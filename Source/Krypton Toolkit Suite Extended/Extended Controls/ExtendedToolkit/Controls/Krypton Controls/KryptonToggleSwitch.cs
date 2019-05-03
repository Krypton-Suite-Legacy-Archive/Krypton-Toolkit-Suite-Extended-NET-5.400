﻿using ExtendedControls.Base.Code.Drawing;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    /// <summary>
    /// A toggle switch.
    /// Boilerplate code from: https://github.com/aalitor/AltoControls/blob/on-development/AltoControls/Controls/SwitchButton.cs
    /// </summary>
    [ToolboxItem(true)]
    //[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class KryptonToggleSwitch : Control
    {
        #region Old Code

        //#region Events
        //public delegate void SliderChangedEventHandler(object sender, EventArgs e);

        //public event SliderChangedEventHandler SliderValueChanged;
        //#endregion

        //#region Variables
        //private float _diameter, _artis;
        //private RoundedRectangleF _rect;
        //private RectangleF _circle;
        //private bool _isOn, _useGradientOnKnob, _useKryptonRenderer, _showTextOnControl;
        //private Color _borderColour, _offColour, _onColour, _disabledColour, _knobColour, _disabledKnobColour, _enabledTextColour, _disabledTextColour, _startGradientColour, _middleGradientColour, _endGradientColour, _penColour;
        //private Timer _paintTicker = new Timer();
        //private string _enabledText, _disabledText;
        //private LinearGradientMode _mode;
        //private IPalette _palette;
        //private PaletteRedirect _paletteRedirect;
        //private PaletteBackInheritRedirect _paletteBack;
        //private PaletteBorderInheritRedirect _paletteBorder;
        //private PaletteContentInheritRedirect _paletteContent;
        //private IDisposable _mementoBack;
        //#endregion

        //#region Properties
        //public bool ShowTextOnControl { get => _showTextOnControl; set { _showTextOnControl = value; Invalidate(); } }

        //public bool UseGradientOnKnob { get => _useGradientOnKnob; set { _useGradientOnKnob = value; Invalidate(); } }

        //public bool IsOn { get => _isOn; set { _paintTicker.Stop(); _isOn = value; _paintTicker.Start(); if (SliderValueChanged != null) SliderValueChanged(this, EventArgs.Empty); } }

        //public Color BorderColour { get => _borderColour; set { _borderColour = value; Invalidate(); } }

        //public Color DisabledColour { get => _disabledColour; set { _disabledColour = value; Invalidate(); } }

        //public Color DisabledTextColour { get => _disabledTextColour; set { _disabledTextColour = value; Invalidate(); } }

        //public Color DisabledKnobColour { get => _disabledKnobColour; set { _disabledKnobColour = value; Invalidate(); } }

        //public Color KnobColour { get => _knobColour; set { _knobColour = value; Invalidate(); } }

        //public Color EnabledTextColour { get => _enabledTextColour; set { _enabledTextColour = value; Invalidate(); } }

        //public Color DisabledBackgroundColour { get => _offColour; set { _offColour = value; Invalidate(); } }

        //public Color EnabledBackgroundColour { get => _onColour; set { _onColour = value; Invalidate(); } }

        //public Color GradientStartColour { get => _startGradientColour; set { _startGradientColour = value; Invalidate(); } }

        //public Color GradientEndColour { get => _endGradientColour; set { _endGradientColour = value; Invalidate(); } }

        //public Color PenColour { get => _penColour; set { _penColour = value; Invalidate(); } }

        //public string EnabledText { get => _enabledText; set { _enabledText = value; Invalidate(); } }

        //public string DisabledText { get => _disabledText; set { _disabledText = value; Invalidate(); } }

        //public LinearGradientMode GradientMode { get => _mode; set { _mode = value; Invalidate(); } }

        //protected override Size DefaultSize => new Size(60, 35);
        //#endregion

        //#region Constructor
        //public KryptonToggleSwitch()
        //{
        //    // Double buffering
        //    SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        //    SetStyle(ControlStyles.UserPaint, true);

        //    SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        //    SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        //    SetStyle(ControlStyles.ResizeRedraw, true);


        //    #region Set Colours
        //    DisabledBackgroundColour = Color.Red;

        //    EnabledBackgroundColour = Color.LightGreen;

        //    KnobColour = Color.FromArgb(246, 240, 230);

        //    DisabledColour = Color.FromArgb(207, 207, 207);

        //    DisabledKnobColour = Color.FromArgb(179, 179, 179);

        //    EnabledTextColour = Color.Gray;

        //    DisabledTextColour = Color.White;

        //    GradientStartColour = Color.FromArgb(187, 206, 230);

        //    //MiddleGradientColour = Color.FromArgb(220, 232, 246);

        //    GradientEndColour = Color.FromArgb(132, 157, 189);

        //    GradientMode = LinearGradientMode.ForwardDiagonal;

        //    PenColour = Color.LightGray;
        //    #endregion

        //    EnabledText = "On";

        //    DisabledText = "Off";

        //    Cursor = Cursors.Hand;

        //    DoubleBuffered = true;

        //    _artis = 4;

        //    _diameter = 30;

        //    ShowTextOnControl = true;

        //    _rect = new RoundedRectangleF(2 * _diameter, _diameter + 2, _diameter / 2, 1, 1);

        //    _circle = new RectangleF(1, 1, _diameter, _diameter);

        //    IsOn = true;

        //    UseGradientOnKnob = true;

        //    //UseKryptonRenderer = false;

        //    BorderColour = Color.LightGray;

        //    BackColor = Color.Transparent;

        //    Font = new Font("Segoe UI", 11f, FontStyle.Bold);

        //    _paintTicker.Interval = 1;

        //    _paintTicker.Tick += PaintTicker_Tick;

        //    Text = "";
        //}
        //#endregion

        //#region Event Handlers
        //private void PaintTicker_Tick(object sender, EventArgs e)
        //{
        //    float x = _circle.X;

        //    if (IsOn)
        //    {
        //        if (x + _artis <= Width - _diameter - 1)
        //        {
        //            x += _artis;

        //            _circle = new RectangleF(x, 1, _diameter, _diameter);

        //            //Invalidate();
        //        }
        //        else
        //        {
        //            x = Width - _diameter - 1;

        //            _circle = new RectangleF(x, 1, _diameter, _diameter);

        //            //Invalidate();

        //            _paintTicker.Stop();
        //        }

        //    }
        //    else //switch the circle to the left with animation
        //    {
        //        if (x - _artis >= 1)
        //        {
        //            x -= _artis;

        //            _circle = new RectangleF(x, 1, _diameter, _diameter);

        //            Invalidate();
        //        }
        //        else
        //        {
        //            x = 1;

        //            _circle = new RectangleF(x, 1, _diameter, _diameter);

        //            Invalidate();

        //            _paintTicker.Stop();

        //        }
        //    }
        //}

        //private void OnGlobalPaletteChanged(object sender, EventArgs e)
        //{
        //    if (_palette != null)
        //    {
        //        _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
        //    }

        //    _palette = KryptonManager.CurrentGlobalPalette;

        //    if (_palette != null)
        //    {
        //        _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
        //    }

        //    Invalidate();
        //}

        //private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        //{
        //    Invalidate();
        //}
        //#endregion

        //#region Overrides
        //protected override void OnEnabledChanged(EventArgs e)
        //{
        //    Invalidate();

        //    base.OnEnabledChanged(e);
        //}

        //protected override void OnResize(EventArgs e)
        //{
        //    Width = (Height - 2) * 2;

        //    _diameter = Width / 2;

        //    _artis = 4 * _diameter / 30;

        //    _rect = new RoundedRectangleF(2 * _diameter, _diameter + 2, _diameter / 2, 1, 1);

        //    _circle = new RectangleF(!IsOn ? 1 : Width - _diameter - 1, 1, _diameter, _diameter);

        //    base.OnResize(e);
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

        //    if (Enabled)
        //    {
        //        using (SolidBrush sb = new SolidBrush(IsOn ? EnabledBackgroundColour : DisabledBackgroundColour)) //Color.LightGreen : Color.LightGray))
        //        {
        //            e.Graphics.FillPath(sb, _rect.Path);
        //        }

        //        using (Pen pen = new Pen(BorderColour, 2f))
        //        {
        //            e.Graphics.DrawPath(pen, _rect.Path);
        //        }

        //        string on = EnabledText, off = DisabledText;

        //        if (ShowTextOnControl)
        //        {
        //            //if (UseKryptonRenderer)
        //            //{
        //            //    if (UseGradientOnKnob)
        //            //    {
        //            //        UseGradientOnKnob = false;
        //            //    }

        //            //    // Do krypton stuff...
        //            //    if (_palette != null)
        //            //    {
        //            //        PaletteState state = Enabled ? PaletteState.Normal : PaletteState.Disabled;

        //            //        Color backColour = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, state), borderColour = _palette.GetBorderColor1(PaletteBorderStyle.ButtonStandalone, state);

        //            //        OnTextColour = _palette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, state);

        //            //        OffTextColour = _palette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, state);

        //            //        Font = _palette.GetContentShortTextFont(PaletteContentStyle.ButtonStandalone, state);

        //            //        IRenderer renderer = _palette.GetRenderer();

        //            //        using (RenderContext renderContext = new RenderContext(this, e.Graphics, e.ClipRectangle, renderer))
        //            //        {

        //            //        }
        //            //    }
        //            //}
        //            //else
        //            //{
        //            //    UseKryptonRenderer = false;

        //            using (Font typeface = new Font(Font.FontFamily.Name, Font.Size * _diameter / 30, Font.Style))
        //            {
        //                int height = TextRenderer.MeasureText(on, typeface).Height;

        //                float y = (_diameter - height) / 2f;

        //                SolidBrush onBrush = new SolidBrush(EnabledTextColour), offBrush = new SolidBrush(DisabledTextColour);

        //                e.Graphics.DrawString(on, typeface, onBrush, 5, y + 1);

        //                height = TextRenderer.MeasureText(off, typeface).Height;

        //                y = (_diameter - height) / 2f;

        //                e.Graphics.DrawString(off, typeface, offBrush, _diameter + 2, y + 1);
        //            }

        //            if (UseGradientOnKnob)
        //            {
        //                using (LinearGradientBrush lgb = new LinearGradientBrush(_circle, GradientStartColour, GradientEndColour, GradientMode)) //, Color.Aquamarine, LinearGradientMode.ForwardDiagonal))
        //                {
        //                    e.Graphics.FillEllipse(lgb, _circle);
        //                }
        //            }
        //            else
        //            {
        //                using (SolidBrush circleBrush = new SolidBrush(KnobColour)) //"#F6F0E6".FromHex()))
        //                {
        //                    e.Graphics.FillEllipse(circleBrush, _circle);
        //                }
        //            }
        //            //}

        //            using (Pen pen = new Pen(PenColour, 1.2f))
        //            {
        //                e.Graphics.DrawEllipse(pen, _circle);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        using (SolidBrush disableBrush = new SolidBrush(DisabledColour)) //"#CFCFCF".FromHex()))
        //        {
        //            using (SolidBrush ellBrush = new SolidBrush(DisabledKnobColour)) //"#B3B3B3".FromHex()))
        //            {
        //                e.Graphics.FillPath(disableBrush, _rect.Path);

        //                e.Graphics.FillEllipse(ellBrush, _circle);

        //                e.Graphics.DrawEllipse(Pens.DarkGray, _circle);
        //            }
        //        }
        //    }

        //    base.OnPaint(e);
        //}

        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    _isOn = !_isOn;

        //    IsOn = _isOn;

        //    base.OnMouseDown(e);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (_palette != null)
        //        {
        //            _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

        //            _palette = null;
        //        }

        //        KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
        //    }

        //    base.Dispose(disposing);
        //}
        //#endregion

        #endregion

        public delegate void SliderChangedEventHandler(object sender, EventArgs e);
        public event SliderChangedEventHandler SliderValueChanged;

        #region Variables
        private float _diameter, _artis;
        private RoundedRectangleF _rect;
        private RectangleF _circle;
        private bool _isOn, _textEnabled, _useGradientOnKnob;
        private Color _borderColour, _textEnabledForeColour, _textDisabledForeColour,
                      _enabledBackColour, _disabledBackColour, _disabledControlColour,
                      _knobColour, _penColour, _gradientStartColour,
                      _gradientEndColour;
        private Timer _paintTicker = new Timer();
        private LinearGradientMode _mode;
        private string _onText, _offText;
        #endregion

        #region Properties
        public bool TextEnabled
        {
            get => _textEnabled;

            set
            {
                _textEnabled = value;
                Invalidate();
            }
        }

        public bool IsOn
        {
            get => _isOn;

            set
            {
                _paintTicker.Stop();

                _isOn = value;

                _paintTicker.Start();

                if (SliderValueChanged != null)
                    SliderValueChanged(this, EventArgs.Empty);
            }
        }

        public bool UseGradientOnKnob
        {
            get => _useGradientOnKnob;

            set
            {
                _useGradientOnKnob = value;

                Invalidate();
            }
        }

        public Color BorderColour
        {
            get => _borderColour;

            set
            {
                _borderColour = value;

                Invalidate();
            }
        }

        public Color TextEnabledForeColour
        {
            get => _textEnabledForeColour;

            set
            {
                _textEnabledForeColour = value;

                Invalidate();
            }
        }

        public Color TextDisabledForeColour
        {
            get => _textDisabledForeColour;

            set
            {
                _textDisabledForeColour = value;

                Invalidate();
            }
        }

        public Color EnabledBackColour
        {
            get => _enabledBackColour;

            set
            {
                _enabledBackColour = value;

                Invalidate();
            }
        }

        public Color DisabledBackColour
        {
            get => _disabledBackColour;

            set
            {
                _disabledBackColour = value;

                Invalidate();
            }
        }

        public Color DisabledControlColour
        {
            get => _disabledControlColour;

            set
            {
                _disabledControlColour = value;

                Invalidate();
            }
        }

        public Color KnobColour
        {
            get => _knobColour;

            set
            {
                _knobColour = value;

                Invalidate();
            }
        }

        public Color PenColour
        {
            get => _penColour;

            set
            {
                _penColour = value;

                Invalidate();
            }
        }

        public Color GradientStartColour
        {
            get => _gradientStartColour;

            set
            {
                _gradientStartColour = value;

                Invalidate();
            }
        }

        public Color GradientEndColour
        {
            get => _gradientEndColour;

            set
            {
                _gradientEndColour = value;

                Invalidate();
            }
        }

        public LinearGradientMode GradientMode
        {
            get => _mode;

            set
            {
                _mode = value;

                Invalidate();
            }
        }

        public string OnText
        {
            get => _onText;

            set
            {
                _onText = value;

                Invalidate();
            }
        }

        public string OffText
        {
            get => _offText;

            set
            {
                _offText = value;

                Invalidate();
            }
        }
        #endregion

        #region Constructor
        public KryptonToggleSwitch()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            Cursor = Cursors.Hand;
            DoubleBuffered = true;

            BackColor = Color.Transparent;

            Font = new Font("Segoe UI", 9f);

            _artis = 4; //increment for sliding animation

            _diameter = 30;

            TextEnabled = true;

            _rect = new RoundedRectangleF(2 * _diameter, _diameter + 2, _diameter / 2, 1, 1);

            _circle = new RectangleF(1, 1, _diameter, _diameter);

            IsOn = true;

            BorderColour = Color.LightGray;

            UseGradientOnKnob = false;

            TextEnabledForeColour = Color.Gray;

            TextDisabledForeColour = Color.White;

            EnabledBackColour = Color.LightGreen;

            DisabledBackColour = Color.Red;

            PenColour = Color.LightGray;

            DisabledControlColour = Color.LightGray;

            KnobColour = Color.White;

            GradientStartColour = Color.FromArgb(187, 206, 230);

            GradientEndColour = Color.FromArgb(132, 157, 189);

            GradientMode = LinearGradientMode.ForwardDiagonal;

            OnText = "On";

            OffText = "Off";

            _paintTicker.Tick += paintTicker_Tick;
            _paintTicker.Interval = 1;
        }
        #endregion

        protected override void OnEnabledChanged(EventArgs e)
        {
            Invalidate();
            base.OnEnabledChanged(e);
        }
        protected override void OnResize(EventArgs e)
        {
            float textSize = Font.Size;

            Width = (Height - 2) * 2;
            _diameter = Width / 2;
            _artis = 4 * _diameter / 30;
            _rect = new RoundedRectangleF(2 * _diameter, _diameter + 2, _diameter / 2, 1, 1);
            _circle = new RectangleF(!_isOn ? 1 : Width - _diameter - 1, 1, _diameter, _diameter);

            Font = Font;

            base.OnResize(e);
        }

        //creates slide animation
        private void paintTicker_Tick(object sender, EventArgs e)
        {
            float x = _circle.X;

            if (_isOn)           //switch the circle to the left
            {
                if (x + _artis <= Width - _diameter - 1)
                {
                    x += _artis;
                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();
                }
                else
                {
                    x = Width - _diameter - 1;
                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();
                    _paintTicker.Stop();
                }

            }
            else //switch the circle to the left with animation
            {
                if (x - _artis >= 1)
                {
                    x -= _artis;
                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();
                }
                else
                {
                    x = 1;
                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();
                    _paintTicker.Stop();

                }
            }
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(60, 35);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (Enabled)
            {
                using (SolidBrush brush = new SolidBrush(IsOn ? EnabledBackColour : DisabledBackColour))
                    e.Graphics.FillPath(brush, _rect.Path);

                using (Pen pen = new Pen(BorderColour, 2f))
                    e.Graphics.DrawPath(pen, _rect.Path);

                string on = OnText, off = OffText;

                SolidBrush onColour = new SolidBrush(TextEnabledForeColour), offBrush = new SolidBrush(TextDisabledForeColour);

                if (TextEnabled)
                    using (Font font = new Font(Font.FontFamily, Font.Size * _diameter / 30, Font.Style))
                    {
                        int height = TextRenderer.MeasureText(on, font).Height;
                        float y = (_diameter - height) / 2f;
                        e.Graphics.DrawString(on, font, onColour, 5, y + 1);

                        height = TextRenderer.MeasureText(off, font).Height;
                        y = (_diameter - height) / 2f;
                        e.Graphics.DrawString(off, font, offBrush, _diameter + 2, y + 1);
                    }

                if (UseGradientOnKnob)
                {
                    using (LinearGradientBrush lgb = new LinearGradientBrush(_circle, GradientStartColour, GradientEndColour, GradientMode))
                    {
                        e.Graphics.FillEllipse(lgb, _circle);
                    }
                }
                else
                {
                    using (SolidBrush circleBrush = new SolidBrush(KnobColour))
                    {
                        e.Graphics.FillEllipse(circleBrush, _circle);
                    }
                }

                using (Pen pen = new Pen(PenColour, 1.2f))
                    e.Graphics.DrawEllipse(pen, _circle);

            }
            else
            {
                using (SolidBrush disableBrush = new SolidBrush(DisabledControlColour))
                using (SolidBrush ellBrush = new SolidBrush(DisabledBackColour))
                {
                    e.Graphics.FillPath(disableBrush, _rect.Path);
                    e.Graphics.FillEllipse(ellBrush, _circle);
                    e.Graphics.DrawEllipse(Pens.DarkGray, _circle);
                }
            }

            base.OnPaint(e);

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            _isOn = !_isOn;
            IsOn = _isOn;

            base.OnMouseClick(e);
        }
    }
}