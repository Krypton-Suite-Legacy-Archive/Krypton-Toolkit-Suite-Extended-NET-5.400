﻿using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Core.Classes.Other
{
    public class GlobalMethods
    {
        #region Constructor
        public GlobalMethods()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Not the implemented yet.
        /// </summary>
        /// <param name="featureName">Name of the feature.</param>
        public static void NotImplementedYet(string featureName = null)
        {
            if (featureName != null)
            {
                KryptonMessageBox.Show($"The feature: { featureName } is not implemented or fully functional yet. Please check back again later.", "Incomplete Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                KryptonMessageBox.Show("This is not implemented or fully functional yet. Please check back again later.", "Incomplete Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}