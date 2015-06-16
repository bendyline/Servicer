// MapOptions.cs
//

using BL.Servicer.MapCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace L
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class IconOptions
    {
        public String IconUrl;
        public String IconRetinaUrl;
        public Point IconSize;
        public Point IconAnchor;
        public Point PopupAnchor;
        public String ShadowUrl;
        public String ShadowRetinaUrl;
        public Point ShadowSize;
        public Point ShadowAnchor;
    }
}
