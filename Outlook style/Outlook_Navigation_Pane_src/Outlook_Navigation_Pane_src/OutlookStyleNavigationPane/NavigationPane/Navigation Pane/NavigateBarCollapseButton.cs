/*
 * Project	    : Outlook 2003 Style Navigation Pane
 *
 * Author       : Muhammed ŞAHİN
 * eMail        : muhammed.sahin@gmail.com
 *
 * Description  : NavigateBar collapse button
 *                Using caption and context text 
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace MT.WindowsUI.NavigationPane
{

    #region Class : NavigateBarCollapseButton

    /// <summary>
    /// NavigateBar collapse button
    /// </summary>
    class NavigateBarCollapseButton : UserControl
    {

        #region Properties

        string toolTipText = "";
        public string ToolTipText
        {
            get { return toolTipText; }
            set { toolTipText = value; }
        }

        bool isExpandArrow = true;
        public bool IsExpandArrow
        {
            get { return isExpandArrow; }
            set
            {
                isExpandArrow = value;
                Invalidate();
            }
        }

        override protected CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT 
                return cp;
            }
        }
        #endregion

        NavigateBar navigateBar;
        static ToolTip toolTip = new ToolTip();
        PaintType paintType = PaintType.Normal;

        #region Constructor Method

        public NavigateBarCollapseButton(NavigateBar tNavigateBar)
        {

            this.Size = new Size(14, 14);
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            navigateBar = tNavigateBar;
        }

        #endregion

        #region Overrided Methods
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            toolTip.SetToolTip(this, toolTipText);
            paintType = PaintType.MouseOver;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            toolTip.RemoveAll();
            base.OnMouseLeave(e);
            paintType = PaintType.Normal;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button != MouseButtons.Left)
                return;

            paintType = PaintType.Selected;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button != MouseButtons.Left)
                return;

            paintType = PaintType.MouseOver;
            this.Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            PaintItem(e.Graphics);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Space)
            {
                this.OnClick(EventArgs.Empty);
            }
        }
        #endregion

        #region Other Methods
        void PaintItem(Graphics g)
        {

            if (paintType == PaintType.Selected || paintType == PaintType.MouseOver)
                NavigateBarHelper.PaintGradientBack(this, g, navigateBar.NavigateBarColorTable, paintType);

            // Draw Arrow Lines

            Pen linePen = new Pen(navigateBar.NavigateBarColorTable.CaptionTextColor);
            int halfHeight = this.Height / 2;

            if (this.navigateBar.RightToLeft == RightToLeft.Yes)
            {
                if (!isExpandArrow)
                {
                    //
                    g.DrawLine(linePen, new Point(4, 4), new Point(7, halfHeight));
                    g.DrawLine(linePen, new Point(4, Width - 4), new Point(7, halfHeight));
                    //
                    g.DrawLine(linePen, new Point(8, 4), new Point(11, halfHeight));
                    g.DrawLine(linePen, new Point(8, Width - 4), new Point(11, halfHeight));
                }
                else
                {
                    //
                    g.DrawLine(linePen, new Point(4, halfHeight), new Point(7, 4));
                    g.DrawLine(linePen, new Point(4, halfHeight), new Point(7, Width - 4));
                    //
                    g.DrawLine(linePen, new Point(8, halfHeight), new Point(11, 4));
                    g.DrawLine(linePen, new Point(8, halfHeight), new Point(11, Width - 4));
                }
            }
            else
            {
                if (isExpandArrow)
                {
                    //
                    g.DrawLine(linePen, new Point(4, 4), new Point(7, halfHeight));
                    g.DrawLine(linePen, new Point(4, Width - 4), new Point(7, halfHeight));
                    //
                    g.DrawLine(linePen, new Point(8, 4), new Point(11, halfHeight));
                    g.DrawLine(linePen, new Point(8, Width - 4), new Point(11, halfHeight));
                }
                else
                {
                    //
                    g.DrawLine(linePen, new Point(4, halfHeight), new Point(7, 4));
                    g.DrawLine(linePen, new Point(4, halfHeight), new Point(7, Width - 4));
                    //
                    g.DrawLine(linePen, new Point(8, halfHeight), new Point(11, 4));
                    g.DrawLine(linePen, new Point(8, halfHeight), new Point(11, Width - 4));
                }

            }

        }
        #endregion

    }
    #endregion
}
