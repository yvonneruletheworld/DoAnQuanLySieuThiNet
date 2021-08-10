using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;

namespace GUI
{
    public partial class UC_Account : UserControl
    {
        
        public PictureBox btnClose { get => this.btn_close; set => this.btn_close = value; }
        public Label id { get => this.lblUser; set => this.lblUser = value; }

        public UC_Account(Account nd)
        {
            InitializeComponent();
            loadInfo(nd);
            this.Dock = DockStyle.Top;
        }

        private void loadInfo(Account nd)
        {
            this.lbl_ten.Text = nd.name;
            this.lblTime.Text = "Lần cuối: " + nd.date + " " + nd.time;
            this.lblUser.Text = nd.user.Trim();
        }

        private void UC_Account_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Orchid;
        }

        private void UC_Account_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
        }
    }
}
