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
    public partial class SponsorsForm : UserControl
    {
        private Sponsor selectedSponsor;

        public SponsorsForm()
        {
            InitializeComponent();
            dgvSponsor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadSponsors();
        }

        private void LoadSponsors()
        {
            dgvSponsor.Rows.Clear();

            SponsorDL dl = new SponsorDL();
            List<Sponsor> sponsors = dl.GetAll();

            UpdateStats(sponsors.Count);

            foreach (Sponsor s in sponsors)
            {
                int rowIndex = dgvSponsor.Rows.Add(
                    s.Name,
                    s.Organization,
                    s.Email,
                    s.Phone
                );

                dgvSponsor.Rows[rowIndex].Tag = s;
            }
        }
        private void UpdateStats(int count)
        {
            lblTotalSponsors.Text = count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new AddSponsor());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedSponsor == null)
            {
                MessageBox.Show("Select a sponsor first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to edit " + selectedSponsor.Name + "?",
                "Confirm Edit",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No)
                return;

            AddSponsor addForm = new AddSponsor();
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(addForm);
            addForm.LoadSponsorData(selectedSponsor);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSponsor == null)
            {
                MessageBox.Show("Select a sponsor first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this sponsor?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvSponsor.SelectedRows[0].Cells[0].Value);

                SponsorDL dl = new SponsorDL();
                dl.Delete(id);

                MessageBox.Show("Sponsor deleted successfully.");
                LoadSponsors();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchSponsors(txtSearch.Text);
        }

        private void SearchSponsors(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadSponsors();
                return;
            }

            dgvSponsor.Rows.Clear();

            SponsorDL dl = new SponsorDL();
            List<Sponsor> sponsors = dl.GetAll();

            keyword = keyword.ToLower();

            foreach (Sponsor s in sponsors)
            {
                if (s.Name.ToLower().Contains(keyword) ||
                    s.Organization.ToLower().Contains(keyword) ||
                    s.Email.ToLower().Contains(keyword))
                {
                    int rowIndex = dgvSponsor.Rows.Add(
                    s.Name,
                    s.Organization,
                    s.Email,
                    s.Phone
                        );
                    dgvSponsor.Rows[rowIndex].Tag = s;
                }
            }
        }

        private void dgvSponsors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedSponsor =
                (Sponsor)dgvSponsor.Rows[e.RowIndex].Tag;

            lblSelectedName.Text = selectedSponsor.Name;
            lblSelectedOrg.Text = selectedSponsor.Organization;
            lblSelectedEmail.Text = selectedSponsor.Email;
            lblSelectedPhone.Text = selectedSponsor.Phone;
        }
    }
}
