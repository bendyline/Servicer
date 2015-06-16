using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.MapCore
{
    public interface IMarkerPrimitive 
    {
        String HtmlContent { get; set; }

        event MapMouseEventHandler Clicked;

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
