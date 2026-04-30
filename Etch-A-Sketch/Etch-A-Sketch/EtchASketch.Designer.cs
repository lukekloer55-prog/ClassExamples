using System.Windows.Forms;

namespace Etch_A_Sketch
{
    partial class EtchASketch
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
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainDisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.DisplayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DrawMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackGroundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PenColorDialog = new System.Windows.Forms.ColorDialog();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTopStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.DrawingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplayPictureBox)).BeginInit();
            this.DisplayContextMenuStrip.SuspendLayout();
            this.TopMenuStrip.SuspendLayout();
            this.BottomStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDisplayPictureBox
            // 
            this.MainDisplayPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDisplayPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainDisplayPictureBox.ContextMenuStrip = this.DisplayContextMenuStrip;
            this.MainDisplayPictureBox.InitialImage = null;
            this.MainDisplayPictureBox.Location = new System.Drawing.Point(16, 37);
            this.MainDisplayPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MainDisplayPictureBox.Name = "MainDisplayPictureBox";
            this.MainDisplayPictureBox.Size = new System.Drawing.Size(931, 437);
            this.MainDisplayPictureBox.TabIndex = 0;
            this.MainDisplayPictureBox.TabStop = false;
            // 
            // DisplayContextMenuStrip
            // 
            this.DisplayContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DisplayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawMenuItem,
            this.ClearMenuItem,
            this.ColorMenuItem,
            this.PenSizeMenuItem});
            this.DisplayContextMenuStrip.Name = "DisplayContextMenuStrip";
            this.DisplayContextMenuStrip.Size = new System.Drawing.Size(118, 92);
            // 
            // DrawMenuItem
            // 
            this.DrawMenuItem.Name = "DrawMenuItem";
            this.DrawMenuItem.Size = new System.Drawing.Size(117, 22);
            this.DrawMenuItem.Text = "Draw";
            // 
            // ClearMenuItem
            // 
            this.ClearMenuItem.Name = "ClearMenuItem";
            this.ClearMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ClearMenuItem.Text = "Clear";
            // 
            // ColorMenuItem
            // 
            this.ColorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenMenuItem,
            this.BackGroundMenuItem});
            this.ColorMenuItem.Name = "ColorMenuItem";
            this.ColorMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ColorMenuItem.Text = "Color";
            // 
            // PenMenuItem
            // 
            this.PenMenuItem.Name = "PenMenuItem";
            this.PenMenuItem.Size = new System.Drawing.Size(142, 22);
            this.PenMenuItem.Text = "Pen";
            this.PenMenuItem.Click += PenMenuItem_Click;
            // 
            // BackGroundMenuItem
            // 
            this.BackGroundMenuItem.Name = "BackGroundMenuItem";
            this.BackGroundMenuItem.Size = new System.Drawing.Size(142, 22);
            this.BackGroundMenuItem.Text = "Back Ground";
            this.BackGroundMenuItem.Click += BackGroundMenuItem_Click;
            // 
            // PenSizeMenuItem
            // 
            this.PenSizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolComboBox});
            this.PenSizeMenuItem.Name = "PenSizeMenuItem";
            this.PenSizeMenuItem.Size = new System.Drawing.Size(117, 22);
            this.PenSizeMenuItem.Text = "Pen Size";
            // 
            // ToolComboBox
            // 
            this.ToolComboBox.Name = "ToolComboBox";
            this.ToolComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(775, 482);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(170, 63);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += ExitButton_Click;
            // 
            // DrawButton
            // 
            this.DrawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawButton.Location = new System.Drawing.Point(598, 482);
            this.DrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(170, 63);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "&Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += DrawButton_Click;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearButton.Location = new System.Drawing.Point(420, 482);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(170, 63);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;  
            this.ClearButton.Click += ClearButton_Click;
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
            this.TopMenuStrip.Size = new System.Drawing.Size(960, 29);
            this.TopMenuStrip.TabIndex = 4;
            // 
            // MenuTopMenuItem
            // 
            this.MenuTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawTopMenuItem,
            this.ClearTopMenuItem,
            this.ExitTopMenuItem});
            this.MenuTopMenuItem.Name = "MenuTopMenuItem";
            this.MenuTopMenuItem.Size = new System.Drawing.Size(54, 25);
            this.MenuTopMenuItem.Text = "Menu";
            this.DrawTopMenuItem.Click += DrawButton_Click;
            this.ClearButton.Click += ClearButton_Click;
            // 
            // DrawTopMenuItem
            // 
            this.DrawTopMenuItem.Name = "DrawTopMenuItem";
            this.DrawTopMenuItem.Size = new System.Drawing.Size(120, 26);
            this.DrawTopMenuItem.Text = "&Draw";
            // 
            // ClearTopMenuItem
            // 
            this.ClearTopMenuItem.Name = "ClearTopMenuItem";
            this.ClearTopMenuItem.Size = new System.Drawing.Size(120, 26);
            this.ClearTopMenuItem.Text = "&Clear";
            this.ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            this.ExitTopMenuItem.Name = "ExitTopMenuItem";
            this.ExitTopMenuItem.Size = new System.Drawing.Size(120, 26);
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
            this.AboutTopStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.AboutTopStripMenuItem.Text = "&About";
            this.AboutTopStripMenuItem.Click += AboutTopStripMenuItem_Click;
            // 
            // BottomStatusStrip
            // 
            this.BottomStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawingStatusLabel});
            this.BottomStatusStrip.Location = new System.Drawing.Point(0, 559);
            this.BottomStatusStrip.Name = "BottomStatusStrip";
            this.BottomStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.BottomStatusStrip.Size = new System.Drawing.Size(960, 22);
            this.BottomStatusStrip.TabIndex = 5;
            this.BottomStatusStrip.Text = "statusStrip1";
            // 
            // DrawingStatusLabel
            // 
            this.DrawingStatusLabel.Name = "DrawingStatusLabel";
            this.DrawingStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.DrawingStatusLabel.Text = "-";
            // 
            // EtchASketch
            // 
            this.AcceptButton = this.DrawButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ClearButton;
            this.ClientSize = new System.Drawing.Size(960, 581);
            this.Controls.Add(this.BottomStatusStrip);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainDisplayPictureBox);
            this.Controls.Add(this.TopMenuStrip);
            this.Font = new System.Drawing.Font("Source Code Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.TopMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(536, 529);
            this.Name = "EtchASketch";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplayPictureBox)).EndInit();
            this.DisplayContextMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.BottomStatusStrip.ResumeLayout(false);
            this.BottomStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DrawTopMenuItem_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private ToolTip MainToolTip;
        private PictureBox MainDisplayPictureBox;
        private Button ExitButton;
        private Button DrawButton;
        private Button ClearButton;
        private ColorDialog PenColorDialog;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem MenuTopMenuItem;
        private ToolStripMenuItem DrawTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopStripMenuItem;
        private ContextMenuStrip DisplayContextMenuStrip;
        private ToolStripMenuItem DrawMenuItem;
        private ToolStripMenuItem ClearMenuItem;
        private ToolStripMenuItem ColorMenuItem;
        private ToolStripMenuItem PenMenuItem;
        private ToolStripMenuItem BackGroundMenuItem;
        private ToolStripMenuItem PenSizeMenuItem;
        private ToolStripComboBox ToolComboBox;
        private StatusStrip BottomStatusStrip;
        private ToolStripStatusLabel DrawingStatusLabel;
    }

       
    
}

