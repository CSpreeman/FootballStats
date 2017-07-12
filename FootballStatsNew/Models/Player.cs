using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatsNew.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Rank { get; set; }

        public string Name { get; set; }

        public string Team { get; set; }

        public string Position { get; set; }
    }
}