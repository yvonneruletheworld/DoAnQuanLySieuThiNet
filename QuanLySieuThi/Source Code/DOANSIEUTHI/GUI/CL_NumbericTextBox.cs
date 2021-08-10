using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
   public class CL_NumbericTextBox : GunaTextBox
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CL_NumbericTextBox
            // 
            this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextChanged += new System.EventHandler(this.CL_NumbericTextBox_TextChanged);
            this.ResumeLayout(false);

        }

        private void CL_NumbericTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.Text.Trim().ToString();
            if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[a-z][A-Z]"))
            {
                System.Windows.Forms.MessageBox.Show("ok");
            }
        }
    }
}
