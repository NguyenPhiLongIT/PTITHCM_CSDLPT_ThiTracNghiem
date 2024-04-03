namespace TN_CSDLPT
{
    partial class frmNhapDe
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
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDe));
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new TN_CSDLPT.DS();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.BODETableAdapter = new TN_CSDLPT.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.CTBAITHITableAdapter = new TN_CSDLPT.DSTableAdapters.CTBAITHITableAdapter();
            this.bODEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.mAGVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dAP_ANTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nOIDUNGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tRINHDOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cAUHOISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bdsCTBaiThi = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.dSMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.DSMONHOCTableAdapter();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENMHComboBox = new System.Windows.Forms.ComboBox();
            cAUHOILabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAP_ANTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBaiThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(46, 30);
            cAUHOILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(51, 13);
            cAUHOILabel.TabIndex = 0;
            cAUHOILabel.Text = "CAUHOI:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(46, 127);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(57, 13);
            tRINHDOLabel.TabIndex = 4;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(500, 30);
            nOIDUNGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(58, 13);
            nOIDUNGLabel.TabIndex = 6;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(500, 88);
            aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(18, 13);
            aLabel.TabIndex = 8;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(500, 143);
            bLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(17, 13);
            bLabel.TabIndex = 10;
            bLabel.Text = "B:";
            bLabel.Click += new System.EventHandler(this.bLabel_Click);
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(910, 88);
            cLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(18, 13);
            cLabel.TabIndex = 12;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(910, 143);
            dLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(18, 13);
            dLabel.TabIndex = 14;
            dLabel.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(967, 31);
            dAP_ANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(48, 13);
            dAP_ANLabel.TabIndex = 16;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(46, 187);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 18;
            mAGVLabel.Text = "MAGV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnDSGV,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDSGV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            // 
            // btnDSGV
            // 
            this.btnDSGV.Caption = "In Danh Sách Giáo Viên";
            this.btnDSGV.Id = 6;
            this.btnDSGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSGV.ImageOptions.Image")));
            this.btnDSGV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSGV.ImageOptions.LargeImage")));
            this.btnDSGV.Name = "btnDSGV";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1348, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 692);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1348, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 647);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1348, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 647);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "BODE";
            this.bdsBoDe.DataSource = this.DS;
            // 
            // BODETableAdapter
            // 
            this.BODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.BODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = this.CTBAITHITableAdapter;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CTBAITHITableAdapter
            // 
            this.CTBAITHITableAdapter.ClearBeforeFill = true;
            // 
            // bODEGridControl
            // 
            this.bODEGridControl.DataSource = this.bdsBoDe;
            this.bODEGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bODEGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bODEGridControl.Location = new System.Drawing.Point(0, 45);
            this.bODEGridControl.MainView = this.gridView1;
            this.bODEGridControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bODEGridControl.MenuManager = this.barManager1;
            this.bODEGridControl.Name = "bODEGridControl";
            this.bODEGridControl.Size = new System.Drawing.Size(1348, 254);
            this.bODEGridControl.TabIndex = 6;
            this.bODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.DetailHeight = 404;
            this.gridView1.GridControl = this.bODEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 23;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 87;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 23;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 87;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 23;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 87;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 23;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 87;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 23;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 87;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 23;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 87;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 23;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 87;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 23;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 87;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 23;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 87;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 23;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 87;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(tENMHLabel);
            this.panelControl2.Controls.Add(this.tENMHComboBox);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(this.mAMHTextEdit);
            this.panelControl2.Controls.Add(mAGVLabel);
            this.panelControl2.Controls.Add(this.mAGVTextEdit);
            this.panelControl2.Controls.Add(dAP_ANLabel);
            this.panelControl2.Controls.Add(this.dAP_ANTextEdit);
            this.panelControl2.Controls.Add(dLabel);
            this.panelControl2.Controls.Add(this.dTextEdit);
            this.panelControl2.Controls.Add(cLabel);
            this.panelControl2.Controls.Add(this.cTextEdit);
            this.panelControl2.Controls.Add(bLabel);
            this.panelControl2.Controls.Add(this.bTextEdit);
            this.panelControl2.Controls.Add(aLabel);
            this.panelControl2.Controls.Add(this.aTextEdit);
            this.panelControl2.Controls.Add(nOIDUNGLabel);
            this.panelControl2.Controls.Add(this.nOIDUNGTextEdit);
            this.panelControl2.Controls.Add(tRINHDOLabel);
            this.panelControl2.Controls.Add(this.tRINHDOTextEdit);
            this.panelControl2.Controls.Add(cAUHOILabel);
            this.panelControl2.Controls.Add(this.cAUHOISpinEdit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 299);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1348, 393);
            this.panelControl2.TabIndex = 7;
            // 
            // mAGVTextEdit
            // 
            this.mAGVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "MAGV", true));
            this.mAGVTextEdit.Location = new System.Drawing.Point(183, 183);
            this.mAGVTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mAGVTextEdit.MenuManager = this.barManager1;
            this.mAGVTextEdit.Name = "mAGVTextEdit";
            this.mAGVTextEdit.Size = new System.Drawing.Size(133, 20);
            this.mAGVTextEdit.TabIndex = 19;
            // 
            // dAP_ANTextEdit
            // 
            this.dAP_ANTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "DAP_AN", true));
            this.dAP_ANTextEdit.Location = new System.Drawing.Point(1030, 27);
            this.dAP_ANTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dAP_ANTextEdit.MenuManager = this.barManager1;
            this.dAP_ANTextEdit.Name = "dAP_ANTextEdit";
            this.dAP_ANTextEdit.Size = new System.Drawing.Size(67, 20);
            this.dAP_ANTextEdit.TabIndex = 17;
            // 
            // dTextEdit
            // 
            this.dTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "D", true));
            this.dTextEdit.Location = new System.Drawing.Point(952, 140);
            this.dTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dTextEdit.MenuManager = this.barManager1;
            this.dTextEdit.Name = "dTextEdit";
            this.dTextEdit.Size = new System.Drawing.Size(254, 20);
            this.dTextEdit.TabIndex = 15;
            // 
            // cTextEdit
            // 
            this.cTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "C", true));
            this.cTextEdit.Location = new System.Drawing.Point(952, 85);
            this.cTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cTextEdit.MenuManager = this.barManager1;
            this.cTextEdit.Name = "cTextEdit";
            this.cTextEdit.Size = new System.Drawing.Size(254, 20);
            this.cTextEdit.TabIndex = 13;
            // 
            // bTextEdit
            // 
            this.bTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "B", true));
            this.bTextEdit.Location = new System.Drawing.Point(619, 136);
            this.bTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bTextEdit.MenuManager = this.barManager1;
            this.bTextEdit.Name = "bTextEdit";
            this.bTextEdit.Size = new System.Drawing.Size(254, 20);
            this.bTextEdit.TabIndex = 11;
            // 
            // aTextEdit
            // 
            this.aTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "A", true));
            this.aTextEdit.Location = new System.Drawing.Point(619, 85);
            this.aTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextEdit.MenuManager = this.barManager1;
            this.aTextEdit.Name = "aTextEdit";
            this.aTextEdit.Size = new System.Drawing.Size(254, 20);
            this.aTextEdit.TabIndex = 9;
            // 
            // nOIDUNGTextEdit
            // 
            this.nOIDUNGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "NOIDUNG", true));
            this.nOIDUNGTextEdit.Location = new System.Drawing.Point(619, 13);
            this.nOIDUNGTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nOIDUNGTextEdit.MenuManager = this.barManager1;
            this.nOIDUNGTextEdit.Name = "nOIDUNGTextEdit";
            this.nOIDUNGTextEdit.Properties.AutoHeight = false;
            this.nOIDUNGTextEdit.Size = new System.Drawing.Size(299, 49);
            this.nOIDUNGTextEdit.TabIndex = 7;
            // 
            // tRINHDOTextEdit
            // 
            this.tRINHDOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "TRINHDO", true));
            this.tRINHDOTextEdit.Location = new System.Drawing.Point(183, 123);
            this.tRINHDOTextEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tRINHDOTextEdit.MenuManager = this.barManager1;
            this.tRINHDOTextEdit.Name = "tRINHDOTextEdit";
            this.tRINHDOTextEdit.Size = new System.Drawing.Size(84, 20);
            this.tRINHDOTextEdit.TabIndex = 5;
            // 
            // cAUHOISpinEdit
            // 
            this.cAUHOISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "CAUHOI", true));
            this.cAUHOISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cAUHOISpinEdit.Location = new System.Drawing.Point(183, 27);
            this.cAUHOISpinEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cAUHOISpinEdit.MenuManager = this.barManager1;
            this.cAUHOISpinEdit.Name = "cAUHOISpinEdit";
            this.cAUHOISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cAUHOISpinEdit.Size = new System.Drawing.Size(84, 20);
            this.cAUHOISpinEdit.TabIndex = 1;
            // 
            // bdsCTBaiThi
            // 
            this.bdsCTBaiThi.DataMember = "FK_CTBAITHI_BODE1";
            this.bdsCTBaiThi.DataSource = this.bdsBoDe;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.DS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // dSMONHOCBindingSource
            // 
            this.dSMONHOCBindingSource.DataMember = "DSMONHOC";
            this.dSMONHOCBindingSource.DataSource = this.DS;
            // 
            // dSMONHOCTableAdapter
            // 
            this.dSMONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(324, 84);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 22;
            mAMHLabel.Text = "MAMH:";
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(371, 81);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mAMHTextEdit.TabIndex = 23;
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(132, 83);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(45, 13);
            tENMHLabel.TabIndex = 23;
            tENMHLabel.Text = "TENMH:";
            // 
            // tENMHComboBox
            // 
            this.tENMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSMONHOCBindingSource, "TENMH", true));
            this.tENMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBoDe, "MAMH", true));
            this.tENMHComboBox.DataSource = this.dSMONHOCBindingSource;
            this.tENMHComboBox.DisplayMember = "TENMH";
            this.tENMHComboBox.FormattingEnabled = true;
            this.tENMHComboBox.Location = new System.Drawing.Point(183, 80);
            this.tENMHComboBox.Name = "tENMHComboBox";
            this.tENMHComboBox.Size = new System.Drawing.Size(121, 21);
            this.tENMHComboBox.TabIndex = 24;
            this.tENMHComboBox.ValueMember = "MAMH";
            // 
            // frmNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 712);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.bODEGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNhapDe";
            this.Text = "frmNhapDe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAP_ANTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBaiThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnDSGV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DS DS;
        private DSTableAdapters.BODETableAdapter BODETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bODEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit mAGVTextEdit;
        private DevExpress.XtraEditors.TextEdit dAP_ANTextEdit;
        private DevExpress.XtraEditors.TextEdit dTextEdit;
        private DevExpress.XtraEditors.TextEdit cTextEdit;
        private DevExpress.XtraEditors.TextEdit bTextEdit;
        private DevExpress.XtraEditors.TextEdit aTextEdit;
        private DevExpress.XtraEditors.TextEdit nOIDUNGTextEdit;
        private DevExpress.XtraEditors.TextEdit tRINHDOTextEdit;
        private DevExpress.XtraEditors.SpinEdit cAUHOISpinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DSTableAdapters.CTBAITHITableAdapter CTBAITHITableAdapter;
        private System.Windows.Forms.BindingSource bdsCTBaiThi;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource dSMONHOCBindingSource;
        private DSTableAdapters.DSMONHOCTableAdapter dSMONHOCTableAdapter;
        private System.Windows.Forms.ComboBox tENMHComboBox;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
    }
}