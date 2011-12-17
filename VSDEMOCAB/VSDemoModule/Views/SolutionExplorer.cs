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

using Syncfusion.Windows.Forms.Tools;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.ObjectBuilder;

namespace VSDemoModule
{
    /// <summary>
    /// It is the solutionexplorer window of VSDemo_CAB
    /// </summary>
    [SmartPart]
    public partial class SolutionExplorer : UserControl
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

        public SolutionExplorer()
        {
            InitializeComponent();
            this.xpToolBar1.BeginGroupAt(this.Showallfiles);
            this.xpToolBar1.BeginGroupAt(this.Viewcode);
            this.treeViewAdv1.Text = "TreeView";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AddTreeItems();
        }

        private void AddTreeItems()
        {
            TreeNodeAdv parent = new TreeNodeAdv("Solution 'SampleSolution'(1 project)");
            parent.LeftImageIndices = new int[] { 31 };
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.TreeView].Add(parent);

            TreeNodeAdv Node = new TreeNodeAdv("SampleProject");
            Node.LeftImageIndices = new int[] { 61 };
            TreeNodeAdv childref = new TreeNodeAdv("References");
            childref.LeftImageIndices = new int[] { 62 };
            TreeNodeAdv childprop = new TreeNodeAdv("Properties");
            TreeNodeAdv childform = new TreeNodeAdv("SampleForm");
            TreeNodeAdv childclass = new TreeNodeAdv("SampleClass");
            childform.LeftImageIndices = new int[] { 5 };
            childclass.LeftImageIndices = new int[] { 63 };
            childprop.LeftImageIndices = new int[] { 62 };
            Node.Nodes.AddRange(new TreeNodeAdv[] { childprop, childref, childform, childclass });
            this.controller.WorkItem.UIExtensionSites[VSDemoCommon.UIElements.TreeView].Add(Node);            
        }
    }
}
