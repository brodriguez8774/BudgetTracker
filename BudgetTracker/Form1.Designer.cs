﻿namespace BudgetTracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.transactorsTab = new System.Windows.Forms.TabPage();
            this.transactorGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox3 = new System.Windows.Forms.TextBox();
            this.phoneLabel3 = new System.Windows.Forms.Label();
            this.phoneTextBox2 = new System.Windows.Forms.TextBox();
            this.phoneLabel2 = new System.Windows.Forms.Label();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.transactorListBox = new System.Windows.Forms.ListBox();
            this.transactorsToolStrip = new System.Windows.Forms.ToolStrip();
            this.addTransactorButton = new System.Windows.Forms.ToolStripButton();
            this.editTransactorButton = new System.Windows.Forms.ToolStripButton();
            this.removeTransactorButton = new System.Windows.Forms.ToolStripButton();
            this.transactionsTab = new System.Windows.Forms.TabPage();
            this.transactionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.tabControl1.SuspendLayout();
            this.transactorsTab.SuspendLayout();
            this.transactorGroupBox.SuspendLayout();
            this.transactorsToolStrip.SuspendLayout();
            this.transactionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.transactorsTab);
            this.tabControl1.Controls.Add(this.transactionsTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 478);
            this.tabControl1.TabIndex = 6;
            // 
            // transactorsTab
            // 
            this.transactorsTab.Controls.Add(this.transactorGroupBox);
            this.transactorsTab.Controls.Add(this.transactorListBox);
            this.transactorsTab.Controls.Add(this.transactorsToolStrip);
            this.transactorsTab.Location = new System.Drawing.Point(4, 22);
            this.transactorsTab.Name = "transactorsTab";
            this.transactorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.transactorsTab.Size = new System.Drawing.Size(882, 452);
            this.transactorsTab.TabIndex = 0;
            this.transactorsTab.Text = "TransactorTab";
            this.transactorsTab.UseVisualStyleBackColor = true;
            // 
            // transactorGroupBox
            // 
            this.transactorGroupBox.Controls.Add(this.categoryComboBox);
            this.transactorGroupBox.Controls.Add(this.phoneTextBox3);
            this.transactorGroupBox.Controls.Add(this.phoneLabel3);
            this.transactorGroupBox.Controls.Add(this.phoneTextBox2);
            this.transactorGroupBox.Controls.Add(this.phoneLabel2);
            this.transactorGroupBox.Controls.Add(this.phoneTextBox1);
            this.transactorGroupBox.Controls.Add(this.phoneLabel1);
            this.transactorGroupBox.Controls.Add(this.postalCodeTextBox);
            this.transactorGroupBox.Controls.Add(this.postalCodeLabel);
            this.transactorGroupBox.Controls.Add(this.regionComboBox);
            this.transactorGroupBox.Controls.Add(this.regionLabel);
            this.transactorGroupBox.Controls.Add(this.cityTextBox);
            this.transactorGroupBox.Controls.Add(this.cityLabel);
            this.transactorGroupBox.Controls.Add(this.addressTextBox);
            this.transactorGroupBox.Controls.Add(this.addressLabel);
            this.transactorGroupBox.Controls.Add(this.lastNameLabel);
            this.transactorGroupBox.Controls.Add(this.lastNameTextBox);
            this.transactorGroupBox.Controls.Add(this.firstNameLabel);
            this.transactorGroupBox.Controls.Add(this.firstNameTextBox);
            this.transactorGroupBox.Location = new System.Drawing.Point(340, 41);
            this.transactorGroupBox.Name = "transactorGroupBox";
            this.transactorGroupBox.Size = new System.Drawing.Size(520, 382);
            this.transactorGroupBox.TabIndex = 11;
            this.transactorGroupBox.TabStop = false;
            this.transactorGroupBox.Text = "transactorGroupBox";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(21, 33);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 18;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // phoneTextBox3
            // 
            this.phoneTextBox3.Location = new System.Drawing.Point(255, 186);
            this.phoneTextBox3.Name = "phoneTextBox3";
            this.phoneTextBox3.Size = new System.Drawing.Size(66, 20);
            this.phoneTextBox3.TabIndex = 17;
            this.phoneTextBox3.Visible = false;
            // 
            // phoneLabel3
            // 
            this.phoneLabel3.AutoSize = true;
            this.phoneLabel3.Location = new System.Drawing.Point(239, 189);
            this.phoneLabel3.Name = "phoneLabel3";
            this.phoneLabel3.Size = new System.Drawing.Size(10, 13);
            this.phoneLabel3.TabIndex = 16;
            this.phoneLabel3.Text = "-";
            this.phoneLabel3.Visible = false;
            // 
            // phoneTextBox2
            // 
            this.phoneTextBox2.Location = new System.Drawing.Point(183, 186);
            this.phoneTextBox2.Name = "phoneTextBox2";
            this.phoneTextBox2.Size = new System.Drawing.Size(50, 20);
            this.phoneTextBox2.TabIndex = 15;
            this.phoneTextBox2.Visible = false;
            // 
            // phoneLabel2
            // 
            this.phoneLabel2.AutoSize = true;
            this.phoneLabel2.Location = new System.Drawing.Point(167, 189);
            this.phoneLabel2.Name = "phoneLabel2";
            this.phoneLabel2.Size = new System.Drawing.Size(10, 13);
            this.phoneLabel2.TabIndex = 14;
            this.phoneLabel2.Text = "-";
            this.phoneLabel2.Visible = false;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.Location = new System.Drawing.Point(111, 186);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(50, 20);
            this.phoneTextBox1.TabIndex = 13;
            this.phoneTextBox1.Visible = false;
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.AutoSize = true;
            this.phoneLabel1.Location = new System.Drawing.Point(18, 189);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(81, 13);
            this.phoneLabel1.TabIndex = 12;
            this.phoneLabel1.Text = "Phone Number:";
            this.phoneLabel1.Visible = false;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(350, 261);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(90, 20);
            this.postalCodeTextBox.TabIndex = 11;
            this.postalCodeTextBox.Visible = false;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(319, 265);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(25, 13);
            this.postalCodeLabel.TabIndex = 10;
            this.postalCodeLabel.Text = "Zip:";
            this.postalCodeLabel.Visible = false;
            // 
            // regionComboBox
            // 
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(264, 258);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(50, 21);
            this.regionComboBox.TabIndex = 9;
            this.regionComboBox.Visible = false;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(223, 264);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(35, 13);
            this.regionLabel.TabIndex = 8;
            this.regionLabel.Text = "State:";
            this.regionLabel.Visible = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(84, 262);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(133, 20);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.Visible = false;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(18, 264);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City:";
            this.cityLabel.Visible = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(84, 226);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(356, 20);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.Visible = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(18, 229);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Visible = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(18, 125);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(21, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(300, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Visible = false;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(18, 72);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(21, 88);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(300, 20);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Visible = false;
            // 
            // transactorListBox
            // 
            this.transactorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.transactorListBox.FormattingEnabled = true;
            this.transactorListBox.Location = new System.Drawing.Point(27, 41);
            this.transactorListBox.Name = "transactorListBox";
            this.transactorListBox.Size = new System.Drawing.Size(286, 394);
            this.transactorListBox.TabIndex = 10;
            // 
            // transactorsToolStrip
            // 
            this.transactorsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.transactorsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactorButton,
            this.editTransactorButton,
            this.removeTransactorButton});
            this.transactorsToolStrip.Location = new System.Drawing.Point(3, 3);
            this.transactorsToolStrip.Name = "transactorsToolStrip";
            this.transactorsToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.transactorsToolStrip.Size = new System.Drawing.Size(876, 25);
            this.transactorsToolStrip.TabIndex = 9;
            this.transactorsToolStrip.Text = "transactorsToolStrip";
            // 
            // addTransactorButton
            // 
            this.addTransactorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addTransactorButton.Image = ((System.Drawing.Image)(resources.GetObject("addTransactorButton.Image")));
            this.addTransactorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTransactorButton.Name = "addTransactorButton";
            this.addTransactorButton.Size = new System.Drawing.Size(119, 22);
            this.addTransactorButton.Text = "Add New Transactor";
            this.addTransactorButton.Click += new System.EventHandler(this.addTransactorButton_Click);
            // 
            // editTransactorButton
            // 
            this.editTransactorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editTransactorButton.Image = ((System.Drawing.Image)(resources.GetObject("editTransactorButton.Image")));
            this.editTransactorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTransactorButton.Name = "editTransactorButton";
            this.editTransactorButton.Size = new System.Drawing.Size(90, 22);
            this.editTransactorButton.Text = "Edit Transactor";
            this.editTransactorButton.Click += new System.EventHandler(this.editTransactorButton_Click);
            // 
            // removeTransactorButton
            // 
            this.removeTransactorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeTransactorButton.Image = ((System.Drawing.Image)(resources.GetObject("removeTransactorButton.Image")));
            this.removeTransactorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeTransactorButton.Name = "removeTransactorButton";
            this.removeTransactorButton.Size = new System.Drawing.Size(113, 22);
            this.removeTransactorButton.Text = "Remove Transactor";
            this.removeTransactorButton.Click += new System.EventHandler(this.removeTransactorButton_Click);
            // 
            // transactionsTab
            // 
            this.transactionsTab.Controls.Add(this.transactionsToolStrip);
            this.transactionsTab.Location = new System.Drawing.Point(4, 22);
            this.transactionsTab.Name = "transactionsTab";
            this.transactionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsTab.Size = new System.Drawing.Size(882, 452);
            this.transactionsTab.TabIndex = 1;
            this.transactionsTab.Text = "TransactionsTab";
            this.transactionsTab.UseVisualStyleBackColor = true;
            // 
            // transactionsToolStrip
            // 
            this.transactionsToolStrip.Location = new System.Drawing.Point(3, 3);
            this.transactionsToolStrip.Name = "transactionsToolStrip";
            this.transactionsToolStrip.Size = new System.Drawing.Size(876, 25);
            this.transactionsToolStrip.TabIndex = 0;
            this.transactionsToolStrip.Text = "transactionsToolStrip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.transactorsTab.ResumeLayout(false);
            this.transactorsTab.PerformLayout();
            this.transactorGroupBox.ResumeLayout(false);
            this.transactorGroupBox.PerformLayout();
            this.transactorsToolStrip.ResumeLayout(false);
            this.transactorsToolStrip.PerformLayout();
            this.transactionsTab.ResumeLayout(false);
            this.transactionsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage transactorsTab;
        private System.Windows.Forms.TabPage transactionsTab;
        private System.Windows.Forms.ListBox transactorListBox;
        private System.Windows.Forms.ToolStrip transactorsToolStrip;
        private System.Windows.Forms.ToolStripButton addTransactorButton;
        private System.Windows.Forms.ToolStripButton editTransactorButton;
        private System.Windows.Forms.ToolStripButton removeTransactorButton;
        private System.Windows.Forms.ToolStrip transactionsToolStrip;
        private System.Windows.Forms.GroupBox transactorGroupBox;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox phoneTextBox3;
        private System.Windows.Forms.Label phoneLabel3;
        private System.Windows.Forms.TextBox phoneTextBox2;
        private System.Windows.Forms.Label phoneLabel2;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.Label phoneLabel1;
        private System.Windows.Forms.ComboBox categoryComboBox;

    }
}

