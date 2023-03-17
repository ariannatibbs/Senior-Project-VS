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
    public partial class LoginForm : Form
    {
        //declare child forms for this form
        MainScreen homeForm;
        HelpForm accountForm;

        public LoginForm()
        {
            InitializeComponent();

            //change the text for the form
        }

        private void loginButton_Click(object sender, EventArgs e) //login button code
        {
            if (usernameTextBox.Text.Equals("user1") && passwordTextBox.Text.Equals("12345")) //if the user enters the right credentials
            {
                // Before showing the form, always create a new instance if the form is null or disposed
                if (null == homeForm || homeForm.IsDisposed)
                {
                    homeForm = new MainScreen();
                } //check if home form exists
                
                homeForm.Show(); //open the home form
                
            }

            else
            {
                MessageBox.Show("Incorrect username or password."); //tell the user their credentials are incorrect
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) //cancel button code
        {
            this.Close(); //close form
        }

        private void new_account_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //new account button code
        {
            if (null == accountForm || accountForm.IsDisposed)
            {
                accountForm = new HelpForm();
            } //check if account form exists

            accountForm.Enabled = true; //account form will open in modify mode
            accountForm.Show(); //open the account form
        }
    }
}
