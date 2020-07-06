using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new Helper();
            start.DogMethod();


            List<string> JsonList = start.MyReaderLine(@"..\..\..\MyFile\MyJson.json");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<Dog> ObjectListWithDogs = new List<Dog>();
            JsonList.ForEach(d => ObjectListWithDogs.Add(JsonConvert.DeserializeObject<Dog>(d)));
            ObjectListWithDogs.ForEach(dog => Console.WriteLine(dog.Name));

            Console.ReadLine();
        }
    }
}
