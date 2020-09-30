// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type Identity.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class Identity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Identity"/> class.
        /// </summary>
        public Identity()
        {
            this.ODataType = "microsoft.graph.identity";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        /// </summary>
        public string DisplayName;

        /// <summary>
        /// Gets or sets id.
        /// Unique identifier for the identity.
        /// </summary>
        public string Id;

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
