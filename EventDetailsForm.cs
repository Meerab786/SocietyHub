using DB_Final.BL;
using DB_Final.DL;
using DB_Final.Events;
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
    public partial class EventDetailsForm : UserControl
    {
        private Event currentEvent;
        public EventDetailsForm()
        {
            InitializeComponent();
        }

        public void LoadEventData(Event e)
        {
            lblTitle.Text = e.Title;
            rtbDescription.Text = e.Description;
            lblStatus.Text = e.Status;
            lblEventIdValue.Text = e.Id.ToString();
            lblStatusValue.Text = e.Status.ToUpper();

            if (e.Status.ToLower() == "active")
            {
                lblStatusValue.BackColor = Color.MediumSeaGreen;
                lblStatusValue.ForeColor = Color.White;
            }
            else if (e.Status.ToLower() == "inactive")
            {
                lblStatusValue.BackColor = Color.IndianRed;
                lblStatusValue.ForeColor = Color.White;
            }
            else
            {
                lblStatusValue.BackColor = Color.MediumPurple;
                lblStatusValue.ForeColor = Color.White;
            }
            string initials = "";

            foreach (string word in e.Title.Split(' '))
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    initials += word[0];
                }
            }
            lblInitials.Text = initials.ToUpper();
            lblDate.Text = e.EventDateTime.ToString("dd MMM yyyy hh:mm tt");
            lblCapacity.Text = e.Capacity.ToString();
            lblVenue.Text = e.Venue != null ? e.Venue.Name : "No Venue";
            lblSociety.Text = e.Society != null ? e.Society.Name : "No Society";
            lblCategory.Text = e.Category != null ? e.Category.Name : "No Category";

            currentEvent = e;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new EventsForm());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddEvent add = new AddEvent();

            Form1 main = (Form1)this.FindForm();

            main.LoadPage(add);

            add.LoadEventData(currentEvent);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete " + currentEvent.Title + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            EventDL dl = new EventDL();
            dl.Delete(currentEvent.Id);
            MessageBox.Show("Event deleted successfully!");
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new EventsForm());
        }

        private void btnManageRegistrations_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            RegistrationsForm form = new RegistrationsForm(currentEvent.Id);
            main.LoadPage(form);
        }
    }
}
