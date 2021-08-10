using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DAL_BLL;
using System.IO;
using FireSharp.Response;

namespace GUI
{
    public partial class UC_Product_EditPanel : UserControl
    {
        GUI_Control control = new GUI_Control();
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        LoaiHangHoa_dal_bll loaiHangHoa_Dal_Bll = new LoaiHangHoa_dal_bll();
        GridView gridView;
        public UC_Product_EditPanel(GridView View)
        {
            InitializeComponent();
            //init(gridView)/*;*/
            this.gridView = View;
            init();
        }

        private void saveImage (string mahanghoa)
        {
            //convert
            if(prd_img.Image != null)
            {
                byte[] file_byte = control.ImageToByteArray(prd_img.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                new UC_Message().showAlert(hangHoa_Dal_Bll.UpdateImage(file_binary, mahanghoa), UC_Message.enmType.Success);
            }
        }

       
        private void retriveImage ()
        {
            string tenhang = gridView.GetFocusedRowCellValue("TenHangHoa").ToString();
            HangHoa hangHoa = hangHoa_Dal_Bll.loadHangHoaTheoTen(tenhang);
            if(hangHoa != null && hangHoa.Anh != null){
                prd_img.Image = control.ByteToImage( hangHoa.Anh.ToArray());
            }
        }

        public void init ()
        {
            txt_tenhang.DataBindings.Add(new Binding("Text", gridView.DataSource,
                    "TenHangHoa", true, DataSourceUpdateMode.OnPropertyChanged));
            txt_dvt.DataBindings.Add(new Binding("Text", gridView.DataSource,
                "DonVi", true, DataSourceUpdateMode.OnPropertyChanged));
            txt_dt.DataBindings.Add(new Binding("Text", gridView.DataSource,
                "TonKho", true, DataSourceUpdateMode.OnPropertyChanged));
            txt_giaban.DataBindings.Add(new Binding("Text", gridView.DataSource,
                "DonGia", true, DataSourceUpdateMode.OnPropertyChanged));
            cbo_loai.DataBindings.Add(new Binding("Text", gridView.DataSource,
                "LoaiHangHoa.TenLoaiHang",true, DataSourceUpdateMode.OnPropertyChanged));
            cbo_vitri.DataBindings.Add(new Binding("Text", gridView.DataSource,
                "ViTri",true, DataSourceUpdateMode.OnPropertyChanged));

            for (int i = 1; i< 16; i++)
            {
                cbo_vitri.Items.Add("Quầy " + i);
            }

            cbo_loai.DataSource = loaiHangHoa_Dal_Bll.loadLoaiHangHoa();
            cbo_loai.DisplayMember = "TenLoaiHang";
            cbo_loai.ValueMember = "MaLoaiHang";
            retriveImage();
        }

        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            HangHoa hh = gridView.GetFocusedRow() as HangHoa;
            if(hh.Active == false)
            {
                new UC_Message().showAlert("Mặt hàng đã vô hiệu hóa", UC_Message.enmType.Info);
                return;
            }    
            if (hh != null)
            {
                saveImage(hh.MaHangHoa);
                hh.TenHangHoa = txt_tenhang.Text.Trim();
                string mnh = cbo_loai.SelectedValue.ToString();
                hh.MaNhom = mnh;
                hh.DonVi = txt_dvt.Text.Trim();
                hh.TonKho = (int?)txt_dt.Value;
                hh.ViTri = cbo_vitri.Text.Trim();

                string rs = hangHoa_Dal_Bll.UpdateHangHoa(hh);
                if (rs.Contains("OK"))
                {
                    FirebaseResponse rep = await FireBaseConnect.Client.UpdateTaskAsync("Product/" + hh.MaHangHoa.Trim() + "/" + "prd_soton", hh.TonKho.ToString());

                    new UC_Message().showAlert("Đã cập nhật ", UC_Message.enmType.Success);
                }
                else
                    new UC_Message().showAlert(rs, UC_Message.enmType.Error);
            }

        }

        
    }
}
