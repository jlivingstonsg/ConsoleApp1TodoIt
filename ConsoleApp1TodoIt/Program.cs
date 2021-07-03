﻿using System;
using ConsoleApp1TodoIt.Data;
using ConsoleApp1TodoIt.Model;
//using Person.Model;


namespace ConsoleApp1TodoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            

            People p = new People();
            TodoItems t = new TodoItems();

            bool Run = true;
            while (Run)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;


                    Console.WriteLine("Enter 1 To Add A Person");
                    Console.WriteLine("Enter 2 To Find A Person By ID");
                    Console.WriteLine("Enter 3 To Show All Person");
                    Console.WriteLine("Enter 4 To Show Number of People");
                    Console.WriteLine("Enter 5 To Delete All Person");

                    Console.WriteLine("Enter 6 To Add A Todo Item");
                    Console.WriteLine("Enter 7 To Find A Todo Item By ID");
                    Console.WriteLine("Enter 8 To Show All Todo Item");
                    Console.WriteLine("Enter 9 To Show Number of Todo Items");
                    Console.WriteLine("Enter 10 Delete All Todo Items");

                    Console.WriteLine("Enter 11 Find All Todo Items By Done/Completed Status");
                    Console.WriteLine("Enter 12 Find All Todo Items By Assignee/Person's ID");
                    Console.WriteLine("Enter 13 Find All Todo Items By Assignee/Person");
                    Console.WriteLine("Enter 14 Find All Todo Items Which Are UnAssigned");

                    Console.WriteLine("Enter 15 To Delete A Person from People/List");
                    Console.WriteLine("Enter 16 To Delete A Todo from Todo Items/List");
                    Console.WriteLine("Enter 17 To Exit Menu");
                    Console.WriteLine("--------------------------------------------------- ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        //Task 8 e.
                        case 1:
                            Console.WriteLine("Enter First Name");
                            string Fn = Console.ReadLine();
                            Console.WriteLine("Enter last Name");
                            string Ln = Console.ReadLine();
                            p.AddPerson(Fn, Ln);
                            break;
                        //Task 8 d.
                        case 2:
                            Console.WriteLine("Enter The Person's ID To Find That Person");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            Person pById = p.FindByID(ID);
                            if (pById.PersonID == 0)
                            {
                                Console.WriteLine("Person Does Not Exist In The List.");
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Press Anything To Continue To Menu");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("ID. First Name. Last Name");
                                Console.WriteLine("{0}   {1}          {2}", ID, pById.FirstName, pById.LastName);
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Press Enter To Continue To Menu");
                                Console.ReadLine();
                            }
                            break;
                        //Task 8 c.
                        case 3:
                            Person[] people = p.FindAll();
                            Console.WriteLine("ID. First Name. Last Name");
                            foreach (var d in people)
                            {
                                string id = Convert.ToString(d.PersonID);
                                Console.WriteLine("{0}   {1}          {2}", id, d.FirstName, d.LastName);
                            }
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        //Task 8 b.
                        case 4:
                            string Size = Convert.ToString(p.Size());
                            Console.WriteLine("The Number of People is:{0}", Size);
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        //Task 8 f.    
                        case 5:
                            p.Clear();
                            Console.WriteLine("Deleted\nPress Enter To Continue To Menu");
                            Console.WriteLine("--------------------------------------------------- ");

                            Console.ReadLine();
                            break;

                        //Task 9 e.
                        case 6:
                            Console.WriteLine("Enter Description");
                            string desc = Console.ReadLine();
                            Console.WriteLine("Enter Person's ID to Assign Him This Todo Item");
                            ID = Convert.ToInt32(Console.ReadLine());
                            pById = p.FindByID(ID);
                            if (pById.PersonID == 0)
                            {
                                Console.WriteLine("Person Does Not Exist In The List.\n Added Null/Blank Assignee To This Task");
                                Console.WriteLine("Is This Todo Item Task Completed Or In-Progress ?");
                                Console.WriteLine("Enter 1 For Yes\n Enter 2 For No");
                                var c = Convert.ToInt32(Console.ReadLine());
                                bool donestatus;
                                if (c == 1)
                                {
                                    donestatus = true;
                                }
                                else
                                {
                                    donestatus = false;
                                }
                                t.AddTodo(desc, donestatus, null);
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Todo Item Added\nPress Enter To Continue To Menu");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Is This Todo Item Task Completed Or In-Progress ?");
                                Console.WriteLine("Enter 1 For Yes\n Enter 2 For No");
                                var c = Convert.ToInt32(Console.ReadLine());
                                bool donestatus;
                                if (c == 1)
                                {
                                    donestatus = true;
                                }
                                else
                                {
                                    donestatus = false;
                                }
                                t.AddTodo(desc, donestatus, pById);
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Todo Item Added\nPress Enter To Continue To Menu");
                                Console.ReadLine();
                                //Console.ReadLine();
                            }
                            break;
                        //Task 9 d.
                        case 7:
                            Console.WriteLine("Enter The Todo Item's ID To Find That Todo Item");
                            ID = Convert.ToInt32(Console.ReadLine());
                            Todo tById = t.FindByID(ID);
                            if (tById.TodoID == 0)
                            {
                                Console.WriteLine("Person Does Not Exist In The List.");
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Press Anything To Continue To Menu");
                                Console.ReadLine();
                            }
                            else
                            {
                                string status = Convert.ToString(tById.Done);
                                Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                                Console.WriteLine("{0}   {1}           {2}             {3}", ID, tById.Description, status, tById.Assignee.FirstName);
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Press Enter To Continue To Menu");
                                Console.ReadLine();
                            }
                            break;
                        //Task 9 c.
                        case 8:
                            Todo[] todoitems = t.FindAll();
                            Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                            foreach (var d in todoitems)
                            {
                                var assigFname = "UnAssigned";
                                if (d.Assignee == null)
                                {
                                    assigFname = "UnAssigned";
                                }
                                else
                                {
                                    assigFname = d.Assignee.FirstName;
                                }
                                string id = Convert.ToString(d.TodoID);
                                Console.WriteLine("{0}   {1}           {2}             {3}", id, d.Description, d.Done, assigFname);
                            }
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        //Task 9 b.
                        case 9:
                            Size = Convert.ToString(t.Size());
                            Console.WriteLine("The Number of Todo Items is:{0}", Size);
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        //Task 9 f.    
                        case 10:
                            t.Clear();
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Deleted\nPress Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        //Task 10 a.
                        case 11:
                            Console.WriteLine("Enter The Completed/Status For Which You Want Find Todo Items");
                            Console.WriteLine("Enter 1 For Completed/Done\n Enter 2 For UnComplete/Not Done");
                            var WantedStatus = Convert.ToInt32(Console.ReadLine());
                            bool ds;
                            if (WantedStatus == 1)
                            {
                                ds = true;
                            }
                            else
                            {
                                ds = false;
                            }
                            Todo[] td = t.FindByDoneStatus(ds);
                            Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                            foreach (var d in td)
                            {
                                string id = Convert.ToString(d.TodoID);
                                Console.WriteLine("{0}   {1}           {2}             {3}", id, d.Description, d.Done, d.Assignee.FirstName);
                            }
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        //Task 10 b.
                        case 12:
                            Console.WriteLine("Enter The Assignee's ID For Which You Want Find Todo Items");
                            ID = Convert.ToInt32(Console.ReadLine());

                            td = t.FindByAssignee(ID);
                            Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                            foreach (var d in td)
                            {
                                string id = Convert.ToString(d.TodoID);
                                Console.WriteLine("{0}   {1}           {2}             {3}", id, d.Description, d.Done, d.Assignee.FirstName);
                            }
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        //Task 10 c.
                        case 13:
                            Console.WriteLine("Enter The Assignee's FirstName For Which You Want Find Todo Items");
                            Fn = Console.ReadLine();
                            Console.WriteLine("Enter The Assignee's LastName For Which You Want Find Todo Items");
                            Ln = Console.ReadLine();
                            //We are entering ID which is just fake and will not be used to search
                            //The search will only be made on First Name and Last Name
                            Person asigne = new Person(1, Fn, Ln);
                            td = t.FindByAssignee(asigne);
                            Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                            foreach (var d in td)
                            {
                                string id = Convert.ToString(d.TodoID);
                                Console.WriteLine("{0}   {1}           {2}             {3}", id, d.Description, d.Done, d.Assignee.FirstName);
                            }
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        case 14:
                            td = t.FindUnassignedTodoItems();
                            Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                            foreach (var d in td)
                            {
                                string id = Convert.ToString(d.TodoID);
                                Console.WriteLine("{0}   {1}           {2}             {3}", id, d.Description, d.Done, "UnAssigned");
                            }
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                            break;
                        case 15:
                            Console.WriteLine("Note: After Deleting A Person, Its ID will not be re-assigned to new person.");
                            Console.WriteLine("Enter The Person's ID To Delete That Person");
                            ID = Convert.ToInt32(Console.ReadLine());
                            pById = p.FindByID(ID);
                            if (pById.PersonID == 0)
                            {
                                Console.WriteLine("Person Does Not Exist In The List. Please Enter Correct ID");
                                Console.WriteLine("Press Anything To Continue To Menu");
                                Console.ReadLine();
                            }
                            else
                            {
                                p.RemovePerson(ID);
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Deleted.\nPress Enter To Continue To Menu");
                                Console.ReadLine();
                            }
                            break;
                        case 16:
                            Console.WriteLine("Note: After Deleting A Todo Item, Its ID will not be re-assigned to new Todo Item.");
                            Console.WriteLine("Enter The Todo Item's ID To Delete That Todo Item");
                            ID = Convert.ToInt32(Console.ReadLine());
                            tById = t.FindByID(ID);
                            if (tById.TodoID == 0)
                            {
                                Console.WriteLine("Todo Item Does Not Exist In The List. Please Enter Correct ID");
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Press Anything To Continue To Menu");
                                Console.ReadLine();
                            }
                            else
                            {
                                t.RemoveTodo(ID);
                                Console.WriteLine("--------------------------------------------------- ");
                                Console.WriteLine("Deleted.\nPress Enter To Continue To Menu");
                                Console.ReadLine();
                            }
                            break;
                        case 17:
                            Run = false;
                            break;
                        default:
                            Console.WriteLine("--------------------------------------------------- ");
                            Console.WriteLine("Wrong Choice, Press Enter To Continue To Menu");
                            Console.ReadLine();
                        break;

                    } //  switch (choice)
                    Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------- ");
                    Console.WriteLine(" Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();

                }// try
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------------------------- ");
                    Console.WriteLine(" 2. That is not a valid input!");
                    Console.ResetColor();
                }


                Console.Clear();

            } //    while (Run)

        } //   static void Main(string[] args)



    }
}