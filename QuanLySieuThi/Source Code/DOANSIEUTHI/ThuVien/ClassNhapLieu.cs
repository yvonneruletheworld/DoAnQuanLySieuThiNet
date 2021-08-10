using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public class ClassNhapLieu
    {
        public int numbericTextBox(TextBox textBox)
        {
            string txt = textBox.Text.Trim().ToString();
            if (txt == null)
            {
                return 1; // textBox Rong
            }
            // convert string textBox text sang mang char 
            // kiem tra tung phan tu xem co phai la so khong
            char[] keyChar = textBox.Text.ToCharArray();
            foreach (char c in keyChar)
            {
                if (!char.IsDigit(c))
                {
                    return 2;
                }
            }
            return 0;
        }

        // Kiem tra textbox co chua ky tu dac biet
        public int containSpecialCharacterTextBox(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                return 1;
            }
            string[] characters = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+", "=", "{", "}", "[", "]", "|", "\\", ".", ",", "<", ">", "?", "/" };
            foreach (string s in characters)
            {
                if (textBox.Text.Trim().Contains(s))
                {
                    return 2;
                }

            }
            return 0;
        }

        //public int passWordValidation (TextBox textBox)
        //{
        //    string value = textBox.Text.Trim().ToString();
        //    if (string.IsNullOrEmpty(value))
        //        return 1;
        //    if(value.Length >= 8 || value.Length <= 26)
        //    {
        //        if(!value.Contains(" "))
        //        return 0;
        //    }
        //}
    }
}
