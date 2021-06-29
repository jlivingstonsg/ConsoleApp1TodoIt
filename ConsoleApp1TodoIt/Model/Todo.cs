using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Model
{
    public class Todo
    {
        readonly static int todoId;
        string description;
        bool done;
        Person assignee;

        public Todo(int todoId, string description)
        {
            //Initializing/creating object.
            this.TodoId = todoId;
            this.Description = description;
        }

    }

}
