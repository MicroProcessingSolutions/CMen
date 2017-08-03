using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    class ClassCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "Class options for CMen";
            application.HelpOption("-?|-h|--help");
            BasicSubCommandsGenerator.Configure(application);
            application.OnExecute(() => {
                new ClassCommand(application).Run();
                return 0;
            });
        }

        public ClassCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }
    }
}