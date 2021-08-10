using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class Config_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();

        public ThietLap loadConfig()
        {
           return context.ThietLaps.SingleOrDefault();
        }
        public string editConfig(ThietLap tl)
        {
            try
            {
                ThietLap item = (from c in context.ThietLaps 
                                 where c.MaThietLap.Equals(tl.MaThietLap) 
                                 select c).Single();
                item.GioDongCua = tl.GioDongCua;
                item.GioMoCua = tl.GioMoCua;
                item.HinhThucChi = tl.HinhThucChi;
                item.LoaiChi = tl.LoaiChi;
                item.MucTonKho = tl.MucTonKho;
                item.NgayBatDau = tl.NgayBatDau;
                item.NgayHoatDong = tl.NgayHoatDong;

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
