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
    public partial class AddProduct : Form
    {
        //initiating instance of classes FormButtons, FormValidation to be able to use the methods there
        FormButtons FormButtons = new FormButtons();
        FormValidation FormValidation = new FormValidation();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormButtons.ReturnToMainForm();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxName);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxInventory);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxPrice);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxMax);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            FormValidation.ChangeFieldColorWhenFilled(textBoxMin);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }
    }
}
