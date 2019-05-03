﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    /// <summary>
    /// A KryptonCommandLink button.
    /// Boilerplate code from (https://blogs.msdn.microsoft.com/knom/2007/03/12/vista-command-link-control-with-c-windows-forms/)
    /// </summary>
    /// <remarks>
    /// If used on Windows Vista or higher, the button will be a CommandLink: Basically the same functionality as a Button but looks different.
    /// </remarks>
    [DesignerCategory("Code")]
    [DisplayName("Krypton Command Link")]
    [Description("A Krypton Command Link Button.")]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonButton))]
    public class KryptonCommandLinkVersion2 : KryptonButton
    {
        #region Variables
        private bool _showUACShield = false;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the shield icon visibility of the command link.
        /// </summary>
        [Category("Command Link"), Description("Gets or sets the shield icon visibility of the command link."), DefaultValue(false)]
        public bool ShowUACShield
        {
            get
            {
                return _showUACShield;
            }

            set
            {
                _showUACShield = value;

                SendMessage(new HandleRef(this, this.Handle), BCM_SETSHIELD, IntPtr.Zero, _showUACShield);
            }
        }

        /// <summary>
        /// Gets or sets the note text of the command link.
        /// </summary>
        [Category("Command Link"), Description("Gets or sets the note text of the command link."), DefaultValue("")]
        public string NoteText
        {
            get
            {
                return GetNoteText();
            }

            set
            {
                SetNoteText(value);
            }
        }
        #endregion

        #region WIN32 Calls
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern int SendMessage(HandleRef hWnd, UInt32 msg, ref int wParam, StringBuilder lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern int SendMessage(HandleRef hWnd, UInt32 msg, IntPtr wParam, string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern int SendMessage(HandleRef hWnd, UInt32 msg, IntPtr wParam, bool lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern int SendMessage(HandleRef hWnd, UInt32 msg, IntPtr wParam, IntPtr lParam);
        #endregion

        #region Constants
        const int BS_COMMANDLINK = 0x0000000E, BCM_SETNOTE = 0x00001609, BCM_GETNOTE = 0x0000160A, BCM_GETNOTELENGTH = 0x0000160B, BCM_SETSHIELD = 0x0000160C;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonCommandLinkVersion2"/> class.
        /// </summary>
        public KryptonCommandLinkVersion2()
        {

        }
        #endregion

        #region Overrides
        protected override Size DefaultSize
        {
            get
            {
                return new Size(160, 60);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;

                createParams.Style |= BS_COMMANDLINK;

                return createParams;
            }
        }
        #endregion

        #region Setter and Getter Methods
        /// <summary>
        /// Sets the NoteText to the value of value.
        /// </summary>
        /// <param name="value">The desired value of NoteText.</param>
        private void SetNoteText(string value)
        {
            SendMessage(new HandleRef(this, this.Handle), BCM_SETNOTE, IntPtr.Zero, value);
        }

        /// <summary>
        /// Returns the value of the NoteText.
        /// </summary>
        /// <returns>The value of the NoteText.</returns>
        private string GetNoteText()
        {
            int _length = SendMessage(new HandleRef(this, this.Handle), BCM_GETNOTELENGTH, IntPtr.Zero, IntPtr.Zero) + 1;

            StringBuilder stringBuilder = new StringBuilder(_length);

            SendMessage(new HandleRef(this, this.Handle), BCM_GETNOTE, ref _length, stringBuilder);

            return stringBuilder.ToString();
        }
        #endregion
    }
}