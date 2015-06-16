// Location.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;

namespace L
{
    [Imported]
    public delegate void ObjectAction(object item);

    [Imported]
    public class MapEvent
    {
        public Element Target;
    }

    [Imported]
    public class MouseEvent : MapEvent
    {
        [ScriptName("latlng")]
        public LatLng LatLng;
    }
}
