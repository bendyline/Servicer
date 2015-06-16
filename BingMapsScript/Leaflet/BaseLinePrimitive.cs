using Microsoft.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.Bing
{
    public class BaseLinePrimitive : Primitive
    {
        private PolylineOptions polylineOptions;

        private BL.Servicer.MapCore.Color strokeColor;

        protected PolylineOptions PolylineOptions
        {
            get
            {
                return this.polylineOptions;
            }
        }

        public BL.Servicer.MapCore.Color StrokeColor
        {
            get
            {
                return this.strokeColor;
            }

            set
            {
                this.strokeColor = value;

                byte r = this.strokeColor.R;
                byte a = this.strokeColor.A;
                byte g = this.strokeColor.G;
                byte b = this.strokeColor.B;

                if (Script.IsNullOrUndefined(r))
                {
                    r = 0;
                }

                if (Script.IsNullOrUndefined(g))
                {
                    g = 0;
                }
                if (Script.IsNullOrUndefined(b))
                {
                    b = 0;
                }
                if (Script.IsNullOrUndefined(a))
                {
                    a = 255;
                }

                this.polylineOptions.StrokeColor = new Color(a, r, g, b);

                this.OnLineStyleUpdated();
            }
        }

        public BaseLinePrimitive(BingMap map) : base(map)
        {
            this.polylineOptions = new PolylineOptions();
        }


        protected virtual void OnLineStyleUpdated()
        {
            
        }


        protected virtual void OnVisibilityUpdated()
        {
            this.polylineOptions.Visible = this.Visible;

            this.OnLineStyleUpdated();
        }
    }
}
