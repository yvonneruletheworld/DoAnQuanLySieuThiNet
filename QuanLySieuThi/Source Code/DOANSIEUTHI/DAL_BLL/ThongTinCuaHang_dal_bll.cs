using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class ThongTinCuaHang_dal_bll
    {
        QLSIEUTHI_linQDataContext qLSIEUTHI_LinQDataContext = new QLSIEUTHI_linQDataContext();

        public ThongTinCuaHang_dal_bll()
        {

        }

        public IQueryable<ThongTinSieuThi> loadThongtinSieuThi ()
        {
            return qLSIEUTHI_LinQDataContext.ThongTinSieuThis.Select(ttst => ttst);
        }
    }
}
