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
    public class MapOptions
    {
        public object Center;
        public double Zoom;
        public double MinZoom;
        public double MaxZoom;
        public LatLngBounds MaxBounds;

        public bool Dragging;
        public bool TouchZoom;
        public bool ScrollWheelZoom;
        public bool DoubleClickZoom;
        public bool BoxZoom;
        public bool Tap;
        public double TapTolerance;
        public bool TrackResize;
        public bool WorldCopyJump;
        public bool ClosePopupOnClick;
        public bool BounceAtZoomLimits;
    }
}
