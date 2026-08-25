using DB_Final.BL;
using DB_Final.DL;
using DB_Final.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Final
{
    public partial class EventsForm : UserControl
    {
        private Event selectedEvent = null;
        public EventsForm()
        {
            InitializeComponent();
            LoadEvents();
            UpdateTotalEvents();
            UpdateUpcomingEvents();
        }
        private void LoadEvents()
        {
            flpEvents.Controls.Clear();

            EventDL dl = new EventDL();

            foreach (Event ev in dl.GetAll())
            {
                flpEvents.Controls.Add(CreateEventCard(ev));
            }
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new AddEvent());
        }

        private Panel CreateEventCard(Event ev)
        {
            Panel card = new Panel();
            card.Width = 260;
            card.Height = 280;
            card.BackColor = Color.White;
            card.Margin = new Padding(12);
            card.BorderStyle = BorderStyle.FixedSingle;

            Panel header = new Panel();
            header.Height = 80;
            header.Dock = DockStyle.Top;
            header.BackColor = Color.FromArgb(111, 66, 193);

            Label lblInitials = new Label();
            lblInitials.Text = GetInitials(ev.Title);
            lblInitials.ForeColor = Color.White;
            lblInitials.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblInitials.Dock = DockStyle.Fill;
            lblInitials.TextAlign = ContentAlignment.MiddleCenter;
            header.Controls.Add(lblInitials);
            card.Controls.Add(header);

            Label lblTitle = new Label();
            lblTitle.Text = ev.Title;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(15, 90);
            lblTitle.Size = new Size(230, 20); 
            card.Controls.Add(lblTitle);

            Label lblSociety = new Label();
            lblSociety.Text = ev.Society != null ? ev.Society.Name : "General";
            lblSociety.Font = new Font("Segoe UI", 9);
            lblSociety.ForeColor = Color.Gray;
            lblSociety.Location = new Point(15, 115);
            lblSociety.Size = new Size(230, 18);
            card.Controls.Add(lblSociety);

            Label lblDate = new Label();
            lblDate.Text = ev.EventDateTime.ToString("dd MMM yyyy hh:mm tt");
            lblDate.Font = new Font("Segoe UI", 8.5f);
            lblDate.ForeColor = Color.DarkGray;
            lblDate.Location = new Point(15, 135);
            lblDate.Size = new Size(230, 18);
            card.Controls.Add(lblDate);

            Label lblVenue = new Label();
            lblVenue.Text = ev.Venue != null ? ev.Venue.Name : "TBD";
            lblVenue.Font = new Font("Segoe UI", 8.5f);
            lblVenue.ForeColor = Color.DarkGray;
            lblVenue.Location = new Point(15, 155);
            lblVenue.Size = new Size(230, 18);
            card.Controls.Add(lblVenue);

            Label lblCap = new Label();
            lblCap.Text = "0 / " + ev.Capacity + " Registered";
            lblCap.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblCap.Location = new Point(15, 185);
            lblCap.Size = new Size(230, 20);
            lblCap.ForeColor = Color.MidnightBlue;
            card.Controls.Add(lblCap);

            ProgressBar pb = new ProgressBar();
            pb.Location = new Point(15, 205);
            pb.Width = 225;
            pb.Height = 10;
            card.Controls.Add(pb);

            Button btnView = new Button();
            btnView.Text = "View Details";
            btnView.BackColor = Color.FromArgb(111, 66, 193);
            btnView.ForeColor = Color.White;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnView.Size = new Size(130, 32);
            btnView.Location = new Point((card.Width - btnView.Width) / 2, 230);
            card.Controls.Add(btnView);

            card.Tag = ev;
            card.Click += Card_Click;
            btnView.Click += Card_Click;
            btnView.Tag = ev;
            btnView.Click += BtnView_Click;

            foreach (Control c in card.Controls)
            {
                c.Click += Card_Click;
                c.MouseEnter += Card_MouseEnter;
                c.MouseLeave += Card_MouseLeave;
            }

            return card;
        }
        private string GetInitials(string text)
        {
            string result = "";
            string[] words = text.Split(' ');
            foreach (string s in words)
                if (!string.IsNullOrEmpty(s)) result += s[0];
            return result.ToUpper();
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            Panel parentCard = ctrl is Panel ? (Panel)ctrl : (Panel)ctrl.Parent;
            parentCard.BackColor = Color.FromArgb(245, 245, 255);
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            Panel parentCard = ctrl is Panel ? (Panel)ctrl : (Panel)ctrl.Parent;
            parentCard.BackColor = Color.White;
        }
        private void Card_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;

            Panel card = c as Panel;

            if (card == null)
                card = c.Parent as Panel;

            if (card != null)
                selectedEvent = (Event)card.Tag;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flpEvents.Controls.Clear();
            EventDL dl = new EventDL();
            List<Event> events = dl.GetAll();
            string keyword = txtSearch.Text.Trim().ToLower();

            foreach (Event ev in events)
            {
                if (string.IsNullOrWhiteSpace(keyword) ||
                    ev.Title.ToLower().Contains(keyword) ||
                    (ev.Society != null && ev.Society.Name.ToLower().Contains(keyword)) ||
                    (ev.Category != null && ev.Category.Name.ToLower().Contains(keyword)) ||
                    (ev.Venue != null && ev.Venue.Name.ToLower().Contains(keyword)))
                {
                    flpEvents.Controls.Add(CreateEventCard(ev));
                }
            }
        }

        private void UpdateTotalEvents()
        {
            EventDL dl = new EventDL();
            int totalEvents = dl.GetAll().Count;
            lblTotalEvents.Text = totalEvents.ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedEvent == null)
            {
                MessageBox.Show("Select an event first.");
                return;
            }

            DialogResult result = MessageBox.Show( "Do you want to edit " + selectedEvent.Title + "?",
                "Confirm Edit",MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            AddEvent add = new AddEvent();
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(add);
            add.LoadEventData(selectedEvent);
        }

        private void UpdateUpcomingEvents()
        {
            EventDL dl = new EventDL();

            List<Event> events = dl.GetAll();

            int upcomingCount = 0;

            foreach (Event ev in events)
            {
                if (ev.EventDateTime >= DateTime.Now)
                {
                    upcomingCount++;
                }
            }

            lblUpcomingEvents.Text = upcomingCount.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEvent == null)
            {
                MessageBox.Show("Select an event first.");
                return;
            }

            DialogResult result = MessageBox.Show( "Do you want to delete " + selectedEvent.Title + "?",
                "Confirm Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            try
            {
                EventDL dl = new EventDL();
                dl.Delete(selectedEvent.Id);
                MessageBox.Show("Event deleted successfully!");
                selectedEvent = null;
                LoadEvents();
                UpdateTotalEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllEvents_Click(object sender, EventArgs e)
        {
            flpEvents.Controls.Clear();
            EventDL dl = new EventDL();
            List<Event> events = dl.GetAll();
            foreach (Event ev in events)
            {
                flpEvents.Controls.Add(CreateEventCard(ev));
            }
        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            flpEvents.Controls.Clear();

            EventDL dl = new EventDL();
            List<Event> events = dl.GetAll();

            foreach (Event ev in events)
            {
                if (ev.EventDateTime >= DateTime.Now)
                {
                    flpEvents.Controls.Add(CreateEventCard(ev));
                }
            }
        }
        private void btnPastEvents_Click(object sender, EventArgs e)
        {
            flpEvents.Controls.Clear();
            EventDL dl = new EventDL();
            List<Event> events = dl.GetAll();

            foreach (Event ev in events)
            {
                if (ev.EventDateTime < DateTime.Now)
                {
                    flpEvents.Controls.Add(CreateEventCard(ev));
                }
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Event ev = (Event)btn.Tag;
            EventDetailsForm details = new EventDetailsForm();
            details.LoadEventData(ev);

            Form1 main = (Form1)this.FindForm();
            main.LoadPage(details);
        }

    }
}