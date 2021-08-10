using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using DAL_BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using FireSharp.Config;
using DevExpress.XtraSplashScreen;
using FireSharp.Response;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GUI
{
    public partial class UC_Product_Dashbroad : UserControl
    {
        //Guna.UI.Lib.ScrollBar.ListViewScrollHelper listViewScrollHelper;
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        CTPhieuNhap_dal_bll cTPhieuNhap_Dal_Bll = new CTPhieuNhap_dal_bll();
        CTHoaDon_dal_bll cTHoaDon_Dal_Bll = new CTHoaDon_dal_bll();
        CTDatHang_dal_bll cTDatHang_Dal_Bll = new CTDatHang_dal_bll();
        PhieuNhap_dal_bll phieuNhap_Dal_Bll = new PhieuNhap_dal_bll();
        LoaiHangHoa_dal_bll loaiHangHoa_Dal_Bll = new LoaiHangHoa_dal_bll();
        NhaCungCap_dal_bll nhaCungCap_Dal_Bll = new NhaCungCap_dal_bll();
        GUI_Control control = new GUI_Control();
        HangHoa hh = null;
        List<HangHoa> hanghoa;
        public UC_Product_Dashbroad(DockStyle fill)
        {
            InitializeComponent();
            init();
            this.Dock = fill;
            checkProduct();
        }

        
        public void reLoad()
        {
            hanghoa = hangHoa_Dal_Bll.LoadHangHoa();
            hangHoaBindingSource.DataSource = hanghoa;
        }
        private void init()
        {
            //gcProduct.DataSource = hangHoa_Dal_Bll.LoadHangHoaHoatDong();
            hanghoa = hangHoa_Dal_Bll.LoadHangHoa();
            hangHoaBindingSource.DataSource = hanghoa;
            var loaihang = loaiHangHoa_Dal_Bll.loadLoaiHangHoa();
            loaiHangHoaBindingSource.DataSource = loaihang;

            LoadDataToLookupGrid(cboVitri);
        }


        private void checkProduct()
        {
            List<HangHoa> hangHoas = hangHoa_Dal_Bll.LoadHangHoaHoatDong();
            List<HangHoa> tonKhos = hangHoa_Dal_Bll.LoadHangTonKho();
            if (hangHoas == null)
            {
                new UC_Message().showAlert("Kho Hàng trống", UC_Message.enmType.Info);
            }
            if(tonKhos.Count != 0)
            {
                pauseForm(tonKhos);
            }    
        }


        private void LoadDataToLookupGrid(DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cbo)
        {
            List<String> vt = hangHoa_Dal_Bll.loadHangHoaVT();

            cbo.DataSource = vt;
            cbo.DisplayMember = "ViTri";
            cbo.ValueMember = "ViTri";

            //
            cbo.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            cbo.PopupFormSize = new Size(600, 400);
            cbo.View.Columns.Clear();
            //cbo.View.Columns.AddVisible("ViTri","Vị Trí");
            //
            cbo.View.OptionsView.ShowColumnHeaders = true;
            cbo.ShowAddNewButton = true;

        }
        private void btn(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaAdvenceButton btn = (Guna.UI.WinForms.GunaAdvenceButton)sender;
            switch (btn.Name)
            {
                case "btn_del":
                    if(gvProduct.FocusedRowHandle >=0)
                    {
                        xoaHangHoa();
                        //xoaHangHoaFireBase();
                    }    
                    break;
                case "btn_edit":
                    if (hh != null)
                        pauseForm(hh.MaHangHoa, (double)hh.DonGia);
                    break;
                case "btn_pause":
                    if(btn.Text.Equals("Phục Hồi"))
                    {
                        if (hangHoa_Dal_Bll.capNhatTinhTrangHangHoa(hh.TenHangHoa,true) == 0)
                        {
                            new UC_Message().showAlert("Phục Hồi " + hh.TenHangHoa, UC_Message.enmType.Info);
                            btn.Text = "Tạm Ngưng";
                            reLoad();
                            updateHangHoaAsync("Còn hàng");
                        }
                    }
                    else
                    {
                        if (hangHoa_Dal_Bll.capNhatTinhTrangHangHoa(hh.TenHangHoa, false) == 0)
                        {
                            new UC_Message().showAlert("Tạm Ngưng " + hh.TenHangHoa, UC_Message.enmType.Info);
                            btn.Text = "Phục Hồi";
                            reLoad();
                            updateHangHoaAsync("Tạm ngưng");
                        }
                    }
                    break;
            }
        }

        private async Task updateHangHoaAsync(string v)
        {
            bool connectInternet = NetworkInterface.GetIsNetworkAvailable();
            if (connectInternet == false)
            {
                new UC_Message().showAlert("Kiểm Tra Kết Nối Mạng", UC_Message.enmType.Warning);
                return;
            }
            else
            {
                SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                try
                {
                    string mhh = gvProduct.GetFocusedRowCellValue(colMaHangHoa).ToString().Trim();
                    FirebaseResponse rep = await FireBaseConnect.Client.UpdateTaskAsync("Product/" + mhh + "/" + "prd_tinhtrang", v);
                }
                catch (Exception e)
                {
                    new UC_Message().showAlert(e.Message, UC_Message.enmType.Error);
                }
                SplashScreenManager.CloseForm();
            }
        }

        private void xoaHangHoaFireBase()
        {
            bool connectInternet = NetworkInterface.GetIsNetworkAvailable();
            if(connectInternet == false)
            {
                new UC_Message().showAlert("Kiểm Tra Kết Nối Mạng", UC_Message.enmType.Warning);
                return;
            }
            else
            {
                SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                try
                {
                    string mhh = gvProduct.GetFocusedRowCellValue(colMaHangHoa).ToString().Trim();
                    var remove = FireBaseConnect.Client.Delete("Product/" + mhh);
                    SplashScreenManager.CloseForm();
                }
                catch (Exception e)
                {
                    //new UC_Message().showAlert(e.Message, UC_Message.enmType.Error);
                }
            }    
        }

        private void pauseForm(string mahh, double gia)
        {
            Form formBackground = new Form();
            try
            {
                using (frmThietLapGia tl = new frmThietLapGia(gia,mahh))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Parent.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    tl.FormClosed += Tl_FormClosed;

                    tl.Owner = formBackground;
                    tl.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
        
        private void pauseForm(List<HangHoa> lst)
        {
            Form formBackground = new Form();
            try
            {
                using (UC_Product_Count frm = new UC_Product_Count(lst))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();


                    frm.Owner = formBackground;
                    frm.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void Tl_FormClosed(object sender, FormClosedEventArgs e)
        {
            init();
        }

        private void xoaHangHoa()
        {
            string rs = hangHoa_Dal_Bll.xoaHangHoa(hh);
            if (rs.Contains("OK"))
            {
                new UC_Message().showAlert("Đã xóa ", UC_Message.enmType.Success);
                reLoad();
            }
            else
            {
                DialogResult dialog =  MessageBox.Show("Bạn muốn xóa tất cả?", "Xóa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if(dialog.Equals(DialogResult.Yes))
                {
                    xoaChiTietNhap(hh);
                    xoaChiTietDat(hh);
                    xoaChiTietHoaDon(hh);
                    xoaHangHoa();
                    return;
                }    
            }    
        }

        private void xoaChiTietHoaDon(HangHoa hh)
        {
            string rs = cTHoaDon_Dal_Bll.xoaChiTietHoaDon(hh.MaHangHoa);
            if (rs.Contains("OK"))
            {
                new UC_Message().showAlert("Đã xóa", UC_Message.enmType.Success);
            }
            else
            {
                new UC_Message().showAlert("Mặt hàng có trong hóa đơn", UC_Message.enmType.Error);
            }
        }

        private void xoaChiTietDat(HangHoa hh)
        {
            string rs = cTDatHang_Dal_Bll.xoaChiTietDat(hh.MaHangHoa);
            if (rs.Contains("OK"))
            {
                new UC_Message().showAlert("Đã xóa phiếu đặt", UC_Message.enmType.Success);
            }
                //new UC_Message().showAlert(rs, UC_Message.enmType.Error);
        }

        private void xoaChiTietNhap(HangHoa hh)
        {
            string rs = cTPhieuNhap_Dal_Bll.xoaChiTietNhap(hh.MaHangHoa);
            if (rs.Contains("OK"))
            {
                new UC_Message().showAlert("Đã xóa Nhập", UC_Message.enmType.Success);
            }
                //new UC_Message().showAlert(rs, UC_Message.enmType.Error);
        }

        private void gvProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                hh = gvProduct.GetFocusedRow() as HangHoa;
                if(hh.Active == false)
                {
                    btn_pause.Text = "Phục Hồi";
                    
                } 
                else
                {
                    btn_pause.Text = "Tạm Ngưng";
                }    
                string ma = gvProduct.GetFocusedRowCellValue("MaHangHoa").ToString().Trim();
                gvProduct.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
                UC_Product_EditPanel editPanel = new UC_Product_EditPanel(this.gvProduct);
                gvProduct.OptionsEditForm.CustomEditFormLayout = editPanel;
                generalGridViewItems(ma);
                loadChiTiet(hh);
            }
        }

        private void loadChiTiet(HangHoa hh)
        {
           ChiTietNhap ctn = cTPhieuNhap_Dal_Bll.loadChiTietNhapTheoHang(hh.MaHangHoa.Trim());
            PhieuNhap nh = phieuNhap_Dal_Bll.loadNgayNhap(hh.MaHangHoa.Trim());
            if(ctn == null || nh == null)
            {
                //new UC_Message().showAlert("Lỗi chi tiết " + hh.TenHangHoa, UC_Message.enmType.Error );
                return;
            }
            else
            {
                lbl_ncc.Text = nh.NhaCungCap1.TenNhaCungCap;
                lbl_gngn.Text = ctn.DonGiaNhap.ToString();
                lbl_nnc.Text = nh.NgayLap.ToString();
            }    
        }

        private void generalGridViewItems(string ma)
        {
            if (ma.Length > 7)
            {
                control.createBarcode(ma.Substring(0, 7), barcode_img);
            }
        }
        private void deTu_EditValueChanged(object sender, EventArgs e)
        {
            if(deTu.EditValue != null && deDen.EditValue != null)
            {
                List<ChiTietHoaDon> lst = cTHoaDon_Dal_Bll.loadCTHoaDonTheoHang(hh.MaHangHoa);
                int? c = 0;
                foreach (ChiTietHoaDon ct in lst)
                {
                    DateTime nl = DateTime.Parse(ct.HoaDon.NgayLap.Trim());
                    if (nl >= (DateTime)deTu.EditValue && nl <= (DateTime)deDen.EditValue)
                        c+= ct.SoLuong;
                }
                lbl_db.Text = c.ToString();
            }
            else
            {
                lbl_db.Text = "0";
            }    
        }

        private async Task dongBoHoaAsync()
        {
            
            SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
            //
            try
            {
                FirebaseResponse firebaseResponse = await FireBaseConnect.Client.GetTaskAsync("Product/");
                if(firebaseResponse == null)
                {
                    bool connectInternet = NetworkInterface.GetIsNetworkAvailable();
                    if (connectInternet == true)
                    {
                        new UC_Message().showAlert("Không thể truy cập được", UC_Message.enmType.Error);
                    }
                    else
                    {
                        new UC_Message().showAlert("Kiểm tra kết nối Internet", UC_Message.enmType.Warning);
                    }
                }
                else
                {
                    string Jsontxt = firebaseResponse.Body;
                    dynamic data = JsonConvert.DeserializeObject<dynamic>(Jsontxt);
                    foreach(dynamic itemDynamic in data)
                    {
                        if(itemDynamic != null)
                        {
                            HangHoa hangHoa = JsonConvert.DeserializeObject<HangHoa>
                                    (((JToken)itemDynamic).ToString());
                            if(hanghoa != null 
                                && hanghoa.Where(h => h.TenHangHoa.Contains(hangHoa.prd_ten)).SingleOrDefault() == null)
                            {
                                HangHoa i = new HangHoa();
                                //char [] s1 = ((JToken)itemDynamic).Path.ToArray();
                                i.MaHangHoa = "HH" + control.RandomCode();
                                i.MaNhom = "LH004";
                                i.TenHangHoa = hangHoa.prd_ten;
                                i.TonKho = int.Parse(hangHoa.prd_soton);
                                i.DonGia = decimal.Parse(hangHoa.prd_dongia);
                                i.GiaVon = decimal.Parse(hangHoa.prd_gia);
                                i.prd_congdung = hangHoa.prd_congdung;
                                i.Mota = 0;
                                i.Active = true;
                                i.Anh = control.ImageToByteArray(hangHoa.prd_hinh);
                                i.prd_dungtic = hangHoa.prd_dungtic;
                                i.prd_nhanhang = hangHoa.prd_nhanhang;
                                i.prd_xuatxu = hangHoa.prd_xuatxu;
                                i.Seri = "0";
                                string rs = hangHoa_Dal_Bll.insertNewHangHoa(i);
                                if(rs.Contains("OK"))
                                {
                                    //control.pushThongBao("Siêu Thị YVONNE - Thông Báo Hàng Hóa", "Nhiều mặt hàng mới đã được cập nhật")
                                    new UC_Message().showAlert("Đã đồng bộ", UC_Message.enmType.Success);
                                    reLoad();
                                }
                                else
                                {
                                    new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                                }
                            }
                        }    
                    }

                }
            }
            catch (Exception e)
            {
                new UC_Message().showAlert(e.Message, UC_Message.enmType.Error);
            }
            SplashScreenManager.CloseForm();
        }

        private async Task taiLenAsync()
        {

            bool connectInternet = NetworkInterface.GetIsNetworkAvailable();
            if (connectInternet == false)
            {
                new UC_Message().showAlert("Không thể truy cập được", UC_Message.enmType.Error);
                return;
            }
            SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");

            try
            {
                FirebaseResponse firebaseResponse = await FireBaseConnect.Client.GetTaskAsync("Product/");
                if (firebaseResponse == null)
                {

                }
                else
                {
                    List<String> hangCu = new List<String>();
                    string Jsontxt = firebaseResponse.Body;
                    dynamic data = JsonConvert.DeserializeObject<dynamic>(Jsontxt);
                    foreach (dynamic itemDynamic in data)
                    {
                        if (itemDynamic != null)
                        {
                            HangHoa hangHoa = JsonConvert.DeserializeObject<HangHoa>
                                    (((JToken)itemDynamic).ToString());
                            hangCu.Add(hangHoa.prd_ten);
                        }

                    }

                    List<String> hangMoi = hanghoa.Select(i => i.TenHangHoa).Except(hangCu).ToList();
                    Random r = new Random();
                    hangMoi.ForEach(item =>
                    {
                        HangHoa p = hangHoa_Dal_Bll.loadHangHoaTheoTen(item);
                        HangHoa hangHoa = new HangHoa
                        {
                            prd_congdung = p.prd_congdung,
                            prd_dungtic = p.prd_dungtic,
                            prd_dongia = p.DonGia.ToString(),
                            prd_gia = p.GiaVon.ToString(),
                            prd_hinh = control.getImage(r.Next(0, 10)),
                            prd_loai = p.LoaiHangHoa.TenLoaiHang,
                            prd_nhanhang = p.prd_nhanhang,
                            prd_soton = p.TonKho.ToString(),
                            prd_ten = p.TenHangHoa,
                            prd_tinhtrang = "Còn Hàng",
                            prd_xuatxu = p.prd_xuatxu
                        };

                        var setter = FireBaseConnect.Client.Set("Product/" + p.MaHangHoa.Trim(), hangHoa);
                    });
                }
                    
                control.pushThongBao("Siêu Thị YVONNE - Thông Báo Hàng Hóa", "Nhiều mặt hàng mới đã được cập nhật. Hãy bắt đầu mua sắm nào!!!");
                new UC_Message().showAlert("Tải  hoàn tất", UC_Message.enmType.Success);

            }
            catch (Exception ex)
            {
                new UC_Message().showAlert(ex.Message, UC_Message.enmType.Error);
            }
            SplashScreenManager.CloseForm();
        }

        private void dongBo_Click(object sender, EventArgs e)
        {
            dongBoHoaAsync();
        }

        private void taiLen_Click(object sender, EventArgs e)
        {
            taiLenAsync();
        }
    }
}
