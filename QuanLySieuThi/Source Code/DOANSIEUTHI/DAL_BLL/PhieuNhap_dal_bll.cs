using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class PhieuNhap_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public List<PhieuNhap> loadPhieuNhap()
        {
            return context.PhieuNhaps.Select(pn => pn).ToList();
        }

        public string insertNewPhieuNhap(PhieuNhap phieuNhap)
        {
            try
            {
                context.PhieuNhaps.InsertOnSubmit(phieuNhap);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return   e.Message;
            }
        }

        public PhieuNhap loadNgayNhap(string maHangHoa)
        {
            PhieuNhap rs = context.GetNgayNhapGanNhat(maHangHoa).SingleOrDefault();
            return rs;
        }

        public string xoaPhieuNhap(PhieuNhap dh)
        {
            try
            {
                context.PhieuNhaps.DeleteOnSubmit(dh);
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
