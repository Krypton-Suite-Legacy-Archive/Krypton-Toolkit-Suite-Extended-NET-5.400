﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControls.Base.Code.ScrollBar.CustomScrollBar
{
    /// <summary>
    /// The scrollbar arrow button states.
    /// </summary>
    internal enum ScrollBarArrowButtonState
    {
        /// <summary>
        /// Indicates the up arrow is in normal state.
        /// </summary>
        UPNORMAL,

        /// <summary>
        /// Indicates the up arrow is in hot state.
        /// </summary>
        UPHOT,

        /// <summary>
        /// Indicates the up arrow is in active state.
        /// </summary>
        UPACTIVE,

        /// <summary>
        /// Indicates the up arrow is in pressed state.
        /// </summary>
        UPPRESSED,

        /// <summary>
        /// Indicates the up arrow is in disabled state.
        /// </summary>
        UPDISABLED,

        /// <summary>
        /// Indicates the down arrow is in normal state.
        /// </summary>
        DOWNNORMAL,

        /// <summary>
        /// Indicates the down arrow is in hot state.
        /// </summary>
        DOWNHOT,

        /// <summary>
        /// Indicates the down arrow is in active state.
        /// </summary>
        DOWNACTIVE,

        /// <summary>
        /// Indicates the down arrow is in pressed state.
        /// </summary>
        DOWNPRESSED,

        /// <summary>
        /// Indicates the down arrow is in disabled state.
        /// </summary>
        DOWNDISABLED
    }
}
