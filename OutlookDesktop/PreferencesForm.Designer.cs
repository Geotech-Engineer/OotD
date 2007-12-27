﻿namespace OutlookDesktop
{
    partial class PreferencesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.tallLabel = new System.Windows.Forms.Label();
            this.shortLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightSlider = new System.Windows.Forms.TrackBar();
            this.wideLabel = new System.Windows.Forms.Label();
            this.narrowLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthSlider = new System.Windows.Forms.TrackBar();
            this.positionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horizontalPosition = new System.Windows.Forms.HScrollBar();
            this.verticalPosition = new System.Windows.Forms.VScrollBar();
            this.preferencesLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.transparentLabel = new System.Windows.Forms.Label();
            this.opaqueLabel = new System.Windows.Forms.Label();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.transparencySlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.heightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // tallLabel
            // 
            this.tallLabel.Location = new System.Drawing.Point(423, 217);
            this.tallLabel.Name = "tallLabel";
            this.tallLabel.Size = new System.Drawing.Size(44, 17);
            this.tallLabel.TabIndex = 43;
            this.tallLabel.Text = "Tall";
            // 
            // shortLabel
            // 
            this.shortLabel.Location = new System.Drawing.Point(213, 217);
            this.shortLabel.Name = "shortLabel";
            this.shortLabel.Size = new System.Drawing.Size(72, 16);
            this.shortLabel.TabIndex = 42;
            this.shortLabel.Text = "Short";
            // 
            // heightLabel
            // 
            this.heightLabel.Location = new System.Drawing.Point(143, 193);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(63, 18);
            this.heightLabel.TabIndex = 41;
            this.heightLabel.Text = "Height";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heightSlider
            // 
            this.heightSlider.Location = new System.Drawing.Point(207, 191);
            this.heightSlider.Maximum = 600;
            this.heightSlider.Name = "heightSlider";
            this.heightSlider.Size = new System.Drawing.Size(250, 45);
            this.heightSlider.SmallChange = 5;
            this.heightSlider.TabIndex = 40;
            this.heightSlider.TickFrequency = 10;
            this.heightSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.heightSlider.Value = 50;
            this.heightSlider.Scroll += new System.EventHandler(this.heightSlider_Scroll);
            // 
            // wideLabel
            // 
            this.wideLabel.Location = new System.Drawing.Point(417, 157);
            this.wideLabel.Name = "wideLabel";
            this.wideLabel.Size = new System.Drawing.Size(44, 17);
            this.wideLabel.TabIndex = 39;
            this.wideLabel.Text = "Wide";
            // 
            // narrowLabel
            // 
            this.narrowLabel.Location = new System.Drawing.Point(213, 157);
            this.narrowLabel.Name = "narrowLabel";
            this.narrowLabel.Size = new System.Drawing.Size(72, 16);
            this.narrowLabel.TabIndex = 38;
            this.narrowLabel.Text = "Narrow";
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(142, 133);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(63, 18);
            this.widthLabel.TabIndex = 37;
            this.widthLabel.Text = "Width";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthSlider
            // 
            this.widthSlider.Location = new System.Drawing.Point(207, 131);
            this.widthSlider.Maximum = 800;
            this.widthSlider.Name = "widthSlider";
            this.widthSlider.Size = new System.Drawing.Size(250, 45);
            this.widthSlider.SmallChange = 5;
            this.widthSlider.TabIndex = 36;
            this.widthSlider.TickFrequency = 10;
            this.widthSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.widthSlider.Value = 50;
            this.widthSlider.Scroll += new System.EventHandler(this.widthSlider_Scroll);
            // 
            // positionLabel
            // 
            this.positionLabel.Location = new System.Drawing.Point(56, 205);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(49, 14);
            this.positionLabel.TabIndex = 35;
            this.positionLabel.Text = "Position";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // horizontalPosition
            // 
            this.horizontalPosition.Location = new System.Drawing.Point(50, 162);
            this.horizontalPosition.Name = "horizontalPosition";
            this.horizontalPosition.Size = new System.Drawing.Size(54, 20);
            this.horizontalPosition.SmallChange = 10;
            this.horizontalPosition.TabIndex = 33;
            this.horizontalPosition.Value = 100;
            this.horizontalPosition.Scroll += new System.Windows.Forms.ScrollEventHandler(this.horizontalPosition_Scroll);
            // 
            // verticalPosition
            // 
            this.verticalPosition.Location = new System.Drawing.Point(66, 146);
            this.verticalPosition.Name = "verticalPosition";
            this.verticalPosition.Size = new System.Drawing.Size(22, 51);
            this.verticalPosition.SmallChange = 10;
            this.verticalPosition.TabIndex = 32;
            this.verticalPosition.Value = 100;
            this.verticalPosition.Scroll += new System.Windows.Forms.ScrollEventHandler(this.verticalPosition_Scroll);
            // 
            // preferencesLabel
            // 
            this.preferencesLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.preferencesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesLabel.ForeColor = System.Drawing.Color.White;
            this.preferencesLabel.Location = new System.Drawing.Point(6, 7);
            this.preferencesLabel.Name = "preferencesLabel";
            this.preferencesLabel.Size = new System.Drawing.Size(467, 27);
            this.preferencesLabel.TabIndex = 24;
            this.preferencesLabel.Text = "Preferences";
            this.preferencesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cancel.Location = new System.Drawing.Point(250, 266);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 24);
            this.Cancel.TabIndex = 30;
            this.Cancel.Text = global::OutlookDesktop.Properties.Resources.CancelButton;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKButton.Location = new System.Drawing.Point(143, 266);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 24);
            this.OKButton.TabIndex = 29;
            this.OKButton.Text = global::OutlookDesktop.Properties.Resources.OKButton;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // transparentLabel
            // 
            this.transparentLabel.Location = new System.Drawing.Point(97, 80);
            this.transparentLabel.Name = "transparentLabel";
            this.transparentLabel.Size = new System.Drawing.Size(72, 16);
            this.transparentLabel.TabIndex = 28;
            this.transparentLabel.Text = "Transparent";
            // 
            // opaqueLabel
            // 
            this.opaqueLabel.Location = new System.Drawing.Point(406, 80);
            this.opaqueLabel.Name = "opaqueLabel";
            this.opaqueLabel.Size = new System.Drawing.Size(48, 16);
            this.opaqueLabel.TabIndex = 27;
            this.opaqueLabel.Text = "Opaque";
            // 
            // opacityLabel
            // 
            this.opacityLabel.Location = new System.Drawing.Point(25, 58);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(63, 18);
            this.opacityLabel.TabIndex = 26;
            this.opacityLabel.Text = "Opacity:";
            this.opacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // transparencySlider
            // 
            this.transparencySlider.Location = new System.Drawing.Point(89, 56);
            this.transparencySlider.Maximum = 100;
            this.transparencySlider.Name = "transparencySlider";
            this.transparencySlider.Size = new System.Drawing.Size(368, 45);
            this.transparencySlider.SmallChange = 5;
            this.transparencySlider.TabIndex = 25;
            this.transparencySlider.TickFrequency = 10;
            this.transparencySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.transparencySlider.Value = 50;
            this.transparencySlider.Scroll += new System.EventHandler(this.transparencySlider_Scroll);
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 304);
            this.Controls.Add(this.tallLabel);
            this.Controls.Add(this.shortLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightSlider);
            this.Controls.Add(this.wideLabel);
            this.Controls.Add(this.narrowLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthSlider);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.horizontalPosition);
            this.Controls.Add(this.verticalPosition);
            this.Controls.Add(this.preferencesLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.transparentLabel);
            this.Controls.Add(this.opaqueLabel);
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.transparencySlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlook on the Destkop Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.heightSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencySlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tallLabel;
        private System.Windows.Forms.Label shortLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TrackBar heightSlider;
        private System.Windows.Forms.Label wideLabel;
        private System.Windows.Forms.Label narrowLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TrackBar widthSlider;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HScrollBar horizontalPosition;
        private System.Windows.Forms.VScrollBar verticalPosition;
        private System.Windows.Forms.Label preferencesLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label transparentLabel;
        private System.Windows.Forms.Label opaqueLabel;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar transparencySlider;
    }
}