using BL.Serv.Maps;
using BL.Servicer.MapCore;
using L;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.LeafletMap
{
    public class CirclePrimitive : BaseLinePrimitive, ICirclePrimitive
    {
        private Circle circle;
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                this.radius= value;

                this.UpdateCircle();
            }
        }

        internal Circle Circle
        {
            get
            {
                return this.circle;
            }
        }

        public CirclePrimitive(LeafletMap map) : base(map)
        {
            this.circle = Leaflet.CreateCircle(null, this.radius, this.PathOptions);
        }

        protected override void OnLocationUpdated()
        {
            base.OnLocationUpdated();

            this.UpdateCircle();
        }

        protected override void OnLineStyleUpdated()
        {
 	        base.OnLineStyleUpdated();

       //     this.circle.SetOptions(this.PathOptions);
        }

        private void UpdateCircle()
        {            
        }
    }
}
