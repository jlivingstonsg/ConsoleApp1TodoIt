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
            return personId = +1;
        }
        public static void PersonReset()
        {
            personId = 0;
        }
    }
}