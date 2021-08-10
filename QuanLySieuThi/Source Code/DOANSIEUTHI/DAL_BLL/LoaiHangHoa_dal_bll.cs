using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class LoaiHangHoa_dal_bll
    {
        QLSIEUTHI_linQDataContext qLSIEUTHI_LinQDataContext = new QLSIEUTHI_linQDataContext();

        public LoaiHangHoa_dal_bll()
        {

        }

        public List<LoaiHangHoa> loadLoaiHangHoa ()
        {
            return qLSIEUTHI_LinQDataContext.LoaiHangHoas.Select(lhh => lhh).ToList();
        }


    }
}
