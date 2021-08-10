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
using AForge.Video.DirectShow;
using ZXing;
using GUI.MODEL;
namespace GUI
{
    public partial class frmScan : DevExpress.XtraEditors.XtraForm
    {

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;
        private bool isScan = false;
        public frmScan()
        {
            InitializeComponent();
        }

        private void frmScan_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboDevice.Items.Add(device.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                gunaTextBox1.Invoke(new MethodInvoker(delegate ()
                {
                    gunaTextBox1.Text = result.ToString();
                }));
            }
            gunaPictureBox1.Image = bitmap;
            COMMON.voucherCode = gunaTextBox1.Text.Trim();
        }

        private void frmScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
            COMMON.voucherCode = gunaTextBox1.Text.Trim();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
            isScan = true;
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (isScan == true)
            //{
            //    if (gunaTextBox1.Text.Trim() != null)
            //        this.Dispose();
            //}
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Enabled = true;
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg"})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    gunaPictureBox1.Image = Image.FromFile(ofd.FileName);
                    BarcodeReader reader = new BarcodeReader();
                    var rs = reader.Decode((Bitmap)gunaPictureBox1.Image);
                    if (rs != null)
                        gunaTextBox1.Text = rs.ToString();
                }
                
            }
        }
    }
}