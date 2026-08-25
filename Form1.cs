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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void MenuHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(91, 33, 182); 
            btn.ForeColor = Color.White;
        }

        private void MenuLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        public void LoadPage(UserControl uc)
        {
            FadeOut(pnlMain, uc);
        }
        private void FadeOut(Panel panel, UserControl newPage)
        {
            Timer t = new Timer();
            t.Interval = 20;

            t.Tick += delegate
            {
                if (panel.BackColor.A > 30)
                {
                    panel.BackColor = Color.FromArgb(
                        panel.BackColor.A - 15,
                        panel.BackColor.R,
                        panel.BackColor.G,
                        panel.BackColor.B
                    );
                }
                else
                {
                    t.Stop();
                    panel.Controls.Clear();
                    FadeIn(newPage);
                }
            };

            t.Start();
        }

        private void FadeIn(UserControl newPage)
        {
            newPage.Dock = DockStyle.Fill;
            newPage.Visible = true;

            pnlMain.Controls.Add(newPage);

            Timer t = new Timer();
            t.Interval = 30;

            t.Tick += delegate
            {
                if (newPage.BackColor.A < 255)
                {
                    newPage.BackColor = Color.FromArgb(
                        newPage.BackColor.A + 15,
                        newPage.BackColor.R,
                        newPage.BackColor.G,
                        newPage.BackColor.B
                    );
                }
                else
                {
                    t.Stop();
                }
            };

            t.Start();
        }

        private void btnSocieties(object sender, EventArgs e)
        {
            LoadPage(new SocietyForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new Dashboard());
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            LoadPage(new EventsForm());
        }

        private void btnVenues_Click(object sender, EventArgs e)
        {
            LoadPage(new VenueForm());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            LoadPage(new StudentsForm());
        }

        private void btnRegiatrations_Click(object sender, EventArgs e)
        {
            LoadPage(new RegistrationsForm());
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            LoadPage(new AnnouncementsForm());
        }
        private void btnSponsors_Click(object sender, EventArgs e)
        {
            LoadPage(new SponsorsForm());
        }

        private void btnSponsorship_Click(object sender, EventArgs e)
        {
            LoadPage(new SponsorshipsForm());
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            LoadPage(new MembershipForm());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            LoadPage(new FeedbackForm());
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadPage(new Reports());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to exit?",
        "Exit",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
