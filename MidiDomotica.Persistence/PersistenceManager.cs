using MidiDomotica.Exchange;
using MidiDomotica.Exchange.UserDataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Persistence
{
    public class PersistenceManager
    {
        private AppDataHandler _appData;
        private DefaultSettings _default;

        private UserDataHandler _userData;

        public PersistenceManager()
        {
            _appData = new AppDataHandler();

            _default = _appData.GetDefaultData();

            _userData = new UserDataHandler(_default.UserDataFolder);
        }

        public DefaultSettings GetDefaultSettings()
        {
            _default = _appData.GetDefaultData();

            return _default;
        }

        public void SaveActionToEvent(string actionName, string eventName, bool notify, params string[] parameters)
        {
            _userData.SaveActionToEvent(actionName, eventName, notify, parameters);
        }

        public void RemoveActionFromEvent(EventSubscriptionData subscription)
        {
            _userData.RemoveActionFromEvent(subscription);
        }

        public IEnumerable<EventSubscriptionData> GetEventSubscriptions()
        {
            return _userData.GetEventSubscriptions();
        }

        public void SetDefaultSettings(DefaultSettings settings)
        {
            _appData.DefaultSettings = settings;
        }
    }
}
