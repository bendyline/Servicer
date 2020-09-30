using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ListLookupColumn
    {
        public bool AllowMultipleValues;
        public bool AllowUnlimitedLength;
        public string ColumnName;
        public string ListId;
        public string PrimaryLookupColumnId;
    }
}
