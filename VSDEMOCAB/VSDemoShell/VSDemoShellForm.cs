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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.EventBroker;


using Syncfusion.CAB.WinForms.WorkSpaces;

namespace VSDemoShell
{
    public partial class VSDemoShellForm : Office2007Form 
    {
        private DockableWorkSpace dockWorkspace;
        private TabbedMDIManagerWorkspace tabbedMdiManagerWorkspace;
        private WorkItem rootWorkItem;

        #region Constructors
        public VSDemoShellForm()
        {
            InitializeComponent();
        }

        [InjectionConstructor]
        public VSDemoShellForm(WorkItem workitem, IWorkItemTypeCatalogService workitemTypeCatalog)
            : this()
        {
            this.rootWorkItem = workitem;
            this.dockWorkspace = new DockableWorkSpace(this.dockingManager1, this);
            this.tabbedMdiManagerWorkspace = new TabbedMDIManagerWorkspace(this);
            this.rootWorkItem.Workspaces.Add(dockWorkspace, VSDemoCommon.WorkspaceNames.DockableWorkspace);
            this.rootWorkItem.Workspaces.Add(tabbedMdiManagerWorkspace, VSDemoCommon.WorkspaceNames.TabbedMDIWorkspace);
            AddSplashPanelWorkspace();
        }

        #endregion

        [ServiceDependency]
        public WorkItem RootWorkItem
        {
            set
            {
                rootWorkItem = value;
            }
        }

        #region SplashPanelWorkspace

        /// <summary>
        /// Adds the Splash panel workspace at the start up of the project
        /// </summary>
        private void AddSplashPanelWorkspace()
        {
            Syncfusion.CAB.WinForms.WorkSpaces.SplashPanelWorkspace spWorkspace = new Syncfusion.CAB.WinForms.WorkSpaces.SplashPanelWorkspace();
            spWorkspace.Name = VSDemoCommon.WorkspaceNames.SplashPanelWorkspace;
            spWorkspace.Size = new System.Drawing.Size(592, 152);
            spWorkspace.TabIndex = 5;
            spWorkspace.Text = VSDemoCommon.WorkspaceNames.SplashPanelWorkspace;
            rootWorkItem.Workspaces.Add(spWorkspace, VSDemoCommon.WorkspaceNames.SplashPanelWorkspace);
            Syncfusion.CAB.WinForms.SmartPartInfos.SplashPanelSmartPartInfo info = new Syncfusion.CAB.WinForms.SmartPartInfos.SplashPanelSmartPartInfo();
            info.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            info.AnimationSpeed = 25;
            info.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center;
            info.TimerInterval = 1500;
            info.SlideStyle = Syncfusion.Windows.Forms.Tools.SlideStyle.FadeIn;
            rootWorkItem.Workspaces[VSDemoCommon.WorkspaceNames.SplashPanelWorkspace].Show(rootWorkItem.Items.AddNew<SplashMessageView>(), info);
        }

        #endregion

        #region EventSubscriptions

        [EventSubscription("topic://VSDemo/StatusBarTextUpdate", ThreadOption.UserInterface)]
        public void OnStatusBarText(object sender, DataEventArgs<string> e)
        {
            this.label1.Text = e.Data;
        }

        #endregion

 
    }
}