using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Data
{
    class PersonSequencer
    {
        private static int personId;
        public static int nextPersonId()
        {
            return personId = +1;
        }
        public static void reset()
        {
            personId = 0;
        }
    }
}
