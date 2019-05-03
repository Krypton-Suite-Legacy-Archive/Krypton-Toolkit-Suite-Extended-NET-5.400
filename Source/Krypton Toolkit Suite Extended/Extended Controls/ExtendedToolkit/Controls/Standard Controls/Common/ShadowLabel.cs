﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    [ToolboxBitmap(typeof(Label)), ToolboxItem(false)]
    public class ShadowLabel : Label
    {

        private Color color;
        private int direction;
        private float softness;
        private int opacity;
        private int shadowDepth;

        public ShadowLabel()
        {
            color = Color.Black;
            direction = 315;
            softness = 2f;
            opacity = 100;
            shadowDepth = 4;
        }

        [Category("Appearance-Extended")]
        [Description("Gets or sets the color of the shadow")]
        [DefaultValue(typeof(Color), "0x000000")]
        public Color Colour
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Invalidate();
            }
        }

        [Category("Appearance-Extended")]
        [Description("Gets or sets the degree of opacity of the shadow")]
        [DefaultValue(100)]
        public int Opacity
        {
            get
            {
                return opacity;
            }
            set
            {
                if (value < 0 || value > 255)
                {
                    throw new ArgumentOutOfRangeException("Opacity",
                      "Opacity must be between 0 and 255");
                }
                opacity = value;
                Invalidate();
            }
        }

        [Category("Appearance-Extended")]
        [Description("Gets or sets how soft the shadow is")]
        [DefaultValue(2f)]
        public float Softness
        {
            get
            {
                return softness;
            }
            set
            {
                if (softness <= 0)
                {
                    throw new ArgumentOutOfRangeException("Softness",
                      "Softness must be greater than 0");
                }
                softness = value;
                Invalidate();
            }
        }

        [Category("Appearance-Extended")]
        [Description("Gets or sets the angle the shadow is cast")]
        [DefaultValue(315)]
        public int Direction
        {
            get
            {
                return direction;
            }
            set
            {
                if (value < 0 || value > 360)
                {
                    throw new ArgumentOutOfRangeException("Direction",
                      "Direction must be between 0 and 360");
                }
                direction = value;
                Invalidate();
            }
        }

        [Category("Appearance-Extended")]
        [Description("Gets or sets the distance between the plane " +
          "of the object casting the shadow and the shadow plane")]
        [DefaultValue(4)]
        public int ShadowDepth
        {
            get
            {
                return shadowDepth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ShadowDepth",
                      "ShadowDepth must be greater than 0");
                }
                shadowDepth = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics screenGraphics = e.Graphics;
            Bitmap shadowBitmap = new Bitmap(Math.Max((int)(Width / softness), 1),
              Math.Max((int)(Height / softness), 1));
            using (Graphics imageGraphics = Graphics.FromImage(shadowBitmap))
            {
                imageGraphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                Matrix transformMatrix = new Matrix();
                transformMatrix.Scale(1 / softness, 1 / softness);
                transformMatrix.Translate((float)(shadowDepth * Math.Cos(direction)),
                  (float)(shadowDepth * Math.Sin(direction)));
                imageGraphics.Transform = transformMatrix;
                imageGraphics.DrawString(Text, Font,
                  new SolidBrush(Color.FromArgb(opacity, color)), 0, 0,
                  StringFormat.GenericTypographic);
            }
            screenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            screenGraphics.DrawImage(shadowBitmap, ClientRectangle, 0, 0,
              shadowBitmap.Width, shadowBitmap.Height, GraphicsUnit.Pixel);
            screenGraphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            screenGraphics.DrawString(Text, Font, new SolidBrush(ForeColor), 0, 0,
              StringFormat.GenericTypographic);

        }
    }
}