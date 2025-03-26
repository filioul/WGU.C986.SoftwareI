using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WGU.C986
{
    public partial class AddPart : Form
    {
        private Inventory workingInventory;
        public AddPart(Inventory inventory)
        {
            InitializeComponent();
            workingInventory = inventory;

            //initiating instance of classes FormButtons, FormValidation to be able to use the methods there
            FormButtons FormButtons = new FormButtons();
            FormValidation FormValidation = new FormValidation();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonInHouse.Checked)
            {
                try
                {
                    Inhouse newInhouse = new Inhouse(int.Parse(textBoxID.Text),
                                                     textBoxName.Text,
                                                     decimal.Parse(textBoxPriceCost.Text),
                                                     int.Parse(textBoxInventory.Text),
                                                     int.Parse(textBoxMin.Text),
                                                     int.Parse(textBoxMax.Text),
                                                     int.Parse(textBoxMachineID.Text));
                    workingInventory.AddPart(newInhouse);
                    MessageBox.Show("New inhouse part added.");
                    ((MainForm)this.Owner).RefreshDataGridViews(workingInventory);
                    this.Close();
                } catch
                {
                    MessageBox.Show("Invalid part details, please try again.");
                }


            } else if (radioButtonOutsourced.Checked)
            {
                try
                {
                    Outsourced newOutsourced = new Outsourced(int.Parse(textBoxID.Text),
                                                     textBoxName.Text,
                                                     decimal.Parse(textBoxPriceCost.Text),
                                                     int.Parse(textBoxInventory.Text),
                                                     int.Parse(textBoxMin.Text),
                                                     int.Parse(textBoxMax.Text),
                                                     textBoxMachineID.Text);
                    workingInventory.AddPart(newOutsourced);
                    MessageBox.Show("New outsourced part added.");
                    ((MainForm)this.Owner).RefreshDataGridViews(workingInventory);
                    this.Close();
                 
                } catch
                {
                    MessageBox.Show("Invalid part details, please try again.");
                }
            }
            
        }
    }
}
