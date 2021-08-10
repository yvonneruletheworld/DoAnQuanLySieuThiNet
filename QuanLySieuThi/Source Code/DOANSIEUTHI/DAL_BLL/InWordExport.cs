using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class InWordExport
    {
        QLSIEUTHI_linQDataContext data = new QLSIEUTHI_linQDataContext();

        public PhieuChi getPC(string a)
        {
            return data.PhieuChis.Where(t => t.MaPhieuChi == a).FirstOrDefault();
        }

        public CongNo getCN(string a)
        {
            return data.CongNos.Where(t => t.MaCongNo == a).FirstOrDefault();
        }

        public NhaCungCap getNCC(string a)
        {
            return data.NhaCungCaps.Where(t => t.MaNhaCungCap == a).FirstOrDefault();
        }

        public NguoiDung getND(string a)
        {
            return data.NguoiDungs.Where(t => t.TenDangNhap == a).FirstOrDefault();
        }

        public PhieuNhap getPN(string a)
        {
            return data.PhieuNhaps.Where(t => t.MaPhieuNhap == a).FirstOrDefault();
        }

        public List<ChiTietNhap> getCTN(string a)
        {
            return data.ChiTietNhaps.Where(t => t.MaPhieuNhap == a).ToList();
        }

        public HangHoa getHH(string a)
        {
            return data.HangHoas.Where(t => t.MaHangHoa == a).FirstOrDefault();
        }

        //====================//

        public HoaDon getHD(string a)
        {
            return data.HoaDons.Where(t => t.MaHoaDon == a).FirstOrDefault();
        }

        public List<ChiTietHoaDon> getCTHD(string a)
        {
            return data.ChiTietHoaDons.Where(t => t.MaHoaDon == a).ToList();
        }

        public KhachHang getKH(string a)
        {
            return data.KhachHangs.Where(t => t.MaKhachHang == a).FirstOrDefault();
        }
    }
}
