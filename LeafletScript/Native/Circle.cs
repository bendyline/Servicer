// Location.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace L
{
    [Imported]
    public class Circle : Path
    {
        public LatLng GetLatLng()
        {
            return null;
        }

        public double GetRadius()
        {
            return -1;
        }

        public Circle SetLatLng(object latLng)
        {
            return null;
        }

        public Circle SetRadius(double number)
        {
            return null;
        }

        public Path AddTo(Map map)
        {
            return this;
        }
    }
}
