/*
	Copyright (c) 2018-2020 Daniel Strayker Nowak
	All rights reserved
*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Reflex_Trainer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Trainer trainer; // Holds timer instance,

        public Form()
        {
            InitializeComponent();
            StatusLabel.Text = "Welcome to Reflex Trainer!\nClick here to start training!";
        }

        // Executes when "Save score" in menu is clicked:
        private void SaveScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Checks, if app is in valid state to save score:
            if(trainer == null || StatusLabel.Text == "Too fast!" || trainer.GetBestTime().Milliseconds == 0)
            {
                MessageBox.Show("There is no achieved score in this Reflex Trainer session or trying saving too-fast-clicked score!", "Reflex Trainer", MessageBoxButtons.OK);
                return;
            }

            folderBrowserDialog1.Description = "Choose path, where to save file:";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath == "") return; // If user didn't choose the path,

            // Trying to save score:
            try
            {
                var save = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\Score.txt");
                save.WriteLine("Your score: {0}ms !", trainer.GetBestTime().Milliseconds);
                save.WriteLine("Score achieved in Reflex Trainer app!");
                save.WriteLine("http://www.straykerpl.github.io");
                save.Dispose();
            }
            catch (Exception a)
            {
                MessageBox.Show("Can't save score: " + a.Message, "Reflex Trainer", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Score saved successful!", "Reflex Trainer", MessageBoxButtons.OK);
        }

        // Executes when "Start training" in menu is clicked:
        private void StartTrainingElement_Click(object sender, EventArgs e)
        {
            StartTraining();
        }

        // Executes when "Stop training" in menu is clicked:
        private void StopTrainingElement_Click(object sender, EventArgs e)
        {
            StopTraining();
            trainer.ClearScore();
        }

        // Executes when "Exit" in menu is clicked:
        private void ExitElement_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Executes when "Documentation" in menu is clicked:
        private void DocsElement_Click(object sender, EventArgs e)
        {
            Process.Start("http://straykerpl.github.io");
        }

        // Executes when "About app" in menu is clicked:
        private void AboutAppElement_Click(object sender, EventArgs e)
        {
            var info = new AboutAppWindow();
            info.ShowDialog();
        }

        // Executes when training area is clicked:
        private void AreaClicked(object sender, EventArgs e)
        {
            // Check, if user clicked in area when color is green:
            if(trainer.GetAreaColor() == Color.Green)
            { // Green color:
                trainer.StopCounting();
                var time = trainer.GetBestTime();
                StatusLabel.Text = string.Concat("Your reaction time: " + time.Milliseconds + " ms!\nClick here to start again!");
                StatusPanel.Visible = true;
                MenuControl(true);
            }
            else
            { // Red color:
                trainer.StopCounting();
                StatusLabel.Text = "Too fast!";
                StatusPanel.Visible = true;
                MenuControl(true);
            }
        }

        // Method to block or unblock menu entries, true for no-training mode, false for training mode:
        public void MenuControl(bool value)
        {
            var a = menuStrip1.Items.Find("StartTrainingElement", true); // Start training,
            var b = menuStrip1.Items.Find("SaveScoreElement", true); // Save score,
            var c = menuStrip1.Items.Find("HelpElement", true); // Help menu,
            var d = menuStrip1.Items.Find("StopTrainingElement", true); // Stop training,

            a[0].Enabled = value;
            b[0].Enabled = value;
            c[0].Enabled = value;
            d[0].Enabled = !value; // Negation here, because "Stop training" menu must be blocked in non-training mode,
        }

        // Starts training by clicking greeting panel:
        private void StatusPanel_Click(object sender, EventArgs e)
        {
            StartTraining();
        }

        // Starts training by clicking greeting message:
        private void StatusLabel_Click(object sender, EventArgs e)
        {
            StartTraining();
        }

        // Method for starting training instructions:
        private void StartTraining()
        {
            MenuControl(false); // Blocking menu entries,
            StatusPanel.Visible = false; // Hide welcome panel,
            trainer = new Trainer(AreaBox); // Create instance of trainer,
            trainer.RedArea(); // Chceck, if training area is red,
            AreaBox.Click += new EventHandler(AreaClicked); // Make sure click handler is added,
            trainer.StartCounting(); // Start counting of time,
        }

        // Method for stopping training instructions:
        private void StopTraining()
        {
            MenuControl(true); // Unblock the menu,
            StatusPanel.Visible = true; // Show welcome panel...
            StatusLabel.Text = "Welcome to Reflex Trainer!\nClick here to start training!"; // ... and display the welcome message,
            trainer.StopCounting(); // Stop all counting,
            trainer.RedArea(); // Set training area to red again,
        }
    }
}
