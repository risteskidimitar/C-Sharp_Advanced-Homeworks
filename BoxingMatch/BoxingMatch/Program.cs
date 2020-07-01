using System;
using System.Collections.Generic;
using System.IO;

namespace BoxingMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initialization
            Boxer TysonFury = new Boxer("Tyson Fury", 124, 1000, false);
            TysonFury.Strength = new Dictionary<TypeOfPunches, int>
            {
              { TypeOfPunches.Cross, 20 }, { TypeOfPunches.Jab, 10 },
              { TypeOfPunches.Uppercut, 25 }, {TypeOfPunches.Hook, 20 } };

            TysonFury.Agility = new Dictionary<TypeOfPunches, int>
            {
                { TypeOfPunches.Cross, 15 }, { TypeOfPunches.Jab, 15 },
                { TypeOfPunches.Uppercut, 30 }, {TypeOfPunches.Hook, 15 }
            };

            Boxer AndyRuizJr = new Boxer("Andy Ruiz Jr", 128, 1500, true);
            AndyRuizJr.Strength = new Dictionary<TypeOfPunches, int>
            {
              { TypeOfPunches.Cross, 26 }, { TypeOfPunches.Jab, 16 },
              { TypeOfPunches.Uppercut, 21 }, {TypeOfPunches.Hook, 16 }
            };

            AndyRuizJr.Agility = new Dictionary<TypeOfPunches, int>
            { { TypeOfPunches.Cross, 26 }, { TypeOfPunches.Jab, 26 },
              { TypeOfPunches.Uppercut, 16 }, {TypeOfPunches.Hook, 21 }
            };

            BoxingMatch match01 = new BoxingMatch();
            Display display = new Display();
            Writer writer = new Writer();
            #endregion

            #region Events

            match01.MatchStats += display.LiveCommentary;
            match01.MatchStats += writer.WritingStats;
            match01.Knockout += display.Knockout;
            match01.Knockout += writer.Knockout;
            AndyRuizJr.BoxingEvent += TysonFury.Defence;
            TysonFury.BoxingEvent += AndyRuizJr.Defence;
            match01.Boxing(TysonFury, AndyRuizJr);
            #endregion


            writer.Logger.sw.Dispose();

            Console.WriteLine(@$"Press ""delete"" if you want to erase match history");

            if (Console.ReadLine() == "delete")
            {
                File.Delete(@"..\..\..\Match\Stats.txt");
            }
        }
    }
}
