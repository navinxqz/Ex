using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AdminSystem.Classes;
using ComponentFactory.Krypton.Toolkit;
using Humanizer;
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

        private void Subscription1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            faddingTime1.Start();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            faddingTimer2.Start();
        }

        private void bgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*if (searchtxt.Text != "Search")
            {
                if (int.TryParse(searchtxt.Text, out int id))
                {
                    memberModels = Global.memberService.Search(searchtxt.Text, true, byId: true);
                    if (memberModels != null)
                    {
                        if (pac)
                        {
                            can_sub = Global.PackgeSupscribtionService.CheckMemberInPackageSubscription(memberModels[0].Id);
                            classes = Global.classService.GetUnsubscribedClasses(memberModels[0].Id, true, true);

                        }
                        else if (mon)
                        {
                            can_sub = Global.monthSubscriptionService.CheckMemberInMonthSubscription(memberModels[0].Id);
                        }
                        else if (cla)
                        {
                            can_sub = Global.classSubscriptionService.CheckMemberInClassSubscription(memberModels[0].Id, classModel.Id);
                        }
                        else if (pri)
                        {
                            can_sub = Global.PrivateSubscriptionService.CheckMemberPrivateSubscription(memberModels[0].Id);
                        }
                    }
                }
                else
                {
                    lab_search_err.Text = "Please enter id as a number";
                }
            }*/
        }

        private void bgWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void searchtxt_Enter(object sender, EventArgs e)
        {
            //if(e.KeyChar == (char)Keys.Return) { searchBtn_Click(sender, e); }
        }

        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Searchtxt_Leave(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

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
            pricelbl.Text = disc + "BDT";
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
            pricelbl.Text = price + "BDT";
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
            pricelbl.Text = price + "BDT";
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
            pricelbl.Text = price + "BDT";
            Subscribebtn.Enabled = false;
            panelPrivSup.Visible = true;
            lessonCost = price;
            LessonNumTxt.KeyPress += LessonNumTxt_KeyPress;
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            if(sender is CheckBox cb) {
                if(cb.Checked)
                {
                    if(cb.Tag is RoleCls r)
                    {
                        clsList.Add(r);
                        price += r.Pricing;
                        disc = price - (price * ((packageManager.Discount) / 100));
                        pricelbl.Text = disc + "BDT";
                        checkers++;
                    }
                    if (checkers == packageManager.NumOfCls)
                    {
                        if (!sub) { Subscribebtn.Enabled = true; }

                        foreach (CheckBox c in panelclassesDataP.Controls.OfType<CheckBox>())
                        {
                            if (!c.Checked) { c.Enabled = false; }
                        }
                    }
                }
                else
                {
                    if(cb.Tag is RoleCls role)
                    {
                        clsList.Remove(role);
                        price -= role.Pricing;
                        disc = price - (price * ((packageManager.Discount) / 100));
                        pricelbl.Text = disc + "BDT";
                        checkers--;
                    }
                    if(checkers == packageManager.NumOfCls - 1)
                    {
                        if (!sub) { Subscribebtn.Enabled = false; }
                        foreach (CheckBox c in panelclassesDataP.Controls.OfType<CheckBox>())
                        {
                            if(!c.Checked) { c.Enabled = true;}
                        }
                    }
                }
            }
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
            checkBox.CheckedChanged += new EventHandler(CheckBox_Checked);
        }

        //private void 

    }
}
