namespace GUI
{
    partial class giaodich
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamGiaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTienSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhuongThucThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItems = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_SoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetail
            // 
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaChiTiet,
            this.colTenHangHoa,
            this.colSoLuong,
            this.colGiaBan,
            this.colGiamGiaHang,
            this.colThanhTienSP});
            this.gvDetail.DetailHeight = 375;
            this.gvDetail.GridControl = this.gcHoaDon;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsView.ShowGroupPanel = false;
            // 
            // colMaChiTiet
            // 
            this.colMaChiTiet.Caption = "Mã Chi Tiết";
            this.colMaChiTiet.FieldName = "MaChiTiet";
            this.colMaChiTiet.MinWidth = 33;
            this.colMaChiTiet.Name = "colMaChiTiet";
            this.colMaChiTiet.OptionsColumn.AllowEdit = false;
            this.colMaChiTiet.Visible = true;
            this.colMaChiTiet.VisibleIndex = 0;
            this.colMaChiTiet.Width = 122;
            // 
            // colTenHangHoa
            // 
            this.colTenHangHoa.Caption = "Tên Hàng Hóa";
            this.colTenHangHoa.FieldName = "TenHangHoa";
            this.colTenHangHoa.MinWidth = 33;
            this.colTenHangHoa.Name = "colTenHangHoa";
            this.colTenHangHoa.Visible = true;
            this.colTenHangHoa.VisibleIndex = 1;
            this.colTenHangHoa.Width = 122;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MinWidth = 33;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 122;
            // 
            // colGiaBan
            // 
            this.colGiaBan.Caption = "Giá Bán";
            this.colGiaBan.DisplayFormat.FormatString = "Numeric \"#,#\"";
            this.colGiaBan.FieldName = "GiaBan";
            this.colGiaBan.MinWidth = 33;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 3;
            this.colGiaBan.Width = 122;
            // 
            // colGiamGiaHang
            // 
            this.colGiamGiaHang.Caption = "Giá Giảm";
            this.colGiamGiaHang.MinWidth = 33;
            this.colGiamGiaHang.Name = "colGiamGiaHang";
            this.colGiamGiaHang.Visible = true;
            this.colGiamGiaHang.VisibleIndex = 4;
            this.colGiamGiaHang.Width = 122;
            // 
            // colThanhTienSP
            // 
            this.colThanhTienSP.Caption = "Thành Tiền";
            this.colThanhTienSP.DisplayFormat.FormatString = "Numeric \"#,#\"";
            this.colThanhTienSP.FieldName = "ThanhTien";
            this.colThanhTienSP.MinWidth = 33;
            this.colThanhTienSP.Name = "colThanhTienSP";
            this.colThanhTienSP.Visible = true;
            this.colThanhTienSP.VisibleIndex = 5;
            this.colThanhTienSP.Width = 122;
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.DataSource = this.hoaDonBindingSource;
            this.gcHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHoaDon.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcHoaDon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.LevelTemplate = this.gvDetail;
            gridLevelNode1.RelationName = "Detail";
            this.gcHoaDon.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcHoaDon.Location = new System.Drawing.Point(0, 0);
            this.gcHoaDon.MainView = this.gvHoaDon;
            this.gcHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItems,
            this.txt_SoLuong});
            this.gcHoaDon.Size = new System.Drawing.Size(1679, 1059);
            this.gcHoaDon.TabIndex = 31;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon,
            this.gvDetail});
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(DAL_BLL.HoaDon);
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gvHoaDon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvHoaDon.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvHoaDon.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvHoaDon.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gvHoaDon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvHoaDon.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvHoaDon.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHoaDon,
            this.colNgayLap,
            this.colNhanVien,
            this.colKhachHang,
            this.colTongCong,
            this.colGiamGia,
            this.colThanhTien,
            this.colTrangThai,
            this.colPhuongThucThanhToan});
            this.gvHoaDon.DetailHeight = 553;
            this.gvHoaDon.FixedLineWidth = 3;
            this.gvHoaDon.GridControl = this.gcHoaDon;
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHoaDon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHoaDon.OptionsDetail.ShowDetailTabs = false;
            this.gvHoaDon.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvHoaDon.OptionsFind.AlwaysVisible = true;
            this.gvHoaDon.OptionsFind.FindNullPrompt = "Nhập nội dung muốn tìm kiếm...";
            this.gvHoaDon.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gvHoaDon.OptionsNavigation.AutoFocusNewRow = true;
            this.gvHoaDon.OptionsSelection.MultiSelect = true;
            this.gvHoaDon.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvHoaDon.OptionsView.ShowGroupPanel = false;
            this.gvHoaDon.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvHoaDon_MasterRowEmpty);
            this.gvHoaDon.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvHoaDon_MasterRowGetChildList);
            this.gvHoaDon.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvHoaDon_MasterRowGetRelationName);
            this.gvHoaDon.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvHoaDon_MasterRowGetRelationCount);
            this.gvHoaDon.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvHoaDon_PopupMenuShowing);
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.Caption = "Mã hóa đơn";
            this.colMaHoaDon.FieldName = "MaHoaDon";
            this.colMaHoaDon.MinWidth = 33;
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.OptionsColumn.AllowEdit = false;
            this.colMaHoaDon.Visible = true;
            this.colMaHoaDon.VisibleIndex = 1;
            this.colMaHoaDon.Width = 122;
            // 
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày Lập";
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.MinWidth = 33;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.AllowEdit = false;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 2;
            this.colNgayLap.Width = 122;
            // 
            // colNhanVien
            // 
            this.colNhanVien.Caption = "Nhân Viên";
            this.colNhanVien.FieldName = "NguoiDung.HoTen";
            this.colNhanVien.MinWidth = 33;
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.OptionsColumn.AllowEdit = false;
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 3;
            this.colNhanVien.Width = 122;
            // 
            // colKhachHang
            // 
            this.colKhachHang.Caption = "Tên Khách Hàng";
            this.colKhachHang.FieldName = "KhachHang.HoTen";
            this.colKhachHang.MinWidth = 33;
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.OptionsColumn.AllowEdit = false;
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 9;
            this.colKhachHang.Width = 122;
            // 
            // colTongCong
            // 
            this.colTongCong.Caption = "Tổng Cộng";
            this.colTongCong.DisplayFormat.FormatString = "#,#";
            this.colTongCong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongCong.FieldName = "TongCong";
            this.colTongCong.MinWidth = 33;
            this.colTongCong.Name = "colTongCong";
            this.colTongCong.OptionsColumn.AllowEdit = false;
            this.colTongCong.Visible = true;
            this.colTongCong.VisibleIndex = 4;
            this.colTongCong.Width = 122;
            // 
            // colGiamGia
            // 
            this.colGiamGia.Caption = "Giảm Giá";
            this.colGiamGia.DisplayFormat.FormatString = "#,#";
            this.colGiamGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiamGia.FieldName = "GiamGia";
            this.colGiamGia.MinWidth = 33;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.OptionsColumn.AllowEdit = false;
            this.colGiamGia.Visible = true;
            this.colGiamGia.VisibleIndex = 6;
            this.colGiamGia.Width = 122;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành Tiền";
            this.colThanhTien.DisplayFormat.FormatString = "#,#";
            this.colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.MinWidth = 33;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.OptionsColumn.AllowEdit = false;
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 5;
            this.colThanhTien.Width = 122;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Có Hiệu Lực";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.MinWidth = 33;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 7;
            this.colTrangThai.Width = 122;
            // 
            // colPhuongThucThanhToan
            // 
            this.colPhuongThucThanhToan.Caption = "Phương thức";
            this.colPhuongThucThanhToan.FieldName = "PhuongThucThanhToan";
            this.colPhuongThucThanhToan.MinWidth = 33;
            this.colPhuongThucThanhToan.Name = "colPhuongThucThanhToan";
            this.colPhuongThucThanhToan.Visible = true;
            this.colPhuongThucThanhToan.VisibleIndex = 8;
            this.colPhuongThucThanhToan.Width = 122;
            // 
            // repositoryItems
            // 
            this.repositoryItems.AutoHeight = false;
            this.repositoryItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItems.DisplayMember = "MaHangHoa";
            this.repositoryItems.Name = "repositoryItems";
            this.repositoryItems.NullText = "Chọn Hàng Hóa";
            this.repositoryItems.PopupView = this.gridView1;
            this.repositoryItems.ValueMember = "MaHangHoa";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHang,
            this.colTenHang});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaHang
            // 
            this.colMaHang.AppearanceCell.Options.UseTextOptions = true;
            this.colMaHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHang.Caption = "Mã Hàng";
            this.colMaHang.FieldName = "MaHangHoa";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Visible = true;
            this.colMaHang.VisibleIndex = 0;
            // 
            // colTenHang
            // 
            this.colTenHang.AppearanceCell.Options.UseTextOptions = true;
            this.colTenHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenHang.Caption = "Tên Hàng Hóa";
            this.colTenHang.FieldName = "TenHangHoa";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Visible = true;
            this.colTenHang.VisibleIndex = 1;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.AutoHeight = false;
            this.txt_SoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_SoLuong.Name = "txt_SoLuong";
            // 
            // giaodich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 1059);
            this.Controls.Add(this.gcHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "giaodich";
            this.Text = "Giao dịch hóa đơn trong ngày";
            this.Load += new System.EventHandler(this.giaodich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit txt_SoLuong;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colTongCong;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colPhuongThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamGiaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTienSP;
    }
}