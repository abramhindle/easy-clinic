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
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;

namespace VSDemoModule.Views.Toolbox
{
    public class ToolBoxWorkItem : WorkItem
    {
        public void ShowToolBox(IWorkspace barWorkspace)
        {
            Syncfusion.CAB.WinForms.SmartPartInfos.GroupBarSmartPartInfo gpSmartPartInfo;

            gpSmartPartInfo = new Syncfusion.CAB.WinForms.SmartPartInfos.GroupBarSmartPartInfo();
            gpSmartPartInfo.BarDisplayText = "Windows Form Controls";
            barWorkspace.Show(this.Items.AddNew<WindowsFormsTab>(), gpSmartPartInfo);
            gpSmartPartInfo = new Syncfusion.CAB.WinForms.SmartPartInfos.GroupBarSmartPartInfo();
            gpSmartPartInfo.BarDisplayText = "Components";
            barWorkspace.Show(this.Items.AddNew<ComponentsTab>(), gpSmartPartInfo);
            gpSmartPartInfo = new Syncfusion.CAB.WinForms.SmartPartInfos.GroupBarSmartPartInfo();
            gpSmartPartInfo.BarDisplayText = "Syncfusion Controls";
            barWorkspace.Show(this.Items.AddNew<SyncfusionTab>(), gpSmartPartInfo);
        }
    }
}
