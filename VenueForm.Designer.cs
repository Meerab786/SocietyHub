namespace DB_Final
{
    partial class VenueForm
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
            this.pnlEvents = new System.Windows.Forms.Panel();
            this.btnAddVenue = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchVenue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpVenues = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlVenueDetails = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.lblVenueStatus = new System.Windows.Forms.Label();
            this.lblVenueFacilities = new System.Windows.Forms.Label();
            this.lblVenueLocation = new System.Windows.Forms.Label();
            this.lblVenueCapacity = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.pnlEvents.SuspendLayout();
            this.pnlVenueDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEvents
            // 
            this.pnlEvents.Controls.Add(this.btnAddVenue);
            this.pnlEvents.Controls.Add(this.label1);
            this.pnlEvents.Controls.Add(this.txtSearchVenue);
            this.pnlEvents.Controls.Add(this.label5);
            this.pnlEvents.Controls.Add(this.label4);
            this.pnlEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEvents.Location = new System.Drawing.Point(0, 0);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(1560, 178);
            this.pnlEvents.TabIndex = 16;
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
            this.btnAddVenue.Location = new System.Drawing.Point(1221, 88);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnAddVenue.Size = new System.Drawing.Size(224, 60);
            this.btnAddVenue.TabIndex = 20;
            this.btnAddVenue.Text = "+ Add Venue";
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Venues:";
            // 
            // txtSearchVenue
            // 
            this.txtSearchVenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtSearchVenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVenue.ForeColor = System.Drawing.Color.Black;
            this.txtSearchVenue.Location = new System.Drawing.Point(210, 137);
            this.txtSearchVenue.Name = "txtSearchVenue";
            this.txtSearchVenue.Size = new System.Drawing.Size(483, 31);
            this.txtSearchVenue.TabIndex = 18;
            this.txtSearchVenue.TextChanged += new System.EventHandler(this.txtSearchVenue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Manage campus spaces, capacity and availability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(55, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "VENUES DIRECTORY";
            // 
            // flpVenues
            // 
            this.flpVenues.AutoScroll = true;
            this.flpVenues.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpVenues.Location = new System.Drawing.Point(1020, 178);
            this.flpVenues.Name = "flpVenues";
            this.flpVenues.Size = new System.Drawing.Size(540, 821);
            this.flpVenues.TabIndex = 17;
            // 
            // pnlVenueDetails
            // 
            this.pnlVenueDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlVenueDetails.Controls.Add(this.btnEdit);
            this.pnlVenueDetails.Controls.Add(this.guna2Button4);
            this.pnlVenueDetails.Controls.Add(this.guna2Button3);
            this.pnlVenueDetails.Controls.Add(this.lblVenueStatus);
            this.pnlVenueDetails.Controls.Add(this.lblVenueFacilities);
            this.pnlVenueDetails.Controls.Add(this.lblVenueLocation);
            this.pnlVenueDetails.Controls.Add(this.lblVenueCapacity);
            this.pnlVenueDetails.Controls.Add(this.lblVenueName);
            this.pnlVenueDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVenueDetails.FillColor = System.Drawing.Color.White;
            this.pnlVenueDetails.Location = new System.Drawing.Point(0, 178);
            this.pnlVenueDetails.Name = "pnlVenueDetails";
            this.pnlVenueDetails.ShadowColor = System.Drawing.Color.LightGray;
            this.pnlVenueDetails.Size = new System.Drawing.Size(997, 821);
            this.pnlVenueDetails.TabIndex = 18;
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
            this.btnEdit.Location = new System.Drawing.Point(48, 671);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnEdit.Size = new System.Drawing.Size(224, 60);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Crimson;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::DB_Final.Properties.Resources.delete__2_;
            this.guna2Button4.Location = new System.Drawing.Point(320, 671);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button4.Size = new System.Drawing.Size(224, 60);
            this.guna2Button4.TabIndex = 29;
            this.guna2Button4.Text = "Delete";
            this.guna2Button4.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Indigo;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::DB_Final.Properties.Resources.bookmark__1_;
            this.guna2Button3.Location = new System.Drawing.Point(591, 671);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button3.Size = new System.Drawing.Size(224, 60);
            this.guna2Button3.TabIndex = 28;
            this.guna2Button3.Text = "Book a Venue";
            // 
            // lblVenueStatus
            // 
            this.lblVenueStatus.AutoSize = true;
            this.lblVenueStatus.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueStatus.ForeColor = System.Drawing.Color.Indigo;
            this.lblVenueStatus.Location = new System.Drawing.Point(59, 433);
            this.lblVenueStatus.Name = "lblVenueStatus";
            this.lblVenueStatus.Size = new System.Drawing.Size(74, 25);
            this.lblVenueStatus.TabIndex = 26;
            this.lblVenueStatus.Text = "Status:";
            // 
            // lblVenueFacilities
            // 
            this.lblVenueFacilities.AutoSize = true;
            this.lblVenueFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueFacilities.ForeColor = System.Drawing.Color.Indigo;
            this.lblVenueFacilities.Location = new System.Drawing.Point(58, 360);
            this.lblVenueFacilities.Name = "lblVenueFacilities";
            this.lblVenueFacilities.Size = new System.Drawing.Size(83, 25);
            this.lblVenueFacilities.TabIndex = 24;
            this.lblVenueFacilities.Text = "Facility:";
            // 
            // lblVenueLocation
            // 
            this.lblVenueLocation.AutoSize = true;
            this.lblVenueLocation.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueLocation.ForeColor = System.Drawing.Color.Indigo;
            this.lblVenueLocation.Location = new System.Drawing.Point(59, 224);
            this.lblVenueLocation.Name = "lblVenueLocation";
            this.lblVenueLocation.Size = new System.Drawing.Size(94, 25);
            this.lblVenueLocation.TabIndex = 23;
            this.lblVenueLocation.Text = "Location:";
            // 
            // lblVenueCapacity
            // 
            this.lblVenueCapacity.AutoSize = true;
            this.lblVenueCapacity.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueCapacity.ForeColor = System.Drawing.Color.Indigo;
            this.lblVenueCapacity.Location = new System.Drawing.Point(58, 291);
            this.lblVenueCapacity.Name = "lblVenueCapacity";
            this.lblVenueCapacity.Size = new System.Drawing.Size(94, 25);
            this.lblVenueCapacity.TabIndex = 22;
            this.lblVenueCapacity.Text = "Capacity:";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueName.ForeColor = System.Drawing.Color.Indigo;
            this.lblVenueName.Location = new System.Drawing.Point(59, 156);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(130, 25);
            this.lblVenueName.TabIndex = 21;
            this.lblVenueName.Text = "Venue Name:";
            // 
            // VenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pnlVenueDetails);
            this.Controls.Add(this.flpVenues);
            this.Controls.Add(this.pnlEvents);
            this.Name = "VenueForm";
            this.Size = new System.Drawing.Size(1560, 999);
            this.pnlEvents.ResumeLayout(false);
            this.pnlEvents.PerformLayout();
            this.pnlVenueDetails.ResumeLayout(false);
            this.pnlVenueDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchVenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAddVenue;
        private System.Windows.Forms.FlowLayoutPanel flpVenues;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlVenueDetails;
        private System.Windows.Forms.Label lblVenueLocation;
        private System.Windows.Forms.Label lblVenueCapacity;
        private System.Windows.Forms.Label lblVenueName;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label lblVenueStatus;
        private System.Windows.Forms.Label lblVenueFacilities;
    }
}
