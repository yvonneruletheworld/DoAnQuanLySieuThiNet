using DAL_BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_Chart : DevExpress.XtraEditors.XtraUserControl
    {
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        public UC_Chart(string tenLoaiHang)
        {
            InitializeComponent();
            lbl.Text = tenLoaiHang;
            init(tenLoaiHang);
        }

        private void init(string tenLoaiHang)
        {
            List<HangHoa> lst = hangHoa_Dal_Bll.loadHangHoaTheoLoai(tenLoaiHang);
            lst.ForEach(d =>
            {
                chartLoaiHangBanTang1.Series["Hàng Hóa"].Points.AddXY(d.TenHangHoa,1000);
            });
        }
    }
}
