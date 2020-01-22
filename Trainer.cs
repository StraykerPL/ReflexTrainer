/*
	Copyright (c) 2018-2020 Daniel Strayker Nowak
	All rights reserved
*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Reflex_Trainer
{
    // Class for managing training in app:
    public class Trainer
    {
        private TimeSpan BestTime; // Holds best time,
        private Color AreaColor; // Holds color of training area,
        private Stopwatch Timekeeper; // Counts time for training session,
        private System.Timers.Timer ColorChangeTimekeeper; // Counts time for changing background from red to green,
        private readonly Random RandGen = new Random(); // Random generator,
        private readonly PictureBox Area; // Holds the trainig area for class's methods,

        // Constructor, this class needs training area to operate:
        public Trainer(PictureBox Area)
        {
            this.Area = Area;
        }

        // Sets training area to red color:
        public void RedArea()
        {
            AreaColor = Color.Red;
            Area.BackColor = AreaColor;
        }

        // Sets training area to green color:
        public void GreenArea()
        {
            AreaColor = Color.Green;
            Area.BackColor = AreaColor;
        }

        // Start counter for reflex time:
        public void StartCounting()
        {
            Timekeeper = new Stopwatch();
            ColorChangeTimekeeper = new System.Timers.Timer();
            ColorChangeTimekeeper.Interval = RandGen.Next(5000, 10000);
            ColorChangeTimekeeper.Elapsed += new ElapsedEventHandler(TimerTick);
            ColorChangeTimekeeper.Enabled = true;
        }

        // Stops all counters:
        public void StopCounting()
        {
            Timekeeper.Stop();
            ColorChangeTimekeeper.Enabled = false;
        }

        // Gets the best time for last session:
        public TimeSpan GetBestTime()
        {
            BestTime = Timekeeper.Elapsed;
            return BestTime;
        }

        // Gets active area color:
        public Color GetAreaColor()
        {
            return AreaColor;
        }

        // This method rises when it's time to change color from red to green:
        private void TimerTick(object a, ElapsedEventArgs b)
        {
            GreenArea();
            Timekeeper.Start();
        }

        // Clears best score from app memory:
        public void ClearScore()
        {
            BestTime = new TimeSpan(0, 0, 0, 0, 0);
            Timekeeper = new Stopwatch();
        }
    }
}
