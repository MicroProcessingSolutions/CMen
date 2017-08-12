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
            Version.TryParse("1.9.6", out version1);
            Version.TryParse(await CatchFrameworkDownlader.GetLatestVersionInfo(true), out version2);

            Assert.True(version2 >= version1);
        }
    }
}