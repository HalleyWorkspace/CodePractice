using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApp.dataControl;



namespace ScheduleApp
{
    public partial class Schedule : Form
    {
        private DateTime startDate;
        private List<scheduleObject> defaultSchedule, dateFiltered, searchFiltered;
        public Schedule()
        {
            InitializeComponent();
            scheduleView.AutoGenerateColumns = false;
            scheduleView.Columns["apointmentId"].DataPropertyName = "apointmentId";
            scheduleView.Columns["date"].DataPropertyName = "date";
            scheduleView.Columns["customerName"].DataPropertyName = "customerName";
            scheduleView.Columns["consultantName"].DataPropertyName = "consultantName";
            scheduleView.Columns["type"].DataPropertyName = "type";
            next.Enabled = false;
            previous.Enabled = false;
            defaultSchedule = DatabaseAccess.getSchedule();
            clearSchedule();
            scheduleView.ClearSelection();
            ScheduleFormatSelector.SelectedItem = "None";
            
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            
            
        }

        private DateTime getStartOfWeek(DateTime date)
        {
            DateTime startOfWeek = date;
            while (startOfWeek.DayOfWeek != DayOfWeek.Sunday)
                startOfWeek = startOfWeek.AddDays(-1);
            return startDate = startOfWeek;
        }

        private DateTime getStartOfMonth(DateTime date)
        {
            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);

            return startDate = startOfMonth;
        }

        private void setSchedule(DateTime startDate, int numberOfDays)
        {
            dateRange.Text = startDate.ToString("MM/dd/yyyy") + " - " + startDate.AddDays(numberOfDays-1).ToString("MM/dd/yyyy");
            dateFiltered = DatabaseAccess.getSchedule(startDate, startDate.AddDays(numberOfDays));
            scheduleView.DataSource = dateFiltered;
            scheduleView.Refresh();
        }

        private void clearSchedule()
        {
            dateRange.Text = "";
            scheduleView.DataSource = defaultSchedule;
            scheduleView.Refresh();
            
        }

        private void ScheduleFormatSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ScheduleFormatSelector.Text == "Week")
            {
                setSchedule(getStartOfWeek(DateTime.Now), 7);
                next.Enabled = true;
                previous.Enabled = true;
            }
            else if (ScheduleFormatSelector.Text == "Month")
            { 
                setSchedule(getStartOfMonth(DateTime.Now), DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                next.Enabled = true;
                previous.Enabled = true;
            }
            else if (ScheduleFormatSelector.Text == "None")
            {
                clearSchedule();
                next.Enabled = false;
                previous.Enabled = false;
            }

            scheduleView.Update();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ApointmentForm apointmentForm = new ApointmentForm();
            this.Hide();
            apointmentForm.ShowDialog();
            defaultSchedule = DatabaseAccess.getSchedule();
            clearSchedule();
            this.Show();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if(ScheduleFormatSelector.Text == "Week")
            {
                startDate = startDate.AddDays(-7);
                setSchedule(startDate, 7);
            }
            else if(ScheduleFormatSelector.Text == "Month")
            {
                startDate = startDate.AddMonths(-1);
                setSchedule(startDate, DateTime.DaysInMonth(startDate.Year, startDate.Month));
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(ScheduleFormatSelector.Text == "Week")
            {
                startDate = startDate.AddDays(7);
                setSchedule(startDate, 7);
            }
            else if (ScheduleFormatSelector.Text == "Month")
            {
                startDate = startDate.AddMonths(1);
                setSchedule(startDate, DateTime.DaysInMonth(startDate.Year, startDate.Month));
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewCustomer viewCustomer = new ViewCustomer((scheduleView.CurrentRow.DataBoundItem as scheduleObject).customerID);
            this.Hide();
            viewCustomer.ShowDialog();
            this.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ApointmentForm apointmentForm = new ApointmentForm((scheduleView.CurrentRow.DataBoundItem as scheduleObject));
            this.Hide();
            apointmentForm.ShowDialog();
            this.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess.deleteAppointment(scheduleView.CurrentRow.DataBoundItem as scheduleObject);
            defaultSchedule = DatabaseAccess.getSchedule();

            if (ScheduleFormatSelector.Text == "None")
                clearSchedule();
            else if (ScheduleFormatSelector.Text == "Week")
                setSchedule(startDate, 7);
            else if (ScheduleFormatSelector.Text == "Month")
                setSchedule(startDate, DateTime.DaysInMonth(startDate.Year, startDate.Month));
            
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            search_bar.Text = "";
            if (ScheduleFormatSelector.Text == "None")
                scheduleView.DataSource = defaultSchedule;
            else if (ScheduleFormatSelector.Text == "Week" || ScheduleFormatSelector.Text == "Month")
                scheduleView.DataSource = dateFiltered;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if(ScheduleFormatSelector.Text == "None")
            {
                searchFiltered = defaultSchedule.Where(x => x.customerName.ToLower().Contains(search_bar.Text.ToLower())).ToList();
            }
            else if(ScheduleFormatSelector.Text == "Week" || ScheduleFormatSelector.Text == "Month")
            {
                searchFiltered = dateFiltered.Where(x => x.customerName.ToLower().Contains(search_bar.Text.ToLower())).ToList();
            }
            scheduleView.DataSource = searchFiltered;
        }
    }
}
