﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing.Drawing2D;

namespace Playground
{
    public class StatusStripControls : KryptonForm
    {
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ExtendedControls.ExtendedToolkit.ToolstripControls.ExtendedToolStripStatusLabel extsslTest;
        private ExtendedControls.ExtendedToolkit.ToolstripControls.KryptonNumericUpDownToolStripItem knudtsiTest;
        private ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls.Office2007ColorPickerToolStripMenuItem o07cptsiTest;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonColourButtonToolStripMenuItem kcbtsmiTest;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTrackBarToolStripMenuItem ktbtsmiTest;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonViewBar kvbTest;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems.KryptonSliderBar ksbTest;
        private KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls.ToolStripMenuItemUACSheld tsmiuacsTest;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid kpgStatusStripItems;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonToolStripStatusLabelExtended ktssleTest;
        private System.ComponentModel.IContainer components;
        private ExtendedControls.ExtendedToolkit.ToolstripControls.ExtendedToolStripStatusLabel etslTest;
        private KryptonCheckButton kcbtnBackwardDiagonal;
        private KryptonCheckButton kcbtnForwardDiagonal;
        private KryptonCheckButton kcbtnVertical;
        private KryptonCheckButton kcbtnHorizontal;
        private KryptonColorButton kcbtnTextColour;
        private KryptonColorButton kcbtnGradientColour2;
        private KryptonColorButton kcbtnGradientColour1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusStripControls));
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues9 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.knudtsiTest = new ExtendedControls.ExtendedToolkit.ToolstripControls.KryptonNumericUpDownToolStripItem();
            this.o07cptsiTest = new ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls.Office2007ColorPickerToolStripMenuItem();
            this.kcbtsmiTest = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonColourButtonToolStripMenuItem();
            this.ktbtsmiTest = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTrackBarToolStripMenuItem();
            this.kvbTest = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonViewBar();
            this.ksbTest = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems.KryptonSliderBar();
            this.tsmiuacsTest = new KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls.ToolStripMenuItemUACSheld();
            this.etslTest = new ExtendedControls.ExtendedToolkit.ToolstripControls.ExtendedToolStripStatusLabel();
            this.kpgStatusStripItems = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid();
            this.kcbtnBackwardDiagonal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcbtnForwardDiagonal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcbtnVertical = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcbtnHorizontal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcbtnTextColour = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kcbtnGradientColour2 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kcbtnGradientColour1 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.statusStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 646);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1070, 22);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knudtsiTest,
            this.o07cptsiTest,
            this.kcbtsmiTest,
            this.ktbtsmiTest,
            this.kvbTest,
            this.ksbTest,
            this.tsmiuacsTest,
            this.etslTest});
            this.statusStrip1.Location = new System.Drawing.Point(0, -3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1070, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // knudtsiTest
            // 
            this.knudtsiTest.AutoSize = false;
            this.knudtsiTest.Name = "knudtsiTest";
            this.knudtsiTest.Size = new System.Drawing.Size(50, 23);
            this.knudtsiTest.Text = "0";
            this.knudtsiTest.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudtsiTest.Click += new System.EventHandler(this.KnudtsiTest_Click);
            // 
            // o07cptsiTest
            // 
            this.o07cptsiTest.Name = "o07cptsiTest";
            // 
            // o07cptsiTest
            // 
            this.o07cptsiTest.Office2007ColourPickerControl.AccessibleName = "o07cptsiTest";
            this.o07cptsiTest.Office2007ColourPickerControl.Color = System.Drawing.Color.Black;
            this.o07cptsiTest.Office2007ColourPickerControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.o07cptsiTest.Office2007ColourPickerControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.o07cptsiTest.Office2007ColourPickerControl.Items.AddRange(new object[] {
            "Color"});
            this.o07cptsiTest.Office2007ColourPickerControl.Location = new System.Drawing.Point(51, 2);
            this.o07cptsiTest.Office2007ColourPickerControl.Name = "o07cptsiTest";
            this.o07cptsiTest.Office2007ColourPickerControl.Size = new System.Drawing.Size(121, 24);
            this.o07cptsiTest.Office2007ColourPickerControl.TabIndex = 2;
            this.o07cptsiTest.Size = new System.Drawing.Size(121, 23);
            this.o07cptsiTest.Text = "Color";
            // 
            // kcbtsmiTest
            // 
            this.kcbtsmiTest.AutoSize = false;
            // 
            // kcbtsmiTest
            // 
            this.kcbtsmiTest.KryptonColorButtonControl.AccessibleName = "kcbtsmiTest";
            this.kcbtsmiTest.KryptonColorButtonControl.Location = new System.Drawing.Point(172, 2);
            this.kcbtsmiTest.KryptonColorButtonControl.Name = "kcbtsmiTest";
            this.kcbtsmiTest.KryptonColorButtonControl.Size = new System.Drawing.Size(90, 23);
            this.kcbtsmiTest.KryptonColorButtonControl.TabIndex = 3;
            popupPositionValues1.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtsmiTest.KryptonColorButtonControl.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.kcbtsmiTest.Name = "kcbtsmiTest";
            this.kcbtsmiTest.Size = new System.Drawing.Size(90, 23);
            this.kcbtsmiTest.Text = "Color";
            // 
            // ktbtsmiTest
            // 
            this.ktbtsmiTest.AutoSize = false;
            // 
            // ktbtsmiTest
            // 
            this.ktbtsmiTest.KryptonTrackBarControl.AccessibleName = "ktbtsmiTest";
            this.ktbtsmiTest.KryptonTrackBarControl.DrawBackground = true;
            this.ktbtsmiTest.KryptonTrackBarControl.Location = new System.Drawing.Point(262, 2);
            this.ktbtsmiTest.KryptonTrackBarControl.Name = "ktbtsmiTest";
            this.ktbtsmiTest.KryptonTrackBarControl.Size = new System.Drawing.Size(150, 23);
            this.ktbtsmiTest.KryptonTrackBarControl.TabIndex = 4;
            popupPositionValues2.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.ktbtsmiTest.KryptonTrackBarControl.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.ktbtsmiTest.LargeChange = 5;
            this.ktbtsmiTest.Maximum = 10;
            this.ktbtsmiTest.Minimum = 0;
            this.ktbtsmiTest.Name = "ktbtsmiTest";
            this.ktbtsmiTest.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.ktbtsmiTest.Size = new System.Drawing.Size(150, 23);
            this.ktbtsmiTest.SmallChange = 1;
            this.ktbtsmiTest.Text = "kryptonTrackBarToolStripMenuItem1";
            this.ktbtsmiTest.TickFrequency = 1;
            this.ktbtsmiTest.TickStyle = System.Windows.Forms.TickStyle.BottomRight;
            this.ktbtsmiTest.TrackBarSize = ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize.Medium;
            this.ktbtsmiTest.Value = 0;
            this.ktbtsmiTest.VolumeControl = false;
            // 
            // kvbTest
            // 
            this.kvbTest.BackColor = System.Drawing.Color.Transparent;
            this.kvbTest.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kvbTest.Name = "kvbTest";
            this.kvbTest.Size = new System.Drawing.Size(117, 23);
            this.kvbTest.Text = "kryptonViewBar1";
            this.kvbTest.ViewBarSize = new System.Drawing.Size(117, 23);
            // 
            // ksbTest
            // 
            this.ksbTest.BackColor = System.Drawing.Color.Transparent;
            this.ksbTest.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ksbTest.Name = "ksbTest";
            this.ksbTest.Size = new System.Drawing.Size(140, 23);
            this.ksbTest.Steps = 2;
            this.ksbTest.Text = "kryptonSliderBar1";
            this.ksbTest.TrackerSize = new System.Drawing.Size(140, 23);
            // 
            // tsmiuacsTest
            // 
            this.tsmiuacsTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiuacsTest.Image")));
            this.tsmiuacsTest.Name = "tsmiuacsTest";
            this.tsmiuacsTest.Size = new System.Drawing.Size(194, 25);
            this.tsmiuacsTest.Text = "toolStripMenuItemUACSheld1";
            // 
            // etslTest
            // 
            this.etslTest.BackColor = System.Drawing.Color.Empty;
            this.etslTest.BkClr = false;
            this.etslTest.BlinkDuration = ((long)(10));
            this.etslTest.BlinkState = ExtendedControls.Base.Enumerations.BlinkState.NormalBlink;
            this.etslTest.CycleInterval = ((short)(2000));
            this.etslTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.etslTest.GradientColourOne = System.Drawing.Color.Empty;
            this.etslTest.GradientColourTwo = System.Drawing.Color.Empty;
            this.etslTest.Name = "etslTest";
            this.etslTest.Size = new System.Drawing.Size(76, 20);
            this.etslTest.Text = "Gradient Test";
            this.etslTest.Click += new System.EventHandler(this.EtslTest_Click);
            // 
            // kpgStatusStripItems
            // 
            this.kpgStatusStripItems.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgStatusStripItems.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgStatusStripItems.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgStatusStripItems.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgStatusStripItems.Location = new System.Drawing.Point(12, 12);
            this.kpgStatusStripItems.Name = "kpgStatusStripItems";
            this.kpgStatusStripItems.Size = new System.Drawing.Size(349, 612);
            this.kpgStatusStripItems.TabIndex = 1;
            // 
            // kcbtnBackwardDiagonal
            // 
            this.kcbtnBackwardDiagonal.Location = new System.Drawing.Point(403, 92);
            this.kcbtnBackwardDiagonal.Name = "kcbtnBackwardDiagonal";
            this.kcbtnBackwardDiagonal.Size = new System.Drawing.Size(150, 25);
            this.kcbtnBackwardDiagonal.TabIndex = 23;
            popupPositionValues3.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtnBackwardDiagonal.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.kcbtnBackwardDiagonal.Values.Text = "&Backward Diagonal";
            this.kcbtnBackwardDiagonal.Click += new System.EventHandler(this.KcbtnBackwardDiagonal_Click);
            // 
            // kcbtnForwardDiagonal
            // 
            this.kcbtnForwardDiagonal.Checked = true;
            this.kcbtnForwardDiagonal.Location = new System.Drawing.Point(402, 252);
            this.kcbtnForwardDiagonal.Name = "kcbtnForwardDiagonal";
            this.kcbtnForwardDiagonal.Size = new System.Drawing.Size(150, 25);
            this.kcbtnForwardDiagonal.TabIndex = 22;
            popupPositionValues4.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtnForwardDiagonal.ToolTipValues.ToolTipPosition = popupPositionValues4;
            this.kcbtnForwardDiagonal.Values.Text = "&Forward Diagonal";
            this.kcbtnForwardDiagonal.Click += new System.EventHandler(this.KcbtnForwardDiagonal_Click);
            // 
            // kcbtnVertical
            // 
            this.kcbtnVertical.Location = new System.Drawing.Point(403, 172);
            this.kcbtnVertical.Name = "kcbtnVertical";
            this.kcbtnVertical.Size = new System.Drawing.Size(150, 25);
            this.kcbtnVertical.TabIndex = 21;
            popupPositionValues5.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtnVertical.ToolTipValues.ToolTipPosition = popupPositionValues5;
            this.kcbtnVertical.Values.Text = "Ver&tical";
            this.kcbtnVertical.Click += new System.EventHandler(this.KcbtnVertical_Click);
            // 
            // kcbtnHorizontal
            // 
            this.kcbtnHorizontal.Location = new System.Drawing.Point(402, 12);
            this.kcbtnHorizontal.Name = "kcbtnHorizontal";
            this.kcbtnHorizontal.Size = new System.Drawing.Size(150, 25);
            this.kcbtnHorizontal.TabIndex = 20;
            popupPositionValues6.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtnHorizontal.ToolTipValues.ToolTipPosition = popupPositionValues6;
            this.kcbtnHorizontal.Values.Text = "&Horizontal";
            this.kcbtnHorizontal.Click += new System.EventHandler(this.KcbtnHorizontal_Click);
            // 
            // kcbtnTextColour
            // 
            this.kcbtnTextColour.AutoSize = true;
            this.kcbtnTextColour.Location = new System.Drawing.Point(402, 488);
            this.kcbtnTextColour.Name = "kcbtnTextColour";
            this.kcbtnTextColour.Size = new System.Drawing.Size(136, 25);
            this.kcbtnTextColour.TabIndex = 26;
            popupPositionValues7.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtnTextColour.ToolTipValues.ToolTipPosition = popupPositionValues7;
            this.kcbtnTextColour.Values.Text = "Text Colour";
            this.kcbtnTextColour.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.KcbtnTextColour_SelectedColorChanged);
            // 
            // kcbtnGradientColour2
            // 
            this.kcbtnGradientColour2.AutoSize = true;
            this.kcbtnGradientColour2.Location = new System.Drawing.Point(403, 401);
            this.kcbtnGradientColour2.Name = "kcbtnGradientColour2";
            this.kcbtnGradientColour2.Size = new System.Drawing.Size(136, 25);
            this.kcbtnGradientColour2.TabIndex = 25;
            popupPositionValues8.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtnGradientColour2.ToolTipValues.ToolTipPosition = popupPositionValues8;
            this.kcbtnGradientColour2.Values.Text = "Gradient Colour 2";
            this.kcbtnGradientColour2.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.KcbtnGradientColour2_SelectedColorChanged);
            // 
            // kcbtnGradientColour1
            // 
            this.kcbtnGradientColour1.AutoSize = true;
            this.kcbtnGradientColour1.Location = new System.Drawing.Point(403, 314);
            this.kcbtnGradientColour1.Name = "kcbtnGradientColour1";
            this.kcbtnGradientColour1.Size = new System.Drawing.Size(136, 25);
            this.kcbtnGradientColour1.TabIndex = 24;
            popupPositionValues9.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcbtnGradientColour1.ToolTipValues.ToolTipPosition = popupPositionValues9;
            this.kcbtnGradientColour1.Values.Text = "Gradient Colour 1";
            this.kcbtnGradientColour1.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.KcbtnGradientColour1_SelectedColorChanged);
            // 
            // StatusStripControls
            // 
            this.ClientSize = new System.Drawing.Size(1070, 668);
            this.Controls.Add(this.kcbtnTextColour);
            this.Controls.Add(this.kcbtnGradientColour2);
            this.Controls.Add(this.kcbtnGradientColour1);
            this.Controls.Add(this.kcbtnBackwardDiagonal);
            this.Controls.Add(this.kcbtnForwardDiagonal);
            this.Controls.Add(this.kcbtnVertical);
            this.Controls.Add(this.kcbtnHorizontal);
            this.Controls.Add(this.kpgStatusStripItems);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "StatusStripControls";
            this.Click += new System.EventHandler(this.StatusStripControls_Click);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public StatusStripControls()
        {
            InitializeComponent();
        }

        private void StatusStripControls_Click(object sender, EventArgs e)
        {

        }

        private void EtslTest_Click(object sender, EventArgs e)
        {
            kpgStatusStripItems.SelectedObject = etslTest;
        }

        private void KnudtsiTest_Click(object sender, EventArgs e)
        {
            kpgStatusStripItems.SelectedObject = knudtsiTest;
        }

        private void KcbtnHorizontal_Click(object sender, EventArgs e)
        {
            etslTest.GradientMode = LinearGradientMode.Horizontal;

            kcbtnHorizontal.Checked = true;

            kcbtnVertical.Checked = false;

            kcbtnForwardDiagonal.Checked = false;

            kcbtnBackwardDiagonal.Checked = false;
        }

        private void KcbtnVertical_Click(object sender, EventArgs e)
        {
            etslTest.GradientMode = LinearGradientMode.Vertical;

            kcbtnHorizontal.Checked = false;

            kcbtnVertical.Checked = true;

            kcbtnForwardDiagonal.Checked = false;

            kcbtnBackwardDiagonal.Checked = false;
        }

        private void KcbtnForwardDiagonal_Click(object sender, EventArgs e)
        {
            etslTest.GradientMode = LinearGradientMode.ForwardDiagonal;

            kcbtnHorizontal.Checked = false;

            kcbtnVertical.Checked = false;

            kcbtnForwardDiagonal.Checked = true;

            kcbtnBackwardDiagonal.Checked = false;
        }

        private void KcbtnBackwardDiagonal_Click(object sender, EventArgs e)
        {
            etslTest.GradientMode = LinearGradientMode.BackwardDiagonal;

            kcbtnHorizontal.Checked = false;

            kcbtnVertical.Checked = false;

            kcbtnForwardDiagonal.Checked = false;

            kcbtnBackwardDiagonal.Checked = true;
        }

        private void KcbtnGradientColour1_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            etslTest.GradientColourOne = kcbtnGradientColour1.SelectedColor;
        }

        private void KcbtnGradientColour2_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            etslTest.GradientColourTwo = kcbtnGradientColour2.SelectedColor;
        }

        private void KcbtnTextColour_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            etslTest.ForeColor = kcbtnTextColour.SelectedColor;
        }
    }
}