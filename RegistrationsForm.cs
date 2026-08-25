using DB_Final.BL;
using DB_Final.DL;
using Org.BouncyCastle.Ocsp;
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
    public partial class RegistrationsForm : UserControl
    {
        private int eventId;
        private EventRegistration selectedRegistration;
        public RegistrationsForm()
        {
            InitializeComponent();
            LoadEventFilter();
            LoadStudentFilter();
            LoadRegistrations();
        }
        public RegistrationsForm(int eventId)
        {
            InitializeComponent();
            this.eventId = eventId;
            LoadRegistrationsByEvent();
        }

        private void LoadRegistrations()
        {
            dgvRegistrations.Rows.Clear();

            EventRegistrationDL dl = new EventRegistrationDL();

            List<EventRegistration> registrations =
                dl.GetAll();

            foreach (EventRegistration er in registrations)
            {
                int rowIndex = dgvRegistrations.Rows.Add(
                    er.Student != null
                        ? er.Student.Name
                        : "N/A",

                    er.Event != null
                        ? er.Event.Title
                        : "N/A",

                    er.Status,

                    er.RegistrationDate
                        .ToString("dd MMM yyyy"),

                    er.CancellationDate.HasValue
                        ? er.CancellationDate.Value
                            .ToString("dd MMM yyyy")
                        : "-"
                );

                DataGridViewRow row =
                    dgvRegistrations.Rows[rowIndex];

                if (er.Status.ToLower() == "registered")
                {
                    row.Cells[2].Style.ForeColor =
                        Color.MediumSeaGreen;
                }
                else if (er.Status.ToLower() == "attended")
                {
                    row.Cells[2].Style.ForeColor =
                        Color.MidnightBlue;
                }
                else if (er.Status.ToLower() == "cancelled")
                {
                    row.Cells[2].Style.ForeColor =
                        Color.Red;
                }
                else if (er.Status.ToLower() == "waitlist")
                {
                    row.Cells[2].Style.ForeColor =
                        Color.DarkOrange;
                }

                row.Tag = er;
            }
        }

        private void btnAddRegistration_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();

            main.LoadPage(new AddRegistrations());
        }

        private void dgvRegistrations_CellClick( object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRegistration = (EventRegistration) dgvRegistrations.Rows[e.RowIndex].Tag;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRegistration == null)
            {
                MessageBox.Show(
                    "Please select a registration first."
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this registration?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                EventRegistrationDL dl =
                    new EventRegistrationDL();

                dl.Delete(selectedRegistration.Id);

                MessageBox.Show(
                    "Registration deleted successfully."
                );

                LoadRegistrations();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRegistration == null)
            {
                MessageBox.Show(
                    "Please select a registration first."
                );
                return;
            }

            AddRegistrations page = new AddRegistrations();

            page.LoadRegistrationData( selectedRegistration);

            Form1 main = (Form1)this.FindForm();

            main.LoadPage(page);
        }

        private void LoadRegistrationsByEvent()
        {
            dgvRegistrations.Rows.Clear();

            EventRegistrationDL dl = new EventRegistrationDL();

            List<EventRegistration> list = dl.GetAll();

            foreach (var reg in list)
            {
                if (reg.Event != null && reg.Event.Id == eventId)
                {
                    int row = dgvRegistrations.Rows.Add(
                        reg.Student.Name,
                        reg.Event.Title,
                        reg.Status,
                        reg.RegistrationDate,
                        reg.CancellationDate.HasValue ? reg.CancellationDate.Value.ToString("yyyy-MM-dd") : "N/A"
                    );

                    dgvRegistrations.Rows[row].Tag = reg;
                }
            }
        }

        private void LoadEventFilter()
        {
            EventDL dl = new EventDL();

            cmbEventFilter.DataSource = dl.GetAll();
            cmbEventFilter.DisplayMember = "Title";
            cmbEventFilter.ValueMember = "Id";

            cmbEventFilter.SelectedIndex = -1;
        }

        private void LoadStudentFilter()
        {
            StudentDL dl = new StudentDL();

            List<Student> students = dl.GetAll();

            cmbStudentFilter.DataSource = students;
            cmbStudentFilter.DisplayMember = "Name";
            cmbStudentFilter.ValueMember = "Id";

            cmbStudentFilter.SelectedIndex = -1;
        }

        private void ApplyFilters()
        {
            dgvRegistrations.Rows.Clear();

            EventRegistrationDL dl = new EventRegistrationDL();
            List<EventRegistration> list = dl.GetAll();

            int? eventId =
                cmbEventFilter.SelectedValue as int?;

            int? studentId =
                cmbStudentFilter.SelectedValue as int?;

            foreach (var reg in list)
            {
                if (eventId != null && reg.Event.Id != eventId)
                    continue;

                if (studentId != null && reg.Student.Id != studentId)
                    continue;

                dgvRegistrations.Rows.Add(
                    reg.Student.Name,
                    reg.Event.Title,
                    reg.Status,
                    reg.RegistrationDate
                );
            }
        }

        private void cmbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void cmbStudentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            cmbEventFilter.SelectedIndex = -1;
            cmbStudentFilter.SelectedIndex = -1;
  
            LoadEventFilter();
            LoadStudentFilter();

            ApplyFilters();

            MessageBox.Show("Data refreshed successfully!");
        }
    }
}
