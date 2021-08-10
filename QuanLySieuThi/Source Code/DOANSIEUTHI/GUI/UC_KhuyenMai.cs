using DAL_BLL;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_KhuyenMai : DevExpress.XtraEditors.XtraUserControl
    {
        Voucher_dal_bll voucher_Dal_Bll = new Voucher_dal_bll();
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        List<Voucher> vouchers;
        GUI_Control control = new GUI_Control();
        string nhdhd = "ALL", nhdmh = "ALL";
        public UC_KhuyenMai()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            vouchers = voucher_Dal_Bll.getVoucher();
            voucherBindingSource.DataSource = new BindingList<Voucher>
                (vouchers.Where(vc => vc.MaSanPham == false).ToList());
            
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            TabNavigationPage page = e.Page as TabNavigationPage;
            switch (page.Name)
            {
                case "tabMH":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    loadMatHang();
                    SplashScreenManager.CloseForm();
                    break;
                case "tabHD":
                    SplashScreenManager.ShowForm(ParentForm, typeof(frmWaiting), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                    init();
                    SplashScreenManager.CloseForm();
                    break;
                default:
                    break;
            }

        }

        private void loadMatHang()
        {
            voucherBindingSource.DataSource = new BindingList<Voucher>
                 (vouchers.Where(vc => vc.MaSanPham == true).ToList());
            hangHoaBindingSource.DataSource = new BindingList<HangHoa>
                (hangHoa_Dal_Bll.LoadHangHoaHoatDong());
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string rs = "";
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_add":
                    if(tabPane1.SelectedPage == tabHD)
                    {
                        initAddHoaDon();
                    } 
                    else
                    {
                        initAddHangHoa();
                    }    
                    break;
                case "btn_sua":
                    if(tabPane1.SelectedPage == tabMH)
                    {
                        Voucher vc = gvKM.GetFocusedRow() as Voucher;
                        if(vc != null && lue_HangHoa.EditValue != null)
                        {
                            rs = hangHoa_Dal_Bll.themKhuyenMai(lue_HangHoa.EditValue.ToString().Trim(), vc.MaVoucher);
                        }

                    }
                    break;
                case "btn_xoa":

                    break;
                case "btn_save":
                    if (tabPane1.SelectedPage == tabHD)
                    {
                        rs = addVoucher(false);
                    }
                    else
                    {
                        if (addVoucher(true).Contains("OK"))
                        {
                            rs = hangHoa_Dal_Bll.themKhuyenMai(lue_HangHoa.EditValue.ToString(), txt_MHMKM.Text);
                        }
                    }
                    break;
                case "btnCan":
                    btn_save.Enabled = false;
                    btn_add.Enabled = true;
                    btn_sua.Enabled = true;
                    btn_xoa.Enabled = true;
                    btnCan.Enabled = false;
                    break;
                default:
                    break;
            }

            if(rs.Contains("OK") && btn.Name != "btn_add" && btn.Name != "btnCan")
            {
                new UC_Message().showAlert("Thành Công", UC_Message.enmType.Success);
                init();
                loadMatHang();
            }    
            else
            {
                new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }
        }

        private void initAddHangHoa()
        {
            txt_MHMKM.Text = "PV" + control.RandomCode();
            control.createBarcode(txt_MHMKM.Text.Trim(), pc_codeMH);
            btnCan.Enabled = true;
            btn_save.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            //
        }

        private string addVoucher(bool v)
        {
            if(v == false)
            {
                Voucher vc = new Voucher();
                vc.MaVoucher = txt_mkm.Text.Trim();
                vc.NgayBatDau = DateTime.Parse(deNBD.EditValue.ToString());
                vc.NgayKetThuc = DateTime.Parse(deNKT.EditValue.ToString());
                vc.NgayApDung = nhdhd;
                vc.KhungGio = caMotTu.EditValue + "/" + caMotDen.EditValue;
                vc.MaSanPham = v;
                if(cboCK.Text.Trim() != "")
                    vc.ChietKhau = int.Parse(cboCK.Text.Trim().Replace("%", ""));
                vc.ChietKhau = 0;
                vc.GiaGiam = txtGiaTriGiam.Value;
                vc.GiaToiDa = txtToiDa.Value;
                vc.GiaToiThieu = txt_toiThieu.Value;
                return voucher_Dal_Bll.addVoucher(vc);
            }    
            else
            {
                int mua = 0, tang = 0;
                if(txt_mua.Value != 0 && txt_Tang.Value != 0)
                {
                    mua = int.Parse(txt_mua.Value.ToString());
                    tang = int.Parse(txt_Tang.Value.ToString());
                }
                Voucher vc = new Voucher
                {
                    MaVoucher = txt_MHMKM.Text.Trim(),
                    NgayBatDau = (DateTime?)de_MatHangBD.EditValue,
                    NgayKetThuc = (DateTime?)de_MatHangKT.EditValue,
                    NgayApDung = nhdmh,
                    KhungGio = tse_MHTu.EditValue + "/" + tse_MHDen.EditValue,
                    MaSanPham = v,
                    ChietKhau = 0,
                    GiaGiam = txt_MHGIam.Value,
                    GiaToiDa = mua,
                    GiaToiThieu = tang,
                };
                return voucher_Dal_Bll.addVoucher(vc);
            }    
        }

        private void initAddHoaDon()
        {
            txt_mkm.Text = "BV" + control.RandomCode();
            control.createBarcode(txt_mkm.Text.Trim(), pc_code);
            btnCan.Enabled = true;
            btn_save.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            //
        }

        private void txt_toiThieu_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown txt = sender as NumericUpDown;
            switch (txt.Name)
            {
                case "txt_toiThieu":
                    txtSoTienChuToiThieu.Text = control.NumberToText((double)txt_toiThieu.Value);
                    break;
                case "txtToiDa":
                    txtSoTienBangChuToiDa.Text = control.NumberToText((double)txtToiDa.Value);
                    break;
                case "txtGiaTriGiam":
                    txtSoTienChuGiam.Text = control.NumberToText((double)txtGiaTriGiam.Value);
                    break;
                case "txt_dongia":
                    txt_ChuDonGia.Text = control.NumberToText((double)txt_dongia.Value);
                    break;
                case "txt_MHGIam":
                    txt_mhchugiam.Text = control.NumberToText((double)txt_MHGIam.Value);
                    break;
                default:
                    break;
            }
        }

        private void cl_NgayHoatdong_SelectedValueChanged(object sender, EventArgs e)
        {
            //foreach (CheckedListBoxItem item in cl_NgayHoatdong.Items)
            //{

            //}    
            cl_NgayHoatdong.Items.ToList().ForEach(item =>
           {
               if(item.CheckState == CheckState.Checked)
               {
                   if (item.Value.ToString() == "ALL")
                       nhdhd = "ALL";
                   else
                       nhdhd += item.Value + ",";
               }   
           });
        }

        private void gvKM_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Voucher vc = gvKM.GetRow(e.FocusedRowHandle) as Voucher;
            if(vc != null)
            {
                if(vc.MaSanPham == false)
                {
                    control.createBarcode(vc.MaVoucher.Trim(), pc_code);
                }
                else
                {
                    control.createBarcode(vc.MaVoucher.Trim(), pc_codeMH);
                }    
            }    
        }

        private void lue_HangHoa_EditValueChanged(object sender, EventArgs e)
        {
            HangHoa hangHoa = hangHoa_Dal_Bll.loadHangHoaTheoMa(lue_HangHoa.EditValue.ToString().Trim()) ;
            if(hangHoa != null)
            {
                txt_dongia.Value = (decimal)hangHoa.DonGia;
            }    
        }

        private void cl_MatHangNgayApDung_SelectedValueChanged(object sender, EventArgs e)
        {
            cl_MatHangNgayApDung.Items.ToList().ForEach(item =>
            {
                if (item.CheckState == CheckState.Checked)
                {
                    if (item.Value.ToString() == "ALL")
                        nhdmh = "ALL";
                    else
                        nhdmh += item.Value + ",";
                }
            });
        }
    }
}
