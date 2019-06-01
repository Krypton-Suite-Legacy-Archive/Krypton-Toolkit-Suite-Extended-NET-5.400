﻿#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion

using System.Drawing;

namespace NaviSuite.Main.Colours
{
    public class NaviColourTableOff7Blue : NaviColourTable
    {
        // General colors 
        public override Color Border { get { return Color.FromArgb(101, 147, 207); } }
        public override Color BorderInner { get { return Color.FromArgb(255, 255, 255); } }
        public override Color Text { get { return Color.FromArgb(21, 66, 139); } }
        public override Color ShapesFront { get { return Color.FromArgb(86, 125, 177); } }
        public override Color Background { get { return Color.FromArgb(255, 255, 255); } }

        // Designtime only
        public override Color DashedLineColor { get { return Color.FromArgb(101, 147, 207); } }

        // NaviBandCollapsed
        public override Color BandCollapsedBgColor1 { get { return Color.FromArgb(213, 228, 242); } }
        public override Color BandCollapsedBgColor2 { get { return Color.FromArgb(209, 214, 220); } }
        public override Color BandCollapsedHoveredColor1 { get { return Color.FromArgb(255, 231, 162); } }
        public override Color BandCollapsedClickedColor1 { get { return Color.FromArgb(251, 140, 60); } }

        // NaviBand Popup
        public override Color PopupBandBackground1 { get { return Color.FromArgb(227, 239, 255); } }
        public override Color PopupBandBackground2 { get { return Color.FromArgb(227, 239, 255); } }

        // NaviBar header
        public override Color HeaderColor1 { get { return Color.FromArgb(175, 210, 255); } }
        public override Color HeaderColor2 { get { return Color.FromArgb(227, 239, 255); } }
        public override Color HeaderText { get { return Color.FromArgb(21, 66, 139); } }

        // NaviBar Overflowpanel
        public override Color OverflowColor1 { get { return Color.FromArgb(209, 214, 220); } }
        public override Color OverflowColor2 { get { return Color.FromArgb(209, 214, 220); } }

        // NaviButton Normal
        public override Color ButtonNormalColor1 { get { return Color.FromArgb(192, 219, 255); } } // Light
        public override Color ButtonNormalColor2 { get { return Color.FromArgb(173, 209, 255); } } // Dark
        public override Color ButtonNormalColor3 { get { return Color.FromArgb(196, 221, 255); } } // Hightlight dark
        public override Color ButtonNormalColor4 { get { return Color.FromArgb(227, 239, 255); } } // Highlight light

        // NaviButton hovered
        public override Color ButtonHoveredColor1 { get { return Color.FromArgb(255, 230, 159); } }
        public override Color ButtonHoveredColor2 { get { return Color.FromArgb(255, 215, 103); } }
        public override Color ButtonHoveredColor3 { get { return Color.FromArgb(255, 233, 168); } }
        public override Color ButtonHoveredColor4 { get { return Color.FromArgb(255, 254, 228); } }

        // NaviButton active
        public override Color ButtonActiveColor1 { get { return Color.FromArgb(254, 225, 122); } }
        public override Color ButtonActiveColor2 { get { return Color.FromArgb(255, 171, 63); } }
        public override Color ButtonActiveColor3 { get { return Color.FromArgb(255, 188, 111); } }
        public override Color ButtonActiveColor4 { get { return Color.FromArgb(255, 217, 170); } }

        // NaviButton clicked
        public override Color ButtonClickedColor1 { get { return Color.FromArgb(255, 211, 101); } }
        public override Color ButtonClickedColor2 { get { return Color.FromArgb(251, 140, 60); } }
        public override Color ButtonClickedColor3 { get { return Color.FromArgb(255, 173, 67); } }
        public override Color ButtonClickedColor4 { get { return Color.FromArgb(255, 189, 105); } }

        // NaviClientArea
        public override Color NaviClientareaBgColor1 { get { return Color.FromArgb(209, 214, 220); } }
        public override Color NaviClientareaBgColor2 { get { return Color.FromArgb(231, 235, 239); } }

        // NaviCollapseButton Normal
        public override Color CollapseButtonNormalColor1 { get { return Color.FromArgb(227, 239, 255); } }
        public override Color CollapseButtonNormalColor2 { get { return Color.FromArgb(175, 210, 255); } }

        // NaviCollapseButton Hovered
        public override Color CollapseButtonHoveredColor1 { get { return Color.FromArgb(248, 194, 94); } } // Dark
        public override Color CollapseButtonHoveredColor2 { get { return Color.FromArgb(255, 255, 220); } } // Light

        // NaviCollapseButton Clicked
        public override Color CollapseButtonClickedColor1 { get { return Color.FromArgb(232, 127, 8); } }
        public override Color CollapseButtonClickedColor2 { get { return Color.FromArgb(247, 217, 121); } }

        // NaviCollapseButton
        public override Color ButtonCollapseFront { get { return Color.FromArgb(255, 248, 203); } }
        public override Color ButtonCollapseActive { get { return Color.FromArgb(255, 248, 203); } }

        // NaviGroup normal
        public override Color GroupColor1 { get { return Color.FromArgb(226, 238, 255); } }
        public override Color GroupColor2 { get { return Color.FromArgb(214, 232, 255); } }

        // NaviGroup hovered
        public override Color GroupHoveredColor1 { get { return Color.FromArgb(255, 255, 255); } }
        public override Color GroupHoveredColor2 { get { return Color.FromArgb(227, 239, 255); } }
        public override Color GroupBorderLight { get { return Color.FromArgb(173, 209, 255); } }

        // Navigroup expanded
        public override Color GroupExpandedColor1 { get { return Color.FromArgb(37, 37, 37); } }
        public override Color GroupExpandedColor2 { get { return Color.FromArgb(98, 98, 98); } }

        // Splitter
        public override Color SplitterColor1 { get { return Color.FromArgb(182, 214, 255); } }
        public override Color SplitterColor2 { get { return Color.FromArgb(255, 255, 255); } }
        public override Color SplitterColor3 { get { return Color.FromArgb(255, 255, 255); } }
    }
}