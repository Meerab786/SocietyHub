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
    public partial class MembershipForm : UserControl
    {
        private Membership selectedMembership = null;

        public MembershipForm()
        {
            InitializeComponent();

            LoadStudents();
            LoadSociety();
            LoadMemberships();

            dgvMemberships.AutoGenerateColumns = false;


            //LoadMembershipss();
            //LoadRoles();
        }

        private void LoadStudents()
        {
            StudentDL dl = new StudentDL();

            cmbStudent.DataSource = dl.GetAll();
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "Id";
        }

        private void LoadSociety()
        {
            SocietyDL dl = new SocietyDL();

            cmbSociety.DataSource = dl.GetAll();
            cmbSociety.DisplayMember = "Name";
            cmbSociety.ValueMember = "Id";
        }

        private void LoadMemberships()
        {
            dgvMemberships.Rows.Clear();

            MembershipDL dl = new MembershipDL();
            List<Membership> list = dl.GetAll();

            foreach (Membership m in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvMemberships);

                row.Cells[0].Value = m.Student != null ? m.Student.Name : "-";
                row.Cells[1].Value = m.Society != null ? m.Society.Name : "-";
                row.Cells[2].Value = m.Status;
                row.Cells[3].Value = m.JoinDate.ToString("dd-MM-yyyy");

                row.Cells[4].Value =
                    m.LeaveDate.HasValue
                    ? m.LeaveDate.Value.ToString("dd-MM-yyyy")
                    : "-";

                row.Tag = m;

                dgvMemberships.Rows.Add(row);
            }
        }

        private void dgvMemberships_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedMembership = (Membership)dgvMemberships.Rows[e.RowIndex].Tag;

            cmbStudent.SelectedValue = selectedMembership.Student.Id;
            cmbSociety.SelectedValue = selectedMembership.Society.Id;

            dtpJoinDate.Value = selectedMembership.JoinDate;

            if (selectedMembership.LeaveDate.HasValue)
                dtpLeaveDate.Value = selectedMembership.LeaveDate.Value;
            else
                dtpLeaveDate.Value = DateTime.Now;

            if (selectedMembership.Status.ToLower() == "active")
                rdbActive.Checked = true;
            else
                rdbInactive.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = (Student)cmbStudent.SelectedItem;
                Society society = (Society)cmbSociety.SelectedItem;

                DateTime joinDate = dtpJoinDate.Value;
                DateTime? leaveDate = null;

                // 🔥 RADIO BUTTON STATUS LOGIC
                string status = "";

                if (rdbActive.Checked)
                    status = "active";
                else if (rdbInactive.Checked)
                    status = "inactive";
                else
                {
                    MessageBox.Show("Please select status");
                    return;
                }

                // leave date only if inactive
                if (status == "inactive")
                    leaveDate = dtpLeaveDate.Value;

                MembershipDL dl = new MembershipDL();

                if (selectedMembership == null)
                {
                    Membership m = new Membership(status, joinDate, leaveDate, student, society);
                    dl.Insert(m);

                    MessageBox.Show("Membership added!");
                }
                else
                {
                    Membership m = new Membership(
                        selectedMembership.Id,
                        status,
                        joinDate,
                        leaveDate,
                        student,
                        society
                    );

                    dl.Update(m);

                    MessageBox.Show("Membership updated!");
                }

                ClearForm();
                LoadMemberships();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            cmbStudent.SelectedIndex = -1;
            cmbSociety.SelectedIndex = -1;

            rdbActive.Checked = false;
            rdbInactive.Checked = false;

            dtpJoinDate.Value = DateTime.Now;
            dtpLeaveDate.Value = DateTime.Now;

            selectedMembership = null;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMembership == null)
            {
                MessageBox.Show("Please select a membership first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                MembershipDL dl = new MembershipDL();
                dl.Delete(selectedMembership.Id);

                MessageBox.Show("Deleted successfully!");

                ClearForm();
                LoadMemberships();
                selectedMembership = null;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedMembership == null)
            {
                MessageBox.Show("Please select a membership first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Load this membership for editing?",
                "Edit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dtpJoinDate.Value = selectedMembership.JoinDate;

                if (selectedMembership.LeaveDate.HasValue)
                    dtpLeaveDate.Value = selectedMembership.LeaveDate.Value;

                cmbStudent.SelectedItem = selectedMembership.Student;
                cmbSociety.SelectedItem = selectedMembership.Society;

                MessageBox.Show("Loaded for editing. Now update and click Save.");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvMemberships.Rows)
            {
                bool visible =
                    row.Cells[0].Value.ToString().ToLower().Contains(keyword) ||  // Student
                    row.Cells[1].Value.ToString().ToLower().Contains(keyword) ||  // Society
                    row.Cells[2].Value.ToString().ToLower().Contains(keyword) ||  // Status
                    row.Cells[3].Value.ToString().ToLower().Contains(keyword);    // Join Date

                row.Visible = visible;
            }
        }

        //private void chkNoEndDate_CheckedChanged(object sender, EventArgs e)
        //{
        //    dtpEndDate.Enabled = !chkNoEndDate.Checked;
        //}
        //private RoleHistory selectedRoleHistory = null;

        //private void LoadMembershipss()
        //{
        //    MembershipDL dl = new MembershipDL();

        //    cmbMembership.DataSource = dl.GetAll();
        //    cmbMembership.DisplayMember = "StudentName";   
        //    cmbMembership.ValueMember = "Id";
        //}
        //private void LoadRoles()
        //{
        //    RoleHistoryDL dl = new RoleHistoryDL();

        //    cmbRole.DataSource = null;
        //    cmbRole.Items.Clear();

        //    cmbRole.DataSource = dl.roles();
        //    cmbRole.DisplayMember = "Name";
        //    cmbRole.ValueMember = "Id";
        //}
        //private void LoadRoleHistory()
        //{
        //    dgvRoleHistory.Rows.Clear();

        //    RoleHistoryDL dl = new RoleHistoryDL();
        //    List<RoleHistory> list = dl.GetAll();

        //    foreach (RoleHistory r in list)
        //    {
        //        DataGridViewRow row = new DataGridViewRow();
        //        row.CreateCells(dgvRoleHistory);

        //        row.Cells[0].Value = r.Membership.Student.Name;
        //        row.Cells[1].Value = r.RoleTitle;
        //        row.Cells[2].Value = r.StartDate.ToString("dd-MM-yyyy");
        //        row.Cells[3].Value =
        //            r.EndDate.HasValue ? r.EndDate.Value.ToString("dd-MM-yyyy") : "-";

        //        row.Tag = r;

        //        dgvRoleHistory.Rows.Add(row);
        //    }
        //}
        //private void btnSaves_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Membership membership = (Membership)cmbMembership.SelectedItem;

        //        string roleName = cmbRole.Text;
        //        int roleId = Convert.ToInt32(cmbRole.SelectedValue);

        //        DateTime startDate = dtpStartDate.Value;

        //        DateTime? endDate = null;
        //        if (!chkNoEndDate.Checked)
        //            endDate = dtpEndDate.Value;

        //        RoleHistoryDL dl = new RoleHistoryDL();

        //        if (selectedRoleHistory == null)
        //        {
        //            RoleHistory rh = new RoleHistory(startDate, endDate, roleName, membership);

        //            dl.Insert(rh, roleId);

        //            MessageBox.Show("Role assigned successfully!");
        //        }
        //        else
        //        {
        //            RoleHistory rh = new RoleHistory(
        //                selectedRoleHistory.Id,
        //                startDate,
        //                endDate,
        //                roleName,
        //                membership
        //            );

        //            dl.Update(rh, roleId);

        //            MessageBox.Show("Updated successfully!");
        //        }

        //        ClearForms();
        //        LoadRoleHistory();
        //        selectedRoleHistory = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private void dgvRoleHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0) return;

        //    selectedRoleHistory = (RoleHistory)dgvRoleHistory.Rows[e.RowIndex].Tag;

        //    if (selectedRoleHistory == null) return;

        //    cmbRole.Text = selectedRoleHistory.RoleTitle;
        //    dtpStartDate.Value = selectedRoleHistory.StartDate;

        //    if (selectedRoleHistory.EndDate.HasValue)
        //    {
        //        dtpEndDate.Value = selectedRoleHistory.EndDate.Value;
        //        chkNoEndDate.Checked = false;
        //    }
        //    else
        //    {
        //        chkNoEndDate.Checked = true;
        //    }

        //    cmbMembership.SelectedItem = selectedRoleHistory.Membership;
        //}
        //private void ClearForms()
        //{
        //    cmbMembership.SelectedIndex = -1;
        //    cmbRole.SelectedIndex = -1;

        //    dtpStartDate.Value = DateTime.Now;
        //    dtpEndDate.Value = DateTime.Now;

        //    chkNoEndDate.Checked = false;

        //    selectedRoleHistory = null;
        //}
        //private void chkNoEndDate_CheckedChanged(object sender, EventArgs e)
        //{
        //    dtpEndDate.Enabled = !chkNoEndDate.Checked;
        //}
    }
}
