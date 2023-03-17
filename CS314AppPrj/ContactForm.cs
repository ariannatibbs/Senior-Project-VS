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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Changes Saved."); //show this message when user clicks "save changes"
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an Contact Form."); //show this message when user clicks "about"
        }

        private void switchToViewModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //accountPanel.Enabled = false; //disables panel to view-only
        }

        private void switchToModifyModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //accountPanel.Enabled = true; //enables panel to be modified
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }
    }
}
