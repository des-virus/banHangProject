using banHangProject.AdminManager.Division;
using banHangProject.AdminManager.Employee;
using banHangProject.SaleManager.Guess;
using banHangProject.SaleManager.Sale;
using banHangProject.View.SaleManager.Sale;
using banHangProject.View.WareManager.Good;
using banHangProject.WareManager.Good;
using banHangProject.WareManager.Label;
using banHangProject.WareManager.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //new frmGuess().Show();
            Application.Run(new frmLogin());
        }
    }
}
