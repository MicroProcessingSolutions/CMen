using System;

namespace CMen.Project
{
    public interface IFileFactory
    {
        UInt32 ResourceCounter { get; }
        IFileData CreateFile(CMenFileType type, string name, DirectoryData root);
    }
}