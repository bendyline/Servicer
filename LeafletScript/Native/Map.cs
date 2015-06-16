// Map.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Html;

namespace L
{
    [Imported]
    public class Map
    {

        public Map()
        {
            ;
        }

        public LatLng GetCenter()
        {
            return null;
        }

        public double GetZoom()
        {
            return 1;
        }

        public void On(String eventName, Action method)
        {

        }

        public void AddEventListener(String eventName, Action method)
        {

        }
        public void RemoveEventListener(String eventName, Action method)
        {

        }

        public void WhenReady(Action method)
        {

        }

        public Map SetView(LatLng center, double zoom)
        {
            return null;
        }
    }
}
