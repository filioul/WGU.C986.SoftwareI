using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WGU.C986
{
    class FormValidation
    {
        public static void ChangeFieldColorWhenFilled(TextBox FieldName)
        {
            //style change for fields
            FieldName.BackColor = Color.White; 
        }

        public static void EnableSaveButtonParts(TextBox textBoxName, TextBox textBoxInventory, TextBox textBoxPriceCost,
                                                 TextBox textBoxMax, TextBox textBoxMin, TextBox textBoxMachineID, Button buttonSave)
        {
            buttonSave.Enabled = (textBoxName.Text != "" && textBoxInventory.Text != "" && textBoxPriceCost.Text != "" && textBoxMax.Text != "" && textBoxMin.Text != "" && textBoxMachineID.Text != "");
        }

        public static void EnableSaveButtonProducts(TextBox textBoxName, TextBox textBoxInventory, TextBox textBoxPrice,
                                                 TextBox textBoxMax, TextBox textBoxMin, Button buttonSave)
        {
            //enables save button if details are filled
            buttonSave.Enabled = (textBoxName.Text != "" && textBoxInventory.Text != "" && textBoxPrice.Text != "" && textBoxMax.Text != "" && textBoxMin.Text != "");
        }

        public static void CheckMinMax(int min, int max)
        {
            //checks that min is not bigger than max
            if (min > max)
            {
                throw new Exception("Invalid Max Min values.");
            }
        }

        public static void CheckInventory(int min, int max, int inventory)
        {
            //checks if the inventory value is valid based on min and max
            if (inventory > max || inventory < min)
            {
                throw new Exception("Invalid Inventory value.");
            }
        }

        public static bool CheckAssociation(Inventory workingInventory, Part selectedPart)
        {
            //checks if part is associated with a product
            Part _part = null;
            foreach (Product product in workingInventory.Products)
            {
                _part = product.LookupAssociatedPart(selectedPart.PartID);
                if (_part != null) {
                    return true;
                }
            }
            return false;
        }
    }
}
