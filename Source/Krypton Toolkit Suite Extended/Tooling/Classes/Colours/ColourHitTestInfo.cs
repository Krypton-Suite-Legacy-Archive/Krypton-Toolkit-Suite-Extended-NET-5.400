﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.400/blob/master/LICENSE
 *
 */
#endregion

using Core.Enumerations;
using System.Drawing;

namespace Core.Classes.Colours
{
    public class ColourHitTestInfo
    {
        #region Properties

        public Color Colour { get; set; }

        public int Index { get; set; }

        public ColourSource Source { get; set; }

        #endregion
    }
}