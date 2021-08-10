using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BLL;

namespace GUI
{
    public partial class frm : DevExpress.XtraEditors.XtraForm
    {
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        CTPhieuNhap_dal_bll cTPhieuNhap_Dal_Bll = new CTPhieuNhap_dal_bll();
        CTHoaDon_dal_bll cTHoaDon_Dal_Bll = new CTHoaDon_dal_bll();
        LoaiHangHoa_dal_bll loaiHangHoa_Dal_Bll = new LoaiHangHoa_dal_bll();
        GUI_Control control = new GUI_Control();
        List<ChiTietNhap> lstNhap = null;
        List<ChiTietHoaDon> lstHoaDon = null;
        public frm()
        {
            InitializeComponent();
            init();
            //this.Controls.Add(new UC_Product_Dashbroad(DockStyle.Fill));
        }

        private void init()
        {
            //gcProduct.DataSource = hangHoa_Dal_Bll.LoadHangHoaHoatDong();
            var hanghoa = hangHoa_Dal_Bll.LoadHangHoaHoatDong();
            hangHoaBindingSource.DataSource = hanghoa;
            var loaihang = loaiHangHoa_Dal_Bll.loadLoaiHangHoa();
            loaiHangHoaBindingSource.DataSource = loaihang;

            LoadDataToLookupGrid(cboVitri);

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

        private void gvProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                lstNhap = cTPhieuNhap_Dal_Bll.loadChiTietNhap().ToList();
                lstHoaDon = cTHoaDon_Dal_Bll.loadCTHoaDon().ToList();
                string ma = gvProduct.GetFocusedRowCellValue("MaHangHoa").ToString().Trim();
                gvProduct.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
                UC_Product_EditPanel editPanel = new UC_Product_EditPanel(this.gvProduct);
                gvProduct.OptionsEditForm.CustomEditFormLayout = editPanel;
                //generalGridViewItems(ma);
            }
        }
    }
}