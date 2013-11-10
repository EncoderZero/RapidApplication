namespace KevinKanAssignment3MovieBonanza
{
    partial class SelectionForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.MovieSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieSelectionListBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.MoviePosterPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MovieSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(779, 676);
            this.NextButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(131, 42);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "&Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MovieSelectionGroupBox
            // 
            this.MovieSelectionGroupBox.Controls.Add(this.MovieSelectionListBox);
            this.MovieSelectionGroupBox.Location = new System.Drawing.Point(87, 22);
            this.MovieSelectionGroupBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MovieSelectionGroupBox.Name = "MovieSelectionGroupBox";
            this.MovieSelectionGroupBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MovieSelectionGroupBox.Size = new System.Drawing.Size(315, 517);
            this.MovieSelectionGroupBox.TabIndex = 2;
            this.MovieSelectionGroupBox.TabStop = false;
            this.MovieSelectionGroupBox.Text = "Your Selection";
            // 
            // MovieSelectionListBox
            // 
            this.MovieSelectionListBox.FormattingEnabled = true;
            this.MovieSelectionListBox.ItemHeight = 29;
            this.MovieSelectionListBox.Location = new System.Drawing.Point(23, 36);
            this.MovieSelectionListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MovieSelectionListBox.Name = "MovieSelectionListBox";
            this.MovieSelectionListBox.Size = new System.Drawing.Size(273, 468);
            this.MovieSelectionListBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(25, 550);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(61, 29);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(25, 634);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(110, 29);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(283, 634);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(62, 29);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(30, 588);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(413, 34);
            this.TitleTextBox.TabIndex = 6;
            // 
            // CategoryextBox
            // 
            this.CategoryextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryextBox.Location = new System.Drawing.Point(30, 670);
            this.CategoryextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CategoryextBox.Name = "CategoryextBox";
            this.CategoryextBox.ReadOnly = true;
            this.CategoryextBox.Size = new System.Drawing.Size(247, 34);
            this.CategoryextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            this.CostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(287, 670);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(176, 34);
            this.CostTextBox.TabIndex = 8;
            // 
            // MoviePosterPictureBox
            // 
            this.MoviePosterPictureBox.Location = new System.Drawing.Point(490, 22);
            this.MoviePosterPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.MoviePosterPictureBox.Name = "MoviePosterPictureBox";
            this.MoviePosterPictureBox.Size = new System.Drawing.Size(420, 644);
            this.MoviePosterPictureBox.TabIndex = 0;
            this.MoviePosterPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(490, 676);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(131, 42);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 730);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CategoryextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MovieSelectionGroupBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MoviePosterPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanaza - Pick Your Film";
            this.MovieSelectionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePosterPictureBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox MovieSelectionGroupBox;
        private System.Windows.Forms.ListBox MovieSelectionListBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

