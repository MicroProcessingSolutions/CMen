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

        public bool CreateClass(string className, DirectoryData rootDirectory, bool enableTest = true)
        {
            try
            {
                _factory.CreateFile(CMenFileType.Source, className, rootDirectory);
                _factory.CreateFile(CMenFileType.Header, className, rootDirectory);
                if(enableTest)
                {
                    _factory.CreateFile(CMenFileType.Test, className, rootDirectory);
                }
            }
            catch (NotImplementedException exception)
            {
                return false;
            }
            catch
            {
                return false;
            }
            
            return true;
        }
    }
}