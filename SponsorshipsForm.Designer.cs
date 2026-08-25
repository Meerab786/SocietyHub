namespace DB_Final
{
    partial class SponsorshipsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddVenue = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlDetails = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblSponsorValue = new System.Windows.Forms.Label();
            this.lblEventValue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblSponsor = new System.Windows.Forms.Label();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.flpSponsorships = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSubHeading);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnAddVenue);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 181);
            this.panel1.TabIndex = 3;
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.lblSubHeading.ForeColor = System.Drawing.Color.Black;
            this.lblSubHeading.Location = new System.Drawing.Point(59, 80);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(306, 21);
            this.lblSubHeading.TabIndex = 1;
            this.lblSubHeading.Text = "Manage sponsor contributions to events";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(58, 130);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(200, 25);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search Sponsorships:";
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
            this.txtSearch.Location = new System.Drawing.Point(265, 122);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search Sponsorships...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(513, 33);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Tag = "Enter Sponsorships...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddVenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddVenue.FillColor = System.Drawing.Color.Indigo;
            this.btnAddVenue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVenue.ForeColor = System.Drawing.Color.White;
            this.btnAddVenue.Location = new System.Drawing.Point(1153, 56);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnAddVenue.Size = new System.Drawing.Size(291, 60);
            this.btnAddVenue.TabIndex = 22;
            this.btnAddVenue.Text = "+ Add Sponsorship";
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddSponsorship_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Indigo;
            this.lblHeading.Location = new System.Drawing.Point(55, 32);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(289, 48);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "SPONSORSHIPS";
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblSponsorValue);
            this.pnlDetails.Controls.Add(this.lblEventValue);
            this.pnlDetails.Controls.Add(this.lblAmount);
            this.pnlDetails.Controls.Add(this.lblAmountValue);
            this.pnlDetails.Controls.Add(this.lblDate);
            this.pnlDetails.Controls.Add(this.lblEvent);
            this.pnlDetails.Controls.Add(this.lblDateValue);
            this.pnlDetails.Controls.Add(this.lblSponsor);
            this.pnlDetails.Controls.Add(this.lblSelectedTitle);
            this.pnlDetails.Controls.Add(this.pictureBox1);
            this.pnlDetails.Controls.Add(this.guna2Button6);
            this.pnlDetails.Controls.Add(this.btnEdit);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetails.Location = new System.Drawing.Point(0, 731);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1494, 246);
            this.pnlDetails.TabIndex = 4;
            // 
            // lblSponsorValue
            // 
            this.lblSponsorValue.AutoSize = true;
            this.lblSponsorValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSponsorValue.ForeColor = System.Drawing.Color.Black;
            this.lblSponsorValue.Location = new System.Drawing.Point(169, 87);
            this.lblSponsorValue.Name = "lblSponsorValue";
            this.lblSponsorValue.Size = new System.Drawing.Size(19, 25);
            this.lblSponsorValue.TabIndex = 45;
            this.lblSponsorValue.Text = "-";
            // 
            // lblEventValue
            // 
            this.lblEventValue.AutoSize = true;
            this.lblEventValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventValue.ForeColor = System.Drawing.Color.Black;
            this.lblEventValue.Location = new System.Drawing.Point(150, 141);
            this.lblEventValue.Name = "lblEventValue";
            this.lblEventValue.Size = new System.Drawing.Size(19, 25);
            this.lblEventValue.TabIndex = 44;
            this.lblEventValue.Text = "-";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAmount.Location = new System.Drawing.Point(519, 90);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(88, 28);
            this.lblAmount.TabIndex = 43;
            this.lblAmount.Text = "Amount";
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountValue.ForeColor = System.Drawing.Color.Black;
            this.lblAmountValue.Location = new System.Drawing.Point(636, 90);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(19, 25);
            this.lblAmountValue.TabIndex = 42;
            this.lblAmountValue.Text = "-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDate.Location = new System.Drawing.Point(58, 187);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(144, 28);
            this.lblDate.TabIndex = 41;
            this.lblDate.Text = "Sponsored On";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEvent.Location = new System.Drawing.Point(58, 138);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(65, 28);
            this.lblEvent.TabIndex = 40;
            this.lblEvent.Text = "Event";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblDateValue.Location = new System.Drawing.Point(239, 190);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(19, 25);
            this.lblDateValue.TabIndex = 38;
            this.lblDateValue.Text = "-";
            // 
            // lblSponsor
            // 
            this.lblSponsor.AutoSize = true;
            this.lblSponsor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSponsor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSponsor.Location = new System.Drawing.Point(58, 87);
            this.lblSponsor.Name = "lblSponsor";
            this.lblSponsor.Size = new System.Drawing.Size(88, 28);
            this.lblSponsor.TabIndex = 37;
            this.lblSponsor.Text = "Sponsor";
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblSelectedTitle.Location = new System.Drawing.Point(111, 23);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(342, 32);
            this.lblSelectedTitle.TabIndex = 1;
            this.lblSelectedTitle.Text = "Selected Sponsorship Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Final.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(65, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.guna2Button6.Location = new System.Drawing.Point(1222, 75);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button6.Size = new System.Drawing.Size(222, 60);
            this.guna2Button6.TabIndex = 36;
            this.guna2Button6.Text = "Delete";
            this.guna2Button6.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(931, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnEdit.Size = new System.Drawing.Size(222, 60);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // flpSponsorships
            // 
            this.flpSponsorships.AutoScroll = true;
            this.flpSponsorships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSponsorships.Location = new System.Drawing.Point(0, 181);
            this.flpSponsorships.Name = "flpSponsorships";
            this.flpSponsorships.Size = new System.Drawing.Size(1494, 550);
            this.flpSponsorships.TabIndex = 5;
            // 
            // SponsorshipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.flpSponsorships);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.panel1);
            this.Name = "SponsorshipsForm";
            this.Size = new System.Drawing.Size(1494, 977);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblSubHeading;
        private Guna.UI2.WinForms.Guna2Button btnAddVenue;
        private System.Windows.Forms.Label lblHeading;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlDetails;
        private System.Windows.Forms.Label lblSponsorValue;
        private System.Windows.Forms.Label lblEventValue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblSponsor;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.FlowLayoutPanel flpSponsorships;
    }
}
