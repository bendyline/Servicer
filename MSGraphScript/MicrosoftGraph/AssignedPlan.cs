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
    /// The type AssignedPlan.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class AssignedPlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedPlan"/> class.
        /// </summary>
        public AssignedPlan()
        {
            this.ODataType = "microsoft.graph.assignedPlan";
        }

        /// <summary>
        /// Gets or sets assignedDateTime.
        /// The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        public Date AssignedDateTime;
    
        /// <summary>
        /// Gets or sets capabilityStatus.
        /// For example, 'Enabled'.
        /// </summary>
        public string CapabilityStatus;
    
        /// <summary>
        /// Gets or sets service.
        /// The name of the service; for example, 'Exchange'.
        /// </summary>
        public string Service;
    
        /// <summary>
        /// Gets or sets servicePlanId.
        /// A GUID that identifies the service plan.
        /// </summary>
        public string ServicePlanId;
    
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
