using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PhanQuyen_NguoiDung_VaiTro_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();

        public List<PhanQuyen_NguoiDung_VaiTro> loadNguoiDungVaiTro()
        {
            return context.PhanQuyen_NguoiDung_VaiTros.ToList();
        }
        public List<VaiTro> loadVaiTro(String mnd)
        {
            return context.PhanQuyen_NguoiDung_VaiTros.Where(n => n.MaNguoiDung == mnd.Trim())
                .Select(vt => vt.VaiTro).ToList();
        }
        public PhanQuyen_NguoiDung_VaiTro loadVaiTro(String mnd, String mvt)
        {
            return context.PhanQuyen_NguoiDung_VaiTros.Where(n => n.MaNguoiDung == mnd.Trim()
            && n.MaVaiTro.Equals(mvt)).SingleOrDefault();
        }
        
        public String loadTenVaiTro(String mnd)
        {
            string rs = "";
            List<String> vts = context.PhanQuyen_NguoiDung_VaiTros.Where(n => n.MaNguoiDung == mnd.Trim())
                .Select(vt => vt.VaiTro.TenVaiTro).ToList();
            foreach( String vt in vts)
            {
                rs += vt + ", ";
            }
            return rs;
        }
        public string phanQuyen(PhanQuyen_NguoiDung_VaiTro pq)
        {
            try
            {
                if (khongTonTaiPQ(pq) == true)
                {
                    context.PhanQuyen_NguoiDung_VaiTros.InsertOnSubmit(pq);
                    context.SubmitChanges();
                    return "OK";
                }
                else
                {
                    return "Have";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string xoaPhanQuyen(String mapq)
        {
            try
            {
                PhanQuyen_NguoiDung_VaiTro pq = context.PhanQuyen_NguoiDung_VaiTros
                    .Where(item => item.MaPhanQuyen.Equals(mapq)).SingleOrDefault();
                    context.PhanQuyen_NguoiDung_VaiTros.DeleteOnSubmit(pq);
                    context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string updatePhanQuyen(PhanQuyen_NguoiDung_VaiTro phanQuyen)
        {
            PhanQuyen_NguoiDung_VaiTro pq = context.PhanQuyen_NguoiDung_VaiTros.Single(i => i.MaPhanQuyen.Equals(phanQuyen.MaPhanQuyen));

            pq.MaNguoiDung = phanQuyen.MaNguoiDung;
            pq.MaVaiTro = phanQuyen.MaVaiTro;
            pq.ThoiGianBatDau = phanQuyen.ThoiGianBatDau;
            pq.ThoiGianKetThuc = phanQuyen.ThoiGianKetThuc;

            // Submit the changes to the database.
            try
            {
                context.SubmitChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private bool khongTonTaiPQ(PhanQuyen_NguoiDung_VaiTro pg)
        {
            return context.PhanQuyen_NguoiDung_VaiTros.Where(x => x.MaNguoiDung.Equals(pg.MaNguoiDung)
            && x.MaVaiTro.Equals(pg.MaVaiTro)).SingleOrDefault() == null ? true : false;
        }

        public List<PhanQuyen_NguoiDung_VaiTro> loadNguoiDungVaiTro(string mavt, string tend)
        {
            List<PhanQuyen_NguoiDung_VaiTro> rs = context.PhanQuyen_NguoiDung_VaiTros
                .Where(pqcnvt => pqcnvt.MaVaiTro.Equals(mavt.Trim())
                && !pqcnvt.MaNguoiDung.Equals(tend)).ToList();
            return rs;
        }
    }
}
