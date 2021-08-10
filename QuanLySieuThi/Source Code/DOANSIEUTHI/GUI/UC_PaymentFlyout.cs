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
using GUI.MODEL;

namespace GUI
{
    public partial class UC_PaymentFlyout : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Card_Validation validation = new Card_Validation();
        DataTable tb;
        bool isValid = false;
        public UC_PaymentFlyout()
        {
            InitializeComponent();
            tb = validation.getDataFormHtml("https://luatminhkhue.vn/cong-van--11420-nhnn-tt-thong-bao-danh-sach-ma-to-chuc-phat-hanh-the.aspx");
        }

        public void mergeMenu(frmCashier_Main parent)
        {
            parent.Ribbon.MergeRibbon(this.ribbonControl1);
        }
        private void txt_tenhang_TextChanged(object sender, EventArgs e)
        {
            if(txt_tenhang.Text.Length < 16)
            {
                isValid = false;
            }
            else
            {
                String type = validation.cardCheck(txt_tenhang.Text.Trim());


                if (type == Card_Validation.CardType.VISA.ToString())
                {
                    btn_bank.ImageOptions.Image = global::GUI.Properties.Resources.icons8_visa_48;
                    barHeaderItem1.Caption = type;
                    isValid = true;
                }
                else if (type == Card_Validation.CardType.MasterCard.ToString())
                {
                    btn_bank.ImageOptions.Image = global::GUI.Properties.Resources.icons8_mastercard_credit_card_48;
                    barHeaderItem1.Caption = type;
                    isValid = true;

                }
                if (type == Card_Validation.CardType.National.ToString())
                {
                    btn_bank.ImageOptions.Image = global::GUI.Properties.Resources.icons8_credit_control_48;
                    barHeaderItem1.Caption = type;
                    isValid = true;

                }
                else
                {
                    btn_bank.ImageOptions.Image = global::GUI.Properties.Resources.icons8_close_32;
                    barHeaderItem1.Caption = type;
                    isValid = true;
                }


                foreach (DataRow row in tb.Rows)
                {
                    if (txt_tenhang.Text.Trim().Contains(row.ItemArray.ElementAt(2).ToString()))
                    {
                        btn_bank.Caption = row.ItemArray.ElementAt(1).ToString();
                        //gunaLabel1.Text = row.ItemArray.ElementAt(1).ToString();
                        isValid = true;
                    }
                }
            }
            
        }

        private void txt_tenhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
                new UC_Message().showAlert("Ký tự không hợp lệ", UC_Message.enmType.Warning);
            }
            else if(e.KeyChar == (char)13)
            {
                if (isValid == true)
                {
                    if (COMMON.bank == null)
                    {
                        COMMON.bank = btn_bank.Caption;
                        this.Close();
                    }
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void UC_PaymentFlyout_Enter(object sender, EventArgs e)
        {
            if (isValid == true)
            {
                if (COMMON.bank == null)
                {
                    COMMON.bank = btn_bank.Caption;
                    this.Close();
                }
            }
            else
                new UC_Message().showAlert("BIN không hợp lệ ", UC_Message.enmType.Error);
        }
    }
}
