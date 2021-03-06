﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatsNew.Models
{
    public class Quarterback : Player
    {
        public string Completions { get; set; }

        public string Attempts { get; set; }

        public string Percentage { get; set; }

        public string AttemptsPerGame { get; set; }

        public string TotalYards { get; set; }

        public string Average { get; set; }

        public string AveragePerGame { get; set; }

        public string Touchdowns { get; set; }

        public string Interceptions { get; set; }
    }
}