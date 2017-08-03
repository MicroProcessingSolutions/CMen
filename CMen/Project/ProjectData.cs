using System;
using System.Collections.Generic;

namespace CMen.Project
{
    public class ProjectData
    {
        public string ProjectName { get; set; }
        public DateTime CreationTime { get; set; }
        public string Author { get; set; }
        public HashSet<DirectoryData> Directories { get; set;}
        public HashSet<FileData> Files { get; set; }
    }
}