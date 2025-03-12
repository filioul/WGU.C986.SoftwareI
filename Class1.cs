using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C986
{
    abstract class Part
    {
        private int PartID;
        private string Name;
        private decimal Price;
        private int InStock;
        private int Min;
        private int Max;
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
