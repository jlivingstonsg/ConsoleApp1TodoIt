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
            todoItems.Clear();
            TodoSequencer.Reset();
            //Expected Value
            int i = 1;

            //Actual Values
            todoItems.AddTodo("", false, null);
            int ps = todoItems.Size();
            //Type Test
            Assert.Equal(i.GetType(), ps.GetType());
            //Value Test
            Assert.Equal(i, ps);
        }
        //---------------------------
        [Fact]
        public void FindAllTest()
        {
            todoItems.Clear();
            TodoSequencer.Reset();
            //Actuall
            todoItems.AddTodo(" ", false, null);
            Todo[] ps = todoItems.FindAll();
            //Expected
            Todo t = new Todo(1, " ");
            Todo[] todoitems = new Todo[0];
            Assert.Equal(todoitems.GetType(), ps.GetType());
            Assert.Equal(t.TodoID, ps[0].TodoID);
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
            //Retreiving All Null
            Todo[] t = todoItems.FindUnassignedTodoItems();
            foreach (Todo c in t)
            {
                //Checking For Only Null
                if (c.Assignee == null)
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
        //Task 10 d part 2
        [Fact]
        public void FindByUnAssignedTodoItemsTest2()
        {
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            //Here we add a person first in the Todo array which have a person NotNull
            todoItems.AddTodo("DDD", true, pr);
            //Here we add a person first in the Todo array which have a person Null
            todoItems.AddTodo("DDD", true, null);
            //Retreiving All Null (which means any TodoItem with person value NotNull wont be retreived)
            Todo[] t = todoItems.FindUnassignedTodoItems();
            foreach (var c in t)
            {
                //
                if (c.Assignee == null)
                {
                    actualresult = true;
                }
                else
                {
                    actualresult = false;
                    break;
                }
            }
            //Here we Test if it really returned an array with Todoitem with a person value Null or not
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