using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Exercise
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Dog(string name, string age, string color)
        {
            Name = name;
            Age = int.Parse(age);
            Color = color;
        }

    }
}
