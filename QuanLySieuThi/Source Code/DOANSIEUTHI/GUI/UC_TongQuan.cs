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
using System.Globalization;

namespace GUI
{
    public partial class UC_TongQuan : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDon_dal_bll hoaDon_Dal_Bll = new HoaDon_dal_bll();
        LoaiHangHoa_dal_bll loaiHangHoa_Dal_Bll = new LoaiHangHoa_dal_bll();
        Color lbl_DoanhThuThangColor;
        public UC_TongQuan()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            List<HoaDon> hoaDons = hoaDon_Dal_Bll.loadHoaDon();
            decimal sum = 0, thangTruoc = 0, thangNay = 0;
            DateTime time;
            hoaDons.ForEach(hd =>
            {
                try
                {
                    if (hd.ThanhTien != null)
                        sum += (decimal)hd.ThanhTien;
                    time = DateTime.Parse(hd.NgayLap.Trim());
                    if (time.Month == DateTime.Now.Month)
                    {
                        thangNay += (decimal)hd.ThanhTien;
                    }
                    if (time.Month == DateTime.Now.Month - 1)
                    {
                        thangTruoc += (decimal)hd.ThanhTien;
                    }
                }
                catch (Exception ex)
                {
                    //new UC_Message().showAlert(ex.Message, UC_Message.enmType.Error);
                }
            });

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            lbl_ThanhTien.Text = double.Parse(sum+"").ToString("#,###", cul.NumberFormat) + "VND";

            List<HoaDon> hoaDons1 = hoaDon_Dal_Bll.loadHoaDonNgay(DateTime.Now.ToString("yyyy/ MM/ dd"));
            decimal sumTD = 0;
            hoaDons1.ForEach(hd =>
            {
                if (hd.ThanhTien != null)
                    sumTD += (decimal)hd.ThanhTien;
            });
            CultureInfo cul1 = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            lbl_ThanhTien.Text = double.Parse(sumTD + "").ToString("#,###", cul1.NumberFormat) + "VND";
            lbl_PhanTramSoVoiHqua.Text = double.Parse(thangTruoc + "").ToString("#,###", cul1.NumberFormat) + "VND";
            lbl_SoVoiDoanhThuThangTruoc.Text = double.Parse(thangNay + "").ToString("#,###", cul1.NumberFormat) + "VND";

            loadChart();

        }

        private void loadChart()
        {
            List<LoaiHangHoa> lst = loaiHangHoa_Dal_Bll.loadLoaiHangHoa();
            lst.ForEach(lhh =>
            {
                flowLayoutPanel1.Controls.Add(new UC_Chart(lhh.TenLoaiHang));
            });
        }

        private static UC_TongQuan _instance;

        public static UC_TongQuan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_TongQuan();
                }
                return _instance;
            }
        }
       
    }
}
