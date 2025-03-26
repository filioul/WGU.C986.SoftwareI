using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace WGU.C986
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part()
        {

        }

        
    }

    public class Inhouse : Part
    {
        private int MachineID;
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineid)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineid;
        }
    }

   public class Outsourced : Part
    {
        private string CompanyName;
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string company)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = company;
        }
    }
}
