using System.Runtime.CompilerServices;

namespace Msal
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ConfigAuthentication
    {
        public string ClientId;
        public string Authority;
        public string RedirectUri;
        public string PostLogoutRedirectUri;
        public bool NavigateToLoginRequestUrl;
    }
}
