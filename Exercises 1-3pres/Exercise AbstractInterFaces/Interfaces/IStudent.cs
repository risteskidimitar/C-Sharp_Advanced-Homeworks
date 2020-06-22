using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_AbstractInterFaces.Interfaces
{
    interface IStudent
    {
        public Dictionary<string, int> Grades { get; set; }
        public void ShowGrades();

    }
}
