namespace RevInvent
{
    partial class Wizard
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
            this.wizardLabel = new System.Windows.Forms.Label();
            this.wizardTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wizardLabel
            // 
            this.wizardLabel.AutoSize = true;
            this.wizardLabel.Location = new System.Drawing.Point(73, 125);
            this.wizardLabel.Name = "wizardLabel";
            this.wizardLabel.Size = new System.Drawing.Size(0, 13);
            this.wizardLabel.TabIndex = 0;
            // 
            // wizardTextBox
            // 
            this.wizardTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.wizardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wizardTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.wizardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardTextBox.Location = new System.Drawing.Point(136, 99);
            this.wizardTextBox.Multiline = true;
            this.wizardTextBox.Name = "wizardTextBox";
            this.wizardTextBox.Size = new System.Drawing.Size(281, 136);
            this.wizardTextBox.TabIndex = 1;
            this.wizardTextBox.TabStop = false;
            this.wizardTextBox.Text = "This is the inventory wizard which will guide you through the configuration. To c" +
    "ontinue press next !";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(195, 285);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(101, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 397);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.wizardTextBox);
            this.Controls.Add(this.wizardLabel);
            this.Name = "Wizard";
            this.Text = "Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wizardLabel;
        private System.Windows.Forms.TextBox wizardTextBox;
        private System.Windows.Forms.Button nextButton;
    }
}