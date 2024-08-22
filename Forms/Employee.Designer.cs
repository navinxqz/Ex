namespace AdminSystem.Forms
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMemberView = new System.Windows.Forms.Panel();
            this.EmployeeData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.panelMemberView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // panelMemberView
            // 
            this.panelMemberView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMemberView.Controls.Add(this.EmployeeData);
            this.panelMemberView.Location = new System.Drawing.Point(0, 74);
            this.panelMemberView.Margin = new System.Windows.Forms.Padding(2);
            this.panelMemberView.Name = "panelMemberView";
            this.panelMemberView.Size = new System.Drawing.Size(1423, 679);
            this.panelMemberView.TabIndex = 6;
            this.panelMemberView.Visible = false;
            // 
            // EmployeeData
            // 
            this.EmployeeData.AllowUserToAddRows = false;
            this.EmployeeData.AllowUserToDeleteRows = false;
            this.EmployeeData.AllowUserToResizeColumns = false;
            this.EmployeeData.AllowUserToResizeRows = false;
            this.EmployeeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.EmployeeData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmployeeData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.EmployeeData.ColumnHeadersHeight = 55;
            this.EmployeeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MName,
            this.Username,
            this.Gender,
            this.Age,
            this.Brithday,
            this.Email,
            this.Phone,
            this.Admin,
            this.Account});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeData.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmployeeData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EmployeeData.EnableHeadersVisualStyles = false;
            this.EmployeeData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.EmployeeData.Location = new System.Drawing.Point(23, 5);
            this.EmployeeData.Margin = new System.Windows.Forms.Padding(1, 5, 25, 26);
            this.EmployeeData.MultiSelect = false;
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.ReadOnly = true;
            this.EmployeeData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeData.RowHeadersVisible = false;
            this.EmployeeData.RowHeadersWidth = 82;
            this.EmployeeData.RowTemplate.Height = 45;
            this.EmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeData.Size = new System.Drawing.Size(1308, 674);
            this.EmployeeData.TabIndex = 36;
            this.EmployeeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeData_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "Name";
            this.MName.HeaderText = "Name";
            this.MName.MinimumWidth = 8;
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Brithday
            // 
            this.Brithday.DataPropertyName = "BrithDay";
            this.Brithday.HeaderText = "Brithday";
            this.Brithday.MinimumWidth = 8;
            this.Brithday.Name = "Brithday";
            this.Brithday.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "PhoneNumber";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.MinimumWidth = 8;
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "AccountStatus";
            this.Account.HeaderText = "Account";
            this.Account.MinimumWidth = 8;
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(876, 9);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(307, 54);
            this.textSearch.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.textSearch.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.textSearch.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.textSearch.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textSearch.StateActive.Border.Width = -2;
            this.textSearch.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.textSearch.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.textSearch.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.textSearch.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.textSearch.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.textSearch.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textSearch.StateDisabled.Border.Width = -2;
            this.textSearch.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.textSearch.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textSearch.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.textSearch.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.textSearch.StateNormal.Content.Padding = new System.Windows.Forms.Padding(15, 12, -1, 13);
            this.textSearch.TabIndex = 3;
            this.textSearch.Text = "Search";
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
            this.btnAdd.Location = new System.Drawing.Point(713, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnAdd.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAdd.OutlineThickness = 1.6F;
            this.btnAdd.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.White;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAdd.Size = new System.Drawing.Size(149, 54);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1293, 715);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelMemberView);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.panelMemberView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMemberView;
        private System.Windows.Forms.DataGridView EmployeeData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brithday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Account;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textSearch;
        private CuoreUI.Controls.cuiButton btnAdd;
    }
}