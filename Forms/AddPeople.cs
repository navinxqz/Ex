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
        private bool E = false, T = false, M = false;
        public string Gender;
        private EmployeeBase empbase;
        private EmployeeBase ebase;
        public AddPeople()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        public AddPeople(EmployeeBase b = null,bool M = false, bool E =false, bool T = false) {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            btnAdd.Enabled = false;

            if (M)
            {
                this.M = true;

            }
        }

        private void passconfirmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_pass_btn_Click(object sender, EventArgs e)
        {

        }

        private void bgWorkerAdd_DoWork(object sender, DoWorkEventArgs e)
        {
            if (E)
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
            }
        }
    }
}
