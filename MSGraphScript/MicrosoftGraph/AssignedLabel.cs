// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type AssignedLabel.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class AssignedLabel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedLabel"/> class.
        /// </summary>
        public AssignedLabel()
        {
            this.ODataType = "microsoft.graph.assignedLabel";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// The display name of the label. Read-only.
        /// </summary>
        public string DisplayName;
    
        /// <summary>
        /// Gets or sets labelId.
        /// The unique identifier of the label.
        /// </summary>
        public string LabelId;
    
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
