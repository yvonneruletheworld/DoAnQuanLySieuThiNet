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
using DevExpress.XtraBars;
using GUI.MODEL;

namespace GUI
{
    public partial class UC_Admin : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
        }

        private static UC_Admin _instance;

        public static UC_Admin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Admin();
                }
                return _instance;
            }
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            if(e.Group.Caption == "Tổng Quang")
            {
                this.ribbonControl.Enabled = false;
            }
            else
            {
                this.ribbonControl.Enabled = true;
            }
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void btn_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonItem item = e.Item as BarButtonItem;
            switch (item.Name)
            {
                case "btn_dx":
                    if (MessageBox.Show("Đăng xuất", COMMON.currentUser.HoTen + ", bạn muốn đăng xuất chương trình ?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Dispose();
                        COMMON.currentUser = null;
                        if (Program._LogIn == null || Program._LogIn.IsDisposed)
                        {
                            Program._LogIn = new frmLogIn(false);
                            Program._LogIn.Show();
                        }
                    }
                    break;
                case "btn_info":
                    new frmConcatBill(COMMON.currentUser).Show();
                    //pauseForm();
                    break;
                case "btn_ncc":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_NhaCungCap(DockStyle.Fill));
                    break;
                case "btn_pq":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_PhanQuyen(DockStyle.Fill));
                    break;
                case "btn_nnd":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_NhomNguoiDung(DockStyle.Fill));
                    break;
                case "btn_nhanvien":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_NhanVien(DockStyle.Fill));
                    break;
                case "btn_hanghoa":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_Product_Dashbroad(DockStyle.Fill));
                    break;
                case "btn_chi":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_PhieuChi());
                    break;
                case "btn_kho":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_KhoHang());
                    break;
                case "btn_kh":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_KhachHang());
                    break;
                case "btn_km":
                    customersNavigationPage.Controls.Clear();
                    customersNavigationPage.Controls.Add(new UC_KhuyenMai());
                    break;
            }
        }
    }
}
