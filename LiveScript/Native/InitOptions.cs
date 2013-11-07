using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WindowsLive
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class InitOptions
    {
        [ScriptName("client_id")]
        public String ClientId;

        [ScriptName("redirect_uri")]
        public String RedirectUri;

        [ScriptName("scope")]
        public String Scope;

        [ScriptName("response_type")]
        public String ResponseType;
    }
}
