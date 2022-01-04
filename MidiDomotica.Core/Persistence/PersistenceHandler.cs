using MidiDomotica.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiDomotica.Persistence;
using MidiDomotica.Exchange.UserDataClasses;

namespace MidiDomotica.Core.Persistence
{
    public class PersistenceHandler
    {
        private PersistenceManager _persistence;

        public PersistenceHandler()
        {
            _persistence = new PersistenceManager();
        }

        public DefaultSettings GetDefaultSettings()
        {
            return _persistence.GetDefaultSettings();
        }

        public void SaveActionToEvent(string actionName, string eventName, bool notify, params string[] parameters)
        {
            _persistence.SaveActionToEvent(actionName, eventName, notify, parameters);
        }

        public void RemoveActionFromEvent(EventSubscriptionData subscription)
        {
            _persistence.RemoveActionFromEvent(subscription);
        }

        public IEnumerable<EventSubscriptionData> GetEventSubscriptions()
        {
            return _persistence.GetEventSubscriptions();
        }

        public void SetDefaultSettings(DefaultSettings settings)
        {
            _persistence.SetDefaultSettings(settings);
        }
    }
}
