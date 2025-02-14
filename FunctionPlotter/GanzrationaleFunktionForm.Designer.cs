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
            this.SuspendLayout();
            // 
            // labelKoeffizienten
            // 
            this.labelKoeffizienten.AutoSize = true;
            this.labelKoeffizienten.Location = new System.Drawing.Point(12, 29);
            this.labelKoeffizienten.Name = "labelKoeffizienten";
            this.labelKoeffizienten.Size = new System.Drawing.Size(226, 16);
            this.labelKoeffizienten.TabIndex = 0;
            this.labelKoeffizienten.Text = "Koeffizienten (durch Komma getrennt)";
            // 
            // buttonZeichnen
            // 
            this.buttonZeichnen.Location = new System.Drawing.Point(15, 82);
            this.buttonZeichnen.Name = "buttonZeichnen";
            this.buttonZeichnen.Size = new System.Drawing.Size(75, 23);
            this.buttonZeichnen.TabIndex = 1;
            this.buttonZeichnen.Text = "Zeichnen";
            this.buttonZeichnen.UseVisualStyleBackColor = true;
            this.buttonZeichnen.Click += new System.EventHandler(this.buttonZeichnen_Click);
            // 
            // textBoxKoeffizienten
            // 
            this.textBoxKoeffizienten.Location = new System.Drawing.Point(300, 26);
            this.textBoxKoeffizienten.Name = "textBoxKoeffizienten";
            this.textBoxKoeffizienten.Size = new System.Drawing.Size(140, 22);
            this.textBoxKoeffizienten.TabIndex = 2;
            // 
            // GanzrationaleFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxKoeffizienten);
            this.Controls.Add(this.buttonZeichnen);
            this.Controls.Add(this.labelKoeffizienten);
            this.Name = "GanzrationaleFunktionForm";
            this.Text = "Ganzrationale Funktion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKoeffizienten;
        private System.Windows.Forms.Button buttonZeichnen;
        private System.Windows.Forms.TextBox textBoxKoeffizienten;
    }
}