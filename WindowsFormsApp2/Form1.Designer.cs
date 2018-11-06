namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.greenbuttonLabel = new System.Windows.Forms.Label();
            this.redbuttonLabel = new System.Windows.Forms.Label();
            this.bluebuttonLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(489, 167);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = resources.GetString("outputLabel.Text");
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(62, 312);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(121, 13);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "Help Ethan with the tent";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(62, 364);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(142, 13);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "Help Jacob grab some water";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(62, 413);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(151, 13);
            this.greenLabel.TabIndex = 6;
            this.greenLabel.Text = "Help Ryan find some fire wood";
            // 
            // greenbuttonLabel
            // 
            this.greenbuttonLabel.Image = global::WindowsFormsApp2.Properties.Resources.green_50x50;
            this.greenbuttonLabel.Location = new System.Drawing.Point(-21, 394);
            this.greenbuttonLabel.Name = "greenbuttonLabel";
            this.greenbuttonLabel.Size = new System.Drawing.Size(100, 47);
            this.greenbuttonLabel.TabIndex = 3;
            // 
            // redbuttonLabel
            // 
            this.redbuttonLabel.Image = global::WindowsFormsApp2.Properties.Resources.red_50x50;
            this.redbuttonLabel.Location = new System.Drawing.Point(-21, 345);
            this.redbuttonLabel.Name = "redbuttonLabel";
            this.redbuttonLabel.Size = new System.Drawing.Size(100, 49);
            this.redbuttonLabel.TabIndex = 2;
            // 
            // bluebuttonLabel
            // 
            this.bluebuttonLabel.Image = global::WindowsFormsApp2.Properties.Resources.blue_50x50;
            this.bluebuttonLabel.Location = new System.Drawing.Point(-21, 294);
            this.bluebuttonLabel.Name = "bluebuttonLabel";
            this.bluebuttonLabel.Size = new System.Drawing.Size(100, 51);
            this.bluebuttonLabel.TabIndex = 1;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(270, 179);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(464, 259);
            this.imageBox.TabIndex = 7;
            this.imageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenbuttonLabel);
            this.Controls.Add(this.redbuttonLabel);
            this.Controls.Add(this.bluebuttonLabel);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Friday the 13th";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
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
        private System.Windows.Forms.PictureBox imageBox;
    }
}

