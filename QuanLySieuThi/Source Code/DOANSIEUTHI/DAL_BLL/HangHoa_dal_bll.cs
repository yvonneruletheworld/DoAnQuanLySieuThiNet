using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAL_BLL
{
   public class HangHoa_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();
        
        public List<String> loadHangHoaVT()
        {
            return context.HangHoas.Select(hh => hh.ViTri).Distinct().ToList();
        }
        public List<HangHoa> loadHangHoaTheoLoai(string tenLoaiHang)
        {
            return context.HangHoas.Where(hh => hh.LoaiHangHoa.TenLoaiHang.Contains(tenLoaiHang)).ToList();
        }
        public string UpdateImage(System.Data.Linq.Binary file_binary, string ma)
        {
            HangHoa hangHoa = context.HangHoas.Where(h => h.MaHangHoa.Equals(ma)).SingleOrDefault();
            try
            {
                hangHoa.Anh = file_binary;
                context.SubmitChanges();
                return "Đã cập nhật" + hangHoa.TenHangHoa;
            }
            catch (Exception e)
            {
                return "Đã xảy ra lỗi: " + e.Message;
            }
        }
        public string UpdateHangHoa(HangHoa hh)
        {
            HangHoa hangHoa = context.HangHoas.Where(h => h.MaHangHoa.Equals(hh.MaHangHoa)).SingleOrDefault();
            try
            {
                hangHoa.TenHangHoa = hh.TenHangHoa;
                hangHoa.MaNhom = hh.MaNhom;
                hangHoa.DonVi = hh.DonVi;
                hangHoa.Mota = hh.Mota;
                hangHoa.ViTri = hh.ViTri;

                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string xoaHangHoa(HangHoa hh)
        {
            HangHoa hangHoa = context.HangHoas.Where(h => h.MaHangHoa.Equals(hh.MaHangHoa)).SingleOrDefault();
            try
            {
                context.HangHoas.DeleteOnSubmit(hangHoa);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        
        public HangHoa loadHangHoaTheoTen(String tenhang)
        {
            return context.HangHoas.Where(h => h.TenHangHoa.Equals(tenhang)).SingleOrDefault();
        }
        public HangHoa loadHangHoaTheoMa(String mahang)
        {
            return context.HangHoas.Where(h => h.MaHangHoa.Equals(mahang)).SingleOrDefault();
        }

        public string chinhSuaGia(string mahang, decimal? gia)
        {
            HangHoa hangHoa = context.HangHoas.Where(h => h.MaHangHoa.Equals(mahang)).SingleOrDefault();
            try
            {
                hangHoa.DonGia = gia;

                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<HangHoa> LoadHangHoaHoatDong()
        {
            return context.HangHoas.Where(h => h.Active.Equals(true)).ToList();
        }
        public List<HangHoa> LoadHangHoa()
        {
            return context.HangHoas.ToList();
        }

        public string themKhuyenMai(string maHH, string maKM)
        {
            try
            {
                HangHoa hh = context.HangHoas.Single(h => h.MaHangHoa.Equals(maHH));
                if (hh != null)
                    hh.MaKhuyenMai = maKM;
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<HangHoa> LoadHangTonKho()
        {
            ThietLap tl = new ThietLap_dal_bll().loadThietLap();
            return context.HangHoas.Where(hh => hh.TonKho <= tl.MucTonKho).ToList();
        }
       
        //public List<String> LoadThongTinHangHoa (string mahanghoa)
        //{
        //    List<String> result = new List<string>();
        //    var hanghoa = (from hh in context.HangHoas
        //                   join ctn in context.ChiTietNhaps
        //                   on hh.MaHangHoa equals ctn.MaHangHoa
        //                   where hh.MaHangHoa.Equals(ctn.MaHangHoa)
        //                   select new
        //                   {
        //                       join_hanghoa = hh,
        //                       join_ctn = ctn
        //                   }).SingleOrDefault();
        //    // add list
        //    result.Add(hanghoa.join_ctn.PhieuNhap.NhaCungCap1.TenNhaCungCap);
        //    result.Add(hanghoa.join_ctn.DonGiaNhap.ToString());
        //    result.Add(hanghoa.join_ctn.PhieuNhap.NgayLap.ToString());
        //    return result;
        //}
        public string insertNewHangHoa(HangHoa hangHoa)
        {
            try
            {
                context.HangHoas.InsertOnSubmit(hangHoa);
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return  e.Message;
            }
        }
       
        public HangHoa kiemTraHangHoaCoTonTai (string tenHang)
        {
            return context.HangHoas.SingleOrDefault(hhoa => hhoa.TenHangHoa == tenHang);
        }

        public int capNhatTinhTrangHangHoa (string tenHangHoa, bool tinhTrang)
        {
            try
            {
                HangHoa getHang = context.HangHoas.Where(h => h.TenHangHoa.Equals(tenHangHoa)).SingleOrDefault();
                if (getHang != null)
                    getHang.Active = tinhTrang;
                context.SubmitChanges();
                return 0;
            }
            catch (Exception)
            {
                return 1;
            }
            
        }
        //public int capNhatSoLuongHangHoa (string maHangHoa, int soluong, bool isReceipt)
        //{

        //    try
        //    {
        //        HangHoa getHang = context.HangHoas.Where(h => h.MaHangHoa.Equals(maHangHoa.Trim())).SingleOrDefault();
        //        if(isReceipt == false)
        //        {
        //            getHang.TonKho += soluong;
        //            context.SubmitChanges();
        //        }    
        //        else
        //        {
        //            if (getHang.TonKho > soluong)
        //            {
        //                getHang.TonKho -= soluong;
        //                context.SubmitChanges();
        //            }
        //            else
        //            {
        //                return -1;
        //            }    
                        
        //        }
        //        return (int)getHang.TonKho;
        //    }
        //    catch (Exception ez)
        //    {
        //        return 1;
        //    }
            
        //}
        
        public int capNhatSoLuongHangHoa2 (string maHangHoa, int soluong, bool isReceipt)
        {
            try
            {
                HangHoa getHang = context.HangHoas.Where(h => h.TenHangHoa.Equals(maHangHoa.Trim())).SingleOrDefault();
                if(isReceipt == false)
                {
                    getHang.TonKho += soluong;
                    context.SubmitChanges();
                }    
                else
                {
                    if (getHang.TonKho > soluong)
                    {
                        getHang.TonKho -= soluong;
                        context.SubmitChanges();
                    }
                    else
                    {
                        return -1;
                    }    
                        
                }    
                return 0;
            }
            catch (Exception)
            {
                return 1;
            }
            
        }
        
    }
}
