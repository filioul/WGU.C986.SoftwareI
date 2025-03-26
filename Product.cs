using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WGU.C986
{
    class Product
    {
        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int prodID, string name, int inStock, decimal price, int max, int min)
        {
            ProductID = prodID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }

        //method to add an associated part
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        //method to remove an associated part
        public bool RemoveAssociatedPart(int partID)
        {
            bool partRemoved = false;
            foreach(Part associatedPart in AssociatedParts)
            {
                if (associatedPart.PartID == partID)
                {
                    AssociatedParts.Remove(associatedPart);
                    partRemoved = true;
                    break;
                }
            }
            return partRemoved;
        }

        //method to look up an associated part
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part associatedPart in AssociatedParts)
            {
                if (associatedPart.PartID == partID)
                {
                    return associatedPart;
                }
            }
            Part emptyPart = null;
            return emptyPart;
        }
    }




}
