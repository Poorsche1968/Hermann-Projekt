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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKoeffizienten
            // 
            this.labelKoeffizienten.AutoSize = true;
            this.labelKoeffizienten.Location = new System.Drawing.Point(8, 9);
            this.labelKoeffizienten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKoeffizienten.Name = "labelKoeffizienten";
            this.labelKoeffizienten.Size = new System.Drawing.Size(135, 13);
            this.labelKoeffizienten.TabIndex = 0;
            this.labelKoeffizienten.Text = "Bsp.: Fkt.f(x)=2x³−4x²+3x+5";
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
            this.textBoxKoeffizienten.Location = new System.Drawing.Point(191, 6);
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
            this.buttonHilfe.Location = new System.Drawing.Point(389, 24);
            this.buttonHilfe.Name = "buttonHilfe";
            this.buttonHilfe.Size = new System.Drawing.Size(75, 23);
            this.buttonHilfe.TabIndex = 4;
            this.buttonHilfe.Text = "Hilfe";
            this.buttonHilfe.UseVisualStyleBackColor = true;
            this.buttonHilfe.Click += new System.EventHandler(this.buttonHilfe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "BITTE GEBEN SIE NUMMERISCH WERTE \r\nUND TRENNEN SIE MIT KOMMAS TRENNEN";
            // 
            // GanzrationaleFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}