using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANSIEUTHI.Login_Resigter
{
    public partial class frmMain : Form
    {
        public bool sizeMax;
        public frmMain()
        {
            InitializeComponent();
            sizeMax = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(sizeMax == true)
            {
                WindowState = FormWindowState.Normal;
                TopMost = false;
                sizeMax = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                sizeMax = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(Program._LogIn == null || Program._LogIn.IsDisposed)
            {
                Program._LogIn = new frmLogIn();
            }
            this.Visible = false;
            Program._LogIn.Show();
        }
    }
}
