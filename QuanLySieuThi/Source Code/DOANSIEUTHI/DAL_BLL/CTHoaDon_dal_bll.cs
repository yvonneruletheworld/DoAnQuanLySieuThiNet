using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class CTHoaDon_dal_bll 
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public List<ChiTietHoaDon> loadCTHoaDon(string mahd)
        {
            return context.ChiTietHoaDons.Where(cthd => cthd.MaHoaDon.Equals(mahd)).ToList();
        }
        public List<ChiTietHoaDon> loadCTHoaDonTheoHang(string mahh)
        {
            return context.ChiTietHoaDons.Where(cthd => cthd.MaHangHoa.Equals(mahh)).ToList();
        }
         public List<ChiTietHoaDon> loadCTHoaDon()
        {
            return context.ChiTietHoaDons.ToList();
        }

        public string insertCthd (ChiTietHoaDon cthd)
        {
            try
            {
                context.ChiTietHoaDons.InsertOnSubmit(cthd);
                context.SubmitChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public ChiTietHoaDon loadCTHoaDontheoma(string machitiet)
        {
            return context.ChiTietHoaDons.Where(hd => hd.MaChiTiet.Equals(machitiet)).SingleOrDefault();
        }
        public List<ChiTietHoaDon> loadCTHoaDontheoProc(string mahoadons)
        {
            return context.GetChiTietByMaHd(mahoadons).ToList();
        }

        public int uodateHoaDonGop(string macthdons, string mahd)
        {
            return context.CapNhatChiTietByMaCT(macthdons, mahd);
        }

        public string xoaChiTietHoaDon(string maHangHoa)
        {
            ChiTietHoaDon hd = context.ChiTietHoaDons
                .Where(h => h.MaHangHoa.Equals(maHangHoa)).SingleOrDefault();
            try
            {
                context.ChiTietHoaDons.DeleteOnSubmit(hd);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string xoaChiTietHoaDon(ChiTietHoaDon ct)
        {
            try
            {
                context.ChiTietHoaDons.DeleteOnSubmit(ct);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
