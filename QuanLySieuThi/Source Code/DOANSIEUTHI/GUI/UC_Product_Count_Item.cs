using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BLL;

namespace GUI
{
    public partial class UC_Product_Count_Item : DevExpress.XtraEditors.XtraUserControl
    {
        GUI_Control control = new GUI_Control();
        public UC_Product_Count_Item(HangHoa hh)
        {
            InitializeComponent();
            init(hh);
        }

        private void init(HangHoa hh)
        {
            if (hh.Anh != null)
            {
                pic_prd.Image = control.ByteToImage(hh.Anh.ToArray());
            }
            gunaLabel16.Text = hh.TenHangHoa;
            gunaLabel1.Text = hh.TonKho.ToString();
        }

        private void pic_prd_MouseEnter(object sender, EventArgs e)
        {
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void pic_prd_MouseLeave(object sender, EventArgs e)
        {
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
        }
    }
}
