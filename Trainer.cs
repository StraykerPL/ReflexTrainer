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
    public class Trainer
    {
        private TimeSpan BestTime;
        private Color AreaColor;
        private Stopwatch Timekeeper;
        private System.Timers.Timer ColorChangeTimekeeper;
        private readonly Random RandGen = new Random();
        private readonly PictureBox Area;

        public Trainer(PictureBox Area)
        {
            this.Area = Area;
        }

        public void RedArea()
        {
            AreaColor = Color.Red;
            Area.BackColor = AreaColor;
        }

        public void GreenArea()
        {
            AreaColor = Color.Green;
            Area.BackColor = AreaColor;
        }

        public void StartCounting()
        {
            Timekeeper = new Stopwatch();
            ColorChangeTimekeeper = new System.Timers.Timer();
            ColorChangeTimekeeper.Interval = RandGen.Next(5000, 10000);
            ColorChangeTimekeeper.Elapsed += new ElapsedEventHandler(TimerTick);
            Timekeeper.Start();
            ColorChangeTimekeeper.Enabled = true;
        }

        public void StopCounting()
        {
            Timekeeper.Stop();
            ColorChangeTimekeeper.Enabled = false;
        }

        public TimeSpan GetBestTime()
        {
            BestTime = Timekeeper.Elapsed;
            return BestTime;
        }

        public Color GetAreaColor()
        {
            return AreaColor;
        }

        private void TimerTick(object a, ElapsedEventArgs b)
        {
            GreenArea();
        }

        public void ClearScore()
        {
            BestTime = new TimeSpan(0, 0, 0, 0, 0);
            Timekeeper = new Stopwatch();
        }
    }
}
