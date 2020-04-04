// https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    
    public class UserSqlBackup
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public ICollection<UserJobs> UserJobs { get; set; }
        //public string Mail { get; set; }
        //public string Phone { get; set; }

        //public string CompanyName { get; set; }      //  Google Drive Klasorunun ismini olusturacak
        //public string CloudUri { get; set; }         //  Google Drive
        //public string CloudUriAccountName { get; set; }
        //public string CloudUriAccountPass { get; set; }

        ////public string PassKey { get; set; }

        //public ICollection<B_01_UserJobs> B_01_UserJobs { get; set; }
    }
}

// https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli