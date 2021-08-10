namespace GUI
{
    partial class UC_NhaCungCap
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCongNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvNhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageLogo = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_thanhtoan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblDonHang = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.btnCan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbl_TenNcc = new DevExpress.XtraEditors.LabelControl();
            this.logo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetail
            // 
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCongNo,
            this.colMaPhieuNhap,
            this.colNgayTra,
            this.colSoTienTra,
            this.colConLai});
            this.gvDetail.GridControl = this.gcNhaCungCap;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsDetail.EnableMasterViewMode = false;
            this.gvDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvDetail_MouseDown);
            // 
            // colMaCongNo
            // 
            this.colMaCongNo.Caption = "Mã Công Nợ";
            this.colMaCongNo.FieldName = "MaCongNo";
            this.colMaCongNo.MinWidth = 30;
            this.colMaCongNo.Name = "colMaCongNo";
            this.colMaCongNo.OptionsColumn.AllowEdit = false;
            this.colMaCongNo.Visible = true;
            this.colMaCongNo.VisibleIndex = 0;
            this.colMaCongNo.Width = 112;
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.Caption = "Mã Phiếu Nhập";
            this.colMaPhieuNhap.MinWidth = 30;
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.OptionsColumn.AllowEdit = false;
            this.colMaPhieuNhap.Visible = true;
            this.colMaPhieuNhap.VisibleIndex = 1;
            this.colMaPhieuNhap.Width = 112;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Caption = "Ngày Chi Trả";
            this.colNgayTra.FieldName = "NgayTra";
            this.colNgayTra.MinWidth = 30;
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.OptionsColumn.AllowEdit = false;
            this.colNgayTra.Visible = true;
            this.colNgayTra.VisibleIndex = 2;
            this.colNgayTra.Width = 112;
            // 
            // colSoTienTra
            // 
            this.colSoTienTra.Caption = "Số Tiền Trả";
            this.colSoTienTra.DisplayFormat.FormatString = "#,#";
            this.colSoTienTra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTienTra.FieldName = "TraTien";
            this.colSoTienTra.MinWidth = 30;
            this.colSoTienTra.Name = "colSoTienTra";
            this.colSoTienTra.OptionsColumn.AllowEdit = false;
            this.colSoTienTra.Visible = true;
            this.colSoTienTra.VisibleIndex = 3;
            this.colSoTienTra.Width = 112;
            // 
            // colConLai
            // 
            this.colConLai.Caption = "Còn Lại";
            this.colConLai.DisplayFormat.FormatString = "#,#";
            this.colConLai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colConLai.FieldName = "ConLai";
            this.colConLai.MinWidth = 30;
            this.colConLai.Name = "colConLai";
            this.colConLai.OptionsColumn.AllowEdit = false;
            this.colConLai.Visible = true;
            this.colConLai.VisibleIndex = 4;
            this.colConLai.Width = 112;
            // 
            // gcNhaCungCap
            // 
            this.gcNhaCungCap.DataSource = this.nhaCungCapBindingSource;
            this.gcNhaCungCap.Dock = System.Windows.Forms.DockStyle.Left;
            gridLevelNode1.LevelTemplate = this.gvDetail;
            gridLevelNode1.RelationName = "gcDetail";
            this.gcNhaCungCap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcNhaCungCap.Location = new System.Drawing.Point(15, 423);
            this.gcNhaCungCap.MainView = this.gvNhaCungCap;
            this.gcNhaCungCap.Name = "gcNhaCungCap";
            this.gcNhaCungCap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageLogo});
            this.gcNhaCungCap.Size = new System.Drawing.Size(2052, 679);
            this.gcNhaCungCap.TabIndex = 2;
            this.gcNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhaCungCap,
            this.gvDetail});
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataSource = typeof(DAL_BLL.NhaCungCap);
            // 
            // gvNhaCungCap
            // 
            this.gvNhaCungCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhaCungCap,
            this.colTenNhaCungCap,
            this.colDiaChi,
            this.colActive,
            this.colSoDienThoai,
            this.colLoaiHang});
            this.gvNhaCungCap.GridControl = this.gcNhaCungCap;
            this.gvNhaCungCap.Name = "gvNhaCungCap";
            this.gvNhaCungCap.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvNhaCungCap.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvNhaCungCap.OptionsDetail.ShowDetailTabs = false;
            this.gvNhaCungCap.OptionsFind.AlwaysVisible = true;
            this.gvNhaCungCap.OptionsSelection.MultiSelect = true;
            this.gvNhaCungCap.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvNhaCungCap.OptionsView.ShowFooter = true;
            this.gvNhaCungCap.OptionsView.ShowGroupPanel = false;
            this.gvNhaCungCap.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvNhaCungCap_MasterRowEmpty);
            this.gvNhaCungCap.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvNhaCungCap_MasterRowGetChildList);
            this.gvNhaCungCap.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvNhaCungCap_MasterRowGetRelationName);
            this.gvNhaCungCap.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvNhaCungCap_MasterRowGetRelationCount);
            this.gvNhaCungCap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhaCungCap_FocusedRowChanged);
            // 
            // colMaNhaCungCap
            // 
            this.colMaNhaCungCap.FieldName = "MaNhaCungCap";
            this.colMaNhaCungCap.MinWidth = 30;
            this.colMaNhaCungCap.Name = "colMaNhaCungCap";
            this.colMaNhaCungCap.OptionsColumn.AllowEdit = false;
            this.colMaNhaCungCap.Width = 112;
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.Caption = "Tên Nhà Cung Cấp";
            this.colTenNhaCungCap.FieldName = "TenNhaCungCap";
            this.colTenNhaCungCap.MinWidth = 30;
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.OptionsColumn.AllowEdit = false;
            this.colTenNhaCungCap.Visible = true;
            this.colTenNhaCungCap.VisibleIndex = 0;
            this.colTenNhaCungCap.Width = 112;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 30;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 1;
            this.colDiaChi.Width = 112;
            // 
            // colActive
            // 
            this.colActive.Caption = "Trạng Thái";
            this.colActive.FieldName = "Active";
            this.colActive.MinWidth = 30;
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.AllowEdit = false;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            this.colActive.Width = 112;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Caption = "Số Điện Thoại";
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.MinWidth = 30;
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.OptionsColumn.AllowEdit = false;
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 3;
            this.colSoDienThoai.Width = 112;
            // 
            // colLoaiHang
            // 
            this.colLoaiHang.Caption = "Lĩnh Vực";
            this.colLoaiHang.FieldName = "LoaiCungCap";
            this.colLoaiHang.MinWidth = 30;
            this.colLoaiHang.Name = "colLoaiHang";
            this.colLoaiHang.OptionsColumn.AllowEdit = false;
            this.colLoaiHang.Visible = true;
            this.colLoaiHang.VisibleIndex = 4;
            this.colLoaiHang.Width = 112;
            // 
            // repositoryItemImageLogo
            // 
            this.repositoryItemImageLogo.AutoHeight = false;
            this.repositoryItemImageLogo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageLogo.Name = "repositoryItemImageLogo";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_thanhtoan);
            this.panelControl1.Controls.Add(this.lblDonHang);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblDiaChi);
            this.panelControl1.Controls.Add(this.lblTrangThai);
            this.panelControl1.Controls.Add(this.btnCan);
            this.panelControl1.Controls.Add(this.btn_sua);
            this.panelControl1.Controls.Add(this.btn_xoa);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Controls.Add(this.lbl_TenNcc);
            this.panelControl1.Controls.Add(this.logo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(15, 15);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.panelControl1.Size = new System.Drawing.Size(2072, 408);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.AnimationHoverSpeed = 0.07F;
            this.btn_thanhtoan.AnimationSpeed = 0.03F;
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_thanhtoan.BaseColor = System.Drawing.Color.Gray;
            this.btn_thanhtoan.BorderColor = System.Drawing.Color.Gray;
            this.btn_thanhtoan.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_thanhtoan.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.CheckedForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.CheckedImage = null;
            this.btn_thanhtoan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_thanhtoan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_thanhtoan.FocusedColor = System.Drawing.Color.Empty;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.Image = null;
            this.btn_thanhtoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_thanhtoan.ImageSize = new System.Drawing.Size(10, 10);
            this.btn_thanhtoan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_thanhtoan.Location = new System.Drawing.Point(1801, 317);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_thanhtoan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.OnHoverImage = null;
            this.btn_thanhtoan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_thanhtoan.OnPressedColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.Radius = 8;
            this.btn_thanhtoan.Size = new System.Drawing.Size(241, 66);
            this.btn_thanhtoan.TabIndex = 42;
            this.btn_thanhtoan.Text = "Thanh Toán Công Nợ";
            this.btn_thanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblDonHang
            // 
            this.lblDonHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblDonHang.Appearance.Options.UseFont = true;
            this.lblDonHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDonHang.Location = new System.Drawing.Point(896, 260);
            this.lblDonHang.Name = "lblDonHang";
            this.lblDonHang.Size = new System.Drawing.Size(812, 39);
            this.lblDonHang.TabIndex = 41;
            this.lblDonHang.Text = "Trạng Thái";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(649, 262);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(224, 39);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Đơn hàng gần đây: ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDiaChi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.lblDiaChi.Appearance.Options.UseFont = true;
            this.lblDiaChi.Appearance.Options.UseForeColor = true;
            this.lblDiaChi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDiaChi.Location = new System.Drawing.Point(363, 125);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(1689, 132);
            this.lblDiaChi.TabIndex = 39;
            this.lblDiaChi.Text = "Trạng Thái";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTrangThai.Appearance.Options.UseFont = true;
            this.lblTrangThai.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTrangThai.Location = new System.Drawing.Point(366, 260);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(152, 39);
            this.lblTrangThai.TabIndex = 38;
            this.lblTrangThai.Text = "Trạng Thái";
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
            this.btnCan.Location = new System.Drawing.Point(383, 326);
            this.btnCan.Name = "btnCan";
            this.btnCan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCan.OnHoverImage = null;
            this.btnCan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCan.OnPressedColor = System.Drawing.Color.Black;
            this.btnCan.Radius = 8;
            this.btnCan.Size = new System.Drawing.Size(65, 57);
            this.btnCan.TabIndex = 37;
            this.btnCan.Text = "X";
            this.btnCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AnimationHoverSpeed = 0.07F;
            this.btn_sua.AnimationSpeed = 0.03F;
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.BaseColor = System.Drawing.Color.SteelBlue;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_sua.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_sua.CheckedForeColor = System.Drawing.Color.White;
            this.btn_sua.CheckedImage = global::GUI.Properties.Resources.icons8_plus_16;
            this.btn_sua.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_sua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sua.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Image = global::GUI.Properties.Resources.icons8_edit_32;
            this.btn_sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sua.ImageSize = new System.Drawing.Size(10, 10);
            this.btn_sua.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_sua.Location = new System.Drawing.Point(269, 326);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sua.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_sua.OnHoverImage = null;
            this.btn_sua.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_sua.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sua.Radius = 8;
            this.btn_sua.Size = new System.Drawing.Size(65, 57);
            this.btn_sua.TabIndex = 36;
            this.btn_sua.Text = " ";
            this.btn_sua.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AnimationHoverSpeed = 0.07F;
            this.btn_xoa.AnimationSpeed = 0.03F;
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.BaseColor = System.Drawing.Color.SteelBlue;
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_xoa.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_xoa.CheckedForeColor = System.Drawing.Color.White;
            this.btn_xoa.CheckedImage = global::GUI.Properties.Resources.icons8_delete_trash_32;
            this.btn_xoa.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoa.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = global::GUI.Properties.Resources.icons8_delete_trash_32;
            this.btn_xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoa.ImageSize = new System.Drawing.Size(10, 10);
            this.btn_xoa.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_xoa.Location = new System.Drawing.Point(155, 326);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoa.OnHoverImage = null;
            this.btn_xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoa.Radius = 8;
            this.btn_xoa.Size = new System.Drawing.Size(65, 57);
            this.btn_xoa.TabIndex = 35;
            this.btn_xoa.Text = " ";
            this.btn_xoa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_save
            // 
            this.btn_save.AnimationHoverSpeed = 0.07F;
            this.btn_save.AnimationSpeed = 0.03F;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BaseColor = System.Drawing.Color.SteelBlue;
            this.btn_save.BorderColor = System.Drawing.Color.Black;
            this.btn_save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_save.CheckedForeColor = System.Drawing.Color.White;
            this.btn_save.CheckedImage = global::GUI.Properties.Resources.icons8_plus_16;
            this.btn_save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_save.Enabled = false;
            this.btn_save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = global::GUI.Properties.Resources.icons8_save_32;
            this.btn_save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_save.ImageSize = new System.Drawing.Size(10, 10);
            this.btn_save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_save.Location = new System.Drawing.Point(41, 326);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_save.Radius = 8;
            this.btn_save.Size = new System.Drawing.Size(65, 57);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = " ";
            this.btn_save.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_TenNcc
            // 
            this.lbl_TenNcc.Appearance.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lbl_TenNcc.Appearance.Options.UseFont = true;
            this.lbl_TenNcc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_TenNcc.Location = new System.Drawing.Point(359, 13);
            this.lbl_TenNcc.Name = "lbl_TenNcc";
            this.lbl_TenNcc.Size = new System.Drawing.Size(1388, 110);
            this.lbl_TenNcc.TabIndex = 1;
            this.lbl_TenNcc.Text = "Tên Nhà Cung Cấp";
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(39, 3);
            this.logo.Name = "logo";
            this.logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.logo.Size = new System.Drawing.Size(306, 298);
            this.logo.TabIndex = 0;
            // 
            // UC_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcNhaCungCap);
            this.Controls.Add(this.panelControl1);
            this.Name = "UC_NhaCungCap";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.Size = new System.Drawing.Size(2087, 1102);
            this.Load += new System.EventHandler(this.UC_NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_TenNcc;
        private DevExpress.XtraEditors.PictureEdit logo;
        private Guna.UI.WinForms.GunaAdvenceButton btnCan;
        private Guna.UI.WinForms.GunaAdvenceButton btn_sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_xoa;
        private Guna.UI.WinForms.GunaAdvenceButton btn_save;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private DevExpress.XtraGrid.GridControl gcNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCongNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienTra;
        private DevExpress.XtraGrid.Columns.GridColumn colConLai;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageLogo;
        private DevExpress.XtraEditors.LabelControl lblDonHang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_thanhtoan;
    }
}
