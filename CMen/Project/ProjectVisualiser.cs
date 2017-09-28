using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CMen.Utils;
using System.Text;

namespace CMen.Project
{
    public class ProjectVisualiser
    {
        public bool VisualiseProject(ProjectData project, string path)
        {
            StringBuilder builder = new StringBuilder();
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            try
            {
                using (StringWriter writer = new StringWriter(builder))
                {
                    using (JsonTextWriter jsonWriter = new JsonTextWriter(writer))
                    {
                        jsonWriter.Formatting = Formatting.Indented;
                        serializer.Serialize(jsonWriter, project, typeof(ProjectData));
                    }
                }
            }
            catch
            {
                CMenConsole.WriteLine("Unknown error appeared.");
                return false;
            }
            CMenConsole.WriteLine("Project visualisation: " + builder.ToString());
            return true;
        }
    }
}