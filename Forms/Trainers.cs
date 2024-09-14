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

        private void Trainers_Load(object sender, EventArgs e)
        {

        }
    }
}
