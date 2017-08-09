using System;

namespace CMen.Project
{
    public enum CMenFileType
    {
        Source,
        Header,
        Binary,
        Resource,
        Document,
        Text,
        Other
    }

    public class FileData : IData
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public CMenFileType DataType { get; set; }
        public DirectoryData RootDirectory { get; set; }
        public bool ShouldBeProcessed { get; set; }

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