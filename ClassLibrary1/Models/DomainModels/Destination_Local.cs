using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class Destination_Local
    {
       
        public int Id { get; set; }
        //public string DestType { get; set; } // Hedef tipi Local, OneDrive v.s.
        public string LocalPath { get; set; }
        public string LocalAccountName { get; set; }
        public string LocalAccountPass { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }



    }
}
