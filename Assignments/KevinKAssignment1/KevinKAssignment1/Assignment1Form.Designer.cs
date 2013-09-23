namespace KevinKAssignment1
{
    //Written By: Kevin Kan
    //Student No. 200213257
    //Version: Sept 22 2013
    //This application calculates the bonus for employees based on total sales in the four
    //week period and how much they worked in that four week period. (the can gain a max of 2% for working the max
    //160 hours)
    partial class Assignment1Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment1Form));
            this.NextButton = new System.Windows.Forms.Button();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.TotalHoursWorkedLabel = new System.Windows.Forms.Label();
            this.EmployeeIdLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.MonthlyTotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.TotalHoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SelectLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectFrancaisButton = new System.Windows.Forms.RadioButton();
            this.SelectEnglishButton = new System.Windows.Forms.RadioButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SelectLanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(383, 277);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 46;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(218, 167);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(87, 17);
            this.SalesBonusLabel.TabIndex = 45;
            this.SalesBonusLabel.Text = "Sales Bonus";
            // 
            // TotalHoursWorkedLabel
            // 
            this.TotalHoursWorkedLabel.AutoSize = true;
            this.TotalHoursWorkedLabel.Location = new System.Drawing.Point(218, 139);
            this.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel";
            this.TotalHoursWorkedLabel.Size = new System.Drawing.Size(135, 17);
            this.TotalHoursWorkedLabel.TabIndex = 44;
            this.TotalHoursWorkedLabel.Text = "Total Hours Worked";
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(218, 111);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(85, 17);
            this.EmployeeIdLabel.TabIndex = 43;
            this.EmployeeIdLabel.Text = "Employee Id";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(218, 83);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(111, 17);
            this.EmployeeNameLabel.TabIndex = 42;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // MonthlyTotalSalesLabel
            // 
            this.MonthlyTotalSalesLabel.AutoSize = true;
            this.MonthlyTotalSalesLabel.Location = new System.Drawing.Point(218, 58);
            this.MonthlyTotalSalesLabel.Name = "MonthlyTotalSalesLabel";
            this.MonthlyTotalSalesLabel.Size = new System.Drawing.Size(132, 17);
            this.MonthlyTotalSalesLabel.TabIndex = 41;
            this.MonthlyTotalSalesLabel.Text = "Total Monthly Sales";
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(462, 170);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(236, 22);
            this.SalesBonusTextBox.TabIndex = 40;
            // 
            // TotalHoursWorkedTextBox
            // 
            this.TotalHoursWorkedTextBox.Location = new System.Drawing.Point(462, 142);
            this.TotalHoursWorkedTextBox.Name = "TotalHoursWorkedTextBox";
            this.TotalHoursWorkedTextBox.Size = new System.Drawing.Size(236, 22);
            this.TotalHoursWorkedTextBox.TabIndex = 39;
            this.TotalHoursWorkedTextBox.Leave += new System.EventHandler(this.TotalHoursWorkedTextBox_Leave);
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(462, 114);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(236, 22);
            this.EmployeeIdTextBox.TabIndex = 38;
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(462, 86);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(236, 22);
            this.EmployeeNameTextBox.TabIndex = 37;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(302, 277);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 35;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(221, 277);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 34;
            this.CalculateButton.TabStop = false;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // SelectLanguageGroupBox
            // 
            this.SelectLanguageGroupBox.Controls.Add(this.SelectFrancaisButton);
            this.SelectLanguageGroupBox.Controls.Add(this.SelectEnglishButton);
            this.SelectLanguageGroupBox.Location = new System.Drawing.Point(12, 208);
            this.SelectLanguageGroupBox.Name = "SelectLanguageGroupBox";
            this.SelectLanguageGroupBox.Size = new System.Drawing.Size(191, 92);
            this.SelectLanguageGroupBox.TabIndex = 33;
            this.SelectLanguageGroupBox.TabStop = false;
            this.SelectLanguageGroupBox.Text = "Select Language";
            // 
            // SelectFrancaisButton
            // 
            this.SelectFrancaisButton.AutoSize = true;
            this.SelectFrancaisButton.Location = new System.Drawing.Point(53, 60);
            this.SelectFrancaisButton.Name = "SelectFrancaisButton";
            this.SelectFrancaisButton.Size = new System.Drawing.Size(83, 21);
            this.SelectFrancaisButton.TabIndex = 1;
            this.SelectFrancaisButton.Text = "Français";
            this.SelectFrancaisButton.UseVisualStyleBackColor = true;
            this.SelectFrancaisButton.CheckedChanged += new System.EventHandler(this.SelectFrancaisButton_CheckedChanged);
            // 
            // SelectEnglishButton
            // 
            this.SelectEnglishButton.AutoSize = true;
            this.SelectEnglishButton.Checked = true;
            this.SelectEnglishButton.Location = new System.Drawing.Point(53, 33);
            this.SelectEnglishButton.Name = "SelectEnglishButton";
            this.SelectEnglishButton.Size = new System.Drawing.Size(75, 21);
            this.SelectEnglishButton.TabIndex = 0;
            this.SelectEnglishButton.TabStop = true;
            this.SelectEnglishButton.Text = "English";
            this.SelectEnglishButton.UseVisualStyleBackColor = true;
            this.SelectEnglishButton.CheckedChanged += new System.EventHandler(this.SelectEnglishButton_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::KevinKAssignment1.Properties.Resources.Yin_Yang_Symbol;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoPictureBox.InitialImage = null;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(191, 190);
            this.LogoPictureBox.TabIndex = 32;
            this.LogoPictureBox.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(462, 58);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(236, 22);
            this.TotalMonthlySalesTextBox.TabIndex = 48;
            this.TotalMonthlySalesTextBox.Leave += new System.EventHandler(this.TotalMonthlySalesTextBox_Leave);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(213, 210);
            this.ErrorMessageLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorMessageLabel.TabIndex = 49;
            // 
            // Assignment1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 307);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalHoursWorkedLabel);
            this.Controls.Add(this.EmployeeIdLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.MonthlyTotalSalesLabel);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalHoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SelectLanguageGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "Assignment1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C Sharp Mail Order Assignment1";
            this.SelectLanguageGroupBox.ResumeLayout(false);
            this.SelectLanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Label TotalHoursWorkedLabel;
        private System.Windows.Forms.Label EmployeeIdLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label MonthlyTotalSalesLabel;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.TextBox TotalHoursWorkedTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox SelectLanguageGroupBox;
        private System.Windows.Forms.RadioButton SelectFrancaisButton;
        private System.Windows.Forms.RadioButton SelectEnglishButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}

