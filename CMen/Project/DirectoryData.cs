using System;

namespace CMen.Project
{
    public class DirectoryData : IData
    {
        public DirectoryData RootDirectory {get; set;}
        public uint ID { get; set; }
        public string Name { get; set; }
        public CMenFileType Type { get; set; }

        public CMenFileType DataType {get; private set;}
        public CMenAbstractResourceType ResourceType { get; set; }

        public override bool Equals (object obj)
        {            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            DirectoryData data = obj as DirectoryData;
            
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