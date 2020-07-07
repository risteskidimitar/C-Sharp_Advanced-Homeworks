using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

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
                    //Console.WriteLine(Result);
                }
                string line = $"_______________";
                List.Add(line);
               // Console.WriteLine(line);
            }

            AsyncWriter(MyFile, List);

            Console.WriteLine("I'm still working!!!");

            Console.ReadLine();
        }
        public static async Task AsyncWriter(string file, List<string> list)
        {
            await File.WriteAllLinesAsync(file, list);
            await Task.Run(() => 
            {
                Thread.Sleep(3000);              
                list.ForEach(l => Console.WriteLine(l));
            });
         

        }
    }
}
