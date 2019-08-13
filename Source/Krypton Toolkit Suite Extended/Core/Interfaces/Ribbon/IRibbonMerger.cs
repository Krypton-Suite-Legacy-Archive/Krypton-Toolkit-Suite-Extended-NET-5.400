﻿using ComponentFactory.Krypton.Ribbon;
using System;

namespace KryptonToolkitSuiteExtendedCore
{
    /// <summary>
    /// The interface used to merge krypton ribbons.
    /// </summary>
    public interface IRibbonMerger
    {
        /// <summary>
        /// Function to merge a ribbon with the target ribbon
        /// </summary>
        /// <param name="ribbon">The ribbon to merge.</param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="ribbon"/> parameter is <b>null</b>.</exception>
        void Merge(KryptonRibbon ribbon);

        /// <summary>
        /// Function to unmerge the specified ribbon from the target ribbon.
        /// </summary>
        /// <param name="ribbon">The ribbon to unmerge.</param>
        void Unmerge(KryptonRibbon ribbon);
    }
}