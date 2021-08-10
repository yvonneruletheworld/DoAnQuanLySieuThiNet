using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class Customer_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public string ThemKhachHang(Customer kh)
        {
            try
            {
                context.Customers.InsertOnSubmit(kh);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string updateKhachHang(Customer kh)
        {
            try
            {
                context.Customers.DeleteOnSubmit(kh);
                context.Customers.InsertOnSubmit(kh);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public DataTable loadCus()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CusID", typeof(string));
            dataTable.Columns.Add("CusName", typeof(string));
            dataTable.Columns.Add("Birthday", typeof(DateTime));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("TotalValue", typeof(double));
            dataTable.Columns.Add("NumberBill", typeof(int));
            dataTable.Columns.Add("Frequency", typeof(double));

            List<Customer> cuss = context.Customers.ToList();
            foreach(Customer customer in cuss)
            {
                dataTable.Rows.Add(new Object [] {customer.CusID, customer.CusName, customer.Birthday ,customer.Address
                    , customer.Phone, customer.TotalValue, customer.NumberBill, customer.Frequency });
            }
            return dataTable;
        }
    }
}
