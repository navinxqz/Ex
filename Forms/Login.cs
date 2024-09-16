using AdminSystem.Classes;
using AdminSystem.Forms;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSystem
{
    public partial class Login : Form
    {
        private EmployeeBase eb = StaticClass.employeeBase;
        bool s = false;
        public Login(bool key)
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.s = key;

            if(s) { LogPanel.Visible = true; }
            else {  LogPanel.Visible = false; }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBox_Enter(ref KryptonTextBox t)
        {
            t.Text = string.Empty;
            t.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
            if (txtUsername.TabStop == false || txtPassword.TabStop == false)
            {
                txtPassword.TabStop = true;
                txtUsername.TabStop = true;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                errorLabel.Text = "Username Required!";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            HidePassBtn.Visible = true;
            showPassBtn.Visible = false;
            txtPassword.PasswordChar = '\0';
        }

        private void HidePassBtn_Click(object sender, EventArgs e)
        {
            HidePassBtn.Visible = false;
            showPassBtn.Visible = true;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Username" && txtPassword.Text != "Password" && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                if (txtUsername.Text != "Username")
                {
                    txtUsername.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    errorLabel.Text = "Username Required!";
                }
                if (txtPassword.Text != "Password")
                {
                    txtPassword.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    errorLabel.Text = "Password Required!";
                }
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Text = "Username";
                    txtUsername.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    errorLabel.Text = "Username Required!";
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Text = "Password";
                    txtPassword.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    errorLabel.Text = "Password Required!";
                }
            }
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void backgroundWorkerLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
        }
        private void backgroundWorkerLogin_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;

            //if () { }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                /*txtUsername.Text = string.Empty;
                txtUsername.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                if (txtUsername.TabStop == false) { txtUsername.TabStop = true; }   */

                txtUsername.Text = string.Empty;
                txtBox_Enter(ref txtUsername);
            }
        }   //for txtPassword.text its better for now to dryrun. will implement in future...
    }
}
