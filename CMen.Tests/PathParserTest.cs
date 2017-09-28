using Xunit;
using CMen.Library;
using CMen.Utils;
using CMen.Project;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CMen.Model;

namespace CMen.Tests
{
    public class PathParserTest
    {
        private const int DirectoriesNumber = 5;
        private ProjectData _data;

        public PathParserTest()
        {
            _data = new ProjectData();

            DirectoryData[] directories = new DirectoryData[DirectoriesNumber];
            for(int counter = 0; counter < DirectoriesNumber; counter++)
            {
                directories[counter] = new DirectoryData();

                directories[counter].ID = 1 + (uint)counter;
                directories[counter].Name = "folder" + (counter + 1).ToString();
                if(counter > 0) directories[counter].RootDirectory = directories[counter - 1];
                CMenConsole.WriteLine("Folder created: " + directories[counter].Name);
            }

            _data.SetDirectories(directories.ToHashSet());
            _data.SetFiles(new HashSet<FileData>());
        }

        [Fact]
        void InvalidPathTest()
        {
            Assert.Throws<IOException>(() => PathParser.ParsePath("folder1/folder2/folder3/folderx", _data));
        }

        [Fact]
        void ValidPathTest()
        {
            PathParserData generatedData = new PathParserData();
            generatedData = PathParser.ParsePath("folder1/folder2/folder3", _data);

            HashSet<DirectoryData> data = new HashSet<DirectoryData>();
            data.Add(_data.Directories.Where(x => x.Name == "folder1").First());
            data.Add(_data.Directories.Where(x => x.Name == "folder2").First());
            data.Add(_data.Directories.Where(x => x.Name == "folder3").First());
            HashSet<DirectoryData>.CreateSetComparer().Equals(generatedData.Directories, data);
        }
    }
}