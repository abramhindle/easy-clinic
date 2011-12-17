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
using Microsoft.Practices.ObjectBuilder;

namespace VSDemoModule
{
    public class VSDemoModuleInit : ModuleInit
    {

        private WorkItem parentWorkItem;

        [InjectionConstructor]
        public VSDemoModuleInit([ServiceDependency] WorkItem workItem)
        {
            this.parentWorkItem = workItem;
        }

        public override void Load()
        {
            base.Load();
            WorkItems.VSDemoWorkItem vsDemoWorkItem = this.parentWorkItem.WorkItems.AddNew<WorkItems.VSDemoWorkItem>();
            this.parentWorkItem.Workspaces.Add(new Views.GroupBarView().GroupBarWorkspace, VSDemoCommon.WorkspaceNames.GroupBarWorkspace);
            vsDemoWorkItem.Show(this.parentWorkItem.Workspaces[VSDemoCommon.WorkspaceNames.DockableWorkspace], this.parentWorkItem.Workspaces[VSDemoCommon.WorkspaceNames.TabbedMDIWorkspace]);
        }


    }
}
