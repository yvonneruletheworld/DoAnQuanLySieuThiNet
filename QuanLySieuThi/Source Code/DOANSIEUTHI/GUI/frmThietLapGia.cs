using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BLL;
using GUI.MODEL;

namespace GUI
{
    public partial class frmThietLapGia : DevExpress.XtraEditors.XtraForm
    {
        double gia;
        string mahang;
        ThietLapGia_dal_bll thietLapGia_Dal_Bll = new ThietLapGia_dal_bll();
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        GUI_Control control = new GUI_Control();
        public frmThietLapGia(double giatien, string mh)
        {
            InitializeComponent();
            this.gia = giatien;
            this.mahang = mh;
            loadThietLap();
            txt_giaban.Text = gia.ToString();
        }

        private void loadThietLap()
        {
            List<ThietLapGia> tlgs = thietLapGia_Dal_Bll.loadThietLap(this.mahang);
            if (tlgs != null)
                thietLapGiaBindingSource.DataSource = new BindingList<ThietLapGia>(tlgs.OrderBy(c => c.NgayThietLap).ToList());
        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                new UC_Message().showAlert("Không hợp lệ", UC_Message.enmType.Warning);
                e.Handled = true;
            }
            if(e.KeyChar == (char) 13)
            {
                if(!gunaTextBox1.Text.ToString().Replace(" ","").Equals(null))
                {
                    ThietLapGia tl = new ThietLapGia();
                    tl.MaThietLap = "TLG" + control.RandomCode();
                    tl.NgayThietLap = DateTime.Now;
                    tl.NguoiThietLap = COMMON.currentUser.TenDangNhap;
                    tl.Gia = (decimal) Double.Parse(gunaTextBox1.Text.ToString().Trim());
                    tl.MaHangHoa = mahang;
                    if (thietLapGia_Dal_Bll.themThietLap(tl).Equals("OK"))
                    {
                        gunaTextBox1.Text = "0";
                        txt_giaban.Text = tl.Gia.ToString();
                        loadThietLap();
                        string rs = hangHoa_Dal_Bll.chinhSuaGia(mahang,tl.Gia);
                        if(rs.Contains("OK"))
                        {
                            new UC_Message().showAlert("Đã cập nhật giá", UC_Message.enmType.Success);
                            lbl.Text = "";
                        }
                        else
                        {
                            new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                            lbl.Text = "";
                        }
                    }    
                }
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text != "0" && gunaTextBox1.Text != "")
            {
                double newGia = Double.Parse(gunaTextBox1.Text.ToString().Trim());
                lbl.Text = "Tăng " + ((float)((newGia - gia) / gia) * 100).ToString(".f") + " %";
            }
        }

    }
}