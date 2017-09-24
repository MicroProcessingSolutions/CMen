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

    public enum CMenAbstractResourceType
    {
        File,
        Class,
        Setting
    }

    public interface IFileData : IData
    {
        //Used for checking if file should be compiled once again
        string LastHashCode { get; }
        string Extension { get; }
        DirectoryData RootDirectory { get; }
        bool ShouldBeProcessed { get; }

        bool Equals (object obj);
        
        int GetHashCode();
    }
}