﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.400/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    public class CircularPictureBox : PictureBox
    {
        public CircularPictureBox()
        {
            BackColor = SystemColors.Control;
        }

        protected override void OnResize(EventArgs e)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));

                Region = new Region(graphicsPath);
            }

            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddEllipse(0, 0, Width - 1, Height - 1);

                Region = new Region(graphicsPath);

                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                pe.Graphics.DrawEllipse(new Pen(new SolidBrush(BackColor), 1), 0, 0, Width - 1, Height - 1);
            }

            base.OnPaint(pe);
        }
    }
}