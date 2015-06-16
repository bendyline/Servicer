// Map.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Html;

namespace L
{
    [IgnoreNamespace]
    [Imported]
    [ScriptName("L")]
    public static class Leaflet
    {

        [ScriptName("map")]
        public static Map CreateMap(Element element, MapOptions options)
        {
            return null;
        }


        [ScriptName("circle")]
        public static Circle CreateCircle(object latLng, double radius, PathOptions options)
        {
            return null;
        }

        [ScriptName("marker")]
        public static Marker CreateMarker(object latLng, MarkerOptions options)
        {
            return null;
        }

        [ScriptName("polyline")]
        public static Polyline CreatePolyline(LatLng[] latLngs, PathOptions options)
        {
            return null;
        }

        [ScriptName("divIcon")]
        public static Icon CreateDivIcon(DivIconOptions iconOptions)
        {
            return null;
        }

        [ScriptName("icon")]
        public static Icon CreateIcon(IconOptions iconOptions)
        {
            return null;
        }

        [ScriptName("latLng")]
        public static LatLng CreateLatLng(double latitude, double longitude)
        {
            return null;
        }

        [ScriptName("latLngBounds")]
        public static LatLngBounds CreateLatLngBounds(LatLng southWest, LatLng northEast)
        {
            return null;
        }

    }
}
