using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class Voucher_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();

        public Voucher getVoucher(string mavc)
        {
            return context.Vouchers.Where(vc => vc.MaVoucher.Equals(mavc)).SingleOrDefault();
        }
        
        public List<Voucher> getVoucher()
        {
            return context.Vouchers.ToList();
        } 
        
        public string addVoucher(Voucher vc)
        {
            try
            {
                context.Vouchers.InsertOnSubmit(vc);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
