using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

////  http://bekenty.com/use-sqlite-in-net-core-3-with-entity-framework-core/
////  https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=visual-studio
//    Add-Migration aralik_14_19_02 -Project ClassLibrary1
//    Add-Migration aralik_24_11_42 -Project ClassLibrary1

//    Update-Database -Project ClassLibrary1
namespace ClassLibrary1.Models.DomainModels
{
    public class DbContextSqlBackup : DbContext
    {
        public DbSet<UserSqlBackup> User { get; set; }
        public DbSet<UserJobs> UserJobs { get; set; }
        public DbSet<DbServerParameters> DbServerParameters { get; set; }
        public DbSet<DbNameOnThisDbServer> DbNameOnThisDbServer { get; set; }
        public DbSet<FoldersToBeBackup> FoldersToBeBackup { get; set; }
        public DbSet<FilesToBeBackup> FilesToBeBackup { get; set; }
        public DbSet<Destination_Local> Destination_Local { get; set; }
        public DbSet<Destination_Network> Destination_Network { get; set; }
        public DbSet<Destination_Cloud> Destination_Cloud { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<NotificationEmail> NotificationEmail { get; set; }
        public DbSet<Schedule> Schedule { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //      => options.UseSqlite("Data Source=sqlbackupandftp.db");
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=SqlBackupTroia;Integrated Security=True");
        }

    }
}
