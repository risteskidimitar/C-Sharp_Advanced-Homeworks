using System;
using System.Collections.Generic;

namespace BoxingMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxer TysonFury = new Boxer("Tyson Fury", 124, 1000, false);
            TysonFury.Strength = new Dictionary<TypeOfPunches, int>
            { { TypeOfPunches.Cross, 20 }, { TypeOfPunches.Jab, 10 },
              { TypeOfPunches.Uppercut, 25 }, {TypeOfPunches.Hook, 20 } };

            TysonFury.Agility = new Dictionary<TypeOfPunches, int>
            { { TypeOfPunches.Cross, 15 }, { TypeOfPunches.Jab, 15 },
              { TypeOfPunches.Uppercut, 30 }, {TypeOfPunches.Hook, 15 } };

            Boxer AndyRuizJr = new Boxer("Andy Ruiz Jr", 128, 1500, true);
            TysonFury.Strength = new Dictionary<TypeOfPunches, int>
            { { TypeOfPunches.Cross, 26 }, { TypeOfPunches.Jab, 16 },
              { TypeOfPunches.Uppercut, 21 }, {TypeOfPunches.Hook, 16 } };

            AndyRuizJr.Agility = new Dictionary<TypeOfPunches, int>
            { { TypeOfPunches.Cross, 26 }, { TypeOfPunches.Jab, 26 },
              { TypeOfPunches.Uppercut, 16 }, {TypeOfPunches.Hook, 21 } };


            TysonFury.Boxing += (t, s) => AndyRuizJr.Defence(t, s);
            AndyRuizJr.Boxing += (t, s) => TysonFury.Defence(t, s);

            BoxingMatch Match01 = new BoxingMatch();

            Match01.Boxing(TysonFury, AndyRuizJr);



            Console.ReadLine();
        }
    }
}
