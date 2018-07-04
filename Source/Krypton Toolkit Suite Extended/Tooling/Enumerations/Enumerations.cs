﻿namespace Tooling.Enumerations
{
    /// <summary>
    /// The RGBA channel
    /// </summary>
    public enum RGBAChannel
    {
        /// <summary>
        /// The red channel.
        /// </summary>
        RED,
        /// <summary>
        /// The green channel.
        /// </summary>
        GREEN,
        /// <summary>
        /// The blue channel.
        /// </summary>
        BLUE,
        /// <summary>
        /// The alpha channel.
        /// </summary>
        ALPHA
    }

    /// <summary>
    /// Specifies the origin of a navigation operation
    /// </summary>
    public enum NavigationOrigin
    {
        /// <summary>
        /// Specifies the beginning
        /// </summary>
        BEGIN,

        /// <summary>
        /// Specifies the current position
        /// </summary>
        CURRENT,

        /// <summary>
        /// Specifies the end
        /// </summary>
        END
    }

    public enum ColourSource
    {
        NONE,
        STANDARD,
        CUSTOM
    }

    public enum ColourSliderNubStyle
    {
        NONE,
        TOPLEFT,
        BOTTOMRIGHT
    }

    public enum ColourPalette
    {
        NONE,

        NAMED,

        OFFICE2010,

        PAINT,

        STANDARD,

        WEBSAFE,

        STANDARD256
    }

    /// <summary>
    /// Specifies the edit mode of a <see cref="ColourGrid" />.
    /// </summary>
    public enum ColourEditingMode
    {
        /// <summary>
        /// None. No editing is allowed.
        /// </summary>
        NONE,

        /// <summary>
        /// Only custom colours can be edited.
        /// </summary>
        CUSTOMONLY,

        /// <summary>
        /// Custom or standard colours can be edited.
        /// </summary>
        BOTH
    }

    /// <summary>
    /// Determines how the selected cell in a <see cref="ColourGrid" /> control is rendered.
    /// </summary>
    public enum ColourGridSelectedCellStyle
    {
        /// <summary>
        /// The selected cell is drawn no differently to any other cell.
        /// </summary>
        NONE,

        /// <summary>
        /// The selected cell displays a basic outline and focus rectangle.
        /// </summary>
        STANDARD,

        /// <summary>
        /// The selected cell is displayed larger than other cells
        /// </summary>
        ZOOMED
    }

    /// <summary>
    /// Specifies the sort order of colours
    /// </summary>
    public enum ColourCollectionSortOrder
    {
        /// <summary>
        /// Ordered by hue.
        /// </summary>
        HUE,

        /// <summary>
        /// Ordered by brightness.
        /// </summary>
        BRIGHTNESS,

        /// <summary>
        /// Ordered by value
        /// </summary>
        VALUE
    }

    /// <summary>
    /// Specifies the style of a colour cell border.
    /// </summary>
    public enum ColourCellBorderStyle
    {
        /// <summary>
        /// No border.
        /// </summary>
        NONE,

        /// <summary>
        /// A single line border.
        /// </summary>
        FIXEDSINGLE,

        /// <summary>
        /// A contrasting double border with a soft inner outline using the colour of the cell.
        /// </summary>
        DOUBLESOFT
    }

    /// <summary>
    /// Specifies the style of a colour bar
    /// </summary>
    public enum ColourBarStyle
    {
        /// <summary>
        /// A gradient from one colour to another.
        /// </summary>
        TWOCOLOUR,

        /// <summary>
        /// A gradient between three colours.
        /// </summary>
        THREECOLOUR,

        /// <summary>
        /// A gradient between a user defined number of colours.
        /// </summary>
        CUSTOM
    }

    /// <summary>
    /// Specifies the version of a Abode Photoshop colour swatch file
    /// </summary>
    public enum AdobePhotoshopColourSwatchFileVersion
    {
        /// <summary>
        /// Version 1
        /// </summary>
        VERSION1 = 1,

        /// <summary>
        /// Version 2
        /// </summary>
        VERSION2
    }

    /// <summary>
    /// Specifies the colour space of an Adobe Photoshop colour swatch file
    /// </summary>
    public enum AdobePhotoshopColourSwatchColourSpace
    {
        /// <summary>
        /// RGB
        /// </summary>
        RGB = 0,

        /// <summary>
        /// HSB
        /// </summary>
        HSB = 1,

        /// <summary>
        /// CMYK
        /// </summary>
        CMYK = 2,

        /// <summary>
        /// Lab
        /// </summary>
        LAB = 7,

        /// <summary>
        /// Grayscale
        /// </summary>
        GRAYSCALE = 8
    }
}