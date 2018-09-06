using System;
using Starcounter;
using Starcounter.Startup;

namespace StarcounterApplication7
{
    class Program
    {
        static void Main()
        {
            DefaultStarcounterBootstrapper.Start(new Startup());
        }
    }
}