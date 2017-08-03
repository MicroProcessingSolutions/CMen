using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    class VerifyCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.HelpOption("-?|-h|--help");
            application.Description = "Verify a resource";
            application.Argument("[name]", "Name of resource");

            application.OnExecute(() => {
                new VerifyCommand(application).Run();
                return 0;
            });
        }

        public VerifyCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }
    }
}