namespace SharpAutoForm
{
    partial class SharpAutoForm
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
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.TradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.AdditionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ComputerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AutoCenterMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoCenterFontDialog = new System.Windows.Forms.FontDialog();
            this.AutoCenterColorDialog = new System.Windows.Forms.ColorDialog();
            this.AdditionalItemsGroupBox.SuspendLayout();
            this.ExteriorFinishGroupBox.SuspendLayout();
            this.AutoCenterMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriceLabel.Location = new System.Drawing.Point(86, 60);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(89, 20);
            this.BasePriceLabel.TabIndex = 0;
            this.BasePriceLabel.Text = "Base Price:";
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(28, 235);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(147, 20);
            this.TradeInAllowanceLabel.TabIndex = 1;
            this.TradeInAllowanceLabel.Text = "Trade-in Allowance:";
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(181, 60);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BasePriceTextBox.TabIndex = 2;
            this.BasePriceTextBox.Tag = "basePrice";
            this.BasePriceTextBox.TextChanged += new System.EventHandler(this.validValuesChecker);
            // 
            // TradeInAllowanceTextBox
            // 
            this.TradeInAllowanceTextBox.Location = new System.Drawing.Point(181, 235);
            this.TradeInAllowanceTextBox.Name = "TradeInAllowanceTextBox";
            this.TradeInAllowanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.TradeInAllowanceTextBox.TabIndex = 3;
            this.TradeInAllowanceTextBox.Tag = "tradeIn";
            this.TradeInAllowanceTextBox.Text = "0";
            this.TradeInAllowanceTextBox.TextChanged += new System.EventHandler(this.validValuesChecker);
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(33, 95);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(142, 20);
            this.AdditionalOptionsLabel.TabIndex = 4;
            this.AdditionalOptionsLabel.Text = "Additional Options:";
            // 
            // AdditionalOptionsTextBox
            // 
            this.AdditionalOptionsTextBox.Location = new System.Drawing.Point(181, 95);
            this.AdditionalOptionsTextBox.Name = "AdditionalOptionsTextBox";
            this.AdditionalOptionsTextBox.ReadOnly = true;
            this.AdditionalOptionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionalOptionsTextBox.TabIndex = 5;
            this.AdditionalOptionsTextBox.Text = "0";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(98, 130);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(77, 20);
            this.SubTotalLabel.TabIndex = 6;
            this.SubTotalLabel.Text = "SubTotal:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(181, 130);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 7;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(47, 165);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(128, 20);
            this.SalesTaxLabel.TabIndex = 8;
            this.SalesTaxLabel.Text = "Sales Tax (13%):";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(181, 165);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 9;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(127, 200);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(48, 20);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(181, 200);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 11;
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountDueLabel.Location = new System.Drawing.Point(72, 270);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(103, 20);
            this.AmountDueLabel.TabIndex = 12;
            this.AmountDueLabel.Text = "Amount Due:";
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(181, 270);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountDueTextBox.TabIndex = 13;
            // 
            // AdditionalItemsGroupBox
            // 
            this.AdditionalItemsGroupBox.Controls.Add(this.ComputerNavigationCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.LeatherInteriorCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.StereoSystemCheckBox);
            this.AdditionalItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalItemsGroupBox.Location = new System.Drawing.Point(347, 52);
            this.AdditionalItemsGroupBox.Name = "AdditionalItemsGroupBox";
            this.AdditionalItemsGroupBox.Size = new System.Drawing.Size(200, 127);
            this.AdditionalItemsGroupBox.TabIndex = 14;
            this.AdditionalItemsGroupBox.TabStop = false;
            this.AdditionalItemsGroupBox.Text = "Additional Items";
            // 
            // ComputerNavigationCheckBox
            // 
            this.ComputerNavigationCheckBox.AutoSize = true;
            this.ComputerNavigationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerNavigationCheckBox.Location = new System.Drawing.Point(20, 81);
            this.ComputerNavigationCheckBox.Name = "ComputerNavigationCheckBox";
            this.ComputerNavigationCheckBox.Size = new System.Drawing.Size(166, 22);
            this.ComputerNavigationCheckBox.TabIndex = 2;
            this.ComputerNavigationCheckBox.Tag = "";
            this.ComputerNavigationCheckBox.Text = "Computer Navigation";
            this.ComputerNavigationCheckBox.UseVisualStyleBackColor = true;
            this.ComputerNavigationCheckBox.CheckedChanged += new System.EventHandler(this._changesHandler);
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(20, 53);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(125, 22);
            this.LeatherInteriorCheckBox.TabIndex = 1;
            this.LeatherInteriorCheckBox.Tag = "";
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.LeatherInteriorCheckBox.CheckedChanged += new System.EventHandler(this._changesHandler);
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(20, 25);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(125, 22);
            this.StereoSystemCheckBox.TabIndex = 0;
            this.StereoSystemCheckBox.Tag = "";
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            this.StereoSystemCheckBox.CheckedChanged += new System.EventHandler(this._changesHandler);
            // 
            // ExteriorFinishGroupBox
            // 
            this.ExteriorFinishGroupBox.Controls.Add(this.CustomizedDetailingRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorFinishGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExteriorFinishGroupBox.Location = new System.Drawing.Point(347, 218);
            this.ExteriorFinishGroupBox.Name = "ExteriorFinishGroupBox";
            this.ExteriorFinishGroupBox.Size = new System.Drawing.Size(200, 126);
            this.ExteriorFinishGroupBox.TabIndex = 15;
            this.ExteriorFinishGroupBox.TabStop = false;
            this.ExteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // CustomizedDetailingRadioButton
            // 
            this.CustomizedDetailingRadioButton.AutoSize = true;
            this.CustomizedDetailingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomizedDetailingRadioButton.Location = new System.Drawing.Point(20, 87);
            this.CustomizedDetailingRadioButton.Name = "CustomizedDetailingRadioButton";
            this.CustomizedDetailingRadioButton.Size = new System.Drawing.Size(166, 22);
            this.CustomizedDetailingRadioButton.TabIndex = 2;
            this.CustomizedDetailingRadioButton.TabStop = true;
            this.CustomizedDetailingRadioButton.Text = "Customized Detailing";
            this.CustomizedDetailingRadioButton.UseVisualStyleBackColor = true;
            this.CustomizedDetailingRadioButton.CheckedChanged += new System.EventHandler(this._changesHandler);
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PearlizedRadioButton.Location = new System.Drawing.Point(20, 56);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(87, 22);
            this.PearlizedRadioButton.TabIndex = 1;
            this.PearlizedRadioButton.TabStop = true;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            this.PearlizedRadioButton.CheckedChanged += new System.EventHandler(this._changesHandler);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardRadioButton.Location = new System.Drawing.Point(20, 25);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(85, 22);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this._changesHandler);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(12, 404);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(92, 32);
            this.CalculateButton.TabIndex = 16;
            this.CalculateButton.Tag = "Calculate";
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.buttonClickHandler);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(241, 404);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(92, 32);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Tag = "Clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.buttonClickHandler);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(486, 404);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 32);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Tag = "Exit";
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.buttonClickHandler);
            // 
            // AutoCenterMenuStrip
            // 
            this.AutoCenterMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCenterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.AutoCenterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AutoCenterMenuStrip.Name = "AutoCenterMenuStrip";
            this.AutoCenterMenuStrip.Size = new System.Drawing.Size(590, 29);
            this.AutoCenterMenuStrip.TabIndex = 19;
            this.AutoCenterMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this._exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.toolStripSeparator,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(182, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.clearToolStripMenuItem.Tag = "";
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.fontToolStripMenuItem.Text = "&Font ...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this._fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.colorToolStripMenuItem.Text = "C&olor ...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this._colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
            // 
            // AutoCenterFontDialog
            // 
            this.AutoCenterFontDialog.MaxSize = 12;
            // 
            // SharpAutoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(590, 461);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExteriorFinishGroupBox);
            this.Controls.Add(this.AdditionalItemsGroupBox);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.AdditionalOptionsTextBox);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.TradeInAllowanceTextBox);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.TradeInAllowanceLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.AutoCenterMenuStrip);
            this.MainMenuStrip = this.AutoCenterMenuStrip;
            this.Name = "SharpAutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Center";
            this.AdditionalItemsGroupBox.ResumeLayout(false);
            this.AdditionalItemsGroupBox.PerformLayout();
            this.ExteriorFinishGroupBox.ResumeLayout(false);
            this.ExteriorFinishGroupBox.PerformLayout();
            this.AutoCenterMenuStrip.ResumeLayout(false);
            this.AutoCenterMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label TradeInAllowanceLabel;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.TextBox TradeInAllowanceTextBox;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.TextBox AdditionalOptionsTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.GroupBox AdditionalItemsGroupBox;
        private System.Windows.Forms.CheckBox ComputerNavigationCheckBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.GroupBox ExteriorFinishGroupBox;
        private System.Windows.Forms.RadioButton CustomizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MenuStrip AutoCenterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.FontDialog AutoCenterFontDialog;
        private System.Windows.Forms.ColorDialog AutoCenterColorDialog;
    }
}

