using Exercise_AbstractInterFaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_AbstractInterFaces
{
    public class Teacher : User, ITeacher
    {
        public string[] Subjects { get ; set; }

        public void ShowSubjects()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
