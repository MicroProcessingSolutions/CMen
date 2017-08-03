using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CMen.Utils;

namespace CMen.Project
{
    public class ProjectSaver
    {
        public const string CMenProjectText = "project.cmen";
        public bool SaveProject(ProjectData project, string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            try
            {
                using (StreamWriter writer = new StreamWriter(path + CMenProjectText))
                {
                    using (JsonWriter jsonWriter = new JsonTextWriter(writer))
                    {
                        serializer.Serialize(jsonWriter, project, typeof(ProjectData));
                    }
                }
            }
            catch
            {
                CMenConsole.WriteLine("Unknown error appeared.");
                return false;
            }
            CMenConsole.WriteLine("Project saved.");
            return true;
        }
    }
}