using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS314AppPrj
{
    public partial class ResetForm : Form
    {
        //declare child forms for this form
        //MainScreen mainScreen;
        public ResetForm()
        {
            InitializeComponent();
        }
        private void noButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e, MainScreen mainScreen)
        {
            //code that closes game
            MainScreen obj = (MainScreen)Application.OpenForms["mainScreen"];

            this.Close();
            obj.Close();
            //mainScreen.Close();
        }
    }
}
