using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace CS314AppPrj
{
    public partial class MainScreen : Form
    {
        //declare child forms for this form
        HelpForm helpForm;
        ResetForm resetForm;


        //variables
        private int num;
        private string guessedPlayer;
        private Workbook wb;
        private Worksheet ws;
        private string filePath = "C:/Users/arian/OneDrive/Desktop/mock database (prototype).xlsx";
        private Microsoft.Office.Interop.Excel.Application excel;


        //ContactForm contactForm;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void helpButton_Click(object sender, EventArgs e) //button to open help window
        {
            if (null == helpForm || helpForm.IsDisposed)
            {
                helpForm = new HelpForm();
            } //check if help form exists

            helpForm.Enabled = false; //help form will open in view-only mode
            helpForm.Show(); //open the help form
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (null == resetForm || resetForm.IsDisposed)
            {
                resetForm = new ResetForm();
            } //check if reset form exists

            //resetForm.Enabled = false; //reset form will open in view-only mode
            resetForm.Show(); //open the reset form
        }

        public void StartButton_Click(object sender, EventArgs e)
        {
            generateRandom();
            readExcel();
        }
        public void generateRandom() //generates random number that will correspond to player in excel sheet
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 26);

            MessageBox.Show(Convert.ToString(num));

            //create a dictionary that stores the info of the player the user is trying to guess
            int i = num;
            int a = 2;
            var guessingPlayer = new Dictionary<string, string>();
            do
            {
                Range cell = ws.Cells[i, a];
                string item = cell.Value; //item is equal to value of that cell
                guessBox.Items.Add(item); //apend name to guessbox

                guessingPlayer.Add(i, item); //append name to dictionary along with its key

                i++;
            }
        }

        public void readExcel() //function to read in data from excel
        {
            
            {
                //filePath = "C:/Users/arian/OneDrive/Desktop/mock database (prototype).xlsx";
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                
                //Workbook wb;
                //Worksheet ws;

                wb = excel.Workbooks.Open(filePath); //set workbook variable to excel sheet
                ws = wb.Worksheets[1]; //sets variable worksheet to the first worksheet in the excel workbook
                
                int i = 2;
                int a = 2;

                var names = new Dictionary<int, string>(); //dictionary that holds all names 

                do
                {
                    Range cell = ws.Cells[i, a];
                    string item = cell.Value; //item is equal to value of that cell
                    guessBox.Items.Add(item); //apend name to guessbox

                    names.Add(i, item); //append name to dictionary along with its key

                    i++;

                }
                while (i < 26); //this loop appends every name in the excel sheet to the dropdown list


                //currentPlayer = names[b]; //sets currentPlayer variable equal to whatever player the
                                          //computer chooses through random number generation

                //MessageBox.Show(currentPlayer);
                
                
                
                //MessageBox.Show(ws.Cells[2, 2].Value); //displays value of the second row, second column cell
            }
        }

        public void guessBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string guessedPlayer = (string)guessBox.SelectedItem; //guessed player is equal to whatever the player chose

                var playerInfo = new Dictionary<string, string>(); //store player info of selected player

                int column = 2;
                int row = num;

                //filePath = "C:/Users/arian/OneDrive/Desktop/mock database (prototype).xlsx";
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                wb = excel.Workbooks.Open(filePath); //set workbook variable to excel sheet
                ws = wb.Worksheets[1]; //sets variable worksheet to the first worksheet in the excel workbook


                do
                {
                    Range cell = ws.Cells[row, column];
                    string item = cell.Value;
                    playerInfo.Add(Convert.ToString(column), item); //add to the dictionary whatever is in
                                                                    //the columns and then then row
                    column++;
                }
                while (column < 9);
                MessageBox.Show(Convert.ToString(playerInfo));
            }

        }
    }
}
