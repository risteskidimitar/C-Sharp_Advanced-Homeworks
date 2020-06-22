using System;

namespace Exercise_AbstractInterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class and Interfaces");

            var DimRis = new Student()
            {
                ID = 1,
                Username = "Dimi",
                Password = "123",
                Grades =
                {
                    {"HTML and CSS", 4},{ "JavaScript", 5 },{"C#", 5}
                }
            };
            var Johnnie = new Student()
            {
                ID = 2,
                Username = "johnnie",
                Password = "123",
                Grades =                 {
                    {"HTML and CSS", 5},{ "JavaScript", 4 },{"C#", 3}
                }
            };

            var MyTeacher = new Teacher()
            {
                ID = 3,
                Username = "best_teacher",
                Password = "best",
                Subjects = new string[2] { "JavaScript", "CSharp" }
            };

            var WebDisigner = new Teacher()
            {
                ID = 3,
                Username = "profi",
                Password = "321",
                Subjects = new[] { "HTML", "CSS" }

            };

            DimRis.PrintUser();
            DimRis.ShowGrades();

            MyTeacher.PrintUser();
            MyTeacher.ShowSubjects();

            Johnnie.PrintUser();
            Johnnie.ShowGrades();

            WebDisigner.PrintUser();
            WebDisigner.ShowSubjects();


            Console.ReadLine();
        }
    }
}
