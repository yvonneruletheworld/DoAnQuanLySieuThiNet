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
using DevExpress.XtraEditors.Controls;
using GUI.MODEL;

namespace GUI
{
    public partial class UC_Config : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_Config _instance;
        Config_dal_bll config_Dal_Bll = new Config_dal_bll();

        public static UC_Config Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new UC_Config();
                }
                return _instance;
            }
        }
        public UC_Config()
        {
            InitializeComponent();
            loadConfig();
        }

        private void loadConfig()
        {
            ThietLap tl = config_Dal_Bll.loadConfig();
            if(tl != null)
            {
                txt_tencty.Text = tl.TenCongTy;
                de_ngayhoatdong.EditValue = tl.NgayBatDau;
                tseGioMoCua.EditValue = tl.GioMoCua;
                tseDongCua.EditValue = tl.GioDongCua;
                ghTonKho.Value = int.Parse(tl.MucTonKho.ToString());
                rt_LoaiChi.Text = tl.LoaiChi;
                rch_Htc.Text = tl.HinhThucChi;

                String[] ngayHDs = tl.NgayHoatDong.Split(',');
                foreach (CheckedListBoxItem item in cl_NgayHoatdong.Items)
                {
                    if (ngayHDs.Contains(item.Value))
                        item.CheckState = CheckState.Checked;
                }
                String[] caLam = tl.CaLam.Split('/');
                switch (caLam.Length)
                {
                    case 1:
                        radioGroup1.SelectedIndex = 0;
                        String[] gioLam = caLam[0].ToString().Split(',');
                        caMotTu.EditValue = gioLam[0];
                        caMotDen.EditValue = gioLam[1];
                        
                        break;
                    case 2:
                        radioGroup1.SelectedIndex = 1;
                        String[][] gioLam2 =  { caLam[0].ToString().Split(',') , caLam[1].ToString().Split(',') };
                        caMotTu.EditValue = gioLam2[0][0];
                        caMotDen.EditValue = gioLam2[0][1];
                        caHaiTu.EditValue = gioLam2[1][0];
                        caHaiDen.EditValue = gioLam2[1][1];
                        break;
                    case 3:
                        radioGroup1.SelectedIndex = 2;
                        String[][] gioLam3 = { caLam[0].ToString().Split(','), caLam[1].ToString().Split(','), caLam[2].ToString().Split(',') };
                        caMotTu.EditValue = gioLam3[0][0];
                        caMotDen.EditValue = gioLam3[0][1];
                        caHaiTu.EditValue = gioLam3[1][0];
                        caHaiDen.EditValue = gioLam3[1][1];
                        caBaTuu.EditValue = gioLam3[2][0];
                        caBaDen.EditValue = gioLam3[2][1];
                        break;
                    default:
                        break;
                }
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ch = radioGroup1.SelectedIndex;
            switch (ch)
            {
                case 0:
                    caHaiTu.Enabled = true;
                    caHaiDen.Enabled = true;
                    caBaTuu.Enabled = false;
                    caBaDen.Enabled = false;
                    caMotTu.Enabled = true;
                    caMotDen.Enabled = true;
                    break;
                case 1:
                    caHaiTu.Enabled = true;
                    caHaiDen.Enabled = true;
                    caBaTuu.Enabled = false;
                    caBaDen.Enabled = false;
                    caMotTu.Enabled = true;
                    caMotDen.Enabled = true;
                    break;
                case 2:
                    caHaiTu.Enabled = true;
                    caHaiDen.Enabled = true;
                    caBaTuu.Enabled = true;
                    caBaDen.Enabled = true;
                    caMotTu.Enabled = true;
                    caMotDen.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void btn_apdung_Click(object sender, EventArgs e)
        {
            string nhd = "";
            foreach (CheckedListBoxItem item in cl_NgayHoatdong.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    nhd = item.Value + ",";
            }
            ThietLap tl = new ThietLap
            {
                MaThietLap = "1",
                MucTonKho = (int?)ghTonKho.Value,
                TenCongTy = txt_tencty.Text.Trim(),
                NgayHoatDong = nhd,
                NgayBatDau = (DateTime)de_ngayhoatdong.EditValue,
                GioMoCua = tseGioMoCua.EditValue.ToString(),
                GioDongCua = tseDongCua.EditValue.ToString(),
                HinhThucChi = rch_Htc.Text,
                LoaiChi = rt_LoaiChi.Text
            };
            new UC_Message().showAlert(config_Dal_Bll.editConfig(tl), UC_Message.enmType.Success);
            MessageBox.Show("Restarting...");
            if (Program._LogIn == null || Program._LogIn.IsDisposed)
            {
                Program._LogIn = new frmLogIn(false);
            }
            Program._LogIn.Show();
            this.ParentForm.Close();
            Program._TaskMain = null;
            COMMON.currentUser = null;
        }
    }
}
