using BL.Servicer.MapCore;
using Microsoft.Maps;
using System;
using System.Collections.Generic;
using System.Html;
using System.Linq;

namespace BL.Servicer.Maps.Bing
{
    public class BingMap : IMap
    {
        private Element element;
        private Dictionary<String, LinePrimitive> linePrimitives;
        private Dictionary<String, CirclePrimitive> circlePrimitives;
        private Dictionary<String, HtmlPrimitive> htmlPrimitives;
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
                    this.map = new Map(this.element, this.mapOptions);
                    Events.AddHandler(map, "click", this.MapClick);
                }
            }
        }

        public String Credentials
        {
            get
            {
                return this.mapOptions.Credentials;
            }
            set
            {
                this.mapOptions.Credentials = value;
            }
        }

        public bool EnableClickableLogo
        {
            get
            {
                return this.mapOptions.EnableClickableLogo;
            }

            set
            {
                this.mapOptions.EnableClickableLogo = value;
            }
        }

        public bool EnableSearchLogo
        {
            get
            {
                return this.mapOptions.EnableSearchLogo;
            }

            set
            {
                this.mapOptions.EnableSearchLogo = value;
            }
        }

        public bool ShowMapTypeSelector
        {
            get
            {
                return this.mapOptions.ShowMapTypeSelector;
            }

            set
            {
                this.mapOptions.ShowMapTypeSelector = value;
            }
        }

        public bool ShowDashboard
        {
            get
            {
                return this.mapOptions.ShowDashboard;
            }

            set
            {
                this.mapOptions.ShowDashboard = value;
            }
        }
/*         MapOptions mo = new MapOptions();
                mo.EnableClickableLogo = false;
                mo.EnableSearchLogo = false;
                mo.ShowMapTypeSelector = false;
                mo.ShowDashboard = false;

                map = new Map(this.Element, mo);
                Events.AddHandler(map, "click", this.MapClick);*/

        public BingMap()
        {
            this.mapOptions = new MapOptions();
            this.circlePrimitives = new Dictionary<string, CirclePrimitive>();
            this.linePrimitives = new Dictionary<string, LinePrimitive>();
            this.htmlPrimitives = new Dictionary<string, HtmlPrimitive>();
        }


        private void MapClick(object data)
        {
            MouseEventArgs mea = (MouseEventArgs)data;

            if (mea.TargetType == "map")
            {
                MapMouseEventArgs mmea = new MapMouseEventArgs();
                mmea.X = mea.GetX();
                mmea.Y = mea.GetY();

                if (this.Clicked != null)
                {
                    this.Clicked(this, mmea);
                }
            }
        }


        public IHtmlPrimitive CreateHtmlPrimitive()
        {
            HtmlPrimitive htp = new HtmlPrimitive(this);

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

            this.map.Entities.Push(((LinePrimitive)primitive).Polyline);
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

            this.map.Entities.Push(((CirclePrimitive)primitive).Polyline);
        }

        public void RemoveCirclePrimitiveById(String id)
        {
            this.circlePrimitives[id] = null;
        }

        public void RemoveCirclePrimitive(ICirclePrimitive p)
        {
            this.circlePrimitives[p.Id] = null;
        }

        public IHtmlPrimitive GetHtmlPrimitiveById(String id)
        {
            return this.htmlPrimitives[id];
        }

        public void AddHtmlPrimitive(IHtmlPrimitive primitive)
        {
            this.htmlPrimitives[primitive.Id] = (HtmlPrimitive)primitive;

            this.map.Entities.Push(((HtmlPrimitive)primitive).Pushpin);
        }

        public void RemoveHtmlPrimitiveById(String id)
        {
            this.htmlPrimitives[id] = null;
        }

        public void RemoveHtmlPrimitive(IHtmlPrimitive p)
        {
            this.htmlPrimitives[p.Id] = null;
        }

        
        public BL.Servicer.MapCore.Location PixelToLocation(BL.Servicer.MapCore.Point p)
        {
            return (BL.Servicer.MapCore.Location)this.map.TryPixelToLocation(p, PixelReference.Control);
        }


        public void SetView(double latitude, double longitude, int zoomLevel)
        {
            ViewOptions vi = new ViewOptions();
            vi.Zoom = zoomLevel;
            
            Microsoft.Maps.Location l = new Microsoft.Maps.Location();
            l.Latitude = latitude;
            l.Longitude = longitude;

            vi.Center = l;
        }

    }
}
