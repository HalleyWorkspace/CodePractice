using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasHalleyC968Project
{
    internal class InHousePart : Part
    {
        protected int machineID;

        public int MachineID
        {
            get { return machineID; }
            set { machineID = value; }
        }

        public InHousePart(int partId, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartId = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
