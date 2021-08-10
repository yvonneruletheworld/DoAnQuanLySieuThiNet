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
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DAL_BLL;

namespace GUI
{
    public partial class giaodich : DevExpress.XtraEditors.XtraForm
    {
        HoaDon_dal_bll hoaDon_Dal_Bll = new HoaDon_dal_bll();
        CTHoaDon_dal_bll cTHoaDon_Dal_Bll = new CTHoaDon_dal_bll();
        List<ChiTietHoaDon> lstCT = new List<ChiTietHoaDon>();
        Voucher_dal_bll voucher_Dal_Bll = new Voucher_dal_bll();
        public giaodich()
        {
            InitializeComponent();
            InitializeMenuItems();

            init();
        }

        private void init()
        {
            this.lstCT = cTHoaDon_Dal_Bll.loadCTHoaDon();
        }

        DXMenuItem[] menuItems;
        void InitializeMenuItems()
        {
            DXMenuItem itemEdit = new DXMenuItem("Thanh Toán", ItemEdit_Click);
            DXMenuItem itemDelete = new DXMenuItem("Xóa", ItemDelete_Click);
            menuItems = new DXMenuItem[] { itemEdit, itemDelete };

        }

        private void ItemEdit_Click(object sender, System.EventArgs e)
        {
            if (Program._create == null || Program._create.IsDisposed)
            {
                string mhd = gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, colMaHoaDon).ToString().Trim();
                if(mhd != null)
                {
                    Program._create = new create(mhd);
                    Program._create.mergeMenu(Program._Cashier);
                    Program._create.MdiParent = Program._Cashier;
                    Program._create.Show();
                    Program._create.FormClosed += createClose;
                    Program._giaodich = null;
                    Close();
                    //ribbon.SelectedPage = ribbon.MergedPages[0];
                    //this.Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
                }
            }

        }

        private void createClose(object sender, FormClosedEventArgs e)
        {
            //Program._Cashier.ribbon.UnMergeRibbon();
            Program._create = null;
        }

        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            String mahoaDons = "";
            List<int> selectedRows = gvHoaDon.GetSelectedRows().Where(c => c >= 0).ToList();
            selectedRows.ForEach(d =>
            {
                if((bool)gvHoaDon.GetRowCellValue(d, colTrangThai) == false)
                    mahoaDons += gvHoaDon.GetRowCellValue(d, colMaHoaDon).ToString().Trim() + ",";
                else
                {
                    new UC_Message().showAlert("Hoa Don Da thanh toan", UC_Message.enmType.Warning);
                }
            });
            string rs = hoaDon_Dal_Bll.xoaHoaDon(mahoaDons);
            if (rs != "OK")
            {
                new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }
                //gcHoaDon.RefreshDataSource();
                hoaDonBindingSource.DataSource =
                hoaDon_Dal_Bll.loadHoaDonNgay(DateTime.Now.ToString("yyyy-MM-dd"));
        }

        private void gvHoaDon_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                GridView view = sender as GridView;
                view.FocusedRowHandle = e.HitInfo.RowHandle;
                    foreach (DXMenuItem item in menuItems)
                        e.Menu.Items.Add(item);
            }
        }

        private void giaodich_Load(object sender, EventArgs e)
        {
            //new DevExpress.XtraGrid.Design.XViewsPrinting(gcHoaDon);
            hoaDonBindingSource.DataSource =
                hoaDon_Dal_Bll.loadHoaDonNgay(DateTime.Now.ToString("yyyy-MM-dd"));
        }
       
        public void GopHoaDonClick()
        {
            List<int> selectedRows = gvHoaDon.GetSelectedRows().Where(c => c >= 0).ToList();
            if (selectedRows.Count < 2)
            {
                new UC_Message().showAlert("Gộp từ 2 hóa đơn", UC_Message.enmType.Warning);
            }
            else
            {
                String mahds = "";
                selectedRows.ForEach(d =>
                {
                    if((bool)gvHoaDon.GetRowCellValue(d,colTrangThai) == false)
                        mahds += gvHoaDon.GetRowCellValue(d, colMaHoaDon).ToString().Trim() + ",";
                    else
                    {
                        new UC_Message().showAlert("Hóa đơn đã được thanh toán", UC_Message.enmType.Warning);
                    }    
                });
                List<ChiTietHoaDon> cthd = cTHoaDon_Dal_Bll.loadCTHoaDontheoProc(mahds.Trim());
                string id = gvHoaDon.GetRowCellValue(selectedRows.First(), colMaHoaDon).ToString().Trim();
                foreach (ChiTietHoaDon ct in cthd)
                {
                    taoHoaDonGop(ct.MaChiTiet, id);
                }
                try
                {
                    var mavc = gvHoaDon.GetRowCellValue(selectedRows.First(), colGiamGia);
                    if (mavc == null)
                    {
                        hoaDon_Dal_Bll.updateHoaDon(id, 0);
                    }
                    else
                    {
                        Voucher giagiam = voucher_Dal_Bll.getVoucher(mavc.ToString().Trim());
                        if (giagiam.MaSanPham == false)
                            hoaDon_Dal_Bll.updateHoaDon(id, giagiam.GiaGiam);
                        else
                            hoaDon_Dal_Bll.updateHoaDon(id, 0);
                    }    
                }
                catch (Exception)
                {
                    hoaDon_Dal_Bll.updateHoaDon(id, 0);
                }
                     
                
                hoaDonBindingSource.DataSource =
                hoaDon_Dal_Bll.loadHoaDonNgay(DateTime.Now.ToString("yyyy-MM-dd"));
                this.lstCT = cTHoaDon_Dal_Bll.loadCTHoaDon();
            }
        }

        private void taoHoaDonGop(string macts, string mahoadon)
        {
            int rs = cTHoaDon_Dal_Bll.uodateHoaDonGop(macts, mahoadon);
            if (rs != 0)
                new UC_Message().showAlert("Đã xảy ra lỗi", UC_Message.enmType.Error);
            else
                gcHoaDon.RefreshDataSource();
        }

        private void gvHoaDon_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView gr = sender as GridView;
            HoaDon hd = gr.GetRow(e.RowHandle) as HoaDon;
            if (hd != null)
                e.IsEmpty = !lstCT.Any( x => x.MaHoaDon == hd.MaHoaDon);
        }

        private void gvHoaDon_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView gr = sender as GridView;
            HoaDon hd = gr.GetRow(e.RowHandle) as HoaDon;
            if (hd != null)
                e.ChildList = lstCT.Where(x => x.MaHoaDon == hd.MaHoaDon).ToList();
        }

        private void gvHoaDon_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvHoaDon_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
    }
}