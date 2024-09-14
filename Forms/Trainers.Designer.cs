namespace AdminSystem.Forms
{
    partial class Trainers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainers));
            this.bgWorkerList = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerGetEmp = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.faddingTime2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.faddingTimer = new System.Windows.Forms.Timer(this.components);
            this.searchBtn = new CuoreUI.Controls.cuiButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.searchtxtbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "guest-32.png");
            // 
            // faddingTime2
            // 
            this.faddingTime2.Interval = 15;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 40;
            // 
            // faddingTimer
            // 
            this.faddingTimer.Interval = 20;
            // 
            // searchBtn
            // 
            this.searchBtn.CheckButton = false;
            this.searchBtn.Checked = false;
            this.searchBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchBtn.CheckedImageTint = System.Drawing.Color.White;
            this.searchBtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.searchBtn.Content = "";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchBtn.HoveredImageTint = System.Drawing.Color.White;
            this.searchBtn.HoverOutline = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAutoCenter = true;
            this.searchBtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.searchBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchBtn.ImageTint = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(742, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.searchBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.searchBtn.OutlineThickness = 1.6F;
            this.searchBtn.PressedBackground = System.Drawing.Color.Transparent;
            this.searchBtn.PressedImageTint = System.Drawing.Color.White;
            this.searchBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.searchBtn.Rounding = new System.Windows.Forms.Padding(20);
            this.searchBtn.Size = new System.Drawing.Size(48, 51);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.searchtxtbox;
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(420, 14);
            this.searchtxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(307, 54);
            this.searchtxtbox.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateActive.Border.Width = -2;
            this.searchtxtbox.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.searchtxtbox.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbox.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.searchtxtbox.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateDisabled.Border.Width = -2;
            this.searchtxtbox.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.searchtxtbox.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchtxtbox.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.searchtxtbox.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.searchtxtbox.TabIndex = 12;
            this.searchtxtbox.Text = "Search";
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
            this.btnAdd.Location = new System.Drawing.Point(257, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnAdd.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAdd.OutlineThickness = 1.6F;
            this.btnAdd.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.White;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAdd.Size = new System.Drawing.Size(149, 54);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trainers";
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1322, 715);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainers";
            this.Text = "Trainers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorkerList;
        private System.ComponentModel.BackgroundWorker bgWorkerGetEmp;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer faddingTime2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer faddingTimer;
        private CuoreUI.Controls.cuiButton searchBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchtxtbox;
        private CuoreUI.Controls.cuiButton btnAdd;
        private System.Windows.Forms.Label label1;
    }
}