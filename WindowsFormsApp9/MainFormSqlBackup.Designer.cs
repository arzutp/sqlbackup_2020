namespace WindowsFormsApp9
{
    partial class MainFormSqlBackup
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblScheduleWarning = new System.Windows.Forms.Label();
            this.btnScheduleNew = new System.Windows.Forms.Button();
            this.btnScheduleUpdate = new System.Windows.Forms.Button();
            this.btnScheduleDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxScheduleTimes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxScheduleInterval = new System.Windows.Forms.TextBox();
            this.txtBoxScheduleHour = new System.Windows.Forms.TextBox();
            this.chckdLstBoxScheduleDays = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDBserverWarning = new System.Windows.Forms.Label();
            this.btnDbServerUpdate = new System.Windows.Forms.Button();
            this.btnDbServerNew = new System.Windows.Forms.Button();
            this.btnDbServerDelete = new System.Windows.Forms.Button();
            this.chckBoxDbServerLogInType = new System.Windows.Forms.CheckBox();
            this.txtBoxDbServerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDbServerUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDbServerPass = new System.Windows.Forms.TextBox();
            this.chckdLstBoxDbNamesOnDbServer = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblJobListWarning = new System.Windows.Forms.Label();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnJobsNew = new System.Windows.Forms.Button();
            this.btnJobsDelete = new System.Windows.Forms.Button();
            this.lstBoxJobs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "yedekleme ayarları";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.lblScheduleWarning);
            this.groupBox3.Controls.Add(this.btnScheduleNew);
            this.groupBox3.Controls.Add(this.btnScheduleUpdate);
            this.groupBox3.Controls.Add(this.btnScheduleDelete);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtBoxScheduleTimes);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtBoxScheduleInterval);
            this.groupBox3.Controls.Add(this.txtBoxScheduleHour);
            this.groupBox3.Controls.Add(this.chckdLstBoxScheduleDays);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(589, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 220);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "zamanlama ayarları";
            // 
            // lblScheduleWarning
            // 
            this.lblScheduleWarning.AutoSize = true;
            this.lblScheduleWarning.BackColor = System.Drawing.Color.Coral;
            this.lblScheduleWarning.Location = new System.Drawing.Point(28, 178);
            this.lblScheduleWarning.Name = "lblScheduleWarning";
            this.lblScheduleWarning.Size = new System.Drawing.Size(223, 15);
            this.lblScheduleWarning.TabIndex = 23;
            this.lblScheduleWarning.Text = "henüz zamanlama bilgisi oluşturulmamış";
            this.lblScheduleWarning.Visible = false;
            // 
            // btnScheduleNew
            // 
            this.btnScheduleNew.Enabled = false;
            this.btnScheduleNew.Location = new System.Drawing.Point(190, 197);
            this.btnScheduleNew.Name = "btnScheduleNew";
            this.btnScheduleNew.Size = new System.Drawing.Size(75, 23);
            this.btnScheduleNew.TabIndex = 20;
            this.btnScheduleNew.Text = "yeni";
            this.btnScheduleNew.UseVisualStyleBackColor = true;
            this.btnScheduleNew.Click += new System.EventHandler(this.btnScheduleNew_Click);
            // 
            // btnScheduleUpdate
            // 
            this.btnScheduleUpdate.Enabled = false;
            this.btnScheduleUpdate.Location = new System.Drawing.Point(109, 197);
            this.btnScheduleUpdate.Name = "btnScheduleUpdate";
            this.btnScheduleUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnScheduleUpdate.TabIndex = 21;
            this.btnScheduleUpdate.Text = "güncelle";
            this.btnScheduleUpdate.UseVisualStyleBackColor = true;
            // 
            // btnScheduleDelete
            // 
            this.btnScheduleDelete.Enabled = false;
            this.btnScheduleDelete.Location = new System.Drawing.Point(28, 197);
            this.btnScheduleDelete.Name = "btnScheduleDelete";
            this.btnScheduleDelete.Size = new System.Drawing.Size(75, 23);
            this.btnScheduleDelete.TabIndex = 22;
            this.btnScheduleDelete.Text = "sil";
            this.btnScheduleDelete.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "saat";
            // 
            // txtBoxScheduleTimes
            // 
            this.txtBoxScheduleTimes.Enabled = false;
            this.txtBoxScheduleTimes.Location = new System.Drawing.Point(244, 99);
            this.txtBoxScheduleTimes.Name = "txtBoxScheduleTimes";
            this.txtBoxScheduleTimes.Size = new System.Drawing.Size(21, 23);
            this.txtBoxScheduleTimes.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "tekrar sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "aralık(saat)";
            // 
            // txtBoxScheduleInterval
            // 
            this.txtBoxScheduleInterval.Enabled = false;
            this.txtBoxScheduleInterval.Location = new System.Drawing.Point(244, 68);
            this.txtBoxScheduleInterval.Name = "txtBoxScheduleInterval";
            this.txtBoxScheduleInterval.Size = new System.Drawing.Size(21, 23);
            this.txtBoxScheduleInterval.TabIndex = 18;
            // 
            // txtBoxScheduleHour
            // 
            this.txtBoxScheduleHour.Enabled = false;
            this.txtBoxScheduleHour.Location = new System.Drawing.Point(204, 37);
            this.txtBoxScheduleHour.Name = "txtBoxScheduleHour";
            this.txtBoxScheduleHour.Size = new System.Drawing.Size(61, 23);
            this.txtBoxScheduleHour.TabIndex = 14;
            // 
            // chckdLstBoxScheduleDays
            // 
            this.chckdLstBoxScheduleDays.Enabled = false;
            this.chckdLstBoxScheduleDays.FormattingEnabled = true;
            this.chckdLstBoxScheduleDays.Items.AddRange(new object[] {
            "pazartesi",
            "salı",
            "çarşamba",
            "perşembe",
            "cuma",
            "cumartesi",
            "pazar"});
            this.chckdLstBoxScheduleDays.Location = new System.Drawing.Point(6, 37);
            this.chckdLstBoxScheduleDays.Name = "chckdLstBoxScheduleDays";
            this.chckdLstBoxScheduleDays.Size = new System.Drawing.Size(147, 130);
            this.chckdLstBoxScheduleDays.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "yedekleme alınacak günler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.lblDBserverWarning);
            this.groupBox2.Controls.Add(this.btnDbServerUpdate);
            this.groupBox2.Controls.Add(this.btnDbServerNew);
            this.groupBox2.Controls.Add(this.btnDbServerDelete);
            this.groupBox2.Controls.Add(this.chckBoxDbServerLogInType);
            this.groupBox2.Controls.Add(this.txtBoxDbServerName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxDbServerUserName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxDbServerPass);
            this.groupBox2.Controls.Add(this.chckdLstBoxDbNamesOnDbServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(225, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 220);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "veritabanı ayarları";
            // 
            // lblDBserverWarning
            // 
            this.lblDBserverWarning.AutoSize = true;
            this.lblDBserverWarning.BackColor = System.Drawing.Color.Coral;
            this.lblDBserverWarning.Location = new System.Drawing.Point(86, 178);
            this.lblDBserverWarning.Name = "lblDBserverWarning";
            this.lblDBserverWarning.Size = new System.Drawing.Size(209, 15);
            this.lblDBserverWarning.TabIndex = 19;
            this.lblDBserverWarning.Text = "henüz bir DB server tanımı yapılmamış";
            this.lblDBserverWarning.Visible = false;
            // 
            // btnDbServerUpdate
            // 
            this.btnDbServerUpdate.Enabled = false;
            this.btnDbServerUpdate.Location = new System.Drawing.Point(160, 197);
            this.btnDbServerUpdate.Name = "btnDbServerUpdate";
            this.btnDbServerUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDbServerUpdate.TabIndex = 16;
            this.btnDbServerUpdate.Text = "güncelle";
            this.btnDbServerUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDbServerNew
            // 
            this.btnDbServerNew.Enabled = false;
            this.btnDbServerNew.Location = new System.Drawing.Point(251, 197);
            this.btnDbServerNew.Name = "btnDbServerNew";
            this.btnDbServerNew.Size = new System.Drawing.Size(75, 23);
            this.btnDbServerNew.TabIndex = 18;
            this.btnDbServerNew.Text = "yeni";
            this.btnDbServerNew.UseVisualStyleBackColor = true;
            // 
            // btnDbServerDelete
            // 
            this.btnDbServerDelete.Enabled = false;
            this.btnDbServerDelete.Location = new System.Drawing.Point(58, 197);
            this.btnDbServerDelete.Name = "btnDbServerDelete";
            this.btnDbServerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDbServerDelete.TabIndex = 17;
            this.btnDbServerDelete.Text = "sil";
            this.btnDbServerDelete.UseVisualStyleBackColor = true;
            this.btnDbServerDelete.Click += new System.EventHandler(this.btnDbServerDelete_Click);
            // 
            // chckBoxDbServerLogInType
            // 
            this.chckBoxDbServerLogInType.AutoSize = true;
            this.chckBoxDbServerLogInType.Enabled = false;
            this.chckBoxDbServerLogInType.Location = new System.Drawing.Point(22, 63);
            this.chckBoxDbServerLogInType.Name = "chckBoxDbServerLogInType";
            this.chckBoxDbServerLogInType.Size = new System.Drawing.Size(128, 19);
            this.chckBoxDbServerLogInType.TabIndex = 15;
            this.chckBoxDbServerLogInType.Text = "window user log-in";
            this.chckBoxDbServerLogInType.UseVisualStyleBackColor = true;
            // 
            // txtBoxDbServerName
            // 
            this.txtBoxDbServerName.Enabled = false;
            this.txtBoxDbServerName.Location = new System.Drawing.Point(22, 34);
            this.txtBoxDbServerName.Name = "txtBoxDbServerName";
            this.txtBoxDbServerName.Size = new System.Drawing.Size(128, 23);
            this.txtBoxDbServerName.TabIndex = 4;
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
            this.txtBoxDbServerUserName.Enabled = false;
            this.txtBoxDbServerUserName.Location = new System.Drawing.Point(24, 102);
            this.txtBoxDbServerUserName.Name = "txtBoxDbServerUserName";
            this.txtBoxDbServerUserName.Size = new System.Drawing.Size(70, 23);
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
            this.txtBoxDbServerPass.Enabled = false;
            this.txtBoxDbServerPass.Location = new System.Drawing.Point(22, 144);
            this.txtBoxDbServerPass.Name = "txtBoxDbServerPass";
            this.txtBoxDbServerPass.Size = new System.Drawing.Size(72, 23);
            this.txtBoxDbServerPass.TabIndex = 8;
            // 
            // chckdLstBoxDbNamesOnDbServer
            // 
            this.chckdLstBoxDbNamesOnDbServer.Enabled = false;
            this.chckdLstBoxDbNamesOnDbServer.FormattingEnabled = true;
            this.chckdLstBoxDbNamesOnDbServer.Location = new System.Drawing.Point(160, 27);
            this.chckdLstBoxDbNamesOnDbServer.Name = "chckdLstBoxDbNamesOnDbServer";
            this.chckdLstBoxDbNamesOnDbServer.Size = new System.Drawing.Size(166, 148);
            this.chckdLstBoxDbNamesOnDbServer.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "yedeklenecek veritabanları";
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.lblJobListWarning);
            this.groupBox4.Controls.Add(this.btnLogs);
            this.groupBox4.Controls.Add(this.btnJobsNew);
            this.groupBox4.Controls.Add(this.btnJobsDelete);
            this.groupBox4.Controls.Add(this.lstBoxJobs);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(16, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 220);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "görevler";
            // 
            // lblJobListWarning
            // 
            this.lblJobListWarning.AutoSize = true;
            this.lblJobListWarning.BackColor = System.Drawing.Color.Coral;
            this.lblJobListWarning.Location = new System.Drawing.Point(2, 179);
            this.lblJobListWarning.Name = "lblJobListWarning";
            this.lblJobListWarning.Size = new System.Drawing.Size(190, 15);
            this.lblJobListWarning.TabIndex = 14;
            this.lblJobListWarning.Text = "henüz bir görev tanımı yapılmamış";
            this.btnJobsNew.Enabled = true;
            this.lblJobListWarning.Visible = false;
            // 
            // btnLogs
            // 
            this.btnLogs.Enabled = false;
            this.btnLogs.Location = new System.Drawing.Point(6, 197);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(79, 23);
            this.btnLogs.TabIndex = 13;
            this.btnLogs.Text = "logs-tarihçe";
            this.btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnJobsNew
            // 
            this.btnJobsNew.Location = new System.Drawing.Point(135, 197);
            this.btnJobsNew.Name = "btnJobsNew";
            this.btnJobsNew.Size = new System.Drawing.Size(41, 23);
            this.btnJobsNew.TabIndex = 11;
            this.btnJobsNew.Text = "ekle";
            this.btnJobsNew.UseVisualStyleBackColor = true;
            this.btnJobsNew.Click += new System.EventHandler(this.btnJobsNew_Click);
            // 
            // btnJobsDelete
            // 
            this.btnJobsDelete.Enabled = false;
            this.btnJobsDelete.Location = new System.Drawing.Point(91, 197);
            this.btnJobsDelete.Name = "btnJobsDelete";
            this.btnJobsDelete.Size = new System.Drawing.Size(38, 23);
            this.btnJobsDelete.TabIndex = 12;
            this.btnJobsDelete.Text = "sil";
            this.btnJobsDelete.UseVisualStyleBackColor = true;
            this.btnJobsDelete.Click += new System.EventHandler(this.btnJobsDelete_Click);
            // 
            // lstBoxJobs
            // 
            this.lstBoxJobs.FormattingEnabled = true;
            this.lstBoxJobs.ItemHeight = 15;
            this.lstBoxJobs.Location = new System.Drawing.Point(6, 22);
            this.lstBoxJobs.Name = "lstBoxJobs";
            this.lstBoxJobs.Size = new System.Drawing.Size(180, 154);
            this.lstBoxJobs.TabIndex = 10;
            this.lstBoxJobs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxJobs_MouseClick);
            this.lstBoxJobs.SelectedIndexChanged += new System.EventHandler(this.lstBoxJobs_SelectedIndexChanged);
            this.lstBoxJobs.SelectedValueChanged += new System.EventHandler(this.lstBoxJobs_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFormSqlBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFormSqlBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlBackupTroia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxScheduleHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chckdLstBoxScheduleDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDbServerPass;
        private System.Windows.Forms.TextBox txtBoxDbServerUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chckdLstBoxDbNamesOnDbServer;
        private System.Windows.Forms.ListBox lstBoxJobs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDbServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxScheduleInterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxScheduleTimes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chckBoxDbServerLogInType;
        private System.Windows.Forms.Button btnJobsDelete;
        private System.Windows.Forms.Button btnJobsNew;
        private System.Windows.Forms.Button btnDbServerUpdate;
        private System.Windows.Forms.Button btnDbServerDelete;
        private System.Windows.Forms.Button btnDbServerNew;
        private System.Windows.Forms.Button btnScheduleDelete;
        private System.Windows.Forms.Button btnScheduleNew;
        private System.Windows.Forms.Button btnScheduleUpdate;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Label lblDBserverWarning;
        private System.Windows.Forms.Label lblScheduleWarning;
        private System.Windows.Forms.Label lblJobListWarning;
        private System.Windows.Forms.Button button1;
    }
}