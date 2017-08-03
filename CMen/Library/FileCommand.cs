using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    class FileCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "File options for CMen";
            application.HelpOption("-?|-h|--help");
            
            BasicSubCommandsGenerator.Configure(application);
            
            application.OnExecute(() => {
                new FileCommand(application).Run();
                return 0;
            });
        }

        public FileCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }
    }
}