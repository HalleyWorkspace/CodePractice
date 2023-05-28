using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasHalleyC968Project
{
    internal class Inventory
    {
        BindingList<Product> products;
        BindingList<Part> allParts;

        public BindingList<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public BindingList<Part> AllParts
        {
            get { return allParts; }
            set { allParts = value; }
        }

        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void addProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public bool removeProduct(int index)
        {
           return Products.Remove(lookupProduct(index));
        }

        public Product lookupProduct(int index)
        {
            Product foundProduct = null;

            foreach(Product product in Products)
            {
                if(product.ProductId == index)
                {
                    foundProduct = product;
                    break;
                }
            }

            return foundProduct;
        }

        public void updateProduct(int index, Product product)
        {
            int listIndex = Products.IndexOf(lookupProduct(index));

            Products.RemoveAt(listIndex);
            Products.Insert(listIndex, product);
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public Part lookupPart(int index)
        {
            Part foundPart = null;
            foreach(Part part in AllParts)
            {
                if(part.PartId == index)
                {
                    foundPart = part;
                    break;
                }
            }

            return foundPart;
        }

        public void updatePart(int index, Part part)
        {
            int listIndex = AllParts.IndexOf(lookupPart(index));
            AllParts.RemoveAt(listIndex);
            AllParts.Insert(listIndex, part);
        }
    }
}
