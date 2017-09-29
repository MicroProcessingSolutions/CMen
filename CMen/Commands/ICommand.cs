using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Commands
{
    public interface ICommand
    {
        void Run();
    }
}