namespace CMen.Project
{
    public class ClassData : IData
    {
        public ClassData(string name)
        {
            SourceFile = new FileData();
            HeaderFile = new FileData();
            TestFile = new FileData();

            SourceFile.Name = HeaderFile.Name = TestFile.Name = name;

            SourceFile.Extension = ".cpp";
            TestFile.Extension = ".test.cpp";
            HeaderFile.Extension = ".h";

        }

        public uint ID { get; set; }
        public string Name { get; set; }

        public CMenFileType DataType {get; private set;}

        public FileData SourceFile {get; private set;}
        public FileData HeaderFile {get; private set;}
        public FileData TestFile {get; private set;}
    }
}