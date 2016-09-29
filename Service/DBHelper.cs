using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WCFChat.Service
{
    internal static class DbHelper
    {
        private static string ConnStr
            => "Data Source=MARKUS-PC;Initial Catalog=WCFChat;User Id=chatService;Password=3VW@Z5-FZRa@?p4vu^T@MsRTvM63ukmzBJ9DUD%G8@JS24MZU!m*Dkc*HDL%6Xz5?n=BPTRb9*wKaQ8Cx!JGM%wB^_3+v+rD3KGg-8Gq^C@Au-RQYb6dv?PR&bZ+MCU;";

        public static void InsertTest(string test)
        {
            using (var cmd = new SqlCommand("INSERT INTO TEST VALUES ('" + test + "');", new SqlConnection(ConnStr)))
            {
                try
                {
                    cmd.Connection.Open();
                    
                    Console.WriteLine("Ausgeführt: " + cmd.ExecuteNonQuery());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    throw;
                }
            }
        }

        public static string[] GetAllValues()
        {
            List<string> values = new List<string>();

            using (var cmd = new SqlCommand("SELECT * FROM TEST", new SqlConnection(ConnStr)))
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        values.Add(reader[0] as string);
                    }
                }
            }

                return values.ToArray();
        }
    }
}
