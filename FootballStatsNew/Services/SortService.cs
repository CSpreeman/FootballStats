using FootballStatsNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatsNew.Services
{
    public class SortService
    {
        public static int SortData(List<string> data)
        {
            int id = 0;

            switch (data[3])
            {
                case "QB":
                    Quarterback QB = new Quarterback();
                    QB.Rank = data[0];
                    QB.Name = data[1];
                    QB.Team = data[2];
                    QB.Position = data[3];
                    QB.Completions = data[4];
                    QB.Attempts = data[5];
                    QB.Percentage = data[6];
                    QB.AttemptsPerGame = data[7];
                    QB.TotalYards = data[8];
                    QB.Average = data[9];
                    QB.AveragePerGame = data[10];
                    QB.Touchdowns = data[11];
                    QB.Interceptions = data[12];
                    id = QBService.InsertQB(QB);
                    break;

                case "RB":
                    Runningback RB = new Runningback();
                    RB.Rank = data[0];
                    RB.Name = data[1];
                    RB.Team = data[2];
                    RB.Position = data[3];
                    RB.Attempts = data[4];
                    RB.AttemptsPerGame = data[5];
                    RB.Yards = data[6];
                    RB.Average = data[7];
                    RB.YardsPerGame = data[8];
                    RB.Touchdowns = data[9];
                    RB.LongestRun = data[10];
                    RB.FirstDowns = data[11];
                    RB.FirstDownPercentage = data[12];
                    RB.Fumbles = data[15];
                    id = RBService.InsertRB(RB);
                    break;

            }

            return id;
        }
    }
}