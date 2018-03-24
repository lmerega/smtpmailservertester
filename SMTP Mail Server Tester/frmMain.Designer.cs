namespace SMTP_Mail_Server_Tester
{
    partial class frmMain
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
            this.gb01 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHostName = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkBokSSL = new System.Windows.Forms.CheckBox();
            this.gb01.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb01
            // 
            this.gb01.Controls.Add(this.chkBokSSL);
            this.gb01.Controls.Add(this.lblStatus);
            this.gb01.Controls.Add(this.txtTo);
            this.gb01.Controls.Add(this.lblTo);
            this.gb01.Controls.Add(this.txtFrom);
            this.gb01.Controls.Add(this.lblFrom);
            this.gb01.Controls.Add(this.txtPassword);
            this.gb01.Controls.Add(this.lblPassword);
            this.gb01.Controls.Add(this.txtUsername);
            this.gb01.Controls.Add(this.lblUsername);
            this.gb01.Controls.Add(this.txtPort);
            this.gb01.Controls.Add(this.lblPort);
            this.gb01.Controls.Add(this.txtHost);
            this.gb01.Controls.Add(this.lblHostName);
            this.gb01.Location = new System.Drawing.Point(12, 12);
            this.gb01.Name = "gb01";
            this.gb01.Size = new System.Drawing.Size(533, 209);
            this.gb01.TabIndex = 12;
            this.gb01.TabStop = false;
            this.gb01.Text = "SMTP Parameters";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(331, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(269, 53);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(70, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(193, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(331, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(47, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "25";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(269, 27);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(106, 19);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(157, 20);
            this.txtHost.TabIndex = 0;
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(6, 27);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(94, 13);
            this.lblHostName.TabIndex = 0;
            this.lblHostName.Text = "&Host (Name or IP):";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(470, 227);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 13;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(68, 79);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(193, 20);
            this.txtFrom.TabIndex = 7;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(4, 86);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(331, 79);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(193, 20);
            this.txtTo.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(267, 86);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "To:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 111);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(518, 85);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status...";
            // 
            // chkBokSSL
            // 
            this.chkBokSSL.AutoSize = true;
            this.chkBokSSL.Location = new System.Drawing.Point(384, 19);
            this.chkBokSSL.Name = "chkBokSSL";
            this.chkBokSSL.Size = new System.Drawing.Size(71, 17);
            this.chkBokSSL.TabIndex = 16;
            this.chkBokSSL.Text = "SSL/TLS";
            this.chkBokSSL.UseVisualStyleBackColor = true;
            this.chkBokSSL.CheckedChanged += new System.EventHandler(this.chkBokSSL_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 262);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.gb01);
            this.Name = "frmMain";
            this.Text = "SMTP Mail Server Tester";
            this.gb01.ResumeLayout(false);
            this.gb01.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb01;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.CheckBox chkBokSSL;
    }
}

