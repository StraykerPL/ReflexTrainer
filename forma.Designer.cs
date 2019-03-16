namespace Reflex_Trainer
{
    partial class forma
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rozpocznij_trening = new System.Windows.Forms.ToolStripMenuItem();
            this.Zatrzymaj_trening = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Zapisz_wynik = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rozpocznij_trening,
            this.Zatrzymaj_trening,
            this.toolStripSeparator1,
            this.Zapisz_wynik,
            this.toolStripSeparator2,
            this.zakończToolStripMenuItem});
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // Rozpocznij_trening
            // 
            this.Rozpocznij_trening.Name = "Rozpocznij_trening";
            this.Rozpocznij_trening.Size = new System.Drawing.Size(172, 22);
            this.Rozpocznij_trening.Text = "Rozpocznij trening";
            this.Rozpocznij_trening.Click += new System.EventHandler(this.rozpocznijTreningToolStripMenuItem_Click);
            // 
            // Zatrzymaj_trening
            // 
            this.Zatrzymaj_trening.Name = "Zatrzymaj_trening";
            this.Zatrzymaj_trening.Size = new System.Drawing.Size(172, 22);
            this.Zatrzymaj_trening.Text = "Zatrzymaj trening";
            this.Zatrzymaj_trening.Click += new System.EventHandler(this.zatrzymajTreningToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // Zapisz_wynik
            // 
            this.Zapisz_wynik.Name = "Zapisz_wynik";
            this.Zapisz_wynik.Size = new System.Drawing.Size(172, 22);
            this.Zapisz_wynik.Text = "Zapisz wynik";
            this.Zapisz_wynik.Click += new System.EventHandler(this.zapiszWynikToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentacjaToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // dokumentacjaToolStripMenuItem
            // 
            this.dokumentacjaToolStripMenuItem.Name = "dokumentacjaToolStripMenuItem";
            this.dokumentacjaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dokumentacjaToolStripMenuItem.Text = "Dokumentacja";
            this.dokumentacjaToolStripMenuItem.Click += new System.EventHandler(this.dokumentacjaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 411);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reflex Trainer";
            this.SizeChanged += new System.EventHandler(this.forma_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rozpocznij_trening;
        private System.Windows.Forms.ToolStripMenuItem Zatrzymaj_trening;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Zapisz_wynik;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentacjaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

