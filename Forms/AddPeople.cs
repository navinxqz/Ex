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

namespace AdminSystem.Forms
{
    public partial class AddPeople : Form
    {
        private Image img = null;
        private string src = null;
        private bool e = false;
        public string Gender;
        private EmployeeBase empbase;
        private EmployeeBase ebase;
        public AddPeople()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
    }
}
