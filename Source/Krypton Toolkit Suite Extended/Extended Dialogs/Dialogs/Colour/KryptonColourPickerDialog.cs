﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Cyotek.Windows.Forms;
using ExtendedColourControls;
using KryptonToolkitSuiteExtendedCore;

namespace ExtendedDialogs
{
    [DefaultEvent("PreviewColorChanged"), DefaultProperty("Color")]
    public class ColourPickerDialog : KryptonForm
    {
        #region Designer Code
        private IContainer components = null;
        private KryptonPanel kpnlMain;
        private Cyotek.Windows.Forms.ColorGrid cgColourPalette;
        private ColourEditorManager cem;
        private KryptonButton kbtnOk;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cbColourPreview;
        private KryptonButton kbtnCancel;
        private Cyotek.Windows.Forms.ColorEditor ceEditor;
        private ColourEditor ceColour;
        private KryptonButton kbtnSaveColourPalette;
        private KryptonButton kbtnLoadColourPalette;
        private ScreenColourPicker scpPicker;
        private ColourWheel cwColourPicker;

        private void InitializeComponent()
        {
            this.kpnlMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnSaveColourPalette = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnLoadColourPalette = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.scpPicker = new ScreenColourPicker();
            this.ceColour = new ColourEditor();
            this.ceEditor = new Cyotek.Windows.Forms.ColorEditor();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbColourPreview = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.cwColourPicker = new ColourWheel();
            this.cgColourPalette = new Cyotek.Windows.Forms.ColorGrid();
            this.cem = new ColourEditorManager();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).BeginInit();
            this.kpnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbColourPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlMain
            // 
            this.kpnlMain.Controls.Add(this.kbtnSaveColourPalette);
            this.kpnlMain.Controls.Add(this.kbtnLoadColourPalette);
            this.kpnlMain.Controls.Add(this.scpPicker);
            this.kpnlMain.Controls.Add(this.ceColour);
            this.kpnlMain.Controls.Add(this.ceEditor);
            this.kpnlMain.Controls.Add(this.kbtnCancel);
            this.kpnlMain.Controls.Add(this.kbtnOk);
            this.kpnlMain.Controls.Add(this.cbColourPreview);
            this.kpnlMain.Controls.Add(this.cwColourPicker);
            this.kpnlMain.Controls.Add(this.cgColourPalette);
            this.kpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlMain.Location = new System.Drawing.Point(0, 0);
            this.kpnlMain.Name = "kpnlMain";
            this.kpnlMain.Size = new System.Drawing.Size(643, 483);
            this.kpnlMain.TabIndex = 0;
            // 
            // kbtnSaveColourPalette
            // 
            this.kbtnSaveColourPalette.Location = new System.Drawing.Point(41, 300);
            this.kbtnSaveColourPalette.Name = "kbtnSaveColourPalette";
            this.kbtnSaveColourPalette.Size = new System.Drawing.Size(23, 23);
            this.kbtnSaveColourPalette.TabIndex = 5;
            this.kbtnSaveColourPalette.Values.Image = global::ExtendedDialogs.Properties.Resources.palette_save;
            this.kbtnSaveColourPalette.Values.Text = "";
            this.kbtnSaveColourPalette.Click += new System.EventHandler(this.KbtnSaveColourPalette_Click);
            // 
            // kbtnLoadColourPalette
            // 
            this.kbtnLoadColourPalette.Location = new System.Drawing.Point(12, 300);
            this.kbtnLoadColourPalette.Name = "kbtnLoadColourPalette";
            this.kbtnLoadColourPalette.Size = new System.Drawing.Size(23, 23);
            this.kbtnLoadColourPalette.TabIndex = 1;
            this.kbtnLoadColourPalette.Values.Image = global::ExtendedDialogs.Properties.Resources.palette_load;
            this.kbtnLoadColourPalette.Values.Text = "";
            this.kbtnLoadColourPalette.Click += new System.EventHandler(this.KbtnLoadColourPalette_Click);
            // 
            // scpPicker
            // 
            this.scpPicker.Colour = System.Drawing.Color.Empty;
            this.scpPicker.Image = global::ExtendedDialogs.Properties.Resources.eyedropper;
            this.scpPicker.Location = new System.Drawing.Point(501, 164);
            this.scpPicker.Name = "scpPicker";
            this.scpPicker.Size = new System.Drawing.Size(130, 129);
            // 
            // ceColour
            // 
            this.ceColour.BackColor = System.Drawing.Color.Transparent;
            this.ceColour.Location = new System.Drawing.Point(249, 20);
            this.ceColour.Name = "ceColour";
            this.ceColour.Size = new System.Drawing.Size(246, 371);
            this.ceColour.TabIndex = 1;
            // 
            // ceEditor
            // 
            this.ceEditor.BackColor = System.Drawing.Color.Transparent;
            this.ceEditor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceEditor.Location = new System.Drawing.Point(249, 20);
            this.ceEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ceEditor.Name = "ceEditor";
            this.ceEditor.Size = new System.Drawing.Size(246, 371);
            this.ceEditor.TabIndex = 1;
            this.ceEditor.Visible = false;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(501, 64);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(130, 38);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 4;
            this.kbtnCancel.Values.Text = "C&ancel";
            this.kbtnCancel.Click += new System.EventHandler(this.KbtnCancel_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.Location = new System.Drawing.Point(501, 20);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(130, 38);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 3;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.KbtnOk_Click);
            // 
            // cbColourPreview
            // 
            this.cbColourPreview.BackColor = System.Drawing.SystemColors.Control;
            this.cbColourPreview.Location = new System.Drawing.Point(501, 341);
            this.cbColourPreview.Name = "cbColourPreview";
            this.cbColourPreview.Size = new System.Drawing.Size(130, 130);
            this.cbColourPreview.TabIndex = 2;
            this.cbColourPreview.TabStop = false;
            this.cbColourPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.CbColourPreview_Paint);
            // 
            // cwColourPicker
            // 
            this.cwColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.cwColourPicker.Location = new System.Drawing.Point(12, 20);
            this.cwColourPicker.Name = "cwColourPicker";
            this.cwColourPicker.Size = new System.Drawing.Size(231, 212);
            this.cwColourPicker.TabIndex = 1;
            // 
            // cgColourPalette
            // 
            this.cgColourPalette.AutoAddColors = false;
            this.cgColourPalette.BackColor = System.Drawing.Color.Transparent;
            this.cgColourPalette.CellSize = new System.Drawing.Size(11, 12);
            this.cgColourPalette.EditMode = Cyotek.Windows.Forms.ColorEditingMode.Both;
            this.cgColourPalette.Location = new System.Drawing.Point(12, 329);
            this.cgColourPalette.Name = "cgColourPalette";
            this.cgColourPalette.SelectedCellStyle = Cyotek.Windows.Forms.ColorGridSelectedCellStyle.Standard;
            this.cgColourPalette.ShowCustomColors = false;
            this.cgColourPalette.Size = new System.Drawing.Size(231, 142);
            this.cgColourPalette.TabIndex = 1;
            this.cgColourPalette.EditingColor += new System.EventHandler<Cyotek.Windows.Forms.EditColorCancelEventArgs>(this.CgColourPalette_EditingColor);
            // 
            // cem
            // 
            this.cem.Color = System.Drawing.Color.Empty;
            this.cem.ColourEditor = this.ceColour;
            this.cem.ColourGrid = this.cgColourPalette;
            this.cem.ColourWheel = this.cwColourPicker;
            this.cem.ScreenColourPicker = this.scpPicker;
            this.cem.ColorChanged += new System.EventHandler(this.Cem_ColorChanged);
            this.cem.ColourChanged += new System.EventHandler(this.Cem_ColourChanged);
            // 
            // ColourPickerDialog
            // 
            this.AcceptButton = this.kbtnOk;
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(643, 483);
            this.Controls.Add(this.kpnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourPickerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Colour Picker";
            this.Load += new System.EventHandler(this.ColourPickerDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).EndInit();
            this.kpnlMain.ResumeLayout(false);
            this.kpnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbColourPreview)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constants

        private static readonly object _eventPreviewColourChanged = new object();

        #endregion

        #region Fields

        private Brush _textureBrush;

        #endregion

        #region Events

        [Category("Property Changed")]
        public event EventHandler PreviewColourChanged
        {
            add { this.Events.AddHandler(_eventPreviewColourChanged, value); }
            remove { this.Events.RemoveHandler(_eventPreviewColourChanged, value); }
        }

        #endregion

        #region Properties

        public Color Colour
        {
            get { return cem.Colour; }
            set { cem.Colour = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowAlphaChannel { get; set; }

        #endregion

        #region Constructors
        public ColourPickerDialog()
        {
            InitializeComponent();

            ShowAlphaChannel = true;

            Font = SystemFonts.DialogFont;
        }
        #endregion

        #region Methods
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                if (_textureBrush != null)
                {
                    _textureBrush.Dispose();

                    _textureBrush = null;
                }
            }

            base.Dispose(disposing);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ceColour.ShowAlphaChannel = ShowAlphaChannel;

            if (!ShowAlphaChannel)
            {
                for (int i = 0; i < cgColourPalette.Colors.Count; i++)
                {
                    Color colour;

                    colour = cgColourPalette.Colors[i];

                    if (colour.A != 255)
                    {
                        cgColourPalette.Colors[i] = Color.FromArgb(255, colour);
                    }
                }
            }
        }

        protected virtual void OnPreviewColourChanged(EventArgs e)
        {
            EventHandler handler;

            handler = (EventHandler)Events[_eventPreviewColourChanged];

            handler?.Invoke(this, e);
        }
        #endregion

        private void ColourPickerDialog_Load(object sender, EventArgs e)
        {

        }

        private void KbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void Cem_ColourChanged(object sender, EventArgs e)
        {
            cbColourPreview.Invalidate();

            OnPreviewColourChanged(e);
        }

        private void Cem_ColorChanged(object sender, EventArgs e)
        {
            cbColourPreview.Invalidate();

            OnPreviewColourChanged(e);
        }

        private void CgColourPalette_EditingColor(object sender, EditColorCancelEventArgs e)
        {
            e.Cancel = true;

            using (ColorDialog cd = new ColorDialog { FullOpen = true, Color = e.Color })
            {
                if (cd.ShowDialog(this) == DialogResult.OK) cgColourPalette.Colors[e.ColorIndex] = cd.Color;
            }
        }

        private void KbtnLoadColourPalette_Click(object sender, EventArgs e)
        {
            using (FileDialog fd = new OpenFileDialog { Filter = Cyotek.Windows.Forms.PaletteSerializer.DefaultOpenFilter, DefaultExt = "pal", Title = "Open a custom palette file:" })
            {
                if (fd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        Cyotek.Windows.Forms.IPaletteSerializer serializer;

                        serializer = Cyotek.Windows.Forms.PaletteSerializer.GetSerializer(fd.FileName);

                        if (serializer != null)
                        {
                            ColorCollection colours;

                            if (!serializer.CanRead) throw new InvalidOperationException("Serializer does not support reading palettes.");

                            using (FileStream fs = File.OpenRead(fd.FileName))
                            {
                                colours = serializer.Deserialize(fs);
                            }

                            if (colours != null)
                            {
                                while (colours.Count > 96)
                                {
                                    colours.RemoveAt(colours.Count - 1);
                                }

                                while (colours.Count < 96)
                                {
                                    colours.Add(Color.White);
                                }

                                cgColourPalette.Colors = colours;
                            }
                        }
                        else
                        {
                            KryptonMessageBoxExtended.Show("Sorry, unable to open palette, the file format is not supported or is not recognized.", "Load Palette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception exc)
                    {
                        KryptonMessageBoxExtended.Show($@"Sorry, unable to open palette. { exc.GetBaseException().Message }", "Load Palette", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void KbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }

        private void CbColourPreview_Paint(object sender, PaintEventArgs e)
        {
            Rectangle region;

            region = cbColourPreview.ClientRectangle;

            if (Colour.A != 255)
            {
                if (_textureBrush == null)
                {
                    using (Bitmap bg = new Bitmap(GetType().Assembly.GetManifestResourceStream(string.Concat(GetType().Namespace, ".Resources.cellbackground.png"))))
                    {
                        _textureBrush = new TextureBrush(bg, WrapMode.Tile);
                    }
                }

                e.Graphics.FillRectangle(_textureBrush, region);
            }

            using (Brush brush = new SolidBrush(this.Colour))
            {
                e.Graphics.FillRectangle(brush, region);
            }

            e.Graphics.DrawRectangle(SystemPens.ControlText, region.Left, region.Top, region.Width - 1, region.Height - 1);
        }

        private void KbtnSaveColourPalette_Click(object sender, EventArgs e)
        {
            using (FileDialog fd = new SaveFileDialog { Filter = Cyotek.Windows.Forms.PaletteSerializer.DefaultSaveFilter, DefaultExt = "pal", Title = "Save custom palette as:" })
            {
                if (fd.ShowDialog(this) == DialogResult.OK)
                {
                    Cyotek.Windows.Forms.IPaletteSerializer serializer;

                    serializer = Cyotek.Windows.Forms.PaletteSerializer.AllSerializers.Where(s => s.CanWrite).ElementAt(fd.FilterIndex - 1);

                    if (serializer != null)
                    {
                        if (!serializer.CanWrite) throw new InvalidOperationException("Serializer does not support writing palettes.");
                    }

                    try
                    {
                        using (FileStream fs = File.OpenWrite(fd.FileName))
                        {
                            serializer.Serialize(fs, cgColourPalette.Colors);
                        }
                    }
                    catch (Exception exc)
                    {
                        KryptonMessageBoxExtended.Show($@"Sorry, unable to save palette. { exc.GetBaseException().Message }", "Save Palette", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    KryptonMessageBoxExtended.Show("Sorry, unable to save palette, the file format is not supported or is not recognised.", "Save Palette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}