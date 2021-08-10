using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PhanQuyen_VaiTro_ChucNang_dal_bll
    {
        QLSIEUTHI_linQDataContext context = new QLSIEUTHI_linQDataContext();

        public List<PhanQuyen_VaiTro_ChucNang> loadChucNangTheoVaiTro()
        {
            return context.PhanQuyen_VaiTro_ChucNangs.ToList();
        }

        public string phanQuyen(PhanQuyen_VaiTro_ChucNang pq)
        {
            try
            {
                if (khongTonTaiPQ(pq) == true)
                {
                    context.PhanQuyen_VaiTro_ChucNangs.InsertOnSubmit(pq);
                    context.SubmitChanges();
                    return "OK";
                }
                else
                {
                    return "Chức năng này đã được chọn";
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
                var query = from item in context.PhanQuyen_VaiTro_ChucNangs
                            where item.MaPhanQuyen.Equals(mapq)
                            select item;

                foreach(PhanQuyen_VaiTro_ChucNang rc in query)
                {
                    context.PhanQuyen_VaiTro_ChucNangs.DeleteOnSubmit(rc);
                    context.SubmitChanges();
                }
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string updatePhanQuyen2(String newMacn, String mapq, string tgtc)
        {
            var query =
                from pqvtcn in context.PhanQuyen_VaiTro_ChucNangs
                where pqvtcn.MaPhanQuyen == mapq
                select pqvtcn;

            foreach (PhanQuyen_VaiTro_ChucNang ord in query)
            {
                //ord.MaChucNang = newMacn;
                PhanQuyen_VaiTro_ChucNang newpq = new PhanQuyen_VaiTro_ChucNang();
                newpq.MaPhanQuyen = ord.MaPhanQuyen;
                newpq.MaVaiTro = ord.MaVaiTro;
                newpq.MaChucNang = newMacn;
                newpq.ThoiGianTruyCap = tgtc;
                context.PhanQuyen_VaiTro_ChucNangs.DeleteOnSubmit(ord);
                context.PhanQuyen_VaiTro_ChucNangs.InsertOnSubmit(newpq);
            }

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

        private bool khongTonTaiVT(string mavt)
        {
            return context.PhanQuyen_VaiTro_ChucNangs.Where(x => x.VaiTro.Equals(mavt))
                .SingleOrDefault() == null ? true : false;
        }

        private bool khongTonTaiPQ(PhanQuyen_VaiTro_ChucNang pg)
        {
            return context.PhanQuyen_VaiTro_ChucNangs.Where(x => x.MaChucNang.Equals(pg.MaChucNang)
            && x.MaVaiTro.Equals(pg.MaVaiTro)).SingleOrDefault() == null ? true : false;
        }

        public List<PhanQuyen_VaiTro_ChucNang> loadChucNangTheoVaiTro (String mavt)
        {
            return context.PhanQuyen_VaiTro_ChucNangs.Where(pqcnvt => pqcnvt.MaVaiTro.Equals(mavt.Trim())).ToList();
        }
    }
}
