using System;

namespace CMen.Project
{
    public class FileFactory
    {
        private UInt32 _resourceCounter = 0;

        public IData CreateFile(CMenFileType type, string name)
        {
            IData file;
            
            switch (type)
            {
                case CMenFileType.Source:
                file = new FileData();
                break;
                case CMenFileType.Header:
                throw new NotImplementedException();
                break;
                case CMenFileType.Test:
                throw new NotImplementedException();
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
            
            if(file != null) file.Type = type;

            return file;
        }
    }
}