// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type OnPremisesProvisioningError.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class OnPremisesProvisioningError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnPremisesProvisioningError"/> class.
        /// </summary>
        public OnPremisesProvisioningError()
        {
            this.ODataType = "microsoft.graph.onPremisesProvisioningError";
        }

        /// <summary>
        /// Gets or sets category.
        /// Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
        /// </summary>
        public string Category;
    
        /// <summary>
        /// Gets or sets occurredDateTime.
        /// The date and time at which the error occurred.
        /// </summary>
        public Date OccurredDateTime;
    
        /// <summary>
        /// Gets or sets propertyCausingError.
        /// Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
        /// </summary>
        public string PropertyCausingError;
    
        /// <summary>
        /// Gets or sets value.
        /// Value of the property causing the error.
        /// </summary>
        public string Value;
    
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
