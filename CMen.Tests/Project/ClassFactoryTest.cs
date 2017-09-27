using Xunit;
using CMen.Project;
using System;
using System.IO;
using System.Threading;

namespace CMen.Tests.Project
{
    public class ClassFactoryTest
    {

        public ClassFactoryTest()
        {
        }

        [Fact]
        public void ClassFactoryCreationTest()
        {
            const string name = "Example1";

            FileFactory fileFactory = new FileFactory();
            ClassFactory factory = new ClassFactory(fileFactory);

            ClassData exampleClass = (ClassData)factory.CreateElement(name, null);

            Assert.Equal(exampleClass.HeaderFile.Name, name);
            Assert.Equal(exampleClass.SourceFile.Name, name);
            Assert.Equal(exampleClass.TestFile.Name, name);
        }
    }
}