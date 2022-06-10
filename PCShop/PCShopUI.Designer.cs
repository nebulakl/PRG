// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace PCShopRevisited
{
    partial class PCShopUI
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
            this.comboBox_cpu = new System.Windows.Forms.ComboBox();
            this.comboBox_hd = new System.Windows.Forms.ComboBox();
            this.comboBox_ram = new System.Windows.Forms.ComboBox();
            this.button_compute = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_cpu
            // 
            this.comboBox_cpu.FormattingEnabled = true;
            this.comboBox_cpu.Location = new System.Drawing.Point(183, 118);
            this.comboBox_cpu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_cpu.Name = "comboBox_cpu";
            this.comboBox_cpu.Size = new System.Drawing.Size(174, 23);
            this.comboBox_cpu.TabIndex = 0;
            this.comboBox_cpu.Text = "CPU Options =>";
            // 
            // comboBox_hd
            // 
            this.comboBox_hd.FormattingEnabled = true;
            this.comboBox_hd.Location = new System.Drawing.Point(365, 118);
            this.comboBox_hd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_hd.Name = "comboBox_hd";
            this.comboBox_hd.Size = new System.Drawing.Size(174, 23);
            this.comboBox_hd.TabIndex = 1;
            this.comboBox_hd.Text = "HD Options =>";
            // 
            // comboBox_ram
            // 
            this.comboBox_ram.FormattingEnabled = true;
            this.comboBox_ram.Location = new System.Drawing.Point(547, 118);
            this.comboBox_ram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ram.Name = "comboBox_ram";
            this.comboBox_ram.Size = new System.Drawing.Size(174, 23);
            this.comboBox_ram.TabIndex = 2;
            this.comboBox_ram.Text = "RAM Options =>";
            // 
            // button_compute
            // 
            this.button_compute.Location = new System.Drawing.Point(410, 163);
            this.button_compute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_compute.Name = "button_compute";
            this.button_compute.Size = new System.Drawing.Size(88, 27);
            this.button_compute.TabIndex = 3;
            this.button_compute.Text = "COMPUTE";
            this.button_compute.UseVisualStyleBackColor = true;
            this.button_compute.Click += new System.EventHandler(this.button_compute_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(183, 210);
            this.textBox_output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(538, 137);
            this.textBox_output.TabIndex = 4;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(271, 370);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(88, 27);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(547, 370);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(88, 27);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // PCShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.button_compute);
            this.Controls.Add(this.comboBox_ram);
            this.Controls.Add(this.comboBox_hd);
            this.Controls.Add(this.comboBox_cpu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PCShopUI";
            this.Text = "PC Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_cpu;
        private System.Windows.Forms.ComboBox comboBox_hd;
        private System.Windows.Forms.ComboBox comboBox_ram;
        private System.Windows.Forms.Button button_compute;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_exit;
    }
}