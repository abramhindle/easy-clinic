using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MT.WindowsUI.NavigationPane;

namespace NavigationPaneDemo
{
    public partial class TestMDIChildForm : Form
    {
        NavigateBar navigationPane1;
        NavigateBar navigationPane2;
        NavigateBar navigationPane3;

        public TestMDIChildForm()
        {
            InitializeComponent();

            // 1
            navigationPane1 = new NavigateBar();
            navigationPane1.Size = new Size(150, 400);
            navigationPane1.Location = new Point(20, 20);
            navigationPane1.NavigateBarButtons.Add(new NavigateBarButton("Muhammed", Properties.Resources.Diary24, new RichTextBox()));
            navigationPane1.NavigateBarButtons.Add(new NavigateBarButton("Şahin"));
            navigationPane1.NavigateBarButtons.Add(new NavigateBarButton("Türkiye"));
            navigationPane1.NavigateBarButtons.Add(new NavigateBarButton("İstanbul"));
            navigationPane1.NavigateBarButtons.Add(new NavigateBarButton("Avrupa"));
            navigationPane1.NavigateBarButtons.Add(new NavigateBarButton("Yakası"));
            navigationPane1.NavigateBarColorTable = NavigateBarColorTable.SystemColor;
            navigationPane1.IsShowCollapsibleScreen = true;
            navigationPane1.CollapsedScreenWidth = 140;

            Controls.Add(navigationPane1);

            // 2
            navigationPane2 = new NavigateBar();
            navigationPane2.Size = new Size(150, 400);
            navigationPane2.Location = new Point(200, 20);
            navigationPane2.NavigateBarDisplayedButtonCount = 4;
            navigationPane2.NavigateBarButtons.Add(new NavigateBarButton("Karabük"));
            navigationPane2.NavigateBarButtons.Add(new NavigateBarButton("İstanbul"));
            navigationPane2.NavigateBarButtons.Add(new NavigateBarButton("Ankara"));
            navigationPane2.NavigateBarButtons.Add(new NavigateBarButton("İzmir"));
            navigationPane2.NavigateBarButtons.Add(new NavigateBarButton("Kastamonu"));
            navigationPane2.NavigateBarColorTable = NavigateBarColorTable.Office2003Blue;
            navigationPane2.ChangeCollapseMode(true);

            Controls.Add(navigationPane2);

            // 3
            navigationPane3 = new NavigateBar();
            navigationPane3.Size = new Size(150, 400);
            navigationPane3.Location = new Point(380, 20);
            navigationPane3.NavigateBarButtons.Add(new NavigateBarButton("Visual C#"));
            navigationPane3.NavigateBarButtons.Add(new NavigateBarButton("Visual FoxPro"));
            navigationPane3.NavigateBarButtons.Add(new NavigateBarButton("Sql Server"));
            navigationPane3.NavigateBarButtons.Add(new NavigateBarButton("Oracle"));
            navigationPane3.NavigateBarButtons.Add(new NavigateBarButton("ADO.NET"));
            navigationPane3.NavigateBarDisplayedButtonCount = 2;
            navigationPane3.NavigateBarColorTable = NavigateBarColorTable.Office2007Blue;

            Controls.Add(navigationPane3);

        }
    }
}