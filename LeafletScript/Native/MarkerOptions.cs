// MapOptions.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace L
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class MarkerOptions
    {
        public String Color;
        public bool Clickable;
        public bool Draggable;
        public bool Keyboard;
        public String Title;
        public String Alt;
        public Number ZIndexOffset;
        public double Opacity;
        public bool RiseOnHover;
        public double RiseOffset;
        public object Icon;
    }
}
