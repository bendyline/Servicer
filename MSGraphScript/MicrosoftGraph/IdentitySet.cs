// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type IdentitySet.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class IdentitySet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySet"/> class.
        /// </summary>
        public IdentitySet()
        {
            this.ODataType = "microsoft.graph.identitySet";
        }

        /// <summary>
        /// Gets or sets application.
        /// Optional. The application associated with this action.
        /// </summary>
        public IdentityObject Application;

        /// <summary>
        /// Gets or sets device.
        /// Optional. The device associated with this action.
        /// </summary>
        public IdentityObject Device;

        /// <summary>
        /// Gets or sets user.
        /// Optional. The user associated with this action.
        /// </summary>
        public IdentityObject User;

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
