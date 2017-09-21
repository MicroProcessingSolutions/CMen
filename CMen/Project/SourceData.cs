namespace CMen.Project
{
    public class SourceData : IFileData
    {
        public string Extension { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public DirectoryData RootDirectory { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool ShouldBeProcessed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public CMenFileType DataType => throw new System.NotImplementedException();

        public uint ID { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}