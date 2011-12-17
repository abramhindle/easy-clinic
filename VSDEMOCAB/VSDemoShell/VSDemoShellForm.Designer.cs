#region Copyright Syncfusion Inc. 2001 - 2010
// Copyright Syncfusion Inc. 2001 - 2010. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace VSDemoShell
{
    partial class VSDemoShellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VSDemoShellForm));
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainToolBar");
            this.fileParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.fileNewParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileNewProjectBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.fileNewWebsiteBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileNewFileBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileOpenParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.fileOpenProjectBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileOpenWebsiteBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileOpenFileBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileAddParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.fileAddNewProjectBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileAddNewFileBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileAddExistingProjectBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileAddExistingFileBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileCloseBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileCloseSolutionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileSaveBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileSaveAllBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileExportTemplateBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.filePageSetupBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.filePrintBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileExitBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.viewParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.projectParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.buildParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.statusBarAdv1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.statusBarAdvPanel1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).BeginInit();
            this.statusBarAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).BeginInit();
            this.statusBarAdvPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fileParentBarItem,
            this.fileNewParentBarItem,
            this.fileNewProjectBarItem,
            this.fileNewWebsiteBarItem,
            this.fileNewFileBarItem,
            this.fileOpenParentBarItem,
            this.fileOpenProjectBarItem,
            this.fileOpenWebsiteBarItem,
            this.fileOpenFileBarItem,
            this.fileAddParentBarItem,
            this.fileAddNewProjectBarItem,
            this.fileAddNewFileBarItem,
            this.fileAddExistingProjectBarItem,
            this.fileAddExistingFileBarItem,
            this.fileCloseBarItem,
            this.fileCloseSolutionBarItem,
            this.fileSaveBarItem,
            this.fileSaveAllBarItem,
            this.fileExportTemplateBarItem,
            this.filePageSetupBarItem,
            this.filePrintBarItem,
            this.fileExitBarItem,
            this.viewParentBarItem,
            this.projectParentBarItem,
            this.buildParentBarItem});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "MainMenu";
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // bar2
            // 
            this.bar2.BarName = "MainToolBar";
            this.bar2.Caption = "MainToolBar";
            this.bar2.Manager = this.mainFrameBarManager1;
            // 
            // fileParentBarItem
            // 
            this.fileParentBarItem.CategoryIndex = 0;
            this.fileParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileParentBarItem.ID = "File";
            this.fileParentBarItem.Text = "File";
            // 
            // fileNewParentBarItem
            // 
            this.fileNewParentBarItem.CategoryIndex = 0;
            this.fileNewParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNewParentBarItem.ID = "New";
            this.fileNewParentBarItem.ImageIndex = 63;
            this.fileNewParentBarItem.ImageList = this.imageList1;
            this.fileNewParentBarItem.Text = "New";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            this.imageList1.Images.SetKeyName(29, "");
            this.imageList1.Images.SetKeyName(30, "");
            this.imageList1.Images.SetKeyName(31, "");
            this.imageList1.Images.SetKeyName(32, "");
            this.imageList1.Images.SetKeyName(33, "");
            this.imageList1.Images.SetKeyName(34, "");
            this.imageList1.Images.SetKeyName(35, "");
            this.imageList1.Images.SetKeyName(36, "");
            this.imageList1.Images.SetKeyName(37, "");
            this.imageList1.Images.SetKeyName(38, "");
            this.imageList1.Images.SetKeyName(39, "");
            this.imageList1.Images.SetKeyName(40, "");
            this.imageList1.Images.SetKeyName(41, "");
            this.imageList1.Images.SetKeyName(42, "");
            this.imageList1.Images.SetKeyName(43, "");
            this.imageList1.Images.SetKeyName(44, "");
            this.imageList1.Images.SetKeyName(45, "");
            this.imageList1.Images.SetKeyName(46, "");
            this.imageList1.Images.SetKeyName(47, "");
            this.imageList1.Images.SetKeyName(48, "");
            this.imageList1.Images.SetKeyName(49, "");
            this.imageList1.Images.SetKeyName(50, "");
            this.imageList1.Images.SetKeyName(51, "");
            this.imageList1.Images.SetKeyName(52, "");
            this.imageList1.Images.SetKeyName(53, "");
            this.imageList1.Images.SetKeyName(54, "");
            this.imageList1.Images.SetKeyName(55, "");
            this.imageList1.Images.SetKeyName(56, "");
            this.imageList1.Images.SetKeyName(57, "");
            this.imageList1.Images.SetKeyName(58, "");
            this.imageList1.Images.SetKeyName(59, "");
            this.imageList1.Images.SetKeyName(60, "");
            this.imageList1.Images.SetKeyName(61, "");
            this.imageList1.Images.SetKeyName(62, "");
            this.imageList1.Images.SetKeyName(63, "");
            this.imageList1.Images.SetKeyName(64, "");
            this.imageList1.Images.SetKeyName(65, "");
            this.imageList1.Images.SetKeyName(66, "");
            this.imageList1.Images.SetKeyName(67, "");
            this.imageList1.Images.SetKeyName(68, "");
            this.imageList1.Images.SetKeyName(69, "");
            this.imageList1.Images.SetKeyName(70, "");
            this.imageList1.Images.SetKeyName(71, "");
            this.imageList1.Images.SetKeyName(72, "");
            this.imageList1.Images.SetKeyName(73, "");
            this.imageList1.Images.SetKeyName(74, "");
            this.imageList1.Images.SetKeyName(75, "");
            this.imageList1.Images.SetKeyName(76, "");
            this.imageList1.Images.SetKeyName(77, "");
            this.imageList1.Images.SetKeyName(78, "");
            this.imageList1.Images.SetKeyName(79, "");
            this.imageList1.Images.SetKeyName(80, "");
            this.imageList1.Images.SetKeyName(81, "");
            this.imageList1.Images.SetKeyName(82, "");
            this.imageList1.Images.SetKeyName(83, "");
            this.imageList1.Images.SetKeyName(84, "");
            this.imageList1.Images.SetKeyName(85, "");
            this.imageList1.Images.SetKeyName(86, "");
            this.imageList1.Images.SetKeyName(87, "");
            this.imageList1.Images.SetKeyName(88, "");
            this.imageList1.Images.SetKeyName(89, "");
            this.imageList1.Images.SetKeyName(90, "");
            this.imageList1.Images.SetKeyName(91, "");
            this.imageList1.Images.SetKeyName(92, "panels_new3_close.ico");
            // 
            // fileNewProjectBarItem
            // 
            this.fileNewProjectBarItem.CategoryIndex = 0;
            this.fileNewProjectBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNewProjectBarItem.ID = "Project";
            this.fileNewProjectBarItem.ImageIndex = 61;
            this.fileNewProjectBarItem.ImageList = this.ImageList2;
            this.fileNewProjectBarItem.Text = "Project";
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "");
            this.ImageList2.Images.SetKeyName(1, "");
            this.ImageList2.Images.SetKeyName(2, "");
            this.ImageList2.Images.SetKeyName(3, "");
            this.ImageList2.Images.SetKeyName(4, "");
            this.ImageList2.Images.SetKeyName(5, "");
            this.ImageList2.Images.SetKeyName(6, "");
            this.ImageList2.Images.SetKeyName(7, "");
            this.ImageList2.Images.SetKeyName(8, "");
            this.ImageList2.Images.SetKeyName(9, "");
            this.ImageList2.Images.SetKeyName(10, "");
            this.ImageList2.Images.SetKeyName(11, "");
            this.ImageList2.Images.SetKeyName(12, "");
            this.ImageList2.Images.SetKeyName(13, "");
            this.ImageList2.Images.SetKeyName(14, "");
            this.ImageList2.Images.SetKeyName(15, "");
            this.ImageList2.Images.SetKeyName(16, "");
            this.ImageList2.Images.SetKeyName(17, "");
            this.ImageList2.Images.SetKeyName(18, "");
            this.ImageList2.Images.SetKeyName(19, "");
            this.ImageList2.Images.SetKeyName(20, "");
            this.ImageList2.Images.SetKeyName(21, "");
            this.ImageList2.Images.SetKeyName(22, "");
            this.ImageList2.Images.SetKeyName(23, "");
            this.ImageList2.Images.SetKeyName(24, "");
            this.ImageList2.Images.SetKeyName(25, "");
            this.ImageList2.Images.SetKeyName(26, "");
            this.ImageList2.Images.SetKeyName(27, "");
            this.ImageList2.Images.SetKeyName(28, "");
            this.ImageList2.Images.SetKeyName(29, "");
            this.ImageList2.Images.SetKeyName(30, "");
            this.ImageList2.Images.SetKeyName(31, "");
            this.ImageList2.Images.SetKeyName(32, "");
            this.ImageList2.Images.SetKeyName(33, "");
            this.ImageList2.Images.SetKeyName(34, "");
            this.ImageList2.Images.SetKeyName(35, "");
            this.ImageList2.Images.SetKeyName(36, "");
            this.ImageList2.Images.SetKeyName(37, "");
            this.ImageList2.Images.SetKeyName(38, "");
            this.ImageList2.Images.SetKeyName(39, "");
            this.ImageList2.Images.SetKeyName(40, "");
            this.ImageList2.Images.SetKeyName(41, "");
            this.ImageList2.Images.SetKeyName(42, "");
            this.ImageList2.Images.SetKeyName(43, "");
            this.ImageList2.Images.SetKeyName(44, "");
            this.ImageList2.Images.SetKeyName(45, "");
            this.ImageList2.Images.SetKeyName(46, "");
            this.ImageList2.Images.SetKeyName(47, "");
            this.ImageList2.Images.SetKeyName(48, "");
            this.ImageList2.Images.SetKeyName(49, "");
            this.ImageList2.Images.SetKeyName(50, "");
            this.ImageList2.Images.SetKeyName(51, "");
            this.ImageList2.Images.SetKeyName(52, "");
            this.ImageList2.Images.SetKeyName(53, "");
            this.ImageList2.Images.SetKeyName(54, "");
            this.ImageList2.Images.SetKeyName(55, "");
            this.ImageList2.Images.SetKeyName(56, "");
            this.ImageList2.Images.SetKeyName(57, "");
            this.ImageList2.Images.SetKeyName(58, "");
            this.ImageList2.Images.SetKeyName(59, "");
            this.ImageList2.Images.SetKeyName(60, "");
            this.ImageList2.Images.SetKeyName(61, "");
            this.ImageList2.Images.SetKeyName(62, "");
            this.ImageList2.Images.SetKeyName(63, "");
            this.ImageList2.Images.SetKeyName(64, "");
            this.ImageList2.Images.SetKeyName(65, "");
            this.ImageList2.Images.SetKeyName(66, "");
            this.ImageList2.Images.SetKeyName(67, "");
            this.ImageList2.Images.SetKeyName(68, "");
            this.ImageList2.Images.SetKeyName(69, "");
            this.ImageList2.Images.SetKeyName(70, "");
            this.ImageList2.Images.SetKeyName(71, "");
            this.ImageList2.Images.SetKeyName(72, "");
            this.ImageList2.Images.SetKeyName(73, "");
            this.ImageList2.Images.SetKeyName(74, "");
            this.ImageList2.Images.SetKeyName(75, "");
            this.ImageList2.Images.SetKeyName(76, "");
            this.ImageList2.Images.SetKeyName(77, "");
            this.ImageList2.Images.SetKeyName(78, "");
            // 
            // fileNewWebsiteBarItem
            // 
            this.fileNewWebsiteBarItem.CategoryIndex = 0;
            this.fileNewWebsiteBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNewWebsiteBarItem.ID = "WebSite";
            this.fileNewWebsiteBarItem.Text = "WebSite";
            // 
            // fileNewFileBarItem
            // 
            this.fileNewFileBarItem.CategoryIndex = 0;
            this.fileNewFileBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNewFileBarItem.ID = "File_1";
            this.fileNewFileBarItem.ImageIndex = 63;
            this.fileNewFileBarItem.ImageList = this.ImageList2;
            this.fileNewFileBarItem.Text = "File";
            // 
            // fileOpenParentBarItem
            // 
            this.fileOpenParentBarItem.CategoryIndex = 0;
            this.fileOpenParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpenParentBarItem.ID = "Open";
            this.fileOpenParentBarItem.Text = "Open";
            // 
            // fileOpenProjectBarItem
            // 
            this.fileOpenProjectBarItem.CategoryIndex = 0;
            this.fileOpenProjectBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpenProjectBarItem.ID = "Project/Solution";
            this.fileOpenProjectBarItem.ImageIndex = 61;
            this.fileOpenProjectBarItem.ImageList = this.ImageList2;
            this.fileOpenProjectBarItem.Text = "Project/Solution";
            // 
            // fileOpenWebsiteBarItem
            // 
            this.fileOpenWebsiteBarItem.CategoryIndex = 0;
            this.fileOpenWebsiteBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpenWebsiteBarItem.ID = "Website";
            this.fileOpenWebsiteBarItem.Text = "Website";
            // 
            // fileOpenFileBarItem
            // 
            this.fileOpenFileBarItem.CategoryIndex = 0;
            this.fileOpenFileBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpenFileBarItem.ID = "File_2";
            this.fileOpenFileBarItem.ImageIndex = 46;
            this.fileOpenFileBarItem.ImageList = this.imageList1;
            this.fileOpenFileBarItem.Text = "File";
            // 
            // fileAddParentBarItem
            // 
            this.fileAddParentBarItem.CategoryIndex = 0;
            this.fileAddParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAddParentBarItem.ID = "Add";
            this.fileAddParentBarItem.Text = "Add";
            // 
            // fileAddNewProjectBarItem
            // 
            this.fileAddNewProjectBarItem.CategoryIndex = 0;
            this.fileAddNewProjectBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAddNewProjectBarItem.ID = "New Project";
            this.fileAddNewProjectBarItem.Text = "New Project";
            // 
            // fileAddNewFileBarItem
            // 
            this.fileAddNewFileBarItem.CategoryIndex = 0;
            this.fileAddNewFileBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAddNewFileBarItem.ID = "New File";
            this.fileAddNewFileBarItem.Text = "New File";
            // 
            // fileAddExistingProjectBarItem
            // 
            this.fileAddExistingProjectBarItem.CategoryIndex = 0;
            this.fileAddExistingProjectBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAddExistingProjectBarItem.ID = "Existing Project";
            this.fileAddExistingProjectBarItem.Text = "Existing Project";
            // 
            // fileAddExistingFileBarItem
            // 
            this.fileAddExistingFileBarItem.CategoryIndex = 0;
            this.fileAddExistingFileBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAddExistingFileBarItem.ID = "Existing File";
            this.fileAddExistingFileBarItem.Text = "Existing File";
            // 
            // fileCloseBarItem
            // 
            this.fileCloseBarItem.CategoryIndex = 0;
            this.fileCloseBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCloseBarItem.ID = "Close";
            this.fileCloseBarItem.Text = "Close";
            // 
            // fileCloseSolutionBarItem
            // 
            this.fileCloseSolutionBarItem.CategoryIndex = 0;
            this.fileCloseSolutionBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCloseSolutionBarItem.ID = "Close Solution";
            this.fileCloseSolutionBarItem.Text = "Close Solution";
            // 
            // fileSaveBarItem
            // 
            this.fileSaveBarItem.CategoryIndex = 0;
            this.fileSaveBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSaveBarItem.ID = "Save";
            this.fileSaveBarItem.ImageIndex = 30;
            this.fileSaveBarItem.ImageList = this.imageList1;
            this.fileSaveBarItem.Text = "Save";
            // 
            // fileSaveAllBarItem
            // 
            this.fileSaveAllBarItem.CategoryIndex = 0;
            this.fileSaveAllBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSaveAllBarItem.ID = "Save All";
            this.fileSaveAllBarItem.ImageIndex = 29;
            this.fileSaveAllBarItem.ImageList = this.imageList1;
            this.fileSaveAllBarItem.Text = "Save All";
            // 
            // fileExportTemplateBarItem
            // 
            this.fileExportTemplateBarItem.CategoryIndex = 0;
            this.fileExportTemplateBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileExportTemplateBarItem.ID = "Export Template";
            this.fileExportTemplateBarItem.Text = "Export Template";
            // 
            // filePageSetupBarItem
            // 
            this.filePageSetupBarItem.CategoryIndex = 0;
            this.filePageSetupBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePageSetupBarItem.ID = "Page Setup";
            this.filePageSetupBarItem.ImageIndex = 38;
            this.filePageSetupBarItem.ImageList = this.imageList1;
            this.filePageSetupBarItem.Text = "Page Setup";
            // 
            // filePrintBarItem
            // 
            this.filePrintBarItem.CategoryIndex = 0;
            this.filePrintBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePrintBarItem.ID = "Print";
            this.filePrintBarItem.ImageIndex = 39;
            this.filePrintBarItem.ImageList = this.imageList1;
            this.filePrintBarItem.Text = "Print";
            // 
            // fileExitBarItem
            // 
            this.fileExitBarItem.CategoryIndex = 0;
            this.fileExitBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileExitBarItem.ID = "Exit";
            this.fileExitBarItem.Text = "Exit";
            // 
            // viewParentBarItem
            // 
            this.viewParentBarItem.CategoryIndex = 0;
            this.viewParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewParentBarItem.ID = "View";
            this.viewParentBarItem.Text = "View";
            // 
            // projectParentBarItem
            // 
            this.projectParentBarItem.CategoryIndex = 0;
            this.projectParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectParentBarItem.ID = "Project_1";
            this.projectParentBarItem.Text = "Project";
            // 
            // buildParentBarItem
            // 
            this.buildParentBarItem.CategoryIndex = 0;
            this.buildParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildParentBarItem.ID = "Build";
            this.buildParentBarItem.Text = "Build";
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.HostControl = this;
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.Office2007MdiChildForm = true;
            this.dockingManager1.PersistState = true;
            this.dockingManager1.ThemesEnabled = true;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            // 
            // statusBarAdv1
            // 
            this.statusBarAdv1.BorderColor = System.Drawing.Color.Black;
            this.statusBarAdv1.Controls.Add(this.statusBarAdvPanel1);
            this.statusBarAdv1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv1.Location = new System.Drawing.Point(0, 704);
            this.statusBarAdv1.Name = "statusBarAdv1";
            this.statusBarAdv1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv1.Size = new System.Drawing.Size(1016, 30);
            this.statusBarAdv1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv1.TabIndex = 4;
            this.statusBarAdv1.ThemesEnabled = true;
            // 
            // statusBarAdvPanel1
            // 
            this.statusBarAdvPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.statusBarAdvPanel1.BorderColor = System.Drawing.Color.Black;
            this.statusBarAdvPanel1.Controls.Add(this.label1);
            this.statusBarAdvPanel1.Location = new System.Drawing.Point(0, 2);
            this.statusBarAdvPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel1.Name = "statusBarAdvPanel1";
            this.statusBarAdvPanel1.Size = new System.Drawing.Size(1006, 22);
            this.statusBarAdvPanel1.TabIndex = 0;
            this.statusBarAdvPanel1.Text = null;
            this.statusBarAdvPanel1.ThemesEnabled = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSDemoShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.statusBarAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VSDemoShellForm";
            this.Text = "VSDEMO SHELL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).EndInit();
            this.statusBarAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).EndInit();
            this.statusBarAdvPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        internal Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv1;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel1;
        private System.Windows.Forms.Label label1;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fileParentBarItem;
        internal System.Windows.Forms.ImageList imageList1;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fileNewParentBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileNewProjectBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileNewWebsiteBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileNewFileBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fileOpenParentBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileOpenProjectBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileOpenWebsiteBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileOpenFileBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fileAddParentBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileAddNewProjectBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileAddNewFileBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileAddExistingProjectBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileAddExistingFileBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileCloseBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileCloseSolutionBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileSaveBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileSaveAllBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileExportTemplateBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem filePageSetupBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem filePrintBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileExitBarItem;
        private System.Windows.Forms.ImageList ImageList2;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem viewParentBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem projectParentBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem buildParentBarItem;
    }
}

