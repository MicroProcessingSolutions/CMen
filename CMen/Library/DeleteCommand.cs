using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    class DeleteCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.HelpOption("-?|-h|--help");
            application.Description = "Delete a resource";
            application.Argument("[name]", "Name of resource");

            application.OnExecute(() => {
                new DeleteCommand(application).Run();
                return 0;
            });
        }

        public DeleteCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }
    }
}