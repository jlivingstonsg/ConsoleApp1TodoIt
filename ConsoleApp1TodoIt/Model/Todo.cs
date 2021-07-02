using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Model
{
    public class Todo
    {
        readonly int todoId;
        string description;
        bool done;
        Person assignee;

        public Todo(int todoId, string description)
        {
            //Initializing/creating object.
            this.todoId = todoId;
            this.description = description;
        }
        //--------------------------
        public int TodoID
        {
            get
            {
                return todoId;
            }
        }
        //----------------------------
        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }
        //--------------------------
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        //---------------------------------
        public Person Assignee
        {
            get
            {
                return assignee;
            }
            set
            {
                assignee = value;
            }
        }



    }

}