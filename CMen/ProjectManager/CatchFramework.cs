namespace CMen.ProjectManager
{
    public class CatchFramework
    {
        public readonly string Version;
        public readonly string FileContent;

        public CatchFramework(string version, string content)
        {
            Version = version;
            FileContent = content;
        }
    }
}