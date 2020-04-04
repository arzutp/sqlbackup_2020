using ClassLibrary1.Models.DomainModels;
using ClassLibrary1.Models.ViewModels;
using ClassLibrary1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp9
{

    public partial class MainFormSqlBackup : Form
    {

        public VM_Main_Form_DTO _VM_Main_Form_DTO { get; set; }
        object selectedLstBoxItem { get; set; }
        public MainFormSqlBackup(VM_Main_Form_DTO vM_Main_Form_DTO)
        {
            InitializeComponent();
            _VM_Main_Form_DTO = vM_Main_Form_DTO;
            //update_main_form_full_with_VM_Main_Form_DTO();

            this.Text = "SqlBackupTroia -- " + _VM_Main_Form_DTO.UserSqlBackup.Name + " " + _VM_Main_Form_DTO.UserSqlBackup.Lastname;
        }

        public void update_main_form_full_with_VM_Main_Form_DTO()
        {

            if (!(_VM_Main_Form_DTO.UserJobs is null))
            {
                lstBoxJobs.Items.Clear();
                foreach (var uj in _VM_Main_Form_DTO.UserJobs)
                {
                    lstBoxJobs.Items.Add(uj.name);
                    if (uj.name == _VM_Main_Form_DTO.SelectedJob_And_Details.selectedJob.name)
                        lstBoxJobs.SelectedItem = uj.name;

                }
                if (lstBoxJobs.Items.Count < 1)
                    lblJobListWarning.Visible = true;
                else
                    lblJobListWarning.Visible = false;
            }
            selectedLstBoxItem = lstBoxJobs.SelectedItem;
            //MessageBox.Show("lstBoc selected value changed ...");
            string s3 = lstBoxJobs.SelectedItem.ToString();
            //MessageBox.Show(s3);
            //string s1 = _VM_Main_Form_DTO.UserSqlBackup.AccountName.ToString();
            //string s2 = _VM_Main_Form_DTO.UserSqlBackup.Password.ToString();
            _VM_Main_Form_DTO.update_VM_with_jobName(s3);
            update_DbServer_DbNames();
            update_schedule();

        }
        public void update_Joblist()
        {
            if (!(this._VM_Main_Form_DTO.UserJobs is null))
            {
                lstBoxJobs.Items.Clear();
                foreach (var uj in this._VM_Main_Form_DTO.UserJobs)
                {
                    lstBoxJobs.Items.Add(uj.name);
                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.selectedJob!=null)
                        if (uj.name == _VM_Main_Form_DTO.SelectedJob_And_Details.selectedJob.name)
                            lstBoxJobs.SelectedItem = uj.name;
                }
            }
            update_DbServer_DbNames();
            update_schedule();
        }
        public void update_DbServer_DbNames()
        {
            try
            {
                if (!(_VM_Main_Form_DTO.SelectedJob_And_Details.DbServerParameters is null)) {
                txtBoxDbServerName.Text = _VM_Main_Form_DTO.SelectedJob_And_Details.DbServerParameters.ServerName != null ? _VM_Main_Form_DTO.SelectedJob_And_Details.DbServerParameters.ServerName.ToString() : "";
                chckBoxDbServerLogInType.Checked = _VM_Main_Form_DTO.SelectedJob_And_Details.DbServerParameters.AuthType;
                chckdLstBoxDbNamesOnDbServer.Items.Clear();
                }
                if (!(_VM_Main_Form_DTO.SelectedJob_And_Details.dbNamesOnThisDbServers is null))
                    foreach (var dBname in _VM_Main_Form_DTO.SelectedJob_And_Details.dbNamesOnThisDbServers)
                        chckdLstBoxDbNamesOnDbServer.Items.Add(dBname.Name);
                int s = _VM_Main_Form_DTO.SelectedJob_And_Details.dbNamesOnThisDbServers.Count;
                for (int i = 0; i < s; i++)
                    chckdLstBoxDbNamesOnDbServer.SetItemChecked(i, true);
                lblDBserverWarning.Visible = false;
            }
            catch
            {
                txtBoxDbServerName.Text = "";
                chckdLstBoxDbNamesOnDbServer.Items.Clear();
                lblDBserverWarning.Visible = true;
            }
            
        }

        public void update_schedule()
        {
            txtBoxScheduleHour.Text = "";
            txtBoxScheduleTimes.Text = "";
            txtBoxScheduleInterval.Text = "";
            lblDBserverWarning.Visible = true;
            for (int i = 0; i < 7; i++)
                chckdLstBoxScheduleDays.SetItemChecked(i, false);
   
            try
            {

                if (!(_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule is null))
                {
                    DateTime dt = DateTime.Parse(_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.StartDateTime.ToString());
                    txtBoxScheduleHour.Text = dt.ToString("HH:mm");

                    txtBoxScheduleTimes.Text = _VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.howmanyBackup.ToString();
                    //txtBoxScheduleHour.Text = _VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.StartDateTime.ToString();
                    txtBoxScheduleInterval.Text = _VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.interval.ToString();


                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.IsMonday)
                        chckdLstBoxScheduleDays.SetItemChecked(0, true);
                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.IsTuesday)
                        chckdLstBoxScheduleDays.SetItemChecked(1, true);
                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.IsWednesday)
                        chckdLstBoxScheduleDays.SetItemChecked(2, true);
                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.IsThursday)
                        chckdLstBoxScheduleDays.SetItemChecked(3, true);
                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.IsFriday)
                        chckdLstBoxScheduleDays.SetItemChecked(4, true);
                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.IsSaturday)
                        chckdLstBoxScheduleDays.SetItemChecked(5, true);
                    if (_VM_Main_Form_DTO.SelectedJob_And_Details.Schedule.IsSunday)
                        chckdLstBoxScheduleDays.SetItemChecked(6, true);

                    lblDBserverWarning.Visible = false;

                }

            }
            catch
            {
               txtBoxScheduleHour.Text = "";

                txtBoxScheduleTimes.Text = "";

                txtBoxScheduleInterval.Text = "";

                for (int i=0;i<7;i++)
                    chckdLstBoxScheduleDays.SetItemChecked(i, false);
                lblScheduleWarning.Visible = true;
            }

        }


        private void btnJobsNew_Click(object sender, EventArgs e)
        {
            createNewJobForm createNewJobForm = new createNewJobForm(_VM_Main_Form_DTO,this);

            createNewJobForm.Show();
            this.Hide();
        }

        //private void lstBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //if(!(VM_Main_Form_DTO.UserSqlBackup is null))
        //    //{
        //    //    string s1 = VM_Main_Form_DTO.UserSqlBackup.AccountName;
        //    //    string s2 = VM_Main_Form_DTO.UserSqlBackup.Password;
        //    //    string s3 = lstBoxJobs.SelectedItem.ToString();
        //    //    VM_Main_Form_DTO.get_VM_Main_Form_DTO(s3);
        //    //    update_main_form_with_VM_Main_Form_DTO();
        //    //}
        //}

        private void btnJobsDelete_Click(object sender, EventArgs e)
        {

        }



        private void lstBoxJobs_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lstBoxJobs_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedLstBoxItem != lstBoxJobs.SelectedItem)
            { 
                   
                selectedLstBoxItem = lstBoxJobs.SelectedItem;
                //MessageBox.Show("lstBoc selected value changed ...");
                string s3 = lstBoxJobs.SelectedItem.ToString();
                //MessageBox.Show(s3);
                //string s1 = _VM_Main_Form_DTO.UserSqlBackup.AccountName.ToString();
                //string s2 = _VM_Main_Form_DTO.UserSqlBackup.Password.ToString();
                _VM_Main_Form_DTO.update_VM_with_jobName(s3);
                update_DbServer_DbNames();
                update_schedule();

            }


        }

        private void btnDbServerDelete_Click(object sender, EventArgs e)
        {
            _VM_Main_Form_DTO.delete_a_DbServerAndDbNames_from_a_job(selectedLstBoxItem.ToString());
            _VM_Main_Form_DTO.update_VM_with_jobName(selectedLstBoxItem.ToString());
            update_Joblist();
            update_DbServer_DbNames();
        }

        private void btnScheduleNew_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jN = lstBoxJobs.SelectedItem.ToString();

            //MessageBox.Show(jN);
            _VM_Main_Form_DTO.update_VM_with_jobName(jN);
            update_DbServer_DbNames();
            update_schedule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
