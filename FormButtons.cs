using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU.C986
{
    class FormButtons
    {
        public static void ExitApplication() //exits the application, to be used when an exit button is pressed by the user
        {
            Application.Exit();
        }

        public static void ReturnToMainForm() //returns to the main form page, to be used when a cancel button is pressed by the user 
        {
            var mainForm = new MainForm();
            mainForm.Show();
        }


    }
}
