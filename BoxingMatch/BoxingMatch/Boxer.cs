using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BoxingMatch
{
    public class Boxer
    {
        public event Boxing Boxing;
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Hitpoints { get; set; }

        public bool PunchingBoxer;

        public bool KnockedOut;

        public Dictionary<TypeOfPunches, int> Strength = new Dictionary<TypeOfPunches, int>();
        public Dictionary<TypeOfPunches, int> Agility = new Dictionary<TypeOfPunches, int>();

        public Boxer(string name, int weight, int hitpoints, bool punchingBoxer)
        {
            Name = name;
            Weight = weight;
            Hitpoints = hitpoints;
            PunchingBoxer = punchingBoxer;
        }
        public Boxer()
        {

        }


        public void Attack(int value)
        {
            var Pounch = (TypeOfPunches)value;
            Console.WriteLine($"{Name} thrown a {Pounch.ToString()} punch");
            var strength = Strength.Where(x => x.Key == Pounch).Select(x => x.Value).SingleOrDefault();
            Boxing?.Invoke(strength, Pounch);
            PunchingBoxer = false;
            //Thread.Sleep(1000);
        }

        public void Defence(int value, TypeOfPunches type)
        {
            var Pounch = type;
            Console.WriteLine($"Deffence agienst {Pounch.ToString()} punch");
            var agility = Agility.Where(x => x.Key == Pounch).Select(x => x.Value).SingleOrDefault();
            var nett = value - agility;
            if (nett < 0) { nett = 0; }

            Hitpoints -= nett;
            if (Hitpoints <= 0)
            { 
                KnockedOut = true; 
                Console.WriteLine("Knocked out."); 
            }
            PunchingBoxer = true;
            //Thread.Sleep(1000);
        }


    }
    public enum TypeOfPunches
    {
        Cross,
        Jab,
        Uppercut,
        Hook
    }
}
