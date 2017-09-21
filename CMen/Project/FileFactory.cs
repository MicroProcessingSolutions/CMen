using System;

namespace CMen.Project
{
    public class FileFactory : IFileFactory
    {
        public UInt32 ResourceCounter { get; private set; }

        public FileFactory()
        {
            ResourceCounter = 0;
        }

        public IData CreateFile(CMenFileType type, string name, DirectoryData root)
        {
            FileData file;
            
            switch (type)
            {
                case CMenFileType.Source:
                file = new FileData(".cpp", root);
                break;
                case CMenFileType.Header:
                file = new FileData(".h", root);
                break;
                case CMenFileType.Test:
                file = new FileData(".test.cpp", root);
                break;
                case CMenFileType.Binary:
                throw new NotImplementedException();
                break;
                case CMenFileType.Resource:
                throw new NotImplementedException();
                break;
                case CMenFileType.Document:
                throw new NotImplementedException();
                break;
                case CMenFileType.Text:
                throw new NotImplementedException();
                break;
                case CMenFileType.Other:
                throw new NotImplementedException();
                break;
                default:
                throw new NullReferenceException();
                break;
            }
            
            if(file != null)
            {
                file.Type = type;
                file.Name = name;
            }

            return file;
        }
    }
}