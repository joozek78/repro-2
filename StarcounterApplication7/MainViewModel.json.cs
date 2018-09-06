using System;
using System.Diagnostics;
using Starcounter;
using Starcounter.Startup.Routing;
using Starcounter.XSON;

namespace StarcounterApplication7
{
    [Url("/StarcounterApplication7/Main")]
    public partial class MainViewModel : Json
    {
        public string Scope => AttachedScope.GetHashCode().ToString();
    }
}
