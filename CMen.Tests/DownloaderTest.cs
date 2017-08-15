using Xunit;
using CMen.ProjectManager;
using System;
using System.IO;
using System.Threading;

namespace CMen.Tests
{
    public class DownloaderTest
    {

        public DownloaderTest()
        {
        }

        [Fact]
        public async void TestFrameworkGetter()
        {
            CatchFramework framework = await CatchFrameworkDownlader.GetLatestFramework();
            Assert.NotNull(framework);
        }

        [Fact]
        public async void TestVersionGetter()
        {
            Version version1;
            Version version2;

            //First available version when CMen is developed
            Version.TryParse("1.9.6", out version1);

            Version.TryParse(await CatchFrameworkDownlader.GetLatestVersionInfo(true), out version2);

            Assert.True(version2 >= version1);
        }

        [Fact]
        public async void TestFrameworkSaver()
        {
            CatchFramework framework = await CatchFrameworkDownlader.GetLatestFramework();
            Assert.NotNull(framework);

            string path = "./tsaver";
            if(!Directory.Exists(path)) Directory.CreateDirectory(path);

            CatchFrameworkSaver.SaveFramework(path, framework);

            string entirePath = path + "/" + CatchFramework.CatchFrameworkName;
            bool fileExist = File.Exists(entirePath);

            Assert.True(fileExist);

            if(fileExist)
            {
                File.Delete(entirePath);
            }
        }
    }
}