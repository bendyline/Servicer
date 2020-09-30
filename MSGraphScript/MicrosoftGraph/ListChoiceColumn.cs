using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ListChoiceColumn
    {
        public bool AllowTextEntry;
        public string[] Choices;
        public string DisplayAs; // "checkBoxes | dropDownMenu | radioButtons"  
    }
}
