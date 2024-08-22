namespace AdminSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.HidePassBtn = new CuoreUI.Controls.cuiButton();
            this.showPassBtn = new CuoreUI.Controls.cuiButton();
            this.btnLogin = new CuoreUI.Controls.cuiButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorkerLogin = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cuiButton1
            // 
            this.cuiButton1.AutoSize = true;
            this.cuiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Red;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.Black;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.Brown;
            this.cuiButton1.Content = "";
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Red;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.White;
            this.cuiButton1.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton1.Image")));
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.Location = new System.Drawing.Point(770, 6);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.cuiButton1.OutlineThickness = 0F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.Cornsilk;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Coral;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(23, 24);
            this.cuiButton1.TabIndex = 0;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(55, 113);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 54);
            this.txtUsername.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtUsername.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUsername.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtUsername.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateActive.Border.Width = -2;
            this.txtUsername.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.txtUsername.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateActive.Content.Padding = new System.Windows.Forms.Padding(-1, 12, -1, 13);
            this.txtUsername.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtUsername.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUsername.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtUsername.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateDisabled.Border.Width = -2;
            this.txtUsername.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.txtUsername.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1, 12, -1, 13);
            this.txtUsername.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(55, 179);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 54);
            this.txtPassword.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtPassword.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtPassword.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtPassword.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateActive.Border.Width = -2;
            this.txtPassword.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.txtPassword.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateActive.Content.Padding = new System.Windows.Forms.Padding(-1, 12, -1, 13);
            this.txtPassword.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtPassword.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtPassword.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtPassword.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateDisabled.Border.Width = -2;
            this.txtPassword.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.txtPassword.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1, 12, -1, 13);
            this.txtPassword.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.LogPanel.Controls.Add(this.errorLabel);
            this.LogPanel.Controls.Add(this.HidePassBtn);
            this.LogPanel.Controls.Add(this.showPassBtn);
            this.LogPanel.Controls.Add(this.btnLogin);
            this.LogPanel.Controls.Add(this.txtPassword);
            this.LogPanel.Controls.Add(this.txtUsername);
            this.LogPanel.Controls.Add(this.label1);
            this.LogPanel.Location = new System.Drawing.Point(432, 45);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(361, 342);
            this.LogPanel.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(214)))), ((int)(((byte)(232)))));
            this.errorLabel.Location = new System.Drawing.Point(107, 301);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(81, 20);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "                  ";
            // 
            // HidePassBtn
            // 
            this.HidePassBtn.CheckButton = false;
            this.HidePassBtn.Checked = false;
            this.HidePassBtn.CheckedBackground = System.Drawing.Color.Transparent;
            this.HidePassBtn.CheckedImageTint = System.Drawing.Color.White;
            this.HidePassBtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.HidePassBtn.Content = "";
            this.HidePassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.HidePassBtn.ForeColor = System.Drawing.Color.White;
            this.HidePassBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.HidePassBtn.HoveredImageTint = System.Drawing.Color.White;
            this.HidePassBtn.HoverOutline = System.Drawing.Color.White;
            this.HidePassBtn.Image = ((System.Drawing.Image)(resources.GetObject("HidePassBtn.Image")));
            this.HidePassBtn.ImageAutoCenter = true;
            this.HidePassBtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.HidePassBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.HidePassBtn.ImageTint = System.Drawing.Color.White;
            this.HidePassBtn.Location = new System.Drawing.Point(311, 190);
            this.HidePassBtn.Name = "HidePassBtn";
            this.HidePassBtn.NormalBackground = System.Drawing.Color.Transparent;
            this.HidePassBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.HidePassBtn.OutlineThickness = 1.6F;
            this.HidePassBtn.PressedBackground = System.Drawing.Color.Coral;
            this.HidePassBtn.PressedImageTint = System.Drawing.Color.White;
            this.HidePassBtn.PressedOutline = System.Drawing.Color.White;
            this.HidePassBtn.Rounding = new System.Windows.Forms.Padding(15);
            this.HidePassBtn.Size = new System.Drawing.Size(39, 36);
            this.HidePassBtn.TabIndex = 8;
            this.HidePassBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.HidePassBtn.Click += new System.EventHandler(this.HidePassBtn_Click);
            // 
            // showPassBtn
            // 
            this.showPassBtn.CheckButton = false;
            this.showPassBtn.Checked = false;
            this.showPassBtn.CheckedBackground = System.Drawing.Color.Transparent;
            this.showPassBtn.CheckedImageTint = System.Drawing.Color.White;
            this.showPassBtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.showPassBtn.Content = "";
            this.showPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.showPassBtn.ForeColor = System.Drawing.Color.White;
            this.showPassBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.showPassBtn.HoveredImageTint = System.Drawing.Color.White;
            this.showPassBtn.HoverOutline = System.Drawing.Color.White;
            this.showPassBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPassBtn.Image")));
            this.showPassBtn.ImageAutoCenter = true;
            this.showPassBtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.showPassBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.showPassBtn.ImageTint = System.Drawing.Color.White;
            this.showPassBtn.Location = new System.Drawing.Point(311, 189);
            this.showPassBtn.Name = "showPassBtn";
            this.showPassBtn.NormalBackground = System.Drawing.Color.Transparent;
            this.showPassBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.showPassBtn.OutlineThickness = 1.6F;
            this.showPassBtn.PressedBackground = System.Drawing.Color.Coral;
            this.showPassBtn.PressedImageTint = System.Drawing.Color.White;
            this.showPassBtn.PressedOutline = System.Drawing.Color.White;
            this.showPassBtn.Rounding = new System.Windows.Forms.Padding(15);
            this.showPassBtn.Size = new System.Drawing.Size(39, 36);
            this.showPassBtn.TabIndex = 7;
            this.showPassBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.showPassBtn.Click += new System.EventHandler(this.showPassBtn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.CheckButton = false;
            this.btnLogin.Checked = false;
            this.btnLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.White;
            this.btnLogin.Content = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnLogin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnLogin.HoveredImageTint = System.Drawing.Color.White;
            this.btnLogin.HoverOutline = System.Drawing.Color.Transparent;
            this.btnLogin.Image = null;
            this.btnLogin.ImageAutoCenter = true;
            this.btnLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageTint = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(55, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnLogin.NormalOutline = System.Drawing.Color.Transparent;
            this.btnLogin.OutlineThickness = 1.6F;
            this.btnLogin.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnLogin.PressedImageTint = System.Drawing.Color.White;
            this.btnLogin.PressedOutline = System.Drawing.Color.White;
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(15);
            this.btnLogin.Size = new System.Drawing.Size(253, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.LogPanel;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.txtUsername;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.txtPassword;
            // 
            // backgroundWorkerLogin
            // 
            this.backgroundWorkerLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLogin_DoWork);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cuiButton1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private System.Windows.Forms.Panel LogPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private CuoreUI.Controls.cuiButton btnLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private CuoreUI.Controls.cuiButton showPassBtn;
        private CuoreUI.Controls.cuiButton HidePassBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLogin;
    }
}