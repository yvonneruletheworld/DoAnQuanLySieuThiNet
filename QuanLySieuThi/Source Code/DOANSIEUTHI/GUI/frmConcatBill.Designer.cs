namespace GUI
{
    partial class frmConcatBill
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.txt_hoten = new DevExpress.XtraEditors.TextEdit();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txt_tdn = new DevExpress.XtraEditors.TextEdit();
            this.txt_mk = new DevExpress.XtraEditors.TextEdit();
            this.txt_sdt = new DevExpress.XtraEditors.TextEdit();
            this.lbl_gt = new System.Windows.Forms.Label();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.de_ngsinh = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_calam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sav = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_anh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.gunaGoogleSwitch1 = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaGoogleSwitch2 = new Guna.UI.WinForms.GunaGoogleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tdn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngsinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngsinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // txt_hoten
            // 
            this.txt_hoten.EditValue = "Họ và Tên";
            this.txt_hoten.Location = new System.Drawing.Point(39, 319);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_hoten.Properties.Appearance.Options.UseBackColor = true;
            this.txt_hoten.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_hoten.Size = new System.Drawing.Size(501, 36);
            this.txt_hoten.TabIndex = 0;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(134, 33);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(176, 176);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.MouseEnter += new System.EventHandler(this.gunaCirclePictureBox1_MouseEnter);
            this.gunaCirclePictureBox1.MouseLeave += new System.EventHandler(this.gunaCirclePictureBox1_MouseLeave);
            // 
            // txt_tdn
            // 
            this.txt_tdn.EditValue = "Tên Đăng Nhập";
            this.txt_tdn.Enabled = false;
            this.txt_tdn.Location = new System.Drawing.Point(39, 384);
            this.txt_tdn.Name = "txt_tdn";
            this.txt_tdn.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_tdn.Properties.Appearance.Options.UseBackColor = true;
            this.txt_tdn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_tdn.Size = new System.Drawing.Size(229, 36);
            this.txt_tdn.TabIndex = 2;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Contains;
            conditionValidationRule5.ErrorText = "Tên đăng nhập không hợp lệ";
            conditionValidationRule5.Value1 = '@';
            conditionValidationRule5.Values.Add("!");
            conditionValidationRule5.Values.Add("@");
            conditionValidationRule5.Values.Add("#");
            conditionValidationRule5.Values.Add("$");
            conditionValidationRule5.Values.Add("%");
            conditionValidationRule5.Values.Add("^");
            conditionValidationRule5.Values.Add("&");
            conditionValidationRule5.Values.Add("*");
            conditionValidationRule5.Values.Add("(");
            conditionValidationRule5.Values.Add(")");
            conditionValidationRule5.Values.Add("|");
            conditionValidationRule5.Values.Add("}");
            conditionValidationRule5.Values.Add("{");
            conditionValidationRule5.Values.Add("[");
            conditionValidationRule5.Values.Add("?");
            conditionValidationRule5.Values.Add("/");
            conditionValidationRule5.Values.Add(">");
            conditionValidationRule5.Values.Add("<");
            this.dxValidationProvider1.SetValidationRule(this.txt_tdn, conditionValidationRule5);
            // 
            // txt_mk
            // 
            this.txt_mk.EditValue = "Tên Đăng Nhập";
            this.txt_mk.Location = new System.Drawing.Point(305, 384);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_mk.Properties.Appearance.Options.UseBackColor = true;
            this.txt_mk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_mk.Size = new System.Drawing.Size(235, 36);
            this.txt_mk.TabIndex = 3;
            // 
            // txt_sdt
            // 
            this.txt_sdt.EditValue = "Số Điện Thoại";
            this.txt_sdt.Location = new System.Drawing.Point(39, 452);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_sdt.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sdt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_sdt.Size = new System.Drawing.Size(296, 36);
            this.txt_sdt.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Equals;
            conditionValidationRule1.ErrorText = "Số điện thoại không hợp lệ";
            this.dxValidationProvider1.SetValidationRule(this.txt_sdt, conditionValidationRule1);
            // 
            // lbl_gt
            // 
            this.lbl_gt.AutoSize = true;
            this.lbl_gt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gt.Location = new System.Drawing.Point(468, 450);
            this.lbl_gt.Name = "lbl_gt";
            this.lbl_gt.Size = new System.Drawing.Size(41, 28);
            this.lbl_gt.TabIndex = 6;
            this.lbl_gt.Text = "Nữ";
            // 
            // txt_Email
            // 
            this.txt_Email.EditValue = "Email";
            this.txt_Email.Location = new System.Drawing.Point(39, 524);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_Email.Properties.Appearance.Options.UseBackColor = true;
            this.txt_Email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_Email.Size = new System.Drawing.Size(501, 36);
            this.txt_Email.TabIndex = 7;
            // 
            // txt_diachi
            // 
            this.txt_diachi.EditValue = "Dịa Chỉ";
            this.txt_diachi.Location = new System.Drawing.Point(39, 598);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_diachi.Properties.Appearance.Options.UseBackColor = true;
            this.txt_diachi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_diachi.Size = new System.Drawing.Size(501, 36);
            this.txt_diachi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày Sinh";
            // 
            // de_ngsinh
            // 
            this.de_ngsinh.EditValue = null;
            this.de_ngsinh.Location = new System.Drawing.Point(239, 674);
            this.de_ngsinh.Name = "de_ngsinh";
            this.de_ngsinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.de_ngsinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngsinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngsinh.Size = new System.Drawing.Size(301, 36);
            this.de_ngsinh.TabIndex = 11;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.LessOrEqual;
            conditionValidationRule2.ErrorText = "Nhân viên phải trên 18 tuổi";
            conditionValidationRule2.Value1 = new System.DateTime(2003, 1, 1, 16, 51, 19, 0);
            this.dxValidationProvider1.SetValidationRule(this.de_ngsinh, conditionValidationRule2);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(239, 746);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(301, 36);
            this.dateEdit1.TabIndex = 13;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule3.ErrorText = "Ngày Vào Làm Phải Sau 01/01/2020";
            conditionValidationRule3.Value1 = new System.DateTime(2020, 1, 1, 16, 42, 36, 0);
            this.dxValidationProvider1.SetValidationRule(this.dateEdit1, conditionValidationRule3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 748);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vào Làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 820);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ca làm";
            // 
            // lbl_calam
            // 
            this.lbl_calam.AutoSize = true;
            this.lbl_calam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calam.Location = new System.Drawing.Point(240, 820);
            this.lbl_calam.Name = "lbl_calam";
            this.lbl_calam.Size = new System.Drawing.Size(91, 28);
            this.lbl_calam.TabIndex = 15;
            this.lbl_calam.Text = "Vào Làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 889);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tình Trạng";
            // 
            // btn_sav
            // 
            this.btn_sav.AnimationHoverSpeed = 0.07F;
            this.btn_sav.AnimationSpeed = 0.03F;
            this.btn_sav.BackColor = System.Drawing.Color.Transparent;
            this.btn_sav.BaseColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sav.BorderColor = System.Drawing.Color.Black;
            this.btn_sav.BorderSize = 2;
            this.btn_sav.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_sav.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_sav.CheckedForeColor = System.Drawing.Color.White;
            this.btn_sav.CheckedImage = null;
            this.btn_sav.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_sav.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sav.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sav.ForeColor = System.Drawing.Color.Black;
            this.btn_sav.Image = null;
            this.btn_sav.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_sav.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_sav.Location = new System.Drawing.Point(375, 944);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_sav.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sav.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_sav.OnHoverImage = null;
            this.btn_sav.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_sav.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sav.Radius = 5;
            this.btn_sav.Size = new System.Drawing.Size(165, 56);
            this.btn_sav.TabIndex = 18;
            this.btn_sav.Text = "Lưu";
            this.btn_sav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sav.Click += new System.EventHandler(this.btn_anh_Click);
            // 
            // btn_anh
            // 
            this.btn_anh.AnimationHoverSpeed = 0.07F;
            this.btn_anh.AnimationSpeed = 0.03F;
            this.btn_anh.BackColor = System.Drawing.Color.Transparent;
            this.btn_anh.BaseColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_anh.BorderColor = System.Drawing.Color.Black;
            this.btn_anh.BorderSize = 2;
            this.btn_anh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_anh.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_anh.CheckedForeColor = System.Drawing.Color.White;
            this.btn_anh.CheckedImage = null;
            this.btn_anh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_anh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_anh.FocusedColor = System.Drawing.Color.Empty;
            this.btn_anh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_anh.ForeColor = System.Drawing.Color.Black;
            this.btn_anh.Image = global::GUI.Properties.Resources.icons8_edit_32;
            this.btn_anh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_anh.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_anh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_anh.Location = new System.Drawing.Point(366, 89);
            this.btn_anh.Name = "btn_anh";
            this.btn_anh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_anh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_anh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_anh.OnHoverImage = null;
            this.btn_anh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_anh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_anh.Radius = 5;
            this.btn_anh.Size = new System.Drawing.Size(108, 67);
            this.btn_anh.TabIndex = 19;
            this.btn_anh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_anh.Visible = false;
            this.btn_anh.Click += new System.EventHandler(this.btn_anh_Click);
            // 
            // gunaGoogleSwitch1
            // 
            this.gunaGoogleSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGoogleSwitch1.CheckedOffColor = System.Drawing.Color.Black;
            this.gunaGoogleSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGoogleSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch1.Location = new System.Drawing.Point(375, 454);
            this.gunaGoogleSwitch1.Name = "gunaGoogleSwitch1";
            this.gunaGoogleSwitch1.Size = new System.Drawing.Size(86, 44);
            this.gunaGoogleSwitch1.TabIndex = 20;
            this.gunaGoogleSwitch1.CheckedChanged += new System.EventHandler(this.gunaGoogleSwitch1_CheckedChanged);
            // 
            // gunaGoogleSwitch2
            // 
            this.gunaGoogleSwitch2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGoogleSwitch2.CheckedOffColor = System.Drawing.Color.Black;
            this.gunaGoogleSwitch2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGoogleSwitch2.Enabled = false;
            this.gunaGoogleSwitch2.FillColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch2.Location = new System.Drawing.Point(50, 889);
            this.gunaGoogleSwitch2.Name = "gunaGoogleSwitch2";
            this.gunaGoogleSwitch2.Size = new System.Drawing.Size(80, 43);
            this.gunaGoogleSwitch2.TabIndex = 21;
            // 
            // frmConcatBill
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 814);
            this.Controls.Add(this.gunaGoogleSwitch2);
            this.Controls.Add(this.gunaGoogleSwitch1);
            this.Controls.Add(this.btn_anh);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_calam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.de_ngsinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_gt);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tdn);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_diachi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConcatBill";
            this.Text = "Thông tin Cá Nhân";
            ((System.ComponentModel.ISupportInitialize)(this.txt_hoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tdn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngsinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngsinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.TextEdit txt_hoten;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private DevExpress.XtraEditors.TextEdit txt_tdn;
        private DevExpress.XtraEditors.TextEdit txt_mk;
        private DevExpress.XtraEditors.TextEdit txt_sdt;
        private System.Windows.Forms.Label lbl_gt;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit de_ngsinh;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_calam;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton btn_sav;
        private Guna.UI.WinForms.GunaAdvenceButton btn_anh;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private Guna.UI.WinForms.GunaGoogleSwitch gunaGoogleSwitch1;
        private Guna.UI.WinForms.GunaGoogleSwitch gunaGoogleSwitch2;
    }
}