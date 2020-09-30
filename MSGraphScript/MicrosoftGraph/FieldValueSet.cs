// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type Field Value Set.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class FieldValueSet : Entity
    {
    
		///<summary>
		/// The FieldValueSet constructor
		///</summary>
        public FieldValueSet()
        {
            this.ODataType = "microsoft.graph.fieldValueSet";
        }	
    }
}

