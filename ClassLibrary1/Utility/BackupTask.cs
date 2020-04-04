using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TruvaBackup.DAL.Utility
{
    public class BackupTask
    {
        public string serverName { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public List<string> dbNameList { get; set; }
        //public string dbName { get; set; }
        //public string target_1 { get; set; }
        public string authenticationType { get; set; }

        public BackupTask()
        {
            this.dbNameList = new List<string>();
        }

        public List<string> get_all_dbNames_from_server(string _serverName, string _userName, string _pass, bool isWinAuth)
        {


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
            //string[] systemdbList = { "master", "tempdb", "model", "msdb" };

            //    // Database listesini MyDB turundeki listeye atar
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        // Sistem veritabanlari haric
            //        if (!systemdbList.Any(row[0].ToString().Contains))
            //        {
            //            _dbNameList.Add(new MyDB { Id = i, Name = row[0].ToString(), IsChecked = false, IsVisible = true });
            //        }
            //        else
            //        {
            //            _dbNameList.Add(new MyDB { Id = i, Name = row[0].ToString(), IsChecked = false, IsVisible = false });
            //        }

            //        i++;
            //    }

        
        //}
        // Ilgili Veritabanlari Yedekle - Bas
        //#region Ilgili Veritabanlari Yedekle
        //public string BackupAllDbs()
        //{          

        //    if (!(this.dbNameList is null))
        //    {
        //        string s = this.serverName;
        //        string u = this.userName;
        //        string p = this.userPass;
        //        //string target = this.target_1;
        //        string finalTarget;

        //        string datetime = DateTime.Now.ToShortDateString();
        //        datetime += "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString();

        //        string str;
        //        if (this.authenticationType == "Windows Authentication")
        //        {
        //            str = "Data Source=" + s + ";User ID=" + u + ";Password=" + p + ";Integrated Security=True";
        //        }
        //        else
        //        {
        //            str = "Data Source=" + s + ";User ID=" + u + ";Password=" + p + "";
        //        }

        //        SqlConnection con = new SqlConnection(str);

        //        // Yedekleme klasoru olustur
        //        //finalTarget = CreateFolder(target);

        //        con.Open();
        //        SqlCommand cmd_backup = new SqlCommand();
        //        foreach (string dbname in this.dbNameList)
        //        {
        //            cmd_backup.CommandText = "Backup database " + dbname.ToString() + " to disk = '" +
        //                finalTarget + dbname +".bak'";

        //            cmd_backup.Connection = con;
        //            cmd_backup.ExecuteNonQuery();
        //        }
                
        //        con.Close();

        //        // Yedekleme yapilan klasorun adi               
        //        return finalTarget;
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}
        //#endregion
        // Ilgili Veritabanlari Yedekle - Son

        // Yedekleme Klasoru Olustur - Bas
        //#region Yedekleme Klasoru Olustur
        //public string CreateFolder(string baseTarget)
        //{
        //    string _finalTarget;
        //    try
        //    {
        //        string tarih = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
        //        string ana_klasor = baseTarget + @"\TruvaBackupX";
        //        string yedek_klasor = ana_klasor + @"\Backup_" + tarih + @"\";
        //        _finalTarget = yedek_klasor;

        //        if (!System.IO.Directory.Exists(ana_klasor))
        //        {
        //            System.IO.Directory.CreateDirectory(ana_klasor);

        //            if (!System.IO.Directory.Exists(yedek_klasor))
        //            {
        //                System.IO.Directory.CreateDirectory(yedek_klasor);
        //            }
        //        }
        //        else
        //        {
        //            if (!System.IO.Directory.Exists(yedek_klasor))
        //            {
        //                System.IO.Directory.CreateDirectory(yedek_klasor);
        //            }
        //        }

        //        return _finalTarget;

        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Yedekleme icin klasor olusturulamadi.");
        //        return null;
        //    }

        //}
        //#endregion
        // Yedekleme Klasoru Olustur - Son


        // Yedeklenen dosyayi hedeflenen klasorlere gonder - Bas
        //public void CopyFile(string _source, Destination _dest)
        //{

//        //}

//    }
//}
