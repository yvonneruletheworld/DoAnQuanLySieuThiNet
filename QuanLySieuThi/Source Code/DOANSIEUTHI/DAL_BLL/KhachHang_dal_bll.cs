using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class KhachHang_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        
        public List<KhachHang> loadKhachHang ()
        {
            return context.KhachHangs.ToList();
        }
        
        public KhachHang loadKhachHang (string makhachhang)
        {
            return context.KhachHangs.Where(kh => kh.MaKhachHang
            .Equals(makhachhang)).SingleOrDefault();
        }
        public string loadKhachHangDienThoai (string sdt)
        {
            return context.KhachHangs.Where(kh => kh.DienThoai
            .Equals(sdt)).SingleOrDefault().MaKhachHang;
        }

        public string ThemKhachHang(KhachHang kh)
        {
            try
            {
                context.KhachHangs.InsertOnSubmit(kh);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        public string XoaKhachHang(KhachHang kh)
        {
            try
            {
                context.KhachHangs.DeleteOnSubmit(kh);
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
