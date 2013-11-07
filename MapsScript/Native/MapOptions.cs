// MapOptions.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class MapOptions
    {
        public Color BackgroundColor;
        public String Credentials;
        public bool CustomizeOverlays;
        public bool EnableClickableLogo;
        public bool DisableBirdseye;
        public bool DisableKeyboardInput;
        public bool DisableMouseInput;
        public bool DisablePanning;
        public bool DisableTouchInput;
        public bool DisableUserInput;
        public bool DisableZooming;
        public bool EnableSearchLogo;
        public bool FixedMapPosition;
        public double Height;
        public double IntertiaIntensity;
        public bool ShowBreadcrumb;
        public bool ShowCopyright;
        public bool ShowDashboard;
        public bool ShowMapTypeSelector;
        public bool ShowScalebar;
        public object BingTheme;
        public int TileBuffer;
        public bool UseIntertia;
        public double Width;
    }
}
