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
    public partial class CustomerRecords : Form
    {
        public CustomerRecords()
        {
            InitializeComponent();
            customerView.AutoGenerateColumns = false;
            customerView.DataSource = DatabaseAccess.getCustomers();
            customerView.Columns["customerId"].DataPropertyName = "customerId";
            customerView.Columns["customerName"].DataPropertyName = "customerName";
            customerView.Columns["address"].DataPropertyName = "address";
            customerView.Columns["city"].DataPropertyName = "city";
            customerView.Columns["country"].DataPropertyName = "country";
            customerView.Columns["postalCode"].DataPropertyName = "postalCode";
            customerView.Columns["phone"].DataPropertyName = "phoneNumber";
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            this.Hide();
            customerForm.ShowDialog();
            customerView.DataSource = DatabaseAccess.getCustomers();
            this.Show();
            
            

        }

        private void CustomerRecords_Load(object sender, EventArgs e)
        {
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(customerView.CurrentRow.DataBoundItem as customerObject);
            this.Hide();
            customerForm.ShowDialog();
            customerView.DataSource = DatabaseAccess.getCustomers();
            this.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess.deleteCustomer(customerView.CurrentRow.DataBoundItem as customerObject);
            customerView.DataSource = DatabaseAccess.getCustomers();
        }
    }
}
