using Fasterflect;
using MidiDomotica.Core.Actions;
using MidiDomotica.Core.Actions.Interfaces;
using MidiDomotica.Core.Persistence;
using MidiDomotica.Exchange.ControlEvents.Interfaces;
using MidiDomotica.Exchange.UserDataClasses;
using ReflectionExtensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static MidiDomotica.Core.MidiConnection.DeviceConnection;

namespace MidiDomotica.Core.MidiConnection
{
    public class EventSubscriber
    {
        private PersistenceHandler _persistence;
        private IAllActions _actions;

        private IAllEvents _events;

        private static IEnumerable<EventSubscriptionData> _subscriptions;

        public IEnumerable<EventSubscriptionData> Subscriptions { get { return _subscriptions; } }

        private ActionToNotificationMessage actionToNotificationMessage;

        public event EventHandler<NotifyEventArgs> onNotify;

        public EventSubscriber(IAllEvents events, IAllActions actions, PersistenceHandler persistence)
        {
            _events = events;

            _persistence = persistence;

            _actions = actions;

            _subscriptions = _persistence.GetEventSubscriptions() ?? new List<EventSubscriptionData>();

            actionToNotificationMessage = new ActionToNotificationMessage();

            foreach (EventSubscriptionData subscription in _subscriptions)
            {
                EventInfo eventInfo = typeof(IAllEvents).GetAllEvents().FirstOrDefault(x => x.Name == subscription.EventName);
                Type eventType = eventInfo.EventHandlerType.GetGenericArguments()[0];

                MethodInfo methodInfo = typeof(IAllActions).GetAllMethods().FirstOrDefault(x => x.Name == subscription.ActionName);

                var method = typeof(EventSubscriber).GetMethod(nameof(EventSubscriber.Subscribe));
                var genericMethod = method.MakeGenericMethod(eventType);

                bool success = (bool)genericMethod.Invoke(this, new object[] { eventInfo.Name, methodInfo.Name, subscription.Notify, subscription.Parameters.Select(x =>
                    {
                        if (x.StartsWith("AsArray("))
                        {
                            return x.Substring(0, x.Length - 1).Replace("AsArray(", "").Split(new string[] { " + " }, StringSplitOptions.RemoveEmptyEntries) as object[];
                        }
                        else return x as object;
                    }).ToArray()
                });
            }
        }

        public bool AddSubscription<TEventArgs>(string eventName, string actionName, bool notify = false, params object[] parameters)
        {
            if (Subscribe<TEventArgs>(eventName, actionName, notify, parameters))
            {
                _persistence.SaveActionToEvent(actionName, eventName, notify, parameters.Select(x =>
                    {
                        if (x.GetType().Name.EndsWith("[]"))
                            return $"AsArray({String.Join(" + ", (x as object[]).Select(s => s.ToString()))})";
                        else
                            return x.ToString();
                    }).ToArray()
                );

                _subscriptions = _persistence.GetEventSubscriptions();

                return true;
            }

            return false;
        }

        public void Unsubscribe(EventSubscriptionData subscription)
        {
            _persistence.RemoveActionFromEvent(subscription);
        }

        public bool Subscribe<TEventArgs>(string eventName, string actionName, bool notify = false, params object[] parameters)
        {
            try
            {
                MethodInfo eventAddHandler = typeof(IAllEvents).GetAllEvents()
                    .FirstOrDefault(x => x.Name == eventName)?.GetAddMethod(false);
                if (eventAddHandler == null)
                {
                    throw new ArgumentException("Could not find an event by event-name: " + eventName);
                }

                MethodInfo action = typeof(IAllActions).GetAllMethods().FirstOrDefault(x => x.Name == actionName);
                if (action == null)
                {
                    throw new ArgumentException("Could not find an action by action-name: " + actionName);
                }

                List<object> paramsList = parameters.ToList();

                Delegate eventDelegate = new EventHandler<TEventArgs>((object sender, TEventArgs e) =>
                {
                    try
                    {
                        List<object> eventParams = new List<object>(paramsList);

                        for (int i = 0; i < paramsList.Count; i++)
                        {
                            if (paramsList[i].GetType() == typeof(string) &&
                                paramsList[i].ToString().StartsWith("{") && paramsList[i].ToString().EndsWith("}"))
                            {
                                int start = paramsList[i].ToString().IndexOf('(') + 1;
                                int length = paramsList[i].ToString().IndexOf(')') - start;
                                string paramStr = paramsList[i].ToString().Substring(start, length);

                                eventParams[i] = typeof(TEventArgs).GetProperty(paramStr).GetValue(e);
                            }
                        }

                        action.Invoke(_actions, eventParams.ToArray());

                        if (notify)
                        {
                            onNotify.Invoke(this, new NotifyEventArgs()
                            {
                                MessageStringFormat = actionToNotificationMessage[actionName],
                                Params = paramsList.Select(x => x.ToString()).ToArray(),
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMsg = $"Failed to execute command '{actionName}'.\nReason: {ex.Message},\nStackTrace:\n{ex.StackTrace}\nSource: {ex.Source}";
                        Trace.WriteLine(errorMsg);
                        onNotify.Invoke(this, new NotifyEventArgs()
                        {
                            MessageStringFormat = errorMsg,
                            Params = paramsList.Select(x =>
                            {
                                if (x.GetType().Name.EndsWith("[]"))
                                    return String.Join(" + ", (x as object[]).Select(s => s.ToString()));
                                else
                                    return x.ToString();
                            }).ToArray(),
                        });
                    }
                });

                eventAddHandler.Invoke(_events, new object[] {
                    eventDelegate
                });

                return true;
            }
            catch (Exception ex) { return HandleError(ex); }
        }

        private bool HandleError(Exception e)
        {
            Trace.WriteLine("Error attempting to subscribe to an event: " + e.Message);

            return false;
        }
    }
}
