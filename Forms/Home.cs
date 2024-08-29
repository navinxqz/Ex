using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using AdminSystem.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace AdminSystem.Forms
{
    public partial class Home : Form
    {
        private KryptonCheckButton cb = new KryptonCheckButton();
        private List<Form> forms = new List<Form>();
        private HomeForm home = new HomeForm();
        private Employee emp = new Employee();
        private EmployeeBase employee = new EmployeeBase();
        
        public Home()
        {
            InitializeComponent();
            this.Show();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cb = btnHome;
            cb.Checked = true;

            if(employee != null) { 
                if(employee.Pic != null) {
                    cuiButton3.Image = employee.Pic;
                }
            }
        }

        public void LoadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            if(Form is Form f) {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                f.Visible = true;
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadForm(home);
            this.Opacity = 0;
            faddingTimer.Start();
        }

        private void faddingTimer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                faddingTimer.Stop();
            }
        }

        private void sliderHideTimer_Tick(object sender, EventArgs e)
        {
            if(slidePanel.Size.Width > 102)
            {
                int x = slidePanel.Size.Width - 21;
                int y = slidePanel.Size.Height;
                slidePanel.Size = new Size(x, y);

                int z = mainpanel.Size.Width + 21, w = mainpanel.Size.Height;
                mainpanel.Size = new Size(z, w);
                int ly = mainpanel.Location.Y, lx = mainpanel.Location.X - 21;
                mainpanel.Location = new Point(lx, ly);
            }
            else
            {
                sliderHideTimer.Stop();
            }
        }

        private void sliderShowTimer_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Size.Width < 333)
            {
                int x = slidePanel.Size.Width + 21;
                int y = slidePanel.Size.Height;
                slidePanel.Size = new Size(x, y);

                int z = mainpanel.Size.Width - 21, w = mainpanel.Size.Height;
                mainpanel.Size = new Size(z, w);
                int ly = mainpanel.Location.Y, lx = mainpanel.Location.X + 21;
                mainpanel.Location = new Point(lx, ly);
            }
            else
            {
                sliderShowTimer.Stop();
            }
        }
        private void ButtonSetting(KryptonCheckButton button)
        {
            cb.Checked = false;
            cb = button;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(!btnHome.Checked)
            {
                btnHome.Checked = true;
                return;
            }
            LoadForm(home);
            ButtonSetting(btnHome);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if(!logoutBtn.Checked)
            {
                logoutBtn.Checked = true;
                return;
            }
            Login l = new Login();
            l.Visible = true;
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if(!btnEmployees.Checked)
            {
                btnEmployees.Checked = true;
                return;
            }
            LoadForm(emp);
            ButtonSetting(btnEmployees);
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            if(sliderShowTimer.Enabled && !sliderHideTimer.Enabled)
            {
                if(slidePanel.Size.Width == 333)
                {
                    sliderHideTimer.Start();
                }else if(slidePanel.Size.Width == 102)
                {
                    sliderShowTimer.Start();
                }
            }
        }
    }
}
