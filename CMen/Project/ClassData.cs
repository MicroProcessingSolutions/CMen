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

            SourceFile.DataType = CMenFileType.Source;
            HeaderFile.DataType = CMenFileType.Header;
            TestFile.DataType = CMenFileType.Test;

        }

        public uint ID { get; set; }
        public string Name { get; set; }

        public FileData SourceFile;
        public FileData HeaderFile;
        public FileData TestFile;
    }
}