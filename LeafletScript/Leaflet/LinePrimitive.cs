using BL.Servicer.MapCore;
using L;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.LeafletMap
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

        public LinePrimitive(LeafletMap map) : base(map)
        {
            this.polyline = Leaflet.CreatePolyline(null, this.PathOptions);
        }

        protected override void OnLineStyleUpdated()
        {
            base.OnLineStyleUpdated();

            this.polyline.SetStyle(this.PathOptions);
        }

        public void SetPoints(Location[] points)
        {
            Script.Literal("{0}.setLatLngs({1})", polyline, points);
        }
    }
}
