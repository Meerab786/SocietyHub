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
    public partial class AddRegistrations : UserControl
    {
        private EventRegistration editingRegistration;

        public AddRegistrations()
        {
            InitializeComponent();
            LoadStudents();
            LoadEvents();
            LoadStatuses();
            pnlCancellation.Visible = false;
        }

        private void LoadStudents()
        {
            StudentDL dl = new StudentDL();

            cmbStudent.DataSource = dl.GetAll();
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "Id";
            cmbStudent.SelectedIndex = -1;
        }

        private void LoadEvents()
        {
            EventDL dl = new EventDL();

            cmbEvent.DataSource = dl.GetAll();
            cmbEvent.DisplayMember = "Title";
            cmbEvent.ValueMember = "Id";
            cmbEvent.SelectedIndex = -1;
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("registered");
            cmbStatus.Items.Add("attended");
            cmbStatus.Items.Add("waitlist");
            cmbStatus.Items.Add("cancelled");
            cmbStatus.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudent.SelectedIndex == -1 || cmbEvent.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Student and Event.");
                    return;
                }

                Student student = (Student)cmbStudent.SelectedItem;
                Event ev = (Event)cmbEvent.SelectedItem;

                EventRegistrationDL dl = new EventRegistrationDL();

                if (editingRegistration == null)
                {
                    EventRegistration reg =
                        new EventRegistration(
                            dtpRegistrationDate.Value,
                            cmbStatus.Text,
                            student,
                            ev
                        );

                    if (cmbStatus.Text.ToLower() == "cancelled")
                    {
                        reg.CancellationDate = dtpCancellationDate.Value;
                        reg.CancellationReason = rtbCancellationReason.Text;
                    }

                    dl.Insert(reg);

                    MessageBox.Show("Registration added successfully!");
                }

                else
                {
                    EventRegistration reg =
                        new EventRegistration(
                            editingRegistration.Id,
                            dtpRegistrationDate.Value,
                            cmbStatus.Text,
                            cmbStatus.Text.ToLower() == "cancelled"
                                ? (DateTime?)dtpCancellationDate.Value
                                : null,
                            cmbStatus.Text.ToLower() == "cancelled"
                                ? rtbCancellationReason.Text
                                : null,
                            student,
                            ev
                        );

                    dl.Update(reg);

                    MessageBox.Show("Registration updated successfully!");

                    editingRegistration = null;
                }

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex == -1)
                return;

            pnlCancellation.Visible =
                cmbStatus.Text.ToLower() == "cancelled";

            if (!pnlCancellation.Visible)
            {
                dtpCancellationDate.Value = DateTime.Now;
                rtbCancellationReason.Clear();
            }
        }

        private void ClearForm()
        {
            cmbStudent.SelectedIndex = -1;
            cmbEvent.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            dtpRegistrationDate.Value = DateTime.Now;
            dtpCancellationDate.Value = DateTime.Now;

            rtbCancellationReason.Clear();

            pnlCancellation.Visible = false;

            editingRegistration = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new RegistrationsForm());
        }

        public void LoadRegistrationData(EventRegistration reg)
        {
            editingRegistration = reg;

            cmbStudent.SelectedValue = reg.Student.Id;
            cmbEvent.SelectedValue = reg.Event.Id;
            cmbStatus.Text = reg.Status;

            dtpRegistrationDate.Value = reg.RegistrationDate;

            if (reg.Status.ToLower() == "cancelled")
            {
                pnlCancellation.Visible = true;

                if (reg.CancellationDate.HasValue)
                    dtpCancellationDate.Value = reg.CancellationDate.Value;

                rtbCancellationReason.Text = reg.CancellationReason;
            }
        }
    }
}
