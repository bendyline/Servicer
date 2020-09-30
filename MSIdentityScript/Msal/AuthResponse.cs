using System;
using System.Runtime.CompilerServices;

namespace Msal
{
    public delegate void AuthResponseWithErrorCallback(AuthError error, AuthResponse response);
    public delegate void AuthResponseCallback(AuthResponse response);

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class AuthResponse
    {
        public string UniqueId;
        public string TenantId;
        public string TokenType;
        public string AccessToken;
        public string[] Scopes;
        public Date ExpiresOn;
        public Account Account;
        public string AccountState;
    }
}


