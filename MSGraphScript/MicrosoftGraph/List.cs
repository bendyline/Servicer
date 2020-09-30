// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type List.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class List : BaseItem
    {
    
		///<summary>
		/// The List constructor
		///</summary>
        public List()
        {
            this.ODataType = "microsoft.graph.list";
        }

        /// <summary>
        /// Gets or sets display name.
        /// The displayable title of the list.
        /// </summary>
        public string DisplayName;

        /// <summary>
        /// Gets or sets list.
        /// Provides additional details about the list.
        /// </summary>
        public ListInfo ListInfo;

        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        public SharepointIds SharepointIds;

        /// <summary>
        /// Gets or sets system.
        /// If present, indicates that this is a system-managed list. Read-only.
        /// </summary>
        public SystemFacet System;

        /// <summary>
        /// Gets or sets columns.
        /// The collection of field definitions for this list.
        /// </summary>
        public ListColumn[] Columns;

        /// <summary>
        /// Gets or sets content types.
        /// The collection of content types present in this list.
        /// </summary>
        //public IListContentTypesCollectionPage ContentTypes;

        /// <summary>
        /// Gets or sets drive.
        /// Only present on document libraries. Allows access to the list as a [drive][] resource with [driveItems][driveItem].
        /// </summary>
        //public Drive Drive;

        /// <summary>
        /// Gets or sets items.
        /// All items contained in the list.
        /// </summary>
        // public IListItemsCollectionPage Items;

        /// <summary>
        /// Gets or sets subscriptions.
        /// The set of subscriptions on the list.
        /// </summary>
        //public IListSubscriptionsCollectionPage Subscriptions;
    
    }
}

