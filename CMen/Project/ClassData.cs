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

        public CMenFileType DataType {get; private set;}

        public FileData SourceFile {get; private set;}
        public FileData HeaderFile {get; private set;}
        public FileData TestFile {get; private set;}
    }
}