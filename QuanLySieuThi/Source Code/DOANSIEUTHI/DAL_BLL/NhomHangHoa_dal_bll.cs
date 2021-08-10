using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class NhomHangHoa_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        public IQueryable<LoaiHangHoa> loadNhomHangHoa()
        {
            return context.LoaiHangHoas.Select(lhh => lhh);
        }

        public string insertNewNhomHangHoa (string maNhomHang, string tenNhomHang)
        {
            LoaiHangHoa loai = new LoaiHangHoa();
            loai.MaLoaiHang = maNhomHang;
            loai.TenLoaiHang = tenNhomHang;
            try
            {
                context.LoaiHangHoas.InsertOnSubmit(loai);
                context.SubmitChanges();
                return "Thêm thành công "+tenNhomHang;
            }
            catch (Exception e)
            {
                return "Đã xảy ra lỗi: "+ e.Message;
            }
        }
    }

}
