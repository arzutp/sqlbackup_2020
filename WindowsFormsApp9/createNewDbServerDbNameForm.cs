using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1.Models.DomainModels;
using ClassLibrary1.Models.ViewModels;
using ClassLibrary1.Utility;


namespace WindowsFormsApp9
{
    public partial class createNewDbServerDbNameForm : Form
    {

        VM_Main_Form_DTO _vM_Main_Form_DTO { get; set; }
        MainFormSqlBackup _mainFormSqlBackup{ get; set; }

        public createNewDbServerDbNameForm(VM_Main_Form_DTO vM_Main_Form_DTO, MainFormSqlBackup mainFormSqlBackup)
        {
            _vM_Main_Form_DTO = vM_Main_Form_DTO;
            _mainFormSqlBackup = mainFormSqlBackup;

            InitializeComponent();
        }

        private void btnConnectDb_Click(object sender, EventArgs e)
        {
            BackupJobs backupJobs = new BackupJobs();
            List<string> db_names=backupJobs.get_all_dbNames_from_server(txtBoxDbServerName.Text.ToString(), txtBoxDbServerUserName.Text.ToString(), txtBoxDbServerPass.Text.ToString());
            int i =0;
            foreach (String s in db_names)
                chckdLstBoxDbNamesOnDbServer.Items.Add(s);
            MessageBox.Show(" db bağlantısı sağlandı, listeden yedekleme yapılacak db leri seciniz ...");
            // DESKTOP-H80HOLB
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
               DbServerParameters dbServerParameters = new DbServerParameters();

                dbServerParameters.AuthType = chckBoxDbServerLogInType.Checked;
                dbServerParameters.ServerName = txtBoxDbServerName.Text.ToString();
                dbServerParameters.UserName = txtBoxDbServerUserName.Text.ToString();
                dbServerParameters.Password = txtBoxDbServerPass.Text.ToString();

                ////List<ListItem> selected = new List<ListItem>();
                //foreach (var item in chckdLstBoxDbNamesOnDbServer.Items)
                //    dbNameOnThisDbServer.Name = item.name;
                List<DbNameOnThisDbServer> dbNameOnThisDbServerList = new List<DbNameOnThisDbServer>();
                foreach (var item in chckdLstBoxDbNamesOnDbServer.CheckedItems)
                {
                    DbNameOnThisDbServer dbNameOnThisDbServer = new DbNameOnThisDbServer
                    {
                        Name = item.ToString(),
                        IsSelected = true
                    };
                    dbNameOnThisDbServerList.Add(dbNameOnThisDbServer);
                }
            dbServerParameters.DatabasesOnThisServer = dbNameOnThisDbServerList;

                using (DbContextSqlBackup  dbContext =new DbContextSqlBackup())
            {
                foreach( var uj in dbContext.UserJobs)
                {
                    if (uj.name == _vM_Main_Form_DTO.SelectedJob_And_Details.selectedJob.name)
                        if (uj.DbServerParameters is null)
                        {
                            uj.DbServerParameters = dbServerParameters;
                            //dbContext.SaveChanges();
                        }
                        else
                        {
                            //uj.DbServerParameters = null;
                            dbContext.DbServerParameters.Remove(uj.DbServerParameters);
                            //uj.DbServerParameters = null;
                            dbContext.SaveChanges();
                            uj.DbServerParameters = dbServerParameters;
                            //dbContext.SaveChanges();
                        }

                    

                }
                dbContext.SaveChanges();
                
            }

            
            string name = _vM_Main_Form_DTO.UserSqlBackup.AccountName.ToString();
            string pass = _vM_Main_Form_DTO.UserSqlBackup.Password.ToString();
            string jName = _vM_Main_Form_DTO.SelectedJob_And_Details.selectedJob.name;
            _vM_Main_Form_DTO.update_VM_with_accountName_pass(name, pass.decryption(), jName);
            this._mainFormSqlBackup.update_main_form_full_with_VM_Main_Form_DTO();
            this._mainFormSqlBackup.Show();
            this.Hide();


        }

       
    }
}
