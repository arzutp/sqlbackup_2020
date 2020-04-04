using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Utility
{
    public class BackupJobs
    {
        public string serverName { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public string authenticationType { get; set; }
        public List<string> dbNameList { get; set; }
        public BackupJobs()
        {
            this.dbNameList = new List<string>();
        }
        public List<string> get_all_dbNames_from_server(string _serverName, string _userName, string _pass, bool isWinAuth=true)
        {

            // DESKTOP-H80HOLB
        
        List<string> result = new List<string>();
            string _connString = "";


            if (isWinAuth)
                _connString = "Data Source=" + _serverName + ";User ID=" + _userName + ";Password=" + _pass + ";Integrated Security=True";
            else
                _connString = "Data Source=" + _serverName + ";User ID=" + _userName + ";Password=" + _pass;



            SqlConnection conn = new SqlConnection(_connString);



            SqlCommand command = new SqlCommand("SELECT db.[name] as dbname FROM [master].[sys].[databases] db", conn);

            try
            {
                //string dNs = "";
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //Console.WriteLine("\t{0}\t{1}\t{2}",
                    //    reader[0], reader[1], reader[2]);
                    //dNs += reader[0] + " ";
                    result.Add(reader[0].ToString());
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

    }
}
