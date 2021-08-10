using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class NguoiDung_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public IQueryable<NguoiDung> loadNguoiDung ()
        {
            return context.NguoiDungs.Select(nd => nd);
        }
        
        public List<NguoiDung> loadNguoiDungTheoVT (string mavaitro)
        {
            return context.GetNhanVienTheoVaiTro(mavaitro).ToList();
        }
        

        public NguoiDung loadNguoiDung(string tendangnhap, string matkhau)
        {
            NguoiDung nd = context.NguoiDungs.Where(n => n.TenDangNhap.Equals(tendangnhap) && n.MatKhau.Equals(matkhau)).SingleOrDefault();
            return nd;
        }
        public NguoiDung loadNguoiDung(string tendangnhap)
        {
            NguoiDung nd = context.NguoiDungs.Where(n => n.TenDangNhap.Equals(tendangnhap)).SingleOrDefault();
            return nd;
        }
        public NguoiDung updateNguoiDung(NguoiDung ngd)
        {
            NguoiDung nguoiDung = context.NguoiDungs.Where(nd => nd.TenDangNhap.Trim()
            .Equals(ngd.TenDangNhap)).SingleOrDefault();
            try
            {
                nguoiDung.HoTen = ngd.HoTen;
                nguoiDung.MatKhau = ngd.MatKhau;
                nguoiDung.DiaChi = ngd.DiaChi;
                nguoiDung.DienThoai = ngd.DienThoai;
                nguoiDung.Email = ngd.Email;
                nguoiDung.NgaySinh = ngd.NgaySinh;
                nguoiDung.HinhAnh = ngd.HinhAnh;
                nguoiDung.GhiChu = ngd.GhiChu;
                nguoiDung.TrangThai = ngd.TrangThai;
                nguoiDung.HoatDong = ngd.HoatDong;
                //nguoiDung.ChiNhanh = ngd.ChiNhanh;
                context.SubmitChanges();
                return nguoiDung;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string themNguoiDung(NguoiDung nd)
        {
            try
            {
                context.NguoiDungs.InsertOnSubmit(nd);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        public string xoaNguoiDung(NguoiDung nd)
        {
            try
            {
                context.NguoiDungs.DeleteOnSubmit(nd);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public void capNhatTrangThai(string maNguoiDung)
        {
            try
            {
                NguoiDung nd = context.NguoiDungs.Single(n => n.TenDangNhap.Equals(maNguoiDung));
                nd.TrangThai = "";
                context.SubmitChanges();
            }
            catch (Exception e)
            {
            }
        }
    }
}
