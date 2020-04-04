using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1.Models.DomainModels;
using ClassLibrary1.Utility;

namespace WindowsFormsApp9
{
    public partial class userJobsForm : Form
    {
        userLoginForm parentForm { get; set; }
        public userJobsForm(userLoginForm userLoginForm)
        {
            this.parentForm = userLoginForm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.parentForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //utility utility = new utility();

            UserSqlBackup UserSqlBackup = new UserSqlBackup();
            UserSqlBackup.Name = txtBoxName.Text.ToString();
            UserSqlBackup.Lastname = txtBoxLastName.Text.ToString();
            UserSqlBackup.AccountName = txtBoxNickName.Text.ToString();
            UserSqlBackup.Password = utility.encryption(txtBoxUserPass.Text.ToString());
            //UserSqlBackup.CompanyName = txtCompanyName.Text.ToString();

            using (var dbContext = new DbContextSqlBackup())
            {
                dbContext.User.Add(UserSqlBackup);
                dbContext.SaveChanges();

            }
            MessageBox.Show(" kayıt yapıldı ...");
        }
    }
}
