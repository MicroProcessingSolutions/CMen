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
    }
}