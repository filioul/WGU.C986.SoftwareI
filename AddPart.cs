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
        public AddPart()
        {
            InitializeComponent();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            // unchecks the other radio button
            radioButtonInHouse.Checked = false;
            // changes label if the radio button is checked
            labelMachineID.Text = "Company Name";
        }

        private void radioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            // unchecks the other radio button
            radioButtonOutsourced.Checked = false;
            // changes label if the radio button is checked
            labelMachineID.Text = "Machine ID";
        }
    }
}
