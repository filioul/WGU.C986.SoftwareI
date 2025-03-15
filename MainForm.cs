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
        
        public MainForm()
        {
            InitializeComponent();
            InitializeInventoryAndTables();
            //initiating instance of classes to be able to use the methods there
            FormButtons FormButtons = new FormButtons();
            InventoryManagementTools InventorManagementTools = new InventoryManagementTools();
        }

        public void InitializeInventoryAndTables()
        {
            //creates inventory and populates tables
            Inventory workingInventory =  InventoryManagementTools.CreateTestInventory();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            partGridView.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            productGridView.DataSource = prodTable;
        }
        private void addButtonParts_Click(object sender, EventArgs e)
        {
            // opens AddPart form when the 'Add' button is clicked
            Hide();
            var addPartForm = new AddPart();
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

        private void searchBoxParts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

