using System;
using System.Collections.Generic;
using System.Text;

namespace Dogs
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs { get; set; } = new List<Dog>();

        public static void PrintAll()
        {
            ListOfDogs.ForEach(dog => Console.WriteLine(dog.Name));
        }
    }
}
