using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CMen.ProjectManager
{
    public static class CatchFrameworkDownlader
    {
        const string FrameworkInfo = "https://api.github.com/repos/philsquared/Catch/releases/latest";
        const string FrameworkLocation = "https://github.com/philsquared/Catch/releases/download/";
        const string FrameworkFileName = "catch.hpp";
        public static async Task<string> GetLatestVersionInfo()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Repository Checker");
            
            var header = await client.GetStringAsync(FrameworkInfo);
            
            JObject data = JObject.Parse(header);
            
            //Version is contained in `tag_name`
            var version = data["tag_name"].ToString();
            
            return version;
        }

        public static async Task<CatchFramework> GetLatestFramework()
        {
            //CatchFramework testingFramework = new 
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Repository Downloader");

            var frameworkVersion = await GetLatestVersionInfo();
            var frameworkContent = ("v" + (await client.GetStringAsync(FrameworkLocation + frameworkVersion + "/" + FrameworkFileName)));

            return new CatchFramework(frameworkVersion, frameworkContent);
        }
    }
}