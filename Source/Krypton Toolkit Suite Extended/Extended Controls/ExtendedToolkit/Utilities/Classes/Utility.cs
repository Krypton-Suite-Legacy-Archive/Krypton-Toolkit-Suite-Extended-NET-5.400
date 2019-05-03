﻿using System;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.Utilities.Classes
{
    public class Utility
    {
        /// <summary>
        /// Determines whether [is windows seven or above].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is windows seven or above]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWindowsSevenOrAbove()
        {
            bool result = false;

            Version currentOSVersion = Environment.OSVersion.Version;

            if (currentOSVersion.Major >= 6 && currentOSVersion.Minor >= 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static Boolean IsVista()
        {
            // Check OS Before using XP drop shadow
            Boolean Result = false;
            Version OSVer = System.Environment.OSVersion.Version;
            if (OSVer.Major >= 6)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }
            return Result;
        }
        public static StringFormat GetStringFormat(ContentAlignment contentAlignment)
        {
            if (!Enum.IsDefined(typeof(ContentAlignment), (int)contentAlignment))
                throw new System.ComponentModel.InvalidEnumArgumentException(
                    "contentAlignment", (int)contentAlignment, typeof(ContentAlignment));

            StringFormat stringFormat = new StringFormat();

            switch (contentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;
                    break;

                case ContentAlignment.MiddleLeft:
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Near;
                    break;

                case ContentAlignment.MiddleRight:
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Far;
                    break;

                case ContentAlignment.TopCenter:
                    stringFormat.LineAlignment = StringAlignment.Near;
                    stringFormat.Alignment = StringAlignment.Center;
                    break;

                case ContentAlignment.TopLeft:
                    stringFormat.LineAlignment = StringAlignment.Near;
                    stringFormat.Alignment = StringAlignment.Near;
                    break;

                case ContentAlignment.TopRight:
                    stringFormat.LineAlignment = StringAlignment.Near;
                    stringFormat.Alignment = StringAlignment.Far;
                    break;

                case ContentAlignment.BottomCenter:
                    stringFormat.LineAlignment = StringAlignment.Far;
                    stringFormat.Alignment = StringAlignment.Center;
                    break;

                case ContentAlignment.BottomLeft:
                    stringFormat.LineAlignment = StringAlignment.Far;
                    stringFormat.Alignment = StringAlignment.Near;
                    break;

                case ContentAlignment.BottomRight:
                    stringFormat.LineAlignment = StringAlignment.Far;
                    stringFormat.Alignment = StringAlignment.Far;
                    break;
            }

            return stringFormat;
        }
    }
}
