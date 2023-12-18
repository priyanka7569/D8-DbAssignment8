using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conn = "server=PRIYANKAREDDY;database=Day8Db_Assignment;trusted_connection=true;";
            using (SqlConnection con = new SqlConnection(conn))
            {
                string query = "Select top 5 * from Products order by Pname desc";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Top 5 records in Desc");
                while (reader.Read())
                {
                    Console.WriteLine($"PId:{reader["PId"]}\tPname:{reader["PName"]}\tPPrice:{reader["PPrice"]}\tMnfdate:{reader["Mnfdate"]}\tExpDate:{reader["ExpDate"]}");
                }
                reader.Close();
                Console.ReadKey();
            }
        }
    }
}
   
