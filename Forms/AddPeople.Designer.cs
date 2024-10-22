﻿namespace AdminSystem.Forms
{
    partial class AddPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPeople));
            this.labelName = new System.Windows.Forms.Label();
            this.ProfilePic = new CuoreUI.Controls.cuiPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showbtn = new System.Windows.Forms.PictureBox();
            this.hidebtn2 = new System.Windows.Forms.PictureBox();
            this.confirmpstxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LessonCostTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DateSelect = new System.Windows.Forms.DateTimePicker();
            this.show_pass_btn = new System.Windows.Forms.PictureBox();
            this.hide_pass_btn = new System.Windows.Forms.PictureBox();
            this.checkpanel = new System.Windows.Forms.Panel();
            this.AdminRB = new System.Windows.Forms.RadioButton();
            this.UserRB = new System.Windows.Forms.RadioButton();
            this.phntxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.passtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fnametxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.unametxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lnametxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.mailtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dobtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.cancelbtn = new CuoreUI.Controls.cuiButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bgWorkerAdd = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse12 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.faddingTimer = new System.Windows.Forms.Timer(this.components);
            this.faddingTimer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_pass_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pass_btn)).BeginInit();
            this.checkpanel.SuspendLayout();
            this.genderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(41, 8);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(301, 61);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Add Person";
            // 
            // ProfilePic
            // 
            this.ProfilePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePic.Content = ((System.Drawing.Image)(resources.GetObject("ProfilePic.Content")));
            this.ProfilePic.CornerRadius = 100;
            this.ProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePic.ImageTint = System.Drawing.Color.White;
            this.ProfilePic.Location = new System.Drawing.Point(55, 115);
            this.ProfilePic.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(287, 287);
            this.ProfilePic.TabIndex = 1;
            this.ProfilePic.Click += new System.EventHandler(this.ProfilePic_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.showbtn);
            this.panel1.Controls.Add(this.hidebtn2);
            this.panel1.Controls.Add(this.confirmpstxt);
            this.panel1.Controls.Add(this.LessonCostTxt);
            this.panel1.Controls.Add(this.DateSelect);
            this.panel1.Controls.Add(this.show_pass_btn);
            this.panel1.Controls.Add(this.hide_pass_btn);
            this.panel1.Controls.Add(this.checkpanel);
            this.panel1.Controls.Add(this.phntxt);
            this.panel1.Controls.Add(this.genderPanel);
            this.panel1.Controls.Add(this.passtxt);
            this.panel1.Controls.Add(this.fnametxt);
            this.panel1.Controls.Add(this.unametxt);
            this.panel1.Controls.Add(this.lnametxt);
            this.panel1.Controls.Add(this.mailtxt);
            this.panel1.Controls.Add(this.dobtxt);
            this.panel1.Location = new System.Drawing.Point(385, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 443);
            this.panel1.TabIndex = 40;
            // 
            // showbtn
            // 
            this.showbtn.BackColor = System.Drawing.Color.Transparent;
            this.showbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showbtn.Image = ((System.Drawing.Image)(resources.GetObject("showbtn.Image")));
            this.showbtn.Location = new System.Drawing.Point(275, 377);
            this.showbtn.Margin = new System.Windows.Forms.Padding(2);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(45, 28);
            this.showbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showbtn.TabIndex = 51;
            this.showbtn.TabStop = false;
            this.showbtn.Visible = false;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // hidebtn2
            // 
            this.hidebtn2.BackColor = System.Drawing.Color.Transparent;
            this.hidebtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidebtn2.Image = ((System.Drawing.Image)(resources.GetObject("hidebtn2.Image")));
            this.hidebtn2.Location = new System.Drawing.Point(275, 377);
            this.hidebtn2.Margin = new System.Windows.Forms.Padding(2);
            this.hidebtn2.Name = "hidebtn2";
            this.hidebtn2.Size = new System.Drawing.Size(45, 28);
            this.hidebtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidebtn2.TabIndex = 52;
            this.hidebtn2.TabStop = false;
            this.hidebtn2.Visible = false;
            this.hidebtn2.Click += new System.EventHandler(this.hidebtn2_Click);
            // 
            // confirmpstxt
            // 
            this.confirmpstxt.Location = new System.Drawing.Point(28, 366);
            this.confirmpstxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmpstxt.Name = "confirmpstxt";
            this.confirmpstxt.Size = new System.Drawing.Size(307, 54);
            this.confirmpstxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.confirmpstxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.confirmpstxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.confirmpstxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirmpstxt.StateActive.Border.Width = -2;
            this.confirmpstxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.confirmpstxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpstxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.confirmpstxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.confirmpstxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.confirmpstxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.confirmpstxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirmpstxt.StateDisabled.Border.Width = -2;
            this.confirmpstxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.confirmpstxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.confirmpstxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.confirmpstxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.confirmpstxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.confirmpstxt.TabIndex = 50;
            this.confirmpstxt.Text = "Confirm Password";
            this.confirmpstxt.Visible = false;
            this.confirmpstxt.Enter += new System.EventHandler(this.confirmpstxt_Enter);
            this.confirmpstxt.Leave += new System.EventHandler(this.confirmpstxt_Leave);
            // 
            // LessonCostTxt
            // 
            this.LessonCostTxt.Location = new System.Drawing.Point(369, 306);
            this.LessonCostTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LessonCostTxt.Name = "LessonCostTxt";
            this.LessonCostTxt.Size = new System.Drawing.Size(307, 54);
            this.LessonCostTxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.LessonCostTxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.LessonCostTxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.LessonCostTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LessonCostTxt.StateActive.Border.Width = -2;
            this.LessonCostTxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.LessonCostTxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonCostTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.LessonCostTxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.LessonCostTxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.LessonCostTxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.LessonCostTxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LessonCostTxt.StateDisabled.Border.Width = -2;
            this.LessonCostTxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.LessonCostTxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LessonCostTxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.LessonCostTxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.LessonCostTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.LessonCostTxt.TabIndex = 49;
            this.LessonCostTxt.Text = "Lesson Cost";
            this.LessonCostTxt.TextChanged += new System.EventHandler(this.LessonCostTxt_TextChanged);
            this.LessonCostTxt.Enter += new System.EventHandler(this.LessonCostTxt_Enter);
            this.LessonCostTxt.Leave += new System.EventHandler(this.LessonCostTxt_Leave);
            // 
            // DateSelect
            // 
            this.DateSelect.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSelect.Location = new System.Drawing.Point(302, 117);
            this.DateSelect.Margin = new System.Windows.Forms.Padding(2);
            this.DateSelect.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateSelect.MinDate = new System.DateTime(1971, 12, 1, 0, 0, 0, 0);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.Size = new System.Drawing.Size(18, 20);
            this.DateSelect.TabIndex = 48;
            this.DateSelect.ValueChanged += new System.EventHandler(this.DateSelect_ValueChanged);
            // 
            // show_pass_btn
            // 
            this.show_pass_btn.BackColor = System.Drawing.Color.Transparent;
            this.show_pass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_pass_btn.Image = ((System.Drawing.Image)(resources.GetObject("show_pass_btn.Image")));
            this.show_pass_btn.Location = new System.Drawing.Point(275, 314);
            this.show_pass_btn.Margin = new System.Windows.Forms.Padding(2);
            this.show_pass_btn.Name = "show_pass_btn";
            this.show_pass_btn.Size = new System.Drawing.Size(45, 28);
            this.show_pass_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_pass_btn.TabIndex = 44;
            this.show_pass_btn.TabStop = false;
            this.show_pass_btn.Visible = false;
            this.show_pass_btn.Click += new System.EventHandler(this.show_pass_btn_Click);
            // 
            // hide_pass_btn
            // 
            this.hide_pass_btn.BackColor = System.Drawing.Color.Transparent;
            this.hide_pass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide_pass_btn.Image = ((System.Drawing.Image)(resources.GetObject("hide_pass_btn.Image")));
            this.hide_pass_btn.Location = new System.Drawing.Point(275, 314);
            this.hide_pass_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hide_pass_btn.Name = "hide_pass_btn";
            this.hide_pass_btn.Size = new System.Drawing.Size(45, 28);
            this.hide_pass_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide_pass_btn.TabIndex = 45;
            this.hide_pass_btn.TabStop = false;
            this.hide_pass_btn.Visible = false;
            this.hide_pass_btn.Click += new System.EventHandler(this.hide_pass_btn_Click);
            // 
            // checkpanel
            // 
            this.checkpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.checkpanel.Controls.Add(this.AdminRB);
            this.checkpanel.Controls.Add(this.UserRB);
            this.checkpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.checkpanel.Location = new System.Drawing.Point(369, 239);
            this.checkpanel.Margin = new System.Windows.Forms.Padding(2);
            this.checkpanel.Name = "checkpanel";
            this.checkpanel.Size = new System.Drawing.Size(307, 54);
            this.checkpanel.TabIndex = 43;
            this.checkpanel.Visible = false;
            // 
            // AdminRB
            // 
            this.AdminRB.AutoSize = true;
            this.AdminRB.Location = new System.Drawing.Point(15, 8);
            this.AdminRB.Margin = new System.Windows.Forms.Padding(2);
            this.AdminRB.Name = "AdminRB";
            this.AdminRB.Size = new System.Drawing.Size(99, 33);
            this.AdminRB.TabIndex = 0;
            this.AdminRB.TabStop = true;
            this.AdminRB.Text = "Admin";
            this.AdminRB.UseVisualStyleBackColor = true;
            this.AdminRB.CheckedChanged += new System.EventHandler(this.AdminRB_CheckedChanged);
            // 
            // UserRB
            // 
            this.UserRB.AutoSize = true;
            this.UserRB.Location = new System.Drawing.Point(137, 8);
            this.UserRB.Margin = new System.Windows.Forms.Padding(2);
            this.UserRB.Name = "UserRB";
            this.UserRB.Size = new System.Drawing.Size(82, 33);
            this.UserRB.TabIndex = 1;
            this.UserRB.TabStop = true;
            this.UserRB.Text = "User";
            this.UserRB.UseVisualStyleBackColor = true;
            this.UserRB.CheckedChanged += new System.EventHandler(this.UserRB_CheckedChanged);
            // 
            // phntxt
            // 
            this.phntxt.Location = new System.Drawing.Point(369, 171);
            this.phntxt.Margin = new System.Windows.Forms.Padding(2);
            this.phntxt.Name = "phntxt";
            this.phntxt.Size = new System.Drawing.Size(307, 54);
            this.phntxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.phntxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.phntxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.phntxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phntxt.StateActive.Border.Width = -2;
            this.phntxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.phntxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phntxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.phntxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.phntxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.phntxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.phntxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phntxt.StateDisabled.Border.Width = -2;
            this.phntxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.phntxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.phntxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.phntxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.phntxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.phntxt.TabIndex = 3;
            this.phntxt.Text = "Phone";
            this.phntxt.TextChanged += new System.EventHandler(this.phntxt_TextChanged);
            this.phntxt.Enter += new System.EventHandler(this.phntxt_Enter);
            this.phntxt.Leave += new System.EventHandler(this.phntxt_Leave);
            // 
            // genderPanel
            // 
            this.genderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.genderPanel.Controls.Add(this.MaleRB);
            this.genderPanel.Controls.Add(this.FemaleRB);
            this.genderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.genderPanel.Location = new System.Drawing.Point(369, 101);
            this.genderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(307, 54);
            this.genderPanel.TabIndex = 5;
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Location = new System.Drawing.Point(15, 8);
            this.MaleRB.Margin = new System.Windows.Forms.Padding(2);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(84, 33);
            this.MaleRB.TabIndex = 0;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Male";
            this.MaleRB.UseVisualStyleBackColor = true;
            this.MaleRB.CheckedChanged += new System.EventHandler(this.MaleRB_CheckedChanged);
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Location = new System.Drawing.Point(137, 8);
            this.FemaleRB.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(113, 33);
            this.FemaleRB.TabIndex = 1;
            this.FemaleRB.TabStop = true;
            this.FemaleRB.Text = "Female";
            this.FemaleRB.UseVisualStyleBackColor = true;
            this.FemaleRB.CheckedChanged += new System.EventHandler(this.FemaleRB_CheckedChanged);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(28, 303);
            this.passtxt.Margin = new System.Windows.Forms.Padding(2);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(307, 54);
            this.passtxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.passtxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.passtxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.passtxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passtxt.StateActive.Border.Width = -2;
            this.passtxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.passtxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.passtxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.passtxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.passtxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.passtxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passtxt.StateDisabled.Border.Width = -2;
            this.passtxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.passtxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.passtxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.passtxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.passtxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.passtxt.TabIndex = 8;
            this.passtxt.Text = "Password";
            this.passtxt.Visible = false;
            this.passtxt.Enter += new System.EventHandler(this.passtxt_Enter);
            this.passtxt.Leave += new System.EventHandler(this.passtxt_Leave);
            // 
            // fnametxt
            // 
            this.fnametxt.Location = new System.Drawing.Point(28, 35);
            this.fnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(307, 54);
            this.fnametxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.fnametxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.fnametxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.fnametxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fnametxt.StateActive.Border.Width = -2;
            this.fnametxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.fnametxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.fnametxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.fnametxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.fnametxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.fnametxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fnametxt.StateDisabled.Border.Width = -2;
            this.fnametxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.fnametxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.fnametxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.fnametxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.fnametxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.fnametxt.TabIndex = 1;
            this.fnametxt.Text = "First Name";
            this.fnametxt.TextChanged += new System.EventHandler(this.fnametxt_TextChanged);
            this.fnametxt.Enter += new System.EventHandler(this.fnametxt_Enter);
            this.fnametxt.Leave += new System.EventHandler(this.fnametxt_Leave);
            // 
            // unametxt
            // 
            this.unametxt.Location = new System.Drawing.Point(28, 239);
            this.unametxt.Margin = new System.Windows.Forms.Padding(2);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(307, 54);
            this.unametxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.unametxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.unametxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.unametxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.unametxt.StateActive.Border.Width = -2;
            this.unametxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.unametxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.unametxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.unametxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.unametxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.unametxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.unametxt.StateDisabled.Border.Width = -2;
            this.unametxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.unametxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.unametxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.unametxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.unametxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.unametxt.TabIndex = 9;
            this.unametxt.Text = "Username";
            this.unametxt.Visible = false;
            this.unametxt.Enter += new System.EventHandler(this.unametxt_Enter);
            this.unametxt.Leave += new System.EventHandler(this.unametxt_Leave);
            // 
            // lnametxt
            // 
            this.lnametxt.Location = new System.Drawing.Point(369, 35);
            this.lnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(307, 54);
            this.lnametxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.lnametxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.lnametxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.lnametxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lnametxt.StateActive.Border.Width = -2;
            this.lnametxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.lnametxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.lnametxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.lnametxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.lnametxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.lnametxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lnametxt.StateDisabled.Border.Width = -2;
            this.lnametxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.lnametxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lnametxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.lnametxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.lnametxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.lnametxt.TabIndex = 2;
            this.lnametxt.Text = "Last Name";
            this.lnametxt.Enter += new System.EventHandler(this.lnametxt_Enter);
            this.lnametxt.Leave += new System.EventHandler(this.lnametxt_Leave);
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(28, 171);
            this.mailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(307, 54);
            this.mailtxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.mailtxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.mailtxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.mailtxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mailtxt.StateActive.Border.Width = -2;
            this.mailtxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.mailtxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailtxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.mailtxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.mailtxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.mailtxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.mailtxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mailtxt.StateDisabled.Border.Width = -2;
            this.mailtxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.mailtxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mailtxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.mailtxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.mailtxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.mailtxt.TabIndex = 4;
            this.mailtxt.Text = "Email";
            this.mailtxt.TextChanged += new System.EventHandler(this.mailtxt_TextChanged);
            this.mailtxt.Enter += new System.EventHandler(this.mailtxt_Enter);
            this.mailtxt.Leave += new System.EventHandler(this.mailtxt_Leave);
            // 
            // dobtxt
            // 
            this.dobtxt.Location = new System.Drawing.Point(28, 101);
            this.dobtxt.Margin = new System.Windows.Forms.Padding(2);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.ReadOnly = true;
            this.dobtxt.Size = new System.Drawing.Size(307, 54);
            this.dobtxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.dobtxt.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.dobtxt.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.dobtxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dobtxt.StateActive.Border.Width = -2;
            this.dobtxt.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.dobtxt.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobtxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.dobtxt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.dobtxt.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.dobtxt.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.dobtxt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dobtxt.StateDisabled.Border.Width = -2;
            this.dobtxt.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.dobtxt.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dobtxt.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.dobtxt.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.dobtxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.dobtxt.TabIndex = 6;
            this.dobtxt.Text = "Date of Birth";
            // 
            // btnAdd
            // 
            this.btnAdd.CheckButton = false;
            this.btnAdd.Checked = false;
            this.btnAdd.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnAdd.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdd.CheckedOutline = System.Drawing.Color.White;
            this.btnAdd.Content = "Add";
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnAdd.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnAdd.HoveredImageTint = System.Drawing.Color.White;
            this.btnAdd.HoverOutline = System.Drawing.Color.Transparent;
            this.btnAdd.Image = null;
            this.btnAdd.ImageAutoCenter = true;
            this.btnAdd.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageTint = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(52, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnAdd.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAdd.OutlineThickness = 1.6F;
            this.btnAdd.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.White;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAdd.Size = new System.Drawing.Size(137, 54);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.CheckButton = false;
            this.cancelbtn.Checked = false;
            this.cancelbtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.cancelbtn.CheckedImageTint = System.Drawing.Color.White;
            this.cancelbtn.CheckedOutline = System.Drawing.Color.White;
            this.cancelbtn.Content = "Cancel";
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.cancelbtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.cancelbtn.HoveredImageTint = System.Drawing.Color.White;
            this.cancelbtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelbtn.Image = null;
            this.cancelbtn.ImageAutoCenter = true;
            this.cancelbtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.cancelbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cancelbtn.ImageTint = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(195, 415);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.NormalBackground = System.Drawing.Color.Transparent;
            this.cancelbtn.NormalOutline = System.Drawing.Color.White;
            this.cancelbtn.OutlineThickness = 1.6F;
            this.cancelbtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.cancelbtn.PressedImageTint = System.Drawing.Color.White;
            this.cancelbtn.PressedOutline = System.Drawing.Color.White;
            this.cancelbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.cancelbtn.Size = new System.Drawing.Size(147, 54);
            this.cancelbtn.TabIndex = 42;
            this.cancelbtn.TextOffset = new System.Drawing.Point(0, 0);
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.fnametxt;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 40;
            this.bunifuElipse2.TargetControl = this.lnametxt;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 40;
            this.bunifuElipse3.TargetControl = this.dobtxt;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 40;
            this.bunifuElipse4.TargetControl = this.genderPanel;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 40;
            this.bunifuElipse5.TargetControl = this.mailtxt;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 40;
            this.bunifuElipse6.TargetControl = this.phntxt;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 40;
            this.bunifuElipse7.TargetControl = this.unametxt;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 40;
            this.bunifuElipse8.TargetControl = this.checkpanel;
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 40;
            this.bunifuElipse9.TargetControl = this.passtxt;
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 40;
            this.bunifuElipse10.TargetControl = this;
            // 
            // bgWorkerAdd
            // 
            this.bgWorkerAdd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerAdd_DoWork);
            this.bgWorkerAdd.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerAdd_RunWorkerCompleted);
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 40;
            this.bunifuElipse11.TargetControl = this.LessonCostTxt;
            // 
            // bunifuElipse12
            // 
            this.bunifuElipse12.ElipseRadius = 40;
            this.bunifuElipse12.TargetControl = this.confirmpstxt;
            // 
            // faddingTimer
            // 
            this.faddingTimer.Interval = 10;
            // 
            // faddingTimer2
            // 
            this.faddingTimer2.Interval = 7;
            this.faddingTimer2.Tick += new System.EventHandler(this.faddingTimer2_Tick);
            // 
            // AddPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1122, 644);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProfilePic);
            this.Controls.Add(this.labelName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPeople";
            this.Load += new System.EventHandler(this.AddPeople_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_pass_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pass_btn)).EndInit();
            this.checkpanel.ResumeLayout(false);
            this.checkpanel.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private CuoreUI.Controls.cuiPictureBox ProfilePic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox show_pass_btn;
        private System.Windows.Forms.PictureBox hide_pass_btn;
        private System.Windows.Forms.Panel checkpanel;
        private System.Windows.Forms.RadioButton AdminRB;
        private System.Windows.Forms.RadioButton UserRB;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton MaleRB;
        private System.Windows.Forms.RadioButton FemaleRB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox fnametxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox unametxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lnametxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mailtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phntxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox dobtxt;
        private CuoreUI.Controls.cuiButton btnAdd;
        private CuoreUI.Controls.cuiButton cancelbtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private System.ComponentModel.BackgroundWorker bgWorkerAdd;
        private System.Windows.Forms.DateTimePicker DateSelect;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox LessonCostTxt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private System.Windows.Forms.PictureBox showbtn;
        private System.Windows.Forms.PictureBox hidebtn2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox confirmpstxt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse12;
        private System.Windows.Forms.Timer faddingTimer;
        private System.Windows.Forms.Timer faddingTimer2;
    }
}