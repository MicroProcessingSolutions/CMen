namespace CMen.Project
{
    public class ClassData
    {
        public ClassData(string name)
        {
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