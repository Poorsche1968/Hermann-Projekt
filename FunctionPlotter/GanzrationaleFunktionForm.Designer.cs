namespace FunktionZeichnen
{
    partial class GanzrationaleFunktionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKoeffizienten = new System.Windows.Forms.Label();
            this.buttonZeichnen = new System.Windows.Forms.Button();
            this.textBoxKoeffizienten = new System.Windows.Forms.TextBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonHilfe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKoeffizienten
            // 
            this.labelKoeffizienten.AutoSize = true;
            this.labelKoeffizienten.Location = new System.Drawing.Point(9, 24);
            this.labelKoeffizienten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKoeffizienten.Name = "labelKoeffizienten";
            this.labelKoeffizienten.Size = new System.Drawing.Size(184, 13);
            this.labelKoeffizienten.TabIndex = 0;
            this.labelKoeffizienten.Text = "Koeffizienten (durch Komma getrennt)";
            // 
            // buttonZeichnen
            // 
            this.buttonZeichnen.Location = new System.Drawing.Point(11, 67);
            this.buttonZeichnen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZeichnen.Name = "buttonZeichnen";
            this.buttonZeichnen.Size = new System.Drawing.Size(56, 19);
            this.buttonZeichnen.TabIndex = 1;
            this.buttonZeichnen.Text = "Zeichnen";
            this.buttonZeichnen.UseVisualStyleBackColor = true;
            this.buttonZeichnen.Click += new System.EventHandler(this.buttonZeichnen_Click);
            // 
            // textBoxKoeffizienten
            // 
            this.textBoxKoeffizienten.Location = new System.Drawing.Point(225, 21);
            this.textBoxKoeffizienten.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKoeffizienten.Name = "textBoxKoeffizienten";
            this.textBoxKoeffizienten.Size = new System.Drawing.Size(106, 20);
            this.textBoxKoeffizienten.TabIndex = 2;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(470, 24);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(118, 23);
            this.buttonBeenden.TabIndex = 3;
            this.buttonBeenden.Text = "Formular Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHilfe
            // 
            this.buttonHilfe.Location = new System.Drawing.Point(470, 67);
            this.buttonHilfe.Name = "buttonHilfe";
            this.buttonHilfe.Size = new System.Drawing.Size(75, 23);
            this.buttonHilfe.TabIndex = 4;
            this.buttonHilfe.Text = "Hilfe";
            this.buttonHilfe.UseVisualStyleBackColor = true;
            this.buttonHilfe.Click += new System.EventHandler(this.buttonHilfe_Click);
            // 
            // GanzrationaleFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonHilfe);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.textBoxKoeffizienten);
            this.Controls.Add(this.buttonZeichnen);
            this.Controls.Add(this.labelKoeffizienten);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GanzrationaleFunktionForm";
            this.Text = "Ganzrationale Funktion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKoeffizienten;
        private System.Windows.Forms.Button buttonZeichnen;
        private System.Windows.Forms.TextBox textBoxKoeffizienten;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonHilfe;
    }
}