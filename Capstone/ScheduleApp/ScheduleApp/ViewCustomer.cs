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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        public ViewCustomer(int customerId)
        {
            InitializeComponent();
            customerObject customer = DatabaseAccess.getCustomer(customerId);
            id.Text = customer.customerID.ToString();
            name.Text = customer.customerName;
            address.Text = customer.address;
            city.Text = customer.city;
            country.Text = customer.country;
            phoneNumber.Text = customer.phoneNumber;
            postal.Text = customer.postalCode;
        }
    }
}
