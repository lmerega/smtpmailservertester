using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace SMTP_Mail_Server_Tester
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Exception ex;

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            if (txtHost.Text.Length < 5)
            {
                MessageBox.Show("Host not specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ex = new Exception();
            try
            {
                SmtpClient client = new SmtpClient();

                if (txtHost.Text != "")
                    client.Host = txtHost.Text;

                if (txtPort.Text != "")
                    client.Port = Convert.ToInt32(txtPort.Text);

                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    client.UseDefaultCredentials = false;
                    System.Net.NetworkCredential credencials =
                        new System.Net.NetworkCredential(txtUsername.Text, txtPassword.Text);
                    client.Credentials = credencials;
                }
                else
                    client.UseDefaultCredentials = true;
                    client.EnableSsl = chkBokSSL.Checked;
                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new MailAddress(txtFrom.Text);
                mailMessage.To.Add(txtTo.Text);
                mailMessage.Subject = "This is a test";
                mailMessage.Body = "This is the bofy. Just a test";
                client.Send(mailMessage);

                lblStatus.Text = "Email successfully sent";
            }
            catch (Exception ex2)
            {
                ex = ex2;
                lblStatus.Text = "Error Message: " + ex.Message  ;
            }

        }

        private void chkBokSSL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBokSSL.Checked == true)
            {
                txtPort.Text = "587";
                } else {
                txtPort.Text = "25";
            }
        }
    }
}
