using DB_Final.BL;
using DB_Final.DL;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DB_Final
{
    public partial class SocietyForm : UserControl
    {
        Society selectedSociety;

        SocietyDL dl = new SocietyDL();
        SocietyCategoryDL catDL = new SocietyCategoryDL();

        public SocietyForm()
        {
            InitializeComponent();
            LoadSocieties();
        }

        private void LoadSocieties()
        {
            flpSocieties.Controls.Clear();

            SocietyDL dl = new SocietyDL();

            List<Society> societies = dl.GetAll();

            foreach (Society s in societies)
            {
                Panel card = CreateSocietyCard(s);
                flpSocieties.Controls.Add(card);
            }
        }
        private Panel CreateSocietyCard(Society s)
        {

            Panel card = new Panel();

            card.Width = 280;
            card.Height = 170;
            card.BackColor = Color.White;
            card.Margin = new Padding(12);
            card.BorderStyle = BorderStyle.None;

            // simulate soft border
            card.Paint += Card_Paint;

            // TITLE
            Label lblName = new Label();
            lblName.Text = s.Name.ToUpper();
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(15, 15);
            lblName.AutoSize = true;

            // CATEGORY
            Label lblCategory = new Label();
            lblCategory.Text = s.Category != null ? s.Category.Name : "Uncategorized";
            lblCategory.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lblCategory.ForeColor = Color.Indigo;
            lblCategory.Location = new Point(15, 40);
            lblCategory.AutoSize = true;

            // DESCRIPTION (SHORT)
            Label lblDesc = new Label();
            lblDesc.Text = s.Description.Length > 300? s.Description.Substring(0, 300) + "..." : s.Description;

            lblDesc.Font = new Font("Segoe UI", 8);
            lblDesc.ForeColor = Color.DimGray;
            lblDesc.Location = new Point(15, 60);
            lblDesc.Size = new Size(240, 30);

            // STATUS BADGE
            Label lblStatus = new Label();
            lblStatus.Text = s.Status.ToUpper();
            lblStatus.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Size = new Size(85, 23);
            lblStatus.Location = new Point(15, 120);

            if (s.Status.ToLower() == "active")
                lblStatus.BackColor = Color.SeaGreen;
            else
                lblStatus.BackColor = Color.Gray;

            // VIEW BUTTON
            Button btnView = new Button();

            btnView.Text = "View";
            btnView.Size = new Size(80, 28);
            btnView.Location = new Point(185, 125);

            btnView.BackColor = Color.FromArgb(111, 66, 193);
            btnView.ForeColor = Color.White;

            btnView.FlatStyle = FlatStyle.Flat;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.Cursor = Cursors.Hand;

            // hover effects
            btnView.MouseEnter += Button_MouseEnter;
            btnView.MouseLeave += Button_MouseLeave;

            //// CLICK
            btnView.Click += (s1, e1) =>
            {
                selectedSociety = s;
                ShowSocietyDetails(s);
            };

            // ADD CONTROLS
            card.MouseEnter += Card_MouseEnter;
            card.MouseLeave += Card_MouseLeave;

            card.Controls.Add(lblName);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblStatus);
            card.Controls.Add(btnView);

            return card;
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel card = sender as Panel;

            ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid);
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(140, 90, 220);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(111, 66, 193);
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Panel card = sender as Panel;

            card.BackColor = Color.FromArgb(250, 250, 255);
        }
        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Panel card = sender as Panel;

            card.BackColor = Color.White;
        }

        private void ShowSocietyDetails(Society s)
        {
            label2.Visible = true;
            lblName.Visible = true;

            label6.Visible = true;
            lblStatus.Visible = true;

            lblDescription.Visible = true;

            label7.Visible = true;
            lblDate.Visible = true;

            label3.Visible = true;
            lblCategory.Visible = true;

            lblName.Text = s.Name;
            lblStatus.Text = s.Status;
            lblDescription.Text = s.Description;
            lblDate.Text = s.FoundedDate.ToShortDateString();

            lblCategory.Text = s.Category != null
                ? s.Category.Name
                : "No Category";
        }

        //private void ShowDetails(Society s)
        //{
        //    lblName.Text = s.Name;
        //    cmbStatus.Text = s.Category != null ? s.Category.Name : "";
        //    dtpFounded.Text = s.Status;
        //    lblDescription.Text = s.Description;
        //    lblDate.Text = s.FoundedDate.ToShortDateString();
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    Society s = new Society(
        //        txtName.Text,
        //        txtDescription.Text,
        //        dtpFounded.Value,
        //        new SocietyCategory((int)cmbCategory.SelectedValue, cmbCategory.Text, ""),
        //        cmbStatus.Text
        //    );

        //    dl.Insert(s);

        //    MessageBox.Show("Society Added Successfully");

        //    LoadSocieties();
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (selectedSociety == null)
        //    {
        //        MessageBox.Show("Select a society first");
        //        return;
        //    }

        //    txtName.Text = selectedSociety.Name;
        //    txtDescription.Text = selectedSociety.Description;
        //    dtpFounded.Value = selectedSociety.FoundedDate;
        //    cmbStatus.Text = selectedSociety.Status;

        //    if (selectedSociety.Category != null)
        //        cmbCategory.SelectedValue = selectedSociety.Category.Id;
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    Society s = new Society(
        //        selectedSociety.Id,
        //        txtName.Text,
        //        txtDescription.Text,
        //        dtpFounded.Value,
        //        new SocietyCategory((int)cmbCategory.SelectedValue, cmbCategory.Text, ""),
        //        cmbStatus.Text
        //    );

        //    dl.Update(s);

        //    MessageBox.Show("Updated Successfully");

        //    LoadSocieties();
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (selectedSociety == null)
        //    {
        //        MessageBox.Show("Select a society first");
        //        return;
        //    }

        //    dl.Delete(selectedSociety.Id);

        //    MessageBox.Show("Deleted Successfully");

        //    LoadSocieties();
        //}

        //private void btnReset_Click(object sender, EventArgs e)
        //{
        //    txtName.Clear();
        //    txtDescription.Clear();
        //    cmbStatus.SelectedIndex = -1;
        //    cmbCategory.SelectedIndex = -1;
        //    dtpFounded.Value = DateTime.Now;
        //}

        private void btnAddSociety_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new AddSociety());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSociety == null)
            {
                MessageBox.Show("Please select a society first.");

                return;
            }



            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete '"
                + selectedSociety.Name + "' ?",

                "Delete Society",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Warning
            );



            if (result == DialogResult.Yes)
            {
                try
                {
                    SocietyDL dl = new SocietyDL();

                    dl.Delete(selectedSociety.Id);



                    MessageBox.Show(
                        "Society deleted successfully!"
                    );



                    lblName.Text = "";

                    lblStatus.Text = "";

                    lblCategory.Text = "";

                    lblDescription.Text = "";

                    lblDate.Text = "";

                    selectedSociety = null;

                    LoadSocieties();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedSociety == null)
            {
                MessageBox.Show("Select a society first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to edit " + selectedSociety.Name + "?",
                "Confirm Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            AddSociety add = new AddSociety();

            Form1 main = (Form1)this.FindForm();

            main.LoadPage(add);

            add.LoadSocietyData(selectedSociety);
        }

        private void SocietyForm_Load(object sender, EventArgs e)
        {


        }
    }
}
