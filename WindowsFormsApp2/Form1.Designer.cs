﻿namespace WindowsFormsApp2
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.bluebuttonLabel = new System.Windows.Forms.Label();
            this.redbuttonLabel = new System.Windows.Forms.Label();
            this.greenbuttonLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(454, 257);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            // 
            // bluebuttonLabel
            // 
            this.bluebuttonLabel.Image = global::WindowsFormsApp2.Properties.Resources.blue_50x50;
            this.bluebuttonLabel.Location = new System.Drawing.Point(12, 294);
            this.bluebuttonLabel.Name = "bluebuttonLabel";
            this.bluebuttonLabel.Size = new System.Drawing.Size(100, 51);
            this.bluebuttonLabel.TabIndex = 1;
            // 
            // redbuttonLabel
            // 
            this.redbuttonLabel.Image = global::WindowsFormsApp2.Properties.Resources.red_50x50;
            this.redbuttonLabel.Location = new System.Drawing.Point(12, 345);
            this.redbuttonLabel.Name = "redbuttonLabel";
            this.redbuttonLabel.Size = new System.Drawing.Size(100, 49);
            this.redbuttonLabel.TabIndex = 2;
            // 
            // greenbuttonLabel
            // 
            this.greenbuttonLabel.Image = global::WindowsFormsApp2.Properties.Resources.green_50x50;
            this.greenbuttonLabel.Location = new System.Drawing.Point(12, 394);
            this.greenbuttonLabel.Name = "greenbuttonLabel";
            this.greenbuttonLabel.Size = new System.Drawing.Size(100, 47);
            this.greenbuttonLabel.TabIndex = 3;
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(118, 312);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(35, 13);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "label1";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(118, 363);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(35, 13);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "label2";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(118, 412);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(35, 13);
            this.greenLabel.TabIndex = 6;
            this.greenLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenbuttonLabel);
            this.Controls.Add(this.redbuttonLabel);
            this.Controls.Add(this.bluebuttonLabel);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label bluebuttonLabel;
        private System.Windows.Forms.Label redbuttonLabel;
        private System.Windows.Forms.Label greenbuttonLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
    }
}

