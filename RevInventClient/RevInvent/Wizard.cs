﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevInvent
{
    public partial class Wizard : Form
    {
        public Wizard()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Form actualForm = Application.OpenForms["Wizard"];
            actualForm.Close();
            Konfiguration config = new Konfiguration();
            config.ShowDialog();
        }
        
    }
}
