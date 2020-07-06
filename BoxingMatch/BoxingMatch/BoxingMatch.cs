using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BoxingMatch
{
    public delegate void Boxing(int value, TypeOfPunches punch);
    public delegate void BoxingDisplay(Boxer boxer1, Boxer boxer2);
    public delegate void KnockoutBoxer(Boxer boxer);


    public class BoxingMatch
    {
        public event BoxingDisplay MatchStats;

        public event KnockoutBoxer Knockout;
        public event BoxingDisplay After50;

        private int total { get; set; }
        public BoxingMatch()
        {
            total = 50;
        }
        public int Random()
        {
            return new Random().Next(0, 4);
        }


        public void Boxing(Boxer boxer1, Boxer boxer2)
        {


            while (total > 0 && boxer1.KnockedOut == false && boxer2.KnockedOut == false)
            {
                if (boxer1.PunchingBoxer)
                {

                    boxer1.Attack(Random());
                    MatchStats?.Invoke(boxer1, boxer2);
                }
                if (boxer2.PunchingBoxer)
                {

                    boxer2.Attack(Random());
                    MatchStats?.Invoke(boxer1, boxer2);
                }


                if (boxer1.KnockedOut)
                {
                    Knockout?.Invoke(boxer1);
                    break;
                }
                if (boxer2.KnockedOut)
                {
                    Knockout?.Invoke(boxer2);
                    break;
                }
                total--;
            }
            if (total == 0)
            {
                After50?.Invoke(boxer1, boxer2);
            }

        }

    }

}
