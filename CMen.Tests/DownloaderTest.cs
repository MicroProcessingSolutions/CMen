using Xunit;
using CMen.ProjectManager;
using System;

namespace CMen.Tests
{
    public class DownloaderTest
    {

        public DownloaderTest()
        {
        }

        [Fact]
        public async void TestVersionGetterCommandLineApplication()
        {
            Version version1;
            Version version2;
            Version.TryParse("1.9.6", out version1);
            Version.TryParse(await CatchFrameworkDownlader.GetLatestVersionInfo(), out version2);

            Assert.True(version2 >= version1);
        }
    }
}