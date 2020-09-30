using System.Runtime.CompilerServices;

namespace Msal
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class AuthRequest
    {
        public string Authority;
        public string AuthorityMetadata;
        public string ClaimsRequest;
        public string CorrelationId;
        public string State;
    }
}
