using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Model;
using Xunit;

namespace TestProject1
{
    public class PersonTest
    {
        [Theory]
        [InlineData(null, null)]
        public void NullTest(string Fname, string Lname)
        {
            try
            {
                Person person1 = new Person(Fname, Lname);
                Assert.Equal(Fname, person1.FirstName);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("Empty or only whitespace is not allowed.", ex.Message);
            }
        }
        [Theory]
        [InlineData("Lars", "Persson")]
        public void NormalTest(string Fname, string Lname)
        {
            Person person1 = new Person(Fname, Lname);
            Assert.Equal("Lars", person1.FirstName);
            Assert.Equal("Persson", person1.LastName);
        }
    }
}
