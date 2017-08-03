using System.IO;
using System.Linq;
using CMen.Model;
using CMen.Project;

namespace CMen.Utils
{
    public static class PathParser
    {
        public static PathParserData ParsePath(string path, ProjectData project)
        {
            PathParserData parserData = new PathParserData();
            var partedPath = path.Split('/');

            bool doesPathExist = true;

            //To refactor
            foreach(var part in partedPath)
            {
                if(project.Directories.Any(x => x.Name == part))
                {
                    parserData.Directories.Add(project.Directories.Where(x => x.Name == part).First());
                }
                else if(project.Files.Any(x => x.Name == part))
                {
                    if(parserData.FoundFile == null)
                    {
                        parserData.FoundFile = project.Files.Where(x => x.Name == part).First();
                    }
                }
                else
                {
                    throw new IOException("Path not found: " + path + ".");
                }
            }

            return parserData;
        }
    }
}