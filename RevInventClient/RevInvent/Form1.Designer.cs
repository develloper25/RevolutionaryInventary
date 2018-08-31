namespace RevInvent
{
    partial class revInventForm
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
            this.revInventTextBox = new System.Windows.Forms.TextBox();
            this.startInventoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // revInventTextBox
            // 
            this.revInventTextBox.Location = new System.Drawing.Point(98, 98);
            this.revInventTextBox.Multiline = true;
            this.revInventTextBox.Name = "revInventTextBox";
            this.revInventTextBox.Size = new System.Drawing.Size(617, 253);
            this.revInventTextBox.TabIndex = 0;
            // 
            // startInventoryButton
            // 
            this.startInventoryButton.Location = new System.Drawing.Point(298, 416);
            this.startInventoryButton.Name = "startInventoryButton";
            this.startInventoryButton.Size = new System.Drawing.Size(212, 31);
            this.startInventoryButton.TabIndex = 1;
            this.startInventoryButton.Text = "Start Inventory";
            this.startInventoryButton.UseVisualStyleBackColor = true;
            this.startInventoryButton.Click += new System.EventHandler(this.startInventoryButton_Click);
            // 
            // revInventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 495);
            this.Controls.Add(this.startInventoryButton);
            this.Controls.Add(this.revInventTextBox);
            this.Name = "revInventForm";
            this.Text = "RevolutionaryInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox revInventTextBox;
        private System.Windows.Forms.Button startInventoryButton;
    }
}

