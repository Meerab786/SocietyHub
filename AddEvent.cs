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

namespace DB_Final.Events
{
    public partial class AddEvent : UserControl
    {
        private Event editEvent = null;

        public AddEvent()
        {
            InitializeComponent();
            LoadSocieties();
            LoadVenues();
            LoadCategories();
            this.DoubleBuffered = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Enter Event Title.");
                    return;
                }

                if (cmbSociety.SelectedItem == null)
                {
                    MessageBox.Show("Select a Society.");
                    return;
                }

                if (cmbVenue.SelectedItem == null)
                {
                    MessageBox.Show("Select a Venue.");
                    return;
                }

                if (cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Select a Category.");
                    return;
                }

                Society society =  (Society)cmbSociety.SelectedItem;
                Venue venue =  (Venue)cmbVenue.SelectedItem;
                EventCategory category = (EventCategory)cmbCategory.SelectedItem;
                EventDL dl = new EventDL();

                if (editEvent == null)
                {
                    Event ev = new Event(
                        cmbStatus.Text,
                        txtDescription.Text,
                        Convert.ToInt32(numCapacity.Text),
                        txtTitle.Text,
                        dtpEventDate.Value,
                        (Society)cmbSociety.SelectedItem,
                        (Venue)cmbVenue.SelectedItem,
                        (EventCategory)cmbCategory.SelectedItem
                    );

                    dl.Insert(ev);

                    MessageBox.Show("Event Added Successfully!");
                }
                else
                {
                    Event ev = new Event(
                        editEvent.Id,
                        cmbStatus.Text,
                        txtDescription.Text,
                        Convert.ToInt32(numCapacity.Text),
                        txtTitle.Text,
                        dtpEventDate.Value,
                        (Society)cmbSociety.SelectedItem,
                        (Venue)cmbVenue.SelectedItem,
                        (EventCategory)cmbCategory.SelectedItem
                    );

                    dl.Update(ev);

                    MessageBox.Show("Event Updated Successfully!");
                }
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            txtTitle.Clear();

            txtDescription.Clear();

            numCapacity.Value = 1;

            cmbStatus.SelectedIndex = -1;

            cmbSociety.SelectedIndex = -1;

            cmbVenue.SelectedIndex = -1;

            cmbCategory.SelectedIndex = -1;

            dtpEventDate.Value = DateTime.Now;
        }

        private void LoadSocieties()
        {
            SocietyDL dl = new SocietyDL();

            cmbSociety.DataSource = dl.GetAll();

            cmbSociety.DisplayMember = "Name";

            cmbSociety.ValueMember = "Id";
        }

        private void LoadVenues()
        {
            VenueDL dl = new VenueDL();

            cmbVenue.DataSource = dl.GetAll();

            cmbVenue.DisplayMember = "Name";

            cmbVenue.ValueMember = "Id";
        }

        private void LoadCategories()
        {
            EventCategoryDL dl = new EventCategoryDL();

            cmbCategory.DataSource = dl.GetAll();

            cmbCategory.DisplayMember = "Name";

            cmbCategory.ValueMember = "Id";
        }

        public void LoadEventData(Event e)
        {
            editEvent = e;

            txtTitle.Text = e.Title;
            txtDescription.Text = e.Description;
            numCapacity.Text = e.Capacity.ToString();

            dtpEventDate.Value = e.EventDateTime;

            cmbStatus.Text = e.Status;

            cmbSociety.SelectedItem = e.Society;

            cmbVenue.SelectedItem = e.Venue;

            cmbCategory.SelectedItem = e.Category;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new EventsForm());
        }
    }
}
