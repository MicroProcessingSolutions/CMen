using Xunit;
using CMen.Library;
using CMen.Functions;
using System.IO;
using CMen.Project;

namespace CMen.Tests
{
    public class ProjectInitTest
    {
        private ProjectInit _init;

        public ProjectInitTest()
        {
            _init = new ProjectInit();
        }

        [Fact]
        public void TestProjectCreation()
        {
            _init.Name = "Test project";
            _init.Author = "Slawomir";

            _init.SaveProject();

            Assert.True(File.Exists(ProjectSaver.CMenProjectText));
        }
    }
}