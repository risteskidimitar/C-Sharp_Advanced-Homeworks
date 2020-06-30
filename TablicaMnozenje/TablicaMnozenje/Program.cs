using System;
using System.Collections.Generic;
using System.IO;

namespace TablicaMnozenje
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyFile = @"Result.txt";

            List<string> List = new List<string>();
            string Result;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Result = $"{i} * {j} = {i * j}";
                    List.Add(Result);
                    File.WriteAllLines(MyFile, List);
                    Console.WriteLine(Result);
                }
                string line = $"_______________";
                List.Add(line);
                File.WriteAllLines(MyFile, List);
                Console.WriteLine(line);
                
            }


            Console.ReadLine();
        }
    }
}
