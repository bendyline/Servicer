// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type SharepointIds.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class SharepointIds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointIds"/> class.
        /// </summary>
        public SharepointIds()
        {
            this.ODataType = "microsoft.graph.sharepointIds";
        }

        /// <summary>
        /// Gets or sets listId.
        /// The unique identifier (guid) for the item's list in SharePoint.
        /// </summary>
        public string ListId;

        /// <summary>
        /// Gets or sets listItemId.
        /// An integer identifier for the item within the containing list.
        /// </summary>
        public string ListItemId;

        /// <summary>
        /// Gets or sets listItemUniqueId.
        /// The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
        /// </summary>
        public string ListItemUniqueId;

        /// <summary>
        /// Gets or sets siteId.
        /// The unique identifier (guid) for the item's site collection (SPSite).
        /// </summary>
        public string SiteId;

        /// <summary>
        /// Gets or sets siteUrl.
        /// The SharePoint URL for the site that contains the item.
        /// </summary>
        public string SiteUrl;

        /// <summary>
        /// Gets or sets tenantId.
        /// The unique identifier (guid) for the tenancy.
        /// </summary>
        public string TenantId;

        /// <summary>
        /// Gets or sets webId.
        /// The unique identifier (guid) for the item's site (SPWeb).
        /// </summary>
        public string WebId;

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
