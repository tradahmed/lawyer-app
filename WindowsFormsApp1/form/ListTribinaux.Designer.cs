namespace WindowsFormsApp1.form
{
    partial class ListTribinaux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTribinaux));
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.pdfFileOpenBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem();
            this.pdfFileSaveAsBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
            this.pdfFilePrintBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem();
            this.pdfFindTextBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem();
            this.pdfPreviousPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem();
            this.pdfNextPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.pdfSetPageNumberBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem();
            this.repositoryItemPageNumberEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
            this.pdfZoomOutBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem();
            this.pdfZoomInBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem();
            this.pdfExactZoomListBarSubItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
            this.pdfZoom10CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem();
            this.pdfZoom25CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem();
            this.pdfZoom50CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem();
            this.pdfZoom75CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem();
            this.pdfZoom100CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem();
            this.pdfZoom125CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem();
            this.pdfZoom150CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem();
            this.pdfZoom200CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem();
            this.pdfZoom400CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem();
            this.pdfZoom500CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem();
            this.pdfSetActualSizeZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem();
            this.pdfSetPageLevelZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem();
            this.pdfSetFitWidthZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem();
            this.pdfSetFitVisibleZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem();
            this.pdfExportFormDataBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem();
            this.pdfImportFormDataBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.pdfRibbonPage1 = new DevExpress.XtraPdfViewer.Bars.PdfRibbonPage();
            this.pdfFileRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup();
            this.pdfFindRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup();
            this.pdfNavigationRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup();
            this.pdfZoomRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup();
            this.pdfFormDataRibbonPage1 = new DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage();
            this.pdfFormDataBarPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup();
            this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController();
            this.pdfFileSaveAsBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.DocumentFilePath = "C:\\Users\\trada\\Downloads\\combinepdf.pdf";
            this.pdfViewer1.Location = new System.Drawing.Point(0, 139);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(800, 311);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Load += new System.EventHandler(this.pdfViewer1_Load);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.pdfFileOpenBarItem1,
            this.pdfFileSaveAsBarItem1,
            this.pdfFilePrintBarItem1,
            this.pdfFindTextBarItem1,
            this.pdfPreviousPageBarItem1,
            this.pdfNextPageBarItem1,
            this.pdfSetPageNumberBarItem1,
            this.pdfZoomOutBarItem1,
            this.pdfZoomInBarItem1,
            this.pdfExactZoomListBarSubItem1,
            this.pdfZoom10CheckItem1,
            this.pdfZoom25CheckItem1,
            this.pdfZoom50CheckItem1,
            this.pdfZoom75CheckItem1,
            this.pdfZoom100CheckItem1,
            this.pdfZoom125CheckItem1,
            this.pdfZoom150CheckItem1,
            this.pdfZoom200CheckItem1,
            this.pdfZoom400CheckItem1,
            this.pdfZoom500CheckItem1,
            this.pdfSetActualSizeZoomModeCheckItem1,
            this.pdfSetPageLevelZoomModeCheckItem1,
            this.pdfSetFitWidthZoomModeCheckItem1,
            this.pdfSetFitVisibleZoomModeCheckItem1,
            this.pdfExportFormDataBarItem1,
            this.pdfImportFormDataBarItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 30;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pdfRibbonPage1,
            this.pdfFormDataRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 139);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // pdfFileOpenBarItem1
            // 
            this.pdfFileOpenBarItem1.Id = 1;
            this.pdfFileOpenBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1";
            // 
            // pdfFileSaveAsBarItem1
            // 
            this.pdfFileSaveAsBarItem1.Id = 2;
            this.pdfFileSaveAsBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1";
            // 
            // pdfFilePrintBarItem1
            // 
            this.pdfFilePrintBarItem1.Id = 3;
            this.pdfFilePrintBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1";
            // 
            // pdfFindTextBarItem1
            // 
            this.pdfFindTextBarItem1.Id = 4;
            this.pdfFindTextBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1";
            // 
            // pdfPreviousPageBarItem1
            // 
            this.pdfPreviousPageBarItem1.Id = 5;
            this.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1";
            // 
            // pdfNextPageBarItem1
            // 
            this.pdfNextPageBarItem1.Id = 6;
            this.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1";
            // 
            // pdfSetPageNumberBarItem1
            // 
            this.pdfSetPageNumberBarItem1.Edit = this.repositoryItemPageNumberEdit1;
            this.pdfSetPageNumberBarItem1.EditValue = 1;
            this.pdfSetPageNumberBarItem1.Id = 7;
            this.pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1";
            // 
            // repositoryItemPageNumberEdit1
            // 
            this.repositoryItemPageNumberEdit1.AutoHeight = false;
            this.repositoryItemPageNumberEdit1.Mask.EditMask = "########;";
            this.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1";
            this.repositoryItemPageNumberEdit1.TotalPageCount = 11;
            // 
            // pdfZoomOutBarItem1
            // 
            this.pdfZoomOutBarItem1.Id = 8;
            this.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1";
            // 
            // pdfZoomInBarItem1
            // 
            this.pdfZoomInBarItem1.Id = 9;
            this.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1";
            // 
            // pdfExactZoomListBarSubItem1
            // 
            this.pdfExactZoomListBarSubItem1.Id = 10;
            this.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem1)});
            this.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1";
            this.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // pdfZoom10CheckItem1
            // 
            this.pdfZoom10CheckItem1.Id = 11;
            this.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1";
            // 
            // pdfZoom25CheckItem1
            // 
            this.pdfZoom25CheckItem1.Id = 12;
            this.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1";
            // 
            // pdfZoom50CheckItem1
            // 
            this.pdfZoom50CheckItem1.Id = 13;
            this.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1";
            // 
            // pdfZoom75CheckItem1
            // 
            this.pdfZoom75CheckItem1.Id = 14;
            this.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1";
            // 
            // pdfZoom100CheckItem1
            // 
            this.pdfZoom100CheckItem1.Id = 15;
            this.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1";
            // 
            // pdfZoom125CheckItem1
            // 
            this.pdfZoom125CheckItem1.Id = 16;
            this.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1";
            // 
            // pdfZoom150CheckItem1
            // 
            this.pdfZoom150CheckItem1.Id = 17;
            this.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1";
            // 
            // pdfZoom200CheckItem1
            // 
            this.pdfZoom200CheckItem1.Id = 18;
            this.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1";
            // 
            // pdfZoom400CheckItem1
            // 
            this.pdfZoom400CheckItem1.Id = 19;
            this.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1";
            // 
            // pdfZoom500CheckItem1
            // 
            this.pdfZoom500CheckItem1.Id = 20;
            this.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1";
            // 
            // pdfSetActualSizeZoomModeCheckItem1
            // 
            this.pdfSetActualSizeZoomModeCheckItem1.Id = 21;
            this.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1";
            // 
            // pdfSetPageLevelZoomModeCheckItem1
            // 
            this.pdfSetPageLevelZoomModeCheckItem1.Id = 22;
            this.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1";
            // 
            // pdfSetFitWidthZoomModeCheckItem1
            // 
            this.pdfSetFitWidthZoomModeCheckItem1.Id = 23;
            this.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1";
            // 
            // pdfSetFitVisibleZoomModeCheckItem1
            // 
            this.pdfSetFitVisibleZoomModeCheckItem1.Id = 24;
            this.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1";
            // 
            // pdfExportFormDataBarItem1
            // 
            this.pdfExportFormDataBarItem1.Id = 25;
            this.pdfExportFormDataBarItem1.Name = "pdfExportFormDataBarItem1";
            // 
            // pdfImportFormDataBarItem1
            // 
            this.pdfImportFormDataBarItem1.Id = 26;
            this.pdfImportFormDataBarItem1.Name = "pdfImportFormDataBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 27;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "اضافة";
            this.barButtonItem2.Id = 28;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "مشاهدة";
            this.barButtonItem3.Id = 29;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // pdfRibbonPage1
            // 
            this.pdfRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pdfFileRibbonPageGroup1,
            this.pdfFindRibbonPageGroup1,
            this.pdfNavigationRibbonPageGroup1,
            this.pdfZoomRibbonPageGroup1});
            this.pdfRibbonPage1.Name = "pdfRibbonPage1";
            // 
            // pdfFileRibbonPageGroup1
            // 
            this.pdfFileRibbonPageGroup1.ItemLinks.Add(this.pdfFileOpenBarItem1);
            this.pdfFileRibbonPageGroup1.ItemLinks.Add(this.pdfFileSaveAsBarItem1);
            this.pdfFileRibbonPageGroup1.ItemLinks.Add(this.pdfFilePrintBarItem1);
            this.pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1";
            // 
            // pdfFindRibbonPageGroup1
            // 
            this.pdfFindRibbonPageGroup1.AllowTextClipping = false;
            this.pdfFindRibbonPageGroup1.ItemLinks.Add(this.pdfFindTextBarItem1);
            this.pdfFindRibbonPageGroup1.Name = "pdfFindRibbonPageGroup1";
            // 
            // pdfNavigationRibbonPageGroup1
            // 
            this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfPreviousPageBarItem1);
            this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfNextPageBarItem1);
            this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfSetPageNumberBarItem1);
            this.pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1";
            // 
            // pdfZoomRibbonPageGroup1
            // 
            this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfZoomOutBarItem1);
            this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfZoomInBarItem1);
            this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfExactZoomListBarSubItem1);
            this.pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1";
            // 
            // pdfFormDataRibbonPage1
            // 
            this.pdfFormDataRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pdfFormDataBarPageGroup1});
            this.pdfFormDataRibbonPage1.Name = "pdfFormDataRibbonPage1";
            // 
            // pdfFormDataBarPageGroup1
            // 
            this.pdfFormDataBarPageGroup1.ItemLinks.Add(this.pdfExportFormDataBarItem1);
            this.pdfFormDataBarPageGroup1.ItemLinks.Add(this.pdfImportFormDataBarItem1);
            this.pdfFormDataBarPageGroup1.Name = "pdfFormDataBarPageGroup1";
            // 
            // pdfBarController1
            // 
            this.pdfBarController1.BarItems.Add(this.pdfFileOpenBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFileSaveAsBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFilePrintBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFindTextBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfPreviousPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfNextPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageNumberBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomOutBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomInBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfExactZoomListBarSubItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom10CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom25CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom50CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom75CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom100CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom125CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom150CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom200CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom400CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom500CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetActualSizeZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageLevelZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitWidthZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitVisibleZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfExportFormDataBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfImportFormDataBarItem1);
            this.pdfBarController1.Control = this.pdfViewer1;
            // 
            // pdfFileSaveAsBarItem2
            // 
            this.pdfFileSaveAsBarItem2.Id = 2;
            this.pdfFileSaveAsBarItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.pdfFileSaveAsBarItem2.Name = "pdfFileSaveAsBarItem2";
            // 
            // ListTribinaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListTribinaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListTribinaux";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListTribinaux_FormClosed);
            this.Load += new System.EventHandler(this.ListTribinaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem pdfFileOpenBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem pdfFileSaveAsBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem pdfFilePrintBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem pdfFindTextBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem pdfPreviousPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem pdfSetPageNumberBarItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem pdfZoomOutBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem pdfZoomInBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem pdfExactZoomListBarSubItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem pdfZoom10CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem pdfZoom25CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem pdfZoom50CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem pdfZoom75CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem pdfZoom100CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem pdfZoom125CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem pdfZoom150CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem pdfZoom200CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem pdfZoom400CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem pdfZoom500CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem pdfSetActualSizeZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem pdfSetPageLevelZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem pdfSetFitWidthZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem pdfSetFitVisibleZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem pdfExportFormDataBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem pdfImportFormDataBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfRibbonPage pdfRibbonPage1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup pdfFileRibbonPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup pdfFindRibbonPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup pdfNavigationRibbonPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup pdfZoomRibbonPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage pdfFormDataRibbonPage1;
        private DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup pdfFormDataBarPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem pdfFileSaveAsBarItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}