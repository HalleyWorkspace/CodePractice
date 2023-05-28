using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasHalleyC968Project
{
    public class Product
    {
        private BindingList<Part> associatedParts;
        private int productId;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public BindingList<Part> AssociatedParts
        {
            get { return associatedParts; }
            set { associatedParts = value; }
        }


        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.min = min;
            this.max = max;
            associatedParts = new BindingList<Part>();
        }

        public void addAssociatedPart(Part newPart)
        {
            if(newPart != null)
            {
                associatedParts.Add(newPart);
            }
        }

        public Boolean removeAssociatedPart(int id)
        {
            Boolean isFound = false;
            
            foreach (Part part in associatedParts)
            {
                if (part.PartId == id)
                {
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }

        public Part lookupAssociatedPart(int id)
        {
            Part searchPart = null;
            foreach(Part part in associatedParts)
            {
                if(part.PartId == id)
                {
                    searchPart = part;
                    break;
                }
            }
 
            return searchPart;
        }
    }
}
