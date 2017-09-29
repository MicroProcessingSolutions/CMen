using CMen.Project;
using CMen.Utils;
using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Commands
{
    class CheckCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "Project existence checker";
            application.HelpOption("-?|-h|--help");
            BasicSubCommandsGenerator.Configure(application);
            application.OnExecute(() => {
                new CheckCommand(application).Run();
                return 0;
            });
        }

        public CheckCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            ProjectLoader loader = new ProjectLoader();
            loader.LoadProject("./");
        }
    }
}