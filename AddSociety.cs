using DB_Final.BL;
using DB_Final.DL;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DB_Final
{
    public partial class AddSociety : UserControl
    {
        private Society editSociety = null;
        string selectedLogoPath = "";
        public AddSociety()
        {
            InitializeComponent();
            cmbStatus.Items.Add("active");
            cmbStatus.Items.Add("inactive");
            LoadCategories();
        }
        private void UploadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Society Logo";

            ofd.Filter =
                "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;

                string folder =
                    Application.StartupPath + "/Images/Societies/";

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string fileName =
                    Guid.NewGuid().ToString()
                    + Path.GetExtension(sourcePath);

                string destinationPath =
                    Path.Combine(folder, fileName);

                File.Copy(sourcePath, destinationPath, true);

                selectedLogoPath = destinationPath;

                picLogoPreview.Image =
                    Image.FromFile(destinationPath);

                picLogoPreview.SizeMode =
                    PictureBoxSizeMode.Zoom;

                picLogoPreview.Visible = true;

                lblUpload.Visible = false;
                label10.Visible = false;
                picUploadIcon.Visible = false;
            }
        }

        private void LoadCategories()
        {
            SocietyCategoryDL dl = new SocietyCategoryDL();

            List<SocietyCategory> categories = dl.GetAll();

            cmbCategory.DataSource = categories;

            cmbCategory.DisplayMember = "Name";

            cmbCategory.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SocietyCategory cat =  (SocietyCategory)cmbCategory.SelectedItem;
                SocietyDL dl = new SocietyDL();

                if (editSociety == null)
                {
                    Society s = new Society(
                        txtName.Text,
                        txtDescription.Text,
                        dtpFoundedDate.Value,
                        cat,
                        cmbStatus.Text,
                        selectedLogoPath
                    );

                    dl.Insert(s);
                    MessageBox.Show("Society Added Successfully!");
                }

                else
                {
                    Society s = new Society(
                        editSociety.Id,
                        txtName.Text,
                        txtDescription.Text,
                        dtpFoundedDate.Value,
                        cat,
                        cmbStatus.Text,
                        selectedLogoPath
                    );
                    dl.Update(s);
                    MessageBox.Show("Society Updated Successfully!");
                }
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            dtpFoundedDate.Value = DateTime.Now;
            selectedLogoPath = "";
            picLogoPreview.Image = null;
            picUploadIcon.Visible = true;
            lblUpload.Visible = true;
            editSociety = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            dtpFoundedDate.Value = DateTime.Now;
            picLogoPreview.Image = null;
            selectedLogoPath = "";
            picUploadIcon.Visible = true;
            label10.Visible = true;
            lblUpload.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new SocietyForm());
        }
        public void LoadSocietyData(Society s)
        {
            txtName.Text = s.Name;
            txtDescription.Text = s.Description;
            dtpFoundedDate.Value = s.FoundedDate;
            cmbStatus.Text = s.Status;
            cmbCategory.SelectedValue = s.Category.Id;
            selectedLogoPath = s.LogoPath;

            if (!string.IsNullOrEmpty(selectedLogoPath) &&
                File.Exists(selectedLogoPath))
            {
                picLogoPreview.Image = Image.FromFile(selectedLogoPath);
                picLogoPreview.SizeMode = PictureBoxSizeMode.Zoom;

                picUploadIcon.Visible = false;
                lblUpload.Visible = false;
            }
            editSociety = s;
        }
    }
}
