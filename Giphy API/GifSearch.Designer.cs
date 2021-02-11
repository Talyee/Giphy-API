namespace Giphy_API
{
    partial class GifSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GifSearchForm));
            this.DisplayGifBox = new System.Windows.Forms.PictureBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.GiphyAttribute = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGifBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiphyAttribute)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayGifBox
            // 
            this.DisplayGifBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.DisplayGifBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("DisplayGifBox.ErrorImage")));
            this.DisplayGifBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DisplayGifBox.InitialImage")));
            this.DisplayGifBox.Location = new System.Drawing.Point(50, 60);
            this.DisplayGifBox.Name = "DisplayGifBox";
            this.DisplayGifBox.Size = new System.Drawing.Size(400, 300);
            this.DisplayGifBox.TabIndex = 0;
            this.DisplayGifBox.TabStop = false;
            this.DisplayGifBox.UseWaitCursor = true;
            // 
            // TextLabel
            // 
            this.TextLabel.BackColor = System.Drawing.Color.Black;
            this.TextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TextLabel.Location = new System.Drawing.Point(0, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(484, 57);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Please enter your keyword";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextLabel.UseMnemonic = false;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(50, 400);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(228, 20);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(294, 398);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GiphyAttribute
            // 
            this.GiphyAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GiphyAttribute.Image = ((System.Drawing.Image)(resources.GetObject("GiphyAttribute.Image")));
            this.GiphyAttribute.Location = new System.Drawing.Point(384, 391);
            this.GiphyAttribute.Name = "GiphyAttribute";
            this.GiphyAttribute.Size = new System.Drawing.Size(102, 37);
            this.GiphyAttribute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GiphyAttribute.TabIndex = 4;
            this.GiphyAttribute.TabStop = false;
            // 
            // GifSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.GiphyAttribute);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.DisplayGifBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GifSearchForm";
            this.Text = "Giphy Search";
            this.Load += new System.EventHandler(this.GifSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGifBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiphyAttribute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayGifBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.PictureBox GiphyAttribute;
    }
}

