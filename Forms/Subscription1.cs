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
    public partial class Subscription1 : Form
    {
        private PackageManager packageManager;
        private MonthOffer monthOffer;
        private Trainer trainer;
        private RoleCls roleCls;
        private EmployeeBase emp;

        private List<RoleCls> cls;
        private List<RoleCls> clsList = new List<RoleCls> ();
        private List<CheckBox> checkercls;

        //private 

        private bool sub = false, subStatus;
        private int checkers = 0;
        private double price, disc, lessonCost;
        private bool package = false, m = false, cs = false, p = false;

        public Subscription1()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cancelbtn.Focus();
        }

        public void RemoveControls(Panel panel)
        {
            foreach(Control c in panel.Controls)
            {
                c.Dispose();
            }panel.Controls.Clear();
        }
        private void panelnoDataclasesP_Paint(object sender, PaintEventArgs e){}

        private void faddingTime1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else { faddingTime1.Stop(); }
        }

        private void faddingTimer2_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                faddingTimer2.Stop();
                this.Close();
            }
        }

        public Subscription1(PackageManager pm, Image img, EmployeeBase employee)
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            package = true;
            emp = employee;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cancelbtn.Focus();

            subscriptionLbl.Text = "Package Subscription";
            panelData.Visible = false;
            subscriptionLbl.Focus();
            packageManager = pm;

            price = packageManager.MonthOffer.Price;
            disc = price - (price * (packageManager.Discount) / 100);
            panelpackge.BackgroundImage = img;
            panelpackge.BackgroundImageLayout = ImageLayout.Stretch;
            labelpackgename.Text = packageManager.Name;
            labelmonthoffer.Text = packageManager.MonthOffer.NumOfMonths + " Month + " + packageManager.MonthOffer.MaxNum + " Freeze Day";
            labelnumclass.Text = packageManager.NumOfCls + " Class";
            labelnuminvaite.Text = packageManager.InvitationNum + " Invatiation";
            labelDiscount.Text = packageManager.Discount + "% Discount";

            Subscribebtn.Enabled = false;
            labelprice.Text = disc + "BDT";
            panelPackgeSub.Visible = true;
        }
    }
}
