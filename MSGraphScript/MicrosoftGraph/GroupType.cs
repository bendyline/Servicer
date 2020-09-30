// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The enum GroupType.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    public enum GroupType
    {
    
        /// <summary>
        /// Unified Groups
        /// </summary>
        UnifiedGroups = 0,
	
        /// <summary>
        /// Azure AD
        /// </summary>
        AzureAD = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
