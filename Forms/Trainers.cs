using AdminSystem.Classes;
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
    public partial class Trainers : Form
    {
        private List<Trainer> trainer;
        private List<Trainer> tList;
        private EmployeeBase employee;
        private HomeForm homeForm;
        private Home home;

        public Trainers()
        {
            InitializeComponent();
            DataView.AutoGenerateColumns = false;
            bgWorkerGetTrainer.RunWorkerAsync();
        }
        public Trainers(EmployeeBase e, HomeForm hf, Home h)
        {
            InitializeComponent();
            DataView.AutoGenerateColumns = false;
            bgWorkerGetTrainer.RunWorkerAsync();
            home = h; homeForm = hf; employee = e;
        }
        public Trainers(EmployeeBase e)
        {
            InitializeComponent();
            DataView.AutoGenerateColumns = false;
            bgWorkerGetTrainer.RunWorkerAsync();
            employee = e;
        }

        private void Trainers_Load(object sender, EventArgs e)
        {

        }

        private void faddingtimer1_Tick(object sender, EventArgs e)
        {
            if(home.Opacity > 0.86) { home.Opacity -= 0.01; }
            else { faddingtimer1.Stop(); }
        }

        private void faddingtimer2_Tick(object sender, EventArgs e)
        {
            if(home.Opacity < 1) { home.Opacity += 0.01; }
            else { faddingtimer2.Stop(); }
        }

        private void bgWorkerGetTrainer_DoWork(object sender, DoWorkEventArgs e)
        {
            trainer = StaticClass.tQuery.AllTrainers(false, false);
        }

        private void bgWorkerGetTrainer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(trainer != null)
            {
                panelView.Visible = true;
                DataView = StaticClass.data.Grid(DataView, trainer);
            }
            else
            {
                panelView.Visible = false;
            }
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            if(searchtxtbox.Text != "Search")
            {
                try
                {
                    bgWorkerList.RunWorkerAsync();
                }catch (Exception ex)
                {
                    Console.WriteLine($"Error! {ex.Message}");
                }
            }
        }

        private void bgWorkerList_DoWork(object sender, DoWorkEventArgs e)
        {
            tList = trainer.Where(trainer => trainer.Name.ToLower().Contains(searchtxtbox.Text) || 
            trainer.Id.ToString().Contains(searchtxtbox.Text) || 
            trainer.Name.Contains(searchtxtbox.Text) || 
            trainer.Name.ToUpper().Contains(searchtxtbox.Text)).ToList();
        }

        private void bgWorkerList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(tList != null)
            {
                DataView = StaticClass.data.Grid(DataView, tList);
            }
        }
    }
}
