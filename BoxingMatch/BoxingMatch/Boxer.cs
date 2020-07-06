using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BoxingMatch
{
    public class Boxer
    {
        public event Boxing BoxingEvent;
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Hitpoints { get; set; }
        public bool ChangeHitpoits { get; set; }

        public TypeOfPunches Punch { get; set; }

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
            var punch = (TypeOfPunches)value;
            int strength = Strength[punch];
            PunchingBoxer = false;
            Punch = punch;
            ChangeHitpoits = false;
            BoxingEvent?.Invoke(strength, punch);
        }

        public void Defence(int value, TypeOfPunches type)
        {
            PunchingBoxer = true;
            var punch = type;
            int agility = Agility[punch];
            var nett = value - agility;

            if (nett > 0)
            {
                ChangeHitpoits = true;
                Hitpoints -= nett;
            }
            else if (nett <= 0)
            {
                ChangeHitpoits = false;
            }


            if (Hitpoints <= 0)
            {
                KnockedOut = true;
            }

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
