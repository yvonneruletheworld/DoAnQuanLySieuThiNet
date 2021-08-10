namespace GUI
{
    partial class UC_PhanQuyen
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
            this.components = new System.ComponentModel.Container();
            this.phanQuyenVaiTroChucNangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_tencn = new Guna.UI.WinForms.GunaTextBox();
            this.btnCan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_suachucnah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_xoachucnang = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_themchucnang = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tseDen = new DevExpress.XtraEditors.TimeSpanEdit();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tseTu = new DevExpress.XtraEditors.TimeSpanEdit();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.ccb_ChucNang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btn_apdung = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbl_hoadon = new Guna.UI.WinForms.GunaLabel();
            this.clbNCN = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.gcPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhanQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVaiTro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVaiTro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianTruyCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChucNang = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.chucNangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolMaChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenVaiTroChucNangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tseDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseTu.Properties)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccb_ChucNang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbNCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucNangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // phanQuyenVaiTroChucNangBindingSource
            // 
            this.phanQuyenVaiTroChucNangBindingSource.DataSource = typeof(DAL_BLL.PhanQuyen_VaiTro_ChucNang);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.SteelBlue;
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.Group.Normal.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.accordionControl1.Appearance.Item.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Options.UseForeColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(213, 912);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txt_tencn);
            this.groupControl2.Controls.Add(this.btnCan);
            this.groupControl2.Controls.Add(this.btn_suachucnah);
            this.groupControl2.Controls.Add(this.btn_xoachucnang);
            this.groupControl2.Controls.Add(this.btn_themchucnang);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Controls.Add(this.gunaShadowPanel1);
            this.groupControl2.Controls.Add(this.btn_apdung);
            this.groupControl2.Controls.Add(this.lbl_hoadon);
            this.groupControl2.Controls.Add(this.clbNCN);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(213, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(5);
            this.groupControl2.Size = new System.Drawing.Size(2042, 307);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Nhóm Chức Năng";
            // 
            // txt_tencn
            // 
            this.txt_tencn.BackColor = System.Drawing.Color.Transparent;
            this.txt_tencn.BaseColor = System.Drawing.Color.White;
            this.txt_tencn.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_tencn.BorderSize = 1;
            this.txt_tencn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tencn.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tencn.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tencn.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tencn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tencn.Location = new System.Drawing.Point(522, 160);
            this.txt_tencn.Name = "txt_tencn";
            this.txt_tencn.PasswordChar = '\0';
            this.txt_tencn.Radius = 4;
            this.txt_tencn.SelectedText = "";
            this.txt_tencn.Size = new System.Drawing.Size(552, 50);
            this.txt_tencn.TabIndex = 43;
            this.txt_tencn.Text = "Thêm Chức Năng";
            // 
            // btnCan
            // 
            this.btnCan.AnimationHoverSpeed = 0.07F;
            this.btnCan.AnimationSpeed = 0.03F;
            this.btnCan.BackColor = System.Drawing.Color.Transparent;
            this.btnCan.BaseColor = System.Drawing.Color.Gray;
            this.btnCan.BorderColor = System.Drawing.Color.Gray;
            this.btnCan.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCan.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCan.CheckedForeColor = System.Drawing.Color.White;
            this.btnCan.CheckedImage = null;
            this.btnCan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCan.Enabled = false;
            this.btnCan.FocusedColor = System.Drawing.Color.Empty;
            this.btnCan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCan.ForeColor = System.Drawing.Color.White;
            this.btnCan.Image = null;
            this.btnCan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCan.ImageSize = new System.Drawing.Size(10, 10);
            this.btnCan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCan.Location = new System.Drawing.Point(1407, 165);
            this.btnCan.Name = "btnCan";
            this.btnCan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCan.OnHoverImage = null;
            this.btnCan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCan.OnPressedColor = System.Drawing.Color.Black;
            this.btnCan.Radius = 8;
            this.btnCan.Size = new System.Drawing.Size(65, 57);
            this.btnCan.TabIndex = 42;
            this.btnCan.Text = "X";
            this.btnCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_suachucnah
            // 
            this.btn_suachucnah.AnimationHoverSpeed = 0.07F;
            this.btn_suachucnah.AnimationSpeed = 0.03F;
            this.btn_suachucnah.BackColor = System.Drawing.Color.Transparent;
            this.btn_suachucnah.BaseColor = System.Drawing.Color.SteelBlue;
            this.btn_suachucnah.BorderColor = System.Drawing.Color.Black;
            this.btn_suachucnah.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_suachucnah.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_suachucnah.CheckedForeColor = System.Drawing.Color.White;
            this.btn_suachucnah.CheckedImage = global::GUI.Properties.Resources.icons8_plus_16;
            this.btn_suachucnah.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_suachucnah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_suachucnah.FocusedColor = System.Drawing.Color.Empty;
            this.btn_suachucnah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_suachucnah.ForeColor = System.Drawing.Color.White;
            this.btn_suachucnah.Image = global::GUI.Properties.Resources.icons8_edit_32;
            this.btn_suachucnah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_suachucnah.ImageSize = new System.Drawing.Size(10, 10);
            this.btn_suachucnah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_suachucnah.Location = new System.Drawing.Point(1306, 165);
            this.btn_suachucnah.Name = "btn_suachucnah";
            this.btn_suachucnah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_suachucnah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_suachucnah.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_suachucnah.OnHoverImage = null;
            this.btn_suachucnah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_suachucnah.OnPressedColor = System.Drawing.Color.Black;
            this.btn_suachucnah.Radius = 8;
            this.btn_suachucnah.Size = new System.Drawing.Size(65, 57);
            this.btn_suachucnah.TabIndex = 41;
            this.btn_suachucnah.Text = " ";
            this.btn_suachucnah.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_xoachucnang
            // 
            this.btn_xoachucnang.AnimationHoverSpeed = 0.07F;
            this.btn_xoachucnang.AnimationSpeed = 0.03F;
            this.btn_xoachucnang.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoachucnang.BaseColor = System.Drawing.Color.SteelBlue;
            this.btn_xoachucnang.BorderColor = System.Drawing.Color.Black;
            this.btn_xoachucnang.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_xoachucnang.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_xoachucnang.CheckedForeColor = System.Drawing.Color.White;
            this.btn_xoachucnang.CheckedImage = global::GUI.Properties.Resources.icons8_delete_trash_32;
            this.btn_xoachucnang.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_xoachucnang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoachucnang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoachucnang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoachucnang.ForeColor = System.Drawing.Color.White;
            this.btn_xoachucnang.Image = global::GUI.Properties.Resources.icons8_delete_trash_32;
            this.btn_xoachucnang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoachucnang.ImageSize = new System.Drawing.Size(10, 10);
            this.btn_xoachucnang.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_xoachucnang.Location = new System.Drawing.Point(1202, 165);
            this.btn_xoachucnang.Name = "btn_xoachucnang";
            this.btn_xoachucnang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoachucnang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoachucnang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoachucnang.OnHoverImage = null;
            this.btn_xoachucnang.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_xoachucnang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoachucnang.Radius = 8;
            this.btn_xoachucnang.Size = new System.Drawing.Size(65, 57);
            this.btn_xoachucnang.TabIndex = 40;
            this.btn_xoachucnang.Text = " ";
            this.btn_xoachucnang.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_themchucnang
            // 
            this.btn_themchucnang.AnimationHoverSpeed = 0.07F;
            this.btn_themchucnang.AnimationSpeed = 0.03F;
            this.btn_themchucnang.BackColor = System.Drawing.Color.Transparent;
            this.btn_themchucnang.BaseColor = System.Drawing.Color.SteelBlue;
            this.btn_themchucnang.BorderColor = System.Drawing.Color.Black;
            this.btn_themchucnang.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_themchucnang.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_themchucnang.CheckedForeColor = System.Drawing.Color.White;
            this.btn_themchucnang.CheckedImage = global::GUI.Properties.Resources.icons8_plus_16;
            this.btn_themchucnang.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_themchucnang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_themchucnang.Enabled = false;
            this.btn_themchucnang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_themchucnang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_themchucnang.ForeColor = System.Drawing.Color.White;
            this.btn_themchucnang.Image = global::GUI.Properties.Resources.icons8_plus_16;
            this.btn_themchucnang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_themchucnang.ImageSize = new System.Drawing.Size(10, 10);
            this.btn_themchucnang.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_themchucnang.Location = new System.Drawing.Point(1106, 165);
            this.btn_themchucnang.Name = "btn_themchucnang";
            this.btn_themchucnang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_themchucnang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_themchucnang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_themchucnang.OnHoverImage = null;
            this.btn_themchucnang.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_themchucnang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_themchucnang.Radius = 8;
            this.btn_themchucnang.Size = new System.Drawing.Size(65, 57);
            this.btn_themchucnang.TabIndex = 39;
            this.btn_themchucnang.Text = " ";
            this.btn_themchucnang.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tseDen);
            this.groupControl1.Controls.Add(this.gunaLabel1);
            this.groupControl1.Controls.Add(this.tseTu);
            this.groupControl1.Controls.Add(this.gunaLabel2);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(1106, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(681, 107);
            this.groupControl1.TabIndex = 38;
            this.groupControl1.Text = "Thời Gian Truy Cập";
            // 
            // tseDen
            // 
            this.tseDen.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tseDen.Location = new System.Drawing.Point(421, 44);
            this.tseDen.Name = "tseDen";
            this.tseDen.Properties.AllowEditDays = false;
            this.tseDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tseDen.Size = new System.Drawing.Size(205, 36);
            this.tseDen.TabIndex = 38;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(348, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaLabel1.Size = new System.Drawing.Size(47, 28);
            this.gunaLabel1.TabIndex = 39;
            this.gunaLabel1.Text = "Đến";
            // 
            // tseTu
            // 
            this.tseTu.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tseTu.Location = new System.Drawing.Point(91, 44);
            this.tseTu.Name = "tseTu";
            this.tseTu.Properties.AllowEditDays = false;
            this.tseTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tseTu.Size = new System.Drawing.Size(205, 36);
            this.tseTu.TabIndex = 35;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(18, 48);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaLabel2.Size = new System.Drawing.Size(34, 28);
            this.gunaLabel2.TabIndex = 37;
            this.gunaLabel2.Text = "Từ";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(518, 55);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.gunaShadowPanel1.Radius = 4;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 50;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(556, 76);
            this.gunaShadowPanel1.TabIndex = 34;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaCircleButton1);
            this.gunaGroupBox1.Controls.Add(this.ccb_ChucNang);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(4, 2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 8;
            this.gunaGroupBox1.Size = new System.Drawing.Size(548, 70);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::GUI.Properties.Resources.icons8_search_16;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaCircleButton1.Location = new System.Drawing.Point(22, 20);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(35, 35);
            this.gunaCircleButton1.TabIndex = 8;
            // 
            // ccb_ChucNang
            // 
            this.ccb_ChucNang.EditValue = "";
            this.ccb_ChucNang.Location = new System.Drawing.Point(73, 17);
            this.ccb_ChucNang.Name = "ccb_ChucNang";
            this.ccb_ChucNang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ccb_ChucNang.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ccb_ChucNang.Properties.Appearance.Options.UseFont = true;
            this.ccb_ChucNang.Properties.Appearance.Options.UseForeColor = true;
            this.ccb_ChucNang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ccb_ChucNang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccb_ChucNang.Size = new System.Drawing.Size(445, 38);
            this.ccb_ChucNang.TabIndex = 23;
            // 
            // btn_apdung
            // 
            this.btn_apdung.AnimationHoverSpeed = 0.07F;
            this.btn_apdung.AnimationSpeed = 0.03F;
            this.btn_apdung.BackColor = System.Drawing.Color.Transparent;
            this.btn_apdung.BaseColor = System.Drawing.Color.Empty;
            this.btn_apdung.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_apdung.BorderSize = 2;
            this.btn_apdung.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_apdung.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_apdung.CheckedForeColor = System.Drawing.Color.White;
            this.btn_apdung.CheckedImage = global::GUI.Properties.Resources.icons8_plus_16;
            this.btn_apdung.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_apdung.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_apdung.FocusedColor = System.Drawing.Color.Empty;
            this.btn_apdung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_apdung.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_apdung.Image = null;
            this.btn_apdung.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_apdung.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_apdung.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_apdung.Location = new System.Drawing.Point(1652, 167);
            this.btn_apdung.Name = "btn_apdung";
            this.btn_apdung.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_apdung.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_apdung.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_apdung.OnHoverImage = null;
            this.btn_apdung.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_apdung.OnPressedColor = System.Drawing.Color.Black;
            this.btn_apdung.Radius = 8;
            this.btn_apdung.Size = new System.Drawing.Size(135, 58);
            this.btn_apdung.TabIndex = 33;
            this.btn_apdung.Text = "Áp Dụng";
            this.btn_apdung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_apdung.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_hoadon
            // 
            this.lbl_hoadon.AutoSize = true;
            this.lbl_hoadon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoadon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_hoadon.Location = new System.Drawing.Point(513, 24);
            this.lbl_hoadon.Name = "lbl_hoadon";
            this.lbl_hoadon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_hoadon.Size = new System.Drawing.Size(116, 28);
            this.lbl_hoadon.TabIndex = 24;
            this.lbl_hoadon.Text = "Chức Năng";
            // 
            // clbNCN
            // 
            this.clbNCN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.clbNCN.Appearance.Options.UseBackColor = true;
            this.clbNCN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clbNCN.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.clbNCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.clbNCN.Location = new System.Drawing.Point(7, 39);
            this.clbNCN.Name = "clbNCN";
            this.clbNCN.Padding = new System.Windows.Forms.Padding(20);
            this.clbNCN.Size = new System.Drawing.Size(460, 261);
            this.clbNCN.TabIndex = 3;
            this.clbNCN.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbNCN_ItemCheck);
            // 
            // gcPhanQuyen
            // 
            this.gcPhanQuyen.DataSource = this.phanQuyenVaiTroChucNangBindingSource;
            this.gcPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhanQuyen.Location = new System.Drawing.Point(213, 307);
            this.gcPhanQuyen.MainView = this.gvPhanQuyen;
            this.gcPhanQuyen.Name = "gcPhanQuyen";
            this.gcPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChucNang});
            this.gcPhanQuyen.Size = new System.Drawing.Size(2042, 605);
            this.gcPhanQuyen.TabIndex = 4;
            this.gcPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhanQuyen});
            // 
            // gvPhanQuyen
            // 
            this.gvPhanQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhanQuyen,
            this.colMaVaiTro,
            this.colTenVaiTro,
            this.colMaChucNang,
            this.colTenChucNang,
            this.colThoiGianTruyCap});
            this.gvPhanQuyen.GridControl = this.gcPhanQuyen;
            this.gvPhanQuyen.Name = "gvPhanQuyen";
            this.gvPhanQuyen.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPhanQuyen.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPhanQuyen.OptionsFind.AlwaysVisible = true;
            this.gvPhanQuyen.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPhanQuyen_CellValueChanged);
            // 
            // colMaPhanQuyen
            // 
            this.colMaPhanQuyen.FieldName = "MaPhanQuyen";
            this.colMaPhanQuyen.MinWidth = 30;
            this.colMaPhanQuyen.Name = "colMaPhanQuyen";
            this.colMaPhanQuyen.Width = 112;
            // 
            // colMaVaiTro
            // 
            this.colMaVaiTro.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.colMaVaiTro.AppearanceHeader.Options.UseFont = true;
            this.colMaVaiTro.Caption = "Mã Vai Trò";
            this.colMaVaiTro.FieldName = "MaVaiTro";
            this.colMaVaiTro.MinWidth = 30;
            this.colMaVaiTro.Name = "colMaVaiTro";
            this.colMaVaiTro.OptionsColumn.AllowEdit = false;
            this.colMaVaiTro.Visible = true;
            this.colMaVaiTro.VisibleIndex = 0;
            this.colMaVaiTro.Width = 112;
            // 
            // colTenVaiTro
            // 
            this.colTenVaiTro.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.colTenVaiTro.AppearanceHeader.Options.UseFont = true;
            this.colTenVaiTro.Caption = "Tên Vai Trò";
            this.colTenVaiTro.FieldName = "VaiTro.TenVaiTro";
            this.colTenVaiTro.MinWidth = 30;
            this.colTenVaiTro.Name = "colTenVaiTro";
            this.colTenVaiTro.OptionsColumn.AllowEdit = false;
            this.colTenVaiTro.Visible = true;
            this.colTenVaiTro.VisibleIndex = 1;
            this.colTenVaiTro.Width = 112;
            // 
            // colMaChucNang
            // 
            this.colMaChucNang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.colMaChucNang.AppearanceHeader.Options.UseFont = true;
            this.colMaChucNang.Caption = "Mã Chức Năng";
            this.colMaChucNang.FieldName = "MaChucNang";
            this.colMaChucNang.MinWidth = 30;
            this.colMaChucNang.Name = "colMaChucNang";
            this.colMaChucNang.OptionsColumn.AllowEdit = false;
            this.colMaChucNang.Visible = true;
            this.colMaChucNang.VisibleIndex = 2;
            this.colMaChucNang.Width = 112;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.colTenChucNang.AppearanceHeader.Options.UseFont = true;
            this.colTenChucNang.Caption = "Tên Chức Năng";
            this.colTenChucNang.FieldName = "ChucNang.TenChucNang";
            this.colTenChucNang.MinWidth = 30;
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.OptionsColumn.AllowEdit = false;
            this.colTenChucNang.Visible = true;
            this.colTenChucNang.VisibleIndex = 3;
            this.colTenChucNang.Width = 112;
            // 
            // colThoiGianTruyCap
            // 
            this.colThoiGianTruyCap.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.colThoiGianTruyCap.AppearanceHeader.Options.UseFont = true;
            this.colThoiGianTruyCap.Caption = "Thời Gian Truy Cập";
            this.colThoiGianTruyCap.FieldName = "ThoiGianTruyCap";
            this.colThoiGianTruyCap.MinWidth = 30;
            this.colThoiGianTruyCap.Name = "colThoiGianTruyCap";
            this.colThoiGianTruyCap.OptionsColumn.AllowEdit = false;
            this.colThoiGianTruyCap.Visible = true;
            this.colThoiGianTruyCap.VisibleIndex = 4;
            this.colThoiGianTruyCap.Width = 112;
            // 
            // repositoryItemChucNang
            // 
            this.repositoryItemChucNang.AutoHeight = false;
            this.repositoryItemChucNang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemChucNang.DataSource = this.chucNangBindingSource;
            this.repositoryItemChucNang.Name = "repositoryItemChucNang";
            this.repositoryItemChucNang.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // chucNangBindingSource
            // 
            this.chucNangBindingSource.DataSource = typeof(DAL_BLL.ChucNang);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolMaChucNang,
            this.gcolTenChucNang});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcolMaChucNang
            // 
            this.gcolMaChucNang.Caption = "Mã Chức Năng";
            this.gcolMaChucNang.FieldName = "MaChucNang";
            this.gcolMaChucNang.Name = "gcolMaChucNang";
            this.gcolMaChucNang.Visible = true;
            this.gcolMaChucNang.VisibleIndex = 0;
            // 
            // gcolTenChucNang
            // 
            this.gcolTenChucNang.Caption = "Tên Chức Năng";
            this.gcolTenChucNang.FieldName = "TenChucNang";
            this.gcolTenChucNang.Name = "gcolTenChucNang";
            this.gcolTenChucNang.Visible = true;
            this.gcolTenChucNang.VisibleIndex = 1;
            // 
            // UC_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcPhanQuyen);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.accordionControl1);
            this.Name = "UC_PhanQuyen";
            this.Size = new System.Drawing.Size(2255, 912);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenVaiTroChucNangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tseDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseTu.Properties)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ccb_ChucNang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbNCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucNangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource phanQuyenVaiTroChucNangBindingSource;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_apdung;
        private Guna.UI.WinForms.GunaLabel lbl_hoadon;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccb_ChucNang;
        private DevExpress.XtraEditors.CheckedListBoxControl clbNCN;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TimeSpanEdit tseDen;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private DevExpress.XtraEditors.TimeSpanEdit tseTu;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnCan;
        private Guna.UI.WinForms.GunaAdvenceButton btn_suachucnah;
        private Guna.UI.WinForms.GunaAdvenceButton btn_xoachucnang;
        private Guna.UI.WinForms.GunaAdvenceButton btn_themchucnang;
        private Guna.UI.WinForms.GunaTextBox txt_tencn;
        private DevExpress.XtraGrid.GridControl gcPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVaiTro;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianTruyCap;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVaiTro;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucNang;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource chucNangBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenChucNang;
    }
}
