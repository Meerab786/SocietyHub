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
    public partial class SponsorshipsForm : UserControl
    {
        public SponsorshipsForm()
        {
            InitializeComponent();
            flpSponsorships.WrapContents = true;
            flpSponsorships.FlowDirection = FlowDirection.LeftToRight;
            flpSponsorships.AutoScroll = true;
            flpSponsorships.Padding = new Padding(10);
            flpSponsorships.Margin = new Padding(5);
            LoadSponsorshipCards();
        }

        private Panel CreateCard(Sponsorship s)
        {
            Panel card = new Panel();

            card.Size = new Size(290, 155);
            card.Margin = new Padding(15, 15, 15, 15);

            card.BackColor = Color.FromArgb(245, 243, 255);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Cursor = Cursors.Hand;

            Label lblSponsor = new Label();
            lblSponsor.Text = s.Sponsor?.Name ?? "Unknown";
            lblSponsor.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSponsor.ForeColor = Color.Black;
            lblSponsor.Location = new Point(50, 18);
            lblSponsor.AutoSize = true;

            Label lblEvent = new Label();
            lblEvent.Text = "🎯 " + (s.Event?.Title ?? "No Event");
            lblEvent.Font = new Font("Segoe UI", 9);
            lblEvent.Location = new Point(15, 60);
            lblEvent.ForeColor = Color.Black;
            lblEvent.AutoSize = true;

            Label lblAmount = new Label();
            lblAmount.Text = "💰 Rs. " + s.Amount.ToString("N0");
            lblAmount.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblAmount.ForeColor = Color.SeaGreen;
            lblAmount.Location = new Point(15, 90);
            lblAmount.AutoSize = true;

            Label lblDate = new Label();
            lblDate.Text = "📅 " + s.SponsorshipDate.ToString("dd MMM yyyy");
            lblDate.Font = new Font("Segoe UI", 8);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(15, 120);
            lblDate.AutoSize = true;

            Guna.UI2.WinForms.Guna2Button btnView = new Guna.UI2.WinForms.Guna2Button();

            btnView.Text = "View";
            btnView.FillColor = Color.Indigo;
            btnView.ForeColor = Color.White;
            btnView.Size = new Size(80, 30);
            btnView.Location = new Point(200, 115);

            btnView.Click += (sender, e) =>
            {
                ShowDetails(s);
            };

            card.Click += (sender, e) => ShowDetails(s);

            foreach (Control c in new Control[] { lblSponsor, lblEvent, lblAmount, lblDate })
                c.Click += (s2, e2) => ShowDetails(s);

            card.Controls.Add(lblSponsor);
            card.Controls.Add(lblEvent);
            card.Controls.Add(lblAmount);
            card.Controls.Add(lblDate);
            card.Controls.Add(btnView);

            return card;
        }
        private void LoadSponsorshipCards()
        {
            flpSponsorships.Controls.Clear();

            SponsorshipDL dl = new SponsorshipDL();

            List<Sponsorship> sponsorships = dl.GetAll();

            foreach (Sponsorship s in sponsorships)
            {
                flpSponsorships.Controls.Add(CreateCard(s));
            }
        }

        private Sponsorship selectedSponsorship;

        private void ShowDetails(Sponsorship s)
        {
            selectedSponsorship = s;

            lblSponsorValue.Text = s.Sponsor.Name;
            lblEventValue.Text = s.Event.Title;
            lblAmountValue.Text = "Rs. " + s.Amount.ToString("N0");
            lblDateValue.Text = s.SponsorshipDate.ToString("dd MMM yyyy");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchSponsorships(txtSearch.Text.Trim());
        }
        private void SearchSponsorships(string keyword)
        {
            flpSponsorships.Controls.Clear();

            SponsorshipDL dl = new SponsorshipDL();
            List<Sponsorship> sponsorships = dl.GetAll();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                foreach (Sponsorship s in sponsorships)
                {
                    flpSponsorships.Controls.Add(CreateCard(s));
                }
                return;
            }

            keyword = keyword.ToLower();

            foreach (Sponsorship s in sponsorships)
            {
                bool match = false;

                if (s.Sponsor != null &&
                    s.Sponsor.Name.ToLower().Contains(keyword))
                {
                    match = true;
                }

                if (s.Event != null &&
                    s.Event.Title.ToLower().Contains(keyword))
                {
                    match = true;
                }
                if (s.Sponsor != null && s.Sponsor.Organization.ToLower().Contains(keyword))
                {
                    match = true;
                }

                if (s.Amount.ToString().Contains(keyword))
                {
                    match = true;
                }

                if (match)
                {
                    flpSponsorships.Controls.Add(CreateCard(s));
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSponsorship == null)
            {
                MessageBox.Show(
                    "Please select a sponsorship first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this sponsorship?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SponsorshipDL dl = new SponsorshipDL();

                    dl.Delete(selectedSponsorship.Id);

                    MessageBox.Show(
                        "Sponsorship deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    selectedSponsorship = null;

                    lblSponsorValue.Text = "-";
                    lblEventValue.Text = "-";
                    lblAmountValue.Text = "-";
                    lblDateValue.Text = "-";

                    LoadSponsorshipCards();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnAddSponsorship_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();

            AddSponsorship form = new AddSponsorship();

            main.LoadPage(form);
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;

            if (ctrl != null)
            {
                Panel card = ctrl as Panel;
                if (card == null)
                    card = ctrl.Parent as Panel;

                if (card != null && card.Tag is Sponsorship)
                {
                    selectedSponsorship = (Sponsorship)card.Tag;

                    ShowDetails(selectedSponsorship);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedSponsorship == null)
            {
                MessageBox.Show("Please select a sponsorship first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to edit this sponsorship?",
                "Confirm Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            AddSponsorship form = new AddSponsorship();

            form.IsEditMode = true;
            form.SelectedSponsorship = selectedSponsorship;

            form.LoadSponsorshipData(selectedSponsorship);

            Form1 main = (Form1)this.FindForm();
            main.LoadPage(form);
        }
    }
}
