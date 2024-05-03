namespace TextAnalyzer
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.charTextBox = new System.Windows.Forms.TextBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.charLabel = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.charTextBox);
            this.panel1.Controls.Add(this.reloadButton);
            this.panel1.Controls.Add(this.selectFileButton);
            this.panel1.Controls.Add(this.spaceLabel);
            this.panel1.Controls.Add(this.charLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(239, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 444);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Char to find:";
            // 
            // charTextBox
            // 
            this.charTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.charTextBox.Location = new System.Drawing.Point(0, 322);
            this.charTextBox.MaxLength = 1;
            this.charTextBox.Name = "charTextBox";
            this.charTextBox.Size = new System.Drawing.Size(239, 26);
            this.charTextBox.TabIndex = 4;
            this.charTextBox.Text = "A";
            // 
            // reloadButton
            // 
            this.reloadButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reloadButton.Location = new System.Drawing.Point(0, 348);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(239, 48);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectFileButton.Location = new System.Drawing.Point(0, 396);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(239, 48);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // spaceLabel
            // 
            this.spaceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.spaceLabel.Location = new System.Drawing.Point(0, 23);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(239, 23);
            this.spaceLabel.TabIndex = 1;
            this.spaceLabel.Text = "Space count:";
            // 
            // charLabel
            // 
            this.charLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.charLabel.Location = new System.Drawing.Point(0, 0);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(239, 23);
            this.charLabel.TabIndex = 0;
            this.charLabel.Text = "Char count:";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTextBox.Location = new System.Drawing.Point(0, 0);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(239, 444);
            this.dataTextBox.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Text Analyzer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox charTextBox;

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.TextBox dataTextBox;

        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Button selectFileButton;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}