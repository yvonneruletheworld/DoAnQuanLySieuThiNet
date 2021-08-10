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
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Menu;
using Guna.UI.WinForms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using GUI.MODEL;

namespace GUI
{
    public partial class UC_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        NguoiDung_dal_bll nguoiDung_Dal_Bll = new NguoiDung_dal_bll();
        PhanQuyen_NguoiDung_VaiTro_dal_bll phanQuyen_NguoiDung_VaiTro_Dal_Bll
            = new PhanQuyen_NguoiDung_VaiTro_dal_bll();
        PhongBan_dal_bll phongBan_Dal_Bll = new PhongBan_dal_bll();
        VaiTro_dal_bll vaiTro_Dal_Bll = new VaiTro_dal_bll();
        ThongTinCuaHang_dal_bll thongTinCuaHang_Dal_Bll = new ThongTinCuaHang_dal_bll();
        GUI_Control control = new GUI_Control();
        bool isAdd,valid = true;
        public UC_NhanVien(DockStyle fill)
        {
            InitializeComponent();
            loadNhanVien();
            loadPhongBan();
            loadChiNhanh();
            loadVaiTro();
            this.Dock = fill;
        }

        private void loadChiNhanh()
        {
            List<ThongTinSieuThi> lst = thongTinCuaHang_Dal_Bll.loadThongtinSieuThi().ToList();
            foreach (ThongTinSieuThi tt in lst)
                ccb_chinhanh.Properties.Items.Add(
                    new CheckedListBoxItem(tt.DiaChiTruyCap, tt.TenCuaHang));
        }

        private void loadPhongBan()
        {
            clbPB.Items.Add(new CheckedListBoxItem("all", "Tất Cả", CheckState.Checked));
            List<PhongBan> lst = phongBan_Dal_Bll.loadPhongBan();
            foreach (PhongBan pb in lst)
                clbPB.Items.Add(new CheckedListBoxItem(pb.MaPhongBan, pb.TenPhongBan));
        }

        private void loadNhanVien()
        {
            List<NguoiDung> lst = nguoiDung_Dal_Bll.loadNguoiDung().ToList();
            nguoiDungBindingSource.DataSource = new BindingList<NguoiDung>(lst);
        }
        private void tvNhanVien_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            string mand = tvNhanVien.GetRowCellValue(e.RowHandle, colTenDangNhap).ToString().Trim();
            NguoiDung nd = nguoiDung_Dal_Bll.loadNguoiDung(mand);
            if(nd!= null)
            {
                if (nd.HinhAnh != null)
                    e.Item.Elements[3].Image = control.ByteToImage(nd.HinhAnh.ToArray());
                e.Item.Elements[5].Text = phanQuyen_NguoiDung_VaiTro_Dal_Bll
                        .loadTenVaiTro(nd.TenDangNhap);
                if (nd.TrangThai == "")
                {
                    e.Item.Elements[7].Text = "";
                    e.Item.Elements[7].Appearance.Normal.BackColor = Color.Transparent;
                }
            }    
        }

        private void clbPB_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if(e.Index > 0)
            {
                foreach (CheckedListBoxItem i in ccb_ChucVu.Properties.Items)
                {
                    if (i.Tag.Equals(clbPB.SelectedValue.ToString().Trim()))
                        i.Enabled = true;
                    else
                        i.Enabled = false;
                }
            }
            else
            {
                foreach (CheckedListBoxItem i in ccb_ChucVu.Properties.Items)
                {
                     i.Enabled = true;
                }
            }    
        }

        private void loadVaiTro()
        {
            List<VaiTro> lst = vaiTro_Dal_Bll.loadVaiTro();
            foreach(VaiTro vt in lst)
            {
                CheckedListBoxItem item = new CheckedListBoxItem(vt.MaVaiTro, vt.TenVaiTro, vt.MaPhongBan.Trim());
                ccb_ChucVu.Properties.Items.Add(item);
            }    
        }

        private void btn_apdung_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_add":
                    isAdd = true;
                    enabledText();
                    cleanText();
                    txt_tendn.Text = "NV" + control.RandomCode();
                    txt_mk.Text = control.RandomCode();
                    break;
                case "btn_save":
                        if (isAdd)
                        {
                            if (ccb_chinhanh.Text == "")
                            {
                                new UC_Message().showAlert("Chọn chi nhánh", UC_Message.enmType.Warning);
                                return;
                            }
                            themNhanVien();
                        }
                        else
                        {
                            suaNhanVien();
                        }
                        disabledText();
                    break;
                case "btnCan":
                    disabledText();
                    break;
                case "btn_xoa":
                    NguoiDung nd = tvNhanVien.GetFocusedRow() as NguoiDung;
                    string rs = nguoiDung_Dal_Bll.xoaNguoiDung(nd);
                    if (rs.Contains("OK"))
                    {
                        new UC_Message().showAlert("Đã xóa", UC_Message.enmType.Success);
                        loadNhanVien();
                    }
                    else
                        new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                    break;
                case "btn_sua":
                    enabledText();
                    isAdd = false;
                    break;
                default:
                    break;
            }
            //if (clbPB.SelectedItems.Count > 0 && ccb_ChucVu.Text != "")
            //{
            //}
            //else
            //    new UC_Message().showAlert("Vui lòng chọn", UC_Message.enmType.Warning);
        }

        private void suaNhanVien()
        {
            string tendn = tvNhanVien.GetFocusedRowCellValue(colTenDangNhap).ToString();
            NguoiDung nd = new NguoiDung();
            if(nd != null)
            {
                nd.TenDangNhap = tendn;
                nd.HoTen = txt_tennhanvien.Text.Trim();
                nd.MatKhau = txt_mk.Text.Trim();
                nd.ChiNhanh = ccb_chinhanh.Properties.GetCheckedItems().ToString().Trim();
                nd.TrangThai = txt_tt.Text;
                nd.Email = txt_email.Text.Trim();
                nd.NgaySinh = (DateTime?)de_ngsinh.EditValue;
                nd.GhiChu = de_nvl.EditValue.ToString();
                nd.DienThoai = txt_sdt.Text.Trim();
                nd.DiaChi = txt_diachi.Text.Trim();
                if (nv_img.Image != null)
                    nd.HinhAnh = control.ImageToByteArray(nv_img.Image);
                //if (swt_tt.Checked == true)
                //    nd.HoatDong = true;
                //else
                //    nd.HoatDong = false;
                nd.HoatDong = swt_tt.Checked;
                var rs = nguoiDung_Dal_Bll.updateNguoiDung(nd);
                if (rs != null)
                {
                    new UC_Message().showAlert("Đã sửa", UC_Message.enmType.Success);
                    loadNhanVien();
                }
                else
                    new UC_Message().showAlert("Chỉnh sửa thất bại", UC_Message.enmType.Error);
            }    
        }

        private void themNhanVien()
        {
            if(valid)
            {
                NguoiDung nd = new NguoiDung();
                nd.TenDangNhap = txt_tendn.Text.Trim();
                nd.HoTen = txt_tennhanvien.Text.Trim();
                nd.HoatDong = true;
                nd.ChiNhanh = ccb_chinhanh.Properties.GetCheckedItems().ToString().Trim();
                nd.TrangThai = "Tiếp Nhận";
                nd.Email = txt_email.Text.Trim();
                nd.MatKhau = txt_mk.Text.Trim();
                nd.NgaySinh = (DateTime?)de_ngsinh.EditValue;
                nd.GhiChu = de_nvl.EditValue.ToString();
                nd.DienThoai = txt_sdt.Text.Trim();
                nd.DiaChi = txt_diachi.Text.Trim();
                if (nv_img.Image != null)
                    nd.HinhAnh = control.ImageToByteArray(nv_img.Image);
                string rs = nguoiDung_Dal_Bll.themNguoiDung(nd);
                if (rs.Contains("OK"))
                {
                    new UC_Message().showAlert("Đã thêm", UC_Message.enmType.Success);
                    loadNhanVien();
                }
                else
                    new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }
        }

        private void cleanText()
        {
            txt_diachi.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            txt_tennhanvien.Clear();
            nv_img.Image = null;
            de_ngsinh.Text = "";
            de_nvl.Text = "";
        }

        private void enabledText()
        {
            txt_diachi.Enabled = true;
            txt_email.Enabled = true;
            txt_sdt.Enabled = true;
            txt_tennhanvien.Enabled = true;
            nv_img.Enabled = true;
            de_ngsinh.Enabled = true;
            de_nvl.Enabled = true;
            btn_save.Enabled = true;
            btnCan.Enabled = true;
            gcNhanVien.Enabled = false;
            btn_add.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_tt.Enabled = true;
            txt_mk.Enabled = true;
            groupControl3.Text = "Thêm mới";
        }
        private void disabledText()
        {
            txt_diachi.Enabled = false;
            txt_email.Enabled = false;
            txt_sdt.Enabled = false;
            txt_tennhanvien.Enabled = false;
            nv_img.Enabled = false;
            de_ngsinh.Enabled = false;
            de_nvl.Enabled = false;
            btn_save.Enabled = false;
            btnCan.Enabled = false;
            gcNhanVien.Enabled = true;
            btn_add.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            txt_tt.Enabled = false;
            txt_mk.Enabled = false;
        }

        private void ccb_ChucVu_EditValueChanged(object sender, EventArgs e)
        {
            if(isAdd == false)
            {
                var check = ccb_ChucVu.Properties.GetCheckedItems();
                if (check == null || ccb_ChucVu.Text.Trim() == "")
                {
                    loadNhanVien();
                }
                else
                {
                    nguoiDungBindingSource.DataSource = new BindingList<NguoiDung>
                    (nguoiDung_Dal_Bll.loadNguoiDungTheoVT(check.ToString().Replace(" ", "")));
                }
            }    
        }

        private void tvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NguoiDung nd = tvNhanVien.GetRow(e.FocusedRowHandle) as NguoiDung;

            if(nd != null)
            {
                try
                {
                    txt_mk.Text = nd.MatKhau;
                    txt_tendn.Text = nd.TenDangNhap;
                    control.createBarcode(txt_tendn.Text.Trim(), pc_code);
                    txt_tennhanvien.Text = nd.HoTen;
                    txt_sdt.Text = nd.DienThoai;
                    txt_email.Text = nd.Email;
                    txt_diachi.Text = nd.DiaChi;
                    de_ngsinh.EditValue = nd.NgaySinh;
                    de_nvl.EditValue = nd.GhiChu;
                    txt_tt.Text = nd.TrangThai;
                    if (nd.HinhAnh != null)
                    {
                        nv_img.Image = control.ByteToImage(nd.HinhAnh.ToArray());
                    }
                    else
                        nv_img.Image = null;
                    if (nd.HoatDong == true)
                    {
                        swt_tt.Checked = true;
                        lbl_hd.Text = "Hoạt Động";
                    }
                    else
                    {
                        swt_tt.Checked = false;
                        lbl_hd.Text = "Tạm Ngưng";
                    }


                    if (nd.TenDangNhap == COMMON.currentUser.TenDangNhap)
                    {
                        btn_add.Enabled = false;
                        btn_sua.Enabled = false;
                        btn_xoa.Enabled = false;
                    }
                    else
                    {
                        btn_add.Enabled = true;
                        btn_sua.Enabled = true;
                        btn_xoa.Enabled = true;
                    }
                    groupControl3.Text = phanQuyen_NguoiDung_VaiTro_Dal_Bll
                        .loadTenVaiTro(nd.TenDangNhap);
                }
                catch (Exception)
                {

                }
            }

        }

        private void txt_tennhanvien_TextChanged(object sender, EventArgs e)
        {
            GunaTextBox txt = sender as GunaTextBox;
            switch (txt.Name)
            {
                case "txt_tennhanvien":
                    Char [] characters = txt.Text.Trim().ToCharArray();
                    if (txt.Text.Length > 0 && char.IsDigit(characters[txt.Text.Trim().Length - 1]))
                    {
                        new UC_Message().showAlert("Tên không hợp lệ", UC_Message.enmType.Error);
                        txt_tennhanvien.BorderColor = Color.Red;
                        valid = false;
                    }
                    else {

                        if (!Regex.IsMatch(txt.Text.Trim(), @"^[\p{L}\p{M}' \.\-]+$"))
                        {
                            new UC_Message().showAlert("Tên không hợp lệ", UC_Message.enmType.Error);
                            txt_tennhanvien.BorderColor = Color.Red;
                            valid = false;
                        }
                        else
                        {
                            txt_tennhanvien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
                            valid = true;
                        }
                    }
                    break;
                case "txt_email":
                    if (isValidMail(txt_email.Text.Trim()))
                    {
                        txt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
                        valid = true;
                    }
                    else
                    {
                        txt_email.BorderColor = Color.Red;
                        valid = false;
                    }
                    break;
            }
        }

        private bool isValidMail(string v)
        {
            try
            {
                MailAddress m = new MailAddress(v);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void swt_tt_CheckedChanged(object sender, EventArgs e)
        {
            if (swt_tt.Checked == true)
                lbl_hd.Text = "Hoạt Động";
            else
                lbl_hd.Text = "Tạm Ngưng";
        }

        private void dateValidate(object sender, EventArgs e)
        {
            DateEdit item = sender as DateEdit;
            DateTime currentY = DateTime.Now;

            switch (item.Name)
            {
                case "de_ngsinh":
                    if(de_ngsinh.EditValue.ToString().Trim() != "")
                    {
                        DateTime dobY = DateTime.Parse(de_ngsinh.EditValue.ToString());
                        if (currentY.Year - dobY.Year < 18)
                        {
                            new UC_Message().showAlert("Nhân viên chưa đủ 18 tuổi", UC_Message.enmType.Error);
                            de_ngsinh.Text = "";
                            valid = false;
                        }
                        else
                            valid = true;
                    }    
                    break;
                case "de_nvl":
                    if (de_nvl.EditValue.ToString().Trim() != "")
                    {
                        DateTime nvlY = DateTime.Parse(de_nvl.EditValue.ToString());
                        if (currentY.CompareTo(nvlY) < 0)
                        {
                            new UC_Message().showAlert("Không hợp lệ", UC_Message.enmType.Error);
                            de_nvl.Text = "";
                            valid = false;
                        }
                        else
                            valid = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
