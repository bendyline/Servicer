using BL.Serv.Maps;
using BL.Servicer.MapCore;
using Microsoft.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.Bing
{
    public class CirclePrimitive : BaseLinePrimitive, ICirclePrimitive
    {
        private Polyline polyline;
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (this.radius == value)
                {
                    return;
                }

                this.radius= value;

                this.UpdatePolyline();
            }
        }

        internal Polyline Polyline
        {
            get
            {
                return this.polyline;
            }
        }

        public CirclePrimitive(BingMap map) : base(map)
        {
            this.polyline = new Polyline(null, this.PolylineOptions);
        }

        protected override void OnLocationUpdated()
        {
            base.OnLocationUpdated();

            this.UpdatePolyline();
        }

        protected override void OnLineStyleUpdated()
        {
 	        base.OnLineStyleUpdated();

            this.polyline.SetOptions(this.PolylineOptions);
        }

        private void UpdatePolyline()
        {            
            BL.Servicer.MapCore.Location[] radiusCircle = MapUtilities.CreateCircle(this.Location, this.radius);

            Script.Literal("{0}.setLocations({1})", this.polyline, radiusCircle);
        }
    }
}
