using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ListColumn
    {
        public string Id;
        public string Name;
        public string Description;
        public string ColumnGroup;
        public string DisplayName;
        public string EnforceUniqueValues;
        public bool Hidden;
        public bool Indexed;
        public bool ReadOnly;
        public bool Required;
        public ListDefaultColumnValue DefaultValue;

        public ListBooleanColumn Boolean;
        public ListCalculatedColumn Calculated;
        public ListChoiceColumn Choice;
        public ListCurrencyColumn Currency;
        public ListDateTimeColumn DateTimee;
        public ListGeolocationColumn Geolocation;
        public ListLookupColumn Lookup;
        public ListNumberColumn Number;
        public ListPersonOrGroupColumn PersonOrGroup;
        public ListTextColumn Text;

        /*
          "currency": { "@odata.type": "microsoft.graph.currencyColumn" },
          "dateTime": { "@odata.type": "microsoft.graph.dateTimeColumn" },
          "defaultValue": { "@odata.type": "microsoft.graph.defaultColumnValue" },
          "geolocation": { "@odata.type": "microsoft.graph.geolocationColumn" },
          "lookup": { "@odata.type": "microsoft.graph.lookupColumn" },
          "number": { "@odata.type": "microsoft.graph.numberColumn" },
          "personOrGroup": { "@odata.type": "microsoft.graph.personOrGroupColumn" },
          "text": { "@odata.type": "microsoft.graph.textColumn" }*/
    }
}
