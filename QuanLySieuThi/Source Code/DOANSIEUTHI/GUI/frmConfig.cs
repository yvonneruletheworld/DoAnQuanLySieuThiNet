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
using System.Data.Sql;
using System.Data.SqlClient;
using DevExpress.XtraSplashScreen;

namespace GUI
{
    public partial class frmConfig : DevExpress.XtraEditors.XtraForm
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void cboSeverName_DropDown(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(this, typeof(frmWaiting), true, true, false);
            cboSeverName.DataSource = loadDataSource();
            cboSeverName.DisplayMember = "ServerName";
            cboSeverName.ValueMember = "ServerName";
            //cboSeverName.SelectedIndexChanged += CboSeverName_SelectedIndexChanged;
            //SplashScreenManager.CloseForm();
        }

        private void CboSeverName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSeverName.Text == "")
            {
                txtUser.Enabled = false;
                txtPass.Enabled = false;
            }
            else
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
        }

        private DataTable loadDataSource()
        {
            return  SqlDataSourceEnumerator.Instance.GetDataSources();
        }

        private void cboData_DropDown(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaiting), true, true, false);
            cboData.DataSource = getDatabaseName();
            cboData.ValueMember = "Name";
            cboData.DisplayMember = "Name";
            SplashScreenManager.CloseForm();
            cboData.SelectedIndexChanged += CboData_SelectedIndexChanged;
        }

        private void CboData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboData.Text != "")
            {
                btnOk.Enabled = true;
                btnOk.Click += BtnOk_Click;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.CNN = "Data Source=" + cboSeverName.Text.Trim()
                + ";Initial Catalog=" + cboData.Text.Trim()
                + ";User ID=" + txtUser.Text.Trim()
                + ";Password=" + txtPass.Text.Trim() + "";
                Properties.Settings.Default.Save();
                new UC_Message().showAlert("Đã lưu", UC_Message.enmType.Success);
            }
            catch (Exception)
            {
                new UC_Message().showAlert("Lỗi", UC_Message.enmType.Error);
            }
        }



        private DataTable getDatabaseName()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
                "Data Source=" + cboSeverName.Text.Trim() 
                + ";Initial catalog=master;User ID=" + txtUser.Text.Trim()
                + ";pwd=" + txtPass.Text.Trim() + "");
            da.Fill(dt);
            return dt;
        }

        private void txt_Change(object sender, EventArgs e)
        {
            if(txtPass.Text == "" && txtUser.Text == "")
            {
                cboData.Enabled = false;
            }
            else
            {
                cboData.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
            cboData.Text = "";
            cboSeverName.Text = "";
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            if(Program._Config != null)
            {
                this.Close();
                Program._Config = null;
            }
        }
    }
}
