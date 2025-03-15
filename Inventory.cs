using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace WGU.C986
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        //method to add a product to inventory
        public void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        //method to remove a product from inventory
        public bool RemoveProduct(int prodID)
        {
            bool productRemoval = false;
            foreach (Product prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return productRemoval = true;
                }
                else
                {
                    MessageBox.Show("ERROR: The removal failed.");
                    return productRemoval = false;
                }
            }
            return productRemoval;
        }

        //method to look up a product
        public Product LookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Product emptyProduct = null;
            return emptyProduct;
        }

        //method to update the details of an existing product
        public void UpdateProduct(int prodID, Product newProductVersion)
        {
            foreach (Product existingProduct in Products)
            {
                if (existingProduct.ProductID == prodID)
                {
                    RemoveProduct(prodID);
                    AddProduct(newProductVersion);
                    return;
                }
            }
        }

        //method to add a part to inventory
        public void AddPart(Part part)
        {
            Parts.Add(part);
        }

        //method to delete a part from inventory
        public bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(partToDelete);
                return true;
            }
        }

        //method to look up a part
        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = null;
            return emptyPart;
        }

        //method to update an existing part
        public void UpdatePart(int partID, Part part)
        {
            foreach (Part existingPart in Parts)
            {
                if (existingPart.PartID == partID)
                {
                    DeletePart(partID);
                    AddPart(part);
                    return;
                }
            }
        }
    }
}
