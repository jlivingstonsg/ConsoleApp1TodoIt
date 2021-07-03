using ConsoleApp1TodoIt.Model;
using Xunit;

namespace TestProject1Todo
{
    public class UnitTest1Todo
    {
        [Theory]
        [InlineData(1, "Commit Changes")]
        public void NormalTest(int todoid, string description)
        {
            Todo t1 = new Todo(todoid, description);
            Assert.Equal("Commit Changes", t1.Description);
            Assert.Equal(1 , t1.TodoID);
        }
    }
}
