namespace pic_to_4k
{
    partial class PicResize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicResize));
            this.inputbutton = new System.Windows.Forms.Button();
            this.outputandsave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.widthtextBox1 = new System.Windows.Forms.TextBox();
            this.heighttextBox1 = new System.Windows.Forms.TextBox();
            this.width1 = new System.Windows.Forms.Label();
            this.height1 = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputbutton
            // 
            this.inputbutton.AllowDrop = true;
            this.inputbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputbutton.Location = new System.Drawing.Point(612, 165);
            this.inputbutton.Name = "inputbutton";
            this.inputbutton.Size = new System.Drawing.Size(123, 65);
            this.inputbutton.TabIndex = 0;
            this.inputbutton.Text = "Input File";
            this.inputbutton.UseVisualStyleBackColor = true;
            this.inputbutton.Click += new System.EventHandler(this.inputbutton_Click);
            // 
            // outputandsave
            // 
            this.outputandsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputandsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputandsave.Location = new System.Drawing.Point(612, 259);
            this.outputandsave.Name = "outputandsave";
            this.outputandsave.Size = new System.Drawing.Size(122, 65);
            this.outputandsave.TabIndex = 1;
            this.outputandsave.Text = "Convert and Save";
            this.outputandsave.UseVisualStyleBackColor = true;
            this.outputandsave.Click += new System.EventHandler(this.outputandsave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileStripStatusLabel1
            // 
            this.fileStripStatusLabel1.Name = "fileStripStatusLabel1";
            this.fileStripStatusLabel1.Size = new System.Drawing.Size(170, 25);
            this.fileStripStatusLabel1.Text = "fileStripStatusLabel1";
            // 
            // widthtextBox1
            // 
            this.widthtextBox1.Location = new System.Drawing.Point(55, 232);
            this.widthtextBox1.Name = "widthtextBox1";
            this.widthtextBox1.Size = new System.Drawing.Size(100, 26);
            this.widthtextBox1.TabIndex = 5;
            this.widthtextBox1.Text = "3840";
            // 
            // heighttextBox1
            // 
            this.heighttextBox1.Location = new System.Drawing.Point(55, 277);
            this.heighttextBox1.Name = "heighttextBox1";
            this.heighttextBox1.Size = new System.Drawing.Size(100, 26);
            this.heighttextBox1.TabIndex = 6;
            this.heighttextBox1.Text = "2160";
            // 
            // width1
            // 
            this.width1.AutoSize = true;
            this.width1.Location = new System.Drawing.Point(196, 238);
            this.width1.Name = "width1";
            this.width1.Size = new System.Drawing.Size(50, 20);
            this.width1.TabIndex = 7;
            this.width1.Text = "Width";
            // 
            // height1
            // 
            this.height1.AutoSize = true;
            this.height1.Location = new System.Drawing.Point(196, 283);
            this.height1.Name = "height1";
            this.height1.Size = new System.Drawing.Size(56, 20);
            this.height1.TabIndex = 8;
            this.height1.Text = "Height";
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "PNG",
            "GIF",
            "BMP",
            "JPEG"});
            this.formatComboBox.Location = new System.Drawing.Point(55, 48);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(121, 28);
            this.formatComboBox.TabIndex = 11;
            this.formatComboBox.Text = "PNG";
            // 
            // PicResize
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.height1);
            this.Controls.Add(this.width1);
            this.Controls.Add(this.heighttextBox1);
            this.Controls.Add(this.widthtextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.outputandsave);
            this.Controls.Add(this.inputbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PicResize";
            this.Text = "Pic Resize & Repeat";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputbutton;
        private System.Windows.Forms.Button outputandsave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox widthtextBox1;
        private System.Windows.Forms.TextBox heighttextBox1;
        private System.Windows.Forms.Label width1;
        private System.Windows.Forms.Label height1;
        private System.Windows.Forms.ComboBox formatComboBox;
    }
}

