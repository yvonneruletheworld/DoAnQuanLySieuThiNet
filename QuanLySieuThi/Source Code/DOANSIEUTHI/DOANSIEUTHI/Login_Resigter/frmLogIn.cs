using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANSIEUTHI
{
    public partial class frmLogIn : Form
    {
        public bool isValidTextBox = true;
        private Color textBoxBorderColor, textBoxFocusBorderColor ;
        private int isNumbericTextBox;
        public frmLogIn()
        {
            InitializeComponent();
            textBoxBorderColor = username_txt.BorderColor;
            textBoxFocusBorderColor = username_txt.FocusedBorderColor;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show(this, "Những tiến trình đang hoạt động. Bạn thật sự muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (Program._Main == null || Program._Main.IsDisposed)
            {
                Program._Main = new Login_Resigter.frmMain();
            }
            this.Visible = false;
            Program._Main.Show();
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
            }
        }

       
    }
}
