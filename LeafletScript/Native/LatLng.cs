// Location.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace L
{
    [Imported]
    [ScriptName("latLng")]
    public class LatLng
    {
        public LatLng(double latitude, double longitude)
        {

        }

        [ScriptName("lat")]
        public double Latitude;

        [ScriptName("lng")]
        public double Longitude;
    }
}
