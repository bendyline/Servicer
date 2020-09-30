using System.Runtime.CompilerServices;

namespace Msal
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class AuthResponseFuture
    {
        public AuthResponseFuture Then(AuthResponseCallback callback)
        {
            return this;
        }
        public AuthResponseFuture Catch(AuthResponseCallback callback)
        {
            return this;
        }
    }
}
