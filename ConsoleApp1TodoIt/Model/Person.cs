﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Model
{
    public class Person
    {
        //Task 3a
        readonly int personId;
        string firstName;
        string lastName;

        //Task 3b
        public Person(int pID, string firstName, string lastName)
        {
            //Initializing/creating object.
            this.personId = pID;
            // after Task 3c
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int PersonID
        {
            get
            {
                return personId;
            }
        }

        //Task 3c
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                lastName = value;
            }
        }
    }


}