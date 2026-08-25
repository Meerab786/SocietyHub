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
    public partial class AddAnnouncement : UserControl
    {
        public Announcement CurrentAnnouncement = null;
        private Announcement currentAnnouncement = null;

        public AddAnnouncement()
        {
            InitializeComponent();
            LoadSocieties();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Please enter announcement title.");
                    return;
                }

                if (cmbSociety.SelectedItem == null)
                {
                    MessageBox.Show("Please select a society.");
                    return;
                }

                Society society = (Society)cmbSociety.SelectedItem;

                AnnouncementDL dl = new AnnouncementDL();
                if (currentAnnouncement == null)
                {
                    Announcement a = new Announcement(
                        txtTitle.Text.Trim(),
                        rtbMessage.Text.Trim(),
                        dtpPostedAt.Value,
                        society
                    );

                    dl.Insert(a);

                    MessageBox.Show("Announcement added successfully!");
                }
                else
                {
                    Announcement a = new Announcement(
                        currentAnnouncement.Id,
                        txtTitle.Text.Trim(),
                        rtbMessage.Text.Trim(),
                        dtpPostedAt.Value,
                        society
                    );

                    dl.Update(a);

                    MessageBox.Show("Announcement updated successfully!");

                    currentAnnouncement = null;
                }

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadSocieties()
        {
            SocietyDL dl = new SocietyDL();

            cmbSociety.DataSource =
                dl.GetAll();

            cmbSociety.DisplayMember = "Name";
        }
        private void ClearForm()
        {
            txtTitle.Clear();

            rtbMessage.Clear();

            cmbSociety.SelectedIndex = -1;

            dtpPostedAt.Value = DateTime.Now;
        }
        public void LoadAnnouncementForEdit(Announcement a)
        {
            currentAnnouncement = a;

            txtTitle.Text = a.Title;
            rtbMessage.Text = a.Message;
            dtpPostedAt.Value = a.PostedAt;

            if (a.Society != null)
                cmbSociety.Text = a.Society.Name;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            rtbMessage.Clear();
            cmbSociety.SelectedIndex = -1;
            dtpPostedAt.Value = DateTime.Now;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new AnnouncementsForm());
        }
    }
}
