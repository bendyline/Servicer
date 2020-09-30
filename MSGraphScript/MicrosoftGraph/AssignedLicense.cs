// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type AssignedLicense.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class AssignedLicense
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedLicense"/> class.
        /// </summary>
        public AssignedLicense()
        {
            this.ODataType = "microsoft.graph.assignedLicense";
        }

        /// <summary>
        /// Gets or sets disabledPlans.
        /// A collection of the unique identifiers for plans that have been disabled.
        /// </summary>
        public IEnumerable<string> DisabledPlans;
    
        /// <summary>
        /// Gets or sets skuId.
        /// The unique identifier for the SKU.
        /// </summary>
        public string SkuId;
    
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
