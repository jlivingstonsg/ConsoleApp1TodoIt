using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Data;
using ConsoleApp1TodoIt.Model;
using Xunit;

namespace TestProject1TodoItems
{
    public class UnitTest1TodoItems
    {
        TodoItems todoItems = new TodoItems();
        [Fact]
        public void SizeTest()
        {
            int i = 0;
            int ps = todoItems.Size();
            Assert.Equal(i.GetType(), ps.GetType());
        }
        //---------------------------
        [Fact]
        public void FindAllTest()
        {
            Todo[] peoples = new Todo[0];
            Todo[] ps = todoItems.FindAll();
            Assert.Equal(peoples.GetType(), ps.GetType());
        }
        //-------------------------------
        [Theory]
        [InlineData(1)]
        public void FindByIDTest(int ID)
        {
            todoItems.Clear();
            TodoSequencer.Reset();

            Person pr = new Person(1, "dd", "ee");
            //To test find by ID, we first store a todo item
            todoItems.AddTodo("mm", true, pr);
            //Then we test to find it by giving its ID
            Todo ps = todoItems.FindByID(ID);
            Assert.Equal(1, ps.TodoID);
        }
        //------------------------------------------------------
        [Theory]
        [InlineData("Todo 1")]
        public void AddTest(string Desc)
        {
            todoItems.Clear();
            TodoSequencer.Reset();
            Person pr = new Person(1, "dd", "ee");
            Todo ps = todoItems.AddTodo(Desc, true, pr);
            Assert.Equal(1, ps.TodoID);
        }
        //-----------------------------------
        [Theory]
        [InlineData(true)]
        public void FindByDoneStatusTest(bool s)
        {
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            //Here we add a person first in the Todo array
            todoItems.AddTodo("DDD", true, pr);
            //Then we find for Todo items which have done status true
            Todo[] t = todoItems.FindByDoneStatus(s);
            foreach (Todo c in t)
            {
                //Now we verify/test if the returned array has all and only true done status todo items
                if (c.Done == s)
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
        [Theory]
        [InlineData(1)]
        public void FindByAssignee(int ID)
        {
            todoItems.Clear();
            TodoSequencer.Reset();
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            todoItems.AddTodo("DDD", true, pr);
            //Then we find for Todo items which have assignee ID equal to 1
            Todo[] t = todoItems.FindByAssignee(ID);
            foreach (Todo c in t)
            {
                //Now we verify/test if the returned array has all and only assignee ID equal to 1 todo items
                Assert.Equal(1, c.Assignee.PersonID);
                if (c.Assignee.PersonID == ID)
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
        //Here we take a Person for input search, (we are not going to add it in the array)
        Person FBA = new Person(1, "dd", "ee");
        [Fact]
        public void FindByAssigneeTest()
        {
            todoItems.Clear();
            TodoSequencer.Reset();
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            //Here we add a person first in the Todo array
            todoItems.AddTodo("DDD", true, pr);
            //Then we find for Todo items which have assignee equal to FBA (Input search data)
            Todo[] t = todoItems.FindByAssignee(FBA);
            foreach (Todo c in t)
            {
                //Now we verify/test if the returned array has all and only assignee equal to FBA (Input search data) todo items
                if ((c.Assignee.FirstName == FBA.FirstName)
                    && (c.Assignee.LastName == FBA.LastName))
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }

        [Fact]
        public void FindByUnAssignedTodoItemsTest()//10 d
        {
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            //Here we add a person first in the Todo array
            todoItems.AddTodo("DDD", true, null);
            //Then we find for Todo items which have assignee equal to FBA (Input search data)
            Todo[] t = todoItems.FindUnassignedTodoItems();
            foreach (Todo c in t)
            {
                //Now we verify/test if the returned array has all and only assignee equal to FBA (Input search data) todo items
                if (c.Assignee == null)
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
        [Fact]
        public void RemoveTodoTest()//11 b
        {
            bool actualresult = false;
            //Here we add 2 todo items first in the todoitems Array
            todoItems.AddTodo("DDD", true, null);
            todoItems.AddTodo("DDD", true, null);
            //Then we remove our wanted todo by its ID
            Todo[] t = todoItems.RemoveTodo(1);
            foreach (Todo c in t)
            {
                //Now we verify/test if the returned array have all and only todoitems of ID except 1, meaning  1 is removed or not.
                if (c.TodoID == 1)
                {
                    actualresult = false;
                    break;
                }
                else
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
    }

}