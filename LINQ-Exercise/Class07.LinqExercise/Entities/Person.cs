﻿using Class07.LinqExercise.Entities;
using Class07.LinqExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.LinqExercise
{
    public class Person : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }

        public override string Info()
        {
            return FirstName;
        }
    }
}
