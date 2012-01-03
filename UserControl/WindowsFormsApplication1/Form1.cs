using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OVT.CustomControls.CollapsiblePanel collapsiblePanel1;
        public Form1()
        {
            InitializeComponent();

            this.collapsiblePanel1 = new OVT.CustomControls.CollapsiblePanel();
            //
            // collapsiblePanel1
            //
            this.collapsiblePanel1.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel1.HeaderCornersRadius = 5;
            this.collapsiblePanel1.HeaderFont =
        new System.Drawing.Font("Microsoft Sans Serif",
            8.25F, System.Drawing.FontStyle.Bold);
            this.collapsiblePanel1.HeaderImage = null;
            this.collapsiblePanel1.HeaderText = "My Collapsible panel\'s header";
            this.collapsiblePanel1.HeaderTextColor = System.Drawing.Color.Black;
            this.collapsiblePanel1.Location = new System.Drawing.Point(88, 50);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.RoundedCorners = true;
            this.collapsiblePanel1.Size = new System.Drawing.Size(316, 204);
            this.collapsiblePanel1.TabIndex = 0;
            this.collapsiblePanel1.UseAnimation = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 353);
            this.Controls.Add(this.collapsiblePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false); 
        }
    }
}
