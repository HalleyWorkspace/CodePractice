using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThomasHalleyC968Project
{
    public partial class PartForm : Form
    {
        Part tempPart;
        InHousePart tempInhouse;
        OutsourcedPart tempOutsourced;

        public Part TempPart
        {
            get { return tempPart; }
        }

        public PartForm()
        {
            InitializeComponent();
        }

        public PartForm(Part editPart)
        {
            tempPart = editPart;
            if(tempPart is InHousePart)
            {
                tempInhouse = (InHousePart)tempPart;
            }
            else if (tempPart is OutsourcedPart)
            {
                tempOutsourced = (OutsourcedPart)tempPart;
            }
            InitializeComponent();
        }


        private void save_Click(object sender, EventArgs e)
        {
            String newName = textName.Text;
            decimal newPrice;
            int newInventory;
            int newMin;
            int newMax;

            if (String.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Please enter a valid part name");
                return;
            }
            if(!decimal.TryParse(textPrice.Text, out newPrice))
            {
               MessageBox.Show("Please enter a valid price");
                return;
            }
            if(!int.TryParse(textInventory.Text, out newInventory))
            {
                MessageBox.Show("Please enter a valid inventory count");
                return;
            }
            if(!int.TryParse(textMin.Text, out newMin))
            {
                MessageBox.Show("Please enter a valid minimum");
                return;
            }
            if(!int.TryParse(textMax.Text, out newMax))
            {
                MessageBox.Show("Please enter a valid max");
                return;
            }
            if(newMin > newMax)
            {
                MessageBox.Show("Please be sure that the minimum is less than the maximum");
                return;
            }
            if(newInventory < newMin || newInventory > newMax)
            {
                MessageBox.Show("Plase be sure that inventory is between min and max");
                return;
            }

            if(tempPart == null)
            {
                if (inhouse.Checked == true)
                {
                    int newMachineId;
                    if(!int.TryParse(textChange.Text, out newMachineId))
                    {
                        MessageBox.Show("Please enter a valid MachineID");
                        return;
                    }
                    tempPart = new InHousePart(0,newName, newPrice, newInventory, newMin, newMax, newMachineId);
                }
                else if(outsourced.Checked == true)
                {
                    String newBuisness = textChange.Text;
                    if (String.IsNullOrEmpty(newBuisness))
                    {
                        MessageBox.Show("Please enter a valid company name");
                        return;
                    }
                    tempPart = new OutsourcedPart(0, newName, newPrice, newInventory, newMin, newMax, newBuisness);
                }
            }

            else if(tempInhouse != null)
            {
                if(inhouse.Checked == true)
                {
                    int newMachineId;
                    if (!int.TryParse(textChange.Text, out newMachineId))
                    {
                        MessageBox.Show("Please enter a valid MachineID");
                        return;
                    }

                    tempInhouse.Name = newName;
                    tempInhouse.Price = newPrice;
                    tempInhouse.InStock = newInventory;
                    tempInhouse.Max = newMax;
                    tempInhouse.Min = newMin;
                    tempInhouse.MachineID = newMachineId;
                    tempPart = tempInhouse;
                }
                else if(outsourced.Checked == true)
                {
                    string newCompany = textChange.Text;
                    if (String.IsNullOrEmpty(newCompany))
                    {
                        MessageBox.Show("Please enter a valid company name");
                        return;
                    }
                    tempOutsourced = new OutsourcedPart(tempInhouse.PartId, newName, newPrice, newInventory, newMin, newMax, newCompany);
                    tempPart = tempOutsourced;
                }
            }
            else if(tempOutsourced != null)
            {
                if (outsourced.Checked == true)
                {
                    string newCompany = textChange.Text;
                    if (String.IsNullOrEmpty(newCompany))
                    {
                        MessageBox.Show("Please enter a valid company name");
                        return;
                    }

                    tempOutsourced.Name = newName;
                    tempOutsourced.Price = newPrice;
                    tempOutsourced.InStock = newInventory;
                    tempOutsourced.Max = newMax;
                    tempOutsourced.Min = newMin;
                    tempOutsourced.CompanyName = newCompany;
                    tempPart = tempOutsourced;
                }
                else if (inhouse.Checked == true)
                { 
                    int newMachineId;
                    if (!int.TryParse(textChange.Text, out newMachineId))
                    {
                        MessageBox.Show("Please enter a valid MachineID");
                        return;
                    }
                    
                    tempInhouse = new InHousePart(tempOutsourced.PartId, newName, newPrice, newInventory, newMin, newMax, newMachineId);
                    tempPart = tempInhouse;
                }
            }
            
            Close();
        }

        private void inhouse_CheckedChanged(object sender, EventArgs e)
        {
            if(inhouse.Checked == true)
            {
                changeField.Text = "Machine ID";
            }
            if(outsourced.Checked == true)
            {
                changeField.Text = "Company Name";
            }
        }

        private void PartForm_Load(object sender, EventArgs e)
        {
            if (tempPart == null)
            {
                windowName.Text = "Add Part";
            }

            else if (tempInhouse != null)
            {
                windowName.Text = "Eddit Part";

                textID.Text = tempInhouse.PartId.ToString();
                textName.Text = tempInhouse.Name;
                textInventory.Text = tempInhouse.InStock.ToString();
                textPrice.Text = tempInhouse.Price.ToString();
                textMax.Text = tempInhouse.Max.ToString();
                textMin.Text = tempInhouse.Min.ToString();
                textChange.Text = tempInhouse.MachineID.ToString();
            }

            else if (tempOutsourced != null)
            {
                windowName.Text = "Eddit Part";

                textID.Text = tempOutsourced.PartId.ToString();
                textName.Text = tempOutsourced.Name;
                textInventory.Text = tempOutsourced.InStock.ToString();
                textPrice.Text = tempOutsourced.Price.ToString();
                textMax.Text = tempOutsourced.Max.ToString();
                textMin.Text = tempOutsourced.Min.ToString();
                textChange.Text = tempOutsourced.CompanyName;
                outsourced.Checked = true;
            }
            else { }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
