using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class ThietLapGia_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public List<ThietLapGia> loadThietLap()
        {
            return context.ThietLapGias.ToList();
        }
        public string themThietLap(ThietLapGia cn)
        {
            try
            {
                context.ThietLapGias.InsertOnSubmit(cn);
                context.SubmitChanges();
                return ("OK");
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<ThietLapGia> loadThietLap(string mh)
        {
            return context.ThietLapGias.Where(item => item.MaHangHoa.Equals(mh)).ToList();
        }
    }
}
