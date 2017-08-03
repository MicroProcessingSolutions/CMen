using System.Collections.Generic;
using CMen.Project;

namespace CMen.Model
{
    public class PathParserData
    {
        public HashSet<DirectoryData> Directories {get; set;}
        public FileData FoundFile {get; set;}

        public PathParserData()
        {
            Directories = new HashSet<DirectoryData>();
        }
    }
}