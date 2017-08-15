using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    class InitProjectCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "Project init";

            application.Argument("[name]", "Name of project");
            application.Argument("[author]", "Author of project");
            
            application.HelpOption("-?|-h|--help");
            application.OnExecute(() => {
                new InitProjectCommand(application).Run();
                return 0;
            });
        }

        public InitProjectCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }
    }
}