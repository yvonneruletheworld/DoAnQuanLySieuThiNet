namespace GUI
{
    partial class UC_Product_Count
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
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pause = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_edit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.AutoSize = true;
            this.gunaLabel16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel16.Location = new System.Drawing.Point(296, 37);
            this.gunaLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(363, 30);
            this.gunaLabel16.TabIndex = 1;
            this.gunaLabel16.Text = "DANH SÁCH MẶT HÀNG SẮP HÊT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.gunaLabel16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 192);
            this.panel1.TabIndex = 2;
            // 
            // btn_pause
            // 
            this.btn_pause.AnimationHoverSpeed = 0.07F;
            this.btn_pause.AnimationSpeed = 0.03F;
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.BaseColor = System.Drawing.Color.Silver;
            this.btn_pause.BorderColor = System.Drawing.Color.Black;
            this.btn_pause.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_pause.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_pause.CheckedForeColor = System.Drawing.Color.White;
            this.btn_pause.CheckedImage = null;
            this.btn_pause.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_pause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_pause.FocusedColor = System.Drawing.Color.Empty;
            this.btn_pause.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_pause.ForeColor = System.Drawing.Color.Black;
            this.btn_pause.Image = global::GUI.Properties.Resources.icons8_delete_trash_32;
            this.btn_pause.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_pause.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_pause.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_pause.Location = new System.Drawing.Point(871, 8);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_pause.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_pause.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_pause.OnHoverImage = null;
            this.btn_pause.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_pause.OnPressedColor = System.Drawing.Color.Black;
            this.btn_pause.Radius = 8;
            this.btn_pause.Size = new System.Drawing.Size(84, 74);
            this.btn_pause.TabIndex = 19;
            this.btn_pause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AnimationHoverSpeed = 0.07F;
            this.btn_edit.AnimationSpeed = 0.03F;
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.btn_edit.BorderColor = System.Drawing.Color.Black;
            this.btn_edit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_edit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_edit.CheckedForeColor = System.Drawing.Color.White;
            this.btn_edit.CheckedImage = global::GUI.Properties.Resources.icons8_plus_16;
            this.btn_edit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = global::GUI.Properties.Resources.icons8_edit_32;
            this.btn_edit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_edit.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_edit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_edit.Location = new System.Drawing.Point(776, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_edit.OnHoverImage = null;
            this.btn_edit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_edit.Radius = 8;
            this.btn_edit.Size = new System.Drawing.Size(84, 74);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(961, 316);
            this.panel2.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel1.Location = new System.Drawing.Point(44, 127);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(117, 30);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Mặt Hàng";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel2.Location = new System.Drawing.Point(841, 127);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(83, 30);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "Số Tồn";
            // 
            // UC_Product_Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UC_Product_Count";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_pause;
        private Guna.UI.WinForms.GunaAdvenceButton btn_edit;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
