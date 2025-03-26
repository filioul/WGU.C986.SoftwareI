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
    public partial class MainForm : Form
    {
        Inventory workingInventory = new Inventory();
        public MainForm()
        {

            InitializeComponent();
            workingInventory = InitializeInventory();

            //initiating instance of classes to be able to use the methods there
            FormButtons FormButtons = new FormButtons();
            InventoryManagementTools InventorManagementTools = new InventoryManagementTools();
        }

        private Inventory InitializeInventory()
        {
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
            Hide();
            var modPartForm = new ModifyPart();
            modPartForm.Show();
        }

        private void addButtonProducts_Click(object sender, EventArgs e)
        {
            // opens AddProduct form when the 'Add' button is clicked
            Hide();
            var addProductForm = new AddProduct();
            addProductForm.Show();
        }

        private void modifyButtonProducts_Click(object sender, EventArgs e)
        {
            // opens ModifyProduct form when the 'Modify' button is clicked
            Hide();
            var modifyProductForm = new ModifyProduct();
            modifyProductForm.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            FormButtons.ExitApplication();
        }


        private void deleteButtonParts_Click(object sender, EventArgs e)
        {
            if (partGridView.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a row before deleting.");
            }
            else
            {
                Part selectedPart = partGridView.CurrentRow.DataBoundItem as Part;
                workingInventory.AllParts.Remove(selectedPart);
                partGridView.ClearSelection();
            }
        }

        private void deleteButtonProducts_Click(object sender, EventArgs e)
        {
            if (productGridView.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a row before deleting.");
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

