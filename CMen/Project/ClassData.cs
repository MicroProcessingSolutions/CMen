namespace CMen.Project
{
    public class ClassData : IAbstractResource
    {
        public ClassData(string name)
        {
            Name = name;
        }

        public uint ID { get; set; }
        public string Name { get; set; }
        public CMenFileType Type { get; set; }

        public CMenFileType DataType {get; private set;}

        public IFileData SourceFile {get; private set;}
        public IFileData HeaderFile {get; private set;}
        public IFileData TestFile {get; private set;}
        public CMenAbstractResourceType ResourceType { get; set; }

        internal void SetSource(IFileData source)
        {
            SourceFile = source;
        }

        internal void SetHeader(IFileData header)
        {
            HeaderFile = header;
        }

        internal void SetTest(IFileData test)
        {
            TestFile = test;
        }

        public override bool Equals(object obj)
        {
            bool areEqual = true;
            ClassData objectToCompare;
            try
            {
                objectToCompare = (ClassData)obj;

                if(objectToCompare.ID == this.ID)
                {
                    return true;
                }

                areEqual = objectToCompare.Name == this.Name;
                areEqual |= objectToCompare.HeaderFile == this.HeaderFile;
                areEqual |= objectToCompare.SourceFile == this.SourceFile;
                areEqual |= objectToCompare.TestFile == this.TestFile;
                
            }
            catch
            {
                return false;
            }

            return areEqual;
        }
    }
}