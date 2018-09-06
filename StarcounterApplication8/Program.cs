using System;
using Starcounter;
using Starcounter.Startup;

namespace StarcounterApplication8
{
    class Program
    {
        static void Main()
        {
            DefaultStarcounterBootstrapper.Start(new Startup());
        }
    }
}