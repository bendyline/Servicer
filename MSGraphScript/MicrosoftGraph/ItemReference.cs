// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ItemReference.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class ItemReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReference"/> class.
        /// </summary>
        public ItemReference()
        {
            this.ODataType = "microsoft.graph.itemReference";
        }

        /// <summary>
        /// Gets or sets driveId.
        /// Unique identifier of the drive instance that contains the item. Read-only.
        /// </summary>
        public string DriveId;

        /// <summary>
        /// Gets or sets driveType.
        /// Identifies the type of drive. See [drive][] resource for values.
        /// </summary>
        public string DriveType;

        /// <summary>
        /// Gets or sets id.
        /// Unique identifier of the item in the drive. Read-only.
        /// </summary>
        public string Id;

        /// <summary>
        /// Gets or sets name.
        /// The name of the item being referenced. Read-only.
        /// </summary>
        public string Name;

        /// <summary>
        /// Gets or sets path.
        /// Path that can be used to navigate to the item. Read-only.
        /// </summary>
        public string Path;

        /// <summary>
        /// Gets or sets shareId.
        /// A unique identifier for a shared resource that can be accessed via the [Shares][] API.
        /// </summary>
        public string ShareId;

        /// <summary>
        /// Gets or sets sharepointIds.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        public SharepointIds SharepointIds;

        /// <summary>
        /// Gets or sets siteId.
        /// </summary>
        public string SiteId;

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
