using DB_Final.BL;
using DB_Final.DL;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Final
{
    public partial class AddVenue : UserControl
    {
        public bool IsEditMode = false;
        public Venue SelectedVenue = null;

        public AddVenue()
        {
            InitializeComponent();
        }
        private bool isLoaded = false;
        private void AddVenue_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Reserved");

            cmbStatus.SelectedIndex = 0;

            if (IsEditMode && SelectedVenue != null)
            {
                txtVenueName.Text = SelectedVenue.Name;
                txtLocation.Text = SelectedVenue.Location;
                numCapacity.Value = SelectedVenue.Capacity;
                txtFacilities.Text = SelectedVenue.Facilities;

                if (SelectedVenue.Status != null)
                {
                    cmbStatus.SelectedItem = SelectedVenue.Status;
                }
            }

            isLoaded = true;
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            lblPreviewName.Text = "Venue Name: " + txtVenueName.Text;
            lblPreviewLocation.Text = "Location: " + txtLocation.Text;
            lblPreviewCapacity.Text = "Capacity: " + numCapacity.Value;
            lblPreviewFacilities.Text = "Facilities: " + txtFacilities.Text;

            if (cmbStatus.SelectedItem == null)
            {
                return;
            }

            string status = cmbStatus.SelectedItem.ToString();

            lblPreviewStatus.Text = "Status: " + status;

            if (status == "Available")
            {
                lblPreviewStatus.ForeColor = Color.Green;
            }
            else if (status == "Reserved")
            {
                lblPreviewStatus.ForeColor = Color.Red;
            }
        }

        private void txtVenueName_TextChanged(object sender, EventArgs e)
        {
            lblPreviewName.Text = "Venue Name: " + txtVenueName.Text;
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            lblPreviewLocation.Text = "Location: " + txtLocation.Text;
        }

        private void txtFacilities_TextChanged(object sender, EventArgs e)
        {
            lblPreviewFacilities.Text = "Facilities: " + txtFacilities.Text;
        }

        private void numCapacity_ValueChanged(object sender, EventArgs e)
        {
            lblPreviewCapacity.Text = "Capacity: " + numCapacity.Value;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
                return;

            UpdatePreview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VenueDL dl = new VenueDL();

            try
            {
                if (IsEditMode && SelectedVenue != null)
                {
                    SelectedVenue.Name = txtVenueName.Text;
                    SelectedVenue.Location = txtLocation.Text;
                    SelectedVenue.Capacity = (int)numCapacity.Value;
                    SelectedVenue.Facilities = txtFacilities.Text;

                    dl.Update(SelectedVenue);

                    MessageBox.Show("Venue Updated Successfully!");
                }
                else
                {
                    Venue v = new Venue(
                        txtVenueName.Text,
                        txtLocation.Text,
                        (int)numCapacity.Value,
                        txtFacilities.Text
                    );

                    dl.Insert(v);

                    MessageBox.Show("Venue Added Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtVenueName.Clear();
            txtLocation.Clear();
            numCapacity.Value = 0;
            txtFacilities.Clear();
            cmbStatus.SelectedIndex = 0;

            UpdatePreview();
        }

        public void LoadForEdit(Venue v)
        {
            IsEditMode = true;
            SelectedVenue = v;

            txtVenueName.Text = v.Name;
            txtLocation.Text = v.Location;
            numCapacity.Value = v.Capacity;
            txtFacilities.Text = v.Facilities;

            cmbStatus.SelectedItem = v.Status ?? "Available";

            UpdatePreview();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new VenueForm());
        }
    }
}
