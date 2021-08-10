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
using Guna.UI.WinForms;
using DAL_BLL;
using GUI.MODEL;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;

namespace GUI
{
    public partial class UC_PhieuChi : DevExpress.XtraEditors.XtraUserControl
    {
        NhaCungCap_dal_bll nhaCungCap_Dal_Bll = new NhaCungCap_dal_bll();
        ThietLap_dal_bll thietLap_Dal_Bll = new ThietLap_dal_bll();
        PhieuChi_dal_bll phieuChi_Dal_Bll = new PhieuChi_dal_bll();
        NguoiDung_dal_bll nguoiDung_Dal_Bll = new NguoiDung_dal_bll();
        CongNo_dal_bll congNo_Dal_Bll = new CongNo_dal_bll();
        GUI_Control control = new GUI_Control();
        bool isAdd = false;
        DXMenuItem[] menu = null;
        InWordExport data = new InWordExport();
        WordExport word = new WordExport();
        public UC_PhieuChi()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            init();
            initMenu();
        }

        private void initMenu()
        {
            DXMenuItem menuHuy = new DXMenuItem("Hủy", menuHuy_Click);
            menu = new DXMenuItem[] { menuHuy };
        }

        private void menuHuy_Click(object sender, EventArgs e)
        {
            PhieuChi pc = gvDaChuyen.GetFocusedRow() as PhieuChi;
            phieuChi_Dal_Bll.enablePhieuChi(pc.MaPhieuChi);
            congNo_Dal_Bll.xoaCongNo(pc.MaPhieuChi);
            loadPhieuChi();
        }


        private void init()
        {
            //load doi tac
            ThietLap tl = thietLap_Dal_Bll.loadThietLap();
            String[] loaiChi = tl.LoaiChi.Trim().Split(',');
            String[] htChi = tl.HinhThucChi.Trim().Split(',');
            
            ccb_hinhthucchi.Properties.Items.AddRange(htChi);
            ccb_loaiChi.Properties.Items.AddRange(loaiChi);

            loadPhieuChi();
            nhaCungCapBindingSource.DataSource = new BindingList<NhaCungCap>
                (nhaCungCap_Dal_Bll.loadNhaCungCapNo());
            nguoiDungBindingSource.DataSource = new BindingList<NguoiDung>
                (nguoiDung_Dal_Bll.loadNguoiDung().ToList());
        }

        private void loadPhieuChi()
        {
            phieuChiBindingSource.DataSource = new BindingList<PhieuChi>
                (phieuChi_Dal_Bll.loadPhieuChi(false));
            phieuChiBindingSource1.DataSource = new BindingList<PhieuChi>
                (phieuChi_Dal_Bll.loadPhieuChi(true));
        }

        private void enable()
        {
            ccb_loaiChi.Enabled = true;
            ccb_hinhthucchi.Enabled = true;
            ccb_dtc.Enabled = true;
            txt_nguoinhan.Enabled = true;
            txt_themdt.Enabled = true;
            txtDiaChi.Enabled = true;
            txtLyDoChi.Enabled = true;
            txtSoTien.Enabled = true;
            txtNgYeuCau.Enabled = true;
            txtSoTienChu.Enabled = true;
            de_nchi.Enabled = true;
            btn_save.Enabled = true;
            btnCan.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void disable()
        {
            ccb_loaiChi.Enabled = false;
            ccb_hinhthucchi.Enabled = false;
            ccb_dtc.Enabled = false;
            txt_nguoinhan.Enabled = false;
            txt_themdt.Enabled = false;
            txtDiaChi.Enabled = false;
            txtLyDoChi.Enabled = false;
            txtSoTien.Enabled = false;
            txtNgYeuCau.Enabled = false;
            txtSoTienChu.Enabled = false;
            de_nchi.Enabled = false;
            btn_save.Enabled = false;
            btnCan.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            string rs = "";
            switch (btn.Name)
            {
                case "btn_add":
                    isAdd = true;
                    enable();
                    gcPhieuYeuCau.Enabled = false;
                    gcDaChuyen.Enabled = false;
                    textClean();
                    break;
                case "btn_save":
                    disable();
                    gcPhieuYeuCau.Enabled = true;
                    gcDaChuyen.Enabled = true;
                    if (isAdd == true)
                    {
                        rs = taoPhieuChi();
                        if(rs.Contains("OK"))
                        {
                            
                        }
                    }
                    else
                    {
                        rs = suaPhieuChi();
                        if (rs.Contains("OK"))
                        {
                            
                        }
                    }
                    textClean();
                    break;
                case "btn_sua":
                    enable();
                    gcPhieuYeuCau.Enabled = false;
                    gcDaChuyen.Enabled = false;
                    isAdd = false;
                    txt_NguoiChi.Text = COMMON.currentUser.HoTen;
                    break;
                case "btnCan":
                    disable();
                    gcPhieuYeuCau.Enabled = true;
                    gcDaChuyen.Enabled = true;
                    textClean();
                    break;
                case "btn_xoa":
                    rs = phieuChi_Dal_Bll.xoaPhieuChi(txt_tt.Text.Trim());
                    break;
                default:
                    break;
            }
            if (rs.Contains("OK"))
            {
                new UC_Message().showAlert("Cập nhật thành công", UC_Message.enmType.Success);
                loadPhieuChi();
            }
            else
            {
                new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }
        }

        private string suaPhieuChi()
        {
            PhieuChi pc = gvPhieuYeuCau.GetFocusedRow() as PhieuChi;
            PhieuChi item = new PhieuChi();
            item.NgayChi = de_nchi.EditValue.ToString();
            item.TinhTrang = true;
            item.NguoiChi = COMMON.currentUser.TenDangNhap.Trim();
            item.LoaiChi = ccb_loaiChi.Text;
            item.HinhThuc = ccb_hinhthucchi.Text;
            item.DiaChi = txtDiaChi.Text;
            item.Lý_Do_Chi = txtLyDoChi.Text;
            item.GiaTri = txtSoTien.Value;
            item.NguoiYeuCau = pc.NguoiYeuCau;
            item.MaPhieuChi = pc.MaPhieuChi;
            //string mcn = taoCongNo();
            
              return  phieuChi_Dal_Bll.updatePhieuChi(item);
        }

        private void textClean()
        {
            txt_tt.Text = "PC" + control.RandomCode();
            ccb_loaiChi.Text = "Chọn";
            ccb_hinhthucchi.Text = "Chọn";
            txt_nguoinhan.Text = ccb_dtc.Text;
            ccb_dtc.Text = "Chọn";
            txtLyDoChi.Clear();
            txtNgYeuCau.Properties.NullText = "Chọn";
            ccb_dtc.EditValue = null;
            ccb_dtc.Properties.NullText = "Chọn";
            txt_NguoiChi.Text = COMMON.currentUser.HoTen;
            txtSoTien.Value = 0;
        }

        private string taoPhieuChi()
        {
            foreach (Control control in groupControl2.Controls)
            {
                if (control.GetType() == typeof(GunaTextBox) || control.GetType() == typeof(ComboBoxEdit))
                {
                    new UC_Message().showAlert("Dữ liệu thiếu", UC_Message.enmType.Warning);
                    return null;
                }
            }

            PhieuChi pc = new PhieuChi();
            pc.MaPhieuChi = txt_tt.Text.Trim();
            pc.NgayChi = de_nchi.EditValue.ToString();
            pc.GiaTri = txtSoTien.Value;
            pc.TinhTrang = true;
            pc.NguoiChi = COMMON.currentUser.TenDangNhap;
            pc.NguoiYeuCau = txtNgYeuCau.EditValue.ToString();
            pc.LoaiChi = ccb_loaiChi.Text;
            pc.HinhThuc = ccb_hinhthucchi.Text;
            pc.Lý_Do_Chi = txtLyDoChi.Text;


            string rs = phieuChi_Dal_Bll.insertNewPhieuChi(pc, "");

            if (rs.Contains("OK") && taoCongNo() != null)
            {
                return "OK";
            }
            else
            {
                return "Không tạo được công nợ";
            }    
        }

        private string taoCongNo()
        {
            CongNo rs = congNo_Dal_Bll.loadCongNoGanNhat(ccb_dtc.EditValue.ToString().Trim());
            if (rs != null)
            {
                double conLai = (double)rs.ConLai;
                CongNo cn = new CongNo();
                cn.MaCongNo = "CN" + control.RandomCode();
                cn.MaNhaCungCap = ccb_dtc.EditValue.ToString().Trim();
                cn.NgayTra = de_nchi.EditValue.ToString();
                cn.PhieuNhap = rs.PhieuNhap;
                cn.TraTien = txtSoTien.Value;
                cn.ConLai = rs.ConLai - txtSoTien.Value;
                cn.PhieuChi = txt_tt.Text.Trim();
                if (congNo_Dal_Bll.themCongNo(cn).Contains("OK"))
                    return cn.MaCongNo;
                else
                {
                    new UC_Message().showAlert("Lỗi tạo công nợ", UC_Message.enmType.Error);
                    return null;
                }
            }
            return null;
        }

        private void txtSoTien_ValueChanged(object sender, EventArgs e)
        {
            if(txtSoTien.Value <= 0)
            {
                txtSoTien.Value = 0;
            }
            else
            {
                txtSoTienChu.Text = control.NumberToText(Double.Parse(txtSoTien.Value.ToString()));
            }
        }

        private void gvPhieuYeuCau_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle >=0)
            {
                PhieuChi pc = gvPhieuYeuCau.GetFocusedRow() as PhieuChi;
                txt_tt.Text = pc.MaPhieuChi.Trim();
                ccb_loaiChi.Text = pc.LoaiChi;
                ccb_hinhthucchi.Text = pc.HinhThuc;
                NhaCungCap ncc = phieuChi_Dal_Bll.loadNguoiNhan(pc);
                if(ncc != null)
                {
                    txt_nguoinhan.Text = ncc.TenNhaCungCap;
                    ccb_dtc.Text = ncc.TenNhaCungCap;
                }
                txtDiaChi.Text = pc.DiaChi;
                txtLyDoChi.Text = pc.Lý_Do_Chi;
                txtNgYeuCau.Properties.NullText = pc.NguoiDung1.HoTen;
                if(pc.NguoiDung != null && pc.NgayChi != null)
                {
                    txt_NguoiChi.Text = pc.NguoiDung.HoTen;
                    de_nchi.EditValue = pc.NgayChi;
                }
                txtSoTien.Value = (decimal)pc.GiaTri;
                //btn_save.Enabled = true;
                //de_nchi.Enabled = true;
            }

        }

        private void ccb_dtc_EditValueChanged(object sender, EventArgs e)
        {
            if(ccb_dtc.Properties.NullText != "Chọn" || ccb_dtc.EditValue != null)
            {
                if (isAdd == true)
                {
                    NhaCungCap ncc = nhaCungCap_Dal_Bll.loadNhaCungCap(ccb_dtc.Text.ToString().Trim());
                    CongNo cn = congNo_Dal_Bll.loadCongNoGanNhat(ccb_dtc.EditValue.ToString().Trim());
                    txt_nguoinhan.Text = ncc.TenNhaCungCap;
                    txtDiaChi.Text = ncc.DiaChi;
                    txtSoTien.Value = (decimal)cn.ConLai;
                    txt_themdt.Enabled = false;
                }
                else
                {
                    NhaCungCap ncc = nhaCungCap_Dal_Bll.loadNhaCungCap(ccb_dtc.Text.ToString().Trim());
                    txt_nguoinhan.Text = ncc.TenNhaCungCap;
                    txtDiaChi.Text = ncc.DiaChi;
                    txt_themdt.Enabled = false;
                }
            }
              
        }

        private void ccb_loaiChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLyDoChi.Text = ccb_loaiChi.SelectedText;
        }

        private void gvDaChuyen_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                GridView gv = sender as GridView;
                gv.FocusedRowHandle = e.HitInfo.RowHandle;
                foreach (DXMenuItem item in menu)
                {
                    e.Menu.Items.Add(item);
                }
            }
        }
    }
}
