using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Servicer.MapCore
{
    public interface IPrimitive
    {
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
