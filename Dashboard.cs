using DB_Final.BL;
using DB_Final.DL;
using System;
using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            SetupChart();

            LoadDashboardStats();
            LoadPieChart();
            LoadRecentActivity();
            LoadTopSocieties();
            StyleChart();
        }
        private void LoadDashboardStats()
        {
            try
            {
                StudentDL sdl = new StudentDL();
                SocietyDL sodl = new SocietyDL();
                AnnouncementDL adl = new AnnouncementDL();
                EventDL edl = new EventDL();
                SponsorDL spdl = new SponsorDL();
                lblTotalStudents.Text = sdl.GetAll().Count.ToString();
                lblTotalSocieties.Text = sodl.GetAll().Count.ToString();
                lblTotalAnnouncements.Text = adl.GetAll().Count.ToString();
                lblTotalEvents.Text = edl.GetAll().Count.ToString();
                lblTotalSponsors.Text = spdl.GetAll().Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadPieChart()
        {
            chartStudentsPerSociety.Series.Clear();
            chartStudentsPerSociety.ChartAreas.Clear();
            chartStudentsPerSociety.ChartAreas.Add(new ChartArea());

            Series series = new Series("Society Distribution");

            series.ChartType = SeriesChartType.Pie;

            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT";
            series.LegendText = "#VALX";

            MembershipDL dl = new MembershipDL();
            var list = dl.GetAll();

            var data = list
                .Where(m => m.Society != null)
                .GroupBy(m => m.Society.Name)
                .Select(g => new
                {
                    Society = g.Key,
                    Count = g.Count()
                });

            foreach (var item in data)
            {
                series.Points.AddXY(item.Society, item.Count);
            }

            chartStudentsPerSociety.Series.Add(series);
        }

        private void LoadRecentActivity()
        {
            lstActivity.Items.Clear();

            MembershipDL mDL = new MembershipDL();
            FeedbackDL fDL = new FeedbackDL();

            var memberships = mDL.GetAll()
                .OrderByDescending(m => m.JoinDate)
                .Take(3);

            foreach (var m in memberships)
            {
                lstActivity.Items.Add(
                    "🟢 " + m.Student.Name + " joined " + m.Society.Name
                );
            }

            var feedbacks = fDL.GetAll()
                .OrderByDescending(f => f.SubmittedAt)
                .Take(3);

            foreach (var f in feedbacks)
            {
                lstActivity.Items.Add(
                    "⭐ Feedback by " + f.Student.Name + " (" + f.Rating + "/5)"
                );
            }
        }

        private void SetupChart()
        {

            chartTopSocieties.Series.Clear();
            chartTopSocieties.ChartAreas.Clear();

            chartTopSocieties.ChartAreas.Add(new ChartArea());

            Series series = new Series("TopSocieties"); 

            series.ChartType = SeriesChartType.Bar;
            series.IsValueShownAsLabel = true;
            series.Color = Color.MediumPurple;
            chartTopSocieties.Series.Add(series);
        }

        private void LoadTopSocieties()
        {
            chartTopSocieties.Series[0].Points.Clear();

            MembershipDL mDL = new MembershipDL();
            SocietyDL sDL = new SocietyDL();

            var memberships = mDL.GetAll();
            var societies = sDL.GetAll();

            foreach (var s in societies)
            {
                int count = 0;

                foreach (var m in memberships)
                {
                    if (m.Society != null && m.Society.Id == s.Id)
                    {
                        count++;
                    }
                }

                chartTopSocieties.Series[0].Points.AddXY(s.Name, count);
            }

            chartTopSocieties.Refresh();
        }

        private void StyleChart()
{

    chartTopSocieties.Series[0].Color = Color.MediumPurple;

    chartTopSocieties.ChartAreas[0].BackColor = Color.White;

    chartTopSocieties.Titles.Add("Top Societies");

    chartTopSocieties.Series[0].IsValueShownAsLabel = true;
}
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
