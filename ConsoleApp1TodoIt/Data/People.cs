using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Model;

namespace ConsoleApp1TodoIt.Data
{
    public class People
    {
        static Person[] peoples = new Person[0];//8a
        public int Size()//8b
        {
            return peoples.Length;
        }
        //----------------------------------
        public Person[] FindAll()//8c
        {
            return peoples;
        }
        //-----------------------------------------
        public Person FindByID(int personid)//8d
        {
            Person person = new Person(1, "_", "_");
            foreach (var p in peoples)
            {
                if (p.PersonID == personid)
                {
                    person = p;
                }

            }
            return person;
        }
        //-------------------------------
        public Person AddPerson(string Fname, string Lname)//8e
        {
            int size = Size();
            ++size;
            Array.Resize<Person>(ref peoples, size);
            int ID = PersonSequencer.NextPersonId();
            Person p = new Person(ID, Fname, Lname);
            peoples[size - 1] = p;
            return p;
        }
        //----------------------------------

        public Person[] RemovePerson(int personid)//11 a
        {
            int size = 0;
            Person[] pps = new Person[0];
            //Here we run a foreach loop on peoples array
            foreach (var p in peoples)
            {
                //Then we compare our wanted ID with every persons ID
                if (p.PersonID != personid)
                {
                    //if its not found then it will be stored in pps array
                    ++size;
                    Array.Resize<Person>(ref pps, size);
                    pps[size - 1] = p;
                }
            }
            //Now we copy pps array to peoples array
            Array.Copy(pps, peoples, size);
            //returning pps array
            return pps;
        }

        //----------------------------------------
        public void Clear()//-------- 8f
        {
            peoples = new Person[0];
        }

    }
}