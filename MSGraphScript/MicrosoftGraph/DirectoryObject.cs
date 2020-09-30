// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type Directory Object.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class DirectoryObject : Entity
    {
    
		///<summary>
		/// The DirectoryObject constructor
		///</summary>
        public DirectoryObject()
        {
            this.ODataType = "microsoft.graph.directoryObject";
        }

        /// <summary>
        /// Gets or sets deleted date time.
        /// </summary>
        public Date DeletedDateTime;
    
    }
}

