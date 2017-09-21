namespace CMen.Project
{
    public class ClassData : IData
    {
        public ClassData(string name)
        {
            //FileFactory factory = new FileFactory()
        }

        public uint ID { get; set; }
        public string Name { get; set; }
        public CMenFileType Type { get; set; }

        public FileData SourceFile;
        public FileData HeaderFile;
        public FileData TestFile;
    }
}