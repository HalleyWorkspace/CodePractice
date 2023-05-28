using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApp.dataControl;

namespace ScheduleApp
{
    public partial class CustomerForm : Form
    {
        private customerObject editCustomer;
        public CustomerForm()
        {
            InitializeComponent();
            editCustomer= null;
            addEditLabel.Text = "Add";
        }

        public CustomerForm(customerObject customer)
        {
            InitializeComponent();
            editCustomer = customer;
            nameBox.Text = customer.customerName;
            phoneNumberBox.Text = customer.phoneNumber;
            addressBox.Text = customer.address;
            postalCodeBox.Text = customer.postalCode;
            cityBox.Text = customer.city;
            countryBox.Text = customer.country;
            addEditLabel.Text = "Edit";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Regex postalReg = new Regex("^[0-9]{5}$");
            Regex phoneReg = new Regex("^[0-9]{3}-[0-9]{4}$");

            if (nameBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter the customers name");
                return;
            }
            if (phoneNumberBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter the customers phone number");
                return;
            }
            if (addressBox.Text.Equals(string.Empty) 
                || postalCodeBox.Text.Equals(string.Empty)
                || cityBox.Text.Equals(string.Empty)
                || countryBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter the customers full address");
                return;
            }
            if (!postalReg.IsMatch(postalCodeBox.Text))
            {
                MessageBox.Show("Please enter a 5 digit Postal Code");
                return;
            }
            if (!phoneReg.IsMatch(phoneNumberBox.Text))
            {
                MessageBox.Show("Please enter a phone number with the format: ###-####");
                return;
            }


            if (editCustomer == null) {
                customerObject newCustomer = new customerObject()
                {
                    customerID = -1,
                    customerName = nameBox.Text,
                    phoneNumber = phoneNumberBox.Text,
                    address = addressBox.Text,
                    postalCode = postalCodeBox.Text,
                    city = cityBox.Text,
                    country = countryBox.Text
                };
                DatabaseAccess.addCutomer(newCustomer);
            }

            else
            {
                editCustomer.customerName = nameBox.Text;
                editCustomer.phoneNumber = phoneNumberBox.Text;
                editCustomer.address = addressBox.Text;
                editCustomer.postalCode = postalCodeBox.Text;
                editCustomer.city = cityBox.Text;
                editCustomer.country = countryBox.Text;
                DatabaseAccess.updateCustomer(editCustomer);
            }


            this.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
