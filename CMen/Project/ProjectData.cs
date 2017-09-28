using System;
using System.Collections.Generic;
using System.Collections;

namespace CMen.Project
{
    public class ProjectData : IAbstractResource
    {
        public string ProjectName { get; set; }
        public DateTime CreationTime { get; set; }
        public string Author { get; set; }
        public HashSet<DirectoryData> Directories { get; private set;}
        public HashSet<FileData> Files { get; private set; }
        public HashSet<ClassData> Classes { get; private set; }
        public HashSet<ProjectData> Projects { get; private set; }
        public CMenAbstractResourceType ResourceType { get; private set; }
        public uint ID { get; set; }
        public string Name { get; set; }

        public ProjectData()
        {
            Directories = new HashSet<DirectoryData>();
            Files = new HashSet<FileData>();
            Classes = new HashSet<ClassData>();
            Projects = new HashSet<ProjectData>();
        }

        void AddFile(FileData file)
        {
            Files.Add(file);
        }

        void AddDirectory(DirectoryData directory)
        {
            Directories.Add(directory);
        }

        void AddProject(ProjectData project)
        {
            Projects.Add(project);
        }

        void AddClass(ClassData newClass)
        {
            Classes.Add(newClass);
        }

        public void SetDirectories(IEnumerable<DirectoryData> directories)
        {
            Directories = new HashSet<DirectoryData>(directories);
        }

        public void SetFiles(IEnumerable<FileData> files)
        {
            Files = new HashSet<FileData>(files);
        }
    }
}