// Event.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    public static class Events
    {
        public static object AddHandler(object objectToHandle, String eventName, Action<object> eventHandler)
        {
            return null;
        }
 
        public static object AddThrottledHandler(String eventName, Action<object> eventHandler, int throttleInterval)
        {
            return null;
        }

        public static void Invoke(object objectToInvoke, String eventName, object args)
        {
            return;
        }

        public static bool HasHandler(object objectToCheck, String eventName)
        {
            return false;
        }

        public static void RemoveHandler(object handlerPointer)
        {

        }
    }
}
