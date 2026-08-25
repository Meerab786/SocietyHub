using DB_Final.BL;
using DB_Final.DL;
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
    public partial class AddSponsorship : UserControl
    {
        private Sponsorship editingSponsorship = null;
        public bool IsEditMode = false;
        public Sponsorship SelectedSponsorship = null;
        public AddSponsorship()
        {
            InitializeComponent();
            LoadSponsors();
            LoadEvents();

            UpdatePreview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSponsor.SelectedItem == null)
                {
                    MessageBox.Show("Please select a sponsor.");
                    return;
                }

                if (cmbEvent.SelectedItem == null)
                {
                    MessageBox.Show("Please select an event.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAmount.Text))
                {
                    MessageBox.Show("Please enter amount.");
                    return;
                }

                decimal amount;
                if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
                {
                    MessageBox.Show("Enter a valid amount.");
                    return;
                }

                Sponsor sponsor = (Sponsor)cmbSponsor.SelectedItem;
                Event ev = (Event)cmbEvent.SelectedItem;

                SponsorshipDL dl = new SponsorshipDL();

                if (editingSponsorship == null)
                {
                    Sponsorship s = new Sponsorship(
                        amount,
                        dtpDate.Value,
                        sponsor,
                        ev
                    );

                    dl.Insert(s);

                    MessageBox.Show("Sponsorship added successfully!");
                }

                else
                {
                    Sponsorship s = new Sponsorship(
                        editingSponsorship.Id,
                        amount,
                        dtpDate.Value,
                        sponsor,
                        ev
                    );

                    dl.Update(s);

                    MessageBox.Show("Sponsorship updated successfully!");

                    editingSponsorship = null;
                }

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSponsorshipData(Sponsorship s)
        {
            if (s == null) return;

            editingSponsorship = s;

            cmbSponsor.SelectedItem = s.Sponsor;
            cmbEvent.SelectedItem = s.Event;
            txtAmount.Text = s.Amount.ToString();
            dtpDate.Value = s.SponsorshipDate;

            UpdatePreview();
        }

        private void UpdatePreview()
        {
            lblPreviewSponsor.Text =
                cmbSponsor.SelectedItem != null
                ? ((Sponsor)cmbSponsor.SelectedItem).Name
                : "-";

            lblPreviewEvent.Text =
                cmbEvent.SelectedItem != null
                ? ((Event)cmbEvent.SelectedItem).Title
                : "-";

            lblPreviewAmount.Text =
                string.IsNullOrWhiteSpace(txtAmount.Text)
                ? "-"
                : "Rs. " + txtAmount.Text;

            lblPreviewDate.Text = dtpDate.Value.ToString("dd MMM yyyy");
        }

        private void cmbSponsor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }
        private void ClearForm()
        {
            cmbSponsor.SelectedIndex = -1;
            cmbEvent.SelectedIndex = -1;
            txtAmount.Clear();
            dtpDate.Value = DateTime.Now;

            editingSponsorship = null;
            UpdatePreview();
        }
        private void LoadSponsors()
        {
            SponsorDL dl = new SponsorDL();
            List<Sponsor> list = dl.GetAll();

            cmbSponsor.DataSource = null;
            cmbSponsor.DataSource = list;

            cmbSponsor.DisplayMember = "Name";   
            cmbSponsor.ValueMember = "Id";      
        }

        private void LoadEvents()
        {
            EventDL dl = new EventDL();
            List<Event> list = dl.GetAll();

            cmbEvent.DataSource = null;
            cmbEvent.DataSource = list;

            cmbEvent.DisplayMember = "Title";
            cmbEvent.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset the form?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                cmbSponsor.SelectedIndex = -1;
                cmbEvent.SelectedIndex = -1;
                txtAmount.Clear();
                dtpDate.Value = DateTime.Now;

                editingSponsorship = null;

                lblPreviewSponsor.Text = "-";
                lblPreviewEvent.Text = "-";
                lblPreviewAmount.Text = "-";
                lblPreviewDate.Text = "-";
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new SponsorshipsForm());
        }
    }
}
