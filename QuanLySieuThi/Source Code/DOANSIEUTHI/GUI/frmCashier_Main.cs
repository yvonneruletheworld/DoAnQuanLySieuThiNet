using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DAL_BLL;
using GUI.MODEL;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Navigation;

namespace GUI
{
    public partial class frmCashier_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static frmCashier_Main _instance;
        bool isClose = true;
        //private create cr = null;
        //private giaodich gd = null;
        PhongBan_dal_bll phongBan_Dal_Bll = new PhongBan_dal_bll();
        VaiTro_dal_bll vaiTro_Dal_Bll = new VaiTro_dal_bll();
        GUI_Control control = new GUI_Control();

        public static frmCashier_Main Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmCashier_Main();
                }
                return _instance;
            }
        }
        public frmCashier_Main()
        {
            InitializeComponent();
        }

        private void menuItemClick(object sender, ItemClickEventArgs e)
        {
            BarButtonItem btn = e.Item as BarButtonItem;
            switch (btn.Name)
            {
                case "btn_add":
                    if(Program._create == null || Program._create.IsDisposed)
                    {
                        Program._create = new create("");
                        Program._create.mergeMenu(this);
                        Program._create.MdiParent = this;
                        Program._create.Show();
                        Program._create.FormClosed += createClose;
                        ribbon.SelectedPage = ribbon.MergedPages[0];
                        this.Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
                    }
                    break;
                case "btn_gd":
                    if (Program._giaodich == null || Program._giaodich.IsDisposed)
                    {
                        Program._giaodich = new giaodich();
                        Program._giaodich.MdiParent = this;
                        Program._giaodich.Show();
                        this.btn_gop.Enabled = true;
                        Program._giaodich.FormClosed += Gd_FormClosed;
                    }
                    break;
                case "btn_gop":
                    string cthd = "";
                    Program._giaodich.GopHoaDonClick();
                    break;
                case "btn_pause":
                    btn_pause.Caption = "Quầy tạm đóng";
                    btn_pause.ImageOptions.Image = global::GUI.Properties.Resources.icons8_play_48;
                    pauseForm();
                    btn_pause.Caption = "Tạm đóng quầy";
                    btn_pause.ImageOptions.Image = global::GUI.Properties.Resources.icons8_pause_48;
                    break;
                case "btn_support":
                    if(isClose == true)
                    {
                        nvb_hotro.Size = new Size(180, 813);
                        nvb_hotro.Dock = DockStyle.Right;
                        control.loadNavBarHoTro(this.nvb_hotro);
                        isClose = false;
                    }
                    else
                    {
                        nvb_hotro.Size = new Size(0, 813);
                        nvb_hotro.Dock = DockStyle.Right;
                        isClose = true;
                    }    
                    
                    break;
            }
            
        }

        //private void loadNavBarHoTro()
        //{
        //    // load nhân viên quầy hàng, có đi làm và có ca làm việc tương ứng
        //    List<PhongBan> dspb = phongBan_Dal_Bll.loadPhongBan();
        //    foreach (PhongBan pb in dspb)
        //    {
        //        AccordionControlElement ace = new AccordionControlElement(ElementStyle.Group);
        //        ace.Text = pb.TenPhongBan.Trim();
        //        ace.Name = pb.MaPhongBan.Trim();
        //        ace.Appearance.Normal.ForeColor = System.Drawing.Color.White;
        //        loadItemChild(ace);
        //        nvb_hotro.Elements.Add(ace);
        //    }
        //}

        //private void loadItemChild(AccordionControlElement ace)
        //{
        //    List<VaiTro> vts = vaiTro_Dal_Bll.loadVaiTro(ace.Name);
        //    foreach (VaiTro vt in vts)
        //    {
        //        AccordionControlElement ace1 = new AccordionControlElement(ElementStyle.Item);
        //        ace1.Text = vt.TenVaiTro;
        //        ace1.Name = vt.MaVaiTro.Trim();
        //        ace1.Appearance.Normal.ForeColor = System.Drawing.Color.White;
        //        ace.Elements.Add(ace1);
        //    }
        //}

        private void pauseForm()
        {
            Form formBackground = new Form();
            try
            {
                using (frmLogIn uu = new frmLogIn(true))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

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

        private void Gd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.btn_gop.Enabled = false;
            Program._giaodich = null;
        }

        private void createClose(object sender, FormClosedEventArgs e)
        {
            this.ribbon.UnMergeRibbon();
            Program._create = null;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Trở về trang chủ ", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Program._TaskMain == null || Program._TaskMain.IsDisposed)
                {
                    Program._TaskMain = new frmTaskMain();
                    Program._TaskMain.Show();
                }
                Program._Cashier = null;
                this.Close();
            }
        }
    }
}