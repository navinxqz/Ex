using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            image.Add(Image.FromFile("assets/bg1.png"));
            image.Add(Image.FromFile("assets/bg2.png"));
            image.Add(Image.FromFile("assets/bg3.png"));
            image.Add(Image.FromFile("assets/bg4.png"));

            image[0].Tag = "assets/bg1.png";
            image[1].Tag = "assets/bg2.png";
            image[2].Tag = "assets/bg3.png";
            image[3].Tag = "assets/bg4.png";

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

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
        public void Loads()
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

            }catch (Exception ex) { }
        }
    }
}
