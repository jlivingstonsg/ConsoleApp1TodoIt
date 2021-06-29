using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1TodoIt.Data;

namespace TestProject3PersonSequencer
{
    public class UnitTest1PersonSequencer
    {
        [Fact]
        public void PersonIDTest()
        {
            var ID = PersonSequencer.nextPersonid();
            Assert.Equal(1, ID);
        }
        [Fact]
        public void ResetTest()
        {
            PersonSequencer.reset();
        }
    }
}
