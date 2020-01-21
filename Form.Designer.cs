namespace Reflex_Trainer
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TrainingElement = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTrainingElement = new System.Windows.Forms.ToolStripMenuItem();
            this.StopTrainingElement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveScoreElement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitElement = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpElement = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsElement = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAppElement = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaBox = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaBox)).BeginInit();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrainingElement,
            this.HelpElement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrainingElement
            // 
            this.TrainingElement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartTrainingElement,
            this.StopTrainingElement,
            this.toolStripSeparator1,
            this.SaveScoreElement,
            this.toolStripSeparator2,
            this.ExitElement});
            this.TrainingElement.Name = "TrainingElement";
            this.TrainingElement.Size = new System.Drawing.Size(61, 20);
            this.TrainingElement.Text = "Training";
            // 
            // StartTrainingElement
            // 
            this.StartTrainingElement.Name = "StartTrainingElement";
            this.StartTrainingElement.Size = new System.Drawing.Size(143, 22);
            this.StartTrainingElement.Text = "Start Training";
            this.StartTrainingElement.Click += new System.EventHandler(this.StartTrainingElement_Click);
            // 
            // StopTrainingElement
            // 
            this.StopTrainingElement.Enabled = false;
            this.StopTrainingElement.Name = "StopTrainingElement";
            this.StopTrainingElement.Size = new System.Drawing.Size(143, 22);
            this.StopTrainingElement.Text = "Stop Training";
            this.StopTrainingElement.Click += new System.EventHandler(this.StopTrainingElement_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // SaveScoreElement
            // 
            this.SaveScoreElement.Name = "SaveScoreElement";
            this.SaveScoreElement.Size = new System.Drawing.Size(143, 22);
            this.SaveScoreElement.Text = "Save Score";
            this.SaveScoreElement.Click += new System.EventHandler(this.SaveScoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // ExitElement
            // 
            this.ExitElement.Name = "ExitElement";
            this.ExitElement.Size = new System.Drawing.Size(143, 22);
            this.ExitElement.Text = "Exit";
            this.ExitElement.Click += new System.EventHandler(this.ExitElement_Click);
            // 
            // HelpElement
            // 
            this.HelpElement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocsElement,
            this.AboutAppElement});
            this.HelpElement.Name = "HelpElement";
            this.HelpElement.Size = new System.Drawing.Size(44, 20);
            this.HelpElement.Text = "Help";
            // 
            // DocsElement
            // 
            this.DocsElement.Name = "DocsElement";
            this.DocsElement.Size = new System.Drawing.Size(157, 22);
            this.DocsElement.Text = "Documentation";
            this.DocsElement.Click += new System.EventHandler(this.DocsElement_Click);
            // 
            // AboutAppElement
            // 
            this.AboutAppElement.Name = "AboutAppElement";
            this.AboutAppElement.Size = new System.Drawing.Size(157, 22);
            this.AboutAppElement.Text = "About App";
            this.AboutAppElement.Click += new System.EventHandler(this.AboutAppElement_Click);
            // 
            // AreaBox
            // 
            this.AreaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaBox.BackColor = System.Drawing.Color.Red;
            this.AreaBox.Location = new System.Drawing.Point(12, 30);
            this.AreaBox.Name = "AreaBox";
            this.AreaBox.Size = new System.Drawing.Size(776, 411);
            this.AreaBox.TabIndex = 1;
            this.AreaBox.TabStop = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StatusLabel.Location = new System.Drawing.Point(3, 24);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(140, 30);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Welcome to Reflex Trainer!\r\nClick here to start training!\r\n";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusPanel.Controls.Add(this.StatusLabel);
            this.StatusPanel.Location = new System.Drawing.Point(327, 188);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(146, 75);
            this.StatusPanel.TabIndex = 3;
            this.StatusPanel.Click += new System.EventHandler(this.StatusPanel_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.AreaBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reflex Trainer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaBox)).EndInit();
            this.StatusPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem TrainingElement;
        private System.Windows.Forms.ToolStripMenuItem StartTrainingElement;
        private System.Windows.Forms.ToolStripMenuItem StopTrainingElement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveScoreElement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitElement;
        private System.Windows.Forms.ToolStripMenuItem HelpElement;
        private System.Windows.Forms.ToolStripMenuItem DocsElement;
        private System.Windows.Forms.Label StatusLabel;
        public System.Windows.Forms.PictureBox AreaBox;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem AboutAppElement;
        private System.Windows.Forms.Panel StatusPanel;
    }
}

