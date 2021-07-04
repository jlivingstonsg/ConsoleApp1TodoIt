using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Model
{
    public class Todo
    {
        //Task 4 a
        private readonly int todoid;
        private string description;
        private bool done;
        private Person assignee;
        //Task 4 b
        public Todo(int todoid, string description)
        {
            this.todoid = todoid;
            this.description = description;
        }
        
        public int TodoID
        {
            get
            {
                return todoid;
            }
        }

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