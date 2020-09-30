// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ContentTypeOrder.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class ContentTypeOrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTypeOrder"/> class.
        /// </summary>
        public ContentTypeOrder()
        {
            this.ODataType = "microsoft.graph.contentTypeOrder";
        }

        /// <summary>
        /// Gets or sets default.
        /// Whether this is the default Content Type
        /// </summary>
        public bool? Default;

        /// <summary>
        /// Gets or sets position.
        /// Specifies the position in which the Content Type appears in the selection UI.
        /// </summary>
        public int? Position;

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
