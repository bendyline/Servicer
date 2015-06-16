using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BL.Servicer.MapCore
{
    public delegate void MapMouseEventHandler(object sender, MapMouseEventArgs e);

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]    
    public class MapMouseEventArgs
    {
        public double X;
        public double Y;
        public object Target;
    }
}
