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
            this.ChoiceListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoiceComboBox
            // 
            this.ChoiceComboBox.FormattingEnabled = true;
            this.ChoiceComboBox.Location = new System.Drawing.Point(157, 379);
            this.ChoiceComboBox.Name = "ChoiceComboBox";
            this.ChoiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.ChoiceComboBox.TabIndex = 0;
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(82, 28);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(617, 290);
            this.DisplayListBox.TabIndex = 1;
            // 
            // FilterByAisleRadioButton
            // 
            this.FilterByAisleRadioButton.AutoSize = true;
            this.FilterByAisleRadioButton.Location = new System.Drawing.Point(27, 380);
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
            this.FilterByCategoryRadioButton.Location = new System.Drawing.Point(27, 403);
            this.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton";
            this.FilterByCategoryRadioButton.Size = new System.Drawing.Size(107, 17);
            this.FilterByCategoryRadioButton.TabIndex = 3;
            this.FilterByCategoryRadioButton.TabStop = true;
            this.FilterByCategoryRadioButton.Text = "Filter By Category";
            this.FilterByCategoryRadioButton.UseVisualStyleBackColor = true;
            this.FilterByCategoryRadioButton.Click += FilterByCategoryRadioButton_CheckedChanged;
            // 
            // ChoiceListBox
            // 
            this.ChoiceListBox.FormattingEnabled = true;
            this.ChoiceListBox.Location = new System.Drawing.Point(320, 383);
            this.ChoiceListBox.Name = "ChoiceListBox";
            this.ChoiceListBox.Size = new System.Drawing.Size(186, 17);
            this.ChoiceListBox.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(538, 380);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(136, 20);
            this.SearchTextBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(389, 335);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 30);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += SearchButton_Click;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(540, 335);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(145, 30);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += ExitButton_Click;
            // 
            // StansGroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ChoiceListBox);
            this.Controls.Add(this.FilterByCategoryRadioButton);
            this.Controls.Add(this.FilterByAisleRadioButton);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.ChoiceComboBox);
            this.Name = "StansGroceryForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.ListBox ChoiceListBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

