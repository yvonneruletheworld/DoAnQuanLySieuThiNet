using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class VaiTro_dal_bll
    {
        QLSIEUTHI_linQDataContext qLSIEUTHI_LinQDataContext = new QLSIEUTHI_linQDataContext();

        public VaiTro_dal_bll()
        {

        }
        public List<VaiTro> loadVaiTro ()
        {
            return qLSIEUTHI_LinQDataContext.VaiTros.ToList();
        }
        public VaiTro loadVaiTroTheoTen (string tenvt)
        {
            return qLSIEUTHI_LinQDataContext.VaiTros.Where(vt => vt.TenVaiTro.Equals(tenvt))
                .SingleOrDefault();
        }
        public List<VaiTro> loadVaiTro (string mpb)
        {
            return qLSIEUTHI_LinQDataContext.VaiTros.Where(vt => vt.MaPhongBan.Equals(mpb))
                .Select(vt => vt).ToList();
        }
        public List<String> loadManHinh (String mavtro)
        {
            return qLSIEUTHI_LinQDataContext.ManHinhs
                .Where(vt => vt.NhomTruyCap.Equals(mavtro.Trim()))
                .Select(mh => mh.TenManHinh).ToList();
        }
        
        public bool kiemTraTonTai (string tenVaiTro)
        {
            return qLSIEUTHI_LinQDataContext.VaiTros
                .Where(x => x.TenVaiTro.Equals(tenVaiTro)).SingleOrDefault() == null ?
                false : true;
        }
        public string themVaiTro (List<VaiTro> vaiTros)
        {
            try
            {
                var newRC = from field in vaiTros
                            select new VaiTro
                            {
                                MaVaiTro = field.MaVaiTro,
                                TenVaiTro = field.TenVaiTro,
                                MaPhongBan = field.MaPhongBan
                            };
                qLSIEUTHI_LinQDataContext.VaiTros.InsertAllOnSubmit(newRC);
                qLSIEUTHI_LinQDataContext.SubmitChanges();
                return "OK";
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public string xoaVaiTro (string vaiTros)
        {
            try
            {
                if(kiemTraTonTaiNhanVien(vaiTros) == false && kiemTraTonTaiChucNang(vaiTros) == false)
                {
                    qLSIEUTHI_LinQDataContext.XoaVaiTro(vaiTros);
                    return "OK";
                }
                return "Have";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private bool kiemTraTonTaiChucNang(string vaiTros)
        {
            return qLSIEUTHI_LinQDataContext.KiemTraChucNangVaiTro(vaiTros).ToList()
                .Count() == 0 ? false : true;
        }

        private bool kiemTraTonTaiNhanVien(string vaiTros)
        {
            return qLSIEUTHI_LinQDataContext.KiemTraNhanVienVaiTro(vaiTros).ToList()
                .Count() == 0 ? false : true;
        }

        public string suaVaiTro (VaiTro vaiTros)
        {
            try
            {
                VaiTro item = qLSIEUTHI_LinQDataContext.VaiTros.Single(i => i.MaVaiTro.Equals(vaiTros.MaVaiTro.Trim()));

                item.TenVaiTro = vaiTros.TenVaiTro;
                qLSIEUTHI_LinQDataContext.SubmitChanges();
                return "OK";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
