using FlatAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatAutomation
{
    static class Program
    {
        public static SqlHelper sqlHelper = new SqlHelper();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo tr = new CultureInfo("tr");
          
            Application.Run(new Form1());
        }
    }
}
