using FootballStatsNew.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FootballStatsNew.Services
{
    public class QBService
    {

        public static int PostQB(QuarterBack payload)
        {
            int Id = 0;

            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Insert_Quarterback", sqlConn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rank", payload.Rank);
                    cmd.Parameters.AddWithValue("@Name", payload.Name);
                    cmd.Parameters.AddWithValue("@Team", payload.Team);
                    cmd.Parameters.AddWithValue("@Position", payload.Position);
                    cmd.Parameters.AddWithValue("@Completions", payload.Completions);
                    cmd.Parameters.AddWithValue("@Attempts", payload.Attempts);
                    cmd.Parameters.AddWithValue("@Percentage", payload.Percentage);
                    cmd.Parameters.AddWithValue("@AttemptsPerGame", payload.AttemptsPerGame);
                    cmd.Parameters.AddWithValue("@TotalYards", payload.TotalYards);
                    cmd.Parameters.AddWithValue("@Average", payload.Average);
                    cmd.Parameters.AddWithValue("@AveragePerGame", payload.AveragePerGame);
                    cmd.Parameters.AddWithValue("@Touchdowns", payload.Touchdowns);
                    cmd.Parameters.AddWithValue("@Interceptions", payload.Interceptions);

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