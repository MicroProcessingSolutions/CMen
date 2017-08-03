using Xunit;

namespace CMen.Tests
{
    public class FileTest
    {

        [Fact]
        public void TestAreFilesEqualCommandLineApplication()
        {
            CMen.Project.FileData file1 = new CMen.Project.FileData();
            CMen.Project.FileData file2 = new CMen.Project.FileData();

            file2.ID = file1.ID = 1;
            file2.Name = file1.Name = "Name";
            file2.Extension = file1.Extension = "ext";
            file2.DataType = file1.DataType = CMen.Project.CMenFileType.Document;
            file2.RootDirectory = file1.RootDirectory = new CMen.Project.DirectoryData();
            file2.ShouldBeProcessed = file1.ShouldBeProcessed = true;

            //Check equality
            Assert.True(file1.Equals(file2));
            Assert.True(file2.Equals(file1));

            file1.ID = 2;

            //With diffrent ID files should be diffrent
            Assert.False(file2.Equals(file1));

            file1.ID = file2.ID;
            file1.Name = "Random";
            file1.ShouldBeProcessed = true;

            //Main property for comparation is ID and Name, other parametres should be ignored, beacuse FileTest will be mainly used in HashSets

            Assert.True(file2.Equals(file1));
        }
    }
}