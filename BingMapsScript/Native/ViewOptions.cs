// MapOptions.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ViewOptions
    {
        public bool Animate;
        public LocationRect Bounds;
        public Location Center;
        public Point CenterOffset;
        public double Heading;
        public LabelOverlay LabelOverlay;
        public String MapTypeId;
        public double Padding;
        public double Zoom;
    }
}
