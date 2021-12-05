using System;
using System.Windows.Forms;
using PMMarkingUI.Forms;


using PMMarkingUI.Classes;
using ProfitMed.DataContract;
using System.Collections.Generic;
using System.Threading;

namespace PMMarkingUI
{
     class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            //Application.Run(new frmTest());            
            if (new frmLogin().ShowDialog() == DialogResult.OK)
                Application.Run(new frmMain());
        }
    }
}
