using System;

namespace CMen.Project
{
    public enum CMenFileType
    {
        Source,
        Header,
        Test,
        Binary,
        Resource,
        Document,
        Text,
        Other
    }

    public interface IFileData : IData
    {
        string Extension { get; }
        DirectoryData RootDirectory { get; }
        bool ShouldBeProcessed { get; }

        bool Equals (object obj);
        
        int GetHashCode();
    }
}