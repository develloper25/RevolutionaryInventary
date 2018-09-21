using System;
using System.IO;
using System.Windows.Forms;

namespace RevInvent
{
    public partial class Konfiguration : Form
    {
        public Konfiguration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\temp\AppData\Local\RevolutionaryInventory\revInvent.cfg");
            writer.WriteLine(serverTextBox.Text);
            writer.WriteLine(ipAdressTextBox.Text);
            writer.WriteLine(usernameTextBox.Text);
            writer.WriteLine(passwordTextBox.Text);
            Form actualForm = Application.OpenForms["Konfiguration"];
            actualForm.Close();
        }
    }
}
