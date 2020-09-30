// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type List Item.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class ListItem : BaseItem
    {
    
		///<summary>
		/// The ListItem constructor
		///</summary>
        public ListItem()
        {
            this.ODataType = "microsoft.graph.listItem";
        }

        /// <summary>
        /// Gets or sets content type.
        /// The content type of this list item
        /// </summary>
        // public ContentTypeInfo ContentType { get; set; }

        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        public SharepointIds SharepointIds;
    
        /// <summary>
        /// Gets or sets analytics.
        /// Analytics about the view activities that took place on this item.
        /// </summary>
        //public ItemAnalytics Analytics { get; set; }
    
        /// <summary>
        /// Gets or sets drive item.
        /// For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]
        /// </summary>
        //public DriveItem DriveItem { get; set; }
    
        /// <summary>
        /// Gets or sets fields.
        /// The values of the columns set on this list item.
        /// </summary>
//        public FieldValueSet Fields { get; set; }
    
        /// <summary>
        /// Gets or sets versions.
        /// The list of previous versions of the list item.
        /// </summary>
//        public IListItemVersionsCollectionPage Versions { get; set; }
    
    }
}

