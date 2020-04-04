using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class Destination_Cloud
    {
        public int Id { get; set; }
        public string CloudPath { get; set; }
        public string CloudAccountname { get; set; }
        public string CloudAccountPass { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }
    }
}
