using System;
using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    public class RootCommand : ICommand
    {
        private CommandLineApplication _app;

        public void Configure(CommandLineApplication command)
        {
            command.Name = "cmen";
            command.Description = "cmen is simple build tool for C/C++";
            command.HelpOption("-?|-h|--help");
            command.Command("project", ProjectCommand.Configure);
            command.Command("class", ClassCommand.Configure);
            command.Command("file", FileCommand.Configure);
            command.Command("check", CheckCommand.Configure);
            command.OnExecute(() =>
            {
                new RootCommand(_app).Run();
                return 0;
            });
        }

        public RootCommand(CommandLineApplication app)
        {
            _app = app;
        }

        public void Run()
        {
            CheckCommand command = new CheckCommand(_app);
            command.Run();

            _app.ShowHelp();
        }
    }
}