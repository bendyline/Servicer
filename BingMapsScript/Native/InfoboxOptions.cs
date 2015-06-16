using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class InfoboxOptions
    {
        public LabeledAction[] Actions;
        public String Description;
        public double Height;
        public String HtmlContent;
        public String Id;
        public Location Location;
        public Point Offset;
        public bool ShowCloseButton;
        public bool ShowPointer;
        public Pushpin Pushpin;
        public String Title;
        public LabeledAction TitleAction;
        public Action TitleClickHandler;
        public InfoboxType TypeName;
        public bool Visible;
        public double Width;
        public double ZIndex;

    }
}
