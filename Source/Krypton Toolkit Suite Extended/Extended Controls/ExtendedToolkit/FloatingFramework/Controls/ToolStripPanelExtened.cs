﻿#region License
/*
     Copyright(c) 2010 2011 2012 ÌÆÈñ(also tr0217)
     mailto:tr0217@163.com
     The earliest release time: 2010-12-08
     Last modification time:2010-12-20
     Accompanying files of necessity:
            *

     This file and the accompanying files of this project may be freely used provided the following
     conditions are met:
            * This copyright statement is not removed or modified.
            * The code is not sold in uncompiled form.  (Release as a compiled binary which is part
              of an application is fine)
            * The design, code, or compiled binaries are not "Re-branded".
        
     Optional:
            * Redistributions in binary form must reproduce the above copyright notice.
            * I receive a fully licensed copy of the product (regardless of whether the product is
              is free, shrinkwrap, or commercial).  This is optional, though if you release products
              which use code I've contributed to, I would appreciate a fully licensed copy.

     In addition, you may not:
            * Publicly release modified versions of the code or publicly release works derived from
              the code without express written authorization.

     NO WARRANTY:
            THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
            ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
            WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
            IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
            INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
            NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
            OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
            WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
            ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY
            OF SUCH DAMAGE.
*/
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.FloatingFramework.Controls
{
    [Serializable]
    public class ToolStripPanelExtened : ToolStripPanel
    {
        #region Variables
        private Rectangle _activeRectangle;
        #endregion

        #region Property
        public Rectangle ActiveRectangle { get => _activeRectangle; }
        #endregion

        #region Overrides
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            _activeRectangle = ClientRectangle;

            if (_activeRectangle.Width < 23 || _activeRectangle.Height < 23)
            {
                if (Orientation == Orientation.Horizontal)
                {
                    _activeRectangle.Height = 23;
                }
                else
                {
                    _activeRectangle.Width = 23;
                }

                switch (base.Dock)
                {
                    case DockStyle.Bottom:
                        _activeRectangle.Y -= 23;
                        break;
                    case DockStyle.Left:
                        _activeRectangle.X += 23;
                        break;
                    case DockStyle.Right:
                        _activeRectangle.X -= 23;
                        break;
                    default:
                        break;
                }
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            ToolStrip toolStrip = e.Control as ToolStrip;

            if (toolStrip != null)
            {
                if (Orientation == Orientation.Horizontal)
                {
                    toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
                }
                else
                {
                    toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                }
            }
        }
        #endregion
    }
}