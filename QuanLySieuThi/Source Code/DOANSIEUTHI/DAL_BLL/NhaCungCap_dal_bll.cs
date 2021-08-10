using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class NhaCungCap_dal_bll
    {
        QLSIEUTHI_linQDataContext qLSIEUTHI_LinQDataContext = new QLSIEUTHI_linQDataContext();

        public NhaCungCap_dal_bll ()
        {

        }

        public IQueryable<NhaCungCap> loadNhaCungCap ()
        {
            return qLSIEUTHI_LinQDataContext.NhaCungCaps.Select(ncc => ncc);
        }
        public NhaCungCap loadNhaCungCap (string tenncc)
        {
            return qLSIEUTHI_LinQDataContext.NhaCungCaps.Where(ncc => ncc.TenNhaCungCap.Contains(tenncc))
                .SingleOrDefault();
        }
         public List<NhaCungCap> loadNhaCungCapNo ()
        {
            return qLSIEUTHI_LinQDataContext.GetChiNhaCungCapNo().ToList();
        }

        public string updatNhaCungCap(NhaCungCap seleteNcc)
        {
            NhaCungCap item = qLSIEUTHI_LinQDataContext.NhaCungCaps.Single(ncc => ncc.MaNhaCungCap.Equals(seleteNcc.MaNhaCungCap));

            if(item == null)
            {
                return themNcc(seleteNcc);
            }
            else
            {
                try
                {
                    item.TenNhaCungCap = seleteNcc.TenNhaCungCap;
                    item.Active = seleteNcc.Active;
                    item.DiaChi = seleteNcc.DiaChi;
                    item.Logo = seleteNcc.Logo;

                    qLSIEUTHI_LinQDataContext.SubmitChanges();
                    return "OK";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
                

            }    
        }

        private string themNcc(NhaCungCap seleteNcc)
        {
            try
            {
                NhaCungCap item = new NhaCungCap();
                item.TenNhaCungCap = seleteNcc.TenNhaCungCap;
                item.Active = seleteNcc.Active;
                item.DiaChi = seleteNcc.DiaChi;
                item.Logo = seleteNcc.Logo;

                qLSIEUTHI_LinQDataContext.NhaCungCaps.InsertOnSubmit(item);
                qLSIEUTHI_LinQDataContext.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public string themNcc(List<NhaCungCap> seleteNcc)
        {
            var item = from ncc in seleteNcc
                       select new NhaCungCap
                       {
                           MaNhaCungCap = ncc.MaNhaCungCap,
                           TenNhaCungCap = ncc.TenNhaCungCap,
                           DiaChi = ncc.DiaChi,
                           Logo = ncc.Logo,
                           Active = ncc.Active
                       };
            try
            {
                qLSIEUTHI_LinQDataContext.NhaCungCaps.InsertAllOnSubmit(item);
                qLSIEUTHI_LinQDataContext.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        public string xoaNcc(List<NhaCungCap> seleteNcc)
        {
            var item = from ncc in seleteNcc
                       select new NhaCungCap
                       {
                           MaNhaCungCap = ncc.MaNhaCungCap,
                           TenNhaCungCap = ncc.TenNhaCungCap,
                           DiaChi = ncc.DiaChi,
                           Logo = ncc.Logo,
                           Active = ncc.Active
                       };
            try
            {
                qLSIEUTHI_LinQDataContext.NhaCungCaps.DeleteAllOnSubmit(item);
                qLSIEUTHI_LinQDataContext.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
