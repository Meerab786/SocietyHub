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
    public partial class AddSponsor : UserControl
    {
        public bool IsEditMode = false;
        public Sponsor SelectedSponsor = null;

        public AddSponsor()
        {
            InitializeComponent();
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtOrganization.TextChanged += new System.EventHandler(this.txtOrganization_TextChanged);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            UpdatePreview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SponsorDL dl = new SponsorDL();

                if (IsEditMode && SelectedSponsor != null)
                {
                    SelectedSponsor.Name = txtName.Text;
                    SelectedSponsor.Organization = txtOrganization.Text;
                    SelectedSponsor.Email = txtEmail.Text;
                    SelectedSponsor.Phone = txtPhone.Text;

                    dl.Update(SelectedSponsor);
                    MessageBox.Show("Sponsor updated successfully!");
                }
                else
                {
                    Sponsor s = new Sponsor(
                        txtName.Text,
                        txtOrganization.Text,
                        txtEmail.Text,
                        txtPhone.Text
                    );

                    dl.Insert(s);
                    MessageBox.Show("Sponsor added successfully!");
                }

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePreview()
        {
            lblPreviewName.Text = string.IsNullOrWhiteSpace(txtName.Text) ? "Name" : txtName.Text;
            lblPreviewOrg.Text = string.IsNullOrWhiteSpace(txtOrganization.Text) ? "Organization" : txtOrganization.Text;
            lblPreviewEmail.Text = string.IsNullOrWhiteSpace(txtEmail.Text) ? "email@example.com" : txtEmail.Text;
            lblPreviewPhone.Text = string.IsNullOrWhiteSpace(txtPhone.Text) ? "Phone" : txtPhone.Text;
        }

        public void LoadSponsorData(Sponsor s)
        {
            if (s == null) return;

            IsEditMode = true;
            SelectedSponsor = s;

            txtName.Text = s.Name;
            txtOrganization.Text = s.Organization;
            txtEmail.Text = s.Email;
            txtPhone.Text = s.Phone;

            UpdatePreview();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtOrganization.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            IsEditMode = false;
            SelectedSponsor = null;
            UpdatePreview();
        }

        private void btnReset_Click(object sender, EventArgs e) { ClearForm(); }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new SponsorsForm());
        }

        private void txtName_TextChanged(object sender, EventArgs e) 
        {
            UpdatePreview();
        }
        private void txtOrganization_TextChanged(object sender, EventArgs e) 
        {
            UpdatePreview(); 
        }
        private void txtEmail_TextChanged(object sender, EventArgs e) 
        {
            UpdatePreview();
        }
        private void txtPhone_TextChanged(object sender, EventArgs e) 
        {
            UpdatePreview();
        }
    }
}
