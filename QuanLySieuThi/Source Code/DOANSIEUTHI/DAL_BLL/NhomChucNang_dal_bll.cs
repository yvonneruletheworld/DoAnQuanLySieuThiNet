using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class NhomChucNang_dal_bll
    {
        QLSIEUTHI_linQDataContext qLSIEUTHI_LinQDataContext = new QLSIEUTHI_linQDataContext();

        public NhomChucNang_dal_bll()
        {

        }
        public List<NhomChucNang> loadNhomChucNang ()
        {
            return qLSIEUTHI_LinQDataContext.NhomChucNangs.ToList();
        }
    }
}
