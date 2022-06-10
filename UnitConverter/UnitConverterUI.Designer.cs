// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    partial class UnitConverterUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.panelSource = new System.Windows.Forms.Panel();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textSource = new System.Windows.Forms.Label();
            this.panelTarget = new System.Windows.Forms.Panel();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.textTarget = new System.Windows.Forms.Label();
            this.textConvertType = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panelSource.SuspendLayout();
            this.panelTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.BackColor = System.Drawing.Color.Silver;
            this.groupBoxType.Location = new System.Drawing.Point(50, 67);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(200, 245);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Select units =>";
            // 
            // panelSource
            // 
            this.panelSource.BackColor = System.Drawing.Color.YellowGreen;
            this.panelSource.Controls.Add(this.comboBoxSource);
            this.panelSource.Controls.Add(this.textBoxSource);
            this.panelSource.Controls.Add(this.textSource);
            this.panelSource.Location = new System.Drawing.Point(321, 67);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(359, 100);
            this.panelSource.TabIndex = 1;
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(235, 36);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSource.TabIndex = 2;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(4, 37);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(225, 20);
            this.textBoxSource.TabIndex = 1;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textSource
            // 
            this.textSource.AutoSize = true;
            this.textSource.Location = new System.Drawing.Point(4, 20);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(30, 13);
            this.textSource.TabIndex = 0;
            this.textSource.Text = "From";
            // 
            // panelTarget
            // 
            this.panelTarget.BackColor = System.Drawing.Color.Yellow;
            this.panelTarget.Controls.Add(this.comboBoxTarget);
            this.panelTarget.Controls.Add(this.textBoxTarget);
            this.panelTarget.Controls.Add(this.textTarget);
            this.panelTarget.Location = new System.Drawing.Point(321, 212);
            this.panelTarget.Name = "panelTarget";
            this.panelTarget.Size = new System.Drawing.Size(359, 100);
            this.panelTarget.TabIndex = 2;
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(235, 36);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTarget.TabIndex = 2;
            this.comboBoxTarget.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarget_SelectedIndexChanged);
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(3, 36);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.Size = new System.Drawing.Size(226, 20);
            this.textBoxTarget.TabIndex = 1;
            // 
            // textTarget
            // 
            this.textTarget.AutoSize = true;
            this.textTarget.Location = new System.Drawing.Point(4, 20);
            this.textTarget.Name = "textTarget";
            this.textTarget.Size = new System.Drawing.Size(20, 13);
            this.textTarget.TabIndex = 0;
            this.textTarget.Text = "To";
            // 
            // textConvertType
            // 
            this.textConvertType.AutoSize = true;
            this.textConvertType.Location = new System.Drawing.Point(325, 51);
            this.textConvertType.Name = "textConvertType";
            this.textConvertType.Size = new System.Drawing.Size(95, 13);
            this.textConvertType.TabIndex = 3;
            this.textConvertType.Text = "Convert [category name]";
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Pink;
            this.buttonQuit.Location = new System.Drawing.Point(363, 388);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "CLOSE";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // UnitConverterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.textConvertType);
            this.Controls.Add(this.panelTarget);
            this.Controls.Add(this.panelSource);
            this.Controls.Add(this.groupBoxType);
            this.Name = "UnitConverterUI";
            this.Text = "Unit Converter";
            this.panelSource.ResumeLayout(false);
            this.panelSource.PerformLayout();
            this.panelTarget.ResumeLayout(false);
            this.panelTarget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label textSource;
        private System.Windows.Forms.Panel panelTarget;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Label textTarget;
        private System.Windows.Forms.Label textConvertType;
        private System.Windows.Forms.Button buttonQuit;
    }
}