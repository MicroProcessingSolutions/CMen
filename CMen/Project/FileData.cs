using System;

namespace CMen.Project
{
    public class FileData : IFileData
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public CMenFileType DataType { get; set; }
        public DirectoryData RootDirectory { get; set; }
        public bool ShouldBeProcessed { get; set; }
        public CMenFileType Type { get; set; }

        public FileData(string extension, DirectoryData root)
        {
            Extension = extension;
            RootDirectory = root;
        }

        public override bool Equals (object obj)
        {            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            FileData data = obj as FileData;
            
            if(ID == data.ID)
            {
                return true;
            }
            else return false;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return (int)ID;
        }
    }
}