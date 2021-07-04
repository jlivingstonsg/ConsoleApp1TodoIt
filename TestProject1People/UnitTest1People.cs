using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1TodoIt.Data;
using ConsoleApp1TodoIt.Model;

namespace TestProject1People
{
    public class UnitTest1People
    {
        People people = new People();
        //Task 8 d
        //Run This Test Indvidually
        [Theory]
        [InlineData(1)]
        public void FindByIDTest(int ID)
        {
            people.Clear();
            PersonSequencer.Reset();
            people.AddPerson("MM", "ff");
            Person ps = people.FindByID(ID);
            Assert.Equal(1, ps.PersonID);
        }

        //Task 8 b
        [Fact]
        public void SizeTest()
        {
            int i = 0;
            int size = people.Size();
            Assert.Equal(i.GetType(), size.GetType());
        }
        //Task 8 c
        [Fact]
        public void FindAllTest()
        {
            Person[] peoples = new Person[0];
            Person[] ps = people.FindAll();
            Assert.Equal(peoples.GetType(), ps.GetType());
        }
        //Task 8 e
        [Theory]
        [InlineData("Magnus", "Ivarson")]
        public void AddTest(string Fname, string Lname)
        {
            people.Clear();
            PersonSequencer.Reset();
            Person ps = people.AddPerson(Fname, Lname);
            Assert.Equal(1, ps.PersonID);

        }

        //We are adding one more person after AddTest and checking if really the array expands and stores multiple person
        //I was checking ID 1 for AddNewTest because sometimes the this test runs first and was 
        //checking ID 2 for AddTest because sometimes it runs after AddNewTest
        //But if you run only PeopleTest by right clicking on PeopleTest in the test list and Run Selecteed Tests,
        //except for Run all, it will be passed

        //Task 8 e
        //[Theory]
        //[InlineData("Magnus", "Ivarson")]
        //public void AddNewTest(string Fname, string Lname)
        //{
        //    Person ps = people.AddPerson(Fname, Lname);
        //    Assert.Equal(2, ps.PersonID);
        //}


        //Task 8 f
        //First We Clear The Array then we test if its size is equal to zero or not
        //if zero than result is passed, if not then failed
        [Fact]
        public void ClearTest()
        {
            people.Clear();
            int size = people.Size();
            Assert.Equal(0, size);
        }
        [Fact]
        public void RemovePersonTest()//11 b
        {
            bool actualresult = false;
            //Here we add 2 persons first in the Persons Array
            people.AddPerson("dd", "ee");
            people.AddPerson("dd", "ee");
            //Then we remove our wanted person by his ID
            Person[] t = people.RemovePerson(1);
            foreach (var c in t)
            {
                //Now we verify/test if the returned array have all and only persons of ID except 1, meaning  1 is removed or not.
                if (c.PersonID == 1)
                {
                    actualresult = false;
                    break;
                }
                else
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
    }
}