using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BLL;
using DevExpress.XtraGrid.Views.Grid;
using Guna.UI.WinForms;
using GUI.MODEL;
using DevExpress.XtraBars.Navigation;
using DevExpress.Utils.Menu;

namespace GUI
{
    public partial class UC_KhoHang : DevExpress.XtraEditors.XtraUserControl
    {
        GUI_Control control = new GUI_Control();
        ThongTinCuaHang_dal_bll thongTinCuaHang_Dal_Bll = new ThongTinCuaHang_dal_bll();
        NhaCungCap_dal_bll nhaCungCap_Dal_Bll = new NhaCungCap_dal_bll();
        DatHang_dal_bll datHang_Dal_Bll = new DatHang_dal_bll();
        CTDatHang_dal_bll cTDatHang_Dal_Bll = new CTDatHang_dal_bll();
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        PhieuNhap_dal_bll phieuNhap_Dal_Bll = new PhieuNhap_dal_bll();
        LoaiHangHoa_dal_bll loaiHangHoa_Dal_Bll = new LoaiHangHoa_dal_bll();
        CTPhieuNhap_dal_bll cTPhieuNhap_Dal_Bll = new CTPhieuNhap_dal_bll();
        List<ChiTietDatHang> lstCTDH;
        List<ChiTietNhap> lstCTNH;
        DatHang dh;
        decimal thanhtien;
        DXMenuItem[] menu = null;
        InWordExport data = new InWordExport();
        WordExport word = new WordExport();
        public UC_KhoHang()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            init();
        }

        private void init()
        {
            loadDatHang();
            lbl_Username.Text = COMMON.currentUser.HoTen;
        }

        private void loadNhapHang()
        {
            phieuNhapBindingSource.DataSource = new BindingList<PhieuNhap>
            (phieuNhap_Dal_Bll.loadPhieuNhap());
            lstCTNH = cTPhieuNhap_Dal_Bll.loadChiTietNhap().ToList();
        }


        private void loadDatHang()
        {
            datHangBindingSource.DataSource = new BindingList<DatHang>
                (datHang_Dal_Bll.loadDatHang());
            lstCTDH = cTDatHang_Dal_Bll.loadCTDatHang().ToList();
            loadThongTinDat();
        }

        private void loadThongTinDat()
        {
            nhaCungCapBindingSource.DataSource = new BindingList<NhaCungCap>
                (nhaCungCap_Dal_Bll.loadNhaCungCap().ToList());
            thongTinSieuThiBindingSource.DataSource = thongTinCuaHang_Dal_Bll.loadThongtinSieuThi();
            loaiHangHoaBindingSource.DataSource = loaiHangHoa_Dal_Bll.loadLoaiHangHoa();
        }

        private void gvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle >= 0)
            {
                PhieuNhap pn = gvPhieuNhap.GetFocusedRow() as PhieuNhap;
            }
        }

        private void gvDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle >= 0)
            {
                DatHang dh = gvDatHang.GetRow(e.FocusedRowHandle) as DatHang;
                loadThongTinDonDat(dh);
            }
        }

        private void loadThongTinDonDat(DatHang dh)
        {
            if (dh.CanTraNhaCungCap == null || dh.TongTienHang == null || dh.GiamGia == null
                || dh.ChiPhiPhatSinh == null || dh.NgayLap == null)
                return;
            else
            {
                txt_MaDatHang.Text = dh.MaPhieuDatHangNhap;
                lbl_CanTra.Text = new StringBuilder(dh.CanTraNhaCungCap.ToString()).Append(" VND").ToString();
                lbl_TongTienHang.Text = new StringBuilder(dh.TongTienHang.ToString()).Append(" VND").ToString();
                cboGiamGia.Text = dh.GiamGia.ToString();
                txt_ps.Text = new StringBuilder(dh.ChiPhiPhatSinh.ToString()).Append(" VND").ToString();
                de_ngayDat.EditValue = dh.NgayLap;
            }    
            
        }

        private void gvPhieuNhap_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView gv = sender as  GridView;
            PhieuNhap pn = gv.GetRow(e.RowHandle) as PhieuNhap;
            if (pn != null && lstCTNH != null)
                e.IsEmpty = !lstCTNH.Any(ct => ct.MaPhieuNhap.Equals(pn.MaPhieuNhap));
        }

        private void gvPhieuNhap_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView gv = sender as GridView;
            PhieuNhap pn = sender as PhieuNhap;
            if (pn != null && lstCTNH != null)
                e.ChildList = lstCTNH.Where(ct => ct.MaPhieuNhap.Equals(pn.MaPhieuNhap)).ToList();
        }

        private void gvPhieuNhap_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvPhieuNhap_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Chi Tiết Phiếu Nhập";
        }

        private void gvDatHang_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView gv = sender as GridView;
            DatHang pn = sender as DatHang;
            if (pn != null && lstCTDH != null)
                e.IsEmpty = !lstCTDH.Any(ct => ct.MaPhieuDat.Equals(pn.MaPhieuDatHangNhap));

        }

        private void gvDatHang_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView gv = sender as GridView;
            DatHang pn = sender as DatHang;
            if (pn != null && lstCTNH != null)
                e.ChildList = lstCTDH.Where(ct => ct.MaPhieuDat.Equals(pn.MaPhieuDatHangNhap)).ToList();

        }

        private void gvDatHang_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvDatHang_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Chi Tiết Phiếu Đặt";
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_add":
                    txt_MaDatHang.Text = "DHN" + control.RandomCode();
                    cleanText();
                    enabledText();
                    break;
                case "btnCan":
                    disabledText();
                    dataTable_PhieuDat.Rows.Clear();
                    break;
                case "btn_save":
                    if(validatonCcb() == true)
                    {
                        luuDonDat();
                        disabledText();
                    }    
                    else
                        new UC_Message().showAlert("Chưa đủ thông tin", UC_Message.enmType.Warning);
                    break;
                case "btnImport":
                    dataTable_PhieuDat.Rows.Clear();
                    nhapPhieuDatBangExcel();
                    kiemTraMatHangBangKhong();
                    break;
                case "btn_xoa":
                    xoaDonDat();
                    break;
            }
        }

        private void kiemTraMatHangBangKhong()
        {
            for (int i = 0; i < dataTable_PhieuDat.RowCount - 1; i++)
            {
                try
                {
                    int sl = int.Parse(dataTable_PhieuDat.Rows[i].Cells[2].Value.ToString());
                    if (sl < 1)
                    {
                        new UC_Message().showAlert("Số lượng không hợp lệ", UC_Message.enmType.Info);
                        btn_save.Enabled = false;
                        break;
                    }
                    else
                    {
                        btn_save.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    new UC_Message().showAlert(ex.Message, UC_Message.enmType.Error);
                }

            }
        }

        private void xoaDonDat()
        {
            int rh = gvDatHang.FocusedRowHandle;
            if (rh >= 0)
            {
                DatHang dh = gvDatHang.GetRow(rh) as DatHang;
                if(dh.SoTienPhaiTra != 0)
                {
                    string rs = datHang_Dal_Bll.xoaDonDat(dh);
                    if (rs.Contains("OK"))
                    {
                        new UC_Message().showAlert("Đã xóa đơn đặt" + dh.MaPhieuDatHangNhap, UC_Message.enmType.Success);
                        loadDatHang();
                    }
                    else
                    {
                        new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                        return;
                    }
                }    
                else
                {
                    if (dh != null)
                    {
                        if (cTDatHang_Dal_Bll.xoaChiTietDat(dh).Contains("OK"))
                        {
                            loadDatHang();
                        }
                        else
                        {
                            new UC_Message().showAlert("Đơn đặt đã có phiếu nhập", UC_Message.enmType.Error);
                        }
                    }
                    else 
                        new UC_Message().showAlert("Không thể xóa", UC_Message.enmType.Warning);
                    return;
                }    
            }    
            else
            {
                new UC_Message().showAlert("Không hợp lệ", UC_Message.enmType.Warning);
                return;
            }    
        }

        private void cleanText()
        {
            txt_ps.Text = "0";
            txt_pspn.Text = "0";
            lbl_CanTra.Text = "";
            lbl_cantranhap.Text = "";
            lbl_TongTienHang.Text = "";
            lbl_tongtienhangnhap.Text = "";
            de_ngayDat.EditValue = null;
            de_dk.EditValue = null;
            ccb_ncc.Properties.NullText = "Chọn";
        }

        private bool validatonCcb()
        {
            if (ccb_chinhanh.EditValue == null || ccb_dtc.EditValue == null || ccb_loaihang.EditValue == null)
                return false;
            else
                return true;
        }

        private void luuDonDat()
        {
            DatHang dh = new DatHang();
            string rs = "";
            //them don dat hang
            if (taoPhieuDatHang(dh) == 0)
            {
                //luu thong tin dat hang va tam tinh
                //tao mat hang
                for (int i = 0; i < dataTable_PhieuDat.RowCount - 1; i++)
                {
                    string tenhang = dataTable_PhieuDat.Rows[i].Cells[0].Value.ToString();
                    if (tenhang != "")
                    {
                        HangHoa h = hangHoa_Dal_Bll.kiemTraHangHoaCoTonTai(tenhang);
                        //
                        try
                        {
                            if (h != null)
                            {
                                control.capNhatSoLuongHang(dataTable_PhieuDat, i);
                                rs = taoChiTietDHMoi(h, i);
                            }
                            else
                            {
                                HangHoa hh = new HangHoa();
                                hh.MaHangHoa = "HH" + control.RandomCode();
                                hh.MaNhom = ccb_loaihang.EditValue.ToString();
                                hh.ViTri = "Quay";
                                hh.TonKho = int.Parse(dataTable_PhieuDat.Rows[i].Cells[2].Value.ToString());
                                hh.TenHangHoa = dataTable_PhieuDat.Rows[i].Cells[0].Value.ToString();
                                hh.Seri = "0";
                                hh.Mota = 0;
                                hh.GiaVon = decimal.Parse(dataTable_PhieuDat.Rows[i].Cells[3].Value.ToString()); 
                                hh.DonGia = decimal.Parse(dataTable_PhieuDat.Rows[i].Cells[3].Value.ToString());
                                hh.DonVi = dataTable_PhieuDat.Rows[i].Cells[1].Value.ToString();
                                hh.Active = false;
                                hh.Anh = null;
                                hh.prd_congdung = dataTable_PhieuDat.Rows[i].Cells[5].Value.ToString();
                                hh.prd_dungtic = dataTable_PhieuDat.Rows[i].Cells[6].Value.ToString(); 
                                hh.prd_nhanhang = dataTable_PhieuDat.Rows[i].Cells[7].Value.ToString();
                                hh.prd_xuatxu = dataTable_PhieuDat.Rows[i].Cells[8].Value.ToString();
                                string thh = hangHoa_Dal_Bll.insertNewHangHoa(hh);
                                if (thh.Contains("OK"))
                                {
                                    rs = taoChiTietDHMoi(hh, i);
                                }
                                else
                                {
                                    new UC_Message().showAlert(thh, UC_Message.enmType.Error);
                                    continue;
                                }

                            }
                        }
                        catch (Exception e)
                        {
                            new UC_Message().showAlert(e.Message, UC_Message.enmType.Error);
                            continue;
                        }
                        
                    }
                
                }

                if (rs.Contains("OK"))
                {
                    new UC_Message().showAlert("Đã tạo phiếu đặt", UC_Message.enmType.Success);
                }
                loadDatHang();
                dataTable_PhieuDat.Rows.Clear();
            }
        }

        public string taoChiTietDHMoi(HangHoa newHang,int i)
        {
            ChiTietDatHang ct = new ChiTietDatHang();
            ct.MaChiTietDatHang = "CTDH" + control.RandomCode();
            ct.MaHangHoa = newHang.MaHangHoa;
            ct.MaPhieuDat = txt_MaDatHang.Text.Trim();
            ct.SoLuong = int.Parse(dataTable_PhieuDat.Rows[i].Cells[2].Value.ToString());
            ct.GiaNhap = decimal.Parse((dataTable_PhieuDat.Rows[i].Cells[3].Value.ToString()));
            return cTDatHang_Dal_Bll.insertNewCTDatHang(ct);
        }
        private int taoPhieuDatHang(DatHang dh)
        {
            dh.MaPhieuDatHangNhap = txt_MaDatHang.Text.Trim();
            dh.TongTienHang = control.datHang_tongTienHangDat(dataTable_PhieuDat);
            dh.NhanVien = COMMON.currentUser.TenDangNhap;
            if (de_ngayDat.EditValue != null && de_dk.EditValue != null)
            {
                dh.NgayLap = (DateTime?)de_ngayDat.EditValue;
                dh.DuKienNgayNhapKho = (DateTime?)de_dk.EditValue;
            }
            else
            {
                dh.NgayLap = DateTime.Now;
                dh.DuKienNgayNhapKho = null;
            }
            if(cboGiamGia.Text != "")
            {
                dh.GiamGia = int.Parse(cboGiamGia.Text.Replace("%", "").ToString());
            }
            else
            {
                dh.GiamGia = 0;
            }
            dh.ChiPhiPhatSinh = decimal.Parse(txt_ps.Text.ToString());
            dh.NhaCungCap = ccb_dtc.EditValue.ToString();
            
            dh.GhiChu = "";
            dh.ChiNhanh = ccb_chinhanh.EditValue.ToString();
            // so tien phai tra
            dh.CanTraNhaCungCap = dh.TongTienHang - (dh.TongTienHang * (dh.GiamGia / 100)) + dh.ChiPhiPhatSinh;
            //so tien ma cty muon tra
            dh.SoTienPhaiTra = 0;

            string rs = datHang_Dal_Bll.insertNewDatHang(dh);
            if(rs.Contains("OK"))
            {
                //new UC_Message().showAlert("Đã thêm đơn đặt", UC_Message.enmType.Success);
                loadDatHang();
                txt_MaDatHang.Text = dh.MaPhieuDatHangNhap;
                return 0;
            }    
            else
            {
                new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                return 1;
            }
        }

        private void nhapPhieuDatBangExcel()
        {
            
            // mo file excel
            dataTable_PhieuDat.DataSource = null;
            string _pathFilePhieuDat = control.openExcelFile(openFileDialog1);
            control.importOrderByExcel(_pathFilePhieuDat, dataTable_PhieuDat);
            //MessageBox.Show(dataTable_PhieuDat.RowCount.ToString());
        }

        private void enabledText()
        {
            ccb_dtc.Enabled = true;
            txt_themdt.Enabled = true;
            ccb_loaihang.Enabled = true;
            ccb_chinhanh.Enabled = true;
            txt_ps.Enabled = true;
            btnCan.Enabled = true;
            btn_save.Enabled = true;
            btnImport.Enabled = true;
            btn_xoa.Enabled = false;
            gcDatHang.Enabled = false;
            de_dk.Enabled = true;
            de_ngayDat.Enabled = true;
            gcPhieuNhap.Enabled = false;
            ccb_ncc.Enabled = true;
            de_ngaynhap.Enabled = true;
            btn_savepnn.Enabled = true;
            ccb_pd.Enabled = true;

        }

        private void disabledText()
        {
            ccb_dtc.Enabled = false;
            txt_themdt.Enabled = false;
            ccb_loaihang.Enabled = false;
            ccb_chinhanh.Enabled = false;
            txt_ps.Enabled = false;
            btnCan.Enabled = false;
            btn_save.Enabled = false;
            btnImport.Enabled = false;
            btn_xoa.Enabled = true;
            gcDatHang.Enabled = true;
            de_dk.Enabled = false;
            de_ngayDat.Enabled = false;
            gcPhieuNhap.Enabled = true;
            ccb_ncc.Enabled = false;
            de_ngaynhap.Enabled = false;
            btn_savepnn.Enabled = false;
            ccb_pd.Enabled = false;

        }

        private void dataTable_PhieuDat_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            thanhtien = control.datHang_tongTienHangDat(dataTable_PhieuDat);
            lbl_CanTra.Text = new StringBuilder(thanhtien.ToString()).Append(" VND").ToString();
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            TabNavigationPage page = e.Page as TabNavigationPage;
            if(page.Name.Equals("tabNavigationPage2"))
            {
                init2();
            }
            else
            {
                init();
            }
        }

        private void init2()
        {
            loadNhapHang();
            gunaLabel23.Text = COMMON.currentUser.HoTen;
            loadCcbDatHang();
        }

        private void loadCcbDatHang()
        {
            List < DatHang > lstDH = datHang_Dal_Bll.loadDonChuaDuyet();
            if (lstDH.Count == 0 || lstDH == null)
                ccb_pd.Properties.NullText = "Không có đơn đặt";
            else
            {
                datHangBindingSource1.DataSource = lstDH;
            }

        }

        private void ccb_pd_EditValueChanged(object sender, EventArgs e)
        {
            if(ccb_pd.EditValue != null)
            {
                ccb_gg.Enabled = false;
                ccb_ncc.Enabled = false;
                //

                dh = datHang_Dal_Bll.loadDatHang(ccb_pd.EditValue.ToString().Trim());
                if(dh != null)
                {
                    lbl_cantranhap.Text = new StringBuilder(dh.CanTraNhaCungCap.ToString()).Append(" VND").ToString();
                    lbl_tongtienhangnhap.Text = new StringBuilder(dh.TongTienHang.ToString()).Append(" VND").ToString();
                    de_ngaynhap.Value = (DateTime)dh.NgayLap;
                    txt_pspn.Text = dh.ChiPhiPhatSinh.ToString();
                    ccb_ncc.EditValue = dh.NhaCungCap;
                    txt_ThucTra.Text = dh.CanTraNhaCungCap.ToString();
                    hienThiChiTietPhieuNhap(dh.MaPhieuDatHangNhap);
                }
            }    
        }

        private void hienThiChiTietPhieuNhap(string ma)
        {
            dataTable_CTPhieuNhap.Rows.Clear();
            List<ChiTietDatHang> list = cTDatHang_Dal_Bll.loadCTDatHang(ma);
            {
                foreach (ChiTietDatHang ct in list)
                {
                    dataTable_CTPhieuNhap.Rows.Add(ct.HangHoa.TenHangHoa, ct.HangHoa.DonVi, ct.SoLuong, ct.GiaNhap, ct.SoLuong * ct.GiaNhap);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_addpn":
                    txt_mapn.Text = "PN" + control.RandomCode();
                    cleanText();
                    enabledText();
                    break;
                case "btnCanpn":
                    disabledText();
                    dataTable_CTPhieuNhap.Rows.Clear();

                    break;
                case "btn_savepnn":
                    if (txt_ThucTra.Text != "0")
                    {
                        luuPhieuNhap();
                    }
                    else
                        new UC_Message().showAlert("Chưa đủ thông tin", UC_Message.enmType.Warning);
                    break;
                case "btn_xoapnn":
                    xoaPN();
                      break;
                case "gunaAdvenceButton6":
                    string _pathFilePhieuDat = control.openExcelFile(openFileDialog1);
                    control.importOrderByExcel(_pathFilePhieuDat, dataTable_CTPhieuNhap);
                    break;
            }
        }

        private void xoaPN()
        {
            int rh = gvPhieuNhap.FocusedRowHandle;
            if (rh >= 0)
            {
                PhieuNhap dh = gvPhieuNhap.GetRow(rh) as PhieuNhap;
               
                    string rs = phieuNhap_Dal_Bll.xoaPhieuNhap(dh);
                    if (rs.Contains("OK"))
                    {
                        new UC_Message().showAlert("Đã xóa " + dh.MaPhieuDat, UC_Message.enmType.Success);
                        loadNhapHang();
                    }
                    else
                    {
                        new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                        return;
                    }
            }
            else
            {
                new UC_Message().showAlert("Không hợp lệ", UC_Message.enmType.Warning);
                return;
            }
        }

        private void luuPhieuNhap()
        {
            List<String> mahhNhaps = new List<string>();
            if (kiemTraDonNhap(mahhNhaps).Count == 0)
            {
                PhieuNhap pn = taoPhieuNhap();
                if ( pn!= null && phieuNhap_Dal_Bll.insertNewPhieuNhap(pn).Contains("OK"))
                {
                    init2();
                    taoCTPhieuNhap();

                    capNhatTinhHinhHangHoa(mahhNhaps);
                    /// làm trong này nè mã phiếu nhâp: pn.MaPhieuNhap
                    try
                    {
                        PhieuNhap _pn = data.getPN(pn.MaPhieuNhap);

                        NguoiDung nd = data.getND(_pn.NhanVien);

                        List<ChiTietNhap> ctn = data.getCTN(_pn.MaPhieuNhap);

                        NhaCungCap ncc = data.getNCC(_pn.NhaCungCap);



                        DateTime getday = Convert.ToDateTime(_pn.NgayLap);

                        string Ngay = getday.Day.ToString();

                        string Thang = getday.Month.ToString();

                        string Nam = getday.Year.ToString();

                        string SoPhieu = _pn.MaPhieuNhap;

                        string HoTenNguoiGiao = nd.HoTen;

                        string SoHoaDon = SoPhieu;

                        string DonViCungCap = ncc.TenNhaCungCap;

                        string DiaChi = ncc.DiaChi;

                        string STT = "0";

                        string TenSanPham = "";

                        string MaSanPhan = "";

                        string DonViTinh = "";

                        string SoLuong = "";

                        string DonGia = "";

                        string ThanhTien = "";

                        int sum = 0;

                        int i = 1;

                        foreach (ChiTietNhap item in ctn)
                        {
                            HangHoa hh;

                            if (STT == "0")
                            {
                                hh = new HangHoa();

                                hh = data.getHH(item.MaHangHoa);

                                STT = i.ToString();

                                TenSanPham = hh.TenHangHoa;

                                MaSanPhan = hh.MaHangHoa;

                                DonViTinh = hh.DonVi;

                                SoLuong = item.SoLuongNhap.ToString();

                                int value = Convert.ToInt32(item.DonGiaNhap);

                                Decimal _Dongia = Convert.ToDecimal(value);

                                DonGia = String.Format("{0:0,0 VND}", _Dongia).Replace(",", ".");

                                int value2 = Convert.ToInt32(item.SoLuongNhap * item.DonGiaNhap);

                                Decimal _ThanhTien = Convert.ToDecimal(value2);

                                ThanhTien = String.Format("{0:0,0 VND}", _ThanhTien).Replace(",", ".");

                                sum = Convert.ToInt32(item.SoLuongNhap) * Convert.ToInt32(item.DonGiaNhap);

                                i++;
                            }
                            else
                            {
                                hh = new HangHoa();

                                hh = data.getHH(item.MaHangHoa);

                                STT = STT + "\n" + i;

                                TenSanPham = TenSanPham + "\n" + hh.TenHangHoa;

                                MaSanPhan = MaSanPhan + "\n" + hh.MaHangHoa;

                                DonViTinh = DonViTinh + "\n" + hh.DonVi;

                                SoLuong = SoLuong + "\n" + item.SoLuongNhap.ToString();

                                int value = Convert.ToInt32(item.DonGiaNhap);

                                Decimal _Dongia = Convert.ToDecimal(value);

                                String inputDonGia = String.Format("{0:0,0 VND}", _Dongia).Replace(",", ".");

                                DonGia = DonGia + "\n" + inputDonGia;

                                int value2 = Convert.ToInt32(item.SoLuongNhap * item.DonGiaNhap);

                                Decimal _ThanhTien = Convert.ToDecimal(value2);

                                String inputThanhTien = String.Format("{0:0,0 VND}", _ThanhTien).Replace(",", ".");

                                ThanhTien = ThanhTien + "\n" + inputThanhTien;

                                sum = sum + (Convert.ToInt32(item.SoLuongNhap) * Convert.ToInt32(item.DonGiaNhap));

                                i++;
                            }


                        }

                        Decimal _Tong = Convert.ToDecimal(sum);

                        String Tong = String.Format("{0:0,0 VND}", _Tong).Replace(",", ".");

                        word.BaoCaoPhieuNhap(Ngay, Thang, Nam, SoPhieu, HoTenNguoiGiao, SoHoaDon, DonViCungCap, DiaChi, STT, TenSanPham, MaSanPhan, DonViTinh, SoLuong, DonGia, ThanhTien, Tong);

                    }
                    catch
                    {
                        MessageBox.Show("Fail");
                    }
                    disabledText();
                    loadNhapHang();
                    dataTable_CTPhieuNhap.Rows.Clear();
                }
                else
                {
                    new UC_Message().showAlert("Lỗi tạo phiếu nhập", UC_Message.enmType.Error);
                }    
            }
            else
            {
                new UC_Message().showAlert("Chưa lập đơn đặt cho phiếu nhập này", UC_Message.enmType.Error);
            }
        }

        private void taoCTPhieuNhap()
        {
            string rs = "";
            for (int i = 0; i < dataTable_CTPhieuNhap.RowCount - 1; i++)
            {
                HangHoa hh = hangHoa_Dal_Bll.loadHangHoaTheoTen(dataTable_CTPhieuNhap.Rows[i].Cells[0].Value.ToString());
                rs = taoCTPhieuNhap(hh, i);
                if(rs != "OK")
                {
                    //new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                    continue;
                }
            }
            
            new UC_Message().showAlert("Đã thêm phiếu nhập", UC_Message.enmType.Success);
            disabledText();
            dataTable_PhieuDat.Rows.Clear();
        }

        public string taoCTPhieuNhap(HangHoa newHang, int i)
        {
            ChiTietNhap ct = new ChiTietNhap();
            ct.MaChiTietNhap = "CTN" + control.RandomCode();
            ct.MaPhieuNhap = txt_mapn.Text.Trim();
            ct.MaHangHoa = newHang.MaHangHoa;
            ct.SoLuongNhap = int.Parse(dataTable_CTPhieuNhap.Rows[i].Cells[2].Value.ToString());
            ct.DonGiaNhap = decimal.Parse((dataTable_CTPhieuNhap.Rows[i].Cells[3].Value.ToString()));
            return cTPhieuNhap_Dal_Bll.insertNewChiTietNhap(ct);
        }

        private PhieuNhap taoPhieuNhap()
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieuNhap = txt_mapn.Text.ToString().Trim();
            pn.MaPhieuDat = ccb_pd.EditValue.ToString().Trim();
            pn.TongTienHang = decimal.Parse(txt_ThucTra.Text.ToString().Replace("VND","").Trim());
            pn.NhanVien = COMMON.currentUser.TenDangNhap.Trim();
            pn.NgayLap = de_ngaynhap.Value;
            pn.GiamGia = 0;
            pn.ChiPhiPhatSinh = decimal.Parse(txt_pspn.Text.ToString());
            pn.NhaCungCap = ccb_ncc.EditValue.ToString().Trim();
            pn.GhiChu = "";
            if(dh != null)
            {
                pn.ChiNhanh = dh.ChiNhanh;

            }
            // so tien phai tra
            pn.CanTraNhaCungCap = pn.TongTienHang - (pn.TongTienHang * (pn.GiamGia / 100)) + pn.ChiPhiPhatSinh;
            //so tien ma cty muon tra
            pn.SoTienPhaiTra = decimal.Parse(txt_ThucTra.Text.ToString().Trim());
            if (rdo_CongNo.Checked)
            {
                pn.CongNo = true;
                taoCongNo();
            }

            return pn;
        }

        private void taoCongNo()
        {
            CongNo cn = new CongNo();
        }

        private void capNhatTinhHinhHangHoa(List<string> mahangs)
        {
            foreach (String ma in mahangs)
            {
                if (hangHoa_Dal_Bll.capNhatTinhTrangHangHoa(ma, true) == 1)
                {
                    new UC_Message().showAlert("Đã xảy ra lỗi", UC_Message.enmType.Error);
                    return;
                }
            }
            new UC_Message().showAlert("Cập nhật hàng hóa", UC_Message.enmType.Success);
        }

        private List<String> kiemTraDonNhap(List<string> mahangs)
        {
            for (int i = 0; i < dataTable_CTPhieuNhap.RowCount - 1; i++)
            {
                mahangs.Add(dataTable_CTPhieuNhap.Rows[i].Cells[0].Value.ToString().Trim());
            }
            List<String> hangMois = cTDatHang_Dal_Bll.kiemTraHangNhap(mahangs, ccb_pd.EditValue.ToString().Trim());
            return hangMois;
        }

        private void rdo_CongNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_CongNo.Checked == true)
            {
                rdo_CongNo.Checked = false;
            }
        }

        private void gvChiTietDat_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            
        }

        private void gvDatHang_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            DXMenuItem xoa = new DXMenuItem("Xóa", ItemXoa_Click);
            menu = new DXMenuItem[] { xoa};
        }

        private void ItemXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void gvDatHang_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {

        }

        private void dataTable_CTPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
