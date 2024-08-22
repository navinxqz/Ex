using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSystem
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        private void cuiPictureBox1_Load(object sender, EventArgs e)
        {

        }

        private void LoadPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadPanel.Width += 3;
            if(LoadPanel.Width >= 590){
                timer1.Stop();
                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }
    }
}
