﻿using Common;
using Common.Classes;
using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitSuiteExtendedCore;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace KryptonSparkle.Controls
{
    /// <summary>
    /// A standard Krypton button control with UAC shield
    /// Modified from the AeroSuite project.
    /// </summary>
    /// <remarks>
    /// The shield is extracted from the system with LoadImage if possible. Otherwise the shield will be enabled by sending the BCM_SETSHIELD Message to the control.
    /// If the operating system is not Windows Vista or higher, no shield will be displayed as there's no such thing as UAC on the target system -> the shield is obsolete.
    /// </remarks>
    [DesignerCategory("code"), Description("Krypton UAC Elevated Button"), ToolboxBitmap(typeof(KryptonButton), "ToolboxBitmaps.UACButton.bmp"), ToolboxItem(true)]
    public partial class SparkleKryptonUACElevatedButton : KryptonButton
    {
        #region Variables
        private Assembly _processToElevate;

        private bool _elevateApplicationOnClick = true, _showUACShield = true;

        private string _processName = string.Empty;

        private static bool? _isSystemAbleToLoadShield = null;

        private const int BCM_SETSHIELD = 0x160C;

        private int _cornerRadius;

        private GlobalMethods _globalMethods = new GlobalMethods();

        private UtilityMethods _utilityMethods = new UtilityMethods();
        #endregion

        #region Properties
        public Assembly ProcessToElevate { get => _processToElevate; set => _processToElevate = value; }

        /// <summary>
        /// Elevates the current running application to administrator level when button is clicked.
        /// </summary>
        /// <remarks>
        /// The application/process will restart when clicked.
        /// </remarks>
        [Category("Code"), Description("Elevates the current running application to administrator level when button is clicked. The application/process will restart when clicked."), DefaultValue(true)]
        public bool ElevateApplicationOnClick { get => _elevateApplicationOnClick; set => _elevateApplicationOnClick = value; }

        //public bool ShowUACShield { get => _showUACShield; set { _showUACShield = value; Invalidate(); } }

        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; Invalidate(); } }

        /// <summary>
        /// The application assembly.
        /// </summary>
        /// <remarks>
        /// Use 'Process.GetCurrentProcess().ProcessName;' as a start.
        /// </remarks>
        [Category("Code"), Description("The application assembly. Use 'Process.GetCurrentProcess().ProcessName;' as a start."), DefaultValue("")]
        public string ProcessName { get => _processName; set => _processName = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="SparkleKryptonUACElevatedButton"/> class.
        /// </summary>
        public SparkleKryptonUACElevatedButton() : base()
        {
            Size = new Size((int)(Width * 1.5), Height + 1);

            _globalMethods.CheckIfTargetPlatformIsSupported(true);

            if (_globalMethods.GetIsTargetPlatformSupported())
            {
                if (!_isSystemAbleToLoadShield.HasValue || _isSystemAbleToLoadShield.Value)
                {
                    try
                    {
                        var _icon = IconExtractor.LoadIcon(IconType.SHIELD, SystemInformation.SmallIconSize);

                        if (_icon != null)
                        {
                            Values.Image = _icon.ToBitmap();

                            //this.TextImageRelation = TextImageRelation.ImageBeforeText;

                            //Values.Image.ImageAlign = ContentAlignment.MiddleCenter;

                            _isSystemAbleToLoadShield = true;

                            return;
                        }
                        else
                        {
                            _isSystemAbleToLoadShield = false;
                        }
                    }
                    catch (Exception exc)
                    {
                        KryptonMessageBoxExtended.Show($"Your platform is unsupported. Please contact the software vendor for details.\nFor reference, your system is running: { _globalMethods.GetOSFriendlyName() }.\nException message: { exc.Message }.", "Unsupported Software", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        _isSystemAbleToLoadShield = false;
                    }
                }

                //FlatStyle = FlatStyle.System;

                CommonNativeMethods.SendMessage(Handle, BCM_SETSHIELD, IntPtr.Zero, new IntPtr(1));

                CornerRadius = -1;
            }
        }
        #endregion

        #region Overrides
        protected override void OnClick(EventArgs e)
        {
            try
            {
                if (ElevateApplicationOnClick)
                {
                    if (_globalMethods.GetIsTargetPlatformSupported())
                    {
                        if (ProcessName != string.Empty)
                        {
                            _globalMethods.ElevateProcessWithAdministrativeRights(ProcessName);
                        }
                        else if (ProcessToElevate != null) _globalMethods.ElevateProcessWithAdministrativeRights(Path.GetFullPath(ProcessName));
                    }
                }
            }
            catch (Exception ex)
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {
                    CaptureException(ex, null, this);
                }
                else
                {
                    KryptonMessageBoxExtended.Show($"An error has occurred: { ex.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            StateCommon.Border.Rounding = CornerRadius;

            base.OnPaint(e);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Captures the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="currentWindow">The current window.</param>
        /// <param name="title">The title.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodSignature">The method signature.</param>
        /// <param name="defaultTypeface">The default typeface.</param>
        private static void CaptureException(Exception exception, KryptonForm currentWindow, Control control = null, string title = @"Exception Caught", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error, string className = "", string methodSignature = "", Font defaultTypeface = null)
        {
            defaultTypeface = new Font(currentWindow.Font.FontFamily, currentWindow.Font.Size, currentWindow.Font.Style, currentWindow.Font.Unit);

            if (className != "")
            {
                KryptonMessageBoxExtended.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in class: '{ className }.cs'.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
            else if (methodSignature != "")
            {
                KryptonMessageBoxExtended.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in method: '{ methodSignature }'.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
            else if (className != "" && methodSignature != "")
            {
                KryptonMessageBoxExtended.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in class: '{ className }.cs'.\n\nError in method: '{ methodSignature }'.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
            else
            {
                KryptonMessageBoxExtended.Show($"An unexpected error has occurred: { exception.Message }.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
        }
        #endregion
    }
}