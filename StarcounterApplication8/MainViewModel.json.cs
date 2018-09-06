using System;
using System.Diagnostics;
using Starcounter;
using Starcounter.Startup.Routing;
using Starcounter.Startup.Routing.Middleware;
using Starcounter.XSON;

namespace StarcounterApplication8
{
    [Url("/StarcounterApplication8/Main")]
    public partial class MainViewModel : Json
    {
        public string Scope => AttachedScope.GetHashCode().ToString();
    }
}
