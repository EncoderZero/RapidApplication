﻿namespace DollarComputers
{
    partial class StartForm
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
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(221, 145);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(229, 23);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "&New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.Location = new System.Drawing.Point(221, 116);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(229, 23);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "&Load Order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(221, 174);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(229, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(215, 18);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(173, 32);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome To";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(215, 50);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(235, 32);
            this.CompanyLabel.TabIndex = 4;
            this.CompanyLabel.Text = "Dollar Computers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DollarComputers.Properties.Resources.YinYangSymbol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 186);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(456, 211);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Name = "StartForm";
            this.Text = "Dollar Computers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
