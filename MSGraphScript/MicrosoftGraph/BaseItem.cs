// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type Base Item.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class BaseItem : Entity
    {
    
		///<summary>
		/// The internal BaseItem constructor
		///</summary>
        protected internal BaseItem()
        {
            // Don't allow initialization of abstract entity types
        }

        /// <summary>
        /// Gets or sets created by.
        /// Identity of the user, device, or application which created the item. Read-only.
        /// </summary>
        public IdentitySet CreatedBy;

        /// <summary>
        /// Gets or sets created date time.
        /// Date and time of item creation. Read-only.
        /// </summary>
        public Date CreatedDateTime;

        /// <summary>
        /// Gets or sets description.
        /// Provides a user-visible description of the item. Optional.
        /// </summary>
        public string Description;

        /// <summary>
        /// Gets or sets e tag.
        /// ETag for the item. Read-only.
        /// </summary>
        public string ETag;

        /// <summary>
        /// Gets or sets last modified by.
        /// Identity of the user, device, and application which last modified the item. Read-only.
        /// </summary>
        public IdentitySet LastModifiedBy;

        /// <summary>
        /// Gets or sets last modified date time.
        /// Date and time the item was last modified. Read-only.
        /// </summary>
        public Date LastModifiedDateTime;

        /// <summary>
        /// Gets or sets name.
        /// The name of the item. Read-write.
        /// </summary>
        public string Name;

        /// <summary>
        /// Gets or sets parent reference.
        /// Parent information, if the item has a parent. Read-write.
        /// </summary>
        public ItemReference ParentReference;

        /// <summary>
        /// Gets or sets web url.
        /// URL that displays the resource in the browser. Read-only.
        /// </summary>
        public string WebUrl;

        /// <summary>
        /// Gets or sets created by user.
        /// Identity of the user who created the item. Read-only.
        /// </summary>
        public User CreatedByUser;

        /// <summary>
        /// Gets or sets last modified by user.
        /// Identity of the user who last modified the item. Read-only.
        /// </summary>
        public User LastModifiedByUser;    
    }
}

