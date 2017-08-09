using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CMen.ProjectManager
{
    public static class CatchFrameworkDownlader
    {
        const string FrameworkSource = "https://api.github.com/repos/philsquared/Catch/releases/latest";

        public static async Task<string> GetLatestVersionInfo()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Repository Checker");
            
            var header = await client.GetStringAsync(FrameworkSource);
            
            JObject data = JObject.Parse(header);
            
            var version = data["tag_name"].ToString();

            return version.Replace("v", "");
        }
    }
}