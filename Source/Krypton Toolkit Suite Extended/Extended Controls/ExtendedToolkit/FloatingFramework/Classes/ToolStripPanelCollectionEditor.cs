﻿#region License
/*
    Copyright(c) 2010 2011 2012 ÌÆÈñ(also tr0217)
     mailto:tr0217@163.com
     The earliest release time: 2010-12-20
     Last modification time:
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

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.FloatingFramework.Controls;
using ExtendedControls.ExtendedToolkit.FloatingFramework.UX;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.FloatingFramework.Classes
{
    internal class ToolStripPanelCollectionEditor : UITypeEditor
    {
        #region Overrides
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return base.GetEditStyle(context);
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService service = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

            FloatableToolStrip floatableToolStrip = context.Instance as FloatableToolStrip;

            ExistingComponentChooser ecc = new ExistingComponentChooser(floatableToolStrip.ToolStripPanelExtenedList);

            ecc.Text = "ToolStripPanelCollectionEditor";

            if (floatableToolStrip.OriginalParent != null)
            {
                if (floatableToolStrip.OriginalParent is KryptonForm)
                {
                    ecc.SourceComponentContainer = floatableToolStrip.OriginalParent;
                }
                else
                {
                    ecc.SourceComponentContainer = floatableToolStrip.OriginalParent.Parent;
                }
            }

            if (service != null)
            {
                if (service.ShowDialog(ecc) == DialogResult.OK)
                {
                    return ecc.SelectedComponents;
                }
            }

            return floatableToolStrip.ToolStripPanelExtenedList;
        }
        #endregion
    }
}