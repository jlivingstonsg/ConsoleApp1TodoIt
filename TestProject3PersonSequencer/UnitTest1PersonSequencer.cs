using ConsoleApp1TodoIt.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject1PersonSequencer
{
    public class UnitTest1PersonSequencer
    {
        [Fact]
        public void PersonIDTest() // 6d
        {
            //First we reset the preson id because it is called some else places in the code too
            //and may be still increased and we won't know how much is it, so we simply reset it to zero
            //and increase by one again and test if its one
            PersonSequencer.Reset();
            int ID = PersonSequencer.NextPersonId();
            Assert.Equal(1, ID);
        }

        [Fact]
        public void ResetTest()
        {
            PersonSequencer.Reset();
        }
    }
}