using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WGU.C986
{
    public partial class MainForm : Form
    {
        Inventory workingInventory = new Inventory();
        public MainForm()
        {

            InitializeComponent();
            //initializing inventory with test data & setting up grid views
            workingInventory = InitializeInventory();

            //initiating instance of classes to be able to use the methods there
            InventoryManagementTools InventorManagementTools = new InventoryManagementTools();
        }

        private Inventory InitializeInventory()
        {
            //initializing inventory with test data & setting up grid views
            workingInventory = InventoryManagementTools.CreateTestInventory();

            var sourceParts = new BindingSource();
            sourceParts.DataSource = workingInventory.AllParts;
            partGridView.DataSource = sourceParts;

            var sourceProducts = new BindingSource();
            sourceProducts.DataSource = workingInventory.Products;
            productGridView.DataSource = sourceProducts;

            return workingInventory;

        }

        public void RefreshDataGridViews(Inventory newInventory)
        {
            //refreshes data grid views after changes
            workingInventory = newInventory;

            var sourcePartsNew = new BindingSource();
            sourcePartsNew.DataSource = workingInventory.AllParts;
            partGridView.DataSource = sourcePartsNew;

            var sourceProductsNew = new BindingSource();
            sourceProductsNew.DataSource = workingInventory.Products;
            productGridView.DataSource = sourceProductsNew;

            partGridView.Refresh();
            productGridView.Refresh();

        }

        private void addButtonParts_Click(object sender, EventArgs e)
        {
            // opens AddPart form when the 'Add' button is clicked
            var addPartForm = new AddPart(workingInventory);
            addPartForm.Owner = this;
            addPartForm.Show();
        }

        private void modifyButtonParts_Click(object sender, EventArgs e)
        {
            // opens ModifyPart form when the 'Modify' button is clicked (if a part is selected)
            if (partGridView.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a row before modifying.");
            }
            else
            {
                Part selectedPart = partGridView.CurrentRow.DataBoundItem as Part;
                var modPartForm = new ModifyPart(workingInventory, selectedPart);
                modPartForm.Owner = this;
                modPartForm.Show();
            }
        }

        private void addButtonProducts_Click(object sender, EventArgs e)
        {
            // opens AddProduct form when the 'Add' button is clicked
            var addProductForm = new AddProduct(workingInventory);
            addProductForm.Owner = this;
            addProductForm.Show();
        }

        private void modifyButtonProducts_Click(object sender, EventArgs e)
        {
            // opens ModifyProduct form when the 'Modify' button is clicked (if a product is selected)
            if (productGridView.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a row before modifying.");
            }
            else
            {
                Product selectedProduct = productGridView.CurrentRow.DataBoundItem as Product;
                var modifyProductForm = new ModifyProduct(workingInventory, selectedProduct);
                modifyProductForm.Owner = this;
                modifyProductForm.Show();
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void deleteButtonParts_Click(object sender, EventArgs e)
        {
            // deletes an item if conditions are met
            if (partGridView.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a row before deleting.");
            } else if (MessageBox.Show("Are you sure?", "Confirm Deletion",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question) == DialogResult.No)
            {
                partGridView.ClearSelection();
            } else
            {
                Part selectedPart = partGridView.CurrentRow.DataBoundItem as Part;
                if (!FormValidation.CheckAssociation(workingInventory, selectedPart))
                    workingInventory.AllParts.Remove(selectedPart);
                else
                {
                    MessageBox.Show("Cannot delete a part that is associated with a product.");
                }
                partGridView.ClearSelection();
            }
        }

        private void deleteButtonProducts_Click(object sender, EventArgs e)
        {
            // deletes an item if conditions are met
            if (productGridView.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a row before deleting.");
            }
            else if (MessageBox.Show("Are you sure?", "Confirm Deletion",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question) == DialogResult.No)
            {
                partGridView.ClearSelection();
            }
            else
            {
                Product selectedProduct = productGridView.CurrentRow.DataBoundItem as Product;
                workingInventory.Products.Remove(selectedProduct);
                productGridView.ClearSelection();
            }
        }

        private void searchButtonParts_Click(object sender, EventArgs e)
        {
            //searches grid view for part
            if (searchBoxParts.Text == "" || !int.TryParse(searchBoxParts.Text, out int id))
            {
                MessageBox.Show("Please enter a valid search term.");
            }
            else
            {
                foreach (DataGridViewRow row in partGridView.Rows)
                {
                    if (row.DataBoundItem is Part part)
                    {
                        if (part.PartID == id)
                        {
                            partGridView.ClearSelection();
                            row.Selected = true;
                            return;
                        }
                    }
                }
                MessageBox.Show("Part not found.");
            }
        }

        private void searchButtonProducts_Click(object sender, EventArgs e)
        {
            //searches grid view for product
            if (searchBoxProducts.Text == "" || !int.TryParse(searchBoxProducts.Text, out int id))
            {
                MessageBox.Show("Please enter a valid search term.");
            }
            else
            {
                foreach (DataGridViewRow row in productGridView.Rows)
                {
                    if (row.DataBoundItem is Product product)
                    {
                        if (product.ProductID == id)
                        {
                            productGridView.ClearSelection();
                            row.Selected = true;
                            return;
                        }
                    }
                }
                MessageBox.Show("Product not found.");
            }
        }
    }
}

