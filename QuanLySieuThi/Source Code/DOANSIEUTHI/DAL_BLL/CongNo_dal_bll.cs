using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class CongNo_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public List<CongNo> loadCongNo()
        {
            return context.CongNos.Where(cn => cn.ConLai != null).ToList();
        }
        public string themCongNo(CongNo cn)
        {
            try
            {
                context.CongNos.InsertOnSubmit(cn);
                context.SubmitChanges();
                return ("OK");
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }
        
        public string updateCongNo(CongNo cn)
        {
            try
            {
                CongNo congNo = context.CongNos
                    .Where(c => c.MaCongNo.Equals(cn.MaCongNo))
                    .SingleOrDefault();
                if (congNo != null)
                {
                    congNo.NgayTra = cn.NgayTra;
                    congNo.TraTien = cn.TraTien;
                    congNo.ConLai = cn.ConLai;
                }
                context.CongNos.InsertOnSubmit(cn);
                context.SubmitChanges();
                return ("OK");
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }
        public string xoaCongNo(string mapc)
        {
            try
            {
                CongNo congNo = context.CongNos
                    .Where(cn => cn.PhieuChi.Equals(mapc.Trim()))
                    .SingleOrDefault();
                context.CongNos.DeleteOnSubmit(congNo);
                context.SubmitChanges();
                return ("OK");
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }

        public CongNo loadCongNoGanNhat(string v)
        {
            return context.GetConLaiGanNhat(v).SingleOrDefault();
        }
    }
}
