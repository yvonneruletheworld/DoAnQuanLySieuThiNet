namespace GUI
{
    partial class frmCashier_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashier_Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_gop = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dondat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_gd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_pause = new DevExpress.XtraBars.BarButtonItem();
            this.btn_support = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.nvb_hotro = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvb_hotro)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_add,
            this.btn_gop,
            this.btn_dondat,
            this.btn_gd,
            this.barButtonItem1,
            this.btn_pause,
            this.btn_support,
            this.barButtonItem2});
            this.ribbon.LargeImages = this.imageCollection1;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 8;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1944, 256);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_add
            // 
            this.btn_add.Caption = "Thêm hóa đơn";
            this.btn_add.Id = 1;
            this.btn_add.ImageOptions.Image = global::GUI.Properties.Resources.icons8_new_copy_32;
            this.btn_add.ImageOptions.LargeImageIndex = 1;
            this.btn_add.Name = "btn_add";
            this.btn_add.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemClick);
            // 
            // btn_gop
            // 
            this.btn_gop.Caption = "Gộp hóa đơn";
            this.btn_gop.Enabled = false;
            this.btn_gop.Id = 5;
            this.btn_gop.ImageOptions.Image = global::GUI.Properties.Resources.icons8_copy_32;
            this.btn_gop.Name = "btn_gop";
            this.btn_gop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_gop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemClick);
            // 
            // btn_dondat
            // 
            this.btn_dondat.Caption = "Đơn Đặt ";
            this.btn_dondat.Id = 7;
            this.btn_dondat.ImageOptions.Image = global::GUI.Properties.Resources.icons8_order_history_32;
            this.btn_dondat.Name = "btn_dondat";
            this.btn_dondat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_dondat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemClick);
            // 
            // btn_gd
            // 
            this.btn_gd.Caption = "Giao Dịch";
            this.btn_gd.Id = 11;
            this.btn_gd.ImageOptions.Image = global::GUI.Properties.Resources.data_transfer_48px;
            this.btn_gd.Name = "btn_gd";
            this.btn_gd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_gd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_pause
            // 
            this.btn_pause.Caption = "Tạm Đóng Quầy";
            this.btn_pause.Id = 4;
            this.btn_pause.ImageOptions.Image = global::GUI.Properties.Resources.icons8_pause_48;
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_pause.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemClick);
            // 
            // btn_support
            // 
            this.btn_support.Caption = "Hỗ Trợ";
            this.btn_support.Id = 5;
            this.btn_support.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_support.ImageOptions.SvgImage")));
            this.btn_support.Name = "btn_support";
            this.btn_support.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tên chức vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_add, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hóa Đơn";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_gop, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_dondat, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_pause, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_support, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Chức Năng Phụ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_gd);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản Lý";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 1069);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1944, 36);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(7, 69);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(281, 740);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(1936, 149);
            this.xtraTabControl1.TabIndex = 5;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionControlElement1.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "navBarItem1";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionControlElement2.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "navBarGroup1";
            // 
            // nvb_hotro
            // 
            this.nvb_hotro.AllowHtmlText = false;
            this.nvb_hotro.Appearance.AccordionControl.BackColor = System.Drawing.Color.SteelBlue;
            this.nvb_hotro.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.nvb_hotro.Appearance.AccordionControl.Options.UseBackColor = true;
            this.nvb_hotro.Appearance.AccordionControl.Options.UseForeColor = true;
            this.nvb_hotro.Dock = System.Windows.Forms.DockStyle.Right;
            this.nvb_hotro.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2});
            this.nvb_hotro.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.nvb_hotro.Location = new System.Drawing.Point(1944, 256);
            this.nvb_hotro.Name = "nvb_hotro";
            this.nvb_hotro.OptionsFooter.ActiveGroupDisplayMode = DevExpress.XtraBars.Navigation.ActiveGroupDisplayMode.GroupHeaderAndContent;
            this.nvb_hotro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nvb_hotro.Size = new System.Drawing.Size(0, 813);
            this.nvb_hotro.TabIndex = 9;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Trang Chủ";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // frmCashier_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1105);
            this.Controls.Add(this.nvb_hotro);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCashier_Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "frmCashier_Main";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvb_hotro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_add;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btn_gop;
        private DevExpress.XtraBars.BarButtonItem btn_dondat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_gd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_pause;
        private DevExpress.XtraBars.BarButtonItem btn_support;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl nvb_hotro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}