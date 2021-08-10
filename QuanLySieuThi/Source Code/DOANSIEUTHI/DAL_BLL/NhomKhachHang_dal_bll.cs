using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class NhomKhachHang_dal_bll
    {
        QLSIEUTHI_linQDataContext qLSIEUTHI_LinQDataContext = new QLSIEUTHI_linQDataContext();

        public NhomKhachHang_dal_bll()
        {

        }

        public IQueryable<NhomKhachHang> loadNhomKhachHang ()
        {
            return qLSIEUTHI_LinQDataContext.NhomKhachHangs.Select(nkh => nkh);
        }
    }
}
