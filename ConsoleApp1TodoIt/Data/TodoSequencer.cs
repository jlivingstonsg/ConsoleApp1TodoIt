using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Data
{
    public class TodoSequencer
    {
        //Task 7 a.
        private static int TodoId;
        //Task 7 b.
        public static int NextTodoId()
        {
            return ++TodoId;
        }
        //Task 7 c.
        public static void Reset()
        {
            TodoId = 0;
        }
    }
}