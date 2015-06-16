// Location.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace L
{
    [Imported]
    public class Polyline : Path
    {
        public LatLng[] GetLatLngs()
        {
            return null;
        }


        public Polyline SetLatLngs(LatLng[] latLngs)
        {
            return null;
        }

        public Path AddTo(Map map)
        {
            return this;
        }
    }
}
