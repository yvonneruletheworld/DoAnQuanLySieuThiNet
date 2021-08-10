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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GUI
{
    public partial class UC_NhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        NhaCungCap_dal_bll nhaCungCap_Dal_Bll = new NhaCungCap_dal_bll();
        CongNo_dal_bll congNo_Dal_Bll = new CongNo_dal_bll();
        List<CongNo> lstCongNo = null;
        GUI_Control control = new GUI_Control();
        NhaCungCap seleteNcc = null;
        CongNo selectedCN = null;
        List<NhaCungCap> lst = null;
        DatHang_dal_bll datHang_Dal_Bll = new DatHang_dal_bll();
        int rowCount = 0;
        public UC_NhaCungCap(DockStyle fill)
        {
            InitializeComponent();
            loadNhaCungCap();
            loadCongNo();
            this.Dock = fill;
        }

        private void loadCongNo()
        {
            lstCongNo = congNo_Dal_Bll.loadCongNo();
        }

        private void loadNhaCungCap()
        {
             lst = nhaCungCap_Dal_Bll.loadNhaCungCap().ToList();
            nhaCungCapBindingSource.DataSource = new BindingList<NhaCungCap>
                (lst);
        }

        private void gvNhaCungCap_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if(lstCongNo == null)
            {
                loadCongNo();
                gvNhaCungCap_MasterRowEmpty(sender, e);
            }
            else
            {
                GridView gv = sender as GridView;
                NhaCungCap cn = gv.GetRow(e.RowHandle) as NhaCungCap;
                if (cn != null)
                    e.IsEmpty = !lstCongNo.Any(item => item.MaNhaCungCap.Equals(cn.MaNhaCungCap));
            }
        }

        private void gvNhaCungCap_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            if(lstCongNo == null)
            {
                loadCongNo();
                gvNhaCungCap_MasterRowGetChildList(sender, e);
            }
            else
            {
                GridView gv = sender as GridView;
                NhaCungCap ncc = gv.GetRow(e.RowHandle) as NhaCungCap;
                if (ncc != null)
                    e.ChildList = lstCongNo.Where(item => item.MaNhaCungCap.Equals(ncc.MaNhaCungCap)).ToList();
            }
        }

        private void gvNhaCungCap_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvNhaCungCap_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "gcDetail";
        }

        private void gvNhaCungCap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                seleteNcc = gvNhaCungCap.GetRow(e.FocusedRowHandle) as NhaCungCap;
                if (seleteNcc == null)
                    return;

                lbl_TenNcc.Text = seleteNcc.TenNhaCungCap;
                lblDiaChi.Text = seleteNcc.DiaChi;
                if (seleteNcc.Logo != null)
                    logo.Image = control.ByteToImage(seleteNcc.Logo.ToArray());
                else
                    logo.Image = global::GUI.Properties.Resources.logo;
                if (seleteNcc.Active == true)
                {
                    lblTrangThai.Text = "Active";
                    lblTrangThai.ForeColor = System.Drawing.Color.RoyalBlue;
                }
                else
                {
                    lblTrangThai.Text = "Cancel";
                    lblTrangThai.ForeColor = System.Drawing.Color.DarkGray;
                }
                loadTinhTrangDonHang();
            }
            catch (Exception)
            {

            }
        }

        private void loadTinhTrangDonHang()
        {
            string rs = datHang_Dal_Bll.loadDatHangTheoNcc(seleteNcc);
            if (rs == null)
            {
                lblDonHang.Text = "Không có giao dịch nào gần đây";
            }
            else
            {
                lblDonHang.Text = rs;
                lblDonHang.ForeColor = System.Drawing.Color.RoyalBlue;
            }    
        }

        private void btn_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_save":
                    if (gvNhaCungCap.DataRowCount == rowCount)
                    {
                        saveEdit();
                    }
                    else
                    {
                        themNhaCungCap();
                    }
                    colTenNhaCungCap.OptionsColumn.AllowEdit = false;
                    colDiaChi.OptionsColumn.AllowEdit = false;
                    colSoDienThoai.OptionsColumn.AllowEdit = false;
                    colLoaiHang.OptionsColumn.AllowEdit = false;
                    colActive.OptionsColumn.AllowEdit = false;
                    btn_save.Enabled = false;
                    break;
                case "btn_sua":
                    btn_save.Enabled = true;
                    colTenNhaCungCap.OptionsColumn.AllowEdit = true;
                    colDiaChi.OptionsColumn.AllowEdit = true;
                    colSoDienThoai.OptionsColumn.AllowEdit = true;
                    colLoaiHang.OptionsColumn.AllowEdit = true;
                    break;
                case "btn_xoa":
                    btn_save.Enabled = false;
                    xoaNhaCungCap();
                    break;
                case "btn_thanhtoan":
                    if(selectedCN != null)
                    {
                        //pauseForm();
                        new XtraForm1(Double.Parse(selectedCN.ConLai.ToString()), seleteNcc.MaNhaCungCap).Show();
                    }
                    break;
                default:
                    break;
            }
        }

        private void pauseForm()
        {
            Form formBackground = new Form();
            try
            {
                using (XtraForm1 frm = new XtraForm1(Double.Parse(selectedCN.ConLai.ToString()), seleteNcc.MaNhaCungCap))
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

                    frm.Owner = formBackground;
                    frm.FormClosed += Frm_FormClosed;
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
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadCongNo();
        }

        private void themNhaCungCap()
        {
            List<NhaCungCap> lstNhaCungCap = new List<NhaCungCap>();
            for(int i = 0; i< (gvNhaCungCap.DataRowCount - rowCount); i++)
            {
                NhaCungCap ncc = gvNhaCungCap.GetRow(i) as NhaCungCap;
                lstNhaCungCap.Add(ncc);
            }
            string rs = nhaCungCap_Dal_Bll.themNcc(lstNhaCungCap);
            if (rs.Contains("OK"))
            {
                new UC_Message().showAlert("Thêm thành công", UC_Message.enmType.Success);
                loadNhaCungCap();
            }
            else
                new UC_Message().showAlert(rs, UC_Message.enmType.Error);
        }

        private void xoaNhaCungCap()
        {
            List<int> seletedRows = gvNhaCungCap.GetSelectedRows().ToList();

            if(seletedRows.Count < 1)
            {
                new UC_Message().showAlert("Chọn để xóa", UC_Message.enmType.Warning);
                return;
            }
            else
            {
                List<NhaCungCap> lstNhaCungCap = new List<NhaCungCap>();
                seletedRows.ForEach(row =>
                {
                    if(row >= 0)
                    {
                        NhaCungCap ncc = gvNhaCungCap.GetRow(row) as NhaCungCap;
                        lstNhaCungCap.Add(ncc);
                    }
                });
                string rs = nhaCungCap_Dal_Bll.xoaNcc(lstNhaCungCap);
                if (rs.Contains("OK"))
                {
                    new UC_Message().showAlert("Xóa thành công", UC_Message.enmType.Success);
                    loadNhaCungCap();
                }
                else
                    new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }    
        }

        private void saveEdit()
        {
            seleteNcc = gvNhaCungCap.GetFocusedRow() as NhaCungCap;
            seleteNcc.Logo = control.ImageToByteArray(logo.Image);
            string rs = nhaCungCap_Dal_Bll.updatNhaCungCap(seleteNcc);
            if(rs.Contains("OK"))
            {
                new UC_Message().showAlert("Cập nhật thành công", UC_Message.enmType.Success);
                loadNhaCungCap();
            }
            else
                new UC_Message().showAlert(rs, UC_Message.enmType.Error);
        }


        private void gvDetail_MouseDown(object sender, MouseEventArgs e)
        {
            GridView gv = sender as GridView;
            GridView focusedView = gcNhaCungCap.FocusedView as GridView;
            GridHitInfo hitInfo = gv.CalcHitInfo(e.Location);
            if(hitInfo.InRow)
            {
                int rowHandle = hitInfo.RowHandle;
                if(rowHandle != gv.FocusedRowHandle || !gv.Equals(focusedView))
                {
                    selectedCN = gv.GetRow(rowHandle) as CongNo;
                }
            }
        }

        private void UC_NhaCungCap_Load(object sender, EventArgs e)
        {
            this.rowCount = lst.Count;
        }
    }
}
