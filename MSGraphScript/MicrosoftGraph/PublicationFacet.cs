// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type PublicationFacet.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class PublicationFacet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationFacet"/> class.
        /// </summary>
        public PublicationFacet()
        {
            this.ODataType = "microsoft.graph.publicationFacet";
        }

        /// <summary>
        /// Gets or sets level.
        /// The state of publication for this document. Either published or checkout. Read-only.
        /// </summary>
        public string Level;

        /// <summary>
        /// Gets or sets versionId.
        /// The unique identifier for the version that is visible to the current caller. Read-only.
        /// </summary>
        public string VersionId;

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
