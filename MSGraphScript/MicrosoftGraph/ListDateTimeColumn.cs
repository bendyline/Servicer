using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ListDateTimeColumn
    {
        public string DisplayAs; // "default | friendly | standard"
        public string Format; //  "dateOnly | dateTime"
    }
}
