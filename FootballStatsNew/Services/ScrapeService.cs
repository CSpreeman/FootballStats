using FootballStatsNew.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FootballStatsNew.Services
{
    public class ScrapeService
    {

        public static List<int> ScrapeData()
        {
            List<int> ListIds = new List<int>();
            QuarterBack QB = new QuarterBack();

            HtmlWeb hw = new HtmlWeb();
            HtmlDocument htmlDoc = hw.Load("http://www.nfl.com/stats/categorystats?archive=false&conference=null&statisticPositionCategory=QUARTERBACK&season=2016&seasonType=REG&experience=&tabSeq=1&qualified=true&Submit=Go");

            HtmlNodeCollection tables = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"result\"]//tbody");
            HtmlNodeCollection rows = tables[0].SelectNodes("//tr");

            for (int i = 1; i < rows.Count; ++i)
            {
                HtmlNodeCollection col = rows[i].SelectNodes("td");

                for (int x = 0; x <= 12; ++x)
                {
                    HtmlNode item = col[x];
                    string itemData = item.InnerText.ToString();
                    string a = itemData.Replace("\t", string.Empty);
                    string b = a.Replace("\n", string.Empty);
                    double result;

                    if (double.TryParse(b, out result) == true)
                    {
                        result = Convert.ToDouble(b);
                    }
                    switch (x)
                    {
                        case 0:
                            itemData = Regex.Replace(itemData, "[^0-9.]", "");
                            QB.Rank = result;
                            break;
                        case 1:
                            QB.Name = b;
                            break;
                        case 2:
                            QB.Team = b;
                            break;
                        case 3:
                            QB.Position = b;
                            break;
                        case 4:
                            QB.Completions = result;
                            break;
                        case 5:
                            QB.Attempts = result;
                            break;
                        case 6:
                            QB.Percentage = result;
                            break;
                        case 7:
                            QB.AttemptsPerGame = result;
                            break;
                        case 8:
                            QB.TotalYards = result;
                            break;
                        case 9:
                            QB.Average = result;
                            break;
                        case 10:
                            QB.AveragePerGame = result;
                            break;
                        case 11:
                            QB.Touchdowns = result;
                            break;
                        case 12:
                            QB.Interceptions = result;
                            break;
                        default:
                            break;
                    }
                }
                int insertedQB = QBService.PostQB(QB);
                ListIds.Add(insertedQB);
            }

            return ListIds;
        }
    }
}