using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Model;


namespace ConsoleApp1TodoIt.Data
{
    public class TodoItems
    {
        //Task 9 a
        private static Todo[] todoitems = new Todo[0];
        //Task 9 b
        public int Size()
        {
            return todoitems.Length;
        }
        //Task 9 c
        public Todo[] FindAll()
        {
            return todoitems;
        }
        //Task 9 d
        public Todo FindByID(int todoid)
        {
            Todo todo = new Todo(0, "MM");
            foreach (Todo people in todoitems)
            {
                if (people.TodoID == todoid)
                {
                    return people;
                }

            }
            return todo;
        }
        //Task 9 e
        public Todo AddTodo(string Desc, bool status, Person pi)
        {
            int size = Size();
            ++size;
            Array.Resize<Todo>(ref todoitems, size);
            int ID = TodoSequencer.NextTodoId();
            Todo people = new Todo(ID, Desc);
            people.Done = status;
            people.Assignee = pi;
            todoitems[size - 1] = people;
            return people;
        }
        //Task 9 f
        public void Clear()
        {
            todoitems = new Todo[0];
        }
        //Task 10 a
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            //here we take new size variable for a new Todo array
            //in which the matching done status items will  be stored
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (Todo todoitemsarray in todoitems)
            {
                if (todoitemsarray.Done == doneStatus)
                {
                    ++size;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = todoitemsarray;
                }
            }
            return ti;
        }
        //Task 10 b
        public Todo[] FindByAssignee(int personid)
        {
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (Todo todoitemsarray in todoitems)
            {
                if (todoitemsarray.Assignee.PersonID == personid)
                {
                    ++size;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = todoitemsarray;
                }
            }
            return ti;
        }
        //Task 10 c
        public Todo[] FindByAssignee(Person assignee)
        {
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (Todo todoitemsarray in todoitems)
            {
                //To check if this person is same as we want, we compare its ID, FirstName and LastName
                if ((todoitemsarray.Assignee.FirstName == assignee.FirstName)
                    && (todoitemsarray.Assignee.LastName == assignee.LastName))
                {
                    ++size;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = todoitemsarray;
                }
            }
            return ti;
        }
        //Task 10 d
        public Todo[] FindUnassignedTodoItems()
        {
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (Todo todoitemsarray in todoitems)
            {
                //To check if this person is same as we want, we compare its ID, FirstName and LastName
                if (todoitemsarray.Assignee == null)
                {
                    ++size;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = todoitemsarray;
                }
            }
            return ti;
        }
        //Task 11 a2
        public Todo[] RemoveTodo(int todoid)//11 a
        {
            int size = 0;
            Todo[] TD = new Todo[0];
            //Here we run a foreach loop on todoitems array
            foreach (Todo people in todoitems)
            {
                //Then we compare our wanted ID with every Todo ID
                if (people.TodoID != todoid)
                {
                    //if its not found then it will be stored in TD array
                    ++size;
                    Array.Resize<Todo>(ref TD, size);
                    TD[size - 1] = people;
                }
            }
            Clear();
            Array.Resize<Todo>(ref todoitems, size);
            //Now we copy TD array to todoitems array
            Array.Copy(TD, todoitems, size);
            //returning TD array
            return TD;
        }
    }
}