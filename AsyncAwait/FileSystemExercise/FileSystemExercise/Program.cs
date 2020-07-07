using System;
using System.IO;
using System.Threading.Tasks;

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
        public static async Task TaskAsyncAwait(string path, bool boolTrue)
        {
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

                using (StreamWriter sw = new StreamWriter(path, boolTrue))
                {
                    await sw.WriteLineAsync(Writer(num1, num2));
                }

                Console.WriteLine("For additional calculation press Y-y or any key for exit");
                string additional = Console.ReadLine();
                if (additional == "Y" || additional == "y")
                {
                    continue;
                }
                break;
            }

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
                File.Create(filePath).Close(); //Ova ne mora StreamWriter-ot sam kreira fajl dokolku ne postoi.             
            }

            TaskAsyncAwait(filePath, true).Wait();

        }
    }
}
