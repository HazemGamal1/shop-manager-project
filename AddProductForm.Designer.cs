﻿namespace shopManager
{
    partial class AddProductForm
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
            quantityNumericUpDown = new NumericUpDown();
            nameLabel = new Label();
            costLabel = new Label();
            nameTextBox = new TextBox();
            profitTextBox = new TextBox();
            profitLabel = new Label();
            categoryLabel = new Label();
            costTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            quantityLabel = new Label();
            addButton = new Button();
            addProdLapel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityNumericUpDown.BackColor = Color.LightGray;
            quantityNumericUpDown.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantityNumericUpDown.ForeColor = Color.Black;
            quantityNumericUpDown.Location = new Point(269, 392);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(250, 29);
            quantityNumericUpDown.TabIndex = 3;
            quantityNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.WhiteSmoke;
            nameLabel.Location = new Point(55, 258);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(90, 28);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // costLabel
            // 
            costLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            costLabel.BackColor = Color.Transparent;
            costLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            costLabel.ForeColor = Color.WhiteSmoke;
            costLabel.Location = new Point(55, 315);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(75, 28);
            costLabel.TabIndex = 23;
            costLabel.Text = "Cost";
            costLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameTextBox.BackColor = Color.FromArgb(44, 45, 60);
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(148, 258);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(371, 29);
            nameTextBox.TabIndex = 0;
            // 
            // profitTextBox
            // 
            profitTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            profitTextBox.BackColor = Color.FromArgb(44, 45, 60);
            profitTextBox.BorderStyle = BorderStyle.None;
            profitTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            profitTextBox.ForeColor = Color.White;
            profitTextBox.Location = new Point(399, 314);
            profitTextBox.Margin = new Padding(3, 2, 3, 2);
            profitTextBox.Name = "profitTextBox";
            profitTextBox.Size = new Size(120, 29);
            profitTextBox.TabIndex = 2;
            // 
            // profitLabel
            // 
            profitLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            profitLabel.BackColor = Color.Transparent;
            profitLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            profitLabel.ForeColor = Color.WhiteSmoke;
            profitLabel.Location = new Point(304, 314);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(86, 28);
            profitLabel.TabIndex = 25;
            profitLabel.Text = "Profit";
            // 
            // categoryLabel
            // 
            categoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = Color.Transparent;
            categoryLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.WhiteSmoke;
            categoryLabel.Location = new Point(55, 439);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(109, 27);
            categoryLabel.TabIndex = 21;
            categoryLabel.Text = "Category";
            // 
            // costTextBox
            // 
            costTextBox.BackColor = Color.FromArgb(44, 45, 60);
            costTextBox.BorderStyle = BorderStyle.None;
            costTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            costTextBox.ForeColor = Color.White;
            costTextBox.Location = new Point(150, 315);
            costTextBox.Margin = new Padding(3, 2, 3, 2);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(120, 29);
            costTextBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            categoryComboBox.BackColor = Color.LightGray;
            categoryComboBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categoryComboBox.ForeColor = Color.Black;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Cameras", "Phones", "Accessories" });
            categoryComboBox.Location = new Point(269, 439);
            categoryComboBox.Margin = new Padding(3, 2, 3, 2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(250, 31);
            categoryComboBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.WhiteSmoke;
            quantityLabel.Location = new Point(55, 392);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(109, 28);
            quantityLabel.TabIndex = 22;
            quantityLabel.Text = "Quantity";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(114, 0, 0);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(55, 569);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(215, 37);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // addProdLapel
            // 
            addProdLapel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProdLapel.BackColor = Color.Transparent;
            addProdLapel.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            addProdLapel.ForeColor = Color.White;
            addProdLapel.Location = new Point(111, 81);
            addProdLapel.Name = "addProdLapel";
            addProdLapel.Size = new Size(342, 28);
            addProdLapel.TabIndex = 26;
            addProdLapel.Text = "ADD NEW PRODUCT!";
            addProdLapel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(304, 569);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(215, 37);
            button1.TabIndex = 6;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 32);
            ClientSize = new Size(580, 677);
            Controls.Add(button1);
            Controls.Add(addProdLapel);
            Controls.Add(quantityLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(costTextBox);
            Controls.Add(categoryLabel);
            Controls.Add(addButton);
            Controls.Add(profitLabel);
            Controls.Add(profitTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(costLabel);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(nameLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 720);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label costLabel;
        private TextBox nameTextBox;
        private TextBox profitTextBox;
        private Label profitLabel;
        private Label categoryLabel;
        private TextBox costTextBox;
        private ComboBox categoryComboBox;
        private Label quantityLabel;
        private NumericUpDown quantityNumericUpDown;
        private Button addButton;
        private Label addProdLapel;
        private Button button1;
    }
}