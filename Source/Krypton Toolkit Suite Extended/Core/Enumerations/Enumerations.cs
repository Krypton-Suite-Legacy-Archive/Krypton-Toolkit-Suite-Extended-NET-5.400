﻿namespace KryptonToolkitSuiteExtendedCore
{
    public enum BlinkState
    {
        NormalBlink = 0,
        SoftBlink = 1
    }

    public enum ColourComponent
    {
        HUE,
        SATURATION,
        BRIGHTESS,
        RED,
        GREEN,
        BLUE
    }

    public enum SupportedExplorerTypes
    {
        FILE,
        FOLDER
    }

    public enum DevelopmentState
    {
        PREALPHA,
        ALPHA,
        BETA,
        RTM,
        CURRENT,
        EOL
    }

    public enum PaletteFileEditorStatusIndicator
    {
        CREATENEWFILE,
        CHANGEZOOMLEVEL,
        READY,
        OPENFILE,
        SAVEFILE
    }

    /// <summary>
    /// Text alignment options.
    /// </summary>
    public enum TextAlignment
    {
        /// <summary>
        /// Align text to the left.
        /// </summary>
        LEFT = 1,
        /// <summary>
        /// Align text to the right.
        /// </summary>
        RIGHT = 2,
        /// <summary>
        /// Centre the text.
        /// </summary>
        CENTRE = 3,
        /// <summary>
        /// Justify the text.
        /// </summary>
        JUSTIFY = 4
    }

    public enum RectangleEdgeFilter
    {
        NONE = 0,
        TOPLEFT = 1,
        TOPRIGHT = 2,
        BOTTOMLEFT = 4,
        BOTTOMRIGHT = 8,
        ALL = TOPLEFT | TOPRIGHT | BOTTOMLEFT | BOTTOMRIGHT
    }

    #region Scrollbars
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

    /// <summary>
    /// Enum for the scrollbar orientation.
    /// </summary>
    public enum ScrollBarOrientation
    {
        /// <summary>
        /// Indicates a horizontal scrollbar.
        /// </summary>
        HORIZONTAL,

        /// <summary>
        /// Indicates a vertical scrollbar.
        /// </summary>
        VERTICAL
    }

    /// <summary>
    /// The scrollbar states.
    /// </summary>
    internal enum ScrollBarState
    {
        /// <summary>
        /// Indicates a normal scrollbar state.
        /// </summary>
        NORMAL,

        /// <summary>
        /// Indicates a hot scrollbar state.
        /// </summary>
        HOT,

        /// <summary>
        /// Indicates an active scrollbar state.
        /// </summary>
        ACTIVE,

        /// <summary>
        /// Indicates a pressed scrollbar state.
        /// </summary>
        PRESSED,

        /// <summary>
        /// Indicates a disabled scrollbar state.
        /// </summary>
        DISABLED
    }
    #endregion
}