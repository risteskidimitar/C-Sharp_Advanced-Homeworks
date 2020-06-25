using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Authors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(3.Add(5));


            var source = new AuthorRepo();
            var authors = source.GetAuthors();

            ////authors.Where(a => a.Name.StartsWith("A"));

            Action<int> printer = x => Console.WriteLine(x);

            Action<int, int> mulPrinter = (x, y) => Console.WriteLine(x * y);

            //printer(3);
            //printer(2 + 2);
            //printer(3.Add(5));
            //mulPrinter(3, 5);

            //Action line = () => Console.WriteLine("-----------------------------");
            //line();

            //// DO NOT DO THIS - BAD PRACTICE
            //Action<bool, bool, bool, bool> condPrinter = (isActive, isEnabled, isEven, isWeekday) =>
            //{
            //    if (!isActive)
            //    {
            //        Console.WriteLine("Inactive");
            //    }
            //    else if (isEnabled)
            //    {
            //        if (isEven && isWeekday)
            //        {
            //            Console.WriteLine("Something else");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Weekend");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Disabled");
            //    }
            //};
            //condPrinter(true, false, true, true);

            //line();

            //Action<string, int> repeat = (text, times) =>
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        Console.Write(text);
            //    }
            //    Console.WriteLine();
            //};

            //repeat("weko", 5);

            //line();

            //Func<int, int, int> add = (x, y) => x + y;
            //var z = add(4, 7);
            //Console.WriteLine(z);



            //Action<IEnumerable<Author>> authorPrinter = (collection) =>
            //{
            //    foreach (var author in collection.Take(3))
            //    {
            //        Console.WriteLine($"{author.Name}");
            //    }
            //    line();
            //};

            //// A - Authors

            //Func<Author, bool> nameStartsWithA = author => author.Name.StartsWith("A");

            //// var aauthors = Enumerable.Where(authors, nameStartsWithA);
            //var aauthors = authors.Where(nameStartsWithA);

            //authorPrinter(aauthors);

            //// B - Authors

            //Func<Author, bool> nameStartsWithB = author => author.Name.StartsWith("B");

            //var bauthors = authors.Where(nameStartsWithB);

            //authorPrinter(bauthors);

            //// C - Authors

            //Func<Author, bool> nameStartsWithC = GetNameLambdaForCharacter('C');

            //var cauthors = authors.Where(nameStartsWithC);

            //authorPrinter(cauthors);

            //// D - Authors

            //var dauthors = authors.Where(GetNameLambdaForCharacter('D'));
            //authorPrinter(dauthors);

            //// F - Authors

            //// ADVANCED, CAUSES BRAIN HURT
            //// Func<char, Func<Author, bool>> nameStartsWith = c => author => author.Name.StartsWith(c);

            //int countExec = 0;

            //Func<char, Func<Author, bool>> nameStartsWith = c =>
            //{
            //    return author =>
            //    {
            //        countExec += 1;
            //        Console.WriteLine($"I've been called for {author.Name}");
            //        return author.Name.StartsWith(c);
            //    };
            //};

            //var firstAuthor = authors.First();
            //var isFirstAuthorWithAnF = nameStartsWith('F')(firstAuthor);
            //var isFirstAuthorWithAnD = GetNameLambdaForCharacter('D')(firstAuthor);
            //line();

            //Console.WriteLine("BEFORE WHERE");

            //var fauthors = authors.Where(nameStartsWith('C'));

            //var fauthorName = fauthors.Select(f => f.Name).ToList();

            //Console.WriteLine("AFTER WHERE; BEFORE PRINT");

            //authorPrinter(fauthors);

            //Console.WriteLine(countExec);

            //line();

            //// E - Authors
            //var startsWithE = GetStartsWithLambda<Author>('E', a => a.Name);
            //var eauthors = authors.Where(startsWithE);
            //authorPrinter(eauthors);

            //var allBooks = authors.SelectMany(a => a.Books);

            //Console.WriteLine(allBooks.Count());

            //Action<IEnumerable<Book>> bookPrinter = (collection) =>
            //{
            //    foreach (var book in collection)
            //    {
            //        Console.WriteLine($"{book.Title}");
            //    }
            //    line();
            //};

            //line();

            //// A - Books
            //var bookStartsWithA = GetStartsWithLambda<Book>('A', b => b.Title);
            //var abooks = allBooks.Where(bookStartsWithA);
            //bookPrinter(abooks);

            //// Advanced Advanced - Hurts Lecturers Brain

            ////var bookStartsWithB = GetStartsWithLambda<Book>('B', b => b.Title);
            ////var bookStartsWithC = GetStartsWithLambda<Book>('C', b => b.Title);
            ////var bookStartsWithD = GetStartsWithLambda<Book>('D', b => b.Title);
            ////var bookStartsWithE = GetStartsWithLambda<Book>('E', b => b.Title);
            ////var bookStartsWithF = GetStartsWithLambda<Book>('F', b => b.Title);

            ////var bookStartsWithB = GetTitleLambdaForCharacter('B');
            ////var bookStartsWithC = GetTitleLambdaForCharacter('C');
            ////var bookStartsWithD = GetTitleLambdaForCharacter('D');
            ////var bookStartsWithE = GetTitleLambdaForCharacter('E');
            ////var bookStartsWithF = GetTitleLambdaForCharacter('F');

            //var getTitleLambdaForCharacter = GetStartsWithLambdaGenerator<Book>(b => b.Title);

            //var bookStartsWithB = getTitleLambdaForCharacter('B');
            //var bookStartsWithC = getTitleLambdaForCharacter('C');
            //var bookStartsWithD = getTitleLambdaForCharacter('D');
            //var bookStartsWithE = getTitleLambdaForCharacter('E');
            //var bookStartsWithF = getTitleLambdaForCharacter('F');

            //bookPrinter(allBooks.Where(bookStartsWithF));

            //var authorsWithoutBooks = authors.Select(a => new
            //{
            //    a.ID,
            //    a.Name
            //});

            //var booksWithAuthorId = authors.SelectMany(a => a.Books.Select(b => new
            //{
            //    b.ID,
            //    b.Title,
            //    AuthorID = a.ID
            //}));

            //var authorBooks = from a in authorsWithoutBooks
            //                  join b in booksWithAuthorId on a.ID equals b.AuthorID
            //                  select new
            //                  {
            //                      a.Name,
            //                      b.Title
            //                  };

            //// unclear syntax
            ////var authorBooks = authorsWithoutBooks.Join(booksWithAuthorId, a => a.ID, b => b.AuthorID, (a, b) => new
            ////{
            ////    a.Name,
            ////    b.Title
            ////});

            //foreach (var ab in authorBooks)
            //{
            //    Console.WriteLine($"{ab.Name} wrote {ab.Title}");
            //}

            //Console.WriteLine(authorBooks.Count());
            //line();

            //// var booksCount = authors.Sum(a => a.Books.Count());

            //int accumulator = 0;
            //foreach (var author in authors)
            //{
            //    accumulator = accumulator + author.Books.Count();
            //}
            //Console.WriteLine(accumulator);

            //int booksCount = authors.Aggregate(0, (acc, author) => acc + author.Books.Count());

            //Console.WriteLine(booksCount);


            //// select-many via aggregate
            //var aggregateBooks = authors.Aggregate(new List<Book>(), (acc, author) => acc.Concat(author.Books).ToList());
            //Console.WriteLine(aggregateBooks.Count);

            //// where via aggregate
            //// authors.Where(a => a.Name.StartsWith('A'));
            //var authorNamesWithA = authors.Aggregate(new List<Author>(), (acc, author) => author.Name.StartsWith('A') ? acc.Append(author).ToList() : acc);

            //authorPrinter(authorNamesWithA);




            // implement Select, Any, All, Distinct, SingleOrDefault with Aggregate

            //Select 

            var mySelect = authors.Aggregate(new List<string>(), (acc, author) => acc.Append(author.Name).ToList());

            //Any
            var MyAny = authors.Aggregate(false, (acc, author) =>
            {
                if (author.Name.Count() > 10)
                {
                    return acc = true;
                }
                return acc;
            });
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(MyAny);
            Console.ResetColor();

            //All
            var MyAll = authors.Aggregate(false, (acc, author) =>
            {
                if (author.Books.Count >= 0)
                {
                    acc = true;
                }
                else
                {
                    return acc = false;
                }
                return acc;
            });
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(MyAll);
            Console.ResetColor();

            // Distinct
            var MyDistinct = authors.Aggregate(new List<Author>(), (acc, author) => acc.Contains(author) ? acc : acc.Append(author).ToList());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(authors.Count);
            Console.ResetColor();


            //SingleOrDefault

            var MySingleOrDefault = authors.Aggregate(new Author(), (acc, author) => author.Name == "Dimitar" ? acc = author : null);

            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //foreach (var item in mySelect)
            //{
            //    Console.WriteLine(item);
            //}


            Console.ResetColor();
            Console.ReadLine();
        }

        private static Func<Author, bool> GetNameLambdaForCharacter(char c)
        {
            Func<Author, bool> lambda = author => author.Name.StartsWith(c);
            return lambda;
        }

        private static Func<Book, bool> GetTitleLambdaForCharacter(char c)
        {
            Func<Book, bool> lambda = book => book.Title.StartsWith(c);
            return lambda;
        }

        private static Func<T, bool> GetStartsWithLambda<T>(char c, Func<T, string> selector)
        {
            Func<T, bool> lambda = item =>
            {
                var stringFromItem = selector(item);
                return stringFromItem.StartsWith(c);
            };
            return lambda;
        }

        private static Func<char, Func<T, bool>> GetStartsWithLambdaGenerator<T>(Func<T, string> selector)
        {
            Func<char, Func<T, bool>> result = (c) =>
            {
                Func<T, bool> lambda = item =>
                {
                    var stringFromItem = selector(item);
                    return stringFromItem.StartsWith(c);
                };
                return lambda;
            };
            return result;
        }

        private static Func<char, Func<T, bool>> GetStartsWithLambdaGenerator2<T>(Func<T, string> selector) => c => item => selector(item).StartsWith(c);
    }
}
