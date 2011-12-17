using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MT.WindowsUI.NavigationPane;

namespace NavigationPaneDemo
{
    public partial class NhapThongTinBenhNhan : UserControl
    {
        public NhapThongTinBenhNhan()
        {
            InitializeComponent();
        }
        NavigateBar navigateBar;
        NavigateBarColorTable colorTable;
        public NhapThongTinBenhNhan(NavigateBar tNavigatebar)
        {
            InitializeComponent();

            navigateBar = tNavigatebar;

            
            // Property Grid
            colorTable = navigateBar.NavigateBarColorTable;
            
        }

    }
}
