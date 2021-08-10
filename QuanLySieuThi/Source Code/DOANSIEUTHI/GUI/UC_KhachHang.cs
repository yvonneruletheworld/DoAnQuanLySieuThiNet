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
using System.Net.NetworkInformation;

//using FireSharp.Config;
//using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net.Mail;
using DevExpress.XtraTab;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using GUI.MODEL;

namespace GUI
{
    public partial class UC_KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHang_dal_bll khachHang_Dal_Bll = new KhachHang_dal_bll();
        NhomKhachHang_dal_bll nhomKhachHang_Dal_Bll = new NhomKhachHang_dal_bll();
        HoaDon_dal_bll hoaDon_Dal_Bll = new HoaDon_dal_bll();
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        CTHoaDon_dal_bll cTHoaDon_Dal_Bll = new CTHoaDon_dal_bll();
        Customer_dal_bll customer_Dal_Bll = new Customer_dal_bll();
        GUI_Control control = new GUI_Control();
        int listCount;
        double tylemtb = 0;
        List<HoaDon> lst;
        List<ChiTietHoaDon> cthd;
        List<HangHoa> hangHoas;
        DataTable dtData = new DataTable();
        DataTable dtKmean = new DataTable();
        private bool isImport = false;

        
        public UC_KhachHang()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            loadKhachHang();
            timer1.Start();
        }


        private void loadKhachHang()
        {
            List<KhachHang> lst = khachHang_Dal_Bll.loadKhachHang();
            khachHangBindingSource.DataSource = new BindingList<KhachHang>
                (lst);
            listCount = lst.Count;
            nhomKhachHangBindingSource.DataSource = new BindingList<NhomKhachHang>
                (nhomKhachHang_Dal_Bll.loadNhomKhachHang().ToList());
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "themToolStripMenuItem":
                    khachHangBindingSource.AddNew();
                    MaKhachHangTextEdit.Enabled = true;
                    break;
                case "luutoolStripMenuItem":
                    themKhachHang();
                    break;
                case "huyToolStripMenuItem":
                    khachHangBindingSource.ResetBindings(false);
                    break;
                case "xoaToolStripMenuItem":
                    xoaKhachHang();
                    break;
                default:
                    break;
            }
        }

        private void xoaKhachHang()
        {
            KhachHang kh = gvKhachHang.GetFocusedRow() as KhachHang;
            if(kh != null)
            {
                string rs = khachHang_Dal_Bll.XoaKhachHang(kh);
                if (rs.Contains("OK"))
                {
                    loadKhachHang();
                }
                else
                {
                    new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                }
            }
            else
            {
                new UC_Message().showAlert("Chua xac dinh", UC_Message.enmType.Warning);
            }
        }

        private void themKhachHang()
        {
            if (khachHangBindingSource.Count > listCount)
            {
                for (int i = listCount; i < gvKhachHang.DataRowCount; i++)
                {
                    KhachHang kh = gvKhachHang.GetRow(i) as KhachHang;
                    if (kh != null)
                    {
                        kh.MatKhau = "MK" + control.RandomCode();
                        string rs = khachHang_Dal_Bll.ThemKhachHang(kh);
                        if (rs.Contains("OK"))
                        {
                            customer_Dal_Bll.ThemKhachHang(new Customer
                            {
                                CusID = "c" + control.RandomCode(),
                                Address = kh.DiaChi,
                                Birthday = kh.NgaySinh,
                                CusName = kh.HoTen,
                                Phone = kh.DienThoai,
                                Frequency = 0,
                                NumberBill = 0,
                                TotalValue = 0
                            });
                        }
                        else
                        {
                            new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                        }
                    }
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();
            if (connection == true)
            {
                timer1.Stop();
                FireBaseConnect.connectFireBase();
            }
            else
            {
                new UC_Message().showAlert("Kiểm tra kết nối Internet", UC_Message.enmType.Warning);
                timer1.Stop();
            }
        }

        private void gvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            KhachHang kh = gvKhachHang.GetFocusedRow() as KhachHang;
            if (kh != null)
            {
                control.createBarcode(kh.MaKhachHang, pictureBox1);
            }
        }

        private void EmailTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                MailAddress m = new MailAddress(EmailTextEdit.Text.Trim());
                EmailTextEdit.ForeColor = Color.Black;

            }
            catch
            {
                EmailTextEdit.ForeColor = Color.Red;
            }
        }

        private void DienThoaiTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (DienThoaiTextEdit.Text.Length < 12 && DienThoaiTextEdit.Text.Length > 9)
            {
                e.Handled = true;
            }
        }

        private void ItemForMaKhachHang_DoubleClick(object sender, EventArgs e)
        {
            MaKhachHangTextEdit.Text = "KH" + control.RandomCode();
        }

        private void xtraTabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            xoaHDtoolStripMenuItem.Enabled = false;

            XtraTabPage tab = e.Page as XtraTabPage;
            switch (tab.Name)
            {
                case "tb_DatTruoc":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadDatTruocAsync();
                    break;
                case "tb_HoaDon":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadHoaDon();
                    xoaHDtoolStripMenuItem.Enabled = true;
                    break;
                case "tb_PhanLoai":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadKhachHangPL();
                    loadKetQua();

                    LoadThongSoKmean();
                    ShowHideLoad(false,true);
                    break;
                default:
                    break;
            }

        }
        private void ShowHideLoad(bool isShowChk, bool hide)
        {
            foreach (Control ctrl in tabPageResult.Controls)
                if (ctrl is CheckBox)
                {
                    ctrl.Enabled = isShowChk;
                }
            btnPhanLoai.Enabled = !isShowChk;
            if(hide == true)
                SplashScreenManager.CloseForm();
        }
        private void loadKhachHangPL()
        {
            try {
                dtData = customer_Dal_Bll.loadCus();
                //do du lieu cho datatable
                if(dtData != null)
                {
                    //---Hien thi du lieu len DataGridview--
                    grvKhachHang.AutoGenerateColumns = false;
                    grvKhachHang.DataSource = dtData;
                    //-------Gan du lieu cho table kmean(so don>0)
                    dtKmean = dtData.Clone();
                    foreach (DataRow row in dtData.Rows)
                        if (row["NumberBill"].ToString() != "0")
                        {
                            dtKmean.ImportRow(row);
                        }
                    // MessageBox.Show("So hang la:" + dtKmean.Rows.Count);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Loi:" + ex.ToString());
                Console.Write(ex.Message);
            }
            finally
            {

            }
        }
        private void LoadThongSoKmean()
        {
            try
            {
                //lay ra gia tri nho nhat cua cac truong du lieu
                float minTong = float.MaxValue, maxTong = float.MinValue;
                float minDH = float.MaxValue, maxDH = float.MinValue;
                float minTanSuat = float.MaxValue, maxTanSuat = float.MinValue;

                // duyet lan luot cac hang r tim ra cac gtri
                foreach (DataRow row in dtKmean.Rows)
                {
                    float tong = float.Parse(row[5].ToString());
                    float bill = float.Parse(row[6].ToString());
                    float freq = float.Parse(row[7].ToString());
                    if (minTong > tong)
                        minTong = tong;
                    if (maxTong < tong)
                        maxTong = tong;
                    if (minDH > bill)
                        minDH = bill;
                    if (maxDH < bill)
                        maxDH = bill;
                    if (minTanSuat > freq)
                        minTanSuat = freq;
                    if (maxTanSuat < freq)
                        maxTanSuat = freq;
                }
                //ket thuc vong lap lay dc gia tri
                //load thong so gioi han
                DataGridViewRow rowGD1 = new DataGridViewRow();
                rowGD1.CreateCells(grvTSGH);
                rowGD1.Cells[0].Value = "1";
                rowGD1.Cells[1].Value = "Min";
                rowGD1.Cells[2].Value = minTong;
                rowGD1.Cells[3].Value = minDH;
                rowGD1.Cells[4].Value = minTanSuat;
                grvTSGH.Rows.Add(rowGD1);
                DataGridViewRow rowGD2 = new DataGridViewRow();
                rowGD2.CreateCells(grvTSGH);
                rowGD2.Cells[0].Value = "2";
                rowGD2.Cells[1].Value = "Max";
                rowGD2.Cells[2].Value = maxTong;
                rowGD2.Cells[3].Value = maxDH;
                rowGD2.Cells[4].Value = minTanSuat;
                grvTSGH.Rows.Add(rowGD2);

                //--------load thong khoi tao tam----------
                //KH loi nhuan: Tong gia tri la lon nhat
                DataGridViewRow rowKT1 = new DataGridViewRow();
                rowKT1.CreateCells(grvKhoiTaoTam);
                //Khach hang thuong xuyen: Tan suat mua hang lon nhat
                DataGridViewRow rowKT2 = new DataGridViewRow();
                rowKT2.CreateCells(grvKhoiTaoTam);
                DataGridViewRow rowKT3 = new DataGridViewRow();
                //Khach hang mua hang: so bill nho nhat
                rowKT3.CreateCells(grvKhoiTaoTam);
                foreach (DataRow row in dtKmean.Rows)
                {
                    float total = float.Parse(row[5].ToString());
                    float freq = float.Parse(row[7].ToString());
                    float bill = float.Parse(row[6].ToString());
                    if (total == maxTong)
                    {
                        rowKT1.Cells[0].Value = "1";
                        rowKT1.Cells[1].Value = "Khách hàng lợi nhuận";
                        rowKT1.Cells[2].Value = maxTong;
                        rowKT1.Cells[3].Value = bill;
                        rowKT1.Cells[4].Value = freq;
                    }

                    if (bill == minDH)
                    {
                        rowKT3.Cells[0].Value = "3";
                        rowKT3.Cells[1].Value = "Khách hàng mua hàng";
                        rowKT3.Cells[2].Value = total;
                        rowKT3.Cells[3].Value = minDH;
                        rowKT3.Cells[4].Value = freq;
                    }

                    if (maxTanSuat == freq)
                    {
                        rowKT2.Cells[0].Value = "2";
                        rowKT2.Cells[1].Value = "Khách hàng thường xuyên";
                        rowKT2.Cells[2].Value = total;
                        rowKT2.Cells[3].Value = bill;
                        rowKT2.Cells[4].Value = maxTanSuat;
                    }
                }
                //them vao datagridview
                grvKhoiTaoTam.Rows.Add(rowKT1);
                grvKhoiTaoTam.Rows.Add(rowKT2);
                grvKhoiTaoTam.Rows.Add(rowKT3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message);
            }
        }

        private void loadKetQua()
        {
            try
            {
                DataTable dtKH = new DataTable();
                dtKH = customer_Dal_Bll.loadCus();
                grvKetQua.AutoGenerateColumns = false;
                grvKetQua.DataSource = dtKH;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.ToString());
            }
            finally
            {
            }
        }
        private void loadHoaDon()
        {
            hoaDonBindingSource.DataSource = hoaDon_Dal_Bll.loadHoaDon();
            try
            {
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {

            }
        }

        private async Task loadDatTruocAsync()
        {
            HoaDon hoaDon = new HoaDon();
            if (FireBaseConnect.Client == null)
                //loadFireBase();
                FireBaseConnect.connectFireBase();
            else
            {
                bool connection = NetworkInterface.GetIsNetworkAvailable();
                if (connection == true)
                {
                }
                else
                {
                    new UC_Message().showAlert("Kiểm tra kết nối Internet", UC_Message.enmType.Warning);
                    return;
                }
                //FirebaseResponse response = await client.GetTaskAsync(@"TenRoot/TenNode/");
                ////neu phia sau con node nữa thì nhớ /
                //Dictionary<string, string> record = 
                //    JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Body.ToString());
                //record.Values
                //    // lay value
                FirebaseResponse firebaseResponse = await FireBaseConnect.Client.GetTaskAsync("Orders/");
                if (firebaseResponse == null)
                {
                    new UC_Message().showAlert("Không thể truy cập được", UC_Message.enmType.Error);
                }
                else
                {
                    
                        try
                        {
                        string Jsontxt = firebaseResponse.Body;

                        dynamic data = JsonConvert.DeserializeObject<dynamic>(Jsontxt);
                        if (data != null)
                        {
                            lst = new List<HoaDon>();
                            foreach (var itemDynamic in data)
                            {
                                HoaDon item = JsonConvert.DeserializeObject<HoaDon>
                                    (((JProperty)itemDynamic).Value.ToString());
                                item.MaHoaDon = itemDynamic.Name;
                                lst.Add(item);
                            }
                            if (lst.Count > 0 && lst != null)
                            {
                                loadTongTien(lst);
                                hoaDonBindingSource.DataSource = new BindingList<HoaDon>
                                    (lst.Where(i => i.ord_state.Contains("Chờ tiếp nhận")).ToList());
                                SplashScreenManager.CloseForm();
                            }
                        }
                        }
                        catch (Exception)
                        {

                        }
                }

                //List<HoaDon> hd = firebaseResponse.ResultAs<HoaDon>();

                //if (hd != null)
                //    MessageBox.Show(hd.ord_address);
            }
        }

        private void loadChiTiet()
        {
            if (lst != null)
            {
                hangHoas = new List<HangHoa>();
                foreach (HoaDon hd in lst)
                {
                    String[] tenhang = hd.ord_product.Trim().Split('/');
                    String[] soluong = hd.ord_quality.Trim().Split(',');
                    for (int i = 0; i < tenhang.Length; i++)
                    {
                        if (tenhang[i] != "" && soluong[i] != "")
                        {
                            HangHoa hang = new HangHoa();
                            hang.TenHangHoa = tenhang[i].Trim();
                            hang.Mota = int.Parse(soluong[i].Trim());
                            hang.Seri = hd.MaHoaDon;
                            hangHoas.Add(hang);
                        }
                    }
                }
            }
        }

        private void loadTongTien(List<HoaDon> lst)
        {
            foreach (HoaDon hd in lst)
            {
                hd.ord_cost = Decimal.Parse(hd.ord_total) - Decimal.Parse(hd.ord_discount) - Decimal.Parse(hd.ord_delivery);
            }
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "chuyentoolStripMenuItem":
                    if (capNhatHoaDon() == true)
                    {
                    }
                    break;
                case "xoaHDtoolStripMenuItem":
                    HoaDon hd = gvHoaDon.GetFocusedRow() as HoaDon;
                    if(hd != null)
                    {
                        string rs = hoaDon_Dal_Bll.xoaHoaDon(hd.MaHoaDon);
                        if (rs != "OK")
                        {
                            new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                        }
                        else
                        {
                            loadHoaDon();
                        }
                    }

                    break;
                case "tatcatoolStripMenuItem":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadTongTien(lst);
                    hoaDonBindingSource.DataSource = new BindingList<HoaDon>
                        (lst);
                    SplashScreenManager.CloseForm();
                    break;
                case "chotiepnhantoolStripMenuItem":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadTongTien(lst);
                    hoaDonBindingSource.DataSource = new BindingList<HoaDon>
                        (lst.Where(i => i.ord_state.Contains("Chờ tiếp nhận")).ToList());
                    SplashScreenManager.CloseForm();
                    break;
                case "dagiaotoolStripMenuItem":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadTongTien(lst);
                    hoaDonBindingSource.DataSource = new BindingList<HoaDon>
                        (lst.Where(i => i.ord_state.Contains("Đang giao hàng")).ToList());
                    SplashScreenManager.CloseForm();
                    break;
                case "danhantoolStripMenuItem":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadTongTien(lst);
                    hoaDonBindingSource.DataSource = new BindingList<HoaDon>
                        (lst.Where(i => i.ord_state.Contains("Đã giao hàng")).ToList());
                    SplashScreenManager.CloseForm();
                    break;
                default:
                    break;
            }
        }

        //private bool themFireBaseBanner(string url)
        //{
        //    Banner bn = new Banner()
        //    {
        //        bn_id = "BN" + control.RandomCode(),
        //        bn_img = url
        //    };
        //    try
        //    {
        //        var setter = FireBaseConnect.Client.Set("Banner/" + bn.bn_id, bn);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        private bool capNhatHoaDon()
        {
            List<int> seletedRows = gvDatTruoc.GetSelectedRows().Where(row => row >= 0).ToList();
            if (seletedRows.Count > 0)
            {
                seletedRows.ForEach(r =>
                {
                    HoaDon item = gvDatTruoc.GetRow(r) as HoaDon;
                    if (item != null)
                    {
                        HoaDon hd = new HoaDon();
                        hd.MaHoaDon = "HD" + control.RandomCode();
                        hd.MaKhachHang = khachHang_Dal_Bll.loadKhachHangDienThoai(item.ord_phone.Trim());
                        hd.NgayLap = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                        hd.TongCong = Decimal.Parse(item.ord_total.ToString().Trim());
                        hd.ThanhTien = Decimal.Parse(item.ord_cost.ToString().Trim());
                        hd.TrangThai = true;
                        hd.PhuongThucThanhToan = item.ord_payment;
                        hd.NhanVien = COMMON.currentUser.TenDangNhap;

                        if(hoaDon_Dal_Bll.insertHoaDon(hd).Contains("Tạo thành công hóa đơn "))
                        {
                            foreach(HangHoa hh in hangHoas.Where(a => a.Seri.Equals(item.MaHoaDon)))
                            {
                                HangHoa i = hangHoa_Dal_Bll.loadHangHoaTheoTen(hh.TenHangHoa);
                                ChiTietHoaDon ct = new ChiTietHoaDon
                                {
                                    MaChiTiet = "CTDH" + control.RandomCode(),
                                    MaHangHoa = i.MaHangHoa,
                                    GiaBan = i.DonGia,
                                    SoLuong = hh.Mota,
                                    TenHangHoa = hh.TenHangHoa,
                                    ThanhTien = i.DonGia * hh.Mota,
                                    GiamGia = 0,
                                    MaHoaDon = hd.MaHoaDon
                                };
                                if(cTHoaDon_Dal_Bll.insertCthd(ct) == null)
                                {
                                    item.ord_state = "Đang giao hàng";
                                    if (item.ord_address.ToString().Contains("HCM"))
                                        item.ord_reiceve = DateTime.Now.Date.ToString();
                                    else
                                        item.ord_reiceve = DateTime.Now.Date.AddDays(2).ToString() ;
                                    object update = FireBaseConnect.Client.Update("Orders/" + item.MaHoaDon.Trim(), item);
                                    control.pushThongBao("Siêu Thị YVONNE - Thông Báo Đơn Hàng", "Đơn Hàng " + item + " của đã được xác nhận. Vui lòng kiểm tra điện thoại để Bộ phận Giao Hàng của Siêu Thị có thể giao hàng trong thời gian nhanh nhất." +
                                        "Ngày nhận dự kiến: " + item.ord_reiceve + ". Cảm ơn quý khách!");
                                }
                                else
                                {
                                    new UC_Message().showAlert("Đã xảy ra lỗi", UC_Message.enmType.Error);
                                }    
                            }
                        }
                    }
                });
                new UC_Message().showAlert("Đã chuyển", UC_Message.enmType.Success);
                return true;
            }
            else
            {
                new UC_Message().showAlert("Vui lòng chọn hóa đơn", UC_Message.enmType.Warning);
                return false;
            }
        }

    

        private void gvDatTruoc_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if(hangHoas == null)
            {
                loadChiTiet();
            }
            else
            {
                GridView gv = sender as GridView;
                HoaDon hd = gvDatTruoc.GetRow(e.RowHandle) as HoaDon;
                if (hd != null)
                {
                    e.IsEmpty = !hangHoas.Any(i => i.Seri.Equals(hd.MaHoaDon));
                }
            }
        }

        private void gvDatTruoc_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            if (hangHoas == null)
            {
                loadChiTiet();
            }
            else
            {
                GridView gv = sender as GridView;
                HoaDon hd = gvDatTruoc.GetRow(e.RowHandle) as HoaDon;
                if (hd != null)
                {
                    e.ChildList = hangHoas.Where(i => i.Seri.Equals(hd.MaHoaDon)).ToList();
                }
            }
        }

        private void gvDatTruoc_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvDatTruoc_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "DetailDatHang";
        }

        private void gvHoaDon_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            if(cthd == null)
            {
                loadChiTietHoaDon();
                gvHoaDon_MasterRowEmpty(sender, e);
            }
            else
            {
                GridView gv = sender as GridView;
                HoaDon hoaDon = gv.GetRow(e.RowHandle) as HoaDon;
                if (hoaDon != null)
                    e.IsEmpty = !cthd.Any(ct => ct.MaHoaDon.Equals(hoaDon.MaHoaDon));
            }    
        }

        private void loadChiTietHoaDon()
        {
            cthd = cTHoaDon_Dal_Bll.loadCTHoaDon();
        }

        private void gvHoaDon_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            if (cthd == null)
            {
                loadChiTietHoaDon();
                gvHoaDon_MasterRowGetChildList(sender, e);
            }
            else
            {
                GridView gv = sender as GridView;
                HoaDon hoaDon = gv.GetRow(e.RowHandle) as HoaDon;
                if (hoaDon != null)
                    e.ChildList = cthd.Where(ct => ct.MaHoaDon.Equals(hoaDon.MaHoaDon)).ToList();
            }
        }

        private void gvHoaDon_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }

        private void gvHoaDon_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void chkMuaHang_CheckedChanged(object sender, EventArgs e)
        {
            chkMuaHang.Enabled = false;
            bool isVisible = chkMuaHang.Checked;
            ShowHideRow(txtMuaHang.BackColor, isVisible);
            chkMuaHang.Enabled = true;
        }

        private void chkThuongXuyen_CheckedChanged(object sender, EventArgs e)
        {
            chkThuongXuyen.Enabled = false;
            bool isVisible = chkThuongXuyen.Checked;
            ShowHideRow(txtThuongXuyen.BackColor, isVisible);
            chkThuongXuyen.Enabled = true;
        }

        private void chkLoiNhuan_CheckedChanged(object sender, EventArgs e)
        {
            chkLoiNhuan.Enabled = false;
            bool isVisible = chkLoiNhuan.Checked;
            ShowHideRow(txtLoiNhuan.BackColor, isVisible);
            chkLoiNhuan.Enabled = true;
        }

        private void chkTiemNang_CheckedChanged(object sender, EventArgs e)
        {
            chkTiemNang.Enabled = false;
            bool isVisible = chkTiemNang.Checked;
            ShowHideRow(txtTiemNang.BackColor, isVisible);
            chkTiemNang.Enabled = true;
        }

        private void grvKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvKhachHang["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void grvKetQua_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvKetQua[0, e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void btnPhanLoai_Click(object sender, EventArgs e)
        {
            // tao tap hop cac diem
            PointCollection points = new PointCollection();
            //----Lay cac diem tu table k-Mean---
            int id = 0;
            foreach (DataRow row in dtKmean.Rows)
            {
                try
                {
                    float tong = float.Parse(row[5].ToString());
                    float bill = float.Parse(row[6].ToString());
                    float freq = float.Parse(row[7].ToString());
                    points.Add(new Point(id, tong, bill));
                    id++;
                }
                catch (Exception ex)
                {
                    
                    continue;
                }
                
            }
            //Cho nay bat dau lam K-mean nekkkk
            // k la so cum phan chia
            int k = 3;
            List<PointCollection> allClusters = KMeans.DoKMeans(points, k);
            //ham tra ve danh sach cac
            //MessageBox.Show(allClusters.Count + " cum"); 

            int index = 0;
            //dung de dinh mau nen va chu
            string strMsg = "";
            Color[] mauNen = new Color[3] { Color.Red, Color.Blue, Color.Yellow };
            Color[] mauChu = new Color[3] { Color.Yellow, Color.White, Color.Magenta };
            //Dat mau white mac dinh cho cac hang trong griview
            for (int i = 0; i < grvKetQua.RowCount; i++)
            {
                grvKetQua.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            foreach (PointCollection cluster in allClusters)
            {
                strMsg += cluster.Count + " points in cluster" + index + "\n";
                foreach (Point p in cluster)
                {
                    strMsg += " " + p.ToString() + "\n";
                    FillColor(p, mauNen[index], mauChu[index]);
                }
                index += 1;
            }
            //MessageBox.Show(strMsg);
            //------Dat dong duoc chon la dong cuoi cung---
            int sIndex = grvKetQua.Rows.Count - 1;
            grvKetQua.Rows[sIndex].Selected = true;
            grvKetQua.CurrentCell = null;
            //hien thi cac checbox cho nguoi ta loc
            ShowHideLoad(true,false);
        }


        //---To mau cho moi cum voi du lieu dau vao------
        private void FillColor(Point p, Color bgColor, Color foreColor)
        {
            foreach (DataGridViewRow row in grvKetQua.Rows)
            {
                try
                {
                    double total = Convert.ToDouble(row.Cells["Total"].Value.ToString());
                    double bill = Convert.ToDouble(row.Cells["Bill"].Value.ToString());
                    double freq = Convert.ToDouble(row.Cells["Freq"].Value);
                    p.X = Convert.ToDouble(p.X.ToString("0.00"));
                    p.Y = Convert.ToDouble(p.Y.ToString("0.00"));
                    if (p.X == total && p.Y == bill)
                    {
                        DataGridViewCellStyle style = row.DefaultCellStyle;
                        style.BackColor = bgColor;
                        style.ForeColor = foreColor;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
               
        }
        private void ShowHideRow(Color bgColor, bool isVisible)
        {
            //bo dong duoc chon truoc khi an no di
            grvKetQua.CurrentCell = null;
            //------Duyet tung dong de bo di cac dong theo mau truyen vao--
            for (int i = grvKetQua.RowCount - 1; i >= 0; i--)
            {
                DataGridViewCellStyle style = grvKetQua.Rows[i].DefaultCellStyle;
                if (style.BackColor == bgColor)
                    try
                    {
                        grvKetQua.Rows[i].Visible = isVisible;
                    }
                    catch (Exception ex)
                    {
                        //continue;
                        MessageBox.Show("Loi:" + ex.Message);
                    }
            }
        }

        private void tinhSoDonHang()
        {
            Random r = new Random();
            for (int i = 0; i < grvKhachHang.RowCount; i++)
            {
                if (isImport == true)
                {
                    int shd = r.Next(1, 150);
                    grvKhachHang["SoDonHang", i].Value = shd;
                    grvKetQua["Bill", i].Value = shd;
                    tylemtb += shd;
                }
            }
        }

        private void tinhTanSuat()
        {
            // khoi tao lai
            dtData = new DataTable();
            foreach(DataGridViewColumn col in grvKhachHang.Columns)
            {
                dtData.Columns.Add(col.Name);
            }
            Random r = new Random();
            for (int i = 0; i < grvKhachHang.RowCount; i++)
            {
                try
                {
                    double st = Convert.ToDouble(grvKhachHang["TongGiaTri", i].Value.ToString());
                    int s = Convert.ToInt32(grvKhachHang["SoDonHang", i].Value.ToString());
                    // tinh tan suan mua tb
                    double tsmtb = s / st;
                    double tyle = tylemtb / (grvKhachHang.RowCount - 1);

                    double frg = (tsmtb * tyle);
                    grvKhachHang["TanSuat", i].Value = frg;
                    grvKetQua["Freq", i].Value = frg;
                    DataRow dRow = dtData.NewRow();
                    foreach (DataGridViewCell cell in grvKhachHang.Rows[i].Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtData.Rows.Add(dRow);
                }
                catch (Exception)
                {
                    continue;
                }
               
            }
            //tonggiatri
            SplashScreenManager.CloseForm();
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isImport = true;
            SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
            grvKhachHang.DataSource = null;
            string _pathFilePhieuDat = control.openExcelFile(openFileDialog1);
            control.importOrderByExcel2(_pathFilePhieuDat, grvKhachHang);
            grvKetQua.DataSource = null;
            control.importOrderByExcel2(_pathFilePhieuDat, grvKetQua);
            tinhSoDonHang();
            tinhTanSuat();

            try
            {
                dtKmean = dtData.Clone();
                foreach (DataRow row in dtData.Rows)
                    if (row["SoDonHang"].ToString() != "0")
                    {
                        dtKmean.ImportRow(row);
                    }
                grvTSGH.Rows.Clear();
                grvKhoiTaoTam.Rows.Clear();
                LoadThongSoKmean();
                ShowHideLoad(false,true);
                btnPhanLoai.Enabled = true;
            }
            catch (Exception)
            {

            }
        }
    }

}
