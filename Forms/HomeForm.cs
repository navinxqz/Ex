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
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
        public void Load()
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

            }
        }
    }
}
