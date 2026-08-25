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
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.Items.Add("Suspended");

            if (IsEditMode && SelectedStudent != null)
            {
                txtName.Text = SelectedStudent.Name;
                txtEmail.Text = SelectedStudent.Email;
                txtPhone.Text = SelectedStudent.Phone;
                txtDepartment.Text = SelectedStudent.Department;
                txtRegNo.Text = SelectedStudent.RegNo;
                numBatchYear.Value = SelectedStudent.BatchYear;
                cmbStatus.SelectedItem = SelectedStudent.Status;
            }

            UpdatePreview();
        }
        public bool IsEditMode = false;
        public Student SelectedStudent = null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDL dl = new StudentDL();

                if (IsEditMode && SelectedStudent != null)
                {
                    SelectedStudent.Name = txtName.Text;
                    SelectedStudent.Email = txtEmail.Text;
                    SelectedStudent.Phone = txtPhone.Text;
                    SelectedStudent.Department = txtDepartment.Text;
                    SelectedStudent.RegNo = txtRegNo.Text;
                    SelectedStudent.BatchYear = Convert.ToInt32(numBatchYear.Value);
                    SelectedStudent.Status = cmbStatus.SelectedItem.ToString();

                    dl.Update(SelectedStudent);

                    MessageBox.Show("Student updated successfully!");
                }
                else
                {
                    Student s = new Student(
                        txtName.Text,
                        Convert.ToInt32(numBatchYear.Value),
                        txtDepartment.Text,
                        cmbStatus.SelectedItem.ToString(),
                        txtEmail.Text,
                        txtRegNo.Text,
                        txtPhone.Text
                    );

                    dl.Insert(s);

                    MessageBox.Show("Student added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePreview()
        {
            lblPreviewName.Text = "Name: " + txtName.Text;
            lblPreviewDepartment.Text = "Department: " + txtDepartment.Text;
            lblPreviewBatch.Text = "Batch: " + numBatchYear.Value.ToString();
            lblPreviewEmail.Text = "Email: " + txtEmail.Text;
            lblPreviewPhone.Text = "Phone: " + txtPhone.Text;
            lblPreviewRegNo.Text = "Reg No: " + txtRegNo.Text;

            if (cmbStatus.SelectedItem != null)
            {
                string status = cmbStatus.SelectedItem.ToString();

                lblPreviewStatus.Text = "Status: " + status;

                if (status.ToLower() == "active")
                {
                    lblPreviewStatus.ForeColor = Color.Green;
                }
                else if (status.ToLower() == "inactive")
                {
                    lblPreviewStatus.ForeColor = Color.Red;
                }
                else
                {
                    lblPreviewStatus.ForeColor = Color.Orange;
                }
            }
            else
            {
                lblPreviewStatus.Text = "Status:";
                lblPreviewStatus.ForeColor = Color.Black;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
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

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void numBatchYear_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        public void LoadStudentData(Student s)
        {
            if (s == null)
                return;

            IsEditMode = true;
            SelectedStudent = s;

            txtName.Text = s.Name;
            txtEmail.Text = s.Email;
            txtPhone.Text = s.Phone;
            txtDepartment.Text = s.Department;
            txtRegNo.Text = s.RegNo;
            numBatchYear.Value = s.BatchYear;

            cmbStatus.SelectedIndex = cmbStatus.FindStringExact(s.Status);

            UpdatePreview();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtRegNo.Clear();

            numBatchYear.Value = DateTime.Now.Year;

            cmbStatus.SelectedIndex = 0;

            IsEditMode = false;
            SelectedStudent = null;

            txtRegNo.ReadOnly = false;

            UpdatePreview();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new StudentsForm());
        }
    }
}
