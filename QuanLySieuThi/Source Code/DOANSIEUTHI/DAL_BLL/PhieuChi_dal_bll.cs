using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class PhieuChi_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public List<PhieuChi> loadPhieuChi()
        {
            return context.PhieuChis.ToList();
        }
        public List<PhieuChi> loadPhieuChi(bool state)
        {
            return context.PhieuChis.Where(pc => pc.TinhTrang.Equals(state)).ToList();
        }
        public NhaCungCap loadNguoiNhan(PhieuChi pc)
        {
            return pc.CongNos.Where(cn => cn.PhieuChi.Equals(pc.MaPhieuChi))
                    .Select(cn => cn.NhaCungCap).SingleOrDefault();
        }

        public string insertNewPhieuChi(PhieuChi phieuChi, string mcn)
        {
            try
            {
                context.PhieuChis.InsertOnSubmit(phieuChi);
                //if(mcn != "")
                //{
                //    CongNo item = context.CongNos.Where(cn => cn.MaCongNo.Equals(mcn.ToString().Trim())).SingleOrDefault();

                //    item.PhieuChi = phieuChi.MaPhieuChi;
                //    //if (phieuChi.TinhTrang == true)
                //    //{
                //    //    item.ConLai -= phieuChi.GiaTri;
                //    //    item.TraTien += phieuChi.GiaTri;
                //    //}
                //}    
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return  e.Message;
            }
        }

        public void enablePhieuChi(string maPhieuChi)
        {
            try
            {
                PhieuChi item = context.PhieuChis.Where(pc => pc.MaPhieuChi
                .Equals(maPhieuChi.Trim())).SingleOrDefault();

                item.TinhTrang = false;

                
                context.SubmitChanges();
            }
            catch (Exception)
            {
            }
        }
        public string xoaPhieuChi(string maPhieuChi)
        {
            try
            {
                PhieuChi item = context.PhieuChis.Where(pc => pc.MaPhieuChi
                .Equals(maPhieuChi.Trim())).SingleOrDefault();

                context.PhieuChis.DeleteOnSubmit(item);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string updatePhieuChi(PhieuChi phc)
        {
            try
            {
                PhieuChi item = context.PhieuChis.Where(pc => pc.MaPhieuChi
                .Equals(phc.MaPhieuChi.ToString().Trim())).SingleOrDefault();
                //item.NgayChi =  phc.NgayChi;
                //item.NguoiChi = phc.NguoiChi;
                //item.LoaiChi = phc.LoaiChi;
                //item.Lý_Do_Chi = phc.Lý_Do_Chi;
                //item.HinhThuc = phc.HinhThuc;
                //item.TinhTrang = phc.TinhTrang;
                context.PhieuChis.DeleteOnSubmit(item);
                context.PhieuChis.InsertOnSubmit(phc);
                //CongNo congNo = context.CongNos
                //    .Where(cn => cn.MaCongNo.Equals(mcn))
                //    .SingleOrDefault();
                //if(congNo != null)
                //{
                //    congNo.PhieuChi = item.MaPhieuChi;
                //}    
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
