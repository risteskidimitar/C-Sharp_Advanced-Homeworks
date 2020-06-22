using Class07.LinqExercise.Entities;
using Class07.LinqExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.LinqExercise
{
    public class Dog : Base
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, string color, int age, Race race)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
        }
        public override string Info()
        {
            return Name;
        }
    }
}
