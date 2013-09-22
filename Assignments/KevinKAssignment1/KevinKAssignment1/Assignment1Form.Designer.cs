﻿namespace KevinKAssignment1
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
            this.SalesBonusText = new System.Windows.Forms.TextBox();
            this.TotalHoursWorkedText = new System.Windows.Forms.TextBox();
            this.EmployeeIdText = new System.Windows.Forms.TextBox();
            this.EmployeeNameText = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesText = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SelectLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectFrancaisButton = new System.Windows.Forms.RadioButton();
            this.SelectEnglishButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.ErrorLable = new System.Windows.Forms.Label();
            this.SelectLanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // SalesBonusText
            // 
            this.SalesBonusText.Location = new System.Drawing.Point(462, 170);
            this.SalesBonusText.Name = "SalesBonusText";
            this.SalesBonusText.ReadOnly = true;
            this.SalesBonusText.Size = new System.Drawing.Size(121, 22);
            this.SalesBonusText.TabIndex = 40;
            // 
            // TotalHoursWorkedText
            // 
            this.TotalHoursWorkedText.Location = new System.Drawing.Point(462, 142);
            this.TotalHoursWorkedText.Name = "TotalHoursWorkedText";
            this.TotalHoursWorkedText.Size = new System.Drawing.Size(121, 22);
            this.TotalHoursWorkedText.TabIndex = 39;
            // 
            // EmployeeIdText
            // 
            this.EmployeeIdText.Location = new System.Drawing.Point(462, 114);
            this.EmployeeIdText.Name = "EmployeeIdText";
            this.EmployeeIdText.Size = new System.Drawing.Size(121, 22);
            this.EmployeeIdText.TabIndex = 38;
            // 
            // EmployeeNameText
            // 
            this.EmployeeNameText.Location = new System.Drawing.Point(462, 86);
            this.EmployeeNameText.Name = "EmployeeNameText";
            this.EmployeeNameText.Size = new System.Drawing.Size(121, 22);
            this.EmployeeNameText.TabIndex = 37;
            // 
            // TotalMonthlySalesText
            // 
            this.TotalMonthlySalesText.Location = new System.Drawing.Point(462, 58);
            this.TotalMonthlySalesText.Name = "TotalMonthlySalesText";
            this.TotalMonthlySalesText.Size = new System.Drawing.Size(121, 22);
            this.TotalMonthlySalesText.TabIndex = 36;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KevinKAssignment1.Properties.Resources.Yin_Yang_Symbol;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 190);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // ErrorLable
            // 
            this.ErrorLable.AutoSize = true;
            this.ErrorLable.Location = new System.Drawing.Point(233, 210);
            this.ErrorLable.Name = "ErrorLable";
            this.ErrorLable.Size = new System.Drawing.Size(0, 17);
            this.ErrorLable.TabIndex = 47;
            // 
            // Assignment1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 334);
            this.Controls.Add(this.ErrorLable);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalHoursWorkedLabel);
            this.Controls.Add(this.EmployeeIdLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.MonthlyTotalSalesLabel);
            this.Controls.Add(this.SalesBonusText);
            this.Controls.Add(this.TotalHoursWorkedText);
            this.Controls.Add(this.EmployeeIdText);
            this.Controls.Add(this.EmployeeNameText);
            this.Controls.Add(this.TotalMonthlySalesText);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SelectLanguageGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Assignment1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C Sharp Mail Order Assignment1";
            this.SelectLanguageGroupBox.ResumeLayout(false);
            this.SelectLanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox SalesBonusText;
        private System.Windows.Forms.TextBox TotalHoursWorkedText;
        private System.Windows.Forms.TextBox EmployeeIdText;
        private System.Windows.Forms.TextBox EmployeeNameText;
        private System.Windows.Forms.TextBox TotalMonthlySalesText;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox SelectLanguageGroupBox;
        private System.Windows.Forms.RadioButton SelectFrancaisButton;
        private System.Windows.Forms.RadioButton SelectEnglishButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Label ErrorLable;
    }
}
