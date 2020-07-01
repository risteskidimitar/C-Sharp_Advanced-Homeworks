using System;
using System.IO;

namespace FileSystemExercise
{
    class Program
    {
        public static string Writer(int num1, int num2)
        {
            var result = $"{num1} + {num2} = {num1 + num2}";
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string directoryPath = Path.Combine(currentDirectory, "Exercise");
            string filePath = Path.Combine(directoryPath, "Calculations.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();              
            }

            StreamWriter sw = new StreamWriter(filePath, true);


            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Hello, please enter two numbers");
                Console.WriteLine("Your first number is... :");

                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    continue;
                }
                Console.WriteLine("Your second number is... :");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    continue;
                }

                sw.WriteLine(Writer(num1, num2));

                Console.WriteLine("For additional calculation press Y-y or any key for exit");
                string additional = Console.ReadLine();
                if (additional == "Y" || additional == "y")
                {
                    continue;
                }
                break;
            }
            sw.Dispose();


        }
    }
}
