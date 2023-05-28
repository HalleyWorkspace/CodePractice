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
    public partial class ApointmentForm : Form
    {
        private scheduleObject apointment;
        public ApointmentForm()
        {
            InitializeComponent();
            apointmentView.AutoGenerateColumns = false;
            consultantSelect.DataSource = DatabaseAccess.getConsultants();
            apointmentView.DataSource = DatabaseAccess.getCustomers();
            consultantSelect.DisplayMember = "consultantName";
            apointmentDate.CustomFormat = "MM/dd/yyyy hh:mm";
            apointmentView.Columns["customerId"].DataPropertyName = "customerId";
            apointmentView.Columns["customerName"].DataPropertyName = "customerName";
            apointmentView.Columns["address"].DataPropertyName = "address";
            apointmentView.Columns["city"].DataPropertyName = "city";
            apointmentView.Columns["country"].DataPropertyName = "country";
            apointmentView.Columns["postalCode"].DataPropertyName = "postalCode";
            apointmentView.Columns["phone"].DataPropertyName = "phoneNumber";
            apointmentDate.Value = DateTime.Now;
            apointmentTime.Value = DateTime.Now;

            apointment = null;


        }

        public ApointmentForm(scheduleObject oldApointment)
        {
            InitializeComponent();
            apointmentView.AutoGenerateColumns = false;
            consultantSelect.DataSource = DatabaseAccess.getConsultants();
            apointmentView.DataSource = DatabaseAccess.getCustomers();
            consultantSelect.DisplayMember = "consultantName";
            apointmentDate.CustomFormat = "MM/dd/yyyy hh:mm";
            apointmentView.Columns["customerId"].DataPropertyName = "customerId";
            apointmentView.Columns["customerName"].DataPropertyName = "customerName";
            apointmentView.Columns["address"].DataPropertyName = "address";
            apointmentView.Columns["city"].DataPropertyName = "city";
            apointmentView.Columns["country"].DataPropertyName = "country";
            apointmentView.Columns["postalCode"].DataPropertyName = "postalCode";
            apointmentView.Columns["phone"].DataPropertyName = "phoneNumber";

            apointment = oldApointment;
            
            consultantSelect.SelectedIndex = consultantSelect.Items.IndexOf(consultantSelect.Items.OfType<consultantObject>().Single(x => x.consultantId == oldApointment.consultantId));
            typeBox.Text = oldApointment.type;
            apointmentDate.Value = oldApointment.date;
            apointmentTime.Value = oldApointment.date;
            apointmentView.CurrentCell = apointmentView.Rows.OfType<DataGridViewRow>().Single(x => (x.DataBoundItem as customerObject).customerID == apointment.customerID).Cells[0];

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(apointmentDate.Value.DayOfWeek == DayOfWeek.Saturday || apointmentDate.Value.DayOfWeek == DayOfWeek.Sunday)
                    throw new DayException();


                TimeSpan open = new TimeSpan(8, 0, 0);
                TimeSpan close = new TimeSpan(17, 0, 0);
                if (apointmentTime.Value.TimeOfDay < open || apointmentTime.Value.TimeOfDay > close)
                    throw new TimeException();


            }
            catch(DayException exception)
            {
                exception.InvalidDayException();
                return;
            }
            catch(TimeException exception)
            {
                exception.InvalidTimeException();
                return;
            }

            if(typeBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter the type of meeting to be scheduled");
                return;
            }

            if (apointment == null)
            {
                apointment = new scheduleObject()
                {
                    apointmentID = -1,
                    type = typeBox.Text,
                    consultantId = (consultantSelect.SelectedItem as consultantObject).consultantId,
                    consultantName = (consultantSelect.SelectedItem as consultantObject).consultantName,
                    customerID = (apointmentView.CurrentRow.DataBoundItem as customerObject).customerID,
                    customerName = (apointmentView.CurrentRow.DataBoundItem as customerObject).customerName,
                    date = apointmentDate.Value.Date.Add(apointmentTime.Value.TimeOfDay)
                };
                if (!DatabaseAccess.addAppointment(apointment))
                {
                    MessageBox.Show("Overlapping apointments scheduled");
                    return;
                }
            }

            else
            {
                apointment.type = typeBox.Text;
                apointment.consultantId = (consultantSelect.SelectedItem as consultantObject).consultantId;
                apointment.consultantName = (consultantSelect.SelectedItem as consultantObject).consultantName;
                apointment.customerID = (apointmentView.CurrentRow.DataBoundItem as customerObject).customerID;
                apointment.customerName = (apointmentView.CurrentRow.DataBoundItem as customerObject).customerName;
                apointment.date = apointmentDate.Value.Date.Add(apointmentTime.Value.TimeOfDay);

                if (!DatabaseAccess.updateApointment(apointment))
                {
                    MessageBox.Show("Overlapping apointments scheduled");
                    return;
                }

            }
            
            this.Close();

            //check for time conflicts

        }

        private void ApointmentForm_Load(object sender, EventArgs e)
        {
            
        }
    }

    class DayException : Exception
    {

        public DayException() { }

        public void InvalidDayException()
        {
            MessageBox.Show("Apointments only available Monday through Friday");
        }
        
    }

    class TimeException : Exception
    {
        public TimeException() { }

        public void InvalidTimeException()
        {
            MessageBox.Show("Valid Hours for an apointment are from 8:00 AM to 5 PM local time");
        }
    }

}
