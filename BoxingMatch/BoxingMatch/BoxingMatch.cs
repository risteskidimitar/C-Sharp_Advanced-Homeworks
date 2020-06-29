using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BoxingMatch
{
    public delegate void Boxing(int value, TypeOfPunches punch);

    public delegate void BoxingDisplay(Boxer boxer1, Boxer boxer2);// za display


    public class BoxingMatch
    {
        public event BoxingDisplay Match;

        public int Total { get; set; }
        public BoxingMatch()
        {
            Total = 50;
        }
        public int Random()
        {
            return new Random().Next(0, 4);
        }


        public void Boxing(Boxer boxer1, Boxer boxer2)
        {


            while (Total >= 0 && boxer1.KnockedOut == false && boxer2.KnockedOut == false)
            {
                if (Total == 0)// Ova ne mi taboti
                {
                    if (boxer1.Hitpoints > boxer2.Hitpoints)
                    {
                        Console.WriteLine($"The wineer is {boxer1.Name} with {boxer1.Hitpoints}");
                    }
                    if (boxer2.Hitpoints > boxer1.Hitpoints)
                    {
                        Console.WriteLine($"The wineer is {boxer2.Name} with {boxer2.Hitpoints}");
                    }
                    else
                    {
                        Console.WriteLine("Match without winner");
                    }
                }
                if (boxer1.PunchingBoxer)
                {
                    boxer1.Attack(Random());
                    Total--;
                    if (boxer2.KnockedOut)
                    {
                        Console.WriteLine($"{boxer1.Name} is knockout");
                        break;
                    }
                }
                if (boxer2.PunchingBoxer)
                {
                    boxer2.Attack(Random());
                    Total--;
                    if (boxer1.KnockedOut)
                    {
                        Console.WriteLine($"{boxer2.Name} is knockout");
                        break;
                    }
                }


            }

        }

    }

}
