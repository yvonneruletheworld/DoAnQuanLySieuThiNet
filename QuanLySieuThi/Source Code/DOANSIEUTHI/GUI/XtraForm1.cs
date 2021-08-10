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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        double soTien = 0;
        PhieuChi_dal_bll phieuChi_Dal_Bll = new PhieuChi_dal_bll();
        CongNo_dal_bll congNo_Dal_Bll = new CongNo_dal_bll();
        GUI_Control control = new GUI_Control();
        string ncc;
        public XtraForm1(double max, string ncc)
        {
            InitializeComponent();
            //TopMost = true;
            this.soTien = max;
            StartPosition = FormStartPosition.CenterScreen;
            gunaAdvenceButton1.Enabled = true;
            numericUpDown1.Maximum = (decimal)max;
            this.ncc = ncc;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            double stpt = Double.Parse(numericUpDown1.Value.ToString());
            if (stpt > soTien)
                new UC_Message().showAlert("Vượt quá công nợ", UC_Message.enmType.Warning);
            else
            {
                PhieuChi pc = new PhieuChi();
                pc.MaPhieuChi = "PC" + control.RandomCode();
                pc.NgayChi = DateTime.Now.ToString("G");
                pc.TinhTrang = false;
                pc.GiaTri = (decimal?)stpt;
                pc.NguoiYeuCau = COMMON.currentUser.TenDangNhap;
                pc.LoaiChi = "Công Nợ";

                string rs = phieuChi_Dal_Bll.insertNewPhieuChi(pc,"");
                if (rs.Contains("OK"))
                {
                    string mcn = taoCongNo(pc.MaPhieuChi);
                    new UC_Message().showAlert("Thêm thành công", UC_Message.enmType.Success);
                    this.Close();
                }
                else
                    new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }    
        }

        private string taoCongNo(string mpc)
        {
            double stpt = Double.Parse(numericUpDown1.Value.ToString());
            CongNo rs = congNo_Dal_Bll.loadCongNoGanNhat(ncc);
            if (rs != null)
            {
                CongNo cn = new CongNo();
                cn.MaCongNo = "CN" + control.RandomCode();
                cn.MaNhaCungCap = ncc;
                cn.NgayTra = null;
                cn.MaPhieuNhap = rs.MaPhieuNhap;
                //cn.TraTien = (decimal?)stpt;
                cn.ConLai = rs.ConLai;
                cn.PhieuChi = mpc;
                if (congNo_Dal_Bll.themCongNo(cn).Contains("OK"))
                    return cn.MaCongNo;
                else
                {
                    new UC_Message().showAlert("Lỗi tạo công nợ", UC_Message.enmType.Error);
                    return null;
                }
            }
            return null;
        }

    }
}