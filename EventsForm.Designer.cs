namespace DB_Final
{
    partial class EventsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTotalEvents = new System.Windows.Forms.Panel();
            this.lblTotalEvents = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUpcoming = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.flpEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEvents.SuspendLayout();
            this.pnlTotalEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUpcoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEvents
            // 
            this.pnlEvents.Controls.Add(this.label2);
            this.pnlEvents.Controls.Add(this.txtSearch);
            this.pnlEvents.Controls.Add(this.label5);
            this.pnlEvents.Controls.Add(this.label4);
            this.pnlEvents.Controls.Add(this.guna2Button1);
            this.pnlEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEvents.Location = new System.Drawing.Point(0, 0);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(1522, 148);
            this.pnlEvents.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(672, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Search Events:";
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
            this.txtSearch.Location = new System.Drawing.Point(677, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search Events";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(533, 33);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.Tag = "Enter Venue Name ";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Manage all events organized by societies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(55, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "EVENTS";
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
            this.guna2Button1.Location = new System.Drawing.Point(1240, 49);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button1.Size = new System.Drawing.Size(224, 60);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "+ Add Event";
            this.guna2Button1.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // pnlTotalEvents
            // 
            this.pnlTotalEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalEvents.Controls.Add(this.lblTotalEvents);
            this.pnlTotalEvents.Controls.Add(this.pictureBox1);
            this.pnlTotalEvents.Controls.Add(this.label10);
            this.pnlTotalEvents.Controls.Add(this.label9);
            this.pnlTotalEvents.Controls.Add(this.label1);
            this.pnlTotalEvents.Location = new System.Drawing.Point(63, 158);
            this.pnlTotalEvents.Name = "pnlTotalEvents";
            this.pnlTotalEvents.Size = new System.Drawing.Size(286, 132);
            this.pnlTotalEvents.TabIndex = 33;
            // 
            // lblTotalEvents
            // 
            this.lblTotalEvents.AutoSize = true;
            this.lblTotalEvents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEvents.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalEvents.Location = new System.Drawing.Point(95, 22);
            this.lblTotalEvents.Name = "lblTotalEvents";
            this.lblTotalEvents.Size = new System.Drawing.Size(103, 45);
            this.lblTotalEvents.TabIndex = 39;
            this.lblTotalEvents.Text = "Total ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Final.Properties.Resources.totalplay__1_;
            this.pictureBox1.Location = new System.Drawing.Point(5, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 45);
            this.label10.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(99, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "All time events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(98, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Total Events";
            // 
            // pnlUpcoming
            // 
            this.pnlUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcoming.Controls.Add(this.pictureBox2);
            this.pnlUpcoming.Controls.Add(this.lblUpcomingEvents);
            this.pnlUpcoming.Controls.Add(this.label12);
            this.pnlUpcoming.Controls.Add(this.label11);
            this.pnlUpcoming.Location = new System.Drawing.Point(378, 158);
            this.pnlUpcoming.Name = "pnlUpcoming";
            this.pnlUpcoming.Size = new System.Drawing.Size(286, 132);
            this.pnlUpcoming.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DB_Final.Properties.Resources.clock__2_;
            this.pictureBox2.Location = new System.Drawing.Point(7, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingEvents.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUpcomingEvents.Location = new System.Drawing.Point(85, 22);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(103, 45);
            this.lblUpcomingEvents.TabIndex = 40;
            this.lblUpcomingEvents.Text = "Total ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(86, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "In next 30 days";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(85, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 28);
            this.label11.TabIndex = 37;
            this.label11.Text = "Upcoming Events";
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderRadius = 10;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Location = new System.Drawing.Point(63, 315);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.PressedColor = System.Drawing.Color.Indigo;
            this.guna2Button9.Size = new System.Drawing.Size(194, 40);
            this.guna2Button9.TabIndex = 40;
            this.guna2Button9.Text = "All";
            this.guna2Button9.Click += new System.EventHandler(this.btnAllEvents_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderRadius = 10;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Indigo;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Location = new System.Drawing.Point(297, 315);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.PressedColor = System.Drawing.Color.MediumPurple;
            this.guna2Button8.Size = new System.Drawing.Size(194, 40);
            this.guna2Button8.TabIndex = 44;
            this.guna2Button8.Text = "Upcoming";
            this.guna2Button8.Click += new System.EventHandler(this.btnUpcoming_Click);
            // 
            // flpEvents
            // 
            this.flpEvents.AutoScroll = true;
            this.flpEvents.Location = new System.Drawing.Point(47, 361);
            this.flpEvents.Name = "flpEvents";
            this.flpEvents.Size = new System.Drawing.Size(1419, 586);
            this.flpEvents.TabIndex = 46;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(41, 814);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(542, 315);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.Indigo;
            this.guna2Button3.Size = new System.Drawing.Size(194, 40);
            this.guna2Button3.TabIndex = 48;
            this.guna2Button3.Text = "Past Events";
            this.guna2Button3.Click += new System.EventHandler(this.btnPastEvents_Click);
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
            this.guna2Button6.Location = new System.Drawing.Point(988, 267);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.guna2Button6.Size = new System.Drawing.Size(222, 60);
            this.guna2Button6.TabIndex = 31;
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
            this.btnEdit.Location = new System.Drawing.Point(1242, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnEdit.Size = new System.Drawing.Size(222, 60);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.flpEvents);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button9);
            this.Controls.Add(this.pnlUpcoming);
            this.Controls.Add(this.pnlTotalEvents);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlEvents);
            this.Name = "EventsForm";
            this.Size = new System.Drawing.Size(1522, 962);
            this.pnlEvents.ResumeLayout(false);
            this.pnlEvents.PerformLayout();
            this.pnlTotalEvents.ResumeLayout(false);
            this.pnlTotalEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUpcoming.ResumeLayout(false);
            this.pnlUpcoming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Panel pnlTotalEvents;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlUpcoming;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private System.Windows.Forms.FlowLayoutPanel flpEvents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotalEvents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpcomingEvents;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
