using Exercise_AbstractInterFaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_AbstractInterFaces
{
    public class Student : User, IStudent
    {
        public Dictionary<string, int> Grades { get; set; } = new Dictionary<string, int>();

        public void ShowGrades()
        {
            foreach (var item in Grades)
            {
                Console.WriteLine($"Subject {item.Key} with grade of {item.Value}");
            }

        }
    }
}
