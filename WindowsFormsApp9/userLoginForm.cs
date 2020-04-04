using ClassLibrary1.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ClassLibrary1.Utility;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Models.ViewModels;

namespace WindowsFormsApp9
{
    public partial class userLoginForm : Form
    {
        //Main_Form_DTO Main_Form_DTO { get; set; }
        //VM_Main_Form_DTO _VM_Main_Form_DTO { get; set; }
        //public userLoginForm()
        //{
        //    //_VM_Main_Form_DTO = vM_Main_Form_DTO;
        //    InitializeComponent();
        //}
        public userLoginForm()
        {
            //Main_Form_DTO = main_Form_DTO;
            InitializeComponent();
        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            userJobsForm userRegisterForm = new userJobsForm(this);
            userRegisterForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Main_Form_DTO main_Form_DTO = new Main_Form_DTO();

            //main_Form_DTO = Views_Tools.get_main_form_DTO_from_dbContext(txtBoxUserName.Text.ToString(), txtBoxUserPass.Text.ToString());

            VM_Main_Form_DTO vM_Main_Form_DTO = new VM_Main_Form_DTO();
            vM_Main_Form_DTO.update_VM_with_accountName_pass(txtBoxUserName.Text.ToString(), txtBoxUserPass.Text.ToString());
            
            if (vM_Main_Form_DTO.UserSqlBackup is null)
                MessageBox.Show("user not exists");
            else
                {
                MainFormSqlBackup mainFormSqlBackup = new MainFormSqlBackup(vM_Main_Form_DTO);
                mainFormSqlBackup.update_main_form_full_with_VM_Main_Form_DTO();
                mainFormSqlBackup.Show();
                this.Visible = false;
                }


        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "" || txtBoxUserPass.Text == "")
                btnLogIn.Enabled = false;
            else
                btnLogIn.Enabled = true;
        }

        private void txtBoxUserPass_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "" || txtBoxUserPass.Text == "")
                btnLogIn.Enabled = false;
            else
                btnLogIn.Enabled = true;
        }
    }
}
