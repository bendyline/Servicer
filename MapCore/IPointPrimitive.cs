using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.MapCore
{
    public interface IPointPrimitive
    {
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
    }
}
