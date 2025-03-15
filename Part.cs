using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace WGU.C986
{
    abstract class Part
    {
        public int PartID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

        public Part()
        {

        }

        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }
    }

    class Inhouse : Part
    {
        private int MachineID;
    }

    class Outsourced : Part
    {
        private int CompanyName;
    }
}
