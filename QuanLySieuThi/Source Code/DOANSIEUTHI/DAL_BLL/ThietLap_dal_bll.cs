using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class ThietLap_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public ThietLap loadThietLap()
        {
            return context.ThietLaps.FirstOrDefault();
        }
        
        public string themChucNang(ChucNang cn)
        {
            try
            {
                if(khongTonTaiChucNang(cn) == true)
                {
                    context.ChucNangs.InsertOnSubmit(cn);
                    context.SubmitChanges();
                    return ("OK");
                }
                return "Have"; 
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }

        private bool khongTonTaiChucNang(ChucNang cn)
        {
            return context.ChucNangs.Where(item => item.MaChucNang.Equals(cn.MaChucNang)
            && item.MaNhonChucNang.Equals(cn.MaNhonChucNang)) == null ? true : false;
        }

        public ChucNang loadChucNang(string tenNang)
        {
            return context.ChucNangs.Where(cn => cn.TenChucNang.Equals(tenNang)).SingleOrDefault();
        }
    }
}
