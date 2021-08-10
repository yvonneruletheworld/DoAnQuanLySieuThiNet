namespace GUI
{
    partial class UC_Product_Count_Item
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
            this.pic_prd = new DevExpress.XtraEditors.PictureEdit();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_prd
            // 
            this.pic_prd.Location = new System.Drawing.Point(3, 3);
            this.pic_prd.Name = "pic_prd";
            this.pic_prd.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_prd.Size = new System.Drawing.Size(169, 88);
            this.pic_prd.TabIndex = 0;
            this.pic_prd.MouseEnter += new System.EventHandler(this.pic_prd_MouseEnter);
            this.pic_prd.MouseLeave += new System.EventHandler(this.pic_prd_MouseLeave);
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel16.Location = new System.Drawing.Point(190, 4);
            this.gunaLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(546, 87);
            this.gunaLabel16.TabIndex = 2;
            this.gunaLabel16.Text = "Tên Mặt Hàng";
            this.gunaLabel16.MouseEnter += new System.EventHandler(this.pic_prd_MouseEnter);
            this.gunaLabel16.MouseLeave += new System.EventHandler(this.pic_prd_MouseLeave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel1.Location = new System.Drawing.Point(768, 4);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(75, 87);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "0";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.MouseEnter += new System.EventHandler(this.pic_prd_MouseEnter);
            this.gunaLabel1.MouseLeave += new System.EventHandler(this.pic_prd_MouseLeave);
            // 
            // UC_Product_Count_Item
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel16);
            this.Controls.Add(this.pic_prd);
            this.Name = "UC_Product_Count_Item";
            this.Size = new System.Drawing.Size(843, 94);
            this.MouseEnter += new System.EventHandler(this.pic_prd_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.pic_prd_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic_prd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pic_prd;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
