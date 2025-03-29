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

    public partial class ModifyProduct : Form
    {
        private Inventory workingInventory;
        private Product newProduct = new Product();
        private int selectedID;
        public ModifyProduct(Inventory inventory, Product product)
        {
            InitializeComponent();
            //gets inventory + selection from the main form
            workingInventory = inventory;
            selectedID = product.ProductID;

            var sourceParts = new BindingSource();
            sourceParts.DataSource = workingInventory.AllParts;
            allGridView.DataSource = sourceParts;

            var sourceAssociated = new BindingSource();
            sourceAssociated.DataSource = newProduct.AssociatedParts;
            associatedGridView.DataSource = sourceAssociated;

            //initiating instance of classes FormButtons, FormValidation to be able to use the methods there
            FormValidation FormValidation = new FormValidation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            //style changes if box is filled
            FormValidation.ChangeFieldColorWhenFilled(textBoxName);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            //style changes if box is filled
            FormValidation.ChangeFieldColorWhenFilled(textBoxInventory);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            //style changes if box is filled
            FormValidation.ChangeFieldColorWhenFilled(textBoxPrice);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            //style changes if box is filled
            FormValidation.ChangeFieldColorWhenFilled(textBoxMax);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            //style changes if box is filled
            FormValidation.ChangeFieldColorWhenFilled(textBoxMin);
            FormValidation.EnableSaveButtonProducts(textBoxName, textBoxInventory, textBoxPrice, textBoxMax, textBoxMin, buttonSave);
        }

        private void searchButtonProducts_Click(object sender, EventArgs e)
        {
            //searches for part
            if (searchBoxProducts.Text == "" || !int.TryParse(searchBoxProducts.Text, out int id))
            {
                MessageBox.Show("Please enter a valid search term.");
            }
            else
            {
                foreach (DataGridViewRow row in allGridView.Rows)
                {
                    if (row.DataBoundItem is Part part)
                    {
                        if (part.PartID == id)
                        {
                            allGridView.ClearSelection();
                            row.Selected = true;
                            return;
                        }
                    }
                }
                MessageBox.Show("Part not found.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //removes associated part
            if (associatedGridView.CurrentRow.Selected == true)
            {
                Part selectedPart = allGridView.CurrentRow.DataBoundItem as Part;
                newProduct.RemoveAssociatedPart(selectedPart.PartID);

                var sourceAssociated = new BindingSource();
                sourceAssociated.DataSource = newProduct.AssociatedParts;
                associatedGridView.DataSource = sourceAssociated;
            }
        }

        private void addButtonProducts_Click(object sender, EventArgs e)
        {
            //adds associated part
            if (allGridView.CurrentRow.Selected == true)
            {
                Part selectedPart = allGridView.CurrentRow.DataBoundItem as Part;
                newProduct.AddAssociatedPart(selectedPart);

                var sourceAssociated = new BindingSource();
                sourceAssociated.DataSource = newProduct.AssociatedParts;
                associatedGridView.DataSource = sourceAssociated;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //saves modified product to inventory if conditions are met
            try
            {
                newProduct.ProductID = int.Parse(textBoxID.Text);
                newProduct.Name = textBoxName.Text;
                newProduct.InStock = int.Parse(textBoxInventory.Text);
                newProduct.Price = decimal.Parse(textBoxPrice.Text);
                newProduct.Max = int.Parse(textBoxMax.Text);
                newProduct.Min = int.Parse(textBoxMin.Text);
                FormValidation.CheckMinMax(newProduct.Min, newProduct.Max);
                FormValidation.CheckInventory(newProduct.Min, newProduct.Max, newProduct.InStock);
                workingInventory.UpdateProduct(selectedID, newProduct);
                MessageBox.Show("Product updated.");
                ((MainForm)this.Owner).RefreshDataGridViews(workingInventory);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid product details, please try again.");
            }
        }
    }
}
