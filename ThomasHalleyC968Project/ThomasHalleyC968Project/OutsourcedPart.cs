using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasHalleyC968Project
{
    internal class OutsourcedPart:Part
    {
        protected string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public OutsourcedPart(int partId, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartId = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
