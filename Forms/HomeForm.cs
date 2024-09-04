﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSystem.Classes;
using Bunifu.Framework.UI;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace AdminSystem.Forms
{
    public partial class HomeForm : Form
    {
        private List<Image> image = new List<Image>();
        private List<PackageManager> pm;
        private List<MonthOffer> mo;
        private List<RoleCls> roles;
        private EmployeeBase empbase;
        private List<Trainer> trainers;
        private bool getData = false;
        private Home home;

        public class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel() { DoubleBuffered = true; }
        }

        public HomeForm()
        {
            InitializeComponent();
            schedulePanel.Visible = false;
            bgWorkerSchedule.RunWorkerAsync();
            bgWorkerPackage.RunWorkerAsync();
            bgWorkerMonths.RunWorkerAsync();
            bgWorkerCls.RunWorkerAsync();
            bgWorkerTrainer.RunWorkerAsync();

            string basePath = Path.Combine(Environment.CurrentDirectory, @"..\..\assets");

            image.Add(Image.FromFile(Path.Combine(basePath, "bg1.png")));
            image.Add(Image.FromFile(Path.Combine(basePath, "bg2.png")));
            image.Add(Image.FromFile(Path.Combine(basePath, "bg3.png")));
            image.Add(Image.FromFile(Path.Combine(basePath, "bg4.png")));
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
            
            try
            {
                MessageBox.Show($"Current Directory: {Environment.CurrentDirectory}");
                //current working dir

                string basePath = Path.Combine(Environment.CurrentDirectory, @"..\..\assets");

                image.Add(Image.FromFile(Path.Combine(basePath, "bg1.png")));
                image.Add(Image.FromFile(Path.Combine(basePath, "bg2.png")));
                image.Add(Image.FromFile(Path.Combine(basePath, "bg3.png")));
                image.Add(Image.FromFile(Path.Combine(basePath, "bg4.png")));

                /* image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg1.png"));
                   image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg2.png"));
                   image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg3.png"));
                   image.Add(Image.FromFile(@"D:\versity space\NewTask\AdminSystem\assets\bg4.png"));  */

                image[0].Tag = Path.Combine(basePath, "bg1.png");
                image[1].Tag = Path.Combine(basePath, "bg2.png");
                image[2].Tag = Path.Combine(basePath, "bg3.png");
                image[3].Tag = Path.Combine(basePath, "bg4.png");

            }catch(FileNotFoundException ex)
            {
                MessageBox.Show($"File not found: {ex.FileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void RemovePanelControls(Panel p)
        {
            foreach(Control control in p.Controls)
            {
                control.Dispose();
            }p.Controls.Clear();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
        public void Loads()
        {

        }

        private void faddingtimer1_Tick(object sender, EventArgs e)
        {
            if(home.Opacity > 0.86) { home.Opacity -= 0.01; }
            else { faddingtimer1.Stop(); }
        }

        private void faddingtimer2_Tick(object sender, EventArgs e)
        {
            if (home.Opacity < 1) { home.Opacity += 0.01; }
            else { faddingtimer2.Stop(); }
        }

        private void schedulePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomPackage(int x,int y, PackageManager pm, Image img)
        {
            DoubleBufferedPanel panel = new DoubleBufferedPanel();
            Label Lname = new Label();
            Label Lm = new Label();
            Label Ld = new Label();
            Label Ln = new Label();
            Label Discount = new Label();

            SuspendLayout();

            BunifuElipse be = new BunifuElipse();
            be.TargetControl = panel;
            be.ElipseRadius = 50;

            panel.Controls.Add(Lname);
            panel.Controls.Add(Lm);
            panel.Controls.Add(Ld);
            panel.Controls.Add(Ln);
            panel.Controls.Add(Discount);

            panel.ForeColor = Color.White;
            panel.BackColor = Color.Transparent;
            panel.BackgroundImage = img;
            panel.BackgroundImage.Tag = img.Tag;
            panel.BackgroundImageLayout = ImageLayout.Stretch;

            Font labelFontNP = new Font(new FontFamily("Gilroy-SemiBold"), 34, FontStyle.Bold, GraphicsUnit.Pixel);
            Font labelFont = new Font(new FontFamily("Gilroy-SemiBold"), 12, FontStyle.Bold, GraphicsUnit.Point);
            panel.Size = new System.Drawing.Size(390, 230);
            panel.Location = new System.Drawing.Point(x, y);
            panel.Tag = pm;
            panel.Cursor = Cursors.Hand;
            Lname.Font = labelFontNP;
            Lname.Text = pm.Name;
            Lname.Location = new System.Drawing.Point(2, 53);
            Lname.Size = new Size(293, 49);
            Lname.Tag = pm;

            Lm.Font = labelFont;
            Lm.Text = pm.MonthOffer.NumOfMonths + " Month + " + pm.MonthOffer.MaxNum + " Freeze day";
            Lm.Location = new System.Drawing.Point(8, 102);
            Lm.Size = new Size(280, 29);
            Lm.Tag = pm;

            Ld.Font = labelFont;
            Ld.Text = pm.NumOfCls + " Class";
            Ld.Location = new System.Drawing.Point(8, 131);
            Ld.Size = new Size(280, 29);
            Ld.Tag = pm;

            Ln.Font = labelFont;
            Ln.Text = pm.InvitationNum + " Invitation";
            Ln.Location = new System.Drawing.Point(8, 160);
            Ln.Size = new Size(280, 29);
            Ln.Tag = pm;

            Discount.Font = labelFont;
            Discount.Text = pm.Discount + "% Discount";
            Discount.Location = new System.Drawing.Point(8, 191);
            Discount.Size = new Size(280, 29);
            Discount.Tag = pm;

            ResumeLayout();

            panelPackage.Controls.Add(panel);
            panel.Click += new System.EventHandler(panalPackge_Click);
            Ln.Click += new System.EventHandler(panalPackge_Click);
            Lname.Click += new System.EventHandler(panalPackge_Click);
            Lm.Click += new System.EventHandler(panalPackge_Click);
            Ld.Click += new System.EventHandler(panalPackge_Click);
            Discount.Click += new System.EventHandler(panalPackge_Click);
        }

    }
}
