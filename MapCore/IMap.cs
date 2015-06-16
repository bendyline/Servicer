using System;
using System.Collections.Generic;
using System.Html;
using System.Linq;

namespace BL.Servicer.MapCore
{
    public interface IMap
    {
        event MapMouseEventHandler Clicked;

        Element Element { get ; set;}

        IMarkerPrimitive GetMarkerPrimitiveById(String id);
        ILinePrimitive GetLinePrimitiveById(String id);
        ICirclePrimitive GetCirclePrimitiveById(String id);

        IMarkerPrimitive CreateMarkerPrimitive();
        ICirclePrimitive CreateCirclePrimitive();
        ILinePrimitive CreateLinePrimitive();



        void AddLinePrimitive(ILinePrimitive primtive);
        void RemoveLinePrimitiveById(String id);

        void RemoveLinePrimitive(ILinePrimitive p);
        


        void AddCirclePrimitive(ICirclePrimitive primtive);

        void RemoveCirclePrimitiveById(String id);

        void RemoveCirclePrimitive(ICirclePrimitive p);
        


        void AddMarkerPrimitive(IMarkerPrimitive primtive);

        void RemoveMarkerPrimitiveById(String id);

        void RemoveMarkerPrimitive(IMarkerPrimitive p);



        Location PixelToLocation(Point p);

        void SetView(double latitude, double longitude, int zoomLevel);

    }
}
