using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU.C986
{
    public partial class AddPart : Form
    {
        //initiating instance of classes FormButtons, FormValidation to be able to use the methods there
        FormButtons FormButtons = new FormButtons();
        FormValidation FormValidation = new FormValidation();
        public AddPart()
        {
            InitializeComponent();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            // changes label if the radio button is checked
            labelMachineID.Text = "Company Name";
        }

        private void radioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            // changes label if the radio button is checked
            labelMachineID.Text = "Machine ID";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            FormButtons.ReturnToMainForm();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxName);
            FormValidation.EnableSaveButtonParts(textBoxName, textBoxInventory, textBoxPriceCost, textBoxMax, textBoxMin, textBoxMachineID, buttonSave);
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxInventory);
            FormValidation.EnableSaveButtonParts(textBoxName, textBoxInventory, textBoxPriceCost, textBoxMax, textBoxMin, textBoxMachineID, buttonSave);
        }

        private void textBoxPriceCost_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxPriceCost);
            FormValidation.EnableSaveButtonParts(textBoxName, textBoxInventory, textBoxPriceCost, textBoxMax, textBoxMin, textBoxMachineID, buttonSave);
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxMax);
            FormValidation.EnableSaveButtonParts(textBoxName, textBoxInventory, textBoxPriceCost, textBoxMax, textBoxMin, textBoxMachineID, buttonSave);
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxMin);
            FormValidation.EnableSaveButtonParts(textBoxName, textBoxInventory, textBoxPriceCost, textBoxMax, textBoxMin, textBoxMachineID, buttonSave);
        }

        private void textBoxMachineID_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxMachineID);
            FormValidation.EnableSaveButtonParts(textBoxName, textBoxInventory, textBoxPriceCost, textBoxMax, textBoxMin, textBoxMachineID, buttonSave);
        }
    }
}
