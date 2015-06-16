using BL.Servicer.MapCore;
using Microsoft.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.Maps.Bing
{
    public class HtmlPrimitive : Primitive, IHtmlPrimitive
    {
        private Pushpin pushpin;
        private PushpinOptions pushpinOptions;

        public event MapMouseEventHandler Clicked;

        internal Pushpin Pushpin
        {
            get
            {
                return this.pushpin;
            }
        }

        public String HtmlContent
        {
            get
            {
                return this.pushpinOptions.HtmlContent;
            }

            set
            {
                this.pushpinOptions.HtmlContent = value;

                this.pushpin.SetOptions(this.pushpinOptions);
            }
        }

        public HtmlPrimitive(BingMap map) : base(map)
        {
            this.pushpinOptions = new PushpinOptions();

            this.pushpin = new Pushpin(null, this.pushpinOptions);
            

            Events.AddHandler(this.pushpin, "click", this.HandlePushpinClick);

        }

        private void HandlePushpinClick(object o)
        {
            MouseEventArgs mea = (MouseEventArgs)o;

            if (this.Clicked != null)
            {
                MapMouseEventArgs mmea = new MapMouseEventArgs();
                mmea.X = mea.GetX();
                mmea.Y = mea.GetY();
                mmea.Target = this;
                this.Clicked(this, mmea);
            }
        }

        protected override void OnLocationUpdated()
        {
            base.OnLocationUpdated();

            this.pushpin.SetLocation(this.GetBingLocation());
        }


        protected override void OnVisibilityUpdated()
        {
            this.pushpinOptions.Visible = this.Visible;

            this.pushpin.SetOptions(this.pushpinOptions);
        }
    }
}
