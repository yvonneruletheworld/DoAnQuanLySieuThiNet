using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class PhongBan_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public List<PhongBan> loadPhongBan ()
        {
            return context.PhongBans.ToList();
        }

        public bool kiemTraTonTai(string v)
        {
            return context.PhongBans.Where(x => x.TenPhongBan.Equals(v)).SingleOrDefault() == null ?
                false : true;
        }

        public string themPhongBan(List<PhongBan> phongBans)
        {
            try
            {
                var rcs = from pb in phongBans
                          select new PhongBan
                          {
                              MaPhongBan = pb.MaPhongBan,
                              TenPhongBan = pb.TenPhongBan
                          };
                context.PhongBans.InsertAllOnSubmit(rcs);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        public string xoaPhongBan(String phongBans)
        {
            try
            {
                if (kiemTraHoatDong(phongBans.Trim()) == true)
                {
                    context.XoaPhongBan(phongBans);
                    return "OK";
                }
                else
                    return "Have";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private bool kiemTraHoatDong(string v)
        {
            return context.KiemTraPhongBanVaiTro(v).ToList().Count == 0 ? true : false;
        }

        public string suaPhongBan(PhongBan phongBan)
        {
            try
            {
                PhongBan item = context.PhongBans.Single(i => i.MaPhongBan.Equals(phongBan.MaPhongBan));

                item.TenPhongBan = phongBan.TenPhongBan;
                
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
