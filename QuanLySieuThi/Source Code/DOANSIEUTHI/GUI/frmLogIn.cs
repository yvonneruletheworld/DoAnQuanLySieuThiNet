using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;
using DevExpress.XtraSplashScreen;
//using FireSharp.Config;
//using FireSharp.Interfaces;
using FireSharp.Response;
using GUI.MODEL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GUI
{
    public partial class frmLogIn : Form
    {
        public bool isValidTextBox = true;
        public bool isCashier;
        private Color textBoxBorderColor, textBoxFocusBorderColor ;
        NguoiDung_dal_bll nguoiDung_Dal_Bll = new NguoiDung_dal_bll();
        VaiTro_dal_bll vaiTro_Dal_Bll = new VaiTro_dal_bll();
        PhanQuyen_NguoiDung_VaiTro_dal_bll phanQuyen_NguoiDung_VaiTro_Dal_Bll
            = new PhanQuyen_NguoiDung_VaiTro_dal_bll();
        Config_dal_bll config_Dal_Bll = new Config_dal_bll();
        List<Account> lst;
        //firebase
        //IFirebaseConfig firebaseConfig = new FirebaseConfig
        //{
        //    AuthSecret = "Z4plqhJs5asEIuFq7ReEfyjLvNQE9MMr6euygB46",
        //    BasePath = "https://quanlysieuthi-12102000-default-rtdb.firebaseio.com/"
        //};

        //IFirebaseClient _client;

        public frmLogIn(bool isCashier)
        {
            InitializeComponent();
            if (isCashier)
            {
                this.TopMost = true;
                panel1.BackColor = Color.Transparent;
            }
            else
            {
                panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
                timer1.Start();
                kiemTraKetNoi();
            }
            textBoxBorderColor = username_txt.BorderColor;
            textBoxFocusBorderColor = username_txt.FocusedBorderColor;
            this.isCashier = isCashier;
        }

       

        private void kiemTraKetNoi()
        {
            int kq = CheckConfig();
            if (kq == 0)
            {
                new UC_Message().showAlert("Đã kết lỗi", UC_Message.enmType.Info);
            }
            if (kq == 1)
            {
                new UC_Message().showAlert("Chuỗi cấu hình không tồn tại", UC_Message.enmType.Warning);
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
            }
        }

        private async Task loadDangKi()
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaiting), true, true, false);
            if(FireBaseConnect.Client == null)
            {
                //_client = new FireSharp.FirebaseClient(firebaseConfig);
                FireBaseConnect.connectFireBase();
                loadDangKi();
            }
            else
            {
                FirebaseResponse firebaseResponse = await FireBaseConnect.Client.GetTaskAsync("Account/");
                if(firebaseResponse != null)
                {
                    string JSonTxt = firebaseResponse.Body;
                    if (JSonTxt == null)
                        return;
                    else
                    {
                        lst = new List<Account>();
                        dynamic data = JsonConvert.DeserializeObject(JSonTxt);
                        if(data != null)
                        {
                            foreach(var item in data)
                            {
                                Account acc = JsonConvert.DeserializeObject<Account>
                                    (((JProperty)item).Value.ToString());
                                acc.user = item.Name;
                                lst.Add(acc);
                            }
                        }

                        lst.ForEach( i =>
                            {
                             if(lst.Count > 3)
                                {
                                    if (int.Parse(i.rate) < lst.Count - 3)
                                    {
                                        UC_Account acc = new UC_Account(i);
                                        acc.btnClose.Click += BtnClose_Click;
                                        acc.Click += Acc_Click;
                                        panel1.Controls.Add(acc);
                                    }
                             }
                             else
                                {
                                    UC_Account acc = new UC_Account(i);
                                    acc.btnClose.Click += BtnClose_Click;
                                    acc.Click += Acc_Click;
                                    panel1.Controls.Add(acc);
                                }
                        });
                    }
                }
            }
            SplashScreenManager.CloseForm();
        }

        private void Acc_Click(object sender, EventArgs e)
        {
            UC_Account acc = sender as UC_Account;
            username_txt.Text = acc.id.Text;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var rs = FireBaseConnect.Client.Delete("Account/" + COMMON.currentUser.TenDangNhap.Trim());
        }

        private int CheckConfig()
        {
            //string cnn = Properties.Settings.Default.CNN;
            //MessageBox.Show("CNN= " + cnn);

            if (Properties.Settings.Default.CNN == string.Empty)
            {
                return 1;
            }
            SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.CNN);
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                return 0;
            }
            catch (SqlException ex)
            {
                var sth = ex.Message;
                return 2;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(isCashier == false)
            {
                DialogResult option = MessageBox.Show(this, "Những tiến trình đang hoạt động. Bạn thật sự muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                new UC_Message().showAlert("Vui lòng đăng nhập để tiếp tục", UC_Message.enmType.Warning);
            }    
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
               
            if(CheckConfig() == 1)
            {
                new UC_Message().showAlert("Lỗi kết nối", UC_Message.enmType.Error);
                return;
            }    
            if(isCashier == false)
            {
                NguoiDung currentUser = nguoiDung_Dal_Bll.loadNguoiDung(username_txt.Text.Trim(), matkhau_txt.Text.Trim());
                if (currentUser == null)
                {
                    //MessageBox.Show("Người dùng "+ username_txt +"chưa đăng ký");
                    //notifyIcon1.Visible = true;
                    //notifyIcon1.ShowBalloonTip(1000, "Đăng nhập", "Người dùng " + username_txt + "chưa đăng ký", ToolTipIcon.Error);
                    UC_Message msg = new UC_Message();
                    msg.showAlert("Người dùng " + username_txt.Text + "chưa đăng ký", UC_Message.enmType.Error);
                    username_txt.Clear();
                    matkhau_txt.Clear();
                    username_txt.Focus();
                }
                else
                {
                    UC_Message msg = new UC_Message();
                    msg.showAlert("Đăng nhập thành công", UC_Message.enmType.Info);
                    //notifyIcon1.Visible = true;
                    //notifyIcon1.ShowBalloonTip(1000, "Đăng nhập", "Đăng nhập thành công", ToolTipIcon.Info);
                    //MessageBox.Show("Đăng nhập thành công ");
                    COMMON.currentUser = currentUser;

                    if (!CheckDay())
                    {
                        new UC_Message().showAlert("Phiên làm việc chưa bắt đầu! ", UC_Message.enmType.Info);
                        return;
                    }
                    else
                    {
                        if (Program._TaskMain == null || Program._TaskMain.IsDisposed)
                        {
                            Program._TaskMain = new frmTaskMain();
                            ghiLaiDangNhap();
                        }
                        Program._TaskMain.Show();
                        this.Visible = false;
                        Program._LogIn = null;

                    }
                }
            }
            else
            {
                if (!username_txt.Text.Trim().Equals(COMMON.currentUser.TenDangNhap)
                    && !matkhau_txt.Text.Trim().Equals(COMMON.currentUser.MatKhau))
                {
                    this.Close();
                    Program._LogIn = null;
                }
                else
                {
                    UC_Message msg = new UC_Message();
                    msg.showAlert("Người dùng " + username_txt.Text + "chưa đăng ký", UC_Message.enmType.Error);
                }    
                    
            }
        }

        private bool CheckDay()
        {
            if (COMMON.currentUser != null &&
                phanQuyen_NguoiDung_VaiTro_Dal_Bll.loadVaiTro(username_txt.Text.Trim(), "AD") != null)
                return true;
            else
            {
                String tlngay = config_Dal_Bll.loadConfig().NgayHoatDong;
                if(tlngay.Contains("ALL"))
                {
                    return true;
                }
                String day = DateTime.Now.DayOfWeek.ToString();
                if (tlngay.Contains(day))
                    return true;
                else
                    return false;
            }    
        }

        private void ghiLaiDangNhap()
        {
            if(FireBaseConnect.Client == null)
            {
                //_client = new FireSharp.FirebaseClient(firebaseConfig);
                FireBaseConnect.connectFireBase();
                ghiLaiDangNhap();
            }
            else
            {
                 
                try
                {
                    Account a = new Account
                    {
                        name = COMMON.currentUser.HoTen,
                        date = DateTime.Now.ToString("dd/MM/yyyy"),
                        time = DateTime.Now.ToString("h:mm:ss tt"),
                        rate = "1",
                        pass = COMMON.currentUser.MatKhau
                    };
                    if (kiemTraTonTai())
                    {
                        a.rate = (int.Parse(a.rate) + 1).ToString();
                        var rs = FireBaseConnect.Client.Update("Account/" + COMMON.currentUser.TenDangNhap.Trim(), a);
                    }
                    else
                    {
                        var rs = FireBaseConnect.Client.Set("Account/" + COMMON.currentUser.TenDangNhap.Trim(), a);
                    }
                }
                catch (Exception e)
                {
                    new UC_Message().showAlert(e.Message, UC_Message.enmType.Error);
                }
            }    
        }

        private bool kiemTraTonTai()
        {
            if(lst != null)
            {
                foreach (Account i in lst)
                {
                    if (i.user.Contains(COMMON.currentUser.TenDangNhap.Trim()))
                    {
                        return true;
                    }
                }
            }
                return false;
        }

        private void textBoxLogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                errorProvider1.SetError(username_txt, "Tên đăng nhập không bao gồm khoảng trắng");
                username_txt.FocusedBorderColor = Color.Maroon;
                username_txt.BorderColor = Color.Maroon;
                isValidTextBox = false;
                return;
            }
        }

        private void matkhau_txt_TextChanged(object sender, EventArgs e)
        {
            if (matkhau_txt.Text.Contains(" "))
            {
                errorProvider1.SetError(matkhau_txt, "Mật khẩu không bao gồm khoảng trắng");
                matkhau_txt.FocusedBorderColor = Color.Maroon;
                matkhau_txt.BorderColor = Color.Maroon;
                return;
            }
            else
            {
                errorProvider1.Clear();
                username_txt.FocusedBorderColor = textBoxFocusBorderColor;
                username_txt.BorderColor = textBoxBorderColor;
            }
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            //pauseForm();
            Program._Config = new frmConfig();
            Program._Config.ShowDialog();
        }

        private void pauseForm()
        {

                Form formBackground = new Form();
                try
                {
                    using (Program._Config = new frmConfig())
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

                        Program._Config.Owner = formBackground;
                        Program._Config.Show();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool con = NetworkInterface.GetIsNetworkAvailable();
            if(con == true)
            {
                timer1.Stop();
                loadDangKi();
            }
            else
            {
                new UC_Message().showAlert("Kiểm tra kết nối mạng", UC_Message.enmType.Warning);
                timer1.Stop();
            }
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            if (username_txt.Text.Contains(" ") )
            {
                errorProvider1.SetError(username_txt, "Tên đăng nhập không bao gồm khoảng trắng");
                username_txt.FocusedBorderColor = Color.Maroon;
                username_txt.BorderColor = Color.Maroon;
                return;
            }
            else
            {
                errorProvider1.Clear();
                username_txt.FocusedBorderColor = textBoxFocusBorderColor;
                username_txt.BorderColor = textBoxBorderColor;
                matkhau_txt.Clear();
            }
        }

       
    }
}
