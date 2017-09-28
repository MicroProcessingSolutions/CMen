using System;
using CMen.Functions;
using CMen.Utils;
using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    class InitProjectCommand : ICommand
    {
        private CommandLineApplication _app;
        private string _name;
        private string _author;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "Project init";

            var nameArgument = application.Argument("[name]", "Name of project");
            var authorArgument = application.Argument("[author]", "Author of project");
            
            application.HelpOption("-?|-h|--help");
            application.OnExecute(() => {
                try
                {
                    InitProjectCommand command = new InitProjectCommand(application, nameArgument.Value, authorArgument.Value);
                    command.Run();
                }
                catch(NullReferenceException)
                {
                    CMenConsole.WriteLine("Bad arguments for init function.");
                }
                return 0;
            });
        }

        public InitProjectCommand(CommandLineApplication app, string name, string author) {

            if(app == null || name == null || author == null)
            {
                throw new NullReferenceException();
            }

            _app = app;
            _name = name;
            _author = author;
        }

        public void Run()
        {
            ProjectInit initer = new ProjectInit();

            initer.Author = _author;
            initer.Name = _name;
            initer.SaveProject();
        }
    }
}