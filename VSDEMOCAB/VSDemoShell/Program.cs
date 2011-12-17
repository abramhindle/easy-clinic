#region Copyright Syncfusion Inc. 2001 - 2010
// Copyright Syncfusion Inc. 2001 - 2010. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.CAB.WinForms;

namespace VSDemoShell
{
    class Program : SyncFormShellApplication<VSDemoRootWorkItem, VSDemoShellForm>
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Program().Run();
        }

        protected override void AfterShellCreated()
        {
            base.AfterShellCreated();

            RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.MainMenu, Shell.bar1);
            RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.MainToolBar, Shell.bar2);
            AddFileMenu();
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.MainMenu].Add(Shell.viewParentBarItem);
            RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.View, Shell.viewParentBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.MainMenu].Add(Shell.projectParentBarItem);
            RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.Project, Shell.projectParentBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.MainMenu].Add(Shell.buildParentBarItem);
            RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.Build, Shell.buildParentBarItem);
            RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.StatusBar, Shell.statusBarAdv1);
        }

        private void AddFileMenu()
        {
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.MainMenu].Add(Shell.fileParentBarItem);
            this.RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.File, Shell.fileParentBarItem);

            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileNewParentBarItem);
            this.RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.FileNew, Shell.fileNewParentBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileNew].Add(Shell.fileNewProjectBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileNew].Add(Shell.fileNewWebsiteBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileNew].Add(Shell.fileNewFileBarItem);
            this.RootWorkItem.Commands["OnAddWindowsForm"].AddInvoker(this.Shell.fileNewFileBarItem, "Click");
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.MainToolBar].Add(Shell.fileNewParentBarItem);

            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileOpenParentBarItem);
            this.RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.FileOpen, Shell.fileOpenParentBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileOpen].Add(Shell.fileOpenProjectBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileOpen].Add(Shell.fileOpenWebsiteBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileOpen].Add(Shell.fileOpenFileBarItem);

            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileAddParentBarItem);
            this.RootWorkItem.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.FileAdd, Shell.fileAddParentBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileAdd].Add(Shell.fileAddNewProjectBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileAdd].Add(Shell.fileAddNewFileBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileAdd].Add(Shell.fileAddExistingProjectBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.FileAdd].Add(Shell.fileAddExistingFileBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.MainToolBar].Add(Shell.fileAddParentBarItem);

            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileCloseBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileCloseSolutionBarItem);

            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileSaveBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileSaveAllBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.MainToolBar].Add(Shell.fileSaveAllBarItem);

            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.filePageSetupBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.filePrintBarItem);
            this.RootWorkItem.UIExtensionSites[VSDemoCommon.UIElements.File].Add(Shell.fileExitBarItem);
            this.RootWorkItem.Commands["OnExitClick"].AddInvoker(this.Shell.fileExitBarItem, "Click");
        }

    }
}