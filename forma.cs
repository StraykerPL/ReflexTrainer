/*
	Copyright (c) 2018-2019 Daniel Strayker Nowak
	All rights reserved
*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Reflex_Trainer
{
    public partial class forma : Form
    {
        public Trainer trainer;

        public forma()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(label1);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zapiszWynikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Wybierz folder, gdzie zapisać wynik:";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.ShowDialog();

            try
            {
                var zapis = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\Wynik.txt");
                zapis.WriteLine("Twój wynik: {0}ms !", trainer.Jaki_najlepszy_czas().Milliseconds);
                zapis.WriteLine("Wynik osiągnięty w programie Reflex Trainer!");
                zapis.WriteLine("http://www.strayker.cba.pl");
                zapis.Dispose();
            }
            catch (Exception a)
            {
                MessageBox.Show("Nie można zapisać wyniku: " + a.Message, "Reflex Trainer", MessageBoxButtons.OK);
            }

            MessageBox.Show("Wynik zapisany pomyślnie!", "Reflex Trainer", MessageBoxButtons.OK);
        }

        private void zatrzymajTreningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trainer.Zakończ_odliczanie();
            trainer.Czerwona_plansza();
            label1.Visible = false;
            Dostepnosc_menu(true);
        }

        private void rozpocznijTreningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dostepnosc_menu(false);
            label1.Visible = false;
            trainer = new Trainer(pictureBox1);
            trainer.Czerwona_plansza();
            pictureBox1.Click += new EventHandler(Obrazek_klikniety);
            trainer.Rozpocznij_odliczanie();
        }

        private void dokumentacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.strayker.cba.pl/docs");
        }

        private void Obrazek_klikniety(object sender, EventArgs e)
        {
            if(trainer.Jaki_kolor_planszy() == Color.Green)
            {
                trainer.Zakończ_odliczanie();
                var czas = trainer.Jaki_najlepszy_czas();
                label1.Text = string.Concat("Twój czas reakcji: " + czas.Milliseconds + " ms!");
                label1.Visible = true;
                Dostepnosc_menu(true);
            }
            else
            {
                trainer.Zakończ_odliczanie();
                label1.Text = "Za szybko!";
                label1.Visible = true;
                Dostepnosc_menu(true);
            }
        }

        private void forma_SizeChanged(object sender, EventArgs e)
        {
            label1.Location = new Point(Convert.ToInt32(Width * 0.5), Convert.ToInt32(Height * 0.5));
            label1.Refresh();
        }

        public void Dostepnosc_menu(bool var)
        {
            ToolStripItem[] ity1 = menuStrip1.Items.Find("Rozpocznij_trening", true);
            ToolStripItem[] ity3 = menuStrip1.Items.Find("Zapisz_wynik", true);
            ToolStripItem[] ity = { ity1[0], ity3[0] };
            foreach (ToolStripItem a in ity)
            {
                a.Enabled = var;
            }
        }
    }
}
