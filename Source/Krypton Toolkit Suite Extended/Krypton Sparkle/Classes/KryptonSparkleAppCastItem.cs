﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptonSparkle.Classes
{
    /// <summary>
    /// Item from a Sparkle AppCast file
    /// </summary>
    public class KryptonSparkleAppCastItem : IComparable<KryptonSparkleAppCastItem>
    {
        /// <summary>
        /// The application name
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// The installed version
        /// </summary>
        public string AppVersionInstalled { get; set; }
        /// <summary>
        /// The available version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// The release notes linke
        /// </summary>
        public string ReleaseNotesLink { get; set; }
        /// <summary>
        /// The download link
        /// </summary>
        public string DownloadLink { get; set; }
        /// <summary>
        /// The DSA signature
        /// </summary>
        public string DSASignature { get; set; }

        #region IComparable<NetSparkleAppCastItem> Members
        /// <summary>
        /// Compares this instance to another
        /// </summary>
        /// <param name="other">the other instance</param>
        /// <returns>-1, 0, 1 if this instance is less than, equal to, or greater than the <paramref name="other"/></returns>
        public int CompareTo(KryptonSparkleAppCastItem other)
        {
            Version v1 = new Version(this.Version);
            Version v2 = new Version(other.Version);

            return v1.CompareTo(v2);
        }

        #endregion
    }
}