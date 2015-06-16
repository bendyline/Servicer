using BL.Servicer.MapCore;
using Microsoft.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.Bing
{
    public abstract class Primitive : IPrimitive
    {
        private String id;
        private BL.Servicer.MapCore.Location location;
        private object tag;
        private bool visible;
        private BingMap map;

        public event MapMouseEventHandler Clicked;

        public BingMap Map
        {
            get
            {
                return this.map;
            }
        }

        public String Id
        {
            get
            {
                if (this.id == null)
                {
                    this.id = CreateRandomId();
                }

                return id;
            }

            set
            {
                this.id = value;
            }
        }

        public double Latitude
        {
            get
            {
                return this.Location.Latitude;
            }

            set
            {
                this.Location.Latitude = value;

                this.OnLocationUpdated();
            }
        }

        public double Longitude
        {
            get
            {
                return this.Location.Longitude;
            }

            set
            {
                this.Location.Longitude = value;

                this.OnLocationUpdated();
            }
        }

        public object Tag
        {
            get
            {
                return this.tag;
            }

            set
            {
                this.tag = value;
            }
        }

        public bool Visible
        {
            get
            {
                return this.visible;
            }
            set
            {
                this.visible = value;

                this.OnVisibilityUpdated();
            }
        }

        public BL.Servicer.MapCore.Location Location
        {
            get
            {
                if (this.location == null)
                {
                    this.location = new BL.Servicer.MapCore.Location();
                }

                return this.location;
            }

            set
            {
                this.location = value;

                this.OnLocationUpdated();
            }
        }

        public Primitive(BingMap map)
        {
            this.map = map;
        }

        public Microsoft.Maps.Location GetBingLocation()
        {
            Microsoft.Maps.Location mml = null;

            Script.Literal("{0}={1}", mml, this.location);

            return mml;
        }

        protected virtual void OnLocationUpdated()
        {

        }

        protected virtual void OnVisibilityUpdated()
        {

        }

        public static String CreateRandomId()
        {
            String id = String.Empty;

            for (int i = 0; i < 6; i++)
            {
                int typeSwitch = Math.Random() % 8;

                if (typeSwitch <= 1 && i > 0)
                {
                    id += String.FromCharCode((Math.Random() % 10) + 48);
                }
                else if (typeSwitch <= 4)
                {
                    id += String.FromCharCode((Math.Random() % 26) + 97);
                }
                else
                {
                    id += String.FromCharCode((Math.Random() % 26) + 65);
                }
            }

            return id;
        }
    }
}
