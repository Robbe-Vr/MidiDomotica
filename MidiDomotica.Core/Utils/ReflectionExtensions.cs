using Fasterflect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExtensions
{
    public static class ReflectionExtensions
    {
        public static EventInfo[] GetAllEvents(this Type type)
        {
            List<EventInfo> eventsList = new List<EventInfo>();

            eventsList.AddRange(type.GetEvents(Flags.InstanceAnyVisibility));

            foreach (Type subInterface in type.GetInterfaces())
            {
                eventsList.AddRange(subInterface.GetAllEvents());
            }

            return eventsList.ToArray();
        }

        public static MethodInfo[] GetAllMethods(this Type type)
        {
            List<MethodInfo> methodsList = new List<MethodInfo>();

            methodsList.AddRange(type.GetMethods(Flags.InstanceAnyVisibility));

            foreach (Type subInterface in type.GetInterfaces())
            {
                methodsList.AddRange(subInterface.GetAllMethods());
            }

            return methodsList.ToArray();
        }
    }
}
