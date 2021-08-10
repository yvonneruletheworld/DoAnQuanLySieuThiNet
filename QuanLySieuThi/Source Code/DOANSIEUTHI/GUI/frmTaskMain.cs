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
using GUI.MODEL;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars;

namespace GUI
{
    public partial class frmTaskMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        NguoiDung_dal_bll nguoiDung_Dal_Bll = new NguoiDung_dal_bll();
        VaiTro_dal_bll vaiTro_Dal_Bll = new VaiTro_dal_bll();
        PhanQuyen_VaiTro_ChucNang_dal_bll phanQuyen_VaiTro_ChucNang_Dal_Bll = new PhanQuyen_VaiTro_ChucNang_dal_bll();
        ManHinh_dal_bll manHinh_Dal_Bll = new ManHinh_dal_bll();
        PhanQuyen_NguoiDung_VaiTro_dal_bll phanQuyen_NguoiDung_VaiTro_Dal_Bll =
            new PhanQuyen_NguoiDung_VaiTro_dal_bll();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskMain));

        //private static frmTaskMain _instance;

        //public static frmTaskMain Instance {
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new frmTaskMain();
        //        }
        //        return _instance;
        //    }
        //}

        public frmTaskMain()
        {
            InitializeComponent();

        }

        private void loadChucVu(NguoiDung currentUser)
        {
            if(currentUser == null)
            {
                MessageBox.Show("Lỗi");
            }    
            else
            {
                List<VaiTro> mand = phanQuyen_NguoiDung_VaiTro_Dal_Bll.loadVaiTro(currentUser.TenDangNhap);
                foreach (VaiTro vt in mand)
                {
                    AccordionControlElement ace = new AccordionControlElement();
                    ace.Name = vt.MaVaiTro;
                    ace.Text = vt.TenVaiTro;
                    ace.Style = ElementStyle.Group;
                    ace.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ace_ChucNang.ImageOptions.SvgImage")));
                    this.aec_ChucVu.Elements.Add(ace);
                    loadChucNang(vt, ace);
                }
            }    
        }

        private void loadChucNang(VaiTro vt, AccordionControlElement parent)
        {
            List<PhanQuyen_VaiTro_ChucNang> chucNang = phanQuyen_VaiTro_ChucNang_Dal_Bll
                                        .loadChucNangTheoVaiTro(vt.MaVaiTro.Trim());
            foreach(PhanQuyen_VaiTro_ChucNang cn in chucNang)
            {
                AccordionControlElement ace = new AccordionControlElement();
                ace.Name = cn.MaChucNang.Trim();
                ace.Text = cn.ChucNang.TenChucNang.Trim();
                ace.Style = ElementStyle.Item;
                ace.Click += new EventHandler(this.menuItemClick);
                parent.Elements.Add(ace);
                if(!cn.ThoiGianTruyCap.Equals("Full"))
                {
                    timeLimmit(cn, ace);
                }
            }
        }

        private void timeLimmit(PhanQuyen_VaiTro_ChucNang cn, AccordionControlElement ace)
        {
            String[] times = cn.ThoiGianTruyCap.Trim().Split('/');
            DateTime start = DateTime.Parse(times[0]);
            DateTime end = DateTime.Parse(times[1]);
            DateTime now = DateTime.Now;

            int ws = TimeSpan.Compare(start.TimeOfDay, now.TimeOfDay);
            int we = TimeSpan.Compare(end.TimeOfDay, now.TimeOfDay);

            if (ws >= 0 || we <= 0)
            {
                ace.Enabled = false;
            }
        }

        private void menuItemClick(object sender, EventArgs e)
        {
            AccordionControlElement ace = (AccordionControlElement)sender;
            //new UC_Message().showAlert(ace.Name.Trim(), UC_Message.enmType.Info);
            loadManHinh(ace.Name.Trim());
            
        }

        private void loadManHinh(string maChucNang)
        {
            ManHinh mh = manHinh_Dal_Bll.loadManHinh(maChucNang);
            switch (mh.TenManHinh.Trim())
            {
                case "frmCashier_Main":
                    if(Program._Cashier == null || Program._Cashier.IsDisposed)
                    {
                        new UC_Message().showAlert("Chuyển sang màn hình Thu Ngân", UC_Message.enmType.Info);
                        Program._Cashier = new frmCashier_Main();
                    }
                    Program._Cashier.Show();
                    Program._TaskMain = null;
                    this.Close();
                    break;
                case "UC_Admin":
                    fluentDesignFormContainer1.Controls.Clear();
                    if (!fluentDesignFormContainer1.Controls.Contains(UC_Admin.Instance))
                    {
                        try
                        {
                            fluentDesignFormContainer1.Controls.Add(UC_Admin.Instance);
                            UC_Admin.Instance.Dock = DockStyle.Fill;
                            UC_Admin.Instance.BringToFront();
                            UC_Admin.Instance.BringToFront();
                        }
                        catch (Exception)
                        {

                        }
                    }
                    break;
                case "UC_BaoCao":
                    fluentDesignFormContainer1.Controls.Clear();
                    if (!fluentDesignFormContainer1.Controls.Contains(UC_BaoCao.Instance))
                    {
                        fluentDesignFormContainer1.Controls.Add(UC_BaoCao.Instance);
                        UC_BaoCao.Instance.Dock = DockStyle.Fill;
                        UC_BaoCao.Instance.BringToFront();
                    }
                    UC_BaoCao.Instance.BringToFront();
                    break;
                default:
                    break;
            }
        }
        private void frmTaskMain_Load(object sender, EventArgs e)
        {
            loadChucVu(COMMON.currentUser);
            this.Text = "Xin Chào, " + COMMON.currentUser.HoTen + " !";
            fluentDesignFormContainer1.Controls.Clear();
            if (!fluentDesignFormContainer1.Controls.Contains(UC_Config.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(UC_Config.Instance);
                UC_Config.Instance.Dock = DockStyle.Fill;
                UC_Config.Instance.BringToFront();
            }
            UC_Config.Instance.BringToFront();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show( "Đăng xuất khỏi tài khoản "+COMMON.currentUser.HoTen, "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                COMMON.currentUser = null;
                if(Program._LogIn == null || Program._LogIn.IsDisposed)
                {
                    Program._LogIn = new frmLogIn(false);
                    Program._LogIn.Show();
                }  
                this.Close();
                Program._TaskMain = null;
            }
        }
    }
}