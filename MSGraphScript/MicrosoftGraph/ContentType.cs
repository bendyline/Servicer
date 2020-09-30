// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type Content Type.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class ContentType : Entity
    {
    
		///<summary>
		/// The ContentType constructor
		///</summary>
        public ContentType()
        {
            this.ODataType = "microsoft.graph.contentType";
        }

        /// <summary>
        /// Gets or sets description.
        /// The descriptive text for the item.
        /// </summary>
        public string Description;

        /// <summary>
        /// Gets or sets group.
        /// The name of the group this content type belongs to. Helps organize related content types.
        /// </summary>
        public string Group;

        /// <summary>
        /// Gets or sets hidden.
        /// Indicates whether the content type is hidden in the list's 'New' menu.
        /// </summary>
        public bool? Hidden;

        /// <summary>
        /// Gets or sets inherited from.
        /// If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.
        /// </summary>
        public ItemReference InheritedFrom;

        /// <summary>
        /// Gets or sets name.
        /// The name of the content type.
        /// </summary>
        public string Name;

        /// <summary>
        /// Gets or sets order.
        /// Specifies the order in which the content type appears in the selection UI.
        /// </summary>
        public ContentTypeOrder Order;

        /// <summary>
        /// Gets or sets parent id.
        /// The unique identifier of the content type.
        /// </summary>
        public string ParentId;

        /// <summary>
        /// Gets or sets read only.
        /// If true, the content type cannot be modified unless this value is first set to false.
        /// </summary>
        public bool? ReadOnly;

        /// <summary>
        /// Gets or sets sealed.
        /// If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.
        /// </summary>
        public bool? Sealed;

        /// <summary>
        /// Gets or sets column links.
        /// The collection of columns that are required by this content type
        /// </summary>
        //public IContentTypeColumnLinksCollectionPage ColumnLinks;
    
    }
}

