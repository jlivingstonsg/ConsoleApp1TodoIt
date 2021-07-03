using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Data
{
    public class PersonSequencer
    {
        //Task 6 a
        static int personId;

        //Task 6 b
        public static int NextPersonId()
        {
            return ++personId;
        }
        //Task 6 c
        public static void Reset()
        {
            personId = 0;
        }
    }
}