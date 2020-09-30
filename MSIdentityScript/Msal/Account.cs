using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Msal
{

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]

    public class Account
    {
        public string AccountIdentifier;

        public string Environment;

        public int HashCode;

        public string HomeAccoutnIdentifier;

        public string IdToken;

        public Dictionary<String, object> IdTokenClaims;

        public string Name;

        public string Sid;

        public string UserName;
    }
}
