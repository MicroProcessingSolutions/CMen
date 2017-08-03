using Xunit;
using CMen.Project;
using System;
using System.IO;

namespace CMen.Tests
{
    public class ProjectSaverTest
    {
        private readonly ProjectSaver _saver;

        public ProjectSaverTest()
        {
            _saver = new ProjectSaver();
        }

        [Fact]
        public void TestNullCommandLineApplication()
        {
            string actualPath = "./tload";
            if(!Directory.Exists(actualPath)) Directory.CreateDirectory(actualPath);

            string pathToNowhere = "/path/to/nowhere/";

            if(File.Exists(actualPath + ProjectSaver.CMenProjectText))
            {
                File.Delete(actualPath + ProjectSaver.CMenProjectText);
            }

            ProjectData project = new ProjectData();
            project.Author = "Sławomir Kozok";
            project.CreationTime = DateTime.Now;
            project.ProjectName = "CMen";

            Assert.False(_saver.SaveProject(project, pathToNowhere));
            Assert.False(File.Exists(pathToNowhere + ProjectSaver.CMenProjectText));

            Assert.True(_saver.SaveProject(project, actualPath));
            Assert.True(File.Exists(actualPath + ProjectSaver.CMenProjectText));

            if(File.Exists(actualPath + ProjectSaver.CMenProjectText))
            {
                File.Delete(actualPath + ProjectSaver.CMenProjectText);
            }
        }
    }
}