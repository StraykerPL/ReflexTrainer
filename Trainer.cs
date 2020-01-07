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
        private TimeSpan Najlepszy_czas;
        private Color Kolor_planszy;
        private Stopwatch Czasomierz;
        private System.Timers.Timer Miernik_zmian_kolor;
        private Random LosGen = new Random();
        private PictureBox Pole;

        public Trainer(PictureBox pole_treningowe)
        {
            this.Pole = pole_treningowe;
        }

        public void Czerwona_plansza()
        {
            Kolor_planszy = Color.Red;
            Pole.BackColor = Kolor_planszy;
        }

        public void Zielona_plansza()
        {
            Kolor_planszy = Color.Green;
            Pole.BackColor = Kolor_planszy;
        }

        public void Rozpocznij_odliczanie()
        {
            Czasomierz = new Stopwatch();
            Miernik_zmian_kolor = new System.Timers.Timer();
            Miernik_zmian_kolor.Interval = LosGen.Next(5000, 10000);
            Miernik_zmian_kolor.Elapsed += new ElapsedEventHandler(TimerTick);
            Czasomierz.Start();
            Miernik_zmian_kolor.Enabled = true;
        }

        public void Zakończ_odliczanie()
        {
            Czasomierz.Stop();
            Miernik_zmian_kolor.Enabled = false;
        }

        public TimeSpan Jaki_najlepszy_czas()
        {
            Najlepszy_czas = Czasomierz.Elapsed;
            return Najlepszy_czas;
        }

        public Color Jaki_kolor_planszy()
        {
            return Kolor_planszy;
        }

        private void TimerTick(object a, ElapsedEventArgs b)
        {
            Zielona_plansza();
        }
    }
}
