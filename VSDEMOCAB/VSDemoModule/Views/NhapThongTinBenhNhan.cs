using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;

namespace VSDemoModule.Views
{
    [SmartPart]
    public partial class NhapThongTinBenhNhan : UserControl
    {
        public NhapThongTinBenhNhan()
        {
            InitializeComponent();
        }

    
        private VSDemoModule.WorkItems.VSDemoController controller;

        [CreateNew]
        public VSDemoModule.WorkItems.VSDemoController Controller
        {
            set
            {
                controller = value;
            }
        }

        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

    }
}
