// MapUtilities.cs
//

using BL.Servicer.MapCore;
using System;
using System.Collections.Generic;

namespace BL.Serv.Maps
{
    public class MapUtilities
    {
        private const double EarthsRadius = 6371.009; // earth's mean radius
        private const int MetersPerLatitudeDegree = 111133; // pi * 6,367,444 / 180

        // see http://www.movable-type.co.uk/scripts/latlong.html
        // see http://stackoverflow.com/questions/2637023/how-to-calculate-the-latlng-of-a-point-a-certain-distance-away-from-another


        public double ConvertKmToLatitude(double km)
        {
            return (km * 1000) / MetersPerLatitudeDegree;
        }
        /*
        public double ConvertKmToLongitude(double km, double latitude)
        {
            double radiusAtLatitude = 
            return (km * 1000) / MetersPerLatitudeDegree;
        }*/

        public static double ConvertToRadians(double degrees)
        {
            return (degrees * Math.PI) / 180; 
        }

        public static double ConvertToDegrees(double radians)
        {
            return (radians * 180) / Math.PI;
        }

        public static double GetDistance(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double dLat = ConvertToRadians(latitude2 - latitude1);
            double dLon = ConvertToRadians(longitude2 - longitude1);

            latitude1 = ConvertToRadians(latitude1);
            latitude2 = ConvertToRadians(latitude2);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(latitude1) * Math.Cos(latitude2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return EarthsRadius * c;
        }

        public static Location GetDestination(double latitude1, double longitude1, double distance, double bearing)
        {
            double bearingRad = ConvertToRadians(bearing) ;
            Location newLocation = new Location();

            double angularDistance = distance / EarthsRadius;

            latitude1 = ConvertToRadians(latitude1);
            longitude1 = ConvertToRadians(longitude1);

            newLocation.Latitude = Math.Asin((Math.Sin(latitude1) * Math.Cos(angularDistance)) + (Math.Cos(latitude1) * Math.Sin(angularDistance) * Math.Cos(bearingRad)));
            newLocation.Longitude = longitude1 + Math.Atan2(Math.Sin(bearingRad) * Math.Sin(angularDistance) * Math.Cos(latitude1), Math.Cos(angularDistance) - Math.Sin(latitude1) * Math.Sin(newLocation.Latitude));

            newLocation.Longitude = (newLocation.Longitude + 3 * Math.PI) % (2 * Math.PI) - Math.PI;  // normalize to -180..+180º

            newLocation.Latitude = ConvertToDegrees(newLocation.Latitude);
            newLocation.Longitude= ConvertToDegrees(newLocation.Longitude);
            
            return newLocation;
        }

        public static int GetZoomLevel(double latitude1, double longitude1, double latitude2, double longitude2, double width, double height)
        {
            double horizontalDistance = (GetDistance(latitude1, longitude1, latitude1, longitude2) * 1000) ;
            double verticalDistance = (GetDistance(latitude1, longitude1, latitude2, longitude1) * 1000) ;

            double mediumLatitude = (latitude2 + latitude1) / 2;

            double zoomRange = .15;

            for (int i = 0; i < 20; i++)
            {
                int zoom = 19 - i;

                zoomRange += zoomRange;

                double distanceHorizontal = zoomRange * Math.Cos(mediumLatitude) * width;
                double distanceVertical = zoomRange * height;

                if (distanceHorizontal > horizontalDistance && distanceVertical > verticalDistance)
                {
                    return zoom;
                }
 
            }

            return 1;
        }

        public static int GetBearing(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            latitude1 = ConvertToRadians(latitude1);
            latitude2 = ConvertToRadians(latitude2);

            double dLon = ConvertToRadians(longitude2 - longitude1);

            double y = Math.Sin(dLon) * Math.Cos(latitude2);
            double x = Math.Cos(latitude1) * Math.Sin(latitude2) - Math.Sin(latitude1) * Math.Cos(latitude2) * Math.Cos(dLon);

            return (int)Math.Floor((ToDeg(Math.Atan2(y, x)) + 360) % 360);
        }

        public static double ToDeg(double number)
        {
            return number * 180 / Math.PI;
        }

        public static Location[] CreateCircle(Location loc, double distance)
        {
            Location[] locations = new Location[91];
  
            for (int x=0; x<=360; x+=4)
            {
                Location l = GetDestination(loc.Latitude, loc.Longitude, distance, x);

                locations[x / 4] = l;
            }

            return locations;
        }
    }
}
