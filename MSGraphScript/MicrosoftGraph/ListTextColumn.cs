using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ListTextColumn
    {
        public bool AllowMultipleLines;
        public bool AppendChangesToExistingText;
        public int LinesForEditing;
        public int MaxLength;
        public string TextType; // "plain | richText"
    }
}
