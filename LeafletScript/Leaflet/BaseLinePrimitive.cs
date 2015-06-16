using L;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.LeafletMap
{
    public class BaseLinePrimitive : Primitive
    {
        private PathOptions pathOptions;

        private BL.Servicer.MapCore.Color strokeColor;

        protected PathOptions PathOptions
        {
            get
            {
                return this.pathOptions;
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

              //  this.pathOptions.Color = new Color(a, r, g, b);

                this.OnLineStyleUpdated();
            }
        }

        public BaseLinePrimitive(LeafletMap map) : base(map)
        {
            this.pathOptions = new PathOptions();
        }


        protected virtual void OnLineStyleUpdated()
        {
            
        }


        protected virtual void OnVisibilityUpdated()
        {
     //       this.pathOptions.Visible = this.Visible;

            this.OnLineStyleUpdated();
        }
    }
}
