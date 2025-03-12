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
            buttonSave.Enabled = (textBoxName.Text != "" && textBoxInventory.Text != "" && textBoxPrice.Text != "" && textBoxMax.Text != "" && textBoxMin.Text != "");
        }
    }
}
