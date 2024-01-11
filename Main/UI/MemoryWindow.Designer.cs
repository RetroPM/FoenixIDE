﻿namespace FoenixIDE.UI
{
    partial class MemoryWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryWindow));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddressCombo = new System.Windows.Forms.ComboBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.EndAddressText = new System.Windows.Forms.TextBox();
            this.StartAddressText = new System.Windows.Forms.TextBox();
            this.MemoryText = new System.Windows.Forms.TextBox();
            this.UpdateDisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.MemoryWindowTooltips = new System.Windows.Forms.ToolTip(this.components);
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.MCRBit13Button = new System.Windows.Forms.Button();
            this.MCRBit12Button = new System.Windows.Forms.Button();
            this.MCRBit11Button = new System.Windows.Forms.Button();
            this.MCRBit10Button = new System.Windows.Forms.Button();
            this.MCRBit8Button = new System.Windows.Forms.Button();
            this.MCRBit9Button = new System.Windows.Forms.Button();
            this.MCRBit0Button = new System.Windows.Forms.Button();
            this.MCRBit1Button = new System.Windows.Forms.Button();
            this.MCRBit2Button = new System.Windows.Forms.Button();
            this.MCRBit3Button = new System.Windows.Forms.Button();
            this.MCRBit4Button = new System.Windows.Forms.Button();
            this.MCRBit5Button = new System.Windows.Forms.Button();
            this.MCRBit6Button = new System.Windows.Forms.Button();
            this.MCRBit7Button = new System.Windows.Forms.Button();
            this.MasterControlLabel = new System.Windows.Forms.Label();
            this.HighlightPanel = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.HeaderPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.Controls.Add(this.ZeroButton);
            this.HeaderPanel.Controls.Add(this.SaveButton);
            this.HeaderPanel.Controls.Add(this.AddressCombo);
            this.HeaderPanel.Controls.Add(this.PreviousButton);
            this.HeaderPanel.Controls.Add(this.NextButton);
            this.HeaderPanel.Controls.Add(this.ViewButton);
            this.HeaderPanel.Controls.Add(this.EndAddressText);
            this.HeaderPanel.Controls.Add(this.StartAddressText);
            this.HeaderPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(6);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1136, 48);
            this.HeaderPanel.TabIndex = 0;
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.SystemColors.Control;
            this.ZeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZeroButton.Image = global::FoenixIDE.Simulator.Properties.Resources.zero;
            this.ZeroButton.Location = new System.Drawing.Point(898, 2);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(0);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(50, 44);
            this.ZeroButton.TabIndex = 12;
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(980, 2);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 44);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddressCombo
            // 
            this.AddressCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddressCombo.FormattingEnabled = true;
            this.AddressCombo.Location = new System.Drawing.Point(428, 4);
            this.AddressCombo.Margin = new System.Windows.Forms.Padding(4);
            this.AddressCombo.Name = "AddressCombo";
            this.AddressCombo.Size = new System.Drawing.Size(456, 33);
            this.AddressCombo.TabIndex = 10;
            this.AddressCombo.SelectedIndexChanged += new System.EventHandler(this.AddressCombo_SelectedIndexChanged);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.Location = new System.Drawing.Point(376, 0);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(6);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(50, 46);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "←";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(324, 0);
            this.NextButton.Margin = new System.Windows.Forms.Padding(6);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(52, 46);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "→";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(218, 0);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(6);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(104, 46);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // EndAddressText
            // 
            this.EndAddressText.Font = new System.Drawing.Font("Consolas", 10F);
            this.EndAddressText.Location = new System.Drawing.Point(110, 0);
            this.EndAddressText.Margin = new System.Windows.Forms.Padding(6);
            this.EndAddressText.MaxLength = 6;
            this.EndAddressText.Name = "EndAddressText";
            this.EndAddressText.ReadOnly = true;
            this.EndAddressText.Size = new System.Drawing.Size(104, 39);
            this.EndAddressText.TabIndex = 1;
            this.EndAddressText.TabStop = false;
            this.EndAddressText.Text = "0000FF";
            this.EndAddressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartAddressText
            // 
            this.StartAddressText.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartAddressText.Font = new System.Drawing.Font("Consolas", 10F);
            this.StartAddressText.Location = new System.Drawing.Point(0, 0);
            this.StartAddressText.Margin = new System.Windows.Forms.Padding(6);
            this.StartAddressText.MaxLength = 6;
            this.StartAddressText.Name = "StartAddressText";
            this.StartAddressText.Size = new System.Drawing.Size(104, 39);
            this.StartAddressText.TabIndex = 0;
            this.StartAddressText.Text = "000000";
            this.StartAddressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StartAddressText.Validated += new System.EventHandler(this.StartAddressText_Validated);
            // 
            // MemoryText
            // 
            this.MemoryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MemoryText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemoryText.Font = new System.Drawing.Font("Consolas", 10F);
            this.MemoryText.Location = new System.Drawing.Point(0, 54);
            this.MemoryText.Margin = new System.Windows.Forms.Padding(6);
            this.MemoryText.MaxLength = 4096;
            this.MemoryText.Multiline = true;
            this.MemoryText.Name = "MemoryText";
            this.MemoryText.ReadOnly = true;
            this.MemoryText.Size = new System.Drawing.Size(1136, 479);
            this.MemoryText.TabIndex = 0;
            this.MemoryText.TabStop = false;
            this.MemoryText.Text = resources.GetString("MemoryText.Text");
            this.MemoryText.WordWrap = false;
            this.MemoryText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MemoryText_MouseMove);
            // 
            // UpdateDisplayTimer
            // 
            this.UpdateDisplayTimer.Enabled = true;
            this.UpdateDisplayTimer.Interval = 1000;
            this.UpdateDisplayTimer.Tick += new System.EventHandler(this.UpdateDisplayTimer_Tick);
            // 
            // MemoryWindowTooltips
            // 
            this.MemoryWindowTooltips.ShowAlways = true;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.Controls.Add(this.MCRBit13Button);
            this.FooterPanel.Controls.Add(this.MCRBit12Button);
            this.FooterPanel.Controls.Add(this.MCRBit11Button);
            this.FooterPanel.Controls.Add(this.MCRBit10Button);
            this.FooterPanel.Controls.Add(this.MCRBit8Button);
            this.FooterPanel.Controls.Add(this.MCRBit9Button);
            this.FooterPanel.Controls.Add(this.MCRBit0Button);
            this.FooterPanel.Controls.Add(this.MCRBit1Button);
            this.FooterPanel.Controls.Add(this.MCRBit2Button);
            this.FooterPanel.Controls.Add(this.MCRBit3Button);
            this.FooterPanel.Controls.Add(this.MCRBit4Button);
            this.FooterPanel.Controls.Add(this.MCRBit5Button);
            this.FooterPanel.Controls.Add(this.MCRBit6Button);
            this.FooterPanel.Controls.Add(this.MCRBit7Button);
            this.FooterPanel.Controls.Add(this.MasterControlLabel);
            this.FooterPanel.Location = new System.Drawing.Point(0, 537);
            this.FooterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(816, 117);
            this.FooterPanel.TabIndex = 1;
            // 
            // MCRBit13Button
            // 
            this.MCRBit13Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MCRBit13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit13Button.Location = new System.Drawing.Point(492, 59);
            this.MCRBit13Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit13Button.Name = "MCRBit13Button";
            this.MCRBit13Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit13Button.TabIndex = 14;
            this.MCRBit13Button.Tag = "0";
            this.MCRBit13Button.Text = "FS";
            this.MCRBit13Button.UseVisualStyleBackColor = true;
            this.MCRBit13Button.Visible = false;
            this.MCRBit13Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit12Button
            // 
            this.MCRBit12Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MCRBit12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit12Button.Location = new System.Drawing.Point(542, 59);
            this.MCRBit12Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit12Button.Name = "MCRBit12Button";
            this.MCRBit12Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit12Button.TabIndex = 13;
            this.MCRBit12Button.Tag = "0";
            this.MCRBit12Button.Text = "FO";
            this.MCRBit12Button.UseVisualStyleBackColor = true;
            this.MCRBit12Button.Visible = false;
            this.MCRBit12Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit11Button
            // 
            this.MCRBit11Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MCRBit11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit11Button.Location = new System.Drawing.Point(608, 58);
            this.MCRBit11Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit11Button.Name = "MCRBit11Button";
            this.MCRBit11Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit11Button.TabIndex = 12;
            this.MCRBit11Button.Tag = "0";
            this.MCRBit11Button.Text = "SL";
            this.MCRBit11Button.UseVisualStyleBackColor = true;
            this.MCRBit11Button.Visible = false;
            this.MCRBit11Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit10Button
            // 
            this.MCRBit10Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MCRBit10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit10Button.Location = new System.Drawing.Point(658, 58);
            this.MCRBit10Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit10Button.Name = "MCRBit10Button";
            this.MCRBit10Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit10Button.TabIndex = 11;
            this.MCRBit10Button.Tag = "0";
            this.MCRBit10Button.Text = "DY";
            this.MCRBit10Button.UseVisualStyleBackColor = true;
            this.MCRBit10Button.Visible = false;
            this.MCRBit10Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit8Button
            // 
            this.MCRBit8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit8Button.Location = new System.Drawing.Point(758, 58);
            this.MCRBit8Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit8Button.Name = "MCRBit8Button";
            this.MCRBit8Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit8Button.TabIndex = 2;
            this.MCRBit8Button.Tag = "0";
            this.MCRBit8Button.Text = "H";
            this.MCRBit8Button.UseVisualStyleBackColor = true;
            this.MCRBit8Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit9Button
            // 
            this.MCRBit9Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MCRBit9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit9Button.Location = new System.Drawing.Point(708, 58);
            this.MCRBit9Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit9Button.Name = "MCRBit9Button";
            this.MCRBit9Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit9Button.TabIndex = 1;
            this.MCRBit9Button.Tag = "0";
            this.MCRBit9Button.Text = "DP";
            this.MCRBit9Button.UseVisualStyleBackColor = true;
            this.MCRBit9Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit0Button
            // 
            this.MCRBit0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit0Button.Location = new System.Drawing.Point(758, 4);
            this.MCRBit0Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit0Button.Name = "MCRBit0Button";
            this.MCRBit0Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit0Button.TabIndex = 10;
            this.MCRBit0Button.Tag = "0";
            this.MCRBit0Button.Text = "Tx";
            this.MCRBit0Button.UseVisualStyleBackColor = true;
            this.MCRBit0Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit1Button
            // 
            this.MCRBit1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit1Button.Location = new System.Drawing.Point(708, 4);
            this.MCRBit1Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit1Button.Name = "MCRBit1Button";
            this.MCRBit1Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit1Button.TabIndex = 9;
            this.MCRBit1Button.Tag = "0";
            this.MCRBit1Button.Text = "Ov";
            this.MCRBit1Button.UseVisualStyleBackColor = true;
            this.MCRBit1Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit2Button
            // 
            this.MCRBit2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit2Button.Location = new System.Drawing.Point(658, 4);
            this.MCRBit2Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit2Button.Name = "MCRBit2Button";
            this.MCRBit2Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit2Button.TabIndex = 8;
            this.MCRBit2Button.Tag = "0";
            this.MCRBit2Button.Text = "G";
            this.MCRBit2Button.UseVisualStyleBackColor = true;
            this.MCRBit2Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit3Button
            // 
            this.MCRBit3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit3Button.Location = new System.Drawing.Point(608, 4);
            this.MCRBit3Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit3Button.Name = "MCRBit3Button";
            this.MCRBit3Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit3Button.TabIndex = 7;
            this.MCRBit3Button.Tag = "0";
            this.MCRBit3Button.Text = "B";
            this.MCRBit3Button.UseVisualStyleBackColor = true;
            this.MCRBit3Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit4Button
            // 
            this.MCRBit4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit4Button.Location = new System.Drawing.Point(542, 4);
            this.MCRBit4Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit4Button.Name = "MCRBit4Button";
            this.MCRBit4Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit4Button.TabIndex = 6;
            this.MCRBit4Button.Tag = "0";
            this.MCRBit4Button.Text = "Ti";
            this.MCRBit4Button.UseVisualStyleBackColor = true;
            this.MCRBit4Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit5Button
            // 
            this.MCRBit5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit5Button.Location = new System.Drawing.Point(492, 4);
            this.MCRBit5Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit5Button.Name = "MCRBit5Button";
            this.MCRBit5Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit5Button.TabIndex = 5;
            this.MCRBit5Button.Tag = "0";
            this.MCRBit5Button.Text = "S";
            this.MCRBit5Button.UseVisualStyleBackColor = true;
            this.MCRBit5Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit6Button
            // 
            this.MCRBit6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit6Button.Location = new System.Drawing.Point(442, 4);
            this.MCRBit6Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit6Button.Name = "MCRBit6Button";
            this.MCRBit6Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit6Button.TabIndex = 4;
            this.MCRBit6Button.Tag = "0";
            this.MCRBit6Button.Text = "Ga";
            this.MCRBit6Button.UseVisualStyleBackColor = true;
            this.MCRBit6Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MCRBit7Button
            // 
            this.MCRBit7Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MCRBit7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRBit7Button.Location = new System.Drawing.Point(392, 4);
            this.MCRBit7Button.Margin = new System.Windows.Forms.Padding(0);
            this.MCRBit7Button.Name = "MCRBit7Button";
            this.MCRBit7Button.Size = new System.Drawing.Size(52, 50);
            this.MCRBit7Button.TabIndex = 3;
            this.MCRBit7Button.Tag = "0";
            this.MCRBit7Button.Text = "D";
            this.MCRBit7Button.UseVisualStyleBackColor = true;
            this.MCRBit7Button.Click += new System.EventHandler(this.MCRBitButton_Click);
            // 
            // MasterControlLabel
            // 
            this.MasterControlLabel.AutoSize = true;
            this.MasterControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterControlLabel.Location = new System.Drawing.Point(8, 15);
            this.MasterControlLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MasterControlLabel.Name = "MasterControlLabel";
            this.MasterControlLabel.Size = new System.Drawing.Size(239, 29);
            this.MasterControlLabel.TabIndex = 0;
            this.MasterControlLabel.Text = "Master Control Reg";
            this.MasterControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HighlightPanel
            // 
            this.HighlightPanel.BackColor = System.Drawing.Color.Red;
            this.HighlightPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HighlightPanel.CausesValidation = false;
            this.HighlightPanel.Font = new System.Drawing.Font("Consolas", 10F);
            this.HighlightPanel.Location = new System.Drawing.Point(580, 517);
            this.HighlightPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighlightPanel.MaxLength = 2;
            this.HighlightPanel.Name = "HighlightPanel";
            this.HighlightPanel.Size = new System.Drawing.Size(40, 32);
            this.HighlightPanel.TabIndex = 4;
            this.HighlightPanel.TabStop = false;
            this.HighlightPanel.Text = "00";
            this.HighlightPanel.Visible = false;
            this.HighlightPanel.WordWrap = false;
            this.HighlightPanel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HighlightPanel_KeyUp);
            // 
            // PositionLabel
            // 
            this.PositionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(833, 545);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(148, 25);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.Text = "Position Label";
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveDialog
            // 
            this.SaveDialog.Filter = "Binary files|*.bin";
            this.SaveDialog.Title = "Save Memory to File";
            // 
            // MemoryWindow
            // 
            this.AcceptButton = this.ViewButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 654);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.HighlightPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.MemoryText);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1146, 652);
            this.Name = "MemoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Emulator Memory";
            this.Load += new System.EventHandler(this.MemoryWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemoryWindow_KeyDown);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private global::System.Windows.Forms.Button ViewButton;
        private global::System.Windows.Forms.TextBox EndAddressText;
        private global::System.Windows.Forms.TextBox StartAddressText;
        private global::System.Windows.Forms.TextBox MemoryText;
        private global::System.Windows.Forms.Panel HeaderPanel;
        private global::System.Windows.Forms.Timer UpdateDisplayTimer;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.ToolTip MemoryWindowTooltips;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Button MCRBit0Button;
        private System.Windows.Forms.Button MCRBit1Button;
        private System.Windows.Forms.Button MCRBit2Button;
        private System.Windows.Forms.Button MCRBit3Button;
        private System.Windows.Forms.Button MCRBit4Button;
        private System.Windows.Forms.Button MCRBit5Button;
        private System.Windows.Forms.Button MCRBit6Button;
        private System.Windows.Forms.Button MCRBit7Button;
        private System.Windows.Forms.Label MasterControlLabel;
        private System.Windows.Forms.TextBox HighlightPanel;
        private System.Windows.Forms.ComboBox AddressCombo;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.Button MCRBit8Button;
        private System.Windows.Forms.Button MCRBit9Button;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button MCRBit13Button;
        private System.Windows.Forms.Button MCRBit12Button;
        private System.Windows.Forms.Button MCRBit11Button;
        private System.Windows.Forms.Button MCRBit10Button;
    }
}