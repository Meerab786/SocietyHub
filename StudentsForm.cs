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
    public partial class StudentsForm : UserControl
    {
        private Student selectedStudent;
        public StudentsForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.Rows.Clear();

            StudentDL dl = new StudentDL();

            List<Student> students = dl.GetAll();

            foreach (Student s in students)
            {
                dgvStudents.Rows.Add(
                    s.Id,
                    s.Name,
                    s.RegNo,
                    s.Department,
                    s.BatchYear,
                    s.Phone,
                    s.Email,
                    s.Status
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(
                    dgvStudents.SelectedRows[0].Cells[0].Value
                );

                StudentDL dl = new StudentDL();
                dl.Delete(id);

                MessageBox.Show("Student deleted successfully.");

                LoadStudents();
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            SearchStudents(txtSearchStudent.Text);
        }

        private void SearchStudents(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadStudents();
                return;
            }
            dgvStudents.Rows.Clear();

            StudentDL dl = new StudentDL();
            List<Student> students = dl.GetAll();

            keyword = keyword.ToLower();

            foreach (Student s in students)
            {
                if (s.Name.ToLower().Contains(keyword) ||
                    s.RegNo.ToLower().Contains(keyword))
                {
                    dgvStudents.Rows.Add(
                        s.Id,
                        s.Name,
                        s.RegNo,
                        s.Department,
                        s.BatchYear,
                        s.Phone,
                        s.Email,
                        s.Status
                    );
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to edit " + selectedStudent.Name + "?",
                "Confirm Edit",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No)
                return;

            AddStudent add = new AddStudent();

            Form1 main = (Form1)this.FindForm();
            main.LoadPage(add);

            add.LoadStudentData(selectedStudent);
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dgvStudents.Rows[e.RowIndex].Cells[0].Value
                );

                StudentDL dl = new StudentDL();

                selectedStudent = dl.GetById(id);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new AddStudent());
        }
    }
}
