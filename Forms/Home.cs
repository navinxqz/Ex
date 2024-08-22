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

namespace AdminSystem.Forms
{
    public partial class Home : Form
    {
        private KryptonCheckButton cb = new KryptonCheckButton();
        private List<Form> forms = new List<Form>();
        private HomeForm home = new HomeForm();
        
        public Home()
        {
            InitializeComponent();
            this.Show();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cb = btnHome;
            cb.Checked = true;
        }

        public void LoadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Visible = true;
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
    }
}
