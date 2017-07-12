using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatsNew.Models
{
    public class Runningback : Player
    {
        public string Attempts { get; set; }

        public string AttemptsPerGame { get; set; }

        public string Yards { get; set; }

        public string Average { get; set; }

        public string YardsPerGame { get; set; }

        public string Touchdowns { get; set; }

        public string LongestRun { get; set; }

        public string FirstDowns { get; set; }

        public string FirstDownPercentage { get; set; }

        public string Fumbles { get; set; }
    }
}