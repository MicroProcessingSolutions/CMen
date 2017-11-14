using CMen.Project;
using CMen.Utils;
using Microsoft.Extensions.CommandLineUtils;

namespace CMen.Commands.Project
{
    public class AddProjectFileCommand : ICommand
    {
        private CommandLineApplication _app;
        private string _fileName;
        private string _directoryName;
        private string _extensionName;

        public static void Configure(CommandLineApplication application)
        {
            application.Description = "Adding file to project";
            application.HelpOption("-?|-h|--help");
            
            var fileName = application.Argument("[name]", "Name of file");
            var extension = application.Argument("[extension]", "Extension of file");
            var directory = application.Argument("[directory]", "Directory name");

            application.OnExecute(() => {
                new AddProjectFileCommand(application, fileName.Value, extension.Value, directory.Value).Run();
                return 0;
            });
        }

        public void Run()
        {
            ProjectLoader loader = new ProjectLoader();
            var actualProject = loader.LoadProject("./");

            if(actualProject == null)
            {
                CMenConsole.WriteLine("Project does not exist in actual directory");
            }
            else if(_directoryName == null)
            {
                CMenConsole.WriteLine("Directory name is empty");
            }
            else if(_fileName == null)
            {
                CMenConsole.WriteLine("Filename is empty.");
            }
            else
            {
                FileData file = new FileData(_extensionName, null);

                actualProject.AddFile(file);

                ProjectSaver saver = new ProjectSaver();
                saver.SaveProject(actualProject, "./");
            }
        }

        public AddProjectFileCommand(CommandLineApplication app, string fileName, string extensionName, string directoryName) {
            _app = app;
            _fileName = fileName;
            _directoryName = directoryName;
            _extensionName = extensionName;
        }
    }
}