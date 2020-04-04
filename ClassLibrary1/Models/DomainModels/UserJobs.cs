using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class UserJobs
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime? createdTime { get; set; }
        public DateTime? updatedTime { get; set; }
        public bool? isActive { get; set; }
        public UserSqlBackup userSqlBackup { get; set; }
        public int? UserSqlBackupId { get; set; }
        public DbServerParameters DbServerParameters { get; set; }
        //public int? DbServerParametersId { get; set; }

        public NotificationEmail NotificationEmail { get; set; }
        public Schedule Schedule { get; set; }
        public ICollection<FoldersToBeBackup> FoldersToBeBackups { get; set; }
        public ICollection<FilesToBeBackup> FilesToBeBackup { get; set; }

        public ICollection<Destination_Local> Destination_Local { get; set; }
        public ICollection<Destination_Network> Destination_Network { get; set; }
        public ICollection<Destination_Cloud> Destination_Cloud { get; set; }
        public ICollection<Log> Logs { get; set; }

    }
}
