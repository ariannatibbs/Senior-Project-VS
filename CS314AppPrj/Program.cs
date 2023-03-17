using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 14 object in references-> COM tab

//using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 14 object in references-> COM tab


namespace CS314AppPrj
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
            
        }
    }
}
