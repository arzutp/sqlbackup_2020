using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class Schedule
    {
       
        public int Id { get; set; }
        public bool IsSunday { get; set; }
        public bool IsMonday { get; set; }
        public bool IsTuesday { get; set; }
        public bool IsWednesday { get; set; }
        public bool IsThursday { get; set; }
        public bool IsFriday { get; set; }
        public bool IsSaturday { get; set; }

        public DateTime StartDateTime { get; set; }
        public int interval { get; set; }
        public int howmanyBackup { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }
    }
}
