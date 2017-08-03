using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Library
{
    public static class BasicSubCommandsGenerator
    {
        public static void Configure(CommandLineApplication application)
        {
            application.Command("new", NewCommand.Configure);
            application.Command("delete", DeleteCommand.Configure);
            application.Command("verify", VerifyCommand.Configure);
        }
    }
}