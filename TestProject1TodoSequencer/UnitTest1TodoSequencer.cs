using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1TodoIt.Data;

namespace TestProject1TodoSequencer
{
    public class UnitTest1TodoSequencer
    {
        [Fact]
        public void TodoIDTest()
        {
            TodoSequencer.Reset();
            int ID = TodoSequencer.NextTodoId();
            Assert.Equal(1, ID);
        }
        [Fact]
        public void ResetTest()
        {
            TodoSequencer.Reset();
        }
    }
}
