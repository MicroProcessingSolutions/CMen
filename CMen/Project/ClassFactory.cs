using System;

namespace CMen.Project
{
    public class ClassFactory
    {
        private FileFactory _factory;
        private UInt32 _classCounter = 0;

        public ClassFactory(FileFactory factory)
        {
            _factory = factory;
        }

        public IAbstractResource CreateElement(string className, DirectoryData rootDirectory, bool enableTest = true)
        {
            ClassData actualClass = new ClassData(className);

            try
            {
                actualClass.SetSource(_factory.CreateFile(CMenFileType.Source, className, rootDirectory));
                actualClass.SetHeader(_factory.CreateFile(CMenFileType.Header, className, rootDirectory));
                if(enableTest)
                {
                    actualClass.SetTest(_factory.CreateFile(CMenFileType.Test, className, rootDirectory));
                }
            }
            catch (NotImplementedException exception)
            {
                return null;
            }
            catch
            {
                return null;
            }
            
            return actualClass;
        }
    }
}