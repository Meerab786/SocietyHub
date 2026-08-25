namespace DB_Final
{
    partial class SponsorsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalSponsors = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.lblSelectedName = new System.Windows.Forms.Label();
            this.lblSelectedOrg = new System.Windows.Forms.Label();
            this.lblSelectedEmail = new System.Windows.Forms.Label();
            this.lblSelectedPhone = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEvents = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.dgvSponsor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlStats.SuspendLayout();
            this.pnlSelected.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSponsor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(61, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sponsors";
            // 
            // lblTotalSponsors
            // 
            this.lblTotalSponsors.AutoSize = true;
            this.lblTotalSponsors.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalSponsors.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTotalSponsors.Location = new System.Drawing.Point(21, 63);
            this.lblTotalSponsors.Name = "lblTotalSponsors";
            this.lblTotalSponsors.Size = new System.Drawing.Size(46, 54);
            this.lblTotalSponsors.TabIndex = 1;
            this.lblTotalSponsors.Text = "0";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLabel.Location = new System.Drawing.Point(25, 22);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(164, 30);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Total Sponsors";
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.Pink;
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStats.Controls.Add(this.lblTotalLabel);
            this.pnlStats.Controls.Add(this.lblTotalSponsors);
            this.pnlStats.Location = new System.Drawing.Point(1164, 249);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(314, 133);
            this.pnlStats.TabIndex = 1;
            // 
            // pnlSelected
            // 
            this.pnlSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelected.Controls.Add(this.lblSelectedTitle);
            this.pnlSelected.Controls.Add(this.lblSelectedName);
            this.pnlSelected.Controls.Add(this.lblSelectedOrg);
            this.pnlSelected.Controls.Add(this.lblSelectedEmail);
            this.pnlSelected.Controls.Add(this.lblSelectedPhone);
            this.pnlSelected.Location = new System.Drawing.Point(1164, 437);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(314, 274);
            this.pnlSelected.TabIndex = 7;
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblSelectedTitle.Location = new System.Drawing.Point(11, 20);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(174, 28);
            this.lblSelectedTitle.TabIndex = 0;
            this.lblSelectedTitle.Text = "Selected Sponsor";
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedName.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedName.Location = new System.Drawing.Point(11, 76);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(235, 30);
            this.lblSelectedName.TabIndex = 1;
            this.lblSelectedName.Text = "—";
            // 
            // lblSelectedOrg
            // 
            this.lblSelectedOrg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedOrg.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectedOrg.Location = new System.Drawing.Point(11, 121);
            this.lblSelectedOrg.Name = "lblSelectedOrg";
            this.lblSelectedOrg.Size = new System.Drawing.Size(235, 30);
            this.lblSelectedOrg.TabIndex = 2;
            this.lblSelectedOrg.Text = "—";
            // 
            // lblSelectedEmail
            // 
            this.lblSelectedEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedEmail.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedEmail.Location = new System.Drawing.Point(11, 166);
            this.lblSelectedEmail.Name = "lblSelectedEmail";
            this.lblSelectedEmail.Size = new System.Drawing.Size(235, 30);
            this.lblSelectedEmail.TabIndex = 3;
            this.lblSelectedEmail.Text = "—";
            // 
            // lblSelectedPhone
            // 
            this.lblSelectedPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedPhone.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedPhone.Location = new System.Drawing.Point(11, 211);
            this.lblSelectedPhone.Name = "lblSelectedPhone";
            this.lblSelectedPhone.Size = new System.Drawing.Size(235, 30);
            this.lblSelectedPhone.TabIndex = 4;
            this.lblSelectedPhone.Text = "—";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Indigo;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1250, 62);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button1.Size = new System.Drawing.Size(228, 60);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "+ Add Sponsors";
            this.guna2Button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlEvents
            // 
            this.pnlEvents.Controls.Add(this.label2);
            this.pnlEvents.Controls.Add(this.guna2Button1);
            this.pnlEvents.Controls.Add(this.txtSearch);
            this.pnlEvents.Controls.Add(this.lblTitle);
            this.pnlEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEvents.Location = new System.Drawing.Point(0, 0);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(1555, 191);
            this.pnlEvents.TabIndex = 35;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(69, 139);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search by name, org or email...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(533, 33);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Tag = "Enter Venue Name ";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2Button6
            // 
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Crimson;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = global::DB_Final.Properties.Resources.delete__2_;
            this.guna2Button6.Location = new System.Drawing.Point(1196, 865);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button6.Size = new System.Drawing.Size(249, 60);
            this.guna2Button6.TabIndex = 33;
            this.guna2Button6.Text = "Delete";
            this.guna2Button6.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::DB_Final.Properties.Resources.edit__1_;
            this.btnEdit.Location = new System.Drawing.Point(1196, 768);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnEdit.Size = new System.Drawing.Size(249, 60);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvSponsor
            // 
            this.dgvSponsor.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvSponsor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSponsor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSponsor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSponsor.ColumnHeadersHeight = 30;
            this.dgvSponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSponsor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colOrganization,
            this.colEmail,
            this.colPhone});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSponsor.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSponsor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSponsor.Location = new System.Drawing.Point(69, 249);
            this.dgvSponsor.MultiSelect = false;
            this.dgvSponsor.Name = "dgvSponsor";
            this.dgvSponsor.ReadOnly = true;
            this.dgvSponsor.RowHeadersVisible = false;
            this.dgvSponsor.RowHeadersWidth = 62;
            this.dgvSponsor.RowTemplate.Height = 28;
            this.dgvSponsor.Size = new System.Drawing.Size(1022, 676);
            this.dgvSponsor.TabIndex = 36;
            this.dgvSponsor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSponsor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSponsor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSponsor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSponsor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSponsor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSponsor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSponsor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSponsor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSponsor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSponsor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSponsor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSponsor.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvSponsor.ThemeStyle.ReadOnly = true;
            this.dgvSponsor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSponsor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSponsor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSponsor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSponsor.ThemeStyle.RowsStyle.Height = 28;
            this.dgvSponsor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSponsor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSponsor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSponsors_CellClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colOrganization
            // 
            this.colOrganization.HeaderText = "Organization";
            this.colOrganization.MinimumWidth = 8;
            this.colOrganization.Name = "colOrganization";
            this.colOrganization.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search Sponsors:";
            // 
            // SponsorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvSponsor);
            this.Controls.Add(this.pnlEvents);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlSelected);
            this.Name = "SponsorsForm";
            this.Size = new System.Drawing.Size(1555, 975);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlSelected.ResumeLayout(false);
            this.pnlSelected.PerformLayout();
            this.pnlEvents.ResumeLayout(false);
            this.pnlEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSponsor)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalSponsors;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlSelected;
        private System.Windows.Forms.Label lblSelectedEmail;
        private System.Windows.Forms.Label lblSelectedPhone;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.Label lblSelectedOrg;
        private System.Windows.Forms.Label lblSelectedName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Panel pnlEvents;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrganization;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.Label label2;
    }

}

        #endregion
