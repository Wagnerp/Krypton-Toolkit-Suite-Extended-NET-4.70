﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using PaletteExplorer.Classes;
using System;
using System.Drawing;
using ToolkitSettings.Classes.PaletteExplorer;

namespace PaletteExplorer.UX.Colour
{
    public class ColourMixerAdvanced : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel2;
        private KryptonLabel kryptonLabel7;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightestColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMediumColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDarkColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxBaseColour;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel2;
        private KryptonNumericUpDown knumAlpaValue;
        private KryptonLabel kryptonLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel cwSelectedColour;
        private System.Windows.Forms.Panel panel1;
        private KryptonLabel klblRedValue;
        private KryptonLabel klblGreenValue;
        private KryptonLabel klblBlueValue;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel8;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnGenerate;
        private KryptonButton kbtnGenerateARGB;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourMixerAdvanced));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnGenerate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblRedValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbxLightestColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLightColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxMediumColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxDarkColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxBaseColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumAlpaValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cwSelectedColour = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kbtnGenerateARGB = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnGenerateARGB);
            this.kryptonPanel1.Controls.Add(this.kbtnGenerate);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 639);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(851, 65);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnGenerate
            // 
            this.kbtnGenerate.AutoSize = true;
            this.kbtnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerate.Location = new System.Drawing.Point(12, 15);
            this.kbtnGenerate.Name = "kbtnGenerate";
            this.kbtnGenerate.Size = new System.Drawing.Size(197, 30);
            this.kbtnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerate.TabIndex = 61;
            this.kbtnGenerate.Values.Text = "Gener&ate Random Colour";
            this.kbtnGenerate.Click += new System.EventHandler(this.KbtnGenerate_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(807, 15);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 60;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.klblRedValue);
            this.kryptonPanel2.Controls.Add(this.klblGreenValue);
            this.kryptonPanel2.Controls.Add(this.klblBlueValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel2.Controls.Add(this.cbxLightestColour);
            this.kryptonPanel2.Controls.Add(this.cbxLightColour);
            this.kryptonPanel2.Controls.Add(this.cbxMediumColour);
            this.kryptonPanel2.Controls.Add(this.cbxDarkColour);
            this.kryptonPanel2.Controls.Add(this.cbxBaseColour);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.knumAlpaValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.cwSelectedColour);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(851, 639);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // klblRedValue
            // 
            this.klblRedValue.Location = new System.Drawing.Point(117, 456);
            this.klblRedValue.Name = "klblRedValue";
            this.klblRedValue.Size = new System.Drawing.Size(6, 2);
            this.klblRedValue.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.TabIndex = 23;
            this.klblRedValue.Values.Text = "";
            // 
            // klblGreenValue
            // 
            this.klblGreenValue.Location = new System.Drawing.Point(117, 518);
            this.klblGreenValue.Name = "klblGreenValue";
            this.klblGreenValue.Size = new System.Drawing.Size(6, 2);
            this.klblGreenValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.TabIndex = 22;
            this.klblGreenValue.Values.Text = "";
            // 
            // klblBlueValue
            // 
            this.klblBlueValue.Location = new System.Drawing.Point(117, 580);
            this.klblBlueValue.Name = "klblBlueValue";
            this.klblBlueValue.Size = new System.Drawing.Size(6, 2);
            this.klblBlueValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.TabIndex = 21;
            this.klblBlueValue.Values.Text = "";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(12, 456);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(59, 33);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 20;
            this.kryptonLabel10.Values.Text = "Red:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 518);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(80, 33);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "Green:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(12, 580);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(64, 33);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "Blue:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(546, 272);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(178, 33);
            this.kryptonLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 17;
            this.kryptonLabel7.Values.Text = "Medium Colour:";
            // 
            // cbxLightestColour
            // 
            this.cbxLightestColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLightestColour.BackColor = System.Drawing.Color.White;
            this.cbxLightestColour.Location = new System.Drawing.Point(744, 477);
            this.cbxLightestColour.Name = "cbxLightestColour";
            this.cbxLightestColour.Size = new System.Drawing.Size(95, 95);
            this.cbxLightestColour.TabIndex = 15;
            this.cbxLightestColour.TabStop = false;
            // 
            // cbxLightColour
            // 
            this.cbxLightColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLightColour.BackColor = System.Drawing.Color.White;
            this.cbxLightColour.Location = new System.Drawing.Point(744, 361);
            this.cbxLightColour.Name = "cbxLightColour";
            this.cbxLightColour.Size = new System.Drawing.Size(95, 95);
            this.cbxLightColour.TabIndex = 14;
            this.cbxLightColour.TabStop = false;
            // 
            // cbxMediumColour
            // 
            this.cbxMediumColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMediumColour.BackColor = System.Drawing.Color.White;
            this.cbxMediumColour.Location = new System.Drawing.Point(744, 245);
            this.cbxMediumColour.Name = "cbxMediumColour";
            this.cbxMediumColour.Size = new System.Drawing.Size(95, 95);
            this.cbxMediumColour.TabIndex = 13;
            this.cbxMediumColour.TabStop = false;
            // 
            // cbxDarkColour
            // 
            this.cbxDarkColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDarkColour.BackColor = System.Drawing.Color.White;
            this.cbxDarkColour.Location = new System.Drawing.Point(744, 129);
            this.cbxDarkColour.Name = "cbxDarkColour";
            this.cbxDarkColour.Size = new System.Drawing.Size(95, 95);
            this.cbxDarkColour.TabIndex = 12;
            this.cbxDarkColour.TabStop = false;
            // 
            // cbxBaseColour
            // 
            this.cbxBaseColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBaseColour.BackColor = System.Drawing.Color.White;
            this.cbxBaseColour.Location = new System.Drawing.Point(744, 13);
            this.cbxBaseColour.Name = "cbxBaseColour";
            this.cbxBaseColour.Size = new System.Drawing.Size(95, 95);
            this.cbxBaseColour.TabIndex = 11;
            this.cbxBaseColour.TabStop = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(546, 508);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(175, 33);
            this.kryptonLabel5.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Lightest Colour:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(546, 390);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(145, 33);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Light Colour:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(546, 36);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(140, 33);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Base Colour:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(546, 154);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(141, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Dark Colour:";
            // 
            // knumAlpaValue
            // 
            this.knumAlpaValue.DecimalPlaces = 99;
            this.knumAlpaValue.Location = new System.Drawing.Point(97, 390);
            this.knumAlpaValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlpaValue.Name = "knumAlpaValue";
            this.knumAlpaValue.Size = new System.Drawing.Size(120, 32);
            this.knumAlpaValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumAlpaValue.TabIndex = 5;
            this.knumAlpaValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.knumAlpaValue.ValueChanged += new System.EventHandler(this.KnumAlpaValue_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 387);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 33);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Alpha:";
            // 
            // cwSelectedColour
            // 
            this.cwSelectedColour.BackColor = System.Drawing.Color.Transparent;
            this.cwSelectedColour.Location = new System.Drawing.Point(12, 12);
            this.cwSelectedColour.Name = "cwSelectedColour";
            this.cwSelectedColour.Size = new System.Drawing.Size(352, 362);
            this.cwSelectedColour.TabIndex = 3;
            this.cwSelectedColour.ColourChanged += new System.EventHandler(this.CwSelectedColour_ColourChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 637);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 2);
            this.panel1.TabIndex = 2;
            // 
            // kbtnGenerateARGB
            // 
            this.kbtnGenerateARGB.AutoSize = true;
            this.kbtnGenerateARGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateARGB.Location = new System.Drawing.Point(215, 15);
            this.kbtnGenerateARGB.Name = "kbtnGenerateARGB";
            this.kbtnGenerateARGB.Size = new System.Drawing.Size(242, 30);
            this.kbtnGenerateARGB.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateARGB.TabIndex = 62;
            this.kbtnGenerateARGB.Values.Text = "Gener&ate Random ARGB Colour";
            this.kbtnGenerateARGB.Click += new System.EventHandler(this.KbtnGenerateARGB_Click);
            // 
            // ColourMixerAdvanced
            // 
            this.ClientSize = new System.Drawing.Size(851, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColourMixerAdvanced";
            this.Text = "Krypton Palette Colour Mixer";
            this.Load += new System.EventHandler(this.ColourMixerAdvanced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColour)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        ColourIntensitySettingsManager _colourIntensitySettings = new ColourIntensitySettingsManager();
        #endregion

        #region Constructors
        public ColourMixerAdvanced()
        {
            InitializeComponent();
        }
        #endregion

        private void ColourMixerAdvanced_Load(object sender, EventArgs e)
        {

        }

        private void CwSelectedColour_ColourChanged(object sender, EventArgs e)
        {
            UpdateUI(cwSelectedColour.Colour, cwSelectedColour.Colour.A);
        }

        private void UpdateUI(Color colour, int alphaValue = 255)
        {
            #region Colour Boxes
            cbxBaseColour.BackColor = cwSelectedColour.Colour;

            //cbxBaseColour.BackColor.

            ColourHelpers.GenerateColourShades(cbxBaseColour.BackColor, cbxDarkColour, cbxMediumColour, cbxLightColour, cbxLightestColour, _colourIntensitySettings.GetDarkestColourIntensity(), _colourIntensitySettings.GetMediumColourIntensity(), _colourIntensitySettings.GetLightColourIntensity(), _colourIntensitySettings.GetLightestColourIntensity());
            #endregion

            #region Labels
            klblRedValue.Text = colour.R.ToString();

            klblGreenValue.Text = colour.G.ToString();

            klblBlueValue.Text = colour.B.ToString();
            #endregion

            knumAlpaValue.Value = alphaValue;
        }

        private void KnumAlpaValue_ValueChanged(object sender, EventArgs e)
        {
            UpdateUI(cwSelectedColour.Colour, (int)knumAlpaValue.Value);
        }

        private void KbtnGenerate_Click(object sender, EventArgs e)
        {
            cwSelectedColour.Colour = ColourHelpers.GenerateRandomColour();
        }

        private void KbtnGenerateARGB_Click(object sender, EventArgs e)
        {
            cwSelectedColour.Colour = ColourHelpers.GenerateRandomARGBColour();
        }
    }
}