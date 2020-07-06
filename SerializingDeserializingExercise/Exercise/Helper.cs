using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;


namespace Exercise
{
    public class Helper
    {
        private string directoryPath = @"..\..\..\MyFile";
        private string filePath = @"..\..\..\MyFile\MyJson.json";
        public void DogMethod()
        {
            while (true)
            {
                Console.WriteLine(@"If you want to add new dog press ""yes"" or any key to skip");
                string answer = Console.ReadLine();
                if (answer == "YES" || answer == "yes")
                {
                    Console.WriteLine("Please enter a Dog`s properies");
                    Console.WriteLine("Enter a name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("With age ... (press number)");
                    string age = Console.ReadLine();
                    Console.WriteLine("Enter a color: ");
                    string color = Console.ReadLine();

                    Dog dog = new Dog(name, age, color);

                    string newDog = JsonConvert.SerializeObject(dog);
                    MyWriter(filePath, newDog);


                    Console.WriteLine("For exit press: exit");
                    if (Console.ReadLine() == "exit")
                    {
                        break;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("In your json file are written: ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(MyReader(filePath));
                    break;
                }
            }
        }

        public void MyWriter(string path, string json)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(json);
            }
        }

        public string MyReader(string path)
        {
            string result = string.Empty;
            using(StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }

        public List<string> MyReaderLine(string path)
        {
            List<string> result = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line = string.Empty;
                while (line != null)
                {
                    line = sr.ReadLine();
                    if(line == null)
                    {
                        break;
                    }
                    result.Add(line);
                }
            }
            return result;
        }


    }
}
