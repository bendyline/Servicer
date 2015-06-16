using BL.Servicer.MapCore;
using Microsoft.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.Bing
{
    public class LinePrimitive : BaseLinePrimitive, ILinePrimitive
    {
        private Polyline polyline;

        internal Polyline Polyline
        {
            get
            {
                return this.polyline;
            }
        }

        public LinePrimitive(BingMap map) : base(map)
        {
            this.polyline = new Polyline(null, this.PolylineOptions);
        }

        protected override void OnLineStyleUpdated()
        {
            base.OnLineStyleUpdated();

            this.polyline.SetOptions(this.PolylineOptions);
        }

        public void SetPoints(BL.Servicer.MapCore.Location[] points)
        {
            Script.Literal("{0}.setLocations({1})", polyline, points);
        }
    }
}
