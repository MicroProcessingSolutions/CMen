using System.IO;
namespace CMen.ProjectManager
{
    public static class CatchFrameworkSaver
    {
        public static void SaveFramework(string path, CatchFramework framework)
        {
            if(framework != null && framework.FileContent != null)
            {
                string entirePath = path + "/" + CatchFramework.CatchFrameworkName;
                using (StreamWriter writer = new StreamWriter(entirePath))
                {
                    writer.Write(framework.FileContent);
                }
            }
        }
    }
}