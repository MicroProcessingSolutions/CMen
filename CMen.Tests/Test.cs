using Xunit;
using CMen.Library;

namespace CMen.Tests
{
    public class CreatorTest
    {
        private readonly CommandApplicationCreator _creator;

        public CreatorTest()
        {
            _creator = new CommandApplicationCreator();
        }

        [Fact]
        public void TestNullCommandLineApplication()
        {
            //If inside-application is empty, class should create new one
            Assert.NotNull(_creator.GetCommandLineApplication());
        }
    }
}