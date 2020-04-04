using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class FoldersToBeBackup
    {
   
        public int Id { get; set; }
        public string folderName { get; set; }
        public UserJobs userJobs { get; set; }
        public int UserJobsId { get; set; }

    }
}
