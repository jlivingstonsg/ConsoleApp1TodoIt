using ConsoleApp1TodoIt.Data;
using Xunit;

namespace TestProject1PersonSequencer
{
    public class UnitTest1PersonSequencer
    {
        [Fact]
        public void PersonIDTest()
        {
            var ID = PersonSequencer.NextPersonId();
            Assert.Equal(1, ID);
        }
        [Fact]
        public void ResetTest()
        {
            PersonSequencer.PersonReset();
        }
    }
}
