// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type Base Item Version.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class BaseItemVersion : Entity
    {
    
		///<summary>
		/// The internal BaseItemVersion constructor
		///</summary>
        protected internal BaseItemVersion()
        {
            // Don't allow initialization of abstract entity types
        }

        /// <summary>
        /// Gets or sets last modified by.
        /// Identity of the user which last modified the version. Read-only.
        /// </summary>
        public IdentitySet LastModifiedBy;

        /// <summary>
        /// Gets or sets last modified date time.
        /// Date and time the version was last modified. Read-only.
        /// </summary>
        public Date LastModifiedDateTime;

        /// <summary>
        /// Gets or sets publication.
        /// Indicates the publication status of this particular version. Read-only.
        /// </summary>
        public PublicationFacet Publication;
    
    }
}

