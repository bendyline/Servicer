using System.Runtime.CompilerServices;
using System;

namespace Msal
{
    [Imported]
    public class UserAgentApplication
    {
        public String Authority;
        public int HashCode;
        public string RuntimeType;

        public UserAgentApplication(Config config)
        {

        }

        public AuthResponseCallback AuthResponseCallback;

        public AuthResponseFuture AcquireTokenSilent(TokenRequest request)
        {
            return null;
        }

        public Account GetAccount()
        {
            return null;
        }

        public AuthResponseFuture AcquireTokenPopup(TokenRequest request)
        {
            return null;
        }
        public AuthResponseFuture LoginPopup(LoginRequest request)
        {
            return null;
        }

    }
}
