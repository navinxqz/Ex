﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using AdminSystem.Classes;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ComponentFactory.Krypton.Toolkit;
using AdminSystem.DataAccess;

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
                checkpanel.Visible = true;
                unametxt.Text = "Username";
                labelName.Text = "Add Employee";
            }
            else if(TrainerAdd)
            {
                this.TrainerAdd = true;
                trainer = new Trainer();
                LessonCostTxt.Visible = true;
                unametxt.Text = "Specialized";
                labelName.Text = "Add Trainer";
            }
            empbase2 = eb; //EmployeeBase assign after checks
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
            try
            {
                if (EmpAdd)
                {
                    empbase1.FirstName = fnametxt.Text;
                    empbase1.LastName = lnametxt.Text;
                    empbase1.Birthday = DateSelect.Value;
                    empbase1.Gender = Gender;
                    empbase1.Email = mailtxt.Text;
                    empbase1.Phone = phntxt.Text == "Phone" ? null : phntxt.Text;
                    empbase1.Username = unametxt.Text;
                    empbase1.Admin = Role;
                    empbase1.Status = true;
                    empbase1.Password = passtxt.Text;
                    empbase1.Pic = img;
                    empbase1.ImgBase = imgbase;
                }
                else if (MemberAdd) { }

                else if (TrainerAdd)
                {
                    trainer.FirstName = fnametxt.Text;
                    trainer.LastName = lnametxt.Text;
                    trainer.Birthday = DateSelect.Value;
                    trainer.Gender = Gender;
                    trainer.Email = mailtxt.Text;
                    trainer.Phone = phntxt.Text == "Phone" ? null : phntxt.Text;
                    trainer.Specialized = unametxt.Text;
                    trainer.Status = true;
                    trainer.Pic = img;
                    trainer.ImgBase = imgbase;
                    trainer.LessonPrice = Convert.ToInt32(LessonCostTxt.Text);
                }
                bgWorkerAdd.RunWorkerAsync();
            }
            catch (Exception ex) { Console.WriteLine($"Error! {ex.Message}"); }
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

        private void lnametxt_Enter(object sender, EventArgs e)
        {
            if (lnametxt.Text == "Last Name")
            {
                lnametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                lnametxt.Text = String.Empty;
            }
        }

        private void lnametxt_Leave(object sender, EventArgs e)
        {
            if (lnametxt.Text == "")
            {
                lnametxt.Text = "Last Name";
                lnametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
            }
        }

        private void mailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailtxt_Enter(object sender, EventArgs e)
        {
            if (mailtxt.Text == "Email")
            {
                mailtxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                mailtxt.Text = String.Empty;
            }
        }

        private void mailtxt_Leave(object sender, EventArgs e)
        {
            if (mailtxt.Text == "")
            {
                mailtxt.Text = "Email";
                mailtxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
            }
        }

        private void phntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phntxt_Enter(object sender, EventArgs e)
        {
            if (phntxt.Text == "Phone")
            {
                phntxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                phntxt.Text = String.Empty;
            }
        }

        private void phntxt_Leave(object sender, EventArgs e)
        {
            if (phntxt.Text == "")
            {
                phntxt.Text = "Phone";
                phntxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
            }
        }

        private void unametxt_Enter(object sender, EventArgs e)
        {
            if (EmpAdd && unametxt.Text == "Username")
            {
                unametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                unametxt.Text = String.Empty;
            }
            else if (TrainerAdd && unametxt.Text == "Specialized")
            {
                 unametxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                 unametxt.Text = string.Empty;
            }
        }

        private void unametxt_Leave(object sender, EventArgs e)
        {
            if (EmpAdd && string.IsNullOrEmpty(unametxt.Text))
            {
                 unametxt.Text = "Username";
                 unametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
            }
            else if (TrainerAdd && string.IsNullOrEmpty(unametxt.Text))
            {
                 unametxt.Text = "Specialized";
                 unametxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
            }
        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            if (passtxt.Text == "Password")
            {
                passtxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                passtxt.Text = String.Empty;
                passtxt.PasswordChar = '*';
            }
            hide_pass_btn.Visible = true;
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.PasswordChar = '\0';
                passtxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                passtxt.Text = "Password";
            }
            else if(passtxt.Text != "Password")
            {
                passtxt.PasswordChar = '*';
                if(confirmpstxt.Text != passtxt.Text && confirmpstxt.Text != "Confirm Password")
                {
                    confirmpstxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    pass = false;
                }
                else
                {
                    confirmpstxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                    pass = true;
                }
            }
            show_pass_btn.Visible = false;
            hide_pass_btn.Visible= false;
        }

        private void LessonCostTxt_Enter(object sender, EventArgs e)
        {
            if (LessonCostTxt.Text == "Lesson Cost")
            {
                LessonCostTxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                LessonCostTxt.Text = String.Empty;
            }
        }

        private void ProfilePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Choose an image";
            of.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (of.ShowDialog() == DialogResult.OK)
            {
                if (StaticClass.imgManager.GetFileSize(of.FileName) > 1000)
                {
                    //labelimageError.Text = "This image is Big in Size";
                    return;
                }
                img = StaticClass.imgManager.ImgSizeCompresser(Image.FromFile(of.FileName));
                if (img == null)
                {
                    //labelimageError.Text = "This image is Big in Size";
                    return;
                }
                ProfilePic.Content = img;
                imgbase = StaticClass.imgManager.ConvertImgToimgbase(Image.FromFile(of.FileName));  
            }
            /*using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Title = "Choose an image";
                of.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";

                if (of.ShowDialog() == DialogResult.OK)
                {
                    img = new Bitmap(of.FileName);
                    imgbase = ImgManager.ConvertToBase64(img);
                    ProfilePic.Content = img;
                    btnAdd.Enabled = true;
                }
            }   */
        }

        private void LessonCostTxt_Leave(object sender, EventArgs e)
        {
            if (LessonCostTxt.Text == "")
            {
                LessonCostTxt.Text = "Lesson Cost";
                LessonCostTxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            hidebtn2.Visible = true;
            showbtn.Visible = false;
            confirmpstxt.PasswordChar = '*';
        }

        private void hidebtn2_Click(object sender, EventArgs e)
        {
            hidebtn2.Visible = false;
            showbtn.Visible = true;
            passtxt.PasswordChar = '\0';
        }

        private void confirmpstxt_Enter(object sender, EventArgs e)
        {
            if(confirmpstxt.Text == "Confirm Password")
            {
                if(confirmpstxt.Text == "Confirm Password")
                {
                    confirmpstxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                    confirmpstxt.Text = string.Empty;
                }
                confirmpstxt.PasswordChar = '*';
            }hidebtn2.Visible = true;
        }

        private void confirmpstxt_Leave(object sender, EventArgs e)
        {
            if (confirmpstxt.Text == "")
            {
                confirmpstxt.PasswordChar = '\0';
                confirmpstxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                confirmpstxt.Text = "Confirm Password";
            }
            if (confirmpstxt.Text != "Confirm Password")
            {
                confirmpstxt.PasswordChar = '*';
                if (confirmpstxt.Text != passtxt.Text && passtxt.Text != "Password")
                {
                    confirmpstxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    pass = false;
                }
                else
                {
                    confirmpstxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                    pass = true;
                }
            }
            showbtn.Visible = false;
            hidebtn2.Visible = false;
        }

        private void AdminRB_CheckedChanged(object sender, EventArgs e)
        {
            AdminRB.ForeColor = Color.FromArgb(70, 71, 78);
            UserRB.ForeColor = Color.FromArgb(70, 71, 78);
            GetRole();
        }

        private void UserRB_CheckedChanged(object sender, EventArgs e)
        {
            AdminRB.ForeColor = Color.FromArgb(70, 71, 78);
            UserRB.ForeColor = Color.FromArgb(70, 71, 78);
            GetRole();
        }

        private void MaleRB_CheckedChanged(object sender, EventArgs e)
        {
            MaleRB.ForeColor = Color.FromArgb(70, 71, 78);
            FemaleRB.ForeColor = Color.FromArgb(70, 71, 78);
            GetGender();
        }

        private void FemaleRB_CheckedChanged(object sender, EventArgs e)
        {
            MaleRB.ForeColor = Color.FromArgb(70, 71, 78);
            FemaleRB.ForeColor = Color.FromArgb(70, 71, 78);
            GetGender();
        }

        private void bgWorkerAdd_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Status)
            {
                this.Close();
            }
        }

        private void AddPeople_Load(object sender, EventArgs e)
        {
            //this.Opacity = 0;
            faddingTimer.Start();
        }

        private void faddingTimer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                faddingTimer2.Stop();
                this.Close();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            faddingTimer2.Start();
        }

        private void LessonCostTxt_TextChanged(object sender, EventArgs e)
        {
            if (fnametxt.Text != "First Name" && lnametxt.Text != "Second Name" && mailtxt.Text != "Email" && dobtxt.Text != "Date of Birth" && (MaleRB.Checked || FemaleRB.Checked))
            {
                if (EmpAdd)
                {
                    if (unametxt.Text != "Username" && passtxt.Text != "Password" && confirmpstxt.Text != "Confirm Password" && (AdminRB.Checked || UserRB.Checked) && pass)
                    {
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                    }
                }
                else if (MemberAdd)
                {
                    btnAdd.Enabled = true;
                }
                else if (TrainerAdd)
                {
                    if (unametxt.Text != "Specialization" && LessonCostTxt.Text != "Private Price")
                    { 
                        btnAdd.Enabled = true; 
                    }
                    else { btnAdd.Enabled = false; }
                }
            }
        }

        private void hide_pass_btn_Click(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = false;
            show_pass_btn.Visible = true;
            passtxt.PasswordChar = '\0';
        }

        private void DateSelect_ValueChanged(object sender, EventArgs e)
        {
            dobtxt.ForeColor = Color.FromArgb(70, 71, 78);
            dobtxt.Text = DateSelect.Value.ToString("dd-MM-yyyy");
        }

        private void show_pass_btn_Click(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = true;
            show_pass_btn.Visible = false;
            passtxt.PasswordChar = '*';
        }


        private void bgWorkerAdd_DoWork(object sender, DoWorkEventArgs e)
        { try {
            if (EmpAdd)
            {
                //EmployeeEmailModel emailModel = new EmployeeEmailModel();
                empbase1 = StaticClass.empQuery.AddEmp(empbase1);
                //emailModel.EmployeeModel1 = employee;
                //mailModel.EmployeeModel = employeemodel;
                //emailModel.Subject = "Welcome " + employee.Name;
                //emailModel.Body = emailModel.createEmployeeEmail();
                //StaticClass.emailService.AddEmployeeEmail(emailModel);

                if (empbase1 != null) { Status = true; }
                else { Status = false; }
            }
            else if (TrainerAdd)
            {
                //TrainerEmailModel trainerEmailModel = new TrainerEmailModel();
                trainer = StaticClass.tQuery.AddTrainer(trainer);
                //trainerEmailModel.EmployeeModel = employeemodel;
                //trainerEmailModel.TrainerModel = trainer;
                //trainerEmailModel.Subject = "Welcome " + trainer.Name;
                //trainerEmailModel.Body = trainerEmailModel.createTrainerEmail();
                //Global.emailService.AddTrainerEmail(trainerEmailModel);
                if (trainer != null)
                {
                    Status = true;
                }
                else
                {
                    Status = false;
                }
            }
        }catch (Exception ex) {
                MessageBox.Show($"Error occurred while adding data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
