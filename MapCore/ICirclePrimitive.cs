using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.MapCore
{
    public interface ICirclePrimitive
    {
        Color StrokeColor { get; set; }

        double Radius { get; set; }

        event MapMouseEventHandler Clicked;

        String Id
        {
            get;
            set;
        }

        bool Visible
        {
            get;
            set;
        }

        object Tag
        {
            get;
            set;
        }

        double Longitude
        {
            get;
            set;
        }

        double Latitude
        {
            get;
            set;
        }

        Location Location
        {
            get;
            set;
        }
    }
}
