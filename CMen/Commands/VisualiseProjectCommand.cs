using CMen.Project;
using CMen.Utils;
using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Commands
{
    class VisualiseProjectCommand : ICommand
    {
        private CommandLineApplication _app;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "Visualise CMen project";
            
            application.HelpOption("-?|-h|--help");
            application.OnExecute(() => {
                new VisualiseProjectCommand(application).Run();
                return 0;
            });
        }

        public VisualiseProjectCommand(CommandLineApplication app) {
            _app = app;
        }

        public void Run()
        {
            ProjectLoader loader = new ProjectLoader();
            var actualProject = loader.LoadProject("./");

            if(actualProject == null)
            {
                CMenConsole.WriteLine("Project does not exist - cannot show it's tree.");
            }
            else
            {
                ProjectVisualiser visualiser = new ProjectVisualiser();
                visualiser.VisualiseProject(actualProject);
            }
        }
    }
}