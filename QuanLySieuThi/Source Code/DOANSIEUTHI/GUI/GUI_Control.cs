using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.MODEL;
using DAL_BLL;
using System.Drawing;
using System.IO;
using ZXing;
using DevExpress.XtraBars.Navigation;
using System.Net;
using System.Web.Script.Serialization;
using FireSharp.Config;

namespace GUI
{
   public class GUI_Control
    {
        HangHoa_dal_bll hangHoa_Dal_Bll = new HangHoa_dal_bll();
        CTDatHang_dal_bll cTDatHang_Dal_Bll = new CTDatHang_dal_bll();
        CTPhieuNhap_dal_bll cTPhieuNhap_Dal_Bll = new CTPhieuNhap_dal_bll();
        PhongBan_dal_bll phongBan_Dal_Bll = new PhongBan_dal_bll();
        VaiTro_dal_bll vaiTro_Dal_Bll = new VaiTro_dal_bll();
        public string openExcelFile (OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "Excel Office | *.xls; *.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
                return null;
        }
        public void importOrderByExcel(string xlFileName, DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWork;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            Microsoft.Office.Interop.Excel.Range xlrange;
            int xlRow;
                if(xlFileName != string.Empty)
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWork = xlApp.Workbooks.Open(xlFileName);
                    xlSheet = xlWork.Worksheets["Sheet1"];
                    xlrange = xlSheet.UsedRange;

                for (xlRow = 2; xlRow <= xlrange.Rows.Count; xlRow++)
                {
                    dataGridView.Rows.Add(xlrange.Cells[xlRow, 1].Text, xlrange.Cells[xlRow, 2].Text, xlrange.Cells[xlRow, 3].Text, xlrange.Cells[xlRow, 4].Text, xlrange.Cells[xlRow, 5].Text
                        , xlrange.Cells[xlRow, 6].Text, xlrange.Cells[xlRow, 7].Text, xlrange.Cells[xlRow, 8].Text, xlrange.Cells[xlRow, 9].Text);
                }
                xlWork.Close();
                xlApp.Quit();
                }
        }

        public void importOrderByExcel2(string xlFileName, DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWork;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            Microsoft.Office.Interop.Excel.Range xlrange;
            try
            {
                int xlRow;
                if (xlFileName != string.Empty)
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWork = xlApp.Workbooks.Open(xlFileName);
                    xlSheet = xlWork.Worksheets["Sheet1"];
                    xlrange = xlSheet.UsedRange;


                    for (xlRow = 2; xlRow <= xlrange.Rows.Count; xlRow++)
                    {
                        dataGridView.Rows.Add(xlrange.Cells[xlRow, 1].Text, 
                            xlrange.Cells[xlRow, 2].Text, 
                            xlrange.Cells[xlRow, 3].Text, 
                            xlrange.Cells[xlRow, 4].Text, 
                            xlrange.Cells[xlRow, 5].Text
                            , xlrange.Cells[xlRow, 6].Text);
                    }
                    xlWork.Close();
                    xlApp.Quit();
                }
            }
            catch (Exception)
            {
            }
            
        }

       
        public decimal datHang_tongTienHangDat(DataGridView dataGridView)
        {
                
            decimal sum = 0;
            for(int i = 0; i< dataGridView.Rows.Count -1; i++)
            {
                if (dataGridView.Rows[i].Cells[4].Value.ToString() == null)
                {

                }
                else
                {
                    string rs = dataGridView.Rows[i].Cells[4].Value.ToString();
                    if (rs != "")
                        sum += decimal.Parse(rs);
                }
            }
            return sum;
        }

        public long RandomNumber()
        {
            Random random = new Random();
            int rs = random.Next(10, 100);
            return rs;
        }

        public string RandomString(int size, bool lowerCase = false)
        {
            Random random = new Random();
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        public string RandomCode()
        {
            var codeBuilder = new StringBuilder();

            codeBuilder.Append(RandomString(2, true));

            codeBuilder.Append(RandomNumber());

            codeBuilder.Append(RandomString(2));
            return codeBuilder.ToString();
        }

        public void capNhatSoLuongHang (DataGridView dataGridView, int i)
        {
            string tenhag = dataGridView.Rows[i].Cells[0].Value.ToString();
            DialogResult rs = MessageBox.Show("Mặt hàng " + tenhag + "đã có trong kho. Cập nhật số lượng ?", "Mặt hàng", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                int result = hangHoa_Dal_Bll.capNhatSoLuongHangHoa2(tenhag,
                           int.Parse(dataGridView.Rows[i].Cells[2].Value.ToString()),false);

                if (result == 0)
                {
                    MessageBox.Show("Cập Nhật thành công");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi");
            }
            
        }

       

        public byte[] ImageToByteArray (System.Drawing.Image image)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
        
        public byte[] ImageToByteArray (String imageUrl)
        {
            try
            {
                using (var webClient  = new WebClient())
                {
                    return webClient.DownloadData(imageUrl);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        
        public string getImage(int i)
        {
            string [] img = { "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2FK%E1%BA%B9o%20Socola%20Thanh%20350g%20Snickers.png?alt=media&token=f4cfcdf0-7387-4385-a912-de880348b418",
                                "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2FM%C3%A1y%20Gi%E1%BA%B7t%20Electrolux%2010Kg%20EWF1024BDWA.png?alt=media&token=c7f1a9bc-b049-4161-82a4-ab1aee81d3cf",
                                "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2FN%C6%B0%E1%BB%9Bc%20%C3%89p%20Cam%20Batavo.png?alt=media&token=86ced37e-5fdb-4e5f-bb5d-7e4554154cf9",
                                "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2FS%E1%BB%AFa%20chua%20u%E1%BB%91ng%20li%E1%BB%81n%201L%20Mlero.png?alt=media&token=f0d09206-7d9d-4473-a76c-7355b2c5e402",
                                "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fbanhmi.png?alt=media&token=334929fc-9ddc-4f89-8bee-609338b93ebc",
                                 "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fcheetos.png?alt=media&token=a586c5f5-efb5-484f-9521-7e3dbe3e5a60",
                                "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fredbull.png?alt=media&token=98f7c1dd-a245-4410-8740-276661e1ffe3",
            "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fchoco.png?alt=media&token=f44aa958-878e-46ae-87ce-2a8e2c98ce5d",
            "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fsuadua.png?alt=media&token=6bfc2e3e-e61f-46f7-ba39-0552738e1753",
                "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fsuadac.png?alt=media&token=a2f11cd0-9bb4-49d2-be95-f8fe44fb96be",
            "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fkitkat.png?alt=media&token=f4494a6c-de3a-4ac3-a2f6-7397d7829d90",
            "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fsuadac.png?alt=media&token=a2f11cd0-9bb4-49d2-be95-f8fe44fb96be",
            "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Flaycam.png?alt=media&token=9c7a1729-3539-4891-99f6-f000cbf0f7e1",
            "https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fmixanh.png?alt=media&token=27301c78-a31b-46fe-a8d3-409e32605e2f"
            ,"https://firebasestorage.googleapis.com/v0/b/quanlysieuthi-12102000.appspot.com/o/product_img%2Fmishin.png?alt=media&token=c7295d10-26ae-488a-9e89-4b7454d7f4a2"
            };
            return img[i];
        }
        public string pushThongBao(string _title, string _body)
        {
            string response;

            try
            {
                // From: https://console.firebase.google.com/project/x.y.z/settings/general/android:x.y.z

                // Projekt-ID: x.y.z
                // Web-API-Key: A...Y (39 chars)
                // App-ID: 1:...:android:...

                // From https://console.firebase.google.com/project/x.y.z/settings/
                // cloudmessaging/android:x,y,z
                // Server-Key: AAAA0...    ...._4

                string serverKey = "AAAAX2rXqEo:APA91bEfzhoIZ5GJ4UmJrrFCWO-2CNY46fCqnXsXSkCHy6qnjmo8z1r39JCU2_9MYEq2wCmmKLJTO8fUonW5QXX79PCh_WOFy4UIkrim39olWfQozFX97PZhBOr4pZzwVBgj130q-xHg"; // Something very long
                string senderId = "409814411338";
                string deviceId = "fBu5sOVaQ1KxmVt3KXL7-C:APA91bH2ZNTNbqKhNhlujwberOeYfB-lRcbNJ96AOrZzFId3RrXLBgP157FA9JybVicjfZ9gc6x2R6qDaZpgfMgHTEYIB37tK8yPzTPnrDCoMmIIvylLCg1rn5j7vvo2Di4WAk4felDn";

                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");

                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                var data = new
                {
                    to = deviceId,
                    notification = new
                    {
                        body = _body,
                        title = _title,
                        sound = "Enabled"
                    }
                };

                var serializer = new JavaScriptSerializer();
                var json = serializer.Serialize(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", serverKey));
                tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
                tRequest.ContentLength = byteArray.Length;

                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                response = sResponseFromServer;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return response;
        }
        public Image ByteToImage(byte[] binaryArrayImage)
        {
            if (binaryArrayImage.Length != 0)
            {
                using (MemoryStream ms = new MemoryStream(binaryArrayImage))
                {
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
            }
            else
                return null;
        }

        public void createBarcode (string ma, PictureBox pic)
        {
            if(ma != null)
            {
                BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                pic.Image = writer.Write(ma);
            }    
            
        }

        public void loadNavBarHoTro(AccordionControl nvb_hotro)
        {
            // load nhân viên quầy hàng, có đi làm và có ca làm việc tương ứng
            List<PhongBan> dspb = phongBan_Dal_Bll.loadPhongBan();
            foreach (PhongBan pb in dspb)
            {
                AccordionControlElement ace = new AccordionControlElement(ElementStyle.Group);
                ace.Text = pb.TenPhongBan.Trim();
                ace.Name = pb.MaPhongBan.Trim();
                ace.Appearance.Normal.ForeColor = System.Drawing.Color.White;
                loadItemChild(ace);
                nvb_hotro.Elements.Add(ace);
            }
        }

        private void loadItemChild(AccordionControlElement ace)
        {
            List<VaiTro> vts = vaiTro_Dal_Bll.loadVaiTro(ace.Name);
            foreach (VaiTro vt in vts)
            {
                AccordionControlElement ace1 = new AccordionControlElement(ElementStyle.Item);
                ace1.Text = vt.TenVaiTro;
                ace1.Name = vt.MaVaiTro.Trim();
                ace1.Appearance.Normal.ForeColor = System.Drawing.Color.White;
                ace.Elements.Add(ace1);
            }
        }

        public  string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
        }

    public double tinhThanhTien (int soLuong, decimal DonGia, int GiaGia)
        {
            return (double)((DonGia * soLuong) - (DonGia * (GiaGia / 100)));
        }
    }
}
