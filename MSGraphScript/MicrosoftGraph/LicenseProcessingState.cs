// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type LicenseProcessingState.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class LicenseProcessingState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseProcessingState"/> class.
        /// </summary>
        public LicenseProcessingState()
        {
            this.ODataType = "microsoft.graph.licenseProcessingState";
        }

        /// <summary>
        /// Gets or sets state.
        /// </summary>
        public string State;
    
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
