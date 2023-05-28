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
    public partial class ProductForm : Form
    {
        Product tempProduct;
        BindingList<Part> tempPartList;
        public Product TempProduct 
        {
            get { return tempProduct; }
        }

        public ProductForm(BindingList<Part> parts)
        {
            InitializeComponent();
            allParts.DataSource = parts;
            tempPartList = new BindingList<Part>();
            associatedParts.DataSource = tempPartList;
        }

        public ProductForm(BindingList<Part> parts, Product editProduct)
        {
            tempProduct = editProduct;
            InitializeComponent();
            allParts.DataSource = parts;
            tempPartList = editProduct.AssociatedParts;
            associatedParts.DataSource = tempPartList;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if(tempProduct == null)
            {
                windowName.Text = "Add product";
            }
            
            else if(tempProduct != null)
            {
                windowName.Text = "Eddit product";

                productId.Text = tempProduct.ProductId.ToString();
                name.Text = tempProduct.Name;
                inventory.Text = tempProduct.InStock.ToString();
                price.Text = tempProduct.Price.ToString();
                label.Text = tempProduct.Min.ToString();
                max.Text = tempProduct.Max.ToString();
                min.Text = tempProduct.Min.ToString();
                associatedParts.DataSource = tempProduct.AssociatedParts;
            }
            associatedParts.ClearSelection();
            allParts.ClearSelection();
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String  newName = name.Text;
            Decimal newPrice;
            int newInventory, newMin, newMax;

            if (String.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Please enter a valid name");
                return;
            }
            if(!decimal.TryParse(price.Text, out newPrice))
            {
                MessageBox.Show("Please enter a valid price");
                return;
            }
            if (!int.TryParse(inventory.Text, out newInventory))
            {
                MessageBox.Show("Please enter a valid inventory count");
                return;
            }
            if (!int.TryParse(min.Text, out newMin))
            {
                MessageBox.Show("Please enter a valid minimum");
                return;
            }
            if (!int.TryParse(max.Text, out newMax))
            {
                MessageBox.Show("Please enter a valid max");
                return;
            }
            if (newMin > newMax)
            {
                MessageBox.Show("Please be sure that the minimum is less than the maximum");
                return;
            }
            if (newInventory < newMin || newInventory > newMax)
            {
                MessageBox.Show("Plase be sure that inventory is between min and max");
                return;
            }


            if(tempProduct == null)
            {
                tempProduct = new Product(0, newName, newPrice, newInventory, newMin, newMax);
                tempProduct.AssociatedParts = tempPartList;
            }
            else if(tempProduct != null)
            {
                tempProduct.Name = newName;
                tempProduct.Price = newPrice;
                tempProduct.InStock = newInventory;
                tempProduct.Min = newMin;
                tempProduct.Max = newMax;
                tempProduct.AssociatedParts = tempPartList;
            }
            Close();
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            Part selected = allParts.CurrentRow.DataBoundItem as Part;
            if (selected == null || !allParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part");
                return;
            }
            tempPartList.Add(selected);
            associatedParts.ClearSelection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Part selected = associatedParts.CurrentRow.DataBoundItem as Part;
            if (selected == null || !associatedParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part");
                return;
            }
            var option = MessageBox.Show("Are you sure you want to delete this part?", "Delete?", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                tempPartList.Remove(selected);
            } 
        }

        private void partSearch_Click(object sender, EventArgs e)
        {
            String search = partSearchBar.Text.ToLower();
            if (search != null)
            {
                foreach (DataGridViewRow row in allParts.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Equals(search))
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                    allParts.ClearSelection();
                    }

                }
                
            }
            else
            {
                allParts.ClearSelection();
            }
        }
    }
}
