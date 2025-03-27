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
        private Inventory workingInventory;
        private Product newProduct = new Product();
        public AddProduct(Inventory inventory)
        {
            workingInventory = inventory;

            InitializeComponent();

            var sourceParts = new BindingSource();
            sourceParts.DataSource = workingInventory.AllParts;
            allGridView.DataSource = sourceParts;
            //initiating instance of classes FormButtons, FormValidation to be able to use the methods there
            FormButtons FormButtons = new FormButtons();
            FormValidation FormValidation = new FormValidation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                newProduct.ProductID = int.Parse(textBoxID.Text);
                newProduct.Name = textBoxName.Text;
                newProduct.InStock = int.Parse(textBoxInventory.Text);
                newProduct.Price = decimal.Parse(textBoxPrice.Text);
                newProduct.Max = int.Parse(textBoxMax.Text);
                newProduct.Min = int.Parse(textBoxMin.Text);

                workingInventory.AddProduct(newProduct);
                MessageBox.Show("New product added.");
                ((MainForm)this.Owner).RefreshDataGridViews(workingInventory);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid product details, please try again.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (allGridView.CurrentRow.Selected == true)
            {
                Part selectedPart = allGridView.CurrentRow.DataBoundItem as Part;
                newProduct.AddAssociatedPart(selectedPart);

                var sourceAssociated = new BindingSource();
                sourceAssociated.DataSource = newProduct.AssociatedParts;
                associatedGridView.DataSource = sourceAssociated;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (associatedGridView.CurrentRow.Selected == true)
            {
                Part selectedPart = allGridView.CurrentRow.DataBoundItem as Part;
                newProduct.RemoveAssociatedPart(selectedPart.PartID);

                var sourceAssociated = new BindingSource();
                sourceAssociated.DataSource = newProduct.AssociatedParts;
                associatedGridView.DataSource = sourceAssociated;
            }
        }

        private void searchButtonProducts_Click(object sender, EventArgs e)
        {
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
    }
}
