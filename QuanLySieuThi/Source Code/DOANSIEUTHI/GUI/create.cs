using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;
using DevExpress.XtraEditors;
using GUI.MODEL;
using System.Globalization;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using FireSharp.Response;

namespace GUI
{
    public partial class create : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        CTHoaDon_dal_bll cTHoaDon_Dal_Bll = new CTHoaDon_dal_bll();
        HoaDon_dal_bll hoaDon_Dal_Bll = new HoaDon_dal_bll();
        KhachHang_dal_bll khachHang_Dal_Bll = new KhachHang_dal_bll();
        Voucher_dal_bll voucher_Dal_Bll = new Voucher_dal_bll();
        GUI_Control control = new GUI_Control();
        double tongTien , cantra , giamgia ;
        decimal dg; int sl, giam, soBillCu;
        string makm, mkh, im;
        private bool isVoucher = false;
        DXMenuItem[] menuItems;
        InWordExport data = new InWordExport();
        WordExport word = new WordExport();
        //private string lbl_mahoadon;

        //public string Lbl_mahoadon { get => lbl_mahoadon; set => lbl_mahoadon = value; }

        public create(string mahd)
        {
            InitializeComponent();
            this.im = mahd;
            init();
            insertHoaDon();
            generalHoaDon();
            InitializeMenuItems();
            //lbl_mahoadon = lbl_MaHoaDon.Text;
        }

        private void InitializeMenuItems()
        {
            DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
            DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
            menuItems = new DXMenuItem[] { itemEdit, itemDelete };

        }

        private void ItemEdit_Click(object sender, System.EventArgs e)
        {
            gvChiTiet.ShowEditor();
        }
        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            double spx = Double.Parse(gvChiTiet.GetFocusedRowCellValue(colThanhTien).ToString());
            
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
            lbl_TongTienHang.Text = (tongTien -= spx)
                .ToString("#,###", cultureInfo.NumberFormat);
            if (giamgia != 0)
                lbl_CanTra.Text = (tongTien - giamgia)
                    .ToString("#,###", cultureInfo.NumberFormat);
            else
                lbl_CanTra.Text = tongTien
                    .ToString("#,###", cultureInfo.NumberFormat);

            gvChiTiet.DeleteRow(gvChiTiet.FocusedRowHandle);
        }

        public void mergeMenu (frmCashier_Main parent)
        {
            parent.Ribbon.MergeRibbon(this.ribbonControl1);
        }
        private void init ()
        {
            List<HangHoa> hanghoa = hangHoa_Dal_Bll.LoadHangHoaHoatDong();
            

            ////set up value
            if (im == "")
            {
                lbl_MaHoaDon.Text = "HD" + control.RandomCode();
            }
            else
            {
                lbl_MaHoaDon.Text = im;
                HoaDon hd = hoaDon_Dal_Bll.loadHoaDon(im.Trim());
                cantra = (double)hd.ThanhTien;
                tongTien = (double)hd.TongCong;
                if (hd.GiamGia == null)
                    giamgia = 0;
                else
                {
                    giamgia = (double)hd.Voucher.GiaGiam;
                }    
                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                lbl_TongTienHang.Text = (tongTien)
                    .ToString("#,###", cultureInfo.NumberFormat);
                lbl_CanTra.Text = cantra
                        .ToString("#,###", cultureInfo.NumberFormat);
                lbl_giamgia.Text = giamgia
                        .ToString("#,###", cultureInfo.NumberFormat);
                List<ChiTietHoaDon> cthd = cTHoaDon_Dal_Bll.loadCTHoaDon(lbl_MaHoaDon.Text);
                gcChiTiet.DataSource = new BindingList<ChiTietHoaDon>(cthd);
                soBillCu = cthd.Count();
            }
            lbl_Username.Text = COMMON.currentUser.HoTen;
            lbl_NgayLap.Text = DateTime.Today.ToString();
            repositoryItems.DataSource = hanghoa;
        }

        public ChiTietHoaDon createChiTietHoaDon(string mhd, int rowHandel)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaChiTiet = "CTHD" + control.RandomCode();
            cthd.MaHangHoa = gvChiTiet.GetRowCellDisplayText(rowHandel, colMaHangHoa).ToString();
            cthd.TenHangHoa = gvChiTiet.GetRowCellDisplayText(rowHandel, colTenHangHoa).ToString();
            cthd.MaHoaDon = mhd;
            cthd.ThanhTien = decimal.Parse(gvChiTiet.GetRowCellDisplayText(rowHandel, colThanhTien).ToString());
            cthd.SoLuong = int.Parse(gvChiTiet.GetRowCellDisplayText(rowHandel, colSoLuong).ToString());
            cthd.GiaBan = decimal.Parse(gvChiTiet.GetRowCellDisplayText(rowHandel, colGiaBan).ToString());
            cthd.GiamGia = int.Parse(gvChiTiet.GetRowCellDisplayText(rowHandel, colGiamGia).ToString());
            return cthd;
        }

        public async Task themDanhSachHoaDonAsync(string lbl_mahoadon)
        {
            if(gvChiTiet.DataRowCount == 0)
            {
                new UC_Message().showAlert("Chưa nhập mặt hàng cho hóa đơn mới",
                    UC_Message.enmType.Warning);
            }    
            else
            {
                for (int i = 0; i < gvChiTiet.DataRowCount; i++)
                {
                    ChiTietHoaDon ct = createChiTietHoaDon(lbl_mahoadon, i);
                    if (ct == null)
                    {
                        new UC_Message().showAlert("Chi tiết hóa đơn " + ct.TenHangHoa +
                            " - tạo không thành công", UC_Message.enmType.Error);
                        continue;
                    }
                    else
                    {
                        if (cTHoaDon_Dal_Bll.insertCthd(ct) == null)
                        {
                            //int sl = hangHoa_Dal_Bll.capNhatSoLuongHangHoa(ct.MaHangHoa, (int)ct.SoLuong,true);
                            HangHoa hh = hangHoa_Dal_Bll.loadHangHoaTheoMa(ct.MaHangHoa.Trim());
                            FirebaseResponse rep = await FireBaseConnect.Client.UpdateTaskAsync("Product/" + ct.MaHangHoa.Trim() + "/" + "prd_soton", hh.TonKho.ToString());
                        }
                        else
                        {
                            new UC_Message().showAlert("Lỗi thêm " + ct.HangHoa.TenHangHoa, UC_Message.enmType.Error);
                            return;
                        }
                        new UC_Message().showAlert("Đã lưu hóa đơn", UC_Message.enmType.Success);
                    }
                }
            }   
        }
        private HoaDon createNewHoaDon()
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHoaDon = lbl_MaHoaDon.Text;
            hoaDon.NgayLap = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            hoaDon.NhanVien = COMMON.currentUser.TenDangNhap;
            hoaDon.TrangThai = false;
            hoaDon.PhuongThucThanhToan = lbl_payment.Text;
            hoaDon.GiamGia = makm;
            return hoaDon;
        }

        private void insertHoaDon ()
        {
            new UC_Message().showAlert(hoaDon_Dal_Bll.insertHoaDon(createNewHoaDon()), UC_Message.enmType.Success);
        }

        private void Scan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(COMMON.voucherCode != "")
            {
                if(isVoucher == true)
                {
                    txt_ps.Text = COMMON.voucherCode;
                    initVoucher(txt_ps.Text.Trim());
                    COMMON.voucherCode = null;
                }  
                else
                {
                    KhachHang kh =
                        khachHang_Dal_Bll.loadKhachHang(COMMON.voucherCode.Trim());
                    if (kh == null)
                         new UC_Message().showAlert("Thông tin Khách Hàng không hợp lệ"
                            , UC_Message.enmType.Error);
                    else
                    {
                        lbl_TenKhachHang.Text = kh.HoTen.Trim();
                        mkh = kh.MaKhachHang;
                    }
                }    
            }
        }

        private bool initVoucher (string maVC)
        {
            if(kiemTraVoucher(maVC) == false)
            {
                new UC_Message().showAlert("MÃ KHUYỄN MÃI KHÔNG HỢP LỆ"
                            , UC_Message.enmType.Error);
                return false;
            }
            else
            {
                makm = maVC;
                Voucher voucher = voucher_Dal_Bll.getVoucher(maVC.Trim());
                
                if (voucher != null && voucher.GiaGiam > 500)
                {
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    giamgia = Convert.ToDouble(voucher.GiaGiam);
                    lbl_giamgia.Text = "-" + giamgia.
                        ToString("#,###", cultureInfo.NumberFormat);
                    cantra = tongTien - giamgia;
                    lbl_CanTra.Text = cantra.ToString("#,###", cultureInfo.NumberFormat);
                    return true;
                }
                return false;
            }    
        }

        private bool kiemTraVoucher(string maVC)
        {
            if (maVC == null || maVC.Length < 8)
                return false;
            else if (voucher_Dal_Bll.getVoucher(maVC) == null)
                return false;
            return true;
        }

        private void create_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program._create != null)
                Program._create = null;
        }

        private async void fm_menuItem_ClickAsync(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvChiTiet.DataRowCount == 0)
            {
                new UC_Message().showAlert("Đơn hàng trống", UC_Message.enmType.Warning);
            }
            else
            {
                BarButtonItem btn = e.Item as BarButtonItem;
                switch (btn.Name)
                {
                    case "btn_in":
                        if(im != null && im != "")
                        {
                            int sbm = gvChiTiet.DataRowCount;
                            if (soBillCu < sbm)
                            {
                                for(int i = soBillCu; i< sbm; i++)
                                {
                                    ChiTietHoaDon ct = createChiTietHoaDon(im.Trim(), i);
                                    if (ct == null)
                                    {
                                        new UC_Message().showAlert("Chi tiết hóa đơn " + ct.TenHangHoa +
                                            " - tạo không thành công", UC_Message.enmType.Error);
                                        continue;
                                    }
                                    else
                                    {
                                        if (cTHoaDon_Dal_Bll.insertCthd(ct) == null)
                                        {
                                            HangHoa hh = hangHoa_Dal_Bll.loadHangHoaTheoMa(ct.MaHangHoa.Trim());
                                            FirebaseResponse rep = await FireBaseConnect.Client.UpdateTaskAsync("Product/" + ct.MaHangHoa.Trim() + "/" + "prd_soton", hh.TonKho.ToString());
                                        }
                                        else
                                        {
                                            new UC_Message().showAlert("Lỗi thêm " + ct.HangHoa.TenHangHoa, UC_Message.enmType.Error);
                                            return;
                                        }
                                        new UC_Message().showAlert("Đã lưu hóa đơn", UC_Message.enmType.Success);
                                    }
                                }
                            }
                            hoaDon_Dal_Bll.updateHoaDon(im);
                            //rp_receipt rp_Receipt = new rp_receipt();
                            //rp_Receipt.DataSource = gcChiTiet.DataSource;
                            //ReportPrintTool tool = new ReportPrintTool(rp_Receipt);
                            //tool.ShowPreview();
                            try
                            {
                                HoaDon hd = data.getHD(lbl_MaHoaDon.Text);

                                KhachHang kh = data.getKH(hd.MaKhachHang);

                                List<ChiTietHoaDon> cthd = data.getCTHD(hd.MaHoaDon);

                                string TenKhachHang = kh.HoTen;

                                string DiaChi = kh.DiaChi;

                                string SDT = kh.DienThoai;

                                string Email = kh.Email;

                                int sum = 0;

                                int i = 1;

                                string STT = "0";

                                string TenSanPham = "";

                                string MaSanPham = "";

                                string SoLuong = "";

                                string DonGia = "";

                                string ThanhTien = "";

                                foreach (ChiTietHoaDon item in cthd)
                                {
                                    if (STT == "0")
                                    {
                                        STT = i.ToString();

                                        TenSanPham = item.TenHangHoa;

                                        MaSanPham = item.MaHangHoa;

                                        SoLuong = item.SoLuong.ToString();

                                        int value = Convert.ToInt32(item.GiaBan);

                                        Decimal _Dongia = Convert.ToDecimal(value);

                                        DonGia = String.Format("{0:0,0 VND}", _Dongia).Replace(",", ".");

                                        int value2 = Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan);

                                        Decimal _ThanhTien = Convert.ToDecimal(value2);

                                        ThanhTien = String.Format("{0:0,0 VND}", _ThanhTien).Replace(",", ".");

                                        sum = Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan);

                                        i++;
                                    }
                                    else
                                    {
                                        STT = STT + "\n" + i.ToString();

                                        TenSanPham = TenSanPham + "\n" + item.TenHangHoa;

                                        MaSanPham = MaSanPham + "\n" + item.MaHangHoa;

                                        SoLuong = SoLuong + "\n" + item.SoLuong.ToString();

                                        int value = Convert.ToInt32(item.GiaBan);

                                        Decimal _Dongia = Convert.ToDecimal(value);

                                        String inputDonGia = String.Format("{0:0,0 VND}", _Dongia).Replace(",", ".");

                                        DonGia = DonGia + "\n" + inputDonGia;

                                        int value2 = Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan);

                                        Decimal _ThanhTien = Convert.ToDecimal(value2);

                                        String inputThanhTien = String.Format("{0:0,0 VND}", _ThanhTien).Replace(",", ".");

                                        ThanhTien = ThanhTien + "\n" + inputThanhTien;

                                        sum = sum + (Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan));

                                        i++;
                                    }

                                }
                                Decimal _Tong = Convert.ToDecimal(sum);

                                String Tong = String.Format("{0:0,0 VND}", _Tong).Replace(",", ".");

                                word.BaoCaoHoaDon(TenKhachHang, DiaChi, Email, SDT, STT, TenSanPham, MaSanPham, SoLuong, DonGia, ThanhTien, Tong);

                            }
                            catch
                            {
                                MessageBox.Show("fail");
                                return;
                            }
                            Close();
                            Program._create = null;
                        }  
                        else
                        {
                            themDanhSachHoaDonAsync(lbl_MaHoaDon.Text);
                            //updateHoaDOn(lbl_MaHoaDon.Text, true);
                            //hoaDon_Dal_Bll.updateHoaDon(lbl_MaHoaDon.Text.Trim()).Contains("OK")
                            if (updateHoaDOn(lbl_MaHoaDon.Text.Trim(), true) == true)
                            {
                                //rp_receipt rp_Receipt = new rp_receipt();
                                //rp_Receipt.DataSource = gcChiTiet.DataSource;
                                //ReportPrintTool tool = new ReportPrintTool(rp_Receipt);
                                //tool.ShowPreview();
                                //CODE IN HÓA ĐƠN

                                try
                                {
                                    HoaDon hd = data.getHD(lbl_MaHoaDon.Text);

                                    KhachHang kh = data.getKH(hd.MaKhachHang);

                                    List<ChiTietHoaDon> cthd = data.getCTHD(hd.MaHoaDon);

                                    string TenKhachHang = kh.HoTen;

                                    string DiaChi = kh.DiaChi;

                                    string SDT = kh.DienThoai;

                                    string Email = kh.Email;

                                    int sum = 0;

                                    int i = 1;

                                    string STT = "0";

                                    string TenSanPham = "";

                                    string MaSanPham = "";

                                    string SoLuong = "";

                                    string DonGia = "";

                                    string ThanhTien = "";

                                    foreach (ChiTietHoaDon item in cthd)
                                    {
                                        if (STT == "0")
                                        {
                                            STT = i.ToString();

                                            TenSanPham = item.TenHangHoa;

                                            MaSanPham = item.MaHangHoa;

                                            SoLuong = item.SoLuong.ToString();

                                            int value = Convert.ToInt32(item.GiaBan);

                                            Decimal _Dongia = Convert.ToDecimal(value);

                                            DonGia = String.Format("{0:0,0 VND}", _Dongia).Replace(",", ".");

                                            int value2 = Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan);

                                            Decimal _ThanhTien = Convert.ToDecimal(value2);

                                            ThanhTien = String.Format("{0:0,0 VND}", _ThanhTien).Replace(",", ".");

                                            sum = Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan);

                                            i++;
                                        }
                                        else
                                        {
                                            STT = STT + "\n" + i.ToString();

                                            TenSanPham = TenSanPham + "\n" + item.TenHangHoa;

                                            MaSanPham = MaSanPham + "\n" + item.MaHangHoa;

                                            SoLuong = SoLuong + "\n" + item.SoLuong.ToString();

                                            int value = Convert.ToInt32(item.GiaBan);

                                            Decimal _Dongia = Convert.ToDecimal(value);

                                            String inputDonGia = String.Format("{0:0,0 VND}", _Dongia).Replace(",", ".");

                                            DonGia = DonGia + "\n" + inputDonGia;

                                            int value2 = Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan);

                                            Decimal _ThanhTien = Convert.ToDecimal(value2);

                                            String inputThanhTien = String.Format("{0:0,0 VND}", _ThanhTien).Replace(",", ".");

                                            ThanhTien = ThanhTien + "\n" + inputThanhTien;

                                            sum = sum + (Convert.ToInt32(item.SoLuong) * Convert.ToInt32(item.GiaBan));

                                            i++;
                                        }

                                    }
                                    Decimal _Tong = Convert.ToDecimal(sum);

                                    String Tong = String.Format("{0:0,0 VND}", _Tong).Replace(",", ".");

                                    word.BaoCaoHoaDon(TenKhachHang, DiaChi, Email, SDT, STT, TenSanPham, MaSanPham, SoLuong, DonGia, ThanhTien, Tong);

                                }
                                catch
                                {
                                    MessageBox.Show("fail");
                                    return;
                                }
                                
                            }
                            else
                            {
                                new UC_Message().showAlert("Lỗi", UC_Message.enmType.Error);
                            }
                            Close();
                            Program._create = null;
                            new UC_Message().showAlert("Đã In", UC_Message.enmType.Success);
                        }    
                        //cr.themDanhSachHoaDon();
                        break;
                    case "btn_save":
                        themDanhSachHoaDonAsync(lbl_MaHoaDon.Text);
                        updateHoaDOn(lbl_MaHoaDon.Text, false);
                        Close();
                        //cr.themDanhSachHoaDon();
                        break;
                    case "btn_scan":
                       this.isVoucher = true;
                        if (Program._Scan == null || Program._Scan.IsDisposed)
                        {
                            Program._Scan = new frmScan();
                            Program._Scan.FormClosed += Scan_FormClosed;
                            Program._Scan.Show();
                        }
                        break;
                    case "btn_huy":
                        this.Close();
                        break;
                    case "btn_tv":
                        this.isVoucher = false;
                        if (Program._Scan == null || Program._Scan.IsDisposed)
                        {
                            Program._Scan = new frmScan();
                            Program._Scan.FormClosed += Scan_FormClosed;
                            Program._Scan.Show();
                        }
                        break;
                    case "btn_momo":
                        paymentValidator("btn_momo");
                        break;
                    case "btn_cr":
                        paymentValidator("btn_cr");
                        break;
                    case "btn_paypal":
                        paymentValidator("btn_paypal");
                        break;
                }
            }
        }

        
        private void paymentValidator(string v)
        {
            switch (v)
            {
                case "btn_momo":
                    new UC_Message().showAlert("MoMo", UC_Message.enmType.Success);
                    break; 
                case "btn_paypal":
                    new UC_Message().showAlert("Paypal", UC_Message.enmType.Success);
                    break; 
                case "btn_cr":
                    UC_PaymentFlyout gd  = new UC_PaymentFlyout();
                    gd.MdiParent = this.ParentForm;
                    gd.Name = "Thẻ ngân hàng (" +this.lbl_MaHoaDon+ ")";
                    gd.Show();
                    gd.mergeMenu((frmCashier_Main)this.ParentForm);
                    gd.FormClosed += creditClosed;
                    //new UC_Message().showAlert("Credit", UC_Message.enmType.Success);
                    break;
                default:
                    break;
            }
        }

        private void gvChiTiet_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                int dataRow = gvChiTiet.DataRowCount;
                if (gvChiTiet.RowCount < 1)
                    return;
                   
                string mhh = gvChiTiet.GetRowCellValue(dataRow - 1, colMaHangHoa).ToString();
                if (mhh != "")
                {
                    if (gvChiTiet.RowCount == 1)
                    {
                        HangHoa hh = hangHoa_Dal_Bll.loadHangHoaTheoMa(mhh.Trim());
                        int sum = int.Parse(gvChiTiet.GetRowCellValue(0, colSoLuong).ToString());
                        if (hh != null && hh.MaKhuyenMai != null)
                        {
                            txt_ps.Text = hh.MaKhuyenMai.Trim();
                            if (initVoucher(txt_ps.Text.Trim()) == false)
                            {
                                Voucher vc = voucher_Dal_Bll.getVoucher(txt_ps.Text.Trim());
                                if (vc != null && vc.GiaGiam == 0)
                                {
                                    int soMua = (int)(sum % vc.GiaToiDa);
                                    if (sum >= vc.GiaToiDa && soMua >= 1)
                                    {
                                        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                                        giamgia = Convert.ToDouble(soMua * hh.DonGia);
                                        lbl_giamgia.Text = "-" + giamgia.
                                            ToString("#,###", cultureInfo.NumberFormat);
                                        cantra = tongTien - giamgia;
                                        lbl_CanTra.Text = cantra.ToString("#,###", cultureInfo.NumberFormat);
                                        lbl_km.Text = "";
                                    }
                                    else
                                    {
                                        int spt = (int)(vc.GiaToiDa - sum);
                                        int dt = (int)(vc.GiaToiThieu);
                                        MessageBox.Show("Sản phẩm có khuyến mãi");
                                        lbl_km.Text = "+ " + spt.ToString()
                                            + " để nhận ưu đãi tặng "
                                            + dt.ToString()
                                            + " sản phẩm";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dataRow - 1; i++)
                        {
                            if (mhh.Equals(gvChiTiet.GetRowCellValue(i, colMaHangHoa)))
                            {
                                int sl = int.Parse(gvChiTiet.GetRowCellValue(i, colSoLuong).ToString());
                                int slm = int.Parse(gvChiTiet.GetRowCellValue(dataRow - 1, colSoLuong).ToString());
                                double gd = double.Parse(gvChiTiet.GetRowCellValue(i, colGiaBan).ToString());
                                int sum = sl + slm;
                                gvChiTiet.SetRowCellValue(i, colSoLuong, sum);
                                gvChiTiet.SetRowCellValue(i, colThanhTien, (sum) * gd);
                                gvChiTiet.DeleteRow(dataRow - 1);
                                HangHoa hh = hangHoa_Dal_Bll.loadHangHoaTheoMa(mhh.Trim());

                                if (hh != null && hh.MaKhuyenMai != null)
                                {
                                    txt_ps.Text = hh.MaKhuyenMai.Trim();
                                    if (initVoucher(txt_ps.Text.Trim()) == false)
                                    {
                                        Voucher vc = voucher_Dal_Bll.getVoucher(txt_ps.Text.Trim());
                                        if (vc != null && vc.GiaGiam == 0)
                                        {
                                            int soMua = (int)(sum % vc.GiaToiDa);
                                            if (soMua >= 1)
                                            {
                                                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                                                giamgia = Convert.ToDouble(soMua * hh.DonGia);
                                                lbl_giamgia.Text = "-" + giamgia.
                                                    ToString("#,###", cultureInfo.NumberFormat);
                                                cantra = tongTien - giamgia;
                                                lbl_CanTra.Text = cantra.ToString("#,###", cultureInfo.NumberFormat);
                                                lbl_km.Text = "";

                                            }
                                            else
                                            {
                                                int spt = (int)(vc.GiaToiDa - sum);
                                                int dt = (int)(vc.GiaToiThieu);
                                                MessageBox.Show("Sản phẩm có khuyến mãi");
                                                lbl_km.Text = "+ " + spt.ToString()
                                                    + " để nhận ưu đãi tặng "
                                                    + dt.ToString()
                                                    + " sản phẩm";
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }    
                    
                    
                }
            }
            catch (Exception ex)
            {

            }    
        }

        private void gvChiTiet_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                GridView view = sender as GridView;
                view.FocusedRowHandle = e.HitInfo.RowHandle;
                foreach (DXMenuItem item in menuItems)
                    e.Menu.Items.Add(item);
            }
        }

        private void creditClosed(object sender, FormClosedEventArgs e)
        {
            if (COMMON.bank != null)
            {
                lbl_payment.Text = COMMON.bank;
                COMMON.bank = null;
            }    
        }

        public bool updateHoaDOn (string lbl_mahoadon, bool isPrint)
        {
            HoaDon hd = hoaDon_Dal_Bll.loadHoaDon(lbl_mahoadon);
            hd.TrangThai = isPrint;
            hd.TongCong = (decimal?)tongTien;
            if (txt_ps.Text.Trim() == "0")
                hd.GiamGia = null;
            else
                hd.GiamGia = txt_ps.Text.ToString();
            cantra = tongTien - giamgia;
            hd.ThanhTien = (decimal?)cantra;
            if (lbl_TenKhachHang.Text.Trim().Equals("Khách hàng mua lẻ"))
            {
                hd.MaKhachHang = "KHML";
            }
            else
                hd.MaKhachHang = mkh;
            hd.PhuongThucThanhToan = lbl_payment.Text;
            hd.NgayLap = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string up = hoaDon_Dal_Bll.updateHoaDon(hd);
            if (up != null)
            {
                new UC_Message().showAlert(up, UC_Message.enmType.Success);
                return true;
            }
            return false;
        }
        
        private void generalHoaDon()
        {
            if(gvChiTiet.RowCount < 0)
            {
                tongTien = 0; cantra = 0; giamgia = 0;
            }
            else
            {
                tongTien += control.tinhThanhTien(sl, dg, giam);
            }
            lbl_TongTienHang.Text = tongTien.ToString();
            lbl_giamgia.Text = giamgia.ToString();
            lbl_CanTra.Text = (tongTien - giamgia).ToString();
            this.Name = "Hóa Đơn (" + lbl_MaHoaDon +")";
        }
            
        private void gvChiTiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            HangHoa hh = null;
            if (e.Column.FieldName == "MaHangHoa")
            {
                string maHang = gvChiTiet.GetRowCellValue(e.RowHandle, e.Column).ToString();
                hh = hangHoa_Dal_Bll.loadHangHoaTheoMa(maHang);
                if(hh!= null)
                {
                    gvChiTiet.SetRowCellValue(e.RowHandle, "TenHangHoa", hh.TenHangHoa);
                    gvChiTiet.SetRowCellValue(e.RowHandle, "GiamGia", hh.Seri);
                    gvChiTiet.SetRowCellValue(e.RowHandle, "GiaBan", hh.DonGia);
                } 
            } 
            if(e.Column.FieldName == "SoLuong")
            {
                string maHang = gvChiTiet.GetRowCellValue(e.RowHandle, colMaHang).ToString();
                hh = hangHoa_Dal_Bll.loadHangHoaTheoMa(maHang);
                try
                {
                    dg = decimal.Parse(gvChiTiet.GetFocusedRowCellValue(colGiaBan).ToString());
                    sl = int.Parse(gvChiTiet.GetFocusedRowCellValue(colSoLuong).ToString());

                    if (sl == 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0");
                        gvChiTiet.DeleteRow(e.RowHandle);
                        return;
                    }
                    else if(hh.TonKho < sl)
                    {
                        new UC_Message().showAlert("Vượt quá số lượng tồn", UC_Message.enmType.Warning);
                        return;
                    }    
                    gvChiTiet.SetFocusedRowCellValue(colThanhTien, control.tinhThanhTien(sl, dg, 0));
                    generalHoaDon();
                }
                catch (Exception)
                {
                    new UC_Message().showAlert("Đã xảy ra lỗi!", UC_Message.enmType.Error);
                }
                
                //updateHoaDOn();
            }    
        }
    }
}