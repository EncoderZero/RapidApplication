namespace KevinKanAssignment3MovieBonanza
{
    partial class StreamForm
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
            this.MoviePosterPictureBox = new System.Windows.Forms.PictureBox();
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.MovieInfoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePosterPictureBox
            // 
            this.MoviePosterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoviePosterPictureBox.Location = new System.Drawing.Point(28, 14);
            this.MoviePosterPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.MoviePosterPictureBox.Name = "MoviePosterPictureBox";
            this.MoviePosterPictureBox.Size = new System.Drawing.Size(387, 512);
            this.MoviePosterPictureBox.TabIndex = 1;
            this.MoviePosterPictureBox.TabStop = false;
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.AutoSize = true;
            this.ThanksLabel.ForeColor = System.Drawing.Color.White;
            this.ThanksLabel.Location = new System.Drawing.Point(12, 531);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(424, 29);
            this.ThanksLabel.TabIndex = 2;
            this.ThanksLabel.Text = "Thank you for choosing Movie Banaza!";
            this.ThanksLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(171, 695);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(100, 34);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "OK";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // MovieInfoTextBox
            // 
            this.MovieInfoTextBox.BackColor = System.Drawing.Color.Black;
            this.MovieInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieInfoTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MovieInfoTextBox.ForeColor = System.Drawing.Color.White;
            this.MovieInfoTextBox.Location = new System.Drawing.Point(28, 563);
            this.MovieInfoTextBox.Multiline = true;
            this.MovieInfoTextBox.Name = "MovieInfoTextBox";
            this.MovieInfoTextBox.ReadOnly = true;
            this.MovieInfoTextBox.Size = new System.Drawing.Size(387, 126);
            this.MovieInfoTextBox.TabIndex = 5;
            this.MovieInfoTextBox.Text = "Your Account has Been billed $15.00 and a DVD has been sent\r\nBraveheart 3HD will " +
    "stream in about a minute.";
            this.MovieInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(448, 739);
            this.ControlBox = false;
            this.Controls.Add(this.MovieInfoTextBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ThanksLabel);
            this.Controls.Add(this.MoviePosterPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza Thank You!";
            this.Activated += new System.EventHandler(this.StreamForm_Load);
            this.Load += new System.EventHandler(this.StreamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePosterPictureBox;
        private System.Windows.Forms.Label ThanksLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox MovieInfoTextBox;
    }
}