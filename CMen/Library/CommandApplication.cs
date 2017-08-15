using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    public class CommandApplicationCreator
    {
        private CommandLineApplication _commandApplication;

        public void CreateCommandLineApplication(string name)
        {
            _commandApplication = new CommandLineApplication(throwOnUnexpectedArg: true);
            RootCommand rootCommand = new RootCommand(_commandApplication);
            rootCommand.Configure(_commandApplication);
        }

        public CommandLineApplication GetCommandLineApplication()
        {
            return _commandApplication != null ? _commandApplication : new CommandLineApplication(throwOnUnexpectedArg: true);
        }
    }
}