using System.Runtime.CompilerServices;

namespace Msal
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class Config
    {
        public ConfigAuthentication Auth;
        public ConfigCache Cache;
        public ConfigSystem System;
    }
}
