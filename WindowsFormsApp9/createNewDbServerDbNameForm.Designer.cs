namespace WindowsFormsApp9
{
    partial class createNewDbServerDbNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnectDb = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDbServerName = new System.Windows.Forms.TextBox();
            this.chckBoxDbServerLogInType = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDbServerUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDbServerPass = new System.Windows.Forms.TextBox();
            this.chckdLstBoxDbNamesOnDbServer = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConnectDb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBoxDbServerName);
            this.groupBox1.Controls.Add(this.chckBoxDbServerLogInType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxDbServerUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxDbServerPass);
            this.groupBox1.Controls.Add(this.chckdLstBoxDbNamesOnDbServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 225);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "veritabanı ayarları";
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(257, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "iptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConnectDb
            // 
            this.btnConnectDb.Location = new System.Drawing.Point(22, 173);
            this.btnConnectDb.Name = "btnConnectDb";
            this.btnConnectDb.Size = new System.Drawing.Size(58, 23);
            this.btnConnectDb.TabIndex = 19;
            this.btnConnectDb.Text = "bağlan";
            this.btnConnectDb.UseVisualStyleBackColor = true;
            this.btnConnectDb.Click += new System.EventHandler(this.btnConnectDb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "yedeklenecek veritabanları";
            // 
            // txtBoxDbServerName
            // 
            this.txtBoxDbServerName.Location = new System.Drawing.Point(10, 34);
            this.txtBoxDbServerName.Name = "txtBoxDbServerName";
            this.txtBoxDbServerName.Size = new System.Drawing.Size(111, 23);
            this.txtBoxDbServerName.TabIndex = 4;
            this.txtBoxDbServerName.Text = "DESKTOP-H80HOLB";
            // 
            // chckBoxDbServerLogInType
            // 
            this.chckBoxDbServerLogInType.AutoSize = true;
            this.chckBoxDbServerLogInType.Location = new System.Drawing.Point(22, 63);
            this.chckBoxDbServerLogInType.Name = "chckBoxDbServerLogInType";
            this.chckBoxDbServerLogInType.Size = new System.Drawing.Size(128, 19);
            this.chckBoxDbServerLogInType.TabIndex = 15;
            this.chckBoxDbServerLogInType.Text = "window user log-in";
            this.chckBoxDbServerLogInType.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "kullanıcı adı";
            // 
            // txtBoxDbServerUserName
            // 
            this.txtBoxDbServerUserName.Location = new System.Drawing.Point(24, 102);
            this.txtBoxDbServerUserName.Name = "txtBoxDbServerUserName";
            this.txtBoxDbServerUserName.Size = new System.Drawing.Size(112, 23);
            this.txtBoxDbServerUserName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "kullanıcı şifresi";
            // 
            // txtBoxDbServerPass
            // 
            this.txtBoxDbServerPass.Location = new System.Drawing.Point(22, 144);
            this.txtBoxDbServerPass.Name = "txtBoxDbServerPass";
            this.txtBoxDbServerPass.Size = new System.Drawing.Size(112, 23);
            this.txtBoxDbServerPass.TabIndex = 8;
            // 
            // chckdLstBoxDbNamesOnDbServer
            // 
            this.chckdLstBoxDbNamesOnDbServer.FormattingEnabled = true;
            this.chckdLstBoxDbNamesOnDbServer.Location = new System.Drawing.Point(160, 27);
            this.chckdLstBoxDbNamesOnDbServer.Name = "chckdLstBoxDbNamesOnDbServer";
            this.chckdLstBoxDbNamesOnDbServer.Size = new System.Drawing.Size(166, 148);
            this.chckdLstBoxDbNamesOnDbServer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "server adı";
            // 
            // createNewDbServerDbNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "createNewDbServerDbNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createNewDbServerDbNameForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnectDb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDbServerName;
        private System.Windows.Forms.CheckBox chckBoxDbServerLogInType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDbServerUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDbServerPass;
        private System.Windows.Forms.CheckedListBox chckdLstBoxDbNamesOnDbServer;
        private System.Windows.Forms.Label label3;
    }
}