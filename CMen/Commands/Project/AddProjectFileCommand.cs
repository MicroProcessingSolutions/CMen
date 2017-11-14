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

        private ProjectData _actualProject;

        private ProjectLoader _loader;
        private ProjectSaver _saver;

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
            _loader = new ProjectLoader();
            _actualProject = _loader.LoadProject("./");

            if(_actualProject == null)
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

                _actualProject.AddFile(file);

                _saver = new ProjectSaver();
                _saver.SaveProject(_actualProject, "./");
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