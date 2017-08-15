using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CMen.Utils;

namespace CMen.Project
{
    public class ProjectLoader
    {
        public const string CMenProjectText = "project.cmen";
        public ProjectData LoadProject(string path)
        {
            ProjectData project = null;

            try
            {
                using (StreamReader file = File.OpenText(path + CMenProjectText))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Converters.Add(new JavaScriptDateTimeConverter());
                    serializer.NullValueHandling = NullValueHandling.Ignore;
                    project = (ProjectData)serializer.Deserialize(file, typeof(ProjectData));

                    CMenConsole.WriteLine("Project loaded.");
                }
            }
            catch(FileNotFoundException exc)
            {
                CMenConsole.WriteLine("Project file was not found. " + exc.Message);
            }
            catch(ArgumentNullException)
            {
                CMenConsole.WriteLine("Parameter was null.");
            }
            catch(ArgumentException exc)
            {
                CMenConsole.WriteLine("Invalid path. " + exc.Message);
            }
            catch(UnauthorizedAccessException exc)
            {
                CMenConsole.WriteLine("Invalid rights to file. " + exc.Message);
            }
            catch(PathTooLongException)
            {
                CMenConsole.WriteLine("Path was too long.");
            }
            catch(NotSupportedException)
            {
                CMenConsole.WriteLine("Writing this line is not supported.");
            }
            catch(DirectoryNotFoundException)
            {
                CMenConsole.WriteLine("Directory was not found.");
            }
            catch
            {
                CMenConsole.WriteLine("Unknown error appeared.");
            }
            return project;
        }
    }
}