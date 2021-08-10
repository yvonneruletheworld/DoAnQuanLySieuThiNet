using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class ManHinh_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public ManHinh loadManHinh(string mach)
        {
            string manch = context.ChucNangs.Where(cn => cn.MaChucNang.Equals(mach))
                .Select(cn => cn.MaNhonChucNang).SingleOrDefault();

            return context.ManHinhs.Where(mh => mh.NhomTruyCap.Equals(manch.Trim()))
                                    .Select(mh => mh).SingleOrDefault();
        }
        

    }
}
