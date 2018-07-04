﻿using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using ComponentFactory.Krypton.Toolkit;

namespace ExtendedControls.ExtendedToolkit.ToolstripControls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    [ToolboxBitmap(typeof(KryptonNumericUpDown))]
    public partial class KryptonNumericUpDownToolStripItem : ToolStripControlHost
    {
        #region Constructor
        public KryptonNumericUpDownToolStripItem() : base(new KryptonNumericUpDown())
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets KryptonNumericUpDownControl.
        /// </summary>
        /// <value>
        /// The base control.
        /// </value>
        public KryptonNumericUpDown KryptonNumericUpDownControl
        {
            get
            {
                return Control as KryptonNumericUpDown;
            }
        }

        /// <summary>
        /// Gets or sets Value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public decimal Value
        {
            get
            {
                return KryptonNumericUpDownControl.Value;
            }


            set
            {
                KryptonNumericUpDownControl.Value = value;
            }
        }
        #endregion
    }
}