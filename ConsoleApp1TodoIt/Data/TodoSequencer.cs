using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        public static int NextTodoId()
        {
            return todoId = +1;
        }
        public static void TodoReset()
        {
            todoId = 0;
        }
    }
}
