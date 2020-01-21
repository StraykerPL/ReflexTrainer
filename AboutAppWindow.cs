/*
	Copyright (c) 2018-2020 Daniel Strayker Nowak
	All rights reserved
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Reflex_Trainer
{
    public partial class AboutAppWindow : System.Windows.Forms.Form
    {
        public AboutAppWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/StraykerPL/reflex_trainer");
        }
    }
}
