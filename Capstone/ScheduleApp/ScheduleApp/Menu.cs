using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void fullSchduleButton_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();
            schedule.ShowDialog();
            this.Show();
        }

        private void consultantScheduleButton_Click(object sender, EventArgs e)
        {
            ConsultantSelect consultantSelect = new ConsultantSelect();
            this.Hide();
            consultantSelect.ShowDialog();
            this.Show();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            CustomerRecords customerRecords = new CustomerRecords();
            this.Hide();
            customerRecords.ShowDialog();
            this.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.ShowDialog();
            this.Show();
        }
    }
}
