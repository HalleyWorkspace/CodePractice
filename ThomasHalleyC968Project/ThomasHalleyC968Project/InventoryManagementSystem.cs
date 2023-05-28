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
    public partial class InventoryManagementSystem : Form
    {
        Inventory inventory = new Inventory();
        private int partsIndexer = 1;
        private int productsIndexer = 1;
        public InventoryManagementSystem()
        {
            InitializeComponent();


            
            inventory.addPart(new InHousePart(partsIndexer, "Wheel", (decimal)20.11, 15, 10, 30, 115));
            partsIndexer++;
            inventory.addPart(new OutsourcedPart(partsIndexer, "Tire", (decimal)5.25, 20, 5, 50, "Tire Co."));
            partsIndexer++;

            dgParts.DataSource = inventory.AllParts;

            inventory.addProduct(new Product(productsIndexer, "Purple Bike", (decimal)549.99, 10, 1, 42));
            productsIndexer++;
            inventory.addProduct(new Product(productsIndexer, "Red Bike", (decimal)20.24, 15, 1, 84));
            productsIndexer++;
            dgProducts.DataSource = inventory.Products;
        }
        
        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgParts.ClearSelection();
            dgProducts.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            Part selected = dgParts.CurrentRow.DataBoundItem as Part;
            if (selected == null || !dgParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please Make a Selection");
                return;
            }
            var option = MessageBox.Show("Are you sure you want to delete this part?", "Delete?", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            { 
                inventory.deletePart(selected);
            }
            
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            PartForm addPart = new PartForm();
            addPart.ShowDialog();
            if(addPart.TempPart != null)
            {
                addPart.TempPart.PartId = partsIndexer;
                partsIndexer++;
                inventory.addPart(addPart.TempPart);
            }
            
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            Part selected = dgParts.CurrentRow.DataBoundItem as Part;
            if (dgParts.CurrentRow == null || !dgParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please Make a Selection");
                return;
            }
            
            PartForm modifyPart = new PartForm(selected);
            modifyPart.ShowDialog();
            if (!selected.Equals(modifyPart.TempPart))
            {
                inventory.updatePart(selected.PartId, modifyPart.TempPart);
            }
            dgParts.ClearSelection();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchPart_Click(object sender, EventArgs e)
        {
            String search = searchBarPart.Text.ToLower();
            if (search != null) {
                foreach (DataGridViewRow row in dgParts.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Equals(search))
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        dgParts.ClearSelection();
                    }
                }
            }
            else
            {
                dgParts.ClearSelection();
            }
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            Product selected = dgProducts.CurrentRow.DataBoundItem as Product;
            if(selected == null || !dgProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Make a selection");
                return;
            }
            ProductForm modifyProduct = new ProductForm(inventory.AllParts, selected);
            modifyProduct.ShowDialog();
            if (!selected.Equals(modifyProduct.TempProduct) && modifyProduct.TempProduct != null)
            {
                inventory.updateProduct(selected.ProductId, modifyProduct.TempProduct);
                
            }
            dgProducts.ClearSelection();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            ProductForm addProduct = new ProductForm(inventory.AllParts);
            addProduct.ShowDialog();
            if(addProduct.TempProduct != null)
            {
                Product newProduct = addProduct.TempProduct;
                newProduct.ProductId = productsIndexer;
                productsIndexer++;
                inventory.addProduct(newProduct);
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            Product selected = dgProducts.CurrentRow.DataBoundItem as Product;
            if (selected == null || !dgProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Make a selection");
                return;
            }
            if(selected.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Make sure their are no parts associated with this product before deleting");
                return;
            }

            var option = MessageBox.Show("Are you sure you want to delete this part?", "Delete?", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                inventory.Products.Remove(selected);
            }
                
        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            String search = searchBarProduct.Text.ToLower();
            if (search != null)
            {
                foreach (DataGridViewRow row in dgProducts.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Equals(search))
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        dgProducts.ClearSelection();
                    }
                }
            }
            else
            {
                dgProducts.ClearSelection();
            }
        }
    }
}
