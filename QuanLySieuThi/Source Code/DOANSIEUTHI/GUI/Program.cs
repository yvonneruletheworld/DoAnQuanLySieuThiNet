using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static frmLogIn _LogIn = null;
        public static frmTaskMain _TaskMain = null;
        public static frmCashier_Main _Cashier = null;
        public static frmScan _Scan = null;
        public static frmConfig _Config = null;
        public static create _create = null;
        public static giaodich _giaodich = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _LogIn = new frmLogIn(false);
            //_Main = new frmMain();
            //_Product_edit = new frmProduct_Edit();
            Application.Run(_LogIn);
        }
    }
}
