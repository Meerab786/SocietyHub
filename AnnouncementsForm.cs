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
    public partial class AnnouncementsForm : UserControl
    {
        List<Announcement> allAnnouncements = new List<Announcement>();
        public AnnouncementsForm()
        {
            InitializeComponent();
            LoadSocieties();
            LoadAnnouncements();
            colTitle.FillWeight = 25;
            colSociety.FillWeight = 20;
            colPostedAt.FillWeight = 20;
            colMessage.FillWeight = 35;

            colView.FillWeight = 6;
            colActions.FillWeight = 6;
            colDelete.FillWeight = 6;
            pnlViewDetails.Height = 0;
            pnlViewDetails.Visible = true;
        }
        private void LoadAnnouncements()
        {
            AnnouncementDL dl = new AnnouncementDL();
            allAnnouncements = dl.GetAll();

            ApplyFilters();

            dgvAnnouncements.Rows.Clear();
           
            AnnouncementDL adl = new AnnouncementDL();
            List<Announcement> announcements = adl.GetAll();

            foreach (Announcement a in announcements)
            {
                int rowIndex = dgvAnnouncements.Rows.Add(
                    a.Title,
                    a.Society != null ? a.Society.Name : "N/A",
                    a.PostedAt.ToString("dd MMM yyyy hh:mm tt"),
                    a.Message,
                    Properties.Resources.edit__3_,
                    Properties.Resources.bin_1_bold__1_,
                    Properties.Resources.view__1_
                );

                dgvAnnouncements.Rows[rowIndex].Tag = a;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();

            main.LoadPage(new AddAnnouncement());
        }
        private void dgvAnnouncements_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAnnouncements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Announcement announcement = (Announcement)dgvAnnouncements.Rows[e.RowIndex].Tag;
            if (announcement == null)
                return;
            if (dgvAnnouncements.Columns[e.ColumnIndex].Name == "colDelete")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this announcement?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AnnouncementDL adl = new AnnouncementDL();
                        adl.Delete(announcement.Id);

                        MessageBox.Show(
                            "Announcement deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadAnnouncements();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            else if (dgvAnnouncements.Columns[e.ColumnIndex].Name == "colActions")
            {
                AddAnnouncement add = new AddAnnouncement();

                Form1 main = (Form1)this.FindForm();
                main.LoadPage(add);

                add.LoadAnnouncementForEdit(announcement);
            }

            if (e.RowIndex < 0) return;

            if (dgvAnnouncements.Columns[e.ColumnIndex].Name == "colView")
            {
                Announcement a = (Announcement)dgvAnnouncements.Rows[e.RowIndex].Tag;

                ShowPreviewPanel(a);
            }
        }

        private void ShowPreviewPanel(Announcement a)
        {
            lblTitle.Text = "Title: " + a.Title;
            lblMessage.Text = "Message: " + a.Message;
            lblSociety.Text = "Society: " + (a.Society?.Name ?? "N/A");
            lblDate.Text = "Posted: " + a.PostedAt.ToString("dd MMM yyyy hh:mm tt");
            pnlViewDetails.Height = 120;
        }

        private void ApplyFilters()
        {
            IEnumerable<Announcement> filtered = allAnnouncements;

            if (!string.IsNullOrWhiteSpace(txtSearchAnnouncement.Text))
            {
                filtered = filtered.Where(a =>
                    a.Title.ToLower().Contains(txtSearchAnnouncement.Text.ToLower()) ||
                    (a.Message != null && a.Message.ToLower().Contains(txtSearchAnnouncement.Text.ToLower()))
                );
            }
            if (cmbFilterSociety.SelectedIndex != -1 && cmbFilterSociety.SelectedItem is Society selectedSociety)
            {
                filtered = filtered.Where(a =>
                    a.Society != null &&
                    a.Society.Id == selectedSociety.Id
                );
            }
            dgvAnnouncements.Rows.Clear();

            foreach (var a in filtered)
            {
                int rowIndex = dgvAnnouncements.Rows.Add(
                    a.Title,
                    a.Society != null ? a.Society.Name : "N/A",
                    a.PostedAt.ToString("dd MMM yyyy hh:mm tt"),
                    a.Message,
                    Properties.Resources.edit__3_,
                    Properties.Resources.bin_1_bold__1_,
                    Properties.Resources.view__1_

                );

                dgvAnnouncements.Rows[rowIndex].Tag = a;
            }

            lblShowingEntries.Text = $"Showing {filtered.Count()} announcement(s)";
        }

        private void cmbFilterSociety_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchAnnouncement.Clear();
            cmbFilterSociety.SelectedIndex = -1;

            LoadAnnouncements(); 
        }
        private void LoadSocieties()
        {
            SocietyDL sdl = new SocietyDL();
            List<Society> societyList = sdl.GetAll();

            cmbFilterSociety.DataSource = societyList;
            cmbFilterSociety.DisplayMember = "Name";
            cmbFilterSociety.ValueMember = "Id";
            cmbFilterSociety.SelectedIndex = -1;
        }
    }
}
