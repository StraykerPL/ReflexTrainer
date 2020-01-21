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
        public Trainer trainer;

        public Form()
        {
            InitializeComponent();
            StatusLabel.Text = "Welcome to Reflex Trainer!\nClick here to start training!";
        }

        private void SaveScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(trainer == null || StatusLabel.Text == "Too fast!" || trainer.GetBestTime().Milliseconds == 0)
            {
                MessageBox.Show("There is no achieved score in this Reflex Trainer session or trying saving too-fast-clicked score!", "Reflex Trainer", MessageBoxButtons.OK);
                return;
            }

            folderBrowserDialog1.Description = "Choose path, where to save file:";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath == "") return;

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

        private void StartTrainingElement_Click(object sender, EventArgs e)
        {
            StartTraining();
        }

        private void StopTrainingElement_Click(object sender, EventArgs e)
        {
            StopTraining();
            trainer.ClearScore();
        }

        private void ExitElement_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DocsElement_Click(object sender, EventArgs e)
        {
            Process.Start("http://straykerpl.github.io");
        }

        private void AboutAppElement_Click(object sender, EventArgs e)
        {
            var info = new AboutAppWindow();
            info.ShowDialog();
        }

        private void AreaClicked(object sender, EventArgs e)
        {
            if(trainer.GetAreaColor() == Color.Green)
            {
                trainer.StopCounting();
                var time = trainer.GetBestTime();
                StatusLabel.Text = string.Concat("Your reaction time: " + time.Milliseconds + " ms!\nClick here to start again!");
                StatusPanel.Visible = true;
                MenuControl(true);
            }
            else
            {
                trainer.StopCounting();
                StatusLabel.Text = "Too fast!";
                StatusPanel.Visible = true;
                MenuControl(true);
            }
        }

        public void MenuControl(bool value)
        {
            var a = menuStrip1.Items.Find("StartTrainingElement", true); // Start training,
            var b = menuStrip1.Items.Find("SaveScoreElement", true); // Save score,
            var c = menuStrip1.Items.Find("HelpElement", true); // Help menu,
            var d = menuStrip1.Items.Find("StopTrainingElement", true);

            a[0].Enabled = value;
            b[0].Enabled = value;
            c[0].Enabled = value;
            d[0].Enabled = !value;
        }

        private void StatusPanel_Click(object sender, EventArgs e)
        {
            StartTraining();
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            StartTraining();
        }

        private void StartTraining()
        {
            MenuControl(false);
            StatusPanel.Visible = false;
            trainer = new Trainer(AreaBox);
            trainer.RedArea();
            AreaBox.Click += new EventHandler(AreaClicked);
            trainer.StartCounting();
        }

        private void StopTraining()
        {
            MenuControl(true);
            StatusPanel.Visible = true;
            StatusLabel.Text = "Welcome to Reflex Trainer!\nClick here to start training!";
            trainer.StopCounting();
            trainer.RedArea();
        }
    }
}
