using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Utility;
namespace ClassLibrary1.Models.ViewModels

{
    public class Selected_Job_And_Details
    {
        public UserJobs selectedJob { get; set; }
        public DbServerParameters DbServerParameters { get; set; }
        public List<DbNameOnThisDbServer> dbNamesOnThisDbServers { get; set; }
        public Schedule Schedule { get; set; }
        public Destination_Local Destination_Local { set; get; }

        public Destination_Network Destination_Network { set; get; }

        public Destination_Cloud Destination_Cloud { set; get; }
        public Selected_Job_And_Details()
        {
            selectedJob = new UserJobs();
            DbServerParameters = new DbServerParameters();
            dbNamesOnThisDbServers = new List<DbNameOnThisDbServer>();
            Schedule = new Schedule();
            Destination_Local = new Destination_Local();
            Destination_Network = new Destination_Network();
            Destination_Cloud = new Destination_Cloud();

        }
    }
    public class VM_Main_Form_DTO
    {
        public UserSqlBackup UserSqlBackup { get; set; }
        public List<UserJobs> UserJobs { get; set; }
        public Selected_Job_And_Details SelectedJob_And_Details { get; set; }
        public VM_Main_Form_DTO()
        {
            UserSqlBackup = new UserSqlBackup();
            UserJobs = new List<UserJobs>();
            SelectedJob_And_Details = new Selected_Job_And_Details();
        }

        public void update_VM_with_accountName_pass(string name = "", string pass = "", string jobName = "")
        {

            //try
            //{
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                UserSqlBackup = dbContext.User.Where(x => x.AccountName == name && x.Password == pass.encryption()).FirstOrDefault();
                if (!(UserSqlBackup is null))
                    UserJobs = dbContext.UserJobs.Where(x => x.UserSqlBackupId == UserSqlBackup.Id).ToList<UserJobs>();

                if (jobName == "")
                {
                    if (this.UserJobs.Count > 0)
                        this.SelectedJob_And_Details.selectedJob = UserJobs[0];
                    else
                        this.SelectedJob_And_Details.selectedJob = null;

                }
                else
                {
                    if (this.UserJobs.Count > 0)
                    {
                        this.SelectedJob_And_Details.selectedJob = this.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                        if (!(this.SelectedJob_And_Details.selectedJob is null))
                        {

                            this.SelectedJob_And_Details.DbServerParameters = dbContext.DbServerParameters.Where(x => x.UserJobsId == SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();

                            if (!(this.SelectedJob_And_Details.DbServerParameters is null))
                                this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

                            if (!(this.SelectedJob_And_Details.DbServerParameters is null))
                                this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

                            this.SelectedJob_And_Details.Schedule = dbContext.Schedule.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                            this.SelectedJob_And_Details.Destination_Local = dbContext.Destination_Local.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                            this.SelectedJob_And_Details.Destination_Network = dbContext.Destination_Network.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                            this.SelectedJob_And_Details.Destination_Cloud = dbContext.Destination_Cloud.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                        }
                    }
                    else
                        this.SelectedJob_And_Details.selectedJob = null;

                }

                if (!(this.SelectedJob_And_Details.selectedJob is null))
                {

                    this.SelectedJob_And_Details.DbServerParameters = dbContext.DbServerParameters.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();

                    if (!(this.SelectedJob_And_Details.DbServerParameters is null))
                        this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == this.SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

                    if (!(this.SelectedJob_And_Details.DbServerParameters is null))
                        this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == this.SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

                    this.SelectedJob_And_Details.Schedule = dbContext.Schedule.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                    this.SelectedJob_And_Details.Destination_Local = dbContext.Destination_Local.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                    this.SelectedJob_And_Details.Destination_Network = dbContext.Destination_Network.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                    this.SelectedJob_And_Details.Destination_Cloud = dbContext.Destination_Cloud.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                }
            }
            //}
            //catch
            //{

            //}

            //return vM_Main_Form_DTO;

        }
        public void update_VM_with_jobName(string jobName = "")
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {

                if (this.UserJobs.Count > 0)
                {
                    this.SelectedJob_And_Details.selectedJob = this.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                    if (!(this.SelectedJob_And_Details.selectedJob is null))
                    {

                        this.SelectedJob_And_Details.DbServerParameters = dbContext.DbServerParameters.Where(x => x.UserJobsId == SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();

                        if (!(this.SelectedJob_And_Details.DbServerParameters is null))
                            this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

                        if (!(this.SelectedJob_And_Details.DbServerParameters is null))
                            this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

                        this.SelectedJob_And_Details.Schedule = dbContext.Schedule.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                        this.SelectedJob_And_Details.Destination_Local = dbContext.Destination_Local.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                        this.SelectedJob_And_Details.Destination_Network = dbContext.Destination_Network.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                        this.SelectedJob_And_Details.Destination_Cloud = dbContext.Destination_Cloud.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
                    }
                }
                else
                    this.SelectedJob_And_Details.selectedJob = null;

            }

            //if (!(this.SelectedJob_And_Details.selectedJob is null))
            //{

            //    this.SelectedJob_And_Details.DbServerParameters = dbContext.DbServerParameters.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();

            //    if (!(this.SelectedJob_And_Details.DbServerParameters is null))
            //        this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == this.SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

            //    if (!(this.SelectedJob_And_Details.DbServerParameters is null))
            //        this.SelectedJob_And_Details.dbNamesOnThisDbServers = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == this.SelectedJob_And_Details.DbServerParameters.Id).ToList<DbNameOnThisDbServer>();

            //    this.SelectedJob_And_Details.Schedule = dbContext.Schedule.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
            //    this.SelectedJob_And_Details.Destination_Local = dbContext.Destination_Local.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
            //    this.SelectedJob_And_Details.Destination_Network = dbContext.Destination_Network.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
            //    this.SelectedJob_And_Details.Destination_Cloud = dbContext.Destination_Cloud.Where(x => x.UserJobsId == this.SelectedJob_And_Details.selectedJob.Id).FirstOrDefault();
            //}
        }

        public void update_VM_with_schedule_with_jobName(Schedule schedule, string jN)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {

                UserJobs uj = new UserJobs();
                uj = dbContext.UserJobs.Where(x => x.name == jN).FirstOrDefault();

                var sc = dbContext.Schedule.Where(x => x.UserJobsId==uj.Id).FirstOrDefault();

                if (sc == null)
                {

                    schedule.UserJobsId = uj.Id;
                    dbContext.Schedule.Add(schedule);
                }
                else
                {
                    uj.Schedule = sc;
                }
                dbContext.SaveChanges();
            }
        }

        public void remove_VM_with_jobName(object s3)
        {
            throw new NotImplementedException();
        }

        public void create_a_job_for_a_user(int usr_ID, string uj_name)
        {
            

            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
 
                UserJobs uj = new UserJobs();
                uj.name = uj_name;
                uj.UserSqlBackupId = usr_ID;
                dbContext.UserJobs.Add(uj);
                dbContext.SaveChanges();
            }
        }
        public void update_a_job_for_a_user(int userJobID, string uj_name)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                UserJobs usr_j = dbContext.UserJobs.Find(userJobID);
                usr_j.name = uj_name;
                dbContext.SaveChanges();
            }
        }

        public void delete_a_job_from_a_usr(string jName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                UserJobs usr_j = dbContext.UserJobs.Where(x=>x.name==jName).FirstOrDefault();
                dbContext.UserJobs.Remove(usr_j);
                dbContext.SaveChanges();
            }
        }
        public void delete_a_DbServerAndDbNames_from_a_job(string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                UserJobs usr_j = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                DbServerParameters dbServerParameters = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_j.Id).FirstOrDefault();
                ICollection<DbNameOnThisDbServer> dbNames = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == dbServerParameters.Id).ToList();
                foreach(DbNameOnThisDbServer dbn in dbNames)
                {
                    dbContext.DbNameOnThisDbServer.Remove(dbn);

                }
                dbContext.DbServerParameters.Remove(dbServerParameters);
                dbContext.SaveChanges();
            }
        }
    }
}

