using Xunit;
using CMen.Project;
using System;
using System.IO;
using System.Threading;

namespace CMen.Tests
{
    public class ProjectLoaderTest
    {
        private readonly ProjectLoader _loader;
        private readonly ProjectSaver _saver;

        public ProjectLoaderTest()
        {
            _loader = new ProjectLoader();
            _saver = new ProjectSaver();
        }

        [Fact]
        public void TestLoadedProject()
        {
            string actualPath = "./tsave";
            if(!Directory.Exists(actualPath)) Directory.CreateDirectory(actualPath);

            ProjectData project = new ProjectData();
            ProjectData loadedProject;
            project.Author = "Sławomir Kozok";
            project.CreationTime = DateTime.Now;
            project.ProjectName = "CMen";

            _saver.SaveProject(project, actualPath);

            loadedProject = _loader.LoadProject(actualPath);

            Assert.NotNull(loadedProject);

            Assert.Equal(project.Author, loadedProject.Author);
            Assert.True((TimeZoneInfo.ConvertTimeToUtc(project.CreationTime) - TimeZoneInfo.ConvertTimeToUtc(loadedProject.CreationTime)).TotalSeconds < 1);
            Assert.Equal(project.ProjectName, loadedProject.ProjectName);
        }
    }
}