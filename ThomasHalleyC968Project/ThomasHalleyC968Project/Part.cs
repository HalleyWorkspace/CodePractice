using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasHalleyC968Project
{
    public abstract class Part
    {
        private int partId;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public int PartId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        
    }
}
