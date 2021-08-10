using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_BLL
{
   public class DatHang_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public List<DatHang> loadDatHang ()
        {
            return context.DatHangs.ToList();
        }
        public String loadDatHangTheoNcc (NhaCungCap ncc)
        {
           List<String> lst = context.DatHangs.Where(dh => dh.NhaCungCap.Equals(ncc.MaNhaCungCap)).
                Select(dh => dh.MaPhieuDatHangNhap).ToList();
            string rs = "";
            if(lst.Count > 0)
            {
                foreach (string s in lst)
                    rs += s + ",";
                return rs;
            }
            return null;
        }
        public List<String> loadDatHangMa ()
        {
            return context.DatHangs.Select(dh => dh.MaPhieuDatHangNhap).ToList();
        }
        public DatHang loadDatHang (string madh)
        {
            return context.DatHangs.Where(dh => dh.MaPhieuDatHangNhap.Equals(madh)).SingleOrDefault();
        }
        public string insertNewDatHang(DatHang datHang)
        {
            try
            {
                context.DatHangs.InsertOnSubmit(datHang);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string xoaDonDat(DatHang dh)
        {
            try
            {
                context.DatHangs.DeleteOnSubmit(dh);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<DatHang> loadDonChuaDuyet()
        {
            return context.GetDatHangChuaDuyet().ToList();
        }
    }
}
