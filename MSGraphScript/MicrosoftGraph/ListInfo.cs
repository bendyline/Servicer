// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ListInfo.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class ListInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInfo"/> class.
        /// </summary>
        public ListInfo()
        {
            this.ODataType = "microsoft.graph.listInfo";
        }

        /// <summary>
        /// Gets or sets contentTypesEnabled.
        /// If true, indicates that content types are enabled for this list.
        /// </summary>
        public bool? ContentTypesEnabled;

        /// <summary>
        /// Gets or sets hidden.
        /// If true, indicates that the list is not normally visible in the SharePoint user experience.
        /// </summary>
        public bool? Hidden;

        /// <summary>
        /// Gets or sets template.
        /// An enumerated value that represents the base list template used in creating the list. Possible values include documentLibrary, genericList, task, survey, announcements, contacts, and more.
        /// </summary>
        public string Template;

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        public Dictionary<string, object> AdditionalData;

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        public string ODataType;    
    }
}
