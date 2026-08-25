namespace DB_Final
{
    partial class AddAnnouncement
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
            this.pnlLeftForm = new System.Windows.Forms.Panel();
            this.dtpPostedAt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.lblDescHeader = new System.Windows.Forms.Label();
            this.lblDateHeader = new System.Windows.Forms.Label();
            this.cmbSociety = new System.Windows.Forms.ComboBox();
            this.lblSocietyHeader = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.lblFormSubHeader = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAnnouncementHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLeftForm.SuspendLayout();
            this.pnlAnnouncementHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftForm
            // 
            this.pnlLeftForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlLeftForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftForm.Controls.Add(this.dtpPostedAt);
            this.pnlLeftForm.Controls.Add(this.rtbMessage);
            this.pnlLeftForm.Controls.Add(this.lblDescHeader);
            this.pnlLeftForm.Controls.Add(this.lblDateHeader);
            this.pnlLeftForm.Controls.Add(this.cmbSociety);
            this.pnlLeftForm.Controls.Add(this.lblSocietyHeader);
            this.pnlLeftForm.Controls.Add(this.txtTitle);
            this.pnlLeftForm.Controls.Add(this.lblTitleHeader);
            this.pnlLeftForm.Controls.Add(this.lblFormSubHeader);
            this.pnlLeftForm.Controls.Add(this.lblFormHeader);
            this.pnlLeftForm.ForeColor = System.Drawing.Color.White;
            this.pnlLeftForm.Location = new System.Drawing.Point(345, 203);
            this.pnlLeftForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeftForm.Name = "pnlLeftForm";
            this.pnlLeftForm.Size = new System.Drawing.Size(898, 683);
            this.pnlLeftForm.TabIndex = 1;
            // 
            // dtpPostedAt
            // 
            this.dtpPostedAt.Checked = true;
            this.dtpPostedAt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtpPostedAt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPostedAt.ForeColor = System.Drawing.Color.Black;
            this.dtpPostedAt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpPostedAt.Location = new System.Drawing.Point(106, 335);
            this.dtpPostedAt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPostedAt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPostedAt.Name = "dtpPostedAt";
            this.dtpPostedAt.Size = new System.Drawing.Size(658, 39);
            this.dtpPostedAt.TabIndex = 43;
            this.dtpPostedAt.Value = new System.DateTime(2026, 6, 3, 0, 0, 0, 0);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rtbMessage.Location = new System.Drawing.Point(106, 441);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(658, 210);
            this.rtbMessage.TabIndex = 6;
            this.rtbMessage.Text = "";
            // 
            // lblDescHeader
            // 
            this.lblDescHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescHeader.ForeColor = System.Drawing.Color.Indigo;
            this.lblDescHeader.Location = new System.Drawing.Point(101, 408);
            this.lblDescHeader.Name = "lblDescHeader";
            this.lblDescHeader.Size = new System.Drawing.Size(112, 29);
            this.lblDescHeader.TabIndex = 7;
            this.lblDescHeader.Text = "Message";
            // 
            // lblDateHeader
            // 
            this.lblDateHeader.AutoSize = true;
            this.lblDateHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDateHeader.ForeColor = System.Drawing.Color.Indigo;
            this.lblDateHeader.Location = new System.Drawing.Point(101, 307);
            this.lblDateHeader.Name = "lblDateHeader";
            this.lblDateHeader.Size = new System.Drawing.Size(196, 25);
            this.lblDateHeader.TabIndex = 11;
            this.lblDateHeader.Text = "Announcement Date";
            // 
            // cmbSociety
            // 
            this.cmbSociety.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSociety.Items.AddRange(new object[] {
            "Computing Society",
            "Engineering Society",
            "Arts & Media Society"});
            this.cmbSociety.Location = new System.Drawing.Point(106, 245);
            this.cmbSociety.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSociety.Name = "cmbSociety";
            this.cmbSociety.Size = new System.Drawing.Size(658, 36);
            this.cmbSociety.TabIndex = 12;
            // 
            // lblSocietyHeader
            // 
            this.lblSocietyHeader.AutoSize = true;
            this.lblSocietyHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSocietyHeader.ForeColor = System.Drawing.Color.Indigo;
            this.lblSocietyHeader.Location = new System.Drawing.Point(101, 216);
            this.lblSocietyHeader.Name = "lblSocietyHeader";
            this.lblSocietyHeader.Size = new System.Drawing.Size(81, 25);
            this.lblSocietyHeader.TabIndex = 13;
            this.lblSocietyHeader.Text = "Society ";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(106, 151);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(658, 34);
            this.txtTitle.TabIndex = 14;
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.AutoSize = true;
            this.lblTitleHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleHeader.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitleHeader.Location = new System.Drawing.Point(101, 122);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(193, 25);
            this.lblTitleHeader.TabIndex = 29;
            this.lblTitleHeader.Text = "Announcement Title";
            // 
            // lblFormSubHeader
            // 
            this.lblFormSubHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFormSubHeader.ForeColor = System.Drawing.Color.Gray;
            this.lblFormSubHeader.Location = new System.Drawing.Point(101, 57);
            this.lblFormSubHeader.Name = "lblFormSubHeader";
            this.lblFormSubHeader.Size = new System.Drawing.Size(450, 25);
            this.lblFormSubHeader.TabIndex = 16;
            this.lblFormSubHeader.Text = "Enter details for announcement";
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(21)))), ((int)(((byte)(136)))));
            this.lblFormHeader.Location = new System.Drawing.Point(98, 19);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(338, 38);
            this.lblFormHeader.TabIndex = 17;
            this.lblFormHeader.Text = "Add Announcement";
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::DB_Final.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(1019, 928);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Size = new System.Drawing.Size(224, 60);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DeepPink;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.BorderThickness = 3;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::DB_Final.Properties.Resources.cross__5_;
            this.btnCancel.Location = new System.Drawing.Point(345, 928);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.Yellow;
            this.btnCancel.Size = new System.Drawing.Size(224, 60);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlAnnouncementHeader
            // 
            this.pnlAnnouncementHeader.BackColor = System.Drawing.Color.White;
            this.pnlAnnouncementHeader.Controls.Add(this.guna2Button2);
            this.pnlAnnouncementHeader.Controls.Add(this.label1);
            this.pnlAnnouncementHeader.Controls.Add(this.label4);
            this.pnlAnnouncementHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnnouncementHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAnnouncementHeader.Name = "pnlAnnouncementHeader";
            this.pnlAnnouncementHeader.Size = new System.Drawing.Size(1539, 178);
            this.pnlAnnouncementHeader.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(78, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Create a new announcement for your society members";
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
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1240, 56);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(224, 60);
            this.guna2Button2.TabIndex = 29;
            this.guna2Button2.Text = "Back";
            this.guna2Button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pnlAnnouncementHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlLeftForm);
            this.Name = "AddAnnouncement";
            this.Size = new System.Drawing.Size(1539, 1041);
            this.pnlLeftForm.ResumeLayout(false);
            this.pnlLeftForm.PerformLayout();
            this.pnlAnnouncementHeader.ResumeLayout(false);
            this.pnlAnnouncementHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftForm;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPostedAt;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label lblDescHeader;
        private System.Windows.Forms.Label lblDateHeader;
        private System.Windows.Forms.ComboBox cmbSociety;
        private System.Windows.Forms.Label lblSocietyHeader;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitleHeader;
        private System.Windows.Forms.Label lblFormHeader;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblFormSubHeader;
        private System.Windows.Forms.Panel pnlAnnouncementHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
