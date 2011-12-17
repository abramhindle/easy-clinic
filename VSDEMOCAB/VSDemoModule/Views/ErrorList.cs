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

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;

namespace VSDemoModule
{
    /// <summary>
    /// It is the errorlist window of VSDemo_CAB
    /// </summary>
    [SmartPart]
    public partial class ErrorList : UserControl
    {
        #region Members
        public ErrorList()
        {
            InitializeComponent();
            this.xpToolBar1.BeginGroupAt(this.barItem2);
            this.xpToolBar1.BeginGroupAt(this.barItem3);
        }        

        private void barItem2_Click(object sender, EventArgs e)
        {            
            listView1.Items[0].SubItems[0].Text = "No Warnings";
            listView1.Items[0].SubItems[1].Text = "";
            listView1.Items[0].SubItems[2].Text = "";
            listView1.Items[0].SubItems[3].Text = "";
            listView1.Items[0].SubItems[4].Text = "";
        }

        private void barItem3_Click(object sender, EventArgs e)
        {        
            listView1.Items[0].SubItems[0].Text = "No Messages";
            listView1.Items[0].SubItems[1].Text = "";
            listView1.Items[0].SubItems[2].Text = "";
            listView1.Items[0].SubItems[3].Text = "";
            listView1.Items[0].SubItems[4].Text = "";
        }

        private void barItem1_Click(object sender, EventArgs e)
        {
            listView1.Items[0].SubItems[0].Text = "1 ;expected";
            listView1.Items[0].SubItems[1].Text = "SampleClass.cs";
            listView1.Items[0].SubItems[2].Text = "15";
            listView1.Items[0].SubItems[3].Text = "10";
            listView1.Items[0].SubItems[4].Text = "SampleProject";
        }
        #endregion
    }
}
