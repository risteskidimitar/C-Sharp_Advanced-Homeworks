using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BoxingMatch
{
    public class LoggerService
    {
        private string directoryPath = @"..\..\..\MatchFile";
        private string statsFile = @"..\..\..\MatchFile\Stats.txt";
        public StreamWriter sw { get; set; }
        public LoggerService()
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(statsFile))
            {
                File.Create(statsFile).Close();
            }
            sw = new StreamWriter(statsFile, true);
        }

        
    }
}
