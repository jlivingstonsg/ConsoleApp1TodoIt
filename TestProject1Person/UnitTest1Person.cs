using System;
using ConsoleApp1TodoIt.Model;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject1Person
{
    public class PersonTest //--- 3.d 
    {
        [Theory]
        [InlineData(1, null, null)]
        public void NullTest(int ID, string Fname, string Lname)
        {
            try
            {
                Person person = new Person(ID, Fname, Lname);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("Empty or only whitespace is not allowed.", ex.Message);
            }
        }

        // assign any values to properties and check if they are being stored
        [Theory]
        [InlineData(1, "Magnus", "Ivarsson")]
        public void NormalTest(int ID, string Fname, string Lname)
        {
            Person person = new Person(ID, Fname, Lname);
            Assert.Equal("Magnus", person.FirstName);
            Assert.Equal("Ivarsson", person.LastName);
        }
    }
}
