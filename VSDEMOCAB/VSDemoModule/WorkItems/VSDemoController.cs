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
using Microsoft.Practices.CompositeUI.Utility;

namespace VSDemoModule.WorkItems
{
    public class VSDemoController : Controller
    {
        public new VSDemoWorkItem WorkItem
        {
            get
            {
                return base.WorkItem as VSDemoWorkItem;
            }
        }
    }
}
