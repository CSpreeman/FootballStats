using FootballStatsNew.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace FootballStatsNew.Services
{
    public class ScrapeService
    {

        public static List<int> ScrapeData(string pos)
        {
            List<int> ListIds = new List<int>();

            HtmlWeb hw = new HtmlWeb();
            HtmlDocument htmlDoc = hw.Load("http://www.nfl.com/stats/categorystats?archive=false&conference=null&statisticPositionCategory=" + pos + "&season=2016&seasonType=REG&experience=&tabSeq=1&qualified=true&Submit=Go");

            HtmlNodeCollection tables = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"result\"]//tbody");
            HtmlNodeCollection rows = tables[0].SelectNodes("//tr");

            for (int i = 1; i < rows.Count; ++i)
            {
                HtmlNodeCollection col = rows[i].SelectNodes("td");
                List<string> DataList = new List<string>();

                for (int x = 0; x <= 15; ++x)
                {
                    HtmlNode item = col[x];
                    StringBuilder sb = new StringBuilder(item.InnerText.ToString());
                    sb.Replace("\t", string.Empty);
                    sb.Replace("\n", string.Empty);
                    string data = sb.ToString();
                    DataList.Add(data);
                }

                int DataInserted = SortService.SortData(DataList);
                ListIds.Add(DataInserted);
            }

            return ListIds;
        }
    }
}
