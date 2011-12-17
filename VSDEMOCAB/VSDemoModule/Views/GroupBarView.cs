#region Copyright Syncfusion Inc. 2001 - 2010
// Copyright Syncfusion Inc. 2001 - 2010. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace VSDemoModule.Views
{
    [SmartPart]
    public partial class GroupBarView : UserControl
    {
        private VSDemoModule.WorkItems.VSDemoController controller;

        [CreateNew]
        public VSDemoModule.WorkItems.VSDemoController Controller
        {
            set
            {
                controller = value;
            }
        }


        public GroupBarView()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AddMenus();
            GroupBarWorkspace.VisualStyle = VisualStyle.Office2007;
            
        }

        private void AddMenus()
        {
            BarItem bItem;

            #region ViewMenu
            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Code");
            bItem.Shortcut = Shortcut.F7;
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 4;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnBarItemClick"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Designer");
            bItem.Shortcut = Shortcut.ShiftF7;
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 4;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnBarItemClick"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Object Browser");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 42;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnShowObjectBrowser"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Class View");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 38;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnShowClassView"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Output Window");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 32;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnShowOutputWindow"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Error List");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 34;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnShowErrorList"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Task List");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 30;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnShowTaskList"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("ToolBox");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 0;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
            this.controller.WorkItem.Commands["OnShowToolBox"].AddInvoker(bItem, "Click");

            bItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem("Solution Explorer");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 31;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.View].Add(bItem);
          //  this.controller.WorkItem.Commands["OnShowSolutionExplorer"].AddInvoker(bItem, "Click");
            this.controller.WorkItem.Commands["OnShowNhapThongTinBenhNhan"].AddInvoker(bItem, "Click");
            #endregion

            #region Project Menu Add
            bItem = new BarItem("Add Windows Form");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 5;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnAddWindowsForm"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Add UserControl");
            this.controller.WorkItem.Commands["OnAddWindowsForm"].AddInvoker(bItem, "Click");
            
            bItem = new BarItem("Add Component");
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnAddComponent"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Add Class");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 2;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnAddCode"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Add NewItem");
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnAddNewItem"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Add Existing Item");
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnAddExistingItem"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Show All Files");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 7;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnShowAllFiles"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Add Reference");
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnAddReference"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Project Properties");
            bItem.ImageList = this.dockingImageList;
            bItem.ImageIndex = 8;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Project].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnShowProjectProperties"].AddInvoker(bItem, "Click");
            #endregion

            #region Build MenuItems

            bItem = new BarItem("Build Solution");
            bItem.Shortcut = Shortcut.CtrlShiftB;
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Build].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnBuildSolution"].AddInvoker(bItem, "Click");

            bItem = new BarItem("ReBuild Solution");
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Build].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnRebuildSolution"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Clean Solution");
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Build].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnCleanSolution"].AddInvoker(bItem, "Click");

            bItem = new BarItem("Configuration Manager");
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.Build].Add<BarItem>(bItem);
            this.controller.WorkItem.Commands["OnConfigurationManager"].AddInvoker(bItem, "Click");


            #endregion

        }

        #region Commandhandlers

        [CommandHandler("OnAddComponent")]
        public void OnAddComponent(object sender, EventArgs e)
        {
            MessageBox.Show("Adds a Component to the Project");
        }

        [CommandHandler("OnAddNewItem")]
        public void OnAddNewItem(object sender, EventArgs e)
        {
            MessageBox.Show("Adds a New Item to the Project");
        }

        [CommandHandler("OnAddExistingItem")]
        public void OnAddExistingItem(object sender, EventArgs e)
        {
            MessageBox.Show("Adds a New Existing Item to the Project");
        }

        [CommandHandler("OnAddReference")]
        public void OnAddReference(object sender, EventArgs e)
        {
            MessageBox.Show("Adds a Reference to the Project");
        }

        [CommandHandler("OnShowProjectProperties")]
        public void OnShowProjectProperties(object sender, EventArgs e)
        {
            MessageBox.Show("Shows the Project Properties");
        }

        [CommandHandler("OnBuildSolution")]
        public void OnBuildSolution(object sender, EventArgs e)
        {
            MessageBox.Show("Builds the Solution");
        }

        [CommandHandler("OnRebuildSolution")]
        public void OnRebuildSolution(object sender, EventArgs e)
        {
            MessageBox.Show("Rebuild the Solution");
        }

        [CommandHandler("OnCleanSolution")]
        public void OnCleanSolution(object sender, EventArgs e)
        {
            MessageBox.Show("Cleans the Solution");
        }

        [CommandHandler("OnConfigurationManager")]
        public void OnConfigurationManager(object sender, EventArgs e)
        {
            MessageBox.Show("Shows the configuration manager");
        }

        [CommandHandler("OnExitClick")]
        public void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [CommandHandler("OnAboutClick")]
        public void OnAboutSyncfusion(object sender, EventArgs e)
        {
            new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies()).ShowDialog();
        }
        #endregion

    }
}
