using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class Log
    {
        
        public int Id { get; set; }
        //public int JobId { get; set; }
        //public string JobName { get; set; }
        public string Status { get; set; }
        public DateTime StartTime { get; set; }
        public string Duration { get; set; }
        public string FileSize { get; set; }
        public string StatusDetail { get; set; }
        //public virtual Job Job { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }


    }
}
