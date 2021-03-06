﻿namespace CSharpAutoCenter
{
    partial class CSharpAutoCenterForm
    {
         /*Author: Kevin Kan
         * Student Number: 200213257
         * Date: Oct. 6, 2013
         * Purpose: This application calculates the car new purchase value with several additional accessories, an external finish and
         * factors in the trade in value discount. This application has the use of menus and buttons.
         */
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.TradeInValueLabel = new System.Windows.Forms.Label();
            this.TradeInValueTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalItemsLabel = new System.Windows.Forms.Label();
            this.AdditionalItemsTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AdditionalOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.BackupSensorCheckBox = new System.Windows.Forms.CheckBox();
            this.FogLightCheckBox = new System.Windows.Forms.CheckBox();
            this.DoorSillCheckBox = new System.Windows.Forms.CheckBox();
            this.TrailerHitchCheckBox = new System.Windows.Forms.CheckBox();
            this.ExternalFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.ChromeGoldFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomDetailingFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.PearledFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.EditColorDialog = new System.Windows.Forms.ColorDialog();
            this.EditFontDialog = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColourContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearContextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip.SuspendLayout();
            this.AdditionalOptionsGroupBox.SuspendLayout();
            this.ExternalFinishGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ContextMenuStrip = this.contextMenuStrip1;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem,
            this.EditStripMenuItem,
            this.HelpStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(1009, 30);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileStripMenuItem
            // 
            this.FileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileStripMenuItem.Name = "FileStripMenuItem";
            this.FileStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileStripMenuItem.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditStripMenuItem
            // 
            this.EditStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.ColourToolStripMenuItem});
            this.EditStripMenuItem.Name = "EditStripMenuItem";
            this.EditStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.EditStripMenuItem.Text = "&Edit";
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.CalculateToolStripMenuItem.Text = "C&alculate";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.ClearToolStripMenuItem.Text = "&Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.FontToolStripMenuItem.Text = "F&ont";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // ColourToolStripMenuItem
            // 
            this.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem";
            this.ColourToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.ColourToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.ColourToolStripMenuItem.Text = "Co&lour";
            this.ColourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // HelpStripMenuItem
            // 
            this.HelpStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpStripMenuItem.Name = "HelpStripMenuItem";
            this.HelpStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.HelpStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.AboutToolStripMenuItem.Text = "A&bout";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(214, 87);
            this.BasePriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(231, 30);
            this.BasePriceTextBox.TabIndex = 1;
            this.BasePriceTextBox.Text = "$0.00";
            this.BasePriceTextBox.Leave += new System.EventHandler(this.BasePriceTextBox_Leave);
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(13, 91);
            this.BasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(112, 25);
            this.BasePriceLabel.TabIndex = 2;
            this.BasePriceLabel.Text = "Base Price:";
            // 
            // TradeInValueLabel
            // 
            this.TradeInValueLabel.AutoSize = true;
            this.TradeInValueLabel.Location = new System.Drawing.Point(13, 135);
            this.TradeInValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TradeInValueLabel.Name = "TradeInValueLabel";
            this.TradeInValueLabel.Size = new System.Drawing.Size(188, 25);
            this.TradeInValueLabel.TabIndex = 4;
            this.TradeInValueLabel.Text = "Trade-In Allowance:";
            // 
            // TradeInValueTextBox
            // 
            this.TradeInValueTextBox.Location = new System.Drawing.Point(214, 131);
            this.TradeInValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TradeInValueTextBox.Name = "TradeInValueTextBox";
            this.TradeInValueTextBox.Size = new System.Drawing.Size(231, 30);
            this.TradeInValueTextBox.TabIndex = 3;
            this.TradeInValueTextBox.Text = "$0.00";
            this.TradeInValueTextBox.Leave += new System.EventHandler(this.BasePriceTextBox_Leave);
            // 
            // AdditionalItemsLabel
            // 
            this.AdditionalItemsLabel.AutoSize = true;
            this.AdditionalItemsLabel.Location = new System.Drawing.Point(13, 179);
            this.AdditionalItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdditionalItemsLabel.Name = "AdditionalItemsLabel";
            this.AdditionalItemsLabel.Size = new System.Drawing.Size(156, 25);
            this.AdditionalItemsLabel.TabIndex = 6;
            this.AdditionalItemsLabel.Text = "Additional Items:";
            // 
            // AdditionalItemsTextBox
            // 
            this.AdditionalItemsTextBox.Location = new System.Drawing.Point(214, 175);
            this.AdditionalItemsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdditionalItemsTextBox.Name = "AdditionalItemsTextBox";
            this.AdditionalItemsTextBox.ReadOnly = true;
            this.AdditionalItemsTextBox.Size = new System.Drawing.Size(231, 30);
            this.AdditionalItemsTextBox.TabIndex = 5;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(13, 223);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(103, 25);
            this.SubTotalLabel.TabIndex = 8;
            this.SubTotalLabel.Text = "Sub Total:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(214, 218);
            this.SubTotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(231, 30);
            this.SubTotalTextBox.TabIndex = 7;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(13, 267);
            this.TaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(52, 25);
            this.TaxLabel.TabIndex = 10;
            this.TaxLabel.Text = "Tax:";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(214, 262);
            this.TaxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(231, 30);
            this.TaxTextBox.TabIndex = 9;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(13, 310);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(62, 25);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(214, 306);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(231, 30);
            this.TotalTextBox.TabIndex = 11;
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(13, 354);
            this.AmountDueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(127, 25);
            this.AmountDueLabel.TabIndex = 14;
            this.AmountDueLabel.Text = "Amount Due:";
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(214, 350);
            this.AmountDueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(231, 30);
            this.AmountDueTextBox.TabIndex = 13;
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLabel.Location = new System.Drawing.Point(350, 30);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(259, 29);
            this.CarNameLabel.TabIndex = 15;
            this.CarNameLabel.Text = "Honda Odyssey 2013";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(885, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 33);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(760, 383);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(119, 33);
            this.CalculateButton.TabIndex = 18;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(630, 383);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 33);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // AdditionalOptionsGroupBox
            // 
            this.AdditionalOptionsGroupBox.Controls.Add(this.BackupSensorCheckBox);
            this.AdditionalOptionsGroupBox.Controls.Add(this.FogLightCheckBox);
            this.AdditionalOptionsGroupBox.Controls.Add(this.DoorSillCheckBox);
            this.AdditionalOptionsGroupBox.Controls.Add(this.TrailerHitchCheckBox);
            this.AdditionalOptionsGroupBox.Location = new System.Drawing.Point(461, 62);
            this.AdditionalOptionsGroupBox.Name = "AdditionalOptionsGroupBox";
            this.AdditionalOptionsGroupBox.Size = new System.Drawing.Size(337, 143);
            this.AdditionalOptionsGroupBox.TabIndex = 20;
            this.AdditionalOptionsGroupBox.TabStop = false;
            this.AdditionalOptionsGroupBox.Text = "Additional Options";
            // 
            // BackupSensorCheckBox
            // 
            this.BackupSensorCheckBox.AutoSize = true;
            this.BackupSensorCheckBox.Location = new System.Drawing.Point(7, 107);
            this.BackupSensorCheckBox.Name = "BackupSensorCheckBox";
            this.BackupSensorCheckBox.Size = new System.Drawing.Size(256, 29);
            this.BackupSensorCheckBox.TabIndex = 3;
            this.BackupSensorCheckBox.Text = "Backup Sensor - $834.12";
            this.BackupSensorCheckBox.UseVisualStyleBackColor = true;
            this.BackupSensorCheckBox.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // FogLightCheckBox
            // 
            this.FogLightCheckBox.AutoSize = true;
            this.FogLightCheckBox.Location = new System.Drawing.Point(7, 81);
            this.FogLightCheckBox.Name = "FogLightCheckBox";
            this.FogLightCheckBox.Size = new System.Drawing.Size(213, 29);
            this.FogLightCheckBox.TabIndex = 2;
            this.FogLightCheckBox.Text = "Fog Lights - $660.79";
            this.FogLightCheckBox.UseVisualStyleBackColor = true;
            this.FogLightCheckBox.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // DoorSillCheckBox
            // 
            this.DoorSillCheckBox.AutoSize = true;
            this.DoorSillCheckBox.Location = new System.Drawing.Point(7, 55);
            this.DoorSillCheckBox.Name = "DoorSillCheckBox";
            this.DoorSillCheckBox.Size = new System.Drawing.Size(268, 29);
            this.DoorSillCheckBox.TabIndex = 1;
            this.DoorSillCheckBox.Text = "Door Sill Garnish - $283.83";
            this.DoorSillCheckBox.UseVisualStyleBackColor = true;
            this.DoorSillCheckBox.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // TrailerHitchCheckBox
            // 
            this.TrailerHitchCheckBox.AutoSize = true;
            this.TrailerHitchCheckBox.Location = new System.Drawing.Point(7, 29);
            this.TrailerHitchCheckBox.Name = "TrailerHitchCheckBox";
            this.TrailerHitchCheckBox.Size = new System.Drawing.Size(304, 29);
            this.TrailerHitchCheckBox.TabIndex = 0;
            this.TrailerHitchCheckBox.Text = "Trailer Hitch Harness - $242.39";
            this.TrailerHitchCheckBox.UseVisualStyleBackColor = true;
            this.TrailerHitchCheckBox.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // ExternalFinishGroupBox
            // 
            this.ExternalFinishGroupBox.Controls.Add(this.ChromeGoldFinishRadioButton);
            this.ExternalFinishGroupBox.Controls.Add(this.CustomDetailingFinishRadioButton);
            this.ExternalFinishGroupBox.Controls.Add(this.PearledFinishRadioButton);
            this.ExternalFinishGroupBox.Controls.Add(this.StandardFinishRadioButton);
            this.ExternalFinishGroupBox.Location = new System.Drawing.Point(461, 210);
            this.ExternalFinishGroupBox.Name = "ExternalFinishGroupBox";
            this.ExternalFinishGroupBox.Size = new System.Drawing.Size(337, 163);
            this.ExternalFinishGroupBox.TabIndex = 21;
            this.ExternalFinishGroupBox.TabStop = false;
            this.ExternalFinishGroupBox.Text = "External Finish";
            // 
            // ChromeGoldFinishRadioButton
            // 
            this.ChromeGoldFinishRadioButton.AutoSize = true;
            this.ChromeGoldFinishRadioButton.Location = new System.Drawing.Point(6, 133);
            this.ChromeGoldFinishRadioButton.Name = "ChromeGoldFinishRadioButton";
            this.ChromeGoldFinishRadioButton.Size = new System.Drawing.Size(249, 29);
            this.ChromeGoldFinishRadioButton.TabIndex = 3;
            this.ChromeGoldFinishRadioButton.Text = "Chrome/Gold - $2545.67";
            this.ChromeGoldFinishRadioButton.UseVisualStyleBackColor = true;
            this.ChromeGoldFinishRadioButton.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // CustomDetailingFinishRadioButton
            // 
            this.CustomDetailingFinishRadioButton.AutoSize = true;
            this.CustomDetailingFinishRadioButton.Location = new System.Drawing.Point(7, 100);
            this.CustomDetailingFinishRadioButton.Name = "CustomDetailingFinishRadioButton";
            this.CustomDetailingFinishRadioButton.Size = new System.Drawing.Size(280, 29);
            this.CustomDetailingFinishRadioButton.TabIndex = 2;
            this.CustomDetailingFinishRadioButton.Text = "Custom Detailing - $1500.00";
            this.CustomDetailingFinishRadioButton.UseVisualStyleBackColor = true;
            this.CustomDetailingFinishRadioButton.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // PearledFinishRadioButton
            // 
            this.PearledFinishRadioButton.AutoSize = true;
            this.PearledFinishRadioButton.Location = new System.Drawing.Point(6, 65);
            this.PearledFinishRadioButton.Name = "PearledFinishRadioButton";
            this.PearledFinishRadioButton.Size = new System.Drawing.Size(188, 29);
            this.PearledFinishRadioButton.TabIndex = 1;
            this.PearledFinishRadioButton.Text = "Pearled - $850.00";
            this.PearledFinishRadioButton.UseVisualStyleBackColor = true;
            this.PearledFinishRadioButton.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // StandardFinishRadioButton
            // 
            this.StandardFinishRadioButton.AutoSize = true;
            this.StandardFinishRadioButton.Checked = true;
            this.StandardFinishRadioButton.Location = new System.Drawing.Point(7, 30);
            this.StandardFinishRadioButton.Name = "StandardFinishRadioButton";
            this.StandardFinishRadioButton.Size = new System.Drawing.Size(179, 29);
            this.StandardFinishRadioButton.TabIndex = 0;
            this.StandardFinishRadioButton.TabStop = true;
            this.StandardFinishRadioButton.Text = "Standard - $0.00";
            this.StandardFinishRadioButton.UseVisualStyleBackColor = true;
            this.StandardFinishRadioButton.CheckedChanged += new System.EventHandler(this.TrailerHitchCheckBox_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::CSharpAutoCenter.Properties.Resources.Yin_Yang_Symbol;
            this.LogoPictureBox.Location = new System.Drawing.Point(804, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(200, 200);
            this.LogoPictureBox.TabIndex = 16;
            this.LogoPictureBox.TabStop = false;
            // 
            // EditFontDialog
            // 
            this.EditFontDialog.Color = System.Drawing.SystemColors.ControlText;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitContextToolStripMenuItem,
            this.toolStripSeparator1,
            this.CalculateContextToolStripMenuItem,
            this.ClearContextToolStripMenuItem1,
            this.FontContextToolStripMenuItem,
            this.ColourContextToolStripMenuItem,
            this.toolStripSeparator2,
            this.AboutContextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 160);
            // 
            // ExitContextToolStripMenuItem
            // 
            this.ExitContextToolStripMenuItem.Name = "ExitContextToolStripMenuItem";
            this.ExitContextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ExitContextToolStripMenuItem.Text = "E&xit";
            this.ExitContextToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // FontContextToolStripMenuItem
            // 
            this.FontContextToolStripMenuItem.Name = "FontContextToolStripMenuItem";
            this.FontContextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.FontContextToolStripMenuItem.Text = "F&ont";
            this.FontContextToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // ColourContextToolStripMenuItem
            // 
            this.ColourContextToolStripMenuItem.Name = "ColourContextToolStripMenuItem";
            this.ColourContextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ColourContextToolStripMenuItem.Text = "Co&lour";
            this.ColourContextToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // ClearContextToolStripMenuItem1
            // 
            this.ClearContextToolStripMenuItem1.Name = "ClearContextToolStripMenuItem1";
            this.ClearContextToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.ClearContextToolStripMenuItem1.Text = "&Clear";
            this.ClearContextToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // CalculateContextToolStripMenuItem
            // 
            this.CalculateContextToolStripMenuItem.Name = "CalculateContextToolStripMenuItem";
            this.CalculateContextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.CalculateContextToolStripMenuItem.Text = "C&alculate";
            this.CalculateContextToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // AboutContextToolStripMenuItem
            // 
            this.AboutContextToolStripMenuItem.Name = "AboutContextToolStripMenuItem";
            this.AboutContextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.AboutContextToolStripMenuItem.Text = "A&bout";
            this.AboutContextToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // CSharpAutoCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 424);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ExternalFinishGroupBox);
            this.Controls.Add(this.AdditionalOptionsGroupBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.CarNameLabel);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.AdditionalItemsLabel);
            this.Controls.Add(this.AdditionalItemsTextBox);
            this.Controls.Add(this.TradeInValueLabel);
            this.Controls.Add(this.TradeInValueTextBox);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CSharpAutoCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C Sharp Auto Center";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.AdditionalOptionsGroupBox.ResumeLayout(false);
            this.AdditionalOptionsGroupBox.PerformLayout();
            this.ExternalFinishGroupBox.ResumeLayout(false);
            this.ExternalFinishGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label TradeInValueLabel;
        private System.Windows.Forms.TextBox TradeInValueTextBox;
        private System.Windows.Forms.Label AdditionalItemsLabel;
        private System.Windows.Forms.TextBox AdditionalItemsTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox AdditionalOptionsGroupBox;
        private System.Windows.Forms.GroupBox ExternalFinishGroupBox;
        private System.Windows.Forms.CheckBox BackupSensorCheckBox;
        private System.Windows.Forms.CheckBox FogLightCheckBox;
        private System.Windows.Forms.CheckBox DoorSillCheckBox;
        private System.Windows.Forms.CheckBox TrailerHitchCheckBox;
        private System.Windows.Forms.RadioButton ChromeGoldFinishRadioButton;
        private System.Windows.Forms.RadioButton CustomDetailingFinishRadioButton;
        private System.Windows.Forms.RadioButton PearledFinishRadioButton;
        private System.Windows.Forms.RadioButton StandardFinishRadioButton;
        private System.Windows.Forms.ColorDialog EditColorDialog;
        private System.Windows.Forms.FontDialog EditFontDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CalculateContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearContextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FontContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColourContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AboutContextToolStripMenuItem;
    }
}

