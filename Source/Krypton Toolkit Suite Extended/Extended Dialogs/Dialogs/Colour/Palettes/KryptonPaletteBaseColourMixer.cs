using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs
{
    public class KryptonPaletteBaseColourMixer : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonLabel kryptonLabel15;
        private KryptonLabel kryptonLabel12;
        private KryptonLabel kryptonLabel13;
        private KryptonLabel kryptonLabel14;
        private KryptonLabel kryptonLabel16;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox circularPictureBox1;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox circularPictureBox2;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox circularPictureBox3;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox circularPictureBox4;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox circularPictureBox5;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel2;
        private ExtendedColourControls.KryptonAlphaTrackBar kryptonAlphaTrackBar1;
        private ExtendedColourControls.KryptonRedTrackBar kryptonRedTrackBar1;
        private ExtendedColourControls.KryptonGreenTrackBar kryptonGreenTrackBar1;
        private ExtendedColourControls.KryptonBlueTrackBar kryptonBlueTrackBar1;
        private ExtendedColourControls.KryptonAlphaValueNumericBox kryptonAlphaValueNumericBox1;
        private ExtendedColourControls.KryptonRedValueNumericBox kryptonRedValueNumericBox1;
        private ExtendedColourControls.KryptonGreenValueNumericBox kryptonGreenValueNumericBox1;
        private ExtendedColourControls.KryptonBlueValueNumericBox kryptonBlueValueNumericBox1;
        private KryptonGroupBox kryptonGroupBox1;
        private KryptonButton kbtnGenerateAlpha;
        private KryptonButton kbtnGenerateRedValue;
        private KryptonButton kbtnGenerateGreenValue;
        private KryptonButton kbtnGenerateBlueValue;
        private KryptonComboBox kcmbDefinedColour;
        private KryptonLabel kryptonLabel5;
        private KryptonButton kbtnExportSelectedColour;
        private KryptonButton kbtnOk;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.circularPictureBox1 = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.circularPictureBox2 = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.circularPictureBox3 = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.circularPictureBox4 = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.circularPictureBox5 = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonAlphaTrackBar1 = new ExtendedColourControls.KryptonAlphaTrackBar();
            this.kryptonRedTrackBar1 = new ExtendedColourControls.KryptonRedTrackBar();
            this.kryptonGreenTrackBar1 = new ExtendedColourControls.KryptonGreenTrackBar();
            this.kryptonBlueTrackBar1 = new ExtendedColourControls.KryptonBlueTrackBar();
            this.kryptonAlphaValueNumericBox1 = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.kryptonRedValueNumericBox1 = new ExtendedColourControls.KryptonRedValueNumericBox();
            this.kryptonGreenValueNumericBox1 = new ExtendedColourControls.KryptonGreenValueNumericBox();
            this.kryptonBlueValueNumericBox1 = new ExtendedColourControls.KryptonBlueValueNumericBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnGenerateAlpha = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateRedValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmbDefinedColour = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnExportSelectedColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbDefinedColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 590);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(758, 45);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnExportSelectedColour);
            this.kryptonPanel2.Controls.Add(this.kcmbDefinedColour);
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueNumericBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonRedValueNumericBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonGreenValueNumericBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonBlueValueNumericBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel15);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(758, 587);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(24, 348);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(108, 26);
            this.kryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel15.TabIndex = 86;
            this.kryptonLabel15.Values.Text = "Light Colour";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(28, 12);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(104, 26);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 83;
            this.kryptonLabel12.Values.Text = "Base Colour";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(17, 124);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(127, 26);
            this.kryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.TabIndex = 84;
            this.kryptonLabel13.Values.Text = "Darkest Colour";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(17, 236);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(122, 26);
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel14.TabIndex = 85;
            this.kryptonLabel14.Values.Text = "Middle Colour";
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(17, 460);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(130, 26);
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel16.TabIndex = 87;
            this.kryptonLabel16.Values.Text = "Lightest Colour";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.circularPictureBox1.Location = new System.Drawing.Point(43, 49);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.circularPictureBox1.TabIndex = 3;
            this.circularPictureBox1.TabStop = false;
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.circularPictureBox2.Location = new System.Drawing.Point(43, 497);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(64, 64);
            this.circularPictureBox2.TabIndex = 4;
            this.circularPictureBox2.TabStop = false;
            // 
            // circularPictureBox3
            // 
            this.circularPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.circularPictureBox3.Location = new System.Drawing.Point(43, 385);
            this.circularPictureBox3.Name = "circularPictureBox3";
            this.circularPictureBox3.Size = new System.Drawing.Size(64, 64);
            this.circularPictureBox3.TabIndex = 5;
            this.circularPictureBox3.TabStop = false;
            // 
            // circularPictureBox4
            // 
            this.circularPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.circularPictureBox4.Location = new System.Drawing.Point(43, 273);
            this.circularPictureBox4.Name = "circularPictureBox4";
            this.circularPictureBox4.Size = new System.Drawing.Size(64, 64);
            this.circularPictureBox4.TabIndex = 6;
            this.circularPictureBox4.TabStop = false;
            // 
            // circularPictureBox5
            // 
            this.circularPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.circularPictureBox5.Location = new System.Drawing.Point(43, 161);
            this.circularPictureBox5.Name = "circularPictureBox5";
            this.circularPictureBox5.Size = new System.Drawing.Size(64, 64);
            this.circularPictureBox5.TabIndex = 7;
            this.circularPictureBox5.TabStop = false;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Enabled = false;
            this.kryptonLabel10.Location = new System.Drawing.Point(214, 12);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 98;
            this.kryptonLabel10.Values.Text = "Alpha:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Enabled = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(513, 12);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 97;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Enabled = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(415, 12);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 96;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Enabled = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(327, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 95;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // kryptonAlphaTrackBar1
            // 
            this.kryptonAlphaTrackBar1.DrawBackground = true;
            this.kryptonAlphaTrackBar1.Location = new System.Drawing.Point(234, 44);
            this.kryptonAlphaTrackBar1.Maximum = 255;
            this.kryptonAlphaTrackBar1.Name = "kryptonAlphaTrackBar1";
            this.kryptonAlphaTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonAlphaTrackBar1.Size = new System.Drawing.Size(21, 485);
            this.kryptonAlphaTrackBar1.TabIndex = 8;
            this.kryptonAlphaTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kryptonAlphaTrackBar1.Value = 255;
            // 
            // kryptonRedTrackBar1
            // 
            this.kryptonRedTrackBar1.DrawBackground = true;
            this.kryptonRedTrackBar1.Location = new System.Drawing.Point(340, 44);
            this.kryptonRedTrackBar1.Maximum = 255;
            this.kryptonRedTrackBar1.Name = "kryptonRedTrackBar1";
            this.kryptonRedTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonRedTrackBar1.Size = new System.Drawing.Size(21, 485);
            this.kryptonRedTrackBar1.StateCommon.Tick.Color1 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.TabIndex = 9;
            this.kryptonRedTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // kryptonGreenTrackBar1
            // 
            this.kryptonGreenTrackBar1.DrawBackground = true;
            this.kryptonGreenTrackBar1.Location = new System.Drawing.Point(438, 44);
            this.kryptonGreenTrackBar1.Maximum = 255;
            this.kryptonGreenTrackBar1.Name = "kryptonGreenTrackBar1";
            this.kryptonGreenTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonGreenTrackBar1.Size = new System.Drawing.Size(21, 485);
            this.kryptonGreenTrackBar1.StateCommon.Tick.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.TabIndex = 10;
            this.kryptonGreenTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // kryptonBlueTrackBar1
            // 
            this.kryptonBlueTrackBar1.DrawBackground = true;
            this.kryptonBlueTrackBar1.Location = new System.Drawing.Point(529, 44);
            this.kryptonBlueTrackBar1.Maximum = 255;
            this.kryptonBlueTrackBar1.Name = "kryptonBlueTrackBar1";
            this.kryptonBlueTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBlueTrackBar1.Size = new System.Drawing.Size(21, 485);
            this.kryptonBlueTrackBar1.StateCommon.Tick.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.TabIndex = 11;
            this.kryptonBlueTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // kryptonAlphaValueNumericBox1
            // 
            this.kryptonAlphaValueNumericBox1.Location = new System.Drawing.Point(214, 535);
            this.kryptonAlphaValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonAlphaValueNumericBox1.Name = "kryptonAlphaValueNumericBox1";
            this.kryptonAlphaValueNumericBox1.Size = new System.Drawing.Size(62, 26);
            this.kryptonAlphaValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonAlphaValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonAlphaValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonAlphaValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonAlphaValueNumericBox1.TabIndex = 12;
            this.kryptonAlphaValueNumericBox1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // kryptonRedValueNumericBox1
            // 
            this.kryptonRedValueNumericBox1.Location = new System.Drawing.Point(327, 535);
            this.kryptonRedValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonRedValueNumericBox1.Name = "kryptonRedValueNumericBox1";
            this.kryptonRedValueNumericBox1.Size = new System.Drawing.Size(62, 26);
            this.kryptonRedValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonRedValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonRedValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonRedValueNumericBox1.TabIndex = 13;
            // 
            // kryptonGreenValueNumericBox1
            // 
            this.kryptonGreenValueNumericBox1.Location = new System.Drawing.Point(415, 535);
            this.kryptonGreenValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonGreenValueNumericBox1.Name = "kryptonGreenValueNumericBox1";
            this.kryptonGreenValueNumericBox1.Size = new System.Drawing.Size(62, 26);
            this.kryptonGreenValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonGreenValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonGreenValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonGreenValueNumericBox1.TabIndex = 14;
            // 
            // kryptonBlueValueNumericBox1
            // 
            this.kryptonBlueValueNumericBox1.Location = new System.Drawing.Point(513, 535);
            this.kryptonBlueValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonBlueValueNumericBox1.Name = "kryptonBlueValueNumericBox1";
            this.kryptonBlueValueNumericBox1.Size = new System.Drawing.Size(62, 26);
            this.kryptonBlueValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonBlueValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonBlueValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonBlueValueNumericBox1.TabIndex = 15;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Enabled = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(576, 65);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateAlpha);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateRedValue);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateGreenValue);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateBlueValue);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(154, 197);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 103;
            this.kryptonGroupBox1.Values.Heading = "Colour Options";
            // 
            // kbtnGenerateAlpha
            // 
            this.kbtnGenerateAlpha.AutoSize = true;
            this.kbtnGenerateAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateAlpha.Location = new System.Drawing.Point(13, 14);
            this.kbtnGenerateAlpha.Name = "kbtnGenerateAlpha";
            this.kbtnGenerateAlpha.Size = new System.Drawing.Size(125, 30);
            this.kbtnGenerateAlpha.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateAlpha.TabIndex = 101;
            this.kbtnGenerateAlpha.Values.Text = "Generate &Alpha";
            // 
            // kbtnGenerateRedValue
            // 
            this.kbtnGenerateRedValue.AutoSize = true;
            this.kbtnGenerateRedValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateRedValue.Location = new System.Drawing.Point(13, 52);
            this.kbtnGenerateRedValue.Name = "kbtnGenerateRedValue";
            this.kbtnGenerateRedValue.Size = new System.Drawing.Size(111, 30);
            this.kbtnGenerateRedValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateRedValue.TabIndex = 91;
            this.kbtnGenerateRedValue.Values.Text = "Generate &Red";
            // 
            // kbtnGenerateGreenValue
            // 
            this.kbtnGenerateGreenValue.AutoSize = true;
            this.kbtnGenerateGreenValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateGreenValue.Location = new System.Drawing.Point(13, 90);
            this.kbtnGenerateGreenValue.Name = "kbtnGenerateGreenValue";
            this.kbtnGenerateGreenValue.Size = new System.Drawing.Size(126, 30);
            this.kbtnGenerateGreenValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateGreenValue.TabIndex = 92;
            this.kbtnGenerateGreenValue.Values.Text = "Generate &Green";
            // 
            // kbtnGenerateBlueValue
            // 
            this.kbtnGenerateBlueValue.AutoSize = true;
            this.kbtnGenerateBlueValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateBlueValue.Location = new System.Drawing.Point(13, 128);
            this.kbtnGenerateBlueValue.Name = "kbtnGenerateBlueValue";
            this.kbtnGenerateBlueValue.Size = new System.Drawing.Size(114, 30);
            this.kbtnGenerateBlueValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateBlueValue.TabIndex = 93;
            this.kbtnGenerateBlueValue.Values.Text = "Generate &Blue";
            // 
            // kcmbDefinedColour
            // 
            this.kcmbDefinedColour.AutoCompleteCustomSource.AddRange(new string[] {
            "Base Colour",
            "Darkest Colour",
            "Middle Colour",
            "Light Colour",
            "Lightest Colour"});
            this.kcmbDefinedColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbDefinedColour.DropDownWidth = 173;
            this.kcmbDefinedColour.IntegralHeight = false;
            this.kcmbDefinedColour.Items.AddRange(new object[] {
            "Base Colour",
            "Darkest Colour",
            "Middle Colour",
            "Light Colour",
            "Lightest Colour"});
            this.kcmbDefinedColour.Location = new System.Drawing.Point(569, 347);
            this.kcmbDefinedColour.Name = "kcmbDefinedColour";
            this.kcmbDefinedColour.Size = new System.Drawing.Size(177, 27);
            this.kcmbDefinedColour.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbDefinedColour.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbDefinedColour.TabIndex = 33;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(591, 304);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(123, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 32;
            this.kryptonLabel5.Values.Text = "Define Colour:";
            // 
            // kbtnExportSelectedColour
            // 
            this.kbtnExportSelectedColour.AutoSize = true;
            this.kbtnExportSelectedColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnExportSelectedColour.Enabled = false;
            this.kbtnExportSelectedColour.Location = new System.Drawing.Point(569, 395);
            this.kbtnExportSelectedColour.Name = "kbtnExportSelectedColour";
            this.kbtnExportSelectedColour.Size = new System.Drawing.Size(177, 30);
            this.kbtnExportSelectedColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExportSelectedColour.TabIndex = 101;
            this.kbtnExportSelectedColour.Values.Text = "&Export Selected Colour";
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(714, 6);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 102;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // KryptonPaletteBaseColourMixer
            // 
            this.AcceptButton = this.kbtnOk;
            this.ClientSize = new System.Drawing.Size(758, 635);
            this.Controls.Add(this.kryptonBlueTrackBar1);
            this.Controls.Add(this.kryptonGreenTrackBar1);
            this.Controls.Add(this.kryptonRedTrackBar1);
            this.Controls.Add(this.kryptonAlphaTrackBar1);
            this.Controls.Add(this.circularPictureBox5);
            this.Controls.Add(this.circularPictureBox4);
            this.Controls.Add(this.circularPictureBox3);
            this.Controls.Add(this.circularPictureBox2);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonPaletteBaseColourMixer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbDefinedColour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}