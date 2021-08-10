using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class CTDatHang_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public IQueryable<ChiTietDatHang> loadCTDatHang()
        {
            return context.ChiTietDatHangs.Select(ctdh => ctdh);
        }
        public string insertNewCTDatHang(ChiTietDatHang lst)
        {
            try
            {
                context.ChiTietDatHangs.InsertOnSubmit(lst);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<ChiTietDatHang> loadCTDatHang (string madondat)
        {
            return context.ChiTietDatHangs.Where(ctd => ctd.MaPhieuDat.Equals(madondat)).ToList();
        }

        public List<String> kiemTraHangNhap(List<String> list, string maDonDat)
        {
            List<String> maHangHoas = context.ChiTietDatHangs.Where(ctd => ctd.MaPhieuDat.Equals(maDonDat))
                                        .Select(ctd => ctd.HangHoa.TenHangHoa).ToList();

            List<String> firstNotSecond = maHangHoas.Except(list).ToList();
            return firstNotSecond;
        }

        public string xoaChiTietDat(string maHangHoa)
        {
            ChiTietDatHang hd = context.ChiTietDatHangs
                .Where(h => h.MaHangHoa.Equals(maHangHoa)).SingleOrDefault();
            try
            {
                context.ChiTietDatHangs.DeleteOnSubmit(hd);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        public string xoaChiTietDat(DatHang dh)
        {
            var cts = context.ChiTietDatHangs.Where(ct => ct.MaPhieuDat.Equals(dh.MaPhieuDatHangNhap))
                .ToList();
            try
            {
                context.ChiTietDatHangs.DeleteAllOnSubmit(cts);
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
