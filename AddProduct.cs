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
        //initiating instance of class FormButtons to be able to use the methods there
        FormButtons FormButtons = new FormButtons();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormButtons.ReturnToMainForm();
        }
    }
}
