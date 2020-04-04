using ClassLibrary1.Models.DomainModels;
using ClassLibrary1.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Models.ViewModels
{
    public class Repository
    {
        //public VM_Main_Form_DTO _VM_Main_Form_DTO { get; set; }
        public Repository()
        {
            //_VM_Main_Form_DTO = new VM_Main_Form_DTO();
        }
        
        public UserSqlBackup UserSqlBackup_GET_from_name_and_pass_(string name,string pass)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr = dbContext.User.Where(x => x.AccountName == name && x.Password == pass.encryption()).FirstOrDefault();
                return usr;
            }
        }
        public void UserSqlBackup_CREATE_(UserSqlBackup usr)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                dbContext.User.Add(usr);
                dbContext.SaveChanges();
                
            }

        }
        public void UserSqlBackup_update(UserSqlBackup _usr)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr = dbContext.User.Find(_usr.Id);

                usr.Name = _usr.Name;
                usr.AccountName = _usr.AccountName;
                usr.Password = _usr.Password;
                usr.Lastname = _usr.Lastname;

               
                dbContext.SaveChanges();

            }

        }
        public void UserSqlBackup_DELETE(UserSqlBackup _usr)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr = dbContext.User.Find(_usr.Id);

                dbContext.User.Remove(usr);

                dbContext.SaveChanges();

            }

        }
        public List<UserJobs> UserJobs_GET_for_a_user(UserSqlBackup usr)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_jobs = dbContext.UserJobs.Where(x => x.UserSqlBackupId == usr.Id).ToList();
                return usr_jobs;
            }
        }
        public UserJobs UserJobs_GET_for_a_user_and_jobName(UserSqlBackup usr,string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.UserSqlBackupId == usr.Id && x.name==jobName).FirstOrDefault();
                return usr_selected_job;
            }
        }
        public void UserJobs_CREATE_for_a_user_and_jobName(UserSqlBackup _usr, UserJobs uj)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr = dbContext.User.Find(_usr.Id);
                usr.UserJobs.Add(uj);
                dbContext.SaveChanges();
          }
        }
        public void UserJobs_REMOVE_for_a_user(UserSqlBackup _usr, UserJobs uj)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr = dbContext.User.Find(_usr.Id);
                usr.UserJobs.Add(uj);
                dbContext.SaveChanges();
            }
        }


        public DbServerParameters DB_Server_Parameters_GET_for_job(string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var jobDatabaseServerParameter = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();
              
                return jobDatabaseServerParameter;
            }
        }
        public DbServerParameters DB_Server_Parameters_CREATE_for_job(DbServerParameters dbServerParameters,UserJobs usrJob)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
               dbServerParameters.UserJobsId = usrJob.Id;
               dbContext.DbServerParameters.Add(dbServerParameters);
               dbContext.SaveChanges();
            }
            return dbServerParameters;
        }
        

        public DbServerParameters DB_Server_Parameters_UPDATE_for_job(string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var jobDatabaseServerParameter = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();

                return jobDatabaseServerParameter;
            }
        }
        public DbServerParameters DB_Server_Parameters_Remove_for_job(string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var jobDatabaseServerParameter = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();

                return jobDatabaseServerParameter;
            }
        }

        public List<DbNameOnThisDbServer> dBNames_GET_for_job(string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var jobDatabaseServerParameter = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();
                var dBNames = dbContext.DbNameOnThisDbServer.Where(x => x.DbServerParametersId == jobDatabaseServerParameter.Id).ToList();
                return dBNames;
            }
        }
        public void dBNames_Create_for_job(List<DbNameOnThisDbServer> dbNames,string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var jobDatabaseServerParameter = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();
                foreach(var dbn in dbNames)
                {
                    dbn.DbServerParametersId = jobDatabaseServerParameter.Id;
                    dbContext.DbNameOnThisDbServer.Add(dbn);
                }
                dbContext.SaveChanges();             
            }
        }
        public void dBNames_Update_for_job(List<DbNameOnThisDbServer> dbNames, string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var jobDatabaseServerParameter = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();
                foreach (var dbn in dbNames)
                {
                    dbn.DbServerParametersId = jobDatabaseServerParameter.Id;
                    dbContext.DbNameOnThisDbServer.Add(dbn);
                }
                dbContext.SaveChanges();
            }
        }
        public void dBNames_Remove_for_job(List<DbNameOnThisDbServer> dbNames, string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var jobDatabaseServerParameter = dbContext.DbServerParameters.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();
                foreach (var dbn in dbNames)
                {
                    dbn.DbServerParametersId = jobDatabaseServerParameter.Id;
                    dbContext.DbNameOnThisDbServer.Add(dbn);
                }
                dbContext.SaveChanges();
            }
        }
        public Schedule schedule_GET_for_job(string jobName)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                var usr_selected_job = dbContext.UserJobs.Where(x => x.name == jobName).FirstOrDefault();
                var schedule = dbContext.Schedule.Where(x => x.UserJobsId == usr_selected_job.Id).FirstOrDefault();
                return schedule;
            }
        }
        public Schedule schedule_Update_for_job(Schedule schedule,UserJobs userJob)
        {

            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                Schedule _schedule = dbContext.Schedule.Where(x => x.UserJobsId == userJob.Id).FirstOrDefault();
                
                _schedule.IsMonday=schedule.IsMonday;
                _schedule.IsThursday = schedule.IsThursday;
                _schedule.IsWednesday = schedule.IsWednesday;
                _schedule.IsTuesday = schedule.IsTuesday;
                _schedule.IsFriday = schedule.IsFriday;
                _schedule.IsSaturday = schedule.IsSaturday;
                _schedule.IsSunday = schedule.IsSunday;

                _schedule.howmanyBackup = schedule.howmanyBackup;
                _schedule.interval = schedule.interval;
                _schedule.StartDateTime = schedule.StartDateTime;

                dbContext.Schedule.Update(_schedule);

                dbContext.SaveChanges();
                return _schedule;
            }
        }
        public Schedule schedule_Create_for_a_job(Schedule schedule,UserJobs userJob)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                schedule.UserJobsId = userJob.Id;
                dbContext.Schedule.Add(schedule);
                dbContext.SaveChanges();
                return schedule;
            }

        }
        public void schedule_Delete_for_a_job(Schedule schedule)
        {
            using (DbContextSqlBackup dbContext = new DbContextSqlBackup())
            {
                
                dbContext.Schedule.Remove(schedule);
                dbContext.SaveChanges();
                
            }

        }

    }
}
