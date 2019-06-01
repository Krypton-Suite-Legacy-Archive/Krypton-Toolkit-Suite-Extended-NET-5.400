﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.400/blob/master/LICENSE
 *
 */
#endregion

using System.Collections;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Wizard.Classes
{
    public class InfoPageDesigner : ParentControlDesigner
    {
        protected override bool DrawGrid { get { return false; } }

        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);

            if (properties.Contains("BackgroundImage") == true)
            {
                properties.Remove("BackgroundImage");
            }
        }
    }
}