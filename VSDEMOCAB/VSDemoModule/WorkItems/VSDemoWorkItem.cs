#region Copyright Syncfusion Inc. 2001 - 2010
// Copyright Syncfusion Inc. 2001 - 2010. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.CAB.WinForms.SmartPartInfos;
using Syncfusion.CAB.WinForms.WorkSpaces;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.SmartParts;
using VSDemoModule.Views;

namespace VSDemoModule.WorkItems
{
    public class VSDemoWorkItem : WorkItem
    {
        [EventPublication("topic://VSDemo/StatusBarTextUpdate", PublicationScope.Global)]
        public event EventHandler<DataEventArgs<string>> UpdateStatusBar;

        DockableWorkSpace dockworkspace;
        TabbedMDIManagerWorkspace tabbedMDIManagerWorkspace;
        ClassView classView;
        SolutionExplorer solutionExplorer;
        NhapThongTinBenhNhan nhapThongTinBenhNhan;
        ErrorList errorList;
        OutputWindow outputWindow;
        TaskList taskList;
        PropertiesWindow propertiesWindow;
        Views.GroupBarView groupBarView;

        #region ShowWorkitem
        /// <summary>
        /// Shows the controls in workspaces
        /// </summary>
        /// <param name="workspace"></param>
        /// <param name="contentWorkspace"></param>
        public void Show(IWorkspace workspace, IWorkspace contentWorkspace)
        {

            DockingSmartPartInfo smartPartInfo;
            dockworkspace = workspace as DockableWorkSpace;
            tabbedMDIManagerWorkspace = contentWorkspace as TabbedMDIManagerWorkspace;

            //Adding TaskList
            taskList = this.Items.AddNew<TaskList>();
            smartPartInfo = new DockingSmartPartInfo();
            smartPartInfo.Title = "Task List";
            smartPartInfo.DockStyle = DockingStyle.Bottom;
            smartPartInfo.Height = 200;
            smartPartInfo.VisualStyle = VisualStyle.Office2007;
            workspace.Show(taskList, smartPartInfo);

            ////Adding Output Window
            outputWindow = this.Items.AddNew<OutputWindow>();
            smartPartInfo = new DockingSmartPartInfo();
            smartPartInfo.Title = "Output Window";
            smartPartInfo.DockStyle = DockingStyle.Tabbed;
            smartPartInfo.ParentName = "TaskList";
            smartPartInfo.VisualStyle = VisualStyle.Office2007;
            workspace.Show(outputWindow, smartPartInfo);

            //Adding Errorlist
            errorList = this.Items.AddNew<ErrorList>();
            smartPartInfo = new DockingSmartPartInfo();
            smartPartInfo.Title = "Error List";
            smartPartInfo.DockStyle = DockingStyle.Tabbed;
            smartPartInfo.ParentName = "TaskList";
            smartPartInfo.Height = 200;
            smartPartInfo.VisualStyle = VisualStyle.Office2007;
            workspace.Show(errorList, smartPartInfo);

            //Adding toolbox
            groupBarView = this.Items.AddNew<Views.GroupBarView>();
            smartPartInfo = new DockingSmartPartInfo();
            smartPartInfo.Title = "ToolBox";
            smartPartInfo.DockStyle = DockingStyle.Left;
            smartPartInfo.VisualStyle = VisualStyle.Office2007;
            workspace.Show(groupBarView, smartPartInfo);
            Views.Toolbox.ToolBoxWorkItem toolBoxWorkItem = this.WorkItems.AddNew<Views.Toolbox.ToolBoxWorkItem>();
            toolBoxWorkItem.ShowToolBox(this.Workspaces[VSDemoCommon.WorkspaceNames.GroupBarWorkspace]);

            //Adding SolutionExplorer
            //solutionExplorer = this.Items.AddNew<SolutionExplorer>();
            nhapThongTinBenhNhan = this.Items.AddNew<NhapThongTinBenhNhan>();
           // this.UIExtensionSites.RegisterSite(VSDemoCommon.UIElements.TreeView, solutionExplorer.treeViewAdv1);          
            smartPartInfo = new DockingSmartPartInfo();
            smartPartInfo.Title = "Solution Explorer";
            smartPartInfo.DockStyle = DockingStyle.Right;
            smartPartInfo.VisualStyle = VisualStyle.Office2007;
           // workspace.Show(solutionExplorer, smartPartInfo);
            workspace.Show(nhapThongTinBenhNhan, smartPartInfo);

            //Adding Properties Window
            /*propertiesWindow = this.Items.AddNew<PropertiesWindow>();
            smartPartInfo = new DockingSmartPartInfo();
            smartPartInfo.Title = "Properties Window";
            smartPartInfo.DockStyle = DockingStyle.Tabbed;
            smartPartInfo.ParentName = "SolutionExplorer";
            smartPartInfo.VisualStyle = VisualStyle.Office2007;
            workspace.Show(propertiesWindow, smartPartInfo);
            
            //Adding ClassView
            classView = this.Items.AddNew<ClassView>();
            smartPartInfo = new DockingSmartPartInfo();
            smartPartInfo.Title = "Class View";
            smartPartInfo.DockStyle = DockingStyle.Tabbed;
            smartPartInfo.VisualStyle = VisualStyle.Office2007;
            smartPartInfo.ParentName = "SolutionExplorer";
            workspace.Show(classView, smartPartInfo);
             */
        }
        
        #endregion

        #region CommandHandlers

        [CommandHandler("OnShowClassView")]
        public void OnShowClassView(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(classView);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        [CommandHandler("OnShowOutputWindow")]
        public void OnShowOutputWindow(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(outputWindow);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        [CommandHandler("OnShowPropertiesWindow")]
        public void OnShowPropertiesWindow(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(propertiesWindow);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        [CommandHandler("OnShowErrorList")]
        public void OnShowErrorList(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(errorList);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        [CommandHandler("OnShowTaskList")]
        public void OnShowTaskList(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(taskList);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        [CommandHandler("OnShowToolBox")]
        public void OnShowToolBox(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(groupBarView);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

      /*  [CommandHandler("OnShowSolutionExplorer")]
        public void OnShowSolutionExplorer(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(solutionExplorer);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        */
        [CommandHandler("OnShowNhapThongTinBenhNhan")]
        public void OnShowNhapThongTinBenhNhan(object sender, EventArgs e)
        {
            try
            {
                dockworkspace.Activate(nhapThongTinBenhNhan);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        int i = 1;
        [CommandHandler("OnAddWindowsForm")]
        public void OnAddWindowsForm(object sender, EventArgs e)
        {
            TabbedMDIManagerSmartPartInfo smartPartInfo = new TabbedMDIManagerSmartPartInfo();
            smartPartInfo.TabStyle = typeof(TabRendererWhidbey);
            smartPartInfo.DropDownButtonVisible = true;
            smartPartInfo.CloseOnMouseMiddleClick = true;
            smartPartInfo.AllowTabGroupCustomizing = true;
            smartPartInfo.ShowCloseButton = true;
            smartPartInfo.CloseButtonVisible = true;
            smartPartInfo.UseIconsInTab = false;
            smartPartInfo.Title = String.Format("Form{0}", i);
            tabbedMDIManagerWorkspace.Show(this.Items.AddNew<Views.Samples.SampleDesigner>(), smartPartInfo);
            OnUpdateStatus(String.Format("Form{0} Added", i));
            i++;
        }

        private void OnUpdateStatus(String data)
        {
            if (UpdateStatusBar != null)
                UpdateStatusBar(this, new DataEventArgs<string>(String.Format(data)));
        }



        #endregion
    }
}
