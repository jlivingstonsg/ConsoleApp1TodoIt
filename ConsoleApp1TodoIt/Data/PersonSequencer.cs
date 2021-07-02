using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Data
{
    public class PersonSequencer
    {
        private static int personId;
        public static int NextPersonId()
        {
            return personId++;
        }
        public static void PersonReset()
        {
            personId = 0;
        }
    }
}