﻿using System;
using System.ComponentModel;
using System.Net;

namespace KryptonSparkle.Interfaces
{
    public interface IKryptonSparkleDownloadProgress
    {
        /// <summary>
        /// event to fire when the form asks the application to be relaunched
        /// </summary>
        event EventHandler InstallAndRelaunch;

        /// <summary>
        /// Gets or sets the temporary file name where the new items are downloaded
        /// </summary>
        string TempFileName { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if the downloaded file matches its listed
        /// DSA hash.
        /// </summary>
        bool IsDownloadDSAValid { get; set; }

        /// <summary>
        /// Show the UI and waits
        /// </summary>
        void ShowDialog();

        /// <summary>
        /// Called when the download progress changes
        /// </summary>
        /// <param name="sender">not used.</param>
        /// <param name="e">used to resolve the progress of the download. Also contains the total size of the download</param>
        void OnClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e);

        /// <summary>
        /// Event called when the download of the binary is complete
        /// </summary>
        /// <param name="sender">not used.</param>
        /// <param name="e">not used.</param>
        void OnClientDownloadFileCompleted(object sender, AsyncCompletedEventArgs e);
    }
}