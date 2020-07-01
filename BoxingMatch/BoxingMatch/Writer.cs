using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingMatch
{
    public class Writer
    {
        public LoggerService Logger = new LoggerService();
        internal void WritingStats(Boxer first, Boxer second)
        {
            if (first.PunchingBoxer == false)
            {
                Logger.sw.WriteLine($"{first.Name} with {first.Hitpoints} hitpoints thrown a {first.Punch} punch");
             

                if (second.ChangeHitpoits)
                {
                    Logger.sw.WriteLine($"The punch is HIT {second.Name} is now with {second.Hitpoints} hitpoints");
                }
                else
                {
                    Logger.sw.WriteLine($"The punch is MISS, great defence by {second.Name}");
                }
            }

            if (second.PunchingBoxer == false)
            {
                Logger.sw.WriteLine($"{second.Name} with {second.Hitpoints} hitpoints thrown a {second.Punch} punch");
                if (first.ChangeHitpoits)
                {
                    Logger.sw.WriteLine($"The punch is HIT {first.Name} is now with {first.Hitpoints} hitpoints");
                }
                else
                {
                    Logger.sw.WriteLine($"The punch is MISS, great defence {first.Name}");
                }
            }
        }

        internal void Knockout(Boxer boxer)
        {
            for (int i = 10; i > 0; i--)
            {
                Logger.sw.WriteLine(i);
            }
            Logger.sw.WriteLine($"{boxer.Name} is KNOCKED OUT!");
        }
    }
}
