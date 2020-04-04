using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{

    public class NotificationEmail
    {
        
        public int Id { get; set; }
        public string FromName { get; set; }
        //public string FromMail { get; set; }
        public string Subject { get; set; }
        public string SMTPServer { get; set; }
        public string SMTPUserName { get; set; }
        public string SMTPUserPass { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }
    }
}
