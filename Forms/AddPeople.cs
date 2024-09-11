using System;
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
using ComponentFactory.Krypton.Toolkit;

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
            if (EmpAdd)
            {
                if (unametxt.Text == "Username")
                {
                    unametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    unametxt.Text = String.Empty;
                }
            }
            else if (TrainerAdd)
            {
                if (unametxt.Text == "Specialized")
                {
                    unametxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                    unametxt.Text = string.Empty;
                }
            }
        }

        private void unametxt_Leave(object sender, EventArgs e)
        {
            if (EmpAdd)
            {
                if (unametxt.Text == "")
                {
                    unametxt.Text = "Username";
                    unametxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                }
            }else if (TrainerAdd)
            {
                if(unametxt.Text == "")
                {
                    unametxt.Text = "Specialized";
                    unametxt.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                }
            }
        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            if (passtxt.Text == "Password")
            {
                if(passtxt.Text == "Password")
                {
                    passtxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                    passtxt.Text = String.Empty;
                }
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
            if(passtxt.Text != "Password")
            {
                passtxt.PasswordChar = '*';
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
            of.Filter = "Images|*.jpg;*.png;*.bmp";
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
        }

        private void LessonCostTxt_Leave(object sender, EventArgs e)
        {
            if (LessonCostTxt.Text == "")
            {
                LessonCostTxt.Text = "Lesson Cost";
                LessonCostTxt.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
            }
        }

        private void ProfilePic_Load(object sender, EventArgs e)
        {

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

        }


        private void bgWorkerAdd_DoWork(object sender, DoWorkEventArgs e)
        {
            /*if (E)
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
            }*/
        }
    }
}
