using MidiDomotica.Exchange.UserDataClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Persistence
{
    internal class UserDataHandler
    {
        private string _userDataFolder;

        private string _eventSubscriptionsFileName = "EventSubscriptions.json";

        internal UserDataHandler(string userDataFolder)
        {
            _userDataFolder = userDataFolder;

            string filePath = Path.Combine(_userDataFolder, _eventSubscriptionsFileName);

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
        }

        public void SaveActionToEvent(string actionName, string eventName, bool notify, params string[] parameters)
        {
            var subscriptions = GetEventSubscriptions()?.ToList() ?? new List<EventSubscriptionData>();

            subscriptions.Add(
                new EventSubscriptionData()
                {
                    ActionName = actionName,
                    EventName = eventName,
                    Parameters = parameters.ToList(),
                    Notify = notify,
                }
            );

            SaveSubscriptions(subscriptions);
        }

        public void RemoveActionFromEvent(EventSubscriptionData subscription)
        {
            var subscriptions = GetEventSubscriptions()?.ToList() ?? new List<EventSubscriptionData>();

            if (!subscriptions.Remove(subscription))
            {
                subscriptions.Remove(subscriptions.FirstOrDefault(x => { int index = -1; return x.ActionName == subscription.ActionName && x.EventName == subscription.EventName &&
                    x.Parameters.All((p) => { index++; return p == subscription.Parameters[index]; }); }));
            }

            SaveSubscriptions(subscriptions);
        }

        private void SaveSubscriptions(List<EventSubscriptionData> subscriptions)
        {
            EventsListObject listObject = new EventsListObject()
            {
                Subscriptions = subscriptions,
            };

            string filePath = Path.Combine(_userDataFolder, _eventSubscriptionsFileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            JObject settingsJSON = JObject.FromObject(listObject);

            using (StreamWriter file = File.CreateText(filePath))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                writer.Formatting = Formatting.Indented;
                settingsJSON.WriteTo(writer);
            }
        }

        public IEnumerable<EventSubscriptionData> GetEventSubscriptions()
        {
            int retries = 5;
            int delayOnRetry = 1000;
            int tries = 0;

            while (tries < retries)
            {
                try
                {
                    string data = File.ReadAllText(Path.Combine(_userDataFolder, _eventSubscriptionsFileName));

                    EventsListObject eventsListObject = JsonConvert.DeserializeObject<EventsListObject>(data);

                    if (eventsListObject == null) return new List<EventSubscriptionData>();

                    return eventsListObject.Subscriptions;
                }
                catch (Exception e)
                {
                    Trace.WriteLine("Error deserializing json file! Reason: " + e.Message);
                    tries++;
                    Thread.Sleep(delayOnRetry);
                }
            }

            return new List<EventSubscriptionData>();
        }

        private class EventsListObject
        {
            public List<EventSubscriptionData> Subscriptions { get; set; }
        }
    }
}
