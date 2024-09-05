using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AdminSystem.Classes;
using static AdminSystem.Forms.HomeForm;

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

        private void LessonNumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LessonNumTxt_Leave(object sender, EventArgs e)
        {

        }

        private void LessonNumTxt_Enter(object sender, EventArgs e)
        {

        }

        private void LessonNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }

            if(LessonNumTxt.Text.Length >= 1 && !char.IsControl(e.KeyChar)) { e.Handled=true; }
        }

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

        public Subscription1(MonthOffer mo, Image img, EmployeeBase employee)
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            m = true;
            emp = employee;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cancelbtn.Focus();

            subscriptionLbl.Text = "Month Subscribtion";
            panelData.Visible = false;
            subscriptionLbl.Focus();
            monthOffer = mo;
            price = monthOffer.Price;

            panelMonth.BackgroundImage = img;
            panelMonth.BackgroundImageLayout = ImageLayout.Stretch;
            labelnumMonth.Text = monthOffer.NumOfMonths + " Month";
            labelfrezeNum.Text = monthOffer.MaxNum + " Freze day";

            labelmonthprice.Text = price + "BDT";
            labelprice.Text = price + "BDT";
            Subscribebtn.Enabled = false;
            panelMonthSubscription.Visible = true;
        }

        public Subscription1(RoleCls r, Image img, EmployeeBase employee) 
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            cs = true;
            emp = employee;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cancelbtn.Focus();

            roleCls = r;
            price = roleCls.Pricing;
            panelClass.BackgroundImage = img;
            panelClass.BackgroundImageLayout = ImageLayout.Stretch;
            labelclassname.Text = roleCls.Name;
            labelclassDay1.Text = roleCls.SessionDay1;
            labelclassDay2.Text = roleCls.SessionDay2;
            labelclassTrainer.Text = roleCls.Trainer.Name;

            labelclassPrice.Text = roleCls.Pricing + "BDT";
            labelprice.Text = price + "BDT";
            Subscribebtn.Enabled = false;
            panelClassSup.Visible = true;
        }

        public Subscription1(Trainer t, Image img, EmployeeBase employee) 
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            p = true;
            emp = employee;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cancelbtn.Focus();

            subscriptionLbl.Text = "Private Subscribtion";
            panelData.Visible = false;
            subscriptionLbl.Focus();
            trainer = t;
            price = trainer.LessonPrice;

            panelPriv.BackgroundImage = img;
            panelPriv.BackgroundImageLayout = ImageLayout.Stretch;
            labelPrivateSpetialize.Text = trainer.Specialized;
            labelPrivatPrice.Text = trainer.LessonPrice + "BDT";
            labelprice.Text = price + "BDT";
            Subscribebtn.Enabled = false;
            panelPrivSup.Visible = true;
            lessonCost = price;
            LessonNumTxt.KeyPress += LessonNumTxt_KeyPress;
        }

        private void CustomCheckerBox(int x, int y, RoleCls r, Panel p)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.ForeColor = Color.FromArgb(70, 71, 78);
            Font checkFontNP = new Font(new FontFamily("Gilroy-SemiBold"), 28, FontStyle.Bold, GraphicsUnit.Pixel);
            checkBox.Font = checkFontNP;
            checkBox.Size = new Size(159, 48);
            checkBox.Location = new Point(x, y);
            checkBox.Text = r.Name;
            checkBox.Tag = r;
            p.Controls.Add(checkBox);
            //checkBox.CheckedChanged += new EventHandler(checkBox_Checked);
        }

        //private void 

    }
}
