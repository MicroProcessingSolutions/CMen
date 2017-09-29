using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Commands
{
    class NewCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.HelpOption("-?|-h|--help");
            application.Description = "Create a resource";
            application.Argument("[name]", "Name of resource");

            application.OnExecute(() => {
                new NewCommand(application).Run();
                return 0;
            });
        }

        public NewCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }
    }
}