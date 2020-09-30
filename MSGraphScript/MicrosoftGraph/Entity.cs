// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.CompilerServices;


    /// <summary>
    /// The type Entity.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class Entity
    {
    
		///<summary>
		/// The internal Entity constructor
		///</summary>
        protected internal Entity()
        {
            // Don't allow initialization of abstract entity types
        }

        /// <summary>
        /// Gets or sets id.
        /// Read-only.
        /// </summary>
        public string Id;

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        public string ODataType;

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        public Dictionary<string, object> AdditionalData;
    
    }
}

