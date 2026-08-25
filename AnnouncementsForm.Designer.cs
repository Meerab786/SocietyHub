using System;
using System.Drawing;
using System.Runtime.InteropServices.Expando;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace DB_Final
{
    partial class AnnouncementsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAnnouncementHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilterSociety = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchAnnouncement = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();
            this.pnlViewDetails = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSociety = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvAnnouncements = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSociety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActions = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooterPagination = new System.Windows.Forms.Panel();
            this.lblShowingEntries = new System.Windows.Forms.Label();
            this.btnPagePrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnPage1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPage2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPage3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPageNext = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAnnouncementHeader.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            this.pnlViewDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnouncements)).BeginInit();
            this.pnlFooterPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnnouncementHeader
            // 
            this.pnlAnnouncementHeader.BackColor = System.Drawing.Color.White;
            this.pnlAnnouncementHeader.Controls.Add(this.guna2Button2);
            this.pnlAnnouncementHeader.Controls.Add(this.label3);
            this.pnlAnnouncementHeader.Controls.Add(this.label2);
            this.pnlAnnouncementHeader.Controls.Add(this.cmbFilterSociety);
            this.pnlAnnouncementHeader.Controls.Add(this.txtSearchAnnouncement);
            this.pnlAnnouncementHeader.Controls.Add(this.label1);
            this.pnlAnnouncementHeader.Controls.Add(this.guna2Button1);
            this.pnlAnnouncementHeader.Controls.Add(this.label4);
            this.pnlAnnouncementHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnnouncementHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAnnouncementHeader.Name = "pnlAnnouncementHeader";
            this.pnlAnnouncementHeader.Size = new System.Drawing.Size(1575, 240);
            this.pnlAnnouncementHeader.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(639, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Search By Society";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search By Title";
            // 
            // cmbFilterSociety
            // 
            this.cmbFilterSociety.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterSociety.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterSociety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterSociety.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.cmbFilterSociety.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterSociety.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterSociety.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterSociety.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterSociety.ItemHeight = 20;
            this.cmbFilterSociety.Location = new System.Drawing.Point(644, 180);
            this.cmbFilterSociety.Name = "cmbFilterSociety";
            this.cmbFilterSociety.Size = new System.Drawing.Size(309, 26);
            this.cmbFilterSociety.TabIndex = 30;
            this.cmbFilterSociety.SelectedIndexChanged += new System.EventHandler(this.cmbFilterSociety_SelectedIndexChanged);
            // 
            // txtSearchAnnouncement
            // 
            this.txtSearchAnnouncement.BorderRadius = 6;
            this.txtSearchAnnouncement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAnnouncement.DefaultText = "";
            this.txtSearchAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchAnnouncement.Location = new System.Drawing.Point(78, 180);
            this.txtSearchAnnouncement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchAnnouncement.Name = "txtSearchAnnouncement";
            this.txtSearchAnnouncement.PlaceholderText = "🔍  Search announcements...";
            this.txtSearchAnnouncement.SelectedText = "";
            this.txtSearchAnnouncement.Size = new System.Drawing.Size(450, 36);
            this.txtSearchAnnouncement.TabIndex = 0;
            this.txtSearchAnnouncement.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(78, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Create a new announcement for your society members";
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
            this.guna2Button1.Location = new System.Drawing.Point(1098, 59);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button1.Size = new System.Drawing.Size(350, 60);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "+ Add Announcements";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(75, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 48);
            this.label4.TabIndex = 17;
            this.label4.Text = "Announcements";
            // 
            // pnlGridWrapper
            // 
            this.pnlGridWrapper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlGridWrapper.Controls.Add(this.pnlViewDetails);
            this.pnlGridWrapper.Controls.Add(this.dgvAnnouncements);
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Location = new System.Drawing.Point(0, 240);
            this.pnlGridWrapper.Name = "pnlGridWrapper";
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(85, 10, 85, 10);
            this.pnlGridWrapper.Size = new System.Drawing.Size(1575, 724);
            this.pnlGridWrapper.TabIndex = 0;
            // 
            // pnlViewDetails
            // 
            this.pnlViewDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewDetails.Controls.Add(this.lblTitle);
            this.pnlViewDetails.Controls.Add(this.lblMessage);
            this.pnlViewDetails.Controls.Add(this.lblSociety);
            this.pnlViewDetails.Controls.Add(this.lblDate);
            this.pnlViewDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlViewDetails.Location = new System.Drawing.Point(85, 538);
            this.pnlViewDetails.Name = "pnlViewDetails";
            this.pnlViewDetails.Size = new System.Drawing.Size(1405, 176);
            this.pnlViewDetails.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(26, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 30);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Announcements";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Indigo;
            this.lblMessage.Location = new System.Drawing.Point(26, 104);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(165, 28);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = "Announcements";
            // 
            // lblSociety
            // 
            this.lblSociety.AutoSize = true;
            this.lblSociety.BackColor = System.Drawing.Color.Transparent;
            this.lblSociety.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSociety.ForeColor = System.Drawing.Color.Indigo;
            this.lblSociety.Location = new System.Drawing.Point(26, 61);
            this.lblSociety.Name = "lblSociety";
            this.lblSociety.Size = new System.Drawing.Size(151, 25);
            this.lblSociety.TabIndex = 19;
            this.lblSociety.Text = "Announcements";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Indigo;
            this.lblDate.Location = new System.Drawing.Point(421, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 25);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Announcements";
            // 
            // dgvAnnouncements
            // 
            this.dgvAnnouncements.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAnnouncements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnnouncements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnnouncements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnnouncements.ColumnHeadersHeight = 25;
            this.dgvAnnouncements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAnnouncements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colSociety,
            this.colPostedAt,
            this.colMessage,
            this.colActions,
            this.colDelete,
            this.colView});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnnouncements.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAnnouncements.GridColor = System.Drawing.Color.White;
            this.dgvAnnouncements.Location = new System.Drawing.Point(88, 50);
            this.dgvAnnouncements.MultiSelect = false;
            this.dgvAnnouncements.Name = "dgvAnnouncements";
            this.dgvAnnouncements.RowHeadersVisible = false;
            this.dgvAnnouncements.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAnnouncements.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAnnouncements.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAnnouncements.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAnnouncements.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnnouncements.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAnnouncements.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumPurple;
            this.dgvAnnouncements.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAnnouncements.RowTemplate.Height = 28;
            this.dgvAnnouncements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAnnouncements.Size = new System.Drawing.Size(1360, 515);
            this.dgvAnnouncements.TabIndex = 18;
            this.dgvAnnouncements.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnouncements.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAnnouncements.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAnnouncements.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAnnouncements.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAnnouncements.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgvAnnouncements.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvAnnouncements.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAnnouncements.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAnnouncements.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnnouncements.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAnnouncements.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAnnouncements.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvAnnouncements.ThemeStyle.ReadOnly = false;
            this.dgvAnnouncements.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnouncements.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAnnouncements.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnnouncements.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgvAnnouncements.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAnnouncements.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAnnouncements.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAnnouncements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnnouncements_CellClick);
            this.dgvAnnouncements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnnouncements_CellContentClick);
            // 
            // colTitle
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.colTitle.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 8;
            this.colTitle.Name = "colTitle";
            // 
            // colSociety
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.colSociety.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSociety.HeaderText = "Society";
            this.colSociety.MinimumWidth = 8;
            this.colSociety.Name = "colSociety";
            // 
            // colPostedAt
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.colPostedAt.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPostedAt.HeaderText = "Posted At";
            this.colPostedAt.MinimumWidth = 8;
            this.colPostedAt.Name = "colPostedAt";
            this.colPostedAt.ReadOnly = true;
            // 
            // colMessage
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.colMessage.DefaultCellStyle = dataGridViewCellStyle6;
            this.colMessage.HeaderText = "Message";
            this.colMessage.MinimumWidth = 8;
            this.colMessage.Name = "colMessage";
            this.colMessage.ReadOnly = true;
            // 
            // colActions
            // 
            this.colActions.HeaderText = "";
            this.colActions.MinimumWidth = 8;
            this.colActions.Name = "colActions";
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 8;
            this.colDelete.Name = "colDelete";
            // 
            // colView
            // 
            this.colView.HeaderText = "";
            this.colView.MinimumWidth = 8;
            this.colView.Name = "colView";
            // 
            // colId
            // 
            this.colId.HeaderText = "#";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.Width = 150;
            // 
            // pnlFooterPagination
            // 
            this.pnlFooterPagination.Controls.Add(this.lblShowingEntries);
            this.pnlFooterPagination.Controls.Add(this.btnPagePrev);
            this.pnlFooterPagination.Controls.Add(this.btnPage1);
            this.pnlFooterPagination.Controls.Add(this.btnPage2);
            this.pnlFooterPagination.Controls.Add(this.btnPage3);
            this.pnlFooterPagination.Controls.Add(this.btnPageNext);
            this.pnlFooterPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterPagination.Location = new System.Drawing.Point(0, 894);
            this.pnlFooterPagination.Name = "pnlFooterPagination";
            this.pnlFooterPagination.Size = new System.Drawing.Size(1575, 70);
            this.pnlFooterPagination.TabIndex = 0;
            // 
            // lblShowingEntries
            // 
            this.lblShowingEntries.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblShowingEntries.ForeColor = System.Drawing.Color.Gray;
            this.lblShowingEntries.Location = new System.Drawing.Point(85, 25);
            this.lblShowingEntries.Name = "lblShowingEntries";
            this.lblShowingEntries.Size = new System.Drawing.Size(350, 25);
            this.lblShowingEntries.TabIndex = 0;
            this.lblShowingEntries.Text = "Showing 1 to 5 of 24 announcements";
            // 
            // btnPagePrev
            // 
            this.btnPagePrev.BorderRadius = 4;
            this.btnPagePrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnPagePrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPagePrev.ForeColor = System.Drawing.Color.Black;
            this.btnPagePrev.Location = new System.Drawing.Point(1280, 18);
            this.btnPagePrev.Name = "btnPagePrev";
            this.btnPagePrev.Size = new System.Drawing.Size(36, 36);
            this.btnPagePrev.TabIndex = 1;
            this.btnPagePrev.Text = "‹";
            // 
            // btnPage1
            // 
            this.btnPage1.BorderRadius = 4;
            this.btnPage1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(34)))), ((int)(((byte)(199)))));
            this.btnPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage1.ForeColor = System.Drawing.Color.White;
            this.btnPage1.Location = new System.Drawing.Point(1325, 18);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(36, 36);
            this.btnPage1.TabIndex = 2;
            this.btnPage1.Text = "1";
            // 
            // btnPage2
            // 
            this.btnPage2.BorderRadius = 4;
            this.btnPage2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage2.ForeColor = System.Drawing.Color.Black;
            this.btnPage2.Location = new System.Drawing.Point(1365, 18);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(36, 36);
            this.btnPage2.TabIndex = 3;
            this.btnPage2.Text = "2";
            // 
            // btnPage3
            // 
            this.btnPage3.BorderRadius = 4;
            this.btnPage3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage3.ForeColor = System.Drawing.Color.Black;
            this.btnPage3.Location = new System.Drawing.Point(1405, 18);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(36, 36);
            this.btnPage3.TabIndex = 4;
            this.btnPage3.Text = "3";
            // 
            // btnPageNext
            // 
            this.btnPageNext.BorderRadius = 4;
            this.btnPageNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnPageNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPageNext.ForeColor = System.Drawing.Color.Black;
            this.btnPageNext.Location = new System.Drawing.Point(1450, 18);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(36, 36);
            this.btnPageNext.TabIndex = 5;
            this.btnPageNext.Text = "›";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Indigo;
            this.guna2Button2.Image = global::DB_Final.Properties.Resources.reset_left_fill;
            this.guna2Button2.Location = new System.Drawing.Point(1224, 156);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Yellow;
            this.guna2Button2.Size = new System.Drawing.Size(224, 60);
            this.guna2Button2.TabIndex = 38;
            this.guna2Button2.Text = "Refresh";
            this.guna2Button2.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.pnlGridWrapper);
            this.Controls.Add(this.pnlAnnouncementHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AnnouncementsForm";
            this.Size = new System.Drawing.Size(1575, 964);
            this.pnlAnnouncementHeader.ResumeLayout(false);
            this.pnlAnnouncementHeader.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            this.pnlViewDetails.ResumeLayout(false);
            this.pnlViewDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnouncements)).EndInit();
            this.pnlFooterPagination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Global Variable Variable References Declared at Bottom of control file
        private System.Windows.Forms.Panel pnlAnnouncementHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.Panel pnlFooterPagination;

        private Guna.UI2.WinForms.Guna2TextBox txtSearchAnnouncement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;

        private System.Windows.Forms.Label lblShowingEntries;
        private Guna.UI2.WinForms.Guna2Button btnPagePrev;
        private Guna.UI2.WinForms.Guna2Button btnPage1;
        private Guna.UI2.WinForms.Guna2Button btnPage2;
        private Guna.UI2.WinForms.Guna2Button btnPage3;
        private Guna.UI2.WinForms.Guna2Button btnPageNext;
        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAnnouncements;
        private Panel pnlViewDetails;
        private Label lblTitle;
        private Label lblMessage;
        private Label lblSociety;
        private Label lblDate;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterSociety;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colSociety;
        private DataGridViewTextBoxColumn colPostedAt;
        private DataGridViewTextBoxColumn colMessage;
        private DataGridViewImageColumn colActions;
        private DataGridViewImageColumn colDelete;
        private DataGridViewImageColumn colView;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}