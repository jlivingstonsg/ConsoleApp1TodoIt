using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Model;

namespace ConsoleApp1TodoIt.Data
{
    public class People
    {
        //Task 8 a
        private static Person[] peoples = new Person[0];
        //Task 8 b
        public int Size()
        {
            return peoples.Length;
        }
        //Task 8 c
        public Person[] FindAll()
        {
            return peoples;
        }
        //Task 8 d
        public Person FindByID(int PersonID)
        {
            //We are taking this person because we have to return something at the end if our wanted person is not found
            //To know whether the function returned the person we wanted or this new one, we are setting its ID to 0
            //Because all other persons ID will start form one and we will know if its zero than not found, else if its greater than
            //zero, its found
            Person person = new Person(0, "_", "_");
            //Here we run a foreach loop on peoples array
            foreach (var people in peoples)
            {
                //Then we compare our wanted ID with every persons ID
                if (people.PersonID == PersonID)
                {
                    //if its found then it will be returned
                    return people;
                }
            }
            //else the 0 ID person we created will be returned
            return person;
        }
        //Task 8 e
        public Person AddPerson(string Fname, string Lname)
        {
            int size = Size();
            ++size;
            Array.Resize(ref peoples, size);
            int ID = PersonSequencer.NextPersonId();
            Person person = new Person(ID, Fname, Lname);
            peoples[size - 1] = person;
            return person;
        }
        //Task 8 f
        public void Clear()
        {
            peoples = new Person[0];
        }
        //Task 11 a
        public Person[] RemovePerson(int personid)
        {
            int size = 0;
            Person[] pps = new Person[0];
            //Here we run a foreach loop on peoples array
            foreach (var people in peoples)
            {
                //Then we compare our wanted ID with every persons ID
                if (people.PersonID != personid)
                {
                    //if its not found then it will be stored in pps array
                    ++size;
                    Array.Resize<Person>(ref pps, size);
                    pps[size - 1] = people;
                }
            }
            Clear();
            Array.Resize<Person>(ref peoples, size);
            //Now we copy pps array to peoples array
            Array.Copy(pps, peoples, size);
            //returning pps array
            return pps;
        }
    }
}