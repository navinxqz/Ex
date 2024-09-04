using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSystem.Classes;

namespace AdminSystem.Forms
{
    public partial class HomeForm : Form
    {
        private List<Image> image = new List<Image>();
        private List<RoleCls> roles;
        private EmployeeBase empbase;
        private bool getData = false;
        private Home home;
        // future implement...

        public HomeForm()
        {
            InitializeComponent();
            schedulePanel.Visible = false;
            bgWorkerSchedule.RunWorkerAsync();
            bgWorkerPackage.RunWorkerAsync();
            bgWorkerMonths.RunWorkerAsync();
            bgWorkerCls.RunWorkerAsync();
            bgWorkerTrainer.RunWorkerAsync();

            image.Add(Image.FromFile("assets/bg1.png"));
            image.Add(Image.FromFile("assets/bg2.png"));
            image.Add(Image.FromFile("assets/bg3.png"));
            image.Add(Image.FromFile("assets/bg4.png"));
        }

        public HomeForm(EmployeeBase empbase, Home h)
        {
            InitializeComponent();
            schedulePanel.Visible = false;
            bgWorkerSchedule.RunWorkerAsync();
            bgWorkerPackage.RunWorkerAsync();
            bgWorkerMonths.RunWorkerAsync();
            bgWorkerCls.RunWorkerAsync();
            bgWorkerTrainer.RunWorkerAsync();
            
            try
            {
                MessageBox.Show($"Current Directory: {Environment.CurrentDirectory}");
                //current working dir

                string basePath = Path.Combine(Environment.CurrentDirectory, @"..\..\assets");

                image.Add(Image.FromFile(Path.Combine(basePath, "bg1.png")));
                image.Add(Image.FromFile(Path.Combine(basePath, "bg2.png")));
                image.Add(Image.FromFile(Path.Combine(basePath, "bg3.png")));
                image.Add(Image.FromFile(Path.Combine(basePath, "bg4.png")));

                /*   image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg1.png"));
                   image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg2.png"));
                   image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg3.png"));
                   image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg4.png"));  */

                image[0].Tag = Path.Combine(basePath, "bg1.png");
                image[1].Tag = Path.Combine(basePath, "bg2.png");
                image[2].Tag = Path.Combine(basePath, "bg3.png");
                image[3].Tag = Path.Combine(basePath, "bg4.png");

            }catch(FileNotFoundException ex)
            {
                MessageBox.Show($"File not found: {ex.FileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.empbase = empbase;
            home = h;
        }

        public void MaxScheduleResize()
        {
            int x = panel4.Location.X + 21;
            int y = panel4.Location.Y;
            DoubleBuffered = true;

            panel4.Location = new Point(x, y);
            DoubleBuffered = true;
        }
        public void MinScheduleResize()
        {
            int x = panel4.Location.X - 21;
            int y = panel4.Location.Y;
            DoubleBuffered = true;

            panel4.Location = new Point(x, y);
            DoubleBuffered = true;
        }

        private void RemovePanelControls(Panel p)
        {
            foreach(Control control in p.Controls)
            {
                control.Dispose();
            }p.Controls.Clear();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
        public void Loads()
        {

        }

        private void faddingtimer1_Tick(object sender, EventArgs e)
        {
            if(home.Opacity > 0.86) { home.Opacity -= 0.01; }
            else { faddingtimer1.Stop(); }
        }
        private void faddingtimer2_Tick(object sender, EventArgs e)
        {
            if (home.Opacity < 1) { home.Opacity += 0.01; }
            else { faddingtimer2.Stop(); }
        }

        private void schedulePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void CustomPanel(int x,int y,)

    }
}
