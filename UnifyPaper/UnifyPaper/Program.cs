using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifyPaper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
  
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                frmMainpage fmp = new frmMainpage();
                if (fmp != null)
                {
                    Application.Run(fmp);
                }
            }catch(Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            
        }
    }
}
