namespace RevInvent
{
    partial class Konfiguration
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
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.ipAdressLabel = new System.Windows.Forms.Label();
            this.ipAdressTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(188, 99);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(195, 20);
            this.serverTextBox.TabIndex = 0;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(39, 42);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(64, 13);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Client Setup";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(39, 102);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(64, 13);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Servername";
            // 
            // ipAdressLabel
            // 
            this.ipAdressLabel.AutoSize = true;
            this.ipAdressLabel.Location = new System.Drawing.Point(39, 132);
            this.ipAdressLabel.Name = "ipAdressLabel";
            this.ipAdressLabel.Size = new System.Drawing.Size(110, 13);
            this.ipAdressLabel.TabIndex = 3;
            this.ipAdressLabel.Text = "IP Adresse (alternativ)";
            // 
            // ipAdressTextBox
            // 
            this.ipAdressTextBox.Location = new System.Drawing.Point(188, 129);
            this.ipAdressTextBox.Name = "ipAdressTextBox";
            this.ipAdressTextBox.Size = new System.Drawing.Size(195, 20);
            this.ipAdressTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordTextBox.Location = new System.Drawing.Point(188, 232);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(188, 202);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(195, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 56);
            this.panel1.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(332, 16);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.Location = new System.Drawing.Point(189, 16);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(115, 23);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "next >";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(43, 16);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "< back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // Konfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.ipAdressTextBox);
            this.Controls.Add(this.ipAdressLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.serverTextBox);
            this.Name = "Konfiguration";
            this.Text = "Konfiguration";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label ipAdressLabel;
        private System.Windows.Forms.TextBox ipAdressTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button nextButton;
    }
}