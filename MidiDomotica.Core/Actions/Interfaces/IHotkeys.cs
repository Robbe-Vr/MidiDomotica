using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.Actions.Interfaces
{
    public interface IHotkeys : IActions
    {
        void PerformKeyPress(string key);

        void PerformKeyPressCombi(params string[] keys);
    }
}
