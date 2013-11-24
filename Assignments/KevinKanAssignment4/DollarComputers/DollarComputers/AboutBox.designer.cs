namespace DollarComputers
{
    partial class AboutBox1
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
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.ForeColor = System.Drawing.Color.White;
            this.labelProductName.Location = new System.Drawing.Point(374, 22);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(96, 29);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(374, 51);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(95, 29);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(374, 80);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(125, 29);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "CopyRight";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.ForeColor = System.Drawing.Color.White;
            this.labelCompanyName.Location = new System.Drawing.Point(374, 109);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(186, 29);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "Company Name";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxDescription.Location = new System.Drawing.Point(374, 143);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(717, 209);
            this.textBoxDescription.TabIndex = 4;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::DollarComputers.Properties.Resources.YinYangSymbol;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPictureBox.Location = new System.Drawing.Point(21, 22);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(343, 330);
            this.LogoPictureBox.TabIndex = 15;
            this.LogoPictureBox.TabStop = false;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(554, 370);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(91, 41);
            this.OkButton.TabIndex = 16;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1105, 413);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AboutBox1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button OkButton;



    }
}