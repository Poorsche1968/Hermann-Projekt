namespace FunktionZeichnen
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funktionsFormulareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineareFktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qudratischeFktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponentialeFktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganzrationaleFktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem,
            this.funktionsFormulareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.beendenToolStripMenuItem.Text = "beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // funktionsFormulareToolStripMenuItem
            // 
            this.funktionsFormulareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineareFktToolStripMenuItem,
            this.qudratischeFktToolStripMenuItem,
            this.exponentialeFktToolStripMenuItem,
            this.ganzrationaleFktToolStripMenuItem});
            this.funktionsFormulareToolStripMenuItem.Name = "funktionsFormulareToolStripMenuItem";
            this.funktionsFormulareToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.funktionsFormulareToolStripMenuItem.Text = "Funktions Formulare";
            // 
            // lineareFktToolStripMenuItem
            // 
            this.lineareFktToolStripMenuItem.Name = "lineareFktToolStripMenuItem";
            this.lineareFktToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lineareFktToolStripMenuItem.Text = "Lineare Fkt.";
            this.lineareFktToolStripMenuItem.Click += new System.EventHandler(this.lineareFktToolStripMenuItem_Click);
            // 
            // qudratischeFktToolStripMenuItem
            // 
            this.qudratischeFktToolStripMenuItem.Name = "qudratischeFktToolStripMenuItem";
            this.qudratischeFktToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qudratischeFktToolStripMenuItem.Text = "Quadratische Fkt.";
            this.qudratischeFktToolStripMenuItem.Click += new System.EventHandler(this.qudratischeFktToolStripMenuItem_Click);
            // 
            // exponentialeFktToolStripMenuItem
            // 
            this.exponentialeFktToolStripMenuItem.Name = "exponentialeFktToolStripMenuItem";
            this.exponentialeFktToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exponentialeFktToolStripMenuItem.Text = "Exponentiale Fkt.";
            this.exponentialeFktToolStripMenuItem.Click += new System.EventHandler(this.exponentialeFktToolStripMenuItem_Click);
            // 
            // ganzrationaleFktToolStripMenuItem
            // 
            this.ganzrationaleFktToolStripMenuItem.Name = "ganzrationaleFktToolStripMenuItem";
            this.ganzrationaleFktToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ganzrationaleFktToolStripMenuItem.Text = "Ganzrationale Fkt.";
            this.ganzrationaleFktToolStripMenuItem.Click += new System.EventHandler(this.ganzrationaleFktToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funktionsFormulareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineareFktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qudratischeFktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponentialeFktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganzrationaleFktToolStripMenuItem;
    }
}

