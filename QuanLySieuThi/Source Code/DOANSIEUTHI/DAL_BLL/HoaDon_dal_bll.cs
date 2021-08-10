using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   
    public class HoaDon_dal_bll
    {

        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        CTHoaDon_dal_bll cTHoaDon_Dal_Bll = new CTHoaDon_dal_bll();
        public List<HoaDon> loadHoaDon ()
        {
            return context.HoaDons.ToList();
        }
        public List<HoaDon> loadHoaDonNgay (string date)
        {
            return context.HoaDons.Where(hd => hd.NgayLap.Contains(date)).ToList();
        }
        
        public HoaDon loadHoaDon (string mahoadon)
        {
            return context.HoaDons.Where(hd => hd.MaHoaDon.Equals(mahoadon)).SingleOrDefault();
        }
        public string insertHoaDon (HoaDon hoadon)
        {
            try
            {
                context.HoaDons.InsertOnSubmit(hoadon);
                context.SubmitChanges();
                return "Tạo thành công hóa đơn " +hoadon.MaHoaDon;
            }
            catch (Exception e)
            {
                return e.Message;
            } 
        }
        
        public string updateHoaDon (HoaDon hoadon)
        {
            try
            {
                HoaDon hd = context.HoaDons.Single(i => i.MaHoaDon == hoadon.MaHoaDon);
                hd.MaKhachHang = hoadon.MaKhachHang;
                hd.NgayLap = hoadon.NgayLap;
                hd.NhanVien = hoadon.NhanVien;
                hd.TongCong = hoadon.TongCong;
                hd.GiamGia = hoadon.GiamGia;
                hd.ThanhTien = hoadon.ThanhTien;
                hd.TrangThai = hoadon.TrangThai;
                hd.PhuongThucThanhToan = hoadon.PhuongThucThanhToan;
                hd.GhiChu = hoadon.GhiChu;
                context.SubmitChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            } 
        }
        
        public string updateHoaDon (String mhd)
        {
            try
            {
                context.UpdateHoaDon(mhd);
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            } 
        }
        
        public string updateHoaDon (String mhd, decimal? giagiam)
        {
            try
            {
                context.UpdateHoaDonGia(mhd, giagiam);
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            } 
        }
        public string xoaHoaDon (String hoadons)
        {
            try
            {
                context.XoaHoaDon(hoadons);
                return "OK";
            }
            catch (Exception e)
            {
                string rs = "";
                string[] mhd = hoadons.Split(',');
                for(int i =0; i< mhd.Length; i++)
                {
                    rs = xoaHoaDon2(mhd[i].ToString().Trim());
                    if (!rs.Contains("OK"))
                        return rs;
                }
                return "OK";
            } 
        }
        public string xoaHoaDon2 (String hoadons)
        {
            try
            {
                context.XoaHoaDon2(hoadons);
                return "OK";
            }
            catch (Exception e)
            {
                string rs = "";
                List<ChiTietHoaDon> cts = cTHoaDon_Dal_Bll.loadCTHoaDon(hoadons);
                try
                {
                    cts.ForEach(ct =>
                    {
                        rs = cTHoaDon_Dal_Bll.xoaChiTietHoaDon(ct);
                    });
                }
                catch (Exception ex)
                {
                    rs = ex.Message;
                }
                return rs;
            } 
        }

        public List<HoaDon> loadHoaDonGop (bool type)
        {
            string tday = DateTime.Now.ToString("yyyy-MM-dd");
            return context.HoaDons.Where(hd => hd.NgayLap.ToString()
            .Contains(tday) && hd.TrangThai.Equals(type))
             .ToList();
        }
        
    }
}
