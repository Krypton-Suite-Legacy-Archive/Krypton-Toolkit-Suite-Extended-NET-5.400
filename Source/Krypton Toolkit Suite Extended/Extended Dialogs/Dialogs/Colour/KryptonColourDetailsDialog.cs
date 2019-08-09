using System;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs
{
    public class KryptonColourDetailsDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel1;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kavlNormal;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel9;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel10;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel11;
        private ExtendedColourControls.KryptonRedValueNumericBox kryptonRedValueNumericBox2;
        private ExtendedColourControls.KryptonGreenValueNumericBox kryptonGreenValueNumericBox2;
        private ExtendedColourControls.KryptonBlueValueNumericBox kryptonBlueValueNumericBox2;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel8;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel7;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel6;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel5;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel4;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel3;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel2;
        private ExtendedColourControls.KryptonAlphaValueNumericBox kryptonAlphaValueNumericBox1;
        private ExtendedColourControls.KryptonRedValueNumericBox kryptonRedValueNumericBox1;
        private ExtendedColourControls.KryptonGreenValueNumericBox kryptonGreenValueNumericBox1;
        private ExtendedColourControls.KryptonBlueValueNumericBox kryptonBlueValueNumericBox1;
        private KryptonButton kbtnOk;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kavlNormal = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueNumericBox1 = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.kryptonRedValueNumericBox1 = new ExtendedColourControls.KryptonRedValueNumericBox();
            this.kryptonGreenValueNumericBox1 = new ExtendedColourControls.KryptonGreenValueNumericBox();
            this.kryptonBlueValueNumericBox1 = new ExtendedColourControls.KryptonBlueValueNumericBox();
            this.kryptonAlphaValueLabel2 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel3 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel4 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel5 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel6 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel7 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel8 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel9 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel10 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonAlphaValueLabel11 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kryptonRedValueNumericBox2 = new ExtendedColourControls.KryptonRedValueNumericBox();
            this.kryptonGreenValueNumericBox2 = new ExtendedColourControls.KryptonGreenValueNumericBox();
            this.kryptonBlueValueNumericBox2 = new ExtendedColourControls.KryptonBlueValueNumericBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 216);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(494, 45);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(451, 6);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 102;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 3);
            this.panel1.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel9);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel11);
            this.kryptonPanel2.Controls.Add(this.kryptonRedValueNumericBox2);
            this.kryptonPanel2.Controls.Add(this.kryptonGreenValueNumericBox2);
            this.kryptonPanel2.Controls.Add(this.kryptonBlueValueNumericBox2);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel8);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel7);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel6);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel5);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueNumericBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonRedValueNumericBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueLabel1);
            this.kryptonPanel2.Controls.Add(this.kryptonGreenValueNumericBox1);
            this.kryptonPanel2.Controls.Add(this.kavlNormal);
            this.kryptonPanel2.Controls.Add(this.kryptonBlueValueNumericBox1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(494, 213);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kavlNormal
            // 
            this.kavlNormal.AlphaValue = 255;
            this.kavlNormal.Location = new System.Drawing.Point(28, 35);
            this.kavlNormal.Name = "kavlNormal";
            this.kavlNormal.Size = new System.Drawing.Size(61, 26);
            this.kavlNormal.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kavlNormal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kavlNormal.TabIndex = 4;
            this.kavlNormal.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kavlNormal.Values.Text = "ARGB:";
            // 
            // kryptonAlphaValueLabel1
            // 
            this.kryptonAlphaValueLabel1.AlphaValue = 255;
            this.kryptonAlphaValueLabel1.Location = new System.Drawing.Point(95, 35);
            this.kryptonAlphaValueLabel1.Name = "kryptonAlphaValueLabel1";
            this.kryptonAlphaValueLabel1.Size = new System.Drawing.Size(18, 26);
            this.kryptonAlphaValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel1.TabIndex = 5;
            this.kryptonAlphaValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel1.Values.Text = "(";
            // 
            // kryptonAlphaValueNumericBox1
            // 
            this.kryptonAlphaValueNumericBox1.Location = new System.Drawing.Point(119, 35);
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
            this.kryptonAlphaValueNumericBox1.TabIndex = 16;
            this.kryptonAlphaValueNumericBox1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // kryptonRedValueNumericBox1
            // 
            this.kryptonRedValueNumericBox1.Location = new System.Drawing.Point(209, 35);
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
            this.kryptonRedValueNumericBox1.TabIndex = 17;
            // 
            // kryptonGreenValueNumericBox1
            // 
            this.kryptonGreenValueNumericBox1.Location = new System.Drawing.Point(299, 35);
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
            this.kryptonGreenValueNumericBox1.TabIndex = 18;
            // 
            // kryptonBlueValueNumericBox1
            // 
            this.kryptonBlueValueNumericBox1.Location = new System.Drawing.Point(389, 35);
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
            this.kryptonBlueValueNumericBox1.TabIndex = 19;
            // 
            // kryptonAlphaValueLabel2
            // 
            this.kryptonAlphaValueLabel2.AlphaValue = 255;
            this.kryptonAlphaValueLabel2.Location = new System.Drawing.Point(187, 35);
            this.kryptonAlphaValueLabel2.Name = "kryptonAlphaValueLabel2";
            this.kryptonAlphaValueLabel2.Size = new System.Drawing.Size(16, 26);
            this.kryptonAlphaValueLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel2.TabIndex = 20;
            this.kryptonAlphaValueLabel2.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel2.Values.Text = ",";
            // 
            // kryptonAlphaValueLabel3
            // 
            this.kryptonAlphaValueLabel3.AlphaValue = 255;
            this.kryptonAlphaValueLabel3.Location = new System.Drawing.Point(277, 35);
            this.kryptonAlphaValueLabel3.Name = "kryptonAlphaValueLabel3";
            this.kryptonAlphaValueLabel3.Size = new System.Drawing.Size(16, 26);
            this.kryptonAlphaValueLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel3.TabIndex = 21;
            this.kryptonAlphaValueLabel3.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel3.Values.Text = ",";
            // 
            // kryptonAlphaValueLabel4
            // 
            this.kryptonAlphaValueLabel4.AlphaValue = 255;
            this.kryptonAlphaValueLabel4.Location = new System.Drawing.Point(367, 35);
            this.kryptonAlphaValueLabel4.Name = "kryptonAlphaValueLabel4";
            this.kryptonAlphaValueLabel4.Size = new System.Drawing.Size(16, 26);
            this.kryptonAlphaValueLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel4.TabIndex = 22;
            this.kryptonAlphaValueLabel4.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel4.Values.Text = ",";
            // 
            // kryptonAlphaValueLabel5
            // 
            this.kryptonAlphaValueLabel5.AlphaValue = 255;
            this.kryptonAlphaValueLabel5.Location = new System.Drawing.Point(457, 35);
            this.kryptonAlphaValueLabel5.Name = "kryptonAlphaValueLabel5";
            this.kryptonAlphaValueLabel5.Size = new System.Drawing.Size(18, 26);
            this.kryptonAlphaValueLabel5.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel5.TabIndex = 23;
            this.kryptonAlphaValueLabel5.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel5.Values.Text = ")";
            // 
            // kryptonAlphaValueLabel6
            // 
            this.kryptonAlphaValueLabel6.AlphaValue = 255;
            this.kryptonAlphaValueLabel6.Location = new System.Drawing.Point(28, 155);
            this.kryptonAlphaValueLabel6.Name = "kryptonAlphaValueLabel6";
            this.kryptonAlphaValueLabel6.Size = new System.Drawing.Size(61, 26);
            this.kryptonAlphaValueLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel6.TabIndex = 24;
            this.kryptonAlphaValueLabel6.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel6.Values.Text = "ARGB:";
            // 
            // kryptonAlphaValueLabel7
            // 
            this.kryptonAlphaValueLabel7.AlphaValue = 255;
            this.kryptonAlphaValueLabel7.Location = new System.Drawing.Point(28, 95);
            this.kryptonAlphaValueLabel7.Name = "kryptonAlphaValueLabel7";
            this.kryptonAlphaValueLabel7.Size = new System.Drawing.Size(49, 26);
            this.kryptonAlphaValueLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel7.TabIndex = 25;
            this.kryptonAlphaValueLabel7.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel7.Values.Text = "RGB:";
            // 
            // kryptonAlphaValueLabel8
            // 
            this.kryptonAlphaValueLabel8.AlphaValue = 255;
            this.kryptonAlphaValueLabel8.Location = new System.Drawing.Point(95, 95);
            this.kryptonAlphaValueLabel8.Name = "kryptonAlphaValueLabel8";
            this.kryptonAlphaValueLabel8.Size = new System.Drawing.Size(18, 26);
            this.kryptonAlphaValueLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel8.TabIndex = 26;
            this.kryptonAlphaValueLabel8.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel8.Values.Text = "(";
            // 
            // kryptonAlphaValueLabel9
            // 
            this.kryptonAlphaValueLabel9.AlphaValue = 255;
            this.kryptonAlphaValueLabel9.Location = new System.Drawing.Point(367, 95);
            this.kryptonAlphaValueLabel9.Name = "kryptonAlphaValueLabel9";
            this.kryptonAlphaValueLabel9.Size = new System.Drawing.Size(18, 26);
            this.kryptonAlphaValueLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel9.TabIndex = 32;
            this.kryptonAlphaValueLabel9.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel9.Values.Text = ")";
            // 
            // kryptonAlphaValueLabel10
            // 
            this.kryptonAlphaValueLabel10.AlphaValue = 255;
            this.kryptonAlphaValueLabel10.Location = new System.Drawing.Point(277, 95);
            this.kryptonAlphaValueLabel10.Name = "kryptonAlphaValueLabel10";
            this.kryptonAlphaValueLabel10.Size = new System.Drawing.Size(16, 26);
            this.kryptonAlphaValueLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel10.TabIndex = 31;
            this.kryptonAlphaValueLabel10.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel10.Values.Text = ",";
            // 
            // kryptonAlphaValueLabel11
            // 
            this.kryptonAlphaValueLabel11.AlphaValue = 255;
            this.kryptonAlphaValueLabel11.Location = new System.Drawing.Point(187, 95);
            this.kryptonAlphaValueLabel11.Name = "kryptonAlphaValueLabel11";
            this.kryptonAlphaValueLabel11.Size = new System.Drawing.Size(16, 26);
            this.kryptonAlphaValueLabel11.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel11.TabIndex = 30;
            this.kryptonAlphaValueLabel11.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel11.Values.Text = ",";
            // 
            // kryptonRedValueNumericBox2
            // 
            this.kryptonRedValueNumericBox2.Location = new System.Drawing.Point(119, 95);
            this.kryptonRedValueNumericBox2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonRedValueNumericBox2.Name = "kryptonRedValueNumericBox2";
            this.kryptonRedValueNumericBox2.Size = new System.Drawing.Size(62, 26);
            this.kryptonRedValueNumericBox2.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueNumericBox2.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonRedValueNumericBox2.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonRedValueNumericBox2.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonRedValueNumericBox2.TabIndex = 27;
            // 
            // kryptonGreenValueNumericBox2
            // 
            this.kryptonGreenValueNumericBox2.Location = new System.Drawing.Point(209, 95);
            this.kryptonGreenValueNumericBox2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonGreenValueNumericBox2.Name = "kryptonGreenValueNumericBox2";
            this.kryptonGreenValueNumericBox2.Size = new System.Drawing.Size(62, 26);
            this.kryptonGreenValueNumericBox2.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueNumericBox2.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonGreenValueNumericBox2.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonGreenValueNumericBox2.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonGreenValueNumericBox2.TabIndex = 28;
            // 
            // kryptonBlueValueNumericBox2
            // 
            this.kryptonBlueValueNumericBox2.Location = new System.Drawing.Point(299, 95);
            this.kryptonBlueValueNumericBox2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonBlueValueNumericBox2.Name = "kryptonBlueValueNumericBox2";
            this.kryptonBlueValueNumericBox2.Size = new System.Drawing.Size(62, 26);
            this.kryptonBlueValueNumericBox2.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueNumericBox2.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonBlueValueNumericBox2.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonBlueValueNumericBox2.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonBlueValueNumericBox2.TabIndex = 29;
            // 
            // KryptonColourDetailsDialog
            // 
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "KryptonColourDetailsDialog";
            this.Load += new System.EventHandler(this.KryptonColourDetailsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void KryptonColourDetailsDialog_Load(object sender, EventArgs e)
        {

        }
    }
}