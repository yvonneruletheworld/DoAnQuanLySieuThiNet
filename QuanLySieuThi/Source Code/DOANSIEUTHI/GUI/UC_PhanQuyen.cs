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
using DevExpress.XtraBars.Navigation;
using DAL_BLL;
using DevExpress.XtraEditors.Controls;
using Guna.UI.WinForms;

namespace GUI
{
    public partial class UC_PhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        GUI_Control control = new GUI_Control();
        NhomChucNang_dal_bll nhomChucNang_Dal_Bll = new NhomChucNang_dal_bll();
        ChucNang_dal_bll chucNang_Dal_Bll = new ChucNang_dal_bll();
        PhanQuyen_VaiTro_ChucNang_dal_bll phanQuyen_VaiTro_ChucNang_Dal_Bll
            = new PhanQuyen_VaiTro_ChucNang_dal_bll();
        List<ChucNang> chucNangs;
        VaiTro Vt = new VaiTro();
        public UC_PhanQuyen(DockStyle dock)
        {
            InitializeComponent();
            init();
            this.Dock = dock;
        }

        private void init()
        {
            control.loadNavBarHoTro(this.accordionControl1);
            loadNhomChucNang();
            loadChucNang();
            loadBangPhanQuyen();
            //accorditionItemClick();
        }

        private void loadBangPhanQuyen()
        {
            this.phanQuyenVaiTroChucNangBindingSource.DataSource =
                new BindingList<PhanQuyen_VaiTro_ChucNang> 
                (phanQuyen_VaiTro_ChucNang_Dal_Bll.loadChucNangTheoVaiTro());
        }

        private void loadChucNang()
        {
            chucNangs = new List<ChucNang>();
            chucNangs = chucNang_Dal_Bll.loadChucNang();
            foreach(ChucNang cn in chucNangs)
            {
                ccb_ChucNang.Properties.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem(cn.MaChucNang,cn.TenChucNang,cn.MaNhonChucNang));
            }
            
        }

        private void loadNhomChucNang()
        {
            clbNCN.Items.Add(new CheckedListBoxItem("all", "Tất Cả", CheckState.Checked));
            List<NhomChucNang> ncns = nhomChucNang_Dal_Bll.loadNhomChucNang();
            foreach(NhomChucNang ncn in ncns)
            {
                CheckedListBoxItem item = new CheckedListBoxItem(ncn.MaNhomChucNang, ncn.TenNhomChucNang);
                clbNCN.Items.Add(item);
            }
        }
        private void clbNCN_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (CheckedListBoxItem selectedItem in clbNCN.CheckedItems)
            {
                foreach (CheckedListBoxItem item in ccb_ChucNang.Properties.Items)
                {
                    if (selectedItem.Value.ToString().Equals("all"))
                    {
                        item.Enabled = true;
                    }
                    else
                    {
                        if (item.Tag.ToString() != selectedItem.Value.ToString())
                            item.Enabled = false;
                        else
                            item.Enabled = true;
                    }
                        
                        //ccb_ChucNang.Properties.Items[item].Enabled = false;
                }    
            }
        }


        private void accordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            if(e.Element.Style == ElementStyle.Item)
            {
                this.Vt.MaVaiTro = e.Element.Name;
                this.Vt.TenVaiTro = e.Element.Text;
                txt_tencn.Text = e.Element.Text;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_apdung":
                    if (Vt.MaVaiTro == null)
                    {
                        new UC_Message().showAlert("Chọn đối tượng phân quyền", UC_Message.enmType.Warning);
                    }
                    else { 
                        if (String.IsNullOrEmpty(ccb_ChucNang.Text))
                        {
                            new UC_Message().showAlert("Chưa chọn chức năng cho " + Vt.TenVaiTro, UC_Message.enmType.Warning);
                        }
                        else
                        {
                            //List<PhanQuyen_VaiTro_ChucNang> list = new List<PhanQuyen_VaiTro_ChucNang>();
                            String[] maChnang = ccb_ChucNang.EditValue.ToString().Trim().Split(',');
                            foreach (string item in maChnang)
                            {
                                PhanQuyen_VaiTro_ChucNang pq = new PhanQuyen_VaiTro_ChucNang();
                                pq.MaVaiTro = Vt.MaVaiTro;
                                pq.MaChucNang = item.Trim();
                                pq.ThoiGianTruyCap = tseTu.Text.Trim() + "/" + tseDen.Text.Trim();
                                pq.MaPhanQuyen = "PQVC" + control.RandomCode();
                                //list.Add(pq);
                                String s = phanQuyen_VaiTro_ChucNang_Dal_Bll.phanQuyen(pq);
                                if (!s.Equals("OK"))
                                {
                                    new UC_Message().showAlert(s, UC_Message.enmType.Error);
                                    break;
                                }
                                else
                                {
                                    new UC_Message().showAlert("Đã thêm chức năng cho " + Vt.TenVaiTro, UC_Message.enmType.Success);
                                    //gcPhanQuyen.Refresh();
                                    loadBangPhanQuyen();
                                }
                            }
                            
                        }
                    }
                    break;
                case "btn_themchucnang":
                    if(txt_tencn.Text.Contains("Thêm chức năng"))
                    {
                        new UC_Message().showAlert("Nhập chức năng", UC_Message.enmType.Warning);
                    }
                    else
                    {
                        ChucNang cn = new ChucNang();
                        cn.MaNhonChucNang = clbNCN.SelectedValue.ToString();
                        cn.TenChucNang = txt_tencn.Text.Trim();
                        cn.MaChucNang = "CN" + control.RandomCode();
                        string rs = chucNang_Dal_Bll.themChucNang(cn);
                        if(rs.Contains("Have"))
                        {
                            new UC_Message().showAlert(cn.TenChucNang + "đã có trong Mục " 
                                + clbNCN.SelectedItem.ToString(), UC_Message.enmType.Warning);
                            return;
                        }
                        else if(rs.Contains("OK"))
                        {
                            new UC_Message().showAlert( "Đã thêm " +cn.TenChucNang + " vào "
                                + clbNCN.SelectedItem.ToString(), UC_Message.enmType.Success);
                        }
                        else
                        {
                            new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                        }    
                    }    
                    break;
                case "btn_suachucnah":
                    ccb_ChucNang.Enabled = false;
                    clbNCN.Enabled = false;
                    btn_apdung.Enabled = false;
                    btn_xoachucnang.Enabled = false;
                    btn_themchucnang.Enabled = false;
                    accordionControl1.Enabled = false;
                    colTenChucNang.OptionsColumn.AllowEdit = true;
                    //colThoiGianTruyCap.OptionsColumn.AllowEdit = true;
                    this.btnCan.Enabled = true;
                    this.colTenChucNang.ColumnEdit = this.repositoryItemChucNang;
                    loadChucNangEdit();
                    btn_suachucnah.Enabled = false;
                    break;
                case "btnCan":
                    ccb_ChucNang.Enabled = true;
                    clbNCN.Enabled = true;
                    btn_apdung.Enabled = true;
                    btn_xoachucnang.Enabled = true;
                    btn_themchucnang.Enabled = true;
                    accordionControl1.Enabled = true;
                    this.btn_suachucnah.Image = global::GUI.Properties.Resources.icons8_edit_32;
                    this.btn_suachucnah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    this.btn_suachucnah.ImageSize = new System.Drawing.Size(10, 10);
                    this.btnCan.Enabled = false;
                    this.colTenChucNang.FieldName = "ChucNang.TenChucNang";
                    this.colTenChucNang.ColumnEdit = null;
                    btn_suachucnah.Enabled = true;
                    //colThoiGianTruyCap.OptionsColumn.AllowEdit = false;
                    colTenChucNang.OptionsColumn.AllowEdit = false;
                    btn_suachucnah.Text = "";
                    break;
                case "btn_xoachucnang":
                    if(gvPhanQuyen.SelectedRowsCount == 0)
                    {
                        new UC_Message().showAlert("Chọn hàng để xóa", UC_Message.enmType.Warning);
                    }
                    else
                    {
                        string rs = phanQuyen_VaiTro_ChucNang_Dal_Bll.xoaPhanQuyen(
                            gvPhanQuyen.GetFocusedRowCellValue(colMaPhanQuyen).ToString().Trim());
                        if(rs.Contains("OK"))
                        {
                            new UC_Message().showAlert("Đã xóa", UC_Message.enmType.Success);
                            loadBangPhanQuyen();
                        }
                        else
                            new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                    }    
                    break;
                default:
                    break;
            }
        }

        private void loadChucNangEdit()
        {
            this.repositoryItemChucNang.DataSource = chucNang_Dal_Bll.loadChucNang();
            this.repositoryItemChucNang.ValueMember = "TenChucNang";
            this.repositoryItemChucNang.DisplayMember = "TenChucNang";
        }

        private void gvPhanQuyen_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "ChucNang.TenChucNang" ||e.Column.FieldName == "ThoiGianTruyCap")
            {
                string tenNang = gvPhanQuyen.GetRowCellValue(e.RowHandle, e.Column).ToString();
                string mapq = gvPhanQuyen.GetRowCellValue(e.RowHandle, colMaPhanQuyen).ToString();
                string tgtc = "";
                if (tseTu.Text.Trim().Equals(tseDen.Text.Trim()))
                     tgtc = "Full";
                else
                     tgtc = tseTu.Text.Trim() + "/" + tseDen.Text.Trim();
                ChucNang cn = chucNang_Dal_Bll.loadChucNang(tenNang);
                if (cn != null)
                {
                    string rs = phanQuyen_VaiTro_ChucNang_Dal_Bll.updatePhanQuyen2(cn.MaChucNang.Trim(), mapq.Trim(), tgtc);
                    if(rs.Contains("OK"))
                    {
                        new UC_Message().showAlert("Cập nhật thành công", UC_Message.enmType.Success);
                        loadBangPhanQuyen();
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
