using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    class ProjectCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "Project options for CMen";

            BasicSubCommandsGenerator.Configure(application);
            
            application.HelpOption("-?|-h|--help");
            application.OnExecute(() => {
                new ProjectCommand(application).Run();
                return 0;
            });
        }

        public ProjectCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }
    }
}