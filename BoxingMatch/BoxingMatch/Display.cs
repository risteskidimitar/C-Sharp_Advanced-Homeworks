using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BoxingMatch
{
    public class Display
    {
        public void LiveCommentary(Boxer first, Boxer second)
        {
            if (first.PunchingBoxer == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{first.Name} with {first.Hitpoints} hitpoints thrown a {first.Punch} punch");
                if (second.ChangeHitpoits)
                {
                    Console.WriteLine($"The punch is HIT {second.Name} is now with {second.Hitpoints} hitpoints");
                }
                else
                {
                    Console.WriteLine($"The punch is MISS, great defence by {second.Name}");
                }
            }

            if (second.PunchingBoxer == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{second.Name} with {second.Hitpoints} hitpoints thrown a {second.Punch} punch");
                if (first.ChangeHitpoits)
                {
                    Console.WriteLine($"The punch is HIT {first.Name} is now with {first.Hitpoints} hitpoints");
                }
                else
                {
                    Console.WriteLine($"The punch is MISS, great defence {first.Name}");
                }
            }
        }

        public void Knockout(Boxer boxer)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine($"{boxer.Name} is KNOCKED OUT!");
        }
    }
}
