using System;
using System.Collections.Generic;
using System.Data;
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

            //adding test inhouse parts
            Inhouse testPart1 = new Inhouse(1, "Inhouse 1", 9m, 5, 0, 9, 1003);
            workingInventory.AddPart(testPart1);
            Inhouse testPart2 = new Inhouse(2, "Inhouse 2", 7m, 2, 1, 6, 1004);
            workingInventory.AddPart(testPart2);
            Inhouse testPart3 = new Inhouse(3, "Inhouse 3", 9m, 4, 2, 5, 1009);
            workingInventory.AddPart(testPart3);
            Inhouse testPart4 = new Inhouse(4, "Inhouse 4", 3m, 4, 2, 9, 1005);
            workingInventory.AddPart(testPart4);

            //adding test outsourced parts
            Outsourced testPart5 = new Outsourced(11, "Outsourced 1", 7m, 2, 1, 3, "Company A");
            workingInventory.AddPart(testPart5);
            Outsourced testPart6 = new Outsourced(22, "Outsourced 2", 4m, 2, 2, 7, "Company B");
            workingInventory.AddPart(testPart6);
            Outsourced testPart7 = new Outsourced(33, "Outsourced 3", 5m, 4, 1, 8, "Company A");
            workingInventory.AddPart(testPart7);
            Outsourced testPart8 = new Outsourced(44, "Outsourced 4", 2m, 4, 2, 8, "Company C");
            workingInventory.AddPart(testPart8);

            //adding test associated parts
            testProd1.AddAssociatedPart(testPart1);
            testProd1.AddAssociatedPart(testPart3);
            testProd2.AddAssociatedPart(testPart5);
            testProd3.AddAssociatedPart(testPart7);
            testProd3.AddAssociatedPart(testPart8);

            return workingInventory;
        }
    }
}
