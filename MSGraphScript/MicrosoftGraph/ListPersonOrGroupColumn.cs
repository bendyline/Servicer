using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ListPersonOrGroupColumn
    {
        public Boolean AllowMultipleSelection;
        public string DisplayAs; // "account | contentType | created | department | ...",
        public string ChooseFromType; // "peopleAndGroups | peopleOnly"
    }
}
