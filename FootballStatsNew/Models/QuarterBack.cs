using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatsNew.Models
{
    public class QuarterBack : Player
    {
        public double Completions { get; set; }

        public double Attempts { get; set; }

        public double Percentage { get; set; }

        public double AttemptsPerGame { get; set; }

        public double TotalYards { get; set; }

        public double Average { get; set; }

        public double AveragePerGame { get; set; }

        public double Touchdowns { get; set; }

        public double Interceptions { get; set; }
    }
}