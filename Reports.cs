using DB_Final.BL;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Final
{
    public partial class Reports : UserControl
    {
        private string activeReport = "";

        public Reports()
        {
            InitializeComponent();
            this.Load += Reports_Load;
        }

        // ── FORM LOAD ─────────────────────────────────────────────────────────
        private void Reports_Load(object sender, EventArgs e)
        {
            pnlParams.Visible = false;

            // cmbStatus — items manually (changes per report in button click)
            // cmbDepartment — manually fixed values
            cmbDepartment.Items.Clear();
            cmbDepartment.Items.AddRange(new object[] { "All", "CS", "SE", "EE", "ME", "BBA", "AI" });
            cmbDepartment.SelectedIndex = 0;

            // cmbSociety — loaded from DB (used in: Society Members, Announcements, Role History)
            LoadSocietyCombo();

            // cmbVenue — loaded from DB (used in: Venue Utilization)
            LoadVenueCombo();

            // cmbEvent — loaded from DB (used in: Feedback)
            LoadEventCombo();

            // alignment set karo sab controls ki
            SetParamAlignment();
        }

        // ── ALIGNMENT ─────────────────────────────────────────────────────────
        private void SetParamAlignment()
        {
            int top1 = 20;  // labels ki top position
            int top2 = 45;  // controls ki top position
            int h = 30;     // control height

            // From Date
            lblFrom.Location = new Point(20, top1);
            dtpFrom.Location = new Point(20, top2);
            dtpFrom.Size = new Size(180, h);

            // To Date
            lblTo.Location = new Point(220, top1);
            dtpTo.Location = new Point(220, top2);
            dtpTo.Size = new Size(180, h);

            // Society
            lblSociety.Location = new Point(20, top1);
            cmbSociety.Location = new Point(20, top2);
            cmbSociety.Size = new Size(200, h);

            // Status
            lblStatus.Location = new Point(240, top1);
            cmbStatus.Location = new Point(240, top2);
            cmbStatus.Size = new Size(160, h);

            // Department
            lblDepartment.Location = new Point(20, top1);
            cmbDepartment.Location = new Point(20, top2);
            cmbDepartment.Size = new Size(200, h);

            // Venue
            lblVenue.Location = new Point(20, top1);
            cmbVenue.Location = new Point(20, top2);
            cmbVenue.Size = new Size(200, h);

            // Event
            lblEvent.Location = new Point(20, top1);
            cmbEvent.Location = new Point(20, top2);
            cmbEvent.Size = new Size(250, h);

            lblFrom.ForeColor = Color.Black;
            lblTo.ForeColor = Color.Black;
            lblSociety.ForeColor = Color.Black;
            lblStatus.ForeColor = Color.Black;
            lblDepartment.ForeColor = Color.Black;
            lblVenue.ForeColor = Color.Black;
            lblEvent.ForeColor = Color.Black;
            btnGenerate.ForeColor = Color.Black;

            // Generate button — always right side
            btnGenerate.Location = new Point(pnlParams.Width - 180, 20);
            btnGenerate.Size = new Size(160, 60);
        }

        // ── DB LOAD HELPERS ───────────────────────────────────────────────────

        // Society combo — Society Members, Announcements, Role History reports mein use hoga
        private void LoadSocietyCombo()
        {
            cmbSociety.Items.Clear();
            cmbSociety.Items.Add("All");
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var dr = new MySqlCommand("SELECT name FROM Society ORDER BY name", conn).ExecuteReader();
                    while (dr.Read())
                        cmbSociety.Items.Add(dr["name"].ToString());
                }
            }
            catch { }
            cmbSociety.SelectedIndex = 0;
        }

        // Venue combo — Venue Utilization report mein use hoga
        private void LoadVenueCombo()
        {
            cmbVenue.Items.Clear();
            cmbVenue.Items.Add("All");
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var dr = new MySqlCommand("SELECT name FROM Venue ORDER BY name", conn).ExecuteReader();
                    while (dr.Read())
                        cmbVenue.Items.Add(dr["name"].ToString());
                }
            }
            catch { }
            cmbVenue.SelectedIndex = 0;
        }

        // Event combo — Feedback report mein use hoga
        private void LoadEventCombo()
        {
            cmbEvent.Items.Clear();
            cmbEvent.Items.Add("All");
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var dr = new MySqlCommand("SELECT title FROM Event ORDER BY title", conn).ExecuteReader();
                    while (dr.Read())
                        cmbEvent.Items.Add(dr["title"].ToString());
                }
            }
            catch { }
            cmbEvent.SelectedIndex = 0;
        }

        // ── HIDE ALL PARAMS ───────────────────────────────────────────────────
        private void HideAllParams()
        {
            lblFrom.Visible = false; dtpFrom.Visible = false;
            lblTo.Visible = false; dtpTo.Visible = false;
            lblSociety.Visible = false; cmbSociety.Visible = false;
            lblStatus.Visible = false; cmbStatus.Visible = false;
            lblDepartment.Visible = false; cmbDepartment.Visible = false;
            lblVenue.Visible = false; cmbVenue.Visible = false;
            lblEvent.Visible = false; cmbEvent.Visible = false;
        }

        
        

        // ── BIND HELPER ───────────────────────────────────────────────────────
        private void BindReport(string rdlcFileName, object data)
        {
            reportViewer1.LocalReport.ReportPath =
                Application.StartupPath + @"\Reports\" + rdlcFileName;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", data));
            reportViewer1.RefreshReport();
        }

        // ── LOAD: All Events ──────────────────────────────────────────────────
        private void LoadAllEventsReport(DateTime? from, DateTime? to)
        {
            try
            {
                var list = new List<AllEventsReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.EventsReport, conn);
                    cmd.Parameters.AddWithValue("@fromDate", (object)from ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@toDate", (object)to ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new AllEventsReport
                        {
                            EventTitle = dr["title"].ToString(),
                            SocietyName = dr["societyName"].ToString(),
                            VenueName = dr["venueName"].ToString(),
                            Category = dr["categoryName"].ToString(),
                            EvantDateTime = Convert.ToDateTime(dr["eventDatetime"]),
                            Capacity = Convert.ToInt32(dr["capacity"]),
                            Status = dr["status"].ToString()
                        });
                }
                BindReport("AllEventsReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Event Registrations ─────────────────────────────────────────
        private void LoadRegistrationsReport(string status)
        {
            try
            {
                var list = new List<EventRegistrationReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptEventRegistrations, conn);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new EventRegistrationReport
                        {
                            StudentName = dr["studentName"].ToString(),
                            RegNo = dr["regNo"].ToString(),
                            EventTitle = dr["eventTitle"].ToString(),
                            RegistrationDate = Convert.ToDateTime(dr["registrationDate"]),
                            Status = dr["status"].ToString(),
                            CancellationReason = dr["cancellationReason"].ToString()
                        });
                }
                BindReport("EventRegistrationsReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Society Members ─────────────────────────────────────────────
        private void LoadSocietyMembersReport(string societyName, string status)
        {
            try
            {
                var list = new List<SocietyMembersReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptSocietyMembers, conn);
                    cmd.Parameters.AddWithValue("@societyName", (object)societyName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new SocietyMembersReport
                        {
                            StudentName = dr["studentName"].ToString(),
                            RegNo = dr["regNo"].ToString(),
                            Department = dr["department"].ToString(),
                            SocietyName = dr["societyName"].ToString(),
                            JoinDate = Convert.ToDateTime(dr["joinDate"]),
                            LeaveDate = dr["leaveDate"] == DBNull.Value
                                            ? "—"
                                            : Convert.ToDateTime(dr["leaveDate"]).ToString("dd MMM yyyy"),
                            Status = dr["status"].ToString()
                        });
                }
                BindReport("SocietyMembersReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Students ────────────────────────────────────────────────────
        private void LoadStudentsReport(string department)
        {
            try
            {
                var list = new List<StudentsReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptStudents, conn);
                    cmd.Parameters.AddWithValue("@department", (object)department ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@batchYear", DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new StudentsReport
                        {
                            Name = dr["name"].ToString(),
                            RegNo = dr["regNo"].ToString(),
                            Email = dr["email"].ToString(),
                            Phone = dr["phone"].ToString(),
                            Department = dr["department"].ToString(),
                            BatchYear = Convert.ToInt32(dr["batchYear"]),
                            Status = dr["status"].ToString()
                        });
                }
                BindReport("StudentsReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Sponsorships ────────────────────────────────────────────────
        private void LoadSponsorshipsReport(DateTime? from, DateTime? to)
        {
            try
            {
                var list = new List<SponsorshipsReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptSponsorships, conn);
                    cmd.Parameters.AddWithValue("@fromDate", (object)from ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@toDate", (object)to ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new SponsorshipsReport
                        {
                            SponsorName = dr["sponsorName"].ToString(),
                            Organization = dr["organization"].ToString(),
                            EventTitle = dr["eventTitle"].ToString(),
                            Amount = Convert.ToDecimal(dr["amount"]),
                            SponsorshipDate = Convert.ToDateTime(dr["sponsorshipDate"])
                        });
                }
                BindReport("SponsorshipsReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Total Sponsorship by Event ──────────────────────────────────
        private void LoadTotalSponsorshipReport()
        {
            try
            {
                var list = new List<TotalSponsorshipReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptTotalSponsorshipByEvent, conn);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new TotalSponsorshipReport
                        {
                            EventTitle = dr["eventTitle"].ToString(),
                            SocietyName = dr["societyName"].ToString(),
                            TotalSponsors = Convert.ToInt32(dr["totalSponsors"]),
                            TotalAmount = Convert.ToDecimal(dr["totalAmount"])
                        });
                }
                BindReport("TotalSponsorshipReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Venue Utilization ───────────────────────────────────────────
        private void LoadVenueReport(string venueName)
        {
            try
            {
                var list = new List<VenueUtilizationReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptVenueUtilization, conn);
                    cmd.Parameters.AddWithValue("@venueName", (object)venueName ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new VenueUtilizationReport
                        {
                            VenueName = dr["venueName"].ToString(),
                            Location = dr["location"].ToString(),
                            VenueCapacity = Convert.ToInt32(dr["venueCapacity"]),
                            EventTitle = dr["eventTitle"].ToString(),
                            EventDatetime = Convert.ToDateTime(dr["eventDatetime"]),
                            Status = dr["status"].ToString()
                        });
                }
                BindReport("VenueUtilizationReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Announcements ───────────────────────────────────────────────
        private void LoadAnnouncementsReport(string societyName, DateTime? from, DateTime? to)
        {
            try
            {
                var list = new List<AnnouncementsReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptAnnouncements, conn);
                    cmd.Parameters.AddWithValue("@societyName", (object)societyName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fromDate", (object)from ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@toDate", (object)to ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new AnnouncementsReport
                        {
                            SocietyName = dr["societyName"].ToString(),
                            Title = dr["title"].ToString(),
                            Message = dr["message"].ToString(),
                            PostedAt = Convert.ToDateTime(dr["postedAt"])
                        });
                }
                BindReport("AnnouncementsReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Role History ────────────────────────────────────────────────
        private void LoadRoleHistoryReport(string societyName)
        {
            try
            {
                var list = new List<RoleHistoryReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptMembershipRoleHistory, conn);
                    cmd.Parameters.AddWithValue("@societyName", (object)societyName ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new RoleHistoryReport
                        {
                            StudentName = dr["studentName"].ToString(),
                            RegNo = dr["regNo"].ToString(),
                            SocietyName = dr["societyName"].ToString(),
                            RoleName = dr["roleName"].ToString(),
                            StartDate = Convert.ToDateTime(dr["startDate"]),
                            EndDate = dr["endDate"] == DBNull.Value
                                            ? "—"
                                            : Convert.ToDateTime(dr["endDate"]).ToString("dd MMM yyyy")
                        });
                }
                BindReport("RoleHistoryReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // ── LOAD: Feedback ────────────────────────────────────────────────────
        private void LoadFeedbackReport(string eventTitle)
        {
            try
            {
                var list = new List<FeedbackReport>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(DatabaseScripts.RptFeedback, conn);
                    cmd.Parameters.AddWithValue("@eventTitle", (object)eventTitle ?? DBNull.Value);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                        list.Add(new FeedbackReport
                        {
                            StudentName = dr["studentName"].ToString(),
                            EventTitle = dr["eventTitle"].ToString(),
                            Rating = Convert.ToInt32(dr["rating"]),
                            Comment = dr["comment"].ToString(),
                            SubmittedAt = Convert.ToDateTime(dr["submittedAt"])
                        });
                }
                BindReport("FeedbackReport.rdlc", list);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            activeReport = "Sponsorships";
            HideAllParams();
            lblFrom.Visible = true; dtpFrom.Visible = true;
            lblTo.Visible = true; dtpTo.Visible = true;
            pnlParams.Visible = true;
            LoadSponsorshipsReport(null, null);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            activeReport = "Registrations";
            HideAllParams();
            // Status values for registrations
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "All", "registered", "attended", "cancelled", "waitlist" });
            cmbStatus.SelectedIndex = 0;
            lblStatus.Text = "Status:";
            lblStatus.Visible = true; cmbStatus.Visible = true;
            pnlParams.Visible = true;
            LoadRegistrationsReport(null);
        }
        
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            activeReport = "AllEvents";
            HideAllParams();
            lblFrom.Visible = true; dtpFrom.Visible = true;
            lblTo.Visible = true; dtpTo.Visible = true;
            pnlParams.Visible = true;
            LoadAllEventsReport(null, null);
        }


        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            activeReport = "SocietyMembers";
            HideAllParams();
            // Status values for membership
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            cmbStatus.SelectedIndex = 0;
            lblSociety.Visible = true; cmbSociety.Visible = true;
            lblStatus.Text = "Status:";
            lblStatus.Visible = true; cmbStatus.Visible = true;
            pnlParams.Visible = true;
            LoadSocietyMembersReport(null, null);
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            activeReport = "Students";
            HideAllParams();
            lblDepartment.Visible = true; cmbDepartment.Visible = true;
            pnlParams.Visible = true;
            LoadStudentsReport(null);
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            activeReport = "TotalSponsorship";
            pnlParams.Visible = false;
            LoadTotalSponsorshipReport();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            activeReport = "Venue";
            HideAllParams();
            lblVenue.Visible = true; cmbVenue.Visible = true;
            pnlParams.Visible = true;
            LoadVenueReport(null);
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            activeReport = "Announcements";
            HideAllParams();
            lblFrom.Visible = true; dtpFrom.Visible = true;
            lblTo.Visible = true; dtpTo.Visible = true;
            pnlParams.Visible = true;
            LoadAnnouncementsReport(null, null, null);
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            activeReport = "RoleHistory";
            HideAllParams();
            lblSociety.Visible = true; cmbSociety.Visible = true;
            pnlParams.Visible = true;
            LoadRoleHistoryReport(null);
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            activeReport = "Feedback";
            HideAllParams();
            lblEvent.Visible = true; cmbEvent.Visible = true;
            pnlParams.Visible = true;
            LoadFeedbackReport(null);
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            switch (activeReport)
            {
                case "AllEvents":
                    LoadAllEventsReport(dtpFrom.Value, dtpTo.Value);
                    break;
                case "Registrations":
                    LoadRegistrationsReport(
                        cmbStatus.Text == "All" ? null : cmbStatus.Text);
                    break;
                case "SocietyMembers":
                    LoadSocietyMembersReport(
                        cmbSociety.Text == "All" ? null : cmbSociety.Text,
                        cmbStatus.Text == "All" ? null : cmbStatus.Text);
                    break;
                case "Students":
                    LoadStudentsReport(
                        cmbDepartment.Text == "All" ? null : cmbDepartment.Text);
                    break;
                case "Sponsorships":
                    LoadSponsorshipsReport(dtpFrom.Value, dtpTo.Value);
                    break;
                case "TotalSponsorship":
                    LoadTotalSponsorshipReport();
                    break;
                case "Venue":
                    LoadVenueReport(
                        cmbVenue.Text == "All" ? null : cmbVenue.Text);
                    break;
                case "Announcements":
                    LoadAnnouncementsReport(
                        cmbSociety.Text == "All" ? null : cmbSociety.Text,
                        dtpFrom.Value, dtpTo.Value);
                    break;
                case "RoleHistory":
                    LoadRoleHistoryReport(
                        cmbSociety.Text == "All" ? null : cmbSociety.Text);
                    break;
                case "Feedback":
                    LoadFeedbackReport(
                        cmbEvent.Text == "All" ? null : cmbEvent.Text);
                    break;
            }
        }
    }
}