using System.Windows.Forms;

namespace StansGrocery
{
    partial class StansGroceryForm
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
            this.ChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.FilterByAisleRadioButton = new System.Windows.Forms.RadioButton();
            this.FilterByCategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTopStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoiceComboBox
            // 
            this.ChoiceComboBox.FormattingEnabled = true;
            this.ChoiceComboBox.Location = new System.Drawing.Point(82, 418);
            this.ChoiceComboBox.Name = "ChoiceComboBox";
            this.ChoiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.ChoiceComboBox.TabIndex = 0;
            this.ChoiceComboBox.SelectedIndexChanged += ChoiceComboBox_SelectedIndexChanged;
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(18, 41);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(770, 329);
            this.DisplayListBox.TabIndex = 1;
            // 
            // FilterByAisleRadioButton
            // 
            this.FilterByAisleRadioButton.AutoSize = true;
            this.FilterByAisleRadioButton.Location = new System.Drawing.Point(18, 386);
            this.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton";
            this.FilterByAisleRadioButton.Size = new System.Drawing.Size(87, 17);
            this.FilterByAisleRadioButton.TabIndex = 2;
            this.FilterByAisleRadioButton.TabStop = true;
            this.FilterByAisleRadioButton.Text = "Filter By Aisle";
            this.FilterByAisleRadioButton.UseVisualStyleBackColor = true;
            this.FilterByAisleRadioButton.Click += FilterByAisleRadioButton_CheckedChanged;
            // 
            // FilterByCategoryRadioButton
            // 
            this.FilterByCategoryRadioButton.AutoSize = true;
            this.FilterByCategoryRadioButton.Location = new System.Drawing.Point(124, 386);
            this.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton";
            this.FilterByCategoryRadioButton.Size = new System.Drawing.Size(107, 17);
            this.FilterByCategoryRadioButton.TabIndex = 3;
            this.FilterByCategoryRadioButton.TabStop = true;
            this.FilterByCategoryRadioButton.Text = "Filter By Category";
            this.FilterByCategoryRadioButton.UseVisualStyleBackColor = true;
            this.FilterByCategoryRadioButton.Click += FilterByCategoryRadioButton_CheckedChanged;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(337, 414);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(136, 20);
            this.SearchTextBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(495, 408);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 30);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += SearchButton_Click;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(646, 408);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(145, 30);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += ExitButton_Click;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(290, 417);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Search";
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(47, 421);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(29, 13);
            this.FilterLabel.TabIndex = 9;
            this.FilterLabel.Text = "Filter";
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Font = new System.Drawing.Font("Source Code Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTopMenuItem,
            this.HelpTopMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.TopMenuStrip.Size = new System.Drawing.Size(800, 29);
            this.TopMenuStrip.TabIndex = 10;
            // 
            // MenuTopMenuItem
            // 
            this.MenuTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchTopMenuItem,
            this.ExitTopMenuItem});
            this.MenuTopMenuItem.Name = "MenuTopMenuItem";
            this.MenuTopMenuItem.Size = new System.Drawing.Size(54, 25);
            this.MenuTopMenuItem.Text = "Menu";
            // 
            // SearchTopMenuItem
            // 
            this.SearchTopMenuItem.Name = "SearchTopMenuItem";
            this.SearchTopMenuItem.Size = new System.Drawing.Size(180, 26);
            this.SearchTopMenuItem.Text = "&Search";
            this.SearchTopMenuItem.Click += SearchButton_Click;
            // 
            // ExitTopMenuItem
            // 
            this.ExitTopMenuItem.Name = "ExitTopMenuItem";
            this.ExitTopMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ExitTopMenuItem.Text = "E&xit";
            this.ExitTopMenuItem.Click += ExitButton_Click;
            // 
            // HelpTopMenuItem
            // 
            this.HelpTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTopStripMenuItem});
            this.HelpTopMenuItem.Name = "HelpTopMenuItem";
            this.HelpTopMenuItem.Size = new System.Drawing.Size(54, 25);
            this.HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopStripMenuItem
            // 
            this.AboutTopStripMenuItem.Name = "AboutTopStripMenuItem";
            this.AboutTopStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.AboutTopStripMenuItem.Text = "&About";
            this.AboutTopStripMenuItem.Click += AboutTopStripMenuItem_Click;
            // 
            // StansGroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopMenuStrip);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.FilterByCategoryRadioButton);
            this.Controls.Add(this.FilterByAisleRadioButton);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.ChoiceComboBox);
            this.Name = "StansGroceryForm";
            this.Text = "Form1";
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FilterByCategoryRadioButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox ChoiceComboBox;
        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.RadioButton FilterByAisleRadioButton;
        private System.Windows.Forms.RadioButton FilterByCategoryRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutTopStripMenuItem;
    }
}

