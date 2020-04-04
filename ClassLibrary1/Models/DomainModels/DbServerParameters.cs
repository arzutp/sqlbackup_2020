using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class DbServerParameters
    {

        public int Id { get; set; }
        public string ServerName { get; set; }  // server local de ise backup yapılabilir
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool AuthType { get; set; }           // 0:Windows - 1:SqlServer
        //public string ServerType { get; set; }

        public ICollection<DbNameOnThisDbServer> DatabasesOnThisServer { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }

    }

}
