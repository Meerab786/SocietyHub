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
    public partial class FeedbackForm : UserControl
    {
        private Feedback selectedFeedback = null;
        public FeedbackForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadEvents();
            LoadRatings();
            LoadFeedback();
            dgvFeedback.Columns[0].Visible = false;
        }

        private void LoadFeedback()
        {
            dgvFeedback.Rows.Clear();

            FeedbackDL dl = new FeedbackDL();
            List<Feedback> list = dl.GetsAll();

            foreach (Feedback f in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvFeedback);

                row.Cells[0].Value = f.Id;
                row.Cells[1].Value = f.Student != null ? f.Student.Name : "-";
                row.Cells[2].Value = f.Event != null ? f.Event.Title : "-";
                row.Cells[3].Value = f.Rating;
                row.Cells[4].Value = f.Comment;
                row.Cells[5].Value = f.SubmittedAt.ToString("dd-MM-yyyy");

                row.Tag = f;

                dgvFeedback.Rows.Add(row);
            }
        }
        private void LoadStudents()
        {
            StudentDL dl = new StudentDL();

            cmbStudent.DataSource = null;
            cmbStudent.Items.Clear();

            cmbStudent.DataSource = dl.GetAll();
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "Id";

            cmbStudent.SelectedIndex = -1;
        }
        private void LoadRatings()
        {
            cmbRating.Items.Clear();

            for (int i = 1; i <= 5; i++)
            {
                cmbRating.Items.Add(i);
            }

            cmbRating.SelectedIndex = -1;
        }

        private void LoadEvents()
        {
            EventDL dl = new EventDL();

            cmbEvent.DataSource = null;
            cmbEvent.Items.Clear();

            cmbEvent.DataSource = dl.GetAll();
            cmbEvent.DisplayMember = "Title";
            cmbEvent.ValueMember = "Id";

            cmbEvent.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudent.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a student.");
                    return;
                }

                if (cmbEvent.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an event.");
                    return;
                }

                if (cmbRating.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a rating.");
                    return;
                }

                Student student = (Student)cmbStudent.SelectedItem;
                Event eventObj = (Event)cmbEvent.SelectedItem;

                int rating = Convert.ToInt32(cmbRating.SelectedItem);
                string comment = txtComment.Text.Trim();

                DateTime submittedAt = DateTime.Now;

                FeedbackDL dl = new FeedbackDL();

                if (selectedFeedback != null)
                {
                    Feedback feedback = new Feedback(
                        selectedFeedback.Id,
                        rating,
                        comment,
                        submittedAt,
                        student,
                        eventObj
                    );

                    dl.Update(feedback);

                    MessageBox.Show(
                        "Feedback updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    Feedback feedback = new Feedback(
                        rating,
                        comment,
                        submittedAt,
                        student,
                        eventObj
                    );

                    dl.Insert(feedback);

                    MessageBox.Show(
                        "Feedback added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                LoadFeedback();
                ClearFields();

                selectedFeedback = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedFeedback == null)
            {
                MessageBox.Show("Please select a feedback first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to edit this feedback?",
                "Confirm Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                cmbStudent.SelectedValue = selectedFeedback.Student.Id;
                cmbEvent.SelectedValue = selectedFeedback.Event.Id;
                cmbRating.SelectedItem = selectedFeedback.Rating;

                txtComment.Text = selectedFeedback.Comment;

                MessageBox.Show(
                    "Data loaded for editing. Modify and press Save.",
                    "Edit Mode",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedFeedback =
                (Feedback)dgvFeedback.Rows[e.RowIndex].Tag;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            cmbStudent.SelectedIndex = -1;
            cmbEvent.SelectedIndex = -1;
            cmbRating.SelectedIndex = -1;

            txtComment.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFeedback == null)
            {
                MessageBox.Show("Please select a feedback first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this feedback?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    FeedbackDL dl = new FeedbackDL();

                    dl.Delete(selectedFeedback.Id);

                    MessageBox.Show(
                        "Feedback deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadFeedback();
                    ClearFields();

                    selectedFeedback = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFeedback();

            ClearFields();

            selectedFeedback = null;
        }
    }
}
