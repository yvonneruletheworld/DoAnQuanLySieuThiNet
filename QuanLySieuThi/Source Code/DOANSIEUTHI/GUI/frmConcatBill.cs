using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;
using DevExpress.XtraEditors;
using GUI.MODEL;
using System.Globalization;
using DevExpress.XtraBars;
using Guna.UI.WinForms;

namespace GUI
{
    public partial class frmConcatBill : DevExpress.XtraEditors.XtraForm
    {
        HoaDon_dal_bll hoaDon_Dal_Bll = new HoaDon_dal_bll();
        GUI_Control control = new GUI_Control();
        NguoiDung_dal_bll nguoiDung_Dal_Bll = new NguoiDung_dal_bll();

        //private string lbl_mahoadon;

        //public string Lbl_mahoadon { get => lbl_mahoadon; set => lbl_mahoadon = value; }

        public frmConcatBill(NguoiDung nd)
        {
            InitializeComponent();
            init(nd);
        }

        private void init(NguoiDung nd)
        {
            if (nd == null)
            {
                return;
            }
            else
            {
                try
                {
                    if(nd.HinhAnh != null)
                    {
                        this.gunaCirclePictureBox1.Image = control.ByteToImage(nd.HinhAnh.ToArray());
                    }
                    txt_hoten.Text = nd.HoTen;
                    txt_tdn.Text = nd.TenDangNhap;
                    txt_mk.Text = nd.MatKhau;
                    txt_diachi.Text = nd.DiaChi;
                    txt_Email.Text = nd.Email;
                    txt_sdt.Text = nd.DienThoai;
                    de_ngsinh.Text = nd.NgaySinh.ToString();
                    if (nd.TrangThai == "1")
                    {
                        gunaGoogleSwitch2.Checked = true;
                        label4.Text = "Hoạt động";
                    }
                    else
                    {
                        label4.Text = "Tạm Ngưng";
                        gunaGoogleSwitch2.Checked = false;
                    }
                }
                catch (Exception)
                {
                    new UC_Message().showAlert("Không tải được ", UC_Message.enmType.Error);
                }
            }
        }

        private void gunaCirclePictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.btn_anh.Visible = false;
        }

        private void gunaCirclePictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.btn_anh.Visible = true;
        }

        private void btn_anh_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_anh":
                    try
                    {
                        string imageLocation = "";
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                        if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            imageLocation = ofd.FileName;
                            gunaCirclePictureBox1.Image = Image.FromFile(imageLocation);
                            new UC_Message().showAlert("Tải ảnh thành công", UC_Message.enmType.Success);

                        }
                    }
                    catch (Exception)
                    {
                        new UC_Message().showAlert("Đã xảy ra lỗi", UC_Message.enmType.Error);
                    }

                    break;
                case "btn_sav":
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().Equals(typeof(TextEdit)) &&
                            String.IsNullOrEmpty(((TextEdit)c).Text))
                        {
                            new UC_Message().showAlert("Nhập đầy đủ thông tin", UC_Message.enmType.Warning);
                            break;
                        }
                    }
                    saveUser();
                    break;
            }
        }

        private void saveUser()
        {
            try
            {
                //convert
                byte[] file_byte = control.ImageToByteArray(gunaCirclePictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                NguoiDung nd = new NguoiDung();
                nd.MatKhau = txt_mk.Text.Trim();
                nd.TenDangNhap = txt_tdn.Text.Trim();
                nd.HoTen = txt_hoten.Text.Trim();
                nd.DienThoai = txt_sdt.Text.Trim();
                nd.Email = txt_Email.Text.Trim();
                nd.DiaChi = txt_diachi.Text.Trim();
                nd.GhiChu = dateEdit1.Text.Trim();
                nd.NgaySinh = de_ngsinh.DateTime.ToLocalTime();
                nd.HinhAnh = file_binary;

                NguoiDung rs = nguoiDung_Dal_Bll.updateNguoiDung(nd);
                if (rs != null)
                {
                    new UC_Message().showAlert("Đã cập nhật thành công", UC_Message.enmType.Success);
                    COMMON.currentUser = rs;
                }
                else
                    new UC_Message().showAlert("Cập nhật thất bại", UC_Message.enmType.Error);
            }
            catch (Exception)
            {
                new UC_Message().showAlert("Lỗi ", UC_Message.enmType.Error);
            }

        }
        private void gunaGoogleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (lbl_gt.Text.Contains("Nữ"))
                lbl_gt.Text = "Nam";
            lbl_gt.Text = "Nữ";
        }

    }
}