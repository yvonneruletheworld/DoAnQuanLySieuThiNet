namespace GUI
{
    partial class UC_PaymentFlyout
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_tenhang = new Guna.UI.WinForms.GunaTextBox();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rb_format = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpg_tt = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btn_bank = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.BackColor = System.Drawing.Color.Transparent;
            this.txt_tenhang.BaseColor = System.Drawing.Color.White;
            this.txt_tenhang.BorderColor = System.Drawing.Color.Silver;
            this.txt_tenhang.BorderSize = 1;
            this.txt_tenhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenhang.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tenhang.FocusedBorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_tenhang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tenhang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_tenhang.ForeColor = System.Drawing.Color.Gray;
            this.txt_tenhang.Location = new System.Drawing.Point(23, 280);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.PasswordChar = '\0';
            this.txt_tenhang.Radius = 5;
            this.txt_tenhang.SelectedText = "";
            this.txt_tenhang.Size = new System.Drawing.Size(507, 40);
            this.txt_tenhang.TabIndex = 34;
            this.txt_tenhang.TextChanged += new System.EventHandler(this.txt_tenhang_TextChanged);
            this.txt_tenhang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenhang_KeyPress);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_bank,
            this.barHeaderItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rb_format});
            this.ribbonControl1.Size = new System.Drawing.Size(1490, 256);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // rb_format
            // 
            this.rb_format.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpg_tt});
            this.rb_format.Name = "rb_format";
            this.rb_format.Text = "Thông Tin Thanh Toán";
            // 
            // rbpg_tt
            // 
            this.rbpg_tt.ItemLinks.Add(this.btn_bank);
            this.rbpg_tt.ItemLinks.Add(this.barHeaderItem1);
            this.rbpg_tt.Name = "rbpg_tt";
            this.rbpg_tt.Text = "Ngân Hàng";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 782);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1490, 36);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // btn_bank
            // 
            this.btn_bank.Caption = "Tên Ngân Hàng";
            this.btn_bank.Id = 1;
            this.btn_bank.ImageOptions.Image = global::GUI.Properties.Resources.icons8_credit_control_48;
            this.btn_bank.Name = "btn_bank";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Id = 2;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // UC_PaymentFlyout
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 818);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "UC_PaymentFlyout";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Thẻ Tín Dụng";
            this.Enter += new System.EventHandler(this.UC_PaymentFlyout_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txt_tenhang;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rb_format;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpg_tt;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_bank;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
    }
}
