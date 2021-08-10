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
    public partial class UC_Product_Count : DevExpress.XtraEditors.XtraForm
    {
        public UC_Product_Count(List<HangHoa> lst)
        {
            InitializeComponent();
            init(lst);
        }

        private void init(List<HangHoa> lst)
        {
            foreach(HangHoa hh in lst)
            {
                UC_Product_Count_Item item = new UC_Product_Count_Item(hh);
                item.Dock = DockStyle.Top;
                panel2.Controls.Add(item);
            }    
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
