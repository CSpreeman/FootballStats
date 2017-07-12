using FootballStatsNew.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FootballStatsNew.Services
{
    public class RBService
    {
        public static int InsertRB(Runningback payload)
        {
            int Id = 0;

            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Insert_Runningback", sqlConn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rank", payload.Rank);
                    cmd.Parameters.AddWithValue("@Name", payload.Name);
                    cmd.Parameters.AddWithValue("@Team", payload.Team);
                    cmd.Parameters.AddWithValue("@Position", payload.Position);
                    cmd.Parameters.AddWithValue("@Attempts", payload.Attempts);
                    cmd.Parameters.AddWithValue("@AttemptsPerGame", payload.AttemptsPerGame);
                    cmd.Parameters.AddWithValue("@Yards", payload.Yards);
                    cmd.Parameters.AddWithValue("@Average", payload.Average);
                    cmd.Parameters.AddWithValue("@YardsPerGame", payload.YardsPerGame);
                    cmd.Parameters.AddWithValue("@Touchdowns", payload.Touchdowns);
                    cmd.Parameters.AddWithValue("@LongestRun", payload.LongestRun);
                    cmd.Parameters.AddWithValue("@FirstDowns", payload.FirstDowns);
                    cmd.Parameters.AddWithValue("@FirstDownPercentage", payload.FirstDownPercentage);
                    cmd.Parameters.AddWithValue("@Fumbles", payload.Fumbles);

                    SqlParameter outPut = cmd.Parameters.Add("@ID", SqlDbType.Int);
                    outPut.Direction = ParameterDirection.Output;

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();

                    Id = Convert.ToInt32(outPut.Value);

                }
                return Id;
            }
        }

    }
}