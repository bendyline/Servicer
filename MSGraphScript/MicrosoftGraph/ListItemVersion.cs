// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type List Item Version.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class ListItemVersion : BaseItemVersion
    {
    
		///<summary>
		/// The ListItemVersion constructor
		///</summary>
        public ListItemVersion()
        {
            this.ODataType = "microsoft.graph.listItemVersion";
        }

        /// <summary>
        /// Gets or sets fields.
        /// A collection of the fields and values for this version of the list item.
        /// </summary>
        public FieldValueSet Fields;    
    }
}

