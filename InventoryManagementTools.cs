using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C986
{
    class InventoryManagementTools
    {
        public static Inventory CreateTestInventory()
        {
            Inventory workingInventory = new Inventory();

            //adding test products
            Product testProd1 = new Product(1, "Product 1", 10, 12.00m, 20, 5);
            workingInventory.AddProduct(testProd1);
            Product testProd2 = new Product(2, "Product 2", 10, 8.00m, 25, 5);
            workingInventory.AddProduct(testProd2);
            Product testProd3 = new Product(3, "Product 3", 10, 5m, 25, 5);
            workingInventory.AddProduct(testProd3);
            Product testProd4 = new Product(4, "Product 4", 10, 3m, 25, 5);
            workingInventory.AddProduct(testProd4);

            Part testPart1 = new Inhouse();

            return workingInventory;
        }
    }
}
