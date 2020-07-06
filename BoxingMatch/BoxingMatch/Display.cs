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
            Console.ResetColor();
        }

        public void After50WithoutKnockout(Boxer first, Boxer second)
        {
            if (first.Hitpoints > second.Hitpoints)
            {
                Console.WriteLine($"Match is finished, the Winer is {first.Name} with {first.Hitpoints} hitpoints versus {second.Name} - {second.Hitpoints} hitpoints");
            }
            else if (second.Hitpoints > first.Hitpoints)
            {
                Console.WriteLine($"Match is finished, the Winer is {second.Name} with {second.Hitpoints} hitpoints versus {first.Name} - {first.Hitpoints} hitpoints");
            }
            else
            {
                Console.WriteLine($"Match is finished, without winer, {first.Name} with {first.Hitpoints} hitpoints versus {second.Name} with {second.Hitpoints} hitpoints");
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
