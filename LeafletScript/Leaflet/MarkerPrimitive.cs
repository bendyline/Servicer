using BL.Servicer.MapCore;
using L;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.LeafletMap
{
    public class MarkerPrimitive : Primitive, IMarkerPrimitive
    {
        private Marker marker;
        private MarkerOptions markerOptions;
        private String html;

        public event MapMouseEventHandler Clicked;

        internal Marker Marker
        {
            get
            {
                return this.marker;
            }
        }

        public String HtmlContent
        {
            get
            {
                return this.html;
            }

            set
            {
                this.html = value;
            }
        }

        public MarkerPrimitive(LeafletMap map)
            : base(map)
        {
            this.markerOptions = new MarkerOptions();

            this.marker = Leaflet.CreateMarker(null, this.markerOptions);
        }

        protected override void OnLocationUpdated()
        {
            base.OnLocationUpdated();

        }


        protected override void OnVisibilityUpdated()
        {

        }
    }
}
