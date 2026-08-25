using DB_Final.BL;
using DB_Final.DL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DB_Final
{
    public partial class VenueForm : UserControl
    {
        private Venue selectedVenue;

        VenueDL dl = new VenueDL();
        public VenueForm()
        {
            InitializeComponent();
            LoadVenues();
            List<Venue> venues = dl.GetAll();

            if (venues.Count > 0)
            {
                ShowVenueDetails(venues[0]);
            }
        }
        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new AddVenue());
        }

        private void ShowVenueDetails(Venue v)
        {
            selectedVenue = v;

            pnlVenueDetails.Visible = true;

            lblVenueName.Text = "Venue Name: " + v.Name;
            lblVenueLocation.Text = "Location: " + v.Location;
            lblVenueCapacity.Text = "Capacity: " + v.Capacity;
            lblVenueFacilities.Text = "Facilities: " + v.Facilities;

            string status = v.Status;

            if (string.IsNullOrEmpty(status))
                status = "Available";

            lblVenueStatus.Text = "Status: " + status;

            if (status == "Reserved")
                lblVenueStatus.ForeColor = Color.Red;
            else
                lblVenueStatus.ForeColor = Color.Green;
        }

        private void card_MouseEnter(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ShadowPanel card =
                (Guna.UI2.WinForms.Guna2ShadowPanel)sender;

            card.FillColor = Color.FromArgb(230, 225, 255);
        }

        private void card_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ShadowPanel card =
                (Guna.UI2.WinForms.Guna2ShadowPanel)sender;

            card.FillColor = Color.FromArgb(245, 243, 255);
        }

        private void LoadVenues()
        {
            flpVenues.Controls.Clear();

            VenueDL dl = new VenueDL();
            List<Venue> venues = dl.GetAll();

            foreach (Venue v in venues)
            {
                flpVenues.Controls.Add(CreateVenueCard(v));
            }
        }

        private Guna.UI2.WinForms.Guna2ShadowPanel CreateVenueCard(Venue v)
        {
            Guna2ShadowPanel card = new Guna2ShadowPanel();

            card.Size = new Size(270, 160);
            card.ForeColor = Color.Black;
            card.Radius = 10;
            card.ShadowDepth = 50;
            card.FillColor = Color.FromArgb(245, 243, 255);
            card.Margin = new Padding(10);

            Label lblName = new Label();
            lblName.Text = v.Name;
            lblName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblName.Location = new Point(20, 20);
            lblName.AutoSize = true;

            Label lblLocation = new Label();
            lblLocation.Text = "📍 " + v.Location;
            lblLocation.Font = new Font("Segoe UI", 10);
            lblLocation.Location = new Point(20, 65);
            lblLocation.AutoSize = true;

            Label lblCapacity = new Label();
            lblCapacity.Text = "👥 Capacity: " + v.Capacity;
            lblCapacity.Font = new Font("Segoe UI", 10);
            lblCapacity.Location = new Point(20, 95);
            lblCapacity.AutoSize = true;

            Label lblStatus = new Label();

            string status = v.Status;
            if (string.IsNullOrEmpty(status))
                status = "Available";

            lblStatus.Text = "Status: " + status;

            if (status == "Reserved")
                lblStatus.ForeColor = Color.Red;
            else
                lblStatus.ForeColor = Color.Green;

            lblStatus.Location = new Point(15, 100);
            lblStatus.AutoSize = true;


            Guna2Button btnView = new Guna2Button();

            btnView.Text = "View Details";
            btnView.Size = new Size(105, 28);
            btnView.Location = new Point(135, 115);
            btnView.FillColor = Color.Indigo;
            btnView.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnView.BorderRadius = 4;

            btnView.Click += (s, e) =>
            {
                pnlVenueDetails.Visible = true;
                ShowVenueDetails(v);
            };

            card.MouseEnter += card_MouseEnter;
            card.MouseLeave += card_MouseLeave;

            card.Controls.Add(lblName);
            card.Controls.Add(lblLocation);
            card.Controls.Add(lblCapacity);
            card.Controls.Add(btnView);
           
            return card;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Venue v = (Venue)btn.Tag;

            pnlVenueDetails.Visible = true;

            lblVenueName.Text = "Venue Name: " + v.Name;
            lblVenueLocation.Text = "Location: " + v.Location;
            lblVenueCapacity.Text = "Capacity: " + v.Capacity;
            lblVenueFacilities.Text = "Facilities: " + v.Facilities;

            string status = v.Status;
            if (string.IsNullOrEmpty(status))
                status = "Available";

            lblVenueStatus.Text = "Status: " + status;

            if (status == "Reserved")
                lblVenueStatus.ForeColor = Color.Red;
            else
                lblVenueStatus.ForeColor = Color.Green;
        }

        private void txtSearchVenue_TextChanged(object sender, EventArgs e)
        {
            SearchVenues(txtSearchVenue.Text);
        }

        private void SearchVenues(string keyword)
        {
            flpVenues.Controls.Clear();

            VenueDL dl = new VenueDL();
            List<Venue> venues = dl.GetAll();

            keyword = keyword.ToLower();

            List<Venue> filtered = new List<Venue>();

            foreach (Venue v in venues)
            {
                if (v.Name.ToLower().Contains(keyword) ||
                    v.Location.ToLower().Contains(keyword))
                {
                    filtered.Add(v);
                }
            }

            foreach (Venue v in filtered)
            {
                flpVenues.Controls.Add(CreateVenueCard(v));
            }
            if (filtered.Count > 0)
            {
                ShowVenueDetails(filtered[0]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedVenue == null)
            {
                MessageBox.Show("Select a venue first.");
                return;
            }

            DialogResult result = MessageBox.Show( "Are you sure you want to delete this venue?","Confirm Delete",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                VenueDL dl = new VenueDL();

                dl.Delete(selectedVenue.Id);
                MessageBox.Show("Venue deleted successfully.");

                LoadVenues();

                pnlVenueDetails.Visible = false;
                selectedVenue = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedVenue == null)
            {
                MessageBox.Show("Select a venue first.");
                return;
            }

            AddVenue addVenue = new AddVenue();

            Form1 main = (Form1)this.FindForm();
            main.LoadPage(addVenue);

            // 🔥 IMPORTANT: force data AFTER load
            addVenue.LoadForEdit(selectedVenue);
        }
    }
}
   
