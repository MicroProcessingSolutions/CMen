using System;
using Microsoft.Extensions.CommandLineUtils;
using CMen.Commands;
using Newtonsoft.Json;

namespace CMen
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandApplicationCreator creator = new CommandApplicationCreator();
            creator.CreateCommandLineApplication("CMen");
            creator.GetCommandLineApplication().Execute(args);
        }
    }
}
