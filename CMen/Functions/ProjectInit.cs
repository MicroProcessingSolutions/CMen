using System;
using System.Collections.Generic;
using CMen.Project;

namespace CMen.Functions
{
    public class ProjectInit
    {
        private ProjectData _project;
        public ProjectInit()
        {
            _project = new ProjectData();
            _project.CreationTime = DateTime.UtcNow;
        }

        public string Name
        {
            set
            {
                _project.ProjectName = value;
            }
        }

        public string Author
        {
            set
            {
                _project.Author = value;
            }
        }

        public ProjectData GetCreatedProject()
        {
            return _project;
        }

        public bool SaveProject()
        {
            ProjectSaver saver = new ProjectSaver();
            return saver.SaveProject(_project, "./");
        }
    }
}