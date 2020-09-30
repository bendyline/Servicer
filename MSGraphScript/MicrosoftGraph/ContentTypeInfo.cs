// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ContentTypeInfo.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class ContentTypeInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTypeInfo"/> class.
        /// </summary>
        public ContentTypeInfo()
        {
            this.ODataType = "microsoft.graph.contentTypeInfo";
        }

        /// <summary>
        /// Gets or sets id.
        /// The id of the content type.
        /// </summary>
        public string Id;

        /// <summary>
        /// Gets or sets name.
        /// The name of the content type.
        /// </summary>
        public string Name;

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
