using Class07.LinqExercise.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.LinqExercise
{
    public static class CW_Helper
    {
        public static void MyPrinter<T>(this List<T> list)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------");
        }

        public static void PrintSpecificProperty<T>(this List<T> list) where T : Base
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var item in list)
            {
                Console.WriteLine(item.Info());
            }
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------");
        }

        public static void PrintSpecificProperty<T>(this T item) where T : Base
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(item.Info());
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------");
        }
    }
}
