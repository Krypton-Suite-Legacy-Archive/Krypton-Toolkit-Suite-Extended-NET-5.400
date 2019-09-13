﻿using KryptonSparkle.Classes;
using System;
using System.Windows.Forms;

namespace KryptonSparkle.Interfaces
{
    public interface IKryptonSparkleForm
    {
        /// <summary>
        /// Event fired when the user has responded to the 
        /// skip, later, install question.
        /// </summary>
        event EventHandler UserResponded;

        /// <summary>
        /// Show the UI
        /// </summary>
        void Show();

        /// <summary>
        /// Hides the release notes 
        /// </summary>
        void HideReleaseNotes();

        /// <summary>
        /// Gets the result for skip, later, or install
        /// </summary>
        /// <value>Valid results are install = yes, skip = no, later = retry</value>
        DialogResult Result { get; }

        /// <summary>
        /// Gets or sets the current item being installed
        /// </summary>
        KryptonSparkleAppCastItem CurrentItem { get; set; }
    }
}