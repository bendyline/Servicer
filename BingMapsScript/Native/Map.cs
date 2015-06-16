// Map.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Html;

namespace Microsoft.Maps
{
    [Imported]
    public class Map
    {

        public EntityCollection Entities;

        public Map(Element element, MapOptions options)
        {
            ;
        }

        public static String GetVersion()
        {
            return null;
        }

        public void Blur()
        {
            ;
        }

        public void Dispose()
        {
            ;
        }

        public void Focus()
        {
            ;
        }

        public LocationRect GetBounds()
        {
            return null;
        }

        public Location GetCenter()
        {
            return null;
        }

        public void GetCopyrights(Action<String[]> a)
        {
            ;
        }


        public void GetCredentials(Action<String> a)
        {
            ;
        }

        public double GetHeading()
        {
            return -1;
        }

        public double GetHeight()
        {
            return -1;
        }


        public String GetImageryId()
        {
            return null;
        }


        public String GetMapTypeId()
        {
            return null;
        }


        public double GetMetersPerPixel()
        {
            return -1;
        }


        public MapMode GetMode()
        {
            return null;
        }

        public Element GetModeLayer()
        {
            return null;
        }

        public MapOptions GetOptions()
        {
            return null;
        }

        public double GetPageX()
        {
            return -1;
        }

        public double GetPageY()
        {
            return -1;
        }

        public Element GetRootElement()
        {
            return null;
        }

        public LocationRect GetTargetBounds()
        {
            return null;
        }

        public Location GetTargetCenter()
        {
            return null;
        }

        public double GetTargetHeading()
        {
            return -1;
        }

        public double GetTargetMetersPerPixel()
        {
            return -1;
        }

        public double GetTargetZoom()
        {
            return -1;
        }

        public Element GetUserLayer()
        {
            return null;
        }

        public double GetViewportX()
        {
            return -1;
        }

        public double GetViewportY()
        {
            return -1;
        }

        public double GetWidth()
        {
            return -1;
        }

        public double GetZoom()
        {
            return -1;
        }


        public Range GetZoomRange()
        {
            return null;
        }


        public bool IsDownloadingTiles()
        {
            return false;
        }

        public bool IsMercator()
        {
            return false;
        }

        public bool IsRotationEnabled()
        {
            return false;
        }

        public void SetMapType(String mapTypeId)
        {
            ;
        }

        public void SetOptions(Size size)
        {

        }

        public void SetView(ViewOptions options)
        {
            ;
        }

        public object TryLocationToPixel(object location, PixelReference reference)
        {
            return null;

        }

        public object TryPixelToLocation(object point, PixelReference reference)
        {
            return null;
        }
    }
}
