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
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using Guna.UI.WinForms;
using GUI.MODEL;

namespace GUI
{
    public partial class UC_NhomNguoiDung : DevExpress.XtraEditors.XtraUserControl
    {
        PhongBan_dal_bll phongBan_Dal_Bll = new PhongBan_dal_bll();
        VaiTro_dal_bll vaiTro_Dal_Bll = new VaiTro_dal_bll();
        NguoiDung_dal_bll nguoiDung_Dal_Bll = new NguoiDung_dal_bll();
        PhanQuyen_NguoiDung_VaiTro_dal_bll phanQuyen_NguoiDung_VaiTro_Dal_Bll =
            new PhanQuyen_NguoiDung_VaiTro_dal_bll();
        PhongBan pb;
        DXMenuItem[] menuItems;
        GUI_Control control = new GUI_Control();
        string mavt;
        public UC_NhomNguoiDung(DockStyle fill)
        {
            InitializeComponent();
            this.Dock = fill;
            loadPhongBan();
            loadNhanVien();
            InitializeMenuItems();
        }

        void InitializeMenuItems()
        {
            DXMenuItem itemEdit = new DXMenuItem("Chỉnh Sửa");
            DXMenuItem itemDelete = new DXMenuItem("Xóa");
            DXMenuItem itemCancel = new DXMenuItem("Thoát");
            menuItems = new DXMenuItem[] { itemEdit, itemDelete, itemCancel };

        }
        private void loadNhanVien()
        {
            

            if (gcMaVaiTro.ColumnHandle < 0)
            {
                phanQuyenNguoiDungVaiTroBindingSource.DataSource =
                new BindingList<PhanQuyen_NguoiDung_VaiTro>(phanQuyen_NguoiDung_VaiTro_Dal_Bll
                .loadNguoiDungVaiTro());
            }
           
        }
        private void loadCbb()
        {
            repositoryItemNhanVien.DataSource = nguoiDung_Dal_Bll.loadNguoiDung();
            repositoryItemNhanVien.DisplayMember = "TenDangNhap";
            repositoryItemNhanVien.ValueMember = "TenDangNhap";
            repositoryItemChucVu.DataSource = vaiTro_Dal_Bll.loadVaiTro();
            repositoryItemChucVu.DisplayMember = "MaVaiTro";
            repositoryItemChucVu.ValueMember = "MaVaiTro";
        }

        
        private void loadPhongBan()
        {
            phongBanBindingSource.DataSource = new BindingList<PhongBan>
                (phongBan_Dal_Bll.loadPhongBan());
            pb = new PhongBan();
        }

        private void gvChucVu_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //gvChucVu.SetRowCellValue(e.RowHandle, "PhongBan.TenPhongBan", pb.TenPhongBan);
            gvChucVu.SetRowCellValue(e.RowHandle, gcMaVaiTro, "VT" +control.RandomCode());
        }

        private void gvPhongBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = e.FocusedRowHandle;
            if(rowHandle >= 0)
            {
                pb.TenPhongBan = gvPhongBan.GetFocusedRowCellValue(colTenPhongBan).ToString().Trim();
                pb.MaPhongBan = gvPhongBan.GetFocusedRowCellValue(colMaPhongBan).ToString().Trim();
                if (pb.MaPhongBan != null)
                {
                    loadVaiTroTheoPhongBan(pb.MaPhongBan);
                }
            }
        }

        private void loadVaiTroTheoPhongBan(string maPhongBan)
        {
            vaiTroBindingSource.DataSource = new BindingList<VaiTro>
                (vaiTro_Dal_Bll.loadVaiTro(maPhongBan));
        }

        private void gvPhongBan_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if(e.HitInfo.InRow)
            {
                menuItems[2].Enabled = true;
                menuItems[0].Enabled = true;
                GridView gv = sender as GridView;
                gv.FocusedRowHandle = e.HitInfo.RowHandle;
                foreach (DXMenuItem item in menuItems)
                {
                    e.Menu.Items.Add(item);
                    if (gv.Name == "gvPhongBan")
                    {
                        item.Click += pbItem_Click;
                    }
                    else if(gv.Name == "gvChucVu")
                    {
                        item.Click += cvItem_Click;
                    }
                    else
                    {
                        menuItems[0].Enabled = false;
                        item.Click += nvItem_Click;
                        menuItems[2].Enabled = false;
                    }
                }
            }    
        }

        private void nvItem_Click(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            if (item.Caption == "Chỉnh Sửa")
            {
            }
            else if (item.Caption == "Thoát")
            {
               
            }
            else
            {
                xoaGridViewFocused(gvNhanVien, 2);
            }
        }

        private void cvItem_Click(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            if (item.Caption == "Chỉnh Sửa")
            {
                gcMaVaiTro.OptionsColumn.AllowEdit = true;
                gcTenVaiTro.OptionsColumn.AllowEdit = true;
            }
            else if (item.Caption == "Thoát")
            {
                gcMaVaiTro.OptionsColumn.AllowEdit = false;
                gcTenVaiTro.OptionsColumn.AllowEdit = false;
            }
            else
            {
                xoaGridViewFocused(gvChucVu, 1);
            }
        }

        private void pbItem_Click(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            if (item.Caption == "Chỉnh Sửa")
            {
                colTenPhongBan.OptionsColumn.AllowEdit = true;
            }
            else if (item.Caption == "Thoát")
            {
                colTenPhongBan.OptionsColumn.AllowEdit = false;
            }
            else
            {
                xoaGridViewFocused(gvPhongBan, 0);
            }    
        }

        public void xoaGridViewFocused (GridView gv, int type)
        {
            string rs = "";
            List<int> selectedRows = gv.GetSelectedRows().Where(r => r >= 0).ToList();
            if(selectedRows.Count < 1)
            {
                new UC_Message().showAlert("Chọn hàng để xóa", UC_Message.enmType.Warning);
                return;
            }
            else
            {
                switch (type)
                {
                    case 0:
                        string maPhongBans = "";
                        selectedRows.ForEach(sr =>
                        {
                            string MaPhongBan = gv.GetRowCellValue(sr, colMaPhongBan).ToString();
                            maPhongBans += MaPhongBan.Trim() + ",";
                        });
                        rs = phongBan_Dal_Bll.xoaPhongBan(maPhongBans);
                        loadPhongBan();
                        break;
                    case 1:
                        String vts = "";
                        selectedRows.ForEach(sr =>
                        {
                            String MaVaiTro = gv.GetRowCellValue(sr, gcMaVaiTro).ToString();
                            vts += MaVaiTro.Trim() + ",";
                        });
                        rs = vaiTro_Dal_Bll.xoaVaiTro(vts);
                        loadVaiTroTheoPhongBan(pb.MaPhongBan);
                        break;
                    case 2:
                        string mapq = gv.GetRowCellValue(gv.FocusedRowHandle, colMaPhanQuyen).ToString().Trim();
                        rs = phanQuyen_NguoiDung_VaiTro_Dal_Bll.xoaPhanQuyen(mapq);
                        loadNhanVienTheoChucVu(mavt);
                        break;
                    default:
                        break;
                }

                if (rs.Contains("OK"))
                {
                    new UC_Message().showAlert("Xóa Thành Công", UC_Message.enmType.Success);
                }
                else if(rs.Contains("Have"))
                {
                    new UC_Message().showAlert("Không Thể Xóa", UC_Message.enmType.Warning);
                }    
                else
                    new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }    
        }
        private void btn_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_pb":
                    List<PhongBan> phongBans = new List<PhongBan>();
                    for(int i = 0; i< gvPhongBan.DataRowCount; i ++)
                    {
                        string tpb = gvPhongBan.GetRowCellValue(i, colTenPhongBan).ToString().Trim();
                        if (phongBan_Dal_Bll.kiemTraTonTai(tpb) == false)
                        {
                            PhongBan p = new PhongBan();
                            p.TenPhongBan = tpb;
                            p.MaPhongBan = gvPhongBan.GetRowCellValue(i, colMaPhongBan).ToString().Trim();
                            phongBans.Add(p);
                        }
                    }
                    string rs = phongBan_Dal_Bll.themPhongBan(phongBans);
                    if (rs.Contains("OK"))
                    {
                        new UC_Message().showAlert("Đã thêm", UC_Message.enmType.Success);
                        loadPhongBan();
                    }
                    else
                        new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                    break;
                case "btn_pq":
                    if(btn_pq.Text.Trim() == "")
                    {
                        colMaNhanVine.ColumnEdit = this.repositoryItemNhanVien;
                        colMaVaiTro.ColumnEdit = this.repositoryItemChucVu;
                        colThoiGianBatDau.ColumnEdit = this.repositoryItemDateBD;
                        colThoiGianKetThuc.ColumnEdit = this.repositoryItemDateBD;
                        btn_pq.Text = "Save";
                        loadCbb();
                    }
                    else
                    {
                        colThoiGianBatDau.ColumnEdit = null;
                        colThoiGianKetThuc.ColumnEdit = null;
                        colMaNhanVine.ColumnEdit = null;
                        colVaiTro.ColumnEdit = null;
                        btn_pq.Text = "";
                        colMaNhanVine.FieldName = "TenDangNhap";
                        colVaiTro.FieldName = "VaiTro.TenVaiTro";
                        colThoiGianKetThuc.FieldName = "ThoiGianBatDau";
                        colThoiGianBatDau.FieldName = "ThoiGianKetThuc";
                    }    
                    break;
                case "btn_cv":
                    List<VaiTro> vts = new List<VaiTro>();
                    for(int i = 0; i< gvChucVu.DataRowCount; i++)
                    {
                        if(vaiTro_Dal_Bll.kiemTraTonTai(gvChucVu.GetRowCellValue(i,gcTenVaiTro).ToString()) == false)
                        {
                            VaiTro vt = new VaiTro();
                            vt.MaVaiTro = gvChucVu.GetRowCellValue(i, gcMaVaiTro).ToString();
                            vt.TenVaiTro = gvChucVu.GetRowCellValue(i, gcTenVaiTro).ToString();
                            vt.MaPhongBan = pb.MaPhongBan;
                            vts.Add(vt);
                        }

                    }
                    string rc = vaiTro_Dal_Bll.themVaiTro(vts);
                    if (rc.Contains("OK"))
                    {
                        new UC_Message().showAlert("Đã thêm", UC_Message.enmType.Success);
                        loadVaiTroTheoPhongBan(pb.MaPhongBan);
                    }
                    break;
            }
        }


        private void gvPhongBan_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvPhongBan.SetRowCellValue(e.RowHandle, colMaPhongBan, "PB" + control.RandomCode());
        }

        private void gvChucVu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = e.FocusedRowHandle;
            if (rowHandle >= 0)
            {
               mavt = gvChucVu.GetFocusedRowCellValue(gcMaVaiTro).ToString().Trim();
                if (mavt != null)
                {
                    loadNhanVienTheoChucVu(mavt);
                }
            }
        }

        private void loadNhanVienTheoChucVu(string mavt)
        {
                phanQuyenNguoiDungVaiTroBindingSource.DataSource =
                new BindingList<PhanQuyen_NguoiDung_VaiTro>(phanQuyen_NguoiDung_VaiTro_Dal_Bll
                .loadNguoiDungVaiTro(mavt.Trim(), COMMON.currentUser.TenDangNhap));
        }

        private void gvPhongBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                PhongBan pb = new PhongBan();
                pb.MaPhongBan = gvPhongBan.GetRowCellValue(e.RowHandle, colMaPhongBan).ToString();
                pb.TenPhongBan = gvPhongBan.GetRowCellValue(e.RowHandle, colTenPhongBan).ToString();

                if (pb != null)
                {
                    string rs = phongBan_Dal_Bll.suaPhongBan(pb);
                    if (rs.Contains("OK"))
                    {
                        new UC_Message().showAlert("Đã thêm", UC_Message.enmType.Success);
                        loadPhongBan();
                    }
                    else
                        new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                }
            }
        }

        private void gvNhanVien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "MaNguoiDung")
            {
                string id = gvNhanVien.GetRowCellValue(e.RowHandle, colMaNhanVine).ToString().Trim();
                    NguoiDung nd = nguoiDung_Dal_Bll.loadNguoiDung(id);
                    gvNhanVien.SetRowCellValue(e.RowHandle, colTenNhanVien, nd.HoTen.Trim());
            }
            else if(e.Column.FieldName == "VaiTro.TenVaiTro")
            {
                string id = gvNhanVien.GetRowCellValue(e.RowHandle, e.Column.FieldName).ToString().Trim();
                VaiTro vt = vaiTro_Dal_Bll.loadVaiTroTheoTen(id);
                gvNhanVien.SetRowCellValue(e.RowHandle, colMaVaiTro, vt.MaVaiTro.Trim());
            }    
        }

        
        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                if (gvNhanVien.GetRowCellValue(e.FocusedRowHandle, colMaPhanQuyen).ToString().Equals("ID"))
                {
                    //add
                    try
                    {
                        PhanQuyen_NguoiDung_VaiTro pq = new PhanQuyen_NguoiDung_VaiTro();
                        pq.MaPhanQuyen = "PQNDVT" + control.RandomCode();
                        pq.MaNguoiDung = gvNhanVien.GetRowCellValue(e.FocusedRowHandle, colMaNhanVine).ToString().Trim();
                        pq.MaVaiTro = gvNhanVien.GetRowCellValue(e.FocusedRowHandle, colMaVaiTro).ToString().Trim();
                        pq.ThoiGianBatDau = DateTime.Parse(gvNhanVien.GetRowCellValue(e.FocusedRowHandle, colThoiGianBatDau).ToString().Trim());
                        pq.ThoiGianKetThuc = DateTime.Parse(gvNhanVien.GetRowCellValue(e.FocusedRowHandle, colThoiGianKetThuc).ToString().Trim());

                        string rs = phanQuyen_NguoiDung_VaiTro_Dal_Bll.phanQuyen(pq);
                        if (rs.Contains("OK"))
                        {
                            new UC_Message().showAlert("Đã thêm", UC_Message.enmType.Success);
                            nguoiDung_Dal_Bll.capNhatTrangThai(pq.MaNguoiDung);
                            loadNhanVienTheoChucVu(pq.MaVaiTro);

                        }
                        else if (rs.Contains("Have"))
                        {
                            new UC_Message().showAlert("Đã tồn tại", UC_Message.enmType.Warning);
                        }
                        else
                            new UC_Message().showAlert(rs, UC_Message.enmType.Error);
                    }
                    catch (Exception ex)
                    {
                        new UC_Message().showAlert(ex.Message, UC_Message.enmType.Error);
                    }
                   
                }
            }
        }

        private void gvNhanVien_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvNhanVien.SetRowCellValue(e.RowHandle, colMaPhanQuyen, "ID");
        }
    }
}
