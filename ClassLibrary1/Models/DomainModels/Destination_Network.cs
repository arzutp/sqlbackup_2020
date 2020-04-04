using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class Destination_Network
    {
        public int Id { get; set; }
        public string NetworkPath { get; set; }
        public string NetworkAccount { get; set; }
        public string NetworkPass { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }
    }
   


}
