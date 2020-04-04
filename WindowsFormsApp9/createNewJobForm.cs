using ClassLibrary1.Models.DomainModels;
using ClassLibrary1.Models.ViewModels;
using ClassLibrary1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class createNewJobForm : Form
    {
        VM_Main_Form_DTO _main_Form_DTO { get; set; }
        MainFormSqlBackup _MainFormSqlBackup{ get; set; }

        public createNewJobForm(VM_Main_Form_DTO main_Form_DTO, MainFormSqlBackup mainFormSqlBackup)
        {
            this._main_Form_DTO = main_Form_DTO;
            this._MainFormSqlBackup = mainFormSqlBackup;
            InitializeComponent();
        }

        private void createNewJobForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string jName = txtBoxJobName.Text.ToString();
            int usrId = _main_Form_DTO.UserSqlBackup.Id;

            _main_Form_DTO.create_a_job_for_a_user(usrId, jName);

            string name = _main_Form_DTO.UserSqlBackup.AccountName.ToString();
            string pass= _main_Form_DTO.UserSqlBackup.Password.ToString();
            _main_Form_DTO.update_VM_with_accountName_pass(name, pass.decryption(),jName);
            this._MainFormSqlBackup.update_main_form_full_with_VM_Main_Form_DTO();
            this._MainFormSqlBackup.Show();

            this.Hide();



            //string jN = lstBoxJobs.SelectedItem.ToString();
            ////_VM_Main_Form_DTO.delete_a_job_from_a_usr(jN);
            //string accountName = _VM_Main_Form_DTO.UserSqlBackup.AccountName;
            //string pass = _VM_Main_Form_DTO.UserSqlBackup.Password.decryption();

            //_VM_Main_Form_DTO.update_VM_with_accountName_pass(accountName, pass, jN);
            //this.update_main_form_full_with_VM_Main_Form_DTO();




        }
    }
}
