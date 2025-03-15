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
    }

    abstract class Inhouse : Part
    {
        private int MachineID;
    }

    abstract class Outsourced : Part
    {
        private int CompanyName;
    }
}
