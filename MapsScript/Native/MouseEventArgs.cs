// Location.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    public class MouseEventArgs
    {
        public String EventName;
        public bool Handled;
        public bool IsPrimary;
        public bool IsSecondary;
        public bool IsTouchEvent;
        public object OriginalEvent;
        public double PageX;
        public double PageY;
        public object Target;
        public String TargetType;
        public double WheelDelta;

        public double GetX()
        {
            return -1;
        }

        public double GetY()
        {
            return -1;
        }

    }
}
