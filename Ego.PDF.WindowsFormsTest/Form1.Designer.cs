﻿namespace Ego.PDF.WindowsFormsTest
{
    partial class Form1
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
            this.BtnRunSamples = new System.Windows.Forms.Button();
            this.BtnParseFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRunSamples
            // 
            this.BtnRunSamples.Location = new System.Drawing.Point(324, 23);
            this.BtnRunSamples.Name = "BtnRunSamples";
            this.BtnRunSamples.Size = new System.Drawing.Size(117, 34);
            this.BtnRunSamples.TabIndex = 0;
            this.BtnRunSamples.Text = "Run samples";
            this.BtnRunSamples.UseVisualStyleBackColor = true;
            this.BtnRunSamples.Click += new System.EventHandler(this.BtnRunSamples_Click);
            // 
            // BtnParseFont
            // 
            this.BtnParseFont.Location = new System.Drawing.Point(324, 92);
            this.BtnParseFont.Name = "BtnParseFont";
            this.BtnParseFont.Size = new System.Drawing.Size(117, 34);
            this.BtnParseFont.TabIndex = 1;
            this.BtnParseFont.Text = "Parse font";
            this.BtnParseFont.UseVisualStyleBackColor = true;
            this.BtnParseFont.Click += new System.EventHandler(this.BtnParseFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 178);
            this.Controls.Add(this.BtnParseFont);
            this.Controls.Add(this.BtnRunSamples);
            this.Name = "Form1";
            this.Text = "FPDF port";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRunSamples;
        private System.Windows.Forms.Button BtnParseFont;
    }
}

