using ConsoleApp1TodoIt.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace TestProject1Todo
{
    public class Todo_UnitTest //4c
    {
        [Theory]
        [InlineData(1, "Commit Changes")]
        public void NormalTest(int todoid, string description)
        {
            Todo todo = new Todo(todoid, description);
            Assert.Equal("Commit Changes", todo.Description);
        }
    }
}
