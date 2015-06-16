using BL.Servicer.MapCore;
using L;
using System;
using System.Collections.Generic;
using System.Html;
using System.Linq;

namespace BL.Servicer.Maps.LeafletMap
{
    public class LeafletMap : IMap
    {
        private Element element;
        private Dictionary<String, LinePrimitive> linePrimitives;
        private Dictionary<String, CirclePrimitive> circlePrimitives;
        private Dictionary<String, MarkerPrimitive> markerPrimitives;
        private Map map;
        private MapOptions mapOptions;

        public event MapMouseEventHandler Clicked;

        public Element Element 
        {
            get
            {
                return this.element;
            }
            set
            {
                this.element = value;

                if (this.map == null)
                {
                    this.map = Leaflet.CreateMap(this.element, this.mapOptions);
                }
            }
        }

        public LeafletMap()
        {
            this.mapOptions = new MapOptions();
            this.circlePrimitives = new Dictionary<string, CirclePrimitive>();
            this.linePrimitives = new Dictionary<string, LinePrimitive>();
            this.markerPrimitives = new Dictionary<string, MarkerPrimitive>();
        }


        public IMarkerPrimitive CreateMarkerPrimitive()
        {
            MarkerPrimitive htp = new MarkerPrimitive(this);

            return htp;
        }

        public ICirclePrimitive CreateCirclePrimitive()
        {
            CirclePrimitive cp = new CirclePrimitive(this);

            return cp;
        }

        public ILinePrimitive CreateLinePrimitive()
        {
            LinePrimitive lp = new LinePrimitive(this);

            return lp;
        }

        public ILinePrimitive GetLinePrimitiveById(String id)
        {
            return this.linePrimitives[id];
        }

        public void AddLinePrimitive(ILinePrimitive primitive)
        {
            this.linePrimitives[primitive.Id] = (LinePrimitive)primitive;

     //       this.map.Entities.Push(((LinePrimitive)primitive).Polyline);
        }

        public void RemoveLinePrimitiveById(String id)
        {
            this.linePrimitives[id] = null;
        }

        public void RemoveLinePrimitive(ILinePrimitive p)
        {
            this.linePrimitives[p.Id] = null;
        }

        public ICirclePrimitive GetCirclePrimitiveById(String id)
        {
            return this.circlePrimitives[id];
        }

        public void AddCirclePrimitive(ICirclePrimitive primitive)
        {
            this.circlePrimitives[primitive.Id] = (CirclePrimitive)primitive;

            ((CirclePrimitive)primitive).Circle.AddTo(this.map);
        }

        public void RemoveCirclePrimitiveById(String id)
        {
            this.circlePrimitives[id] = null;
        }

        public void RemoveCirclePrimitive(ICirclePrimitive p)
        {
            this.circlePrimitives[p.Id] = null;
        }

        public IMarkerPrimitive GetMarkerPrimitiveById(String id)
        {
            return this.markerPrimitives[id];
        }

        public void AddMarkerPrimitive(IMarkerPrimitive primitive)
        {
            this.markerPrimitives[primitive.Id] = (MarkerPrimitive)primitive;

  //          this.map.Entities.Push(((HtmlPrimitive)primitive).Pushpin);
        }

        public void RemoveMarkerPrimitiveById(String id)
        {
            this.markerPrimitives[id] = null;
        }

        public void RemoveMarkerPrimitive(IMarkerPrimitive p)
        {
            this.markerPrimitives[p.Id] = null;
        }

        
        public BL.Servicer.MapCore.Location PixelToLocation(BL.Servicer.MapCore.Point p)
        {
            return null;
        }


        public void SetView(double latitude, double longitude, int zoomLevel)
        {
            LatLng center = Leaflet.CreateLatLng(latitude, longitude);

            this.map.SetView(center, zoomLevel);
        }

    }
}
