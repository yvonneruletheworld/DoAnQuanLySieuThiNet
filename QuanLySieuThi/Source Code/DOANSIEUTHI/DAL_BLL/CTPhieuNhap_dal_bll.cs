using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class CTPhieuNhap_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public IQueryable<ChiTietNhap> loadChiTietNhap()
        {
            return context.ChiTietNhaps.Select(ct => ct);
        }
        public List<ChiTietNhap> loadChiTietNhap(string mact)
        {
            return context.ChiTietNhaps.Where(ct => ct.MaPhieuNhap.Equals(mact)).ToList();
        }
        public ChiTietNhap loadChiTietNhapTheoHang(string mahh)
        {
            return context.GetNhapGanNhat(mahh).SingleOrDefault();
        }

        public string insertNewChiTietNhap(ChiTietNhap ctnhap)
        {
            try
            {
                context.ChiTietNhaps.InsertOnSubmit(ctnhap);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return  e.Message;
            }
        }

        public string xoaChiTietNhap(string maHangHoa)
        {
            ChiTietNhap hd = context.ChiTietNhaps
                .Where(h => h.MaHangHoa.Equals(maHangHoa)).SingleOrDefault();
            try
            {
                context.ChiTietNhaps.DeleteOnSubmit(hd);
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
