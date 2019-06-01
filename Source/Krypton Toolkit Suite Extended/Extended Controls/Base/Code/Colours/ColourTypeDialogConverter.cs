﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.400/blob/master/LICENSE
 *
 */
#endregion

using System.ComponentModel;
using System.Drawing;

namespace ExtendedControls.Base.Code.Colours
{
    public class ColourTypeDialogConverter : ColorConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return false;
        }
    }
}