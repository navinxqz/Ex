﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminSystem.Classes;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AdminSystem.Forms
{
    public partial class AddPeople : Form
    {
        private Image img = null;
        private string imgbase = null;
        private bool MemberAdd = false, EmpAdd = false, TrainerAdd = false;
        bool Role, pass = false, Status;
        public string Gender;
        private EmployeeBase empbase1;
        private EmployeeBase empbase2;
        private Trainer trainer;
        //for member will be added...

        public AddPeople()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        public AddPeople(EmployeeBase eb = null,bool MemberAdd = false, bool EmpAdd =false, bool TrainerAdd = false) {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            btnAdd.Enabled = false;

            if (MemberAdd)
            {
                this.MemberAdd = true;
                //for member...
                labelName.Text = "Add Member";
            }else if (EmpAdd)
            {
                this. EmpAdd = true;
                empbase1 = new EmployeeBase();
                unametxt.Visible = true;
                passtxt.Visible = true;
                passconfirmtxt.Visible = true;
                checkpanel.Visible = true;
                unametxt.Text = "Username";
                labelName.Text = "Add Employee";
            }else if(TrainerAdd)
            {
                this.TrainerAdd = true;
                trainer = new Trainer();
                LessonCostTxt.Visible = true;
                unametxt.Text = "Specialized";
                labelName.Text = "Add Trainer";
            }empbase2 = eb;
        }

        private void GetGender()
        {
            if (MaleRB.Checked) { Gender = "Male"; }
            else if(FemaleRB.Checked) { Gender = "Female"; }
        }

        //private void 

        private void GetRole()
        {
            if(AdminRB.Checked) { Role = true; }
            else if(UserRB.Checked) { Role = false; }
        }

        private bool EmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void fnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnametxt_Enter(object sender, EventArgs e)
        {
            if(fnametxt.Text == "First Name")
            {
                fnametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                fnametxt.Text = String.Empty;
            }
        }

        private void fnametxt_Leave(object sender, EventArgs e)
        {
            if (fnametxt.Text == "")
            {
                fnametxt.Text = "First Name";
                fnametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
            }
        }

        private void passconfirmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateSelect_ValueChanged(object sender, EventArgs e)
        {
            dobtxt.ForeColor = Color.FromArgb(70, 71, 78);
            dobtxt.Text = DateSelect.Value.ToString("dd-MM-yyyy");
        }

        private void show_pass_btn_Click(object sender, EventArgs e)
        {

        }

        private void bgWorkerAdd_DoWork(object sender, DoWorkEventArgs e)
        {
            if (E)
            {
                if(unametxt.Text == "USERNAME")
                {
                    unametxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                    unametxt.Text = string.Empty;
                }
            }else if (T)
            {
                if(unametxt.Text == "")
                {

                }
            }
        }
    }
}
