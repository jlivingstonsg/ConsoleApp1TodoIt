using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1TodoIt.Model;

namespace TestProject2Todo
{
    public class UnitTest1Todo
    {
        [Theory]
        [InlineData(1, "Commit Changes")]
        public void NormalTest(int todoid, string description)
        {
            Todo t1 = new Todo(todoid, description);
        }
    }
}
