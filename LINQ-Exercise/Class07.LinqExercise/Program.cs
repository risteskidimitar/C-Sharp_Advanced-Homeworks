using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Class07.LinqExercise
{

    class Program
    {
        static void Main(string[] args)
        {


            // Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER

            var task1 = DataBase.people.Where(p => p.FirstName.StartsWith('R'))
                                            .OrderByDescending(a => a.Age).ToList();

            var SQLPersonsFirstNamesStartR = (from p in DataBase.people
                                              where p.FirstName.StartsWith('R')
                                              orderby p.Age descending
                                              select p.FirstName).ToList();

            SQLPersonsFirstNamesStartR.MyPrinter();
            task1.PrintSpecificProperty();


            // Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER

            var task2 = DataBase.dogs.Where(d => d.Color == "Brown" && d.Age > 3)
                                        .OrderBy(d => d.Age).Select(d => $"{ d.Name} {d.Age}").ToList();

            var task2SQL = (from d in DataBase.dogs
                            where d.Color == "Brown" && d.Age > 3
                            orderby d.Age
                            select $"{ d.Name} {d.Age}").ToList();

            task2.MyPrinter();


            // Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER

            var task3 = DataBase.people.Where(p => p.Dogs.Count > 2).OrderByDescending(p => p.FirstName).ToList();

            var task3SQL = (from p in DataBase.people
                            where p.Dogs.Count() > 2
                            orderby p.FirstName descending
                            select p).ToList();

            task3SQL.PrintSpecificProperty();


            // Find and print all Freddy`s dogs names older than 1 year

            var task4 = DataBase.people.SingleOrDefault(p => p.FirstName == "Freddy")
                        .Dogs.Where(d => d.Age > 1).Select(d => d.Name).ToList();

            var task4SQL = (from x in DataBase.people
                            where x.FirstName == "Freddy"
                            from d in x.Dogs
                            where d.Age > 1
                            select d.Name).ToList();

            task4.MyPrinter();
    

            // Find and print Nathen`s first dog

            var task5 = DataBase.people.SingleOrDefault(p => p.FirstName == "Nathen").Dogs.FirstOrDefault();

            var task5SQL = (from p in DataBase.people where p.FirstName == "Nathen" select p)
                .Single().Dogs.FirstOrDefault();

            task5SQL.PrintSpecificProperty();


            // Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

            var task6 = DataBase.people.Where(p => p.FirstName == "Cristofer" ||
                                                    p.FirstName == "Freddy" ||
                                                    p.FirstName == "Erin" ||
                                                    p.FirstName == "Amelia")
                                                    .SelectMany(p => p.Dogs.Where(d => d.Color == "White"))
                                                    .OrderBy(d => d.Name).Select(d => d.Name).ToList();



            var task6SQLDogs = (from p in DataBase.people
                                where p.FirstName == "Cristofer" ||
                                      p.FirstName == "Freddy" ||
                                      p.FirstName == "Erin" ||
                                      p.FirstName == "Amelia"
                                from d in p.Dogs
                                where d.Color == "White"
                                orderby d.Name
                                select d.Name).ToList();


            task6SQLDogs.MyPrinter();

            Console.ReadLine();
        }
    }
}
