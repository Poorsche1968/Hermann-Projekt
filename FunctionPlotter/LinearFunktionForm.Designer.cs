﻿namespace FunktionZeichnen
{
    partial class LinearFunktionForm
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
            this.labelNeigung = new System.Windows.Forms.Label();
            this.labelAbfangen = new System.Windows.Forms.Label();
            this.textBoxNeigung = new System.Windows.Forms.TextBox();
            this.textBoxAbfangen = new System.Windows.Forms.TextBox();
            this.buttonZeichnen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonHilfe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNeigung
            // 
            this.labelNeigung.AutoSize = true;
            this.labelNeigung.Location = new System.Drawing.Point(64, 30);
            this.labelNeigung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNeigung.Name = "labelNeigung";
            this.labelNeigung.Size = new System.Drawing.Size(66, 13);
            this.labelNeigung.TabIndex = 0;
            this.labelNeigung.Text = "Steigung (m)";
            // 
            // labelAbfangen
            // 
            this.labelAbfangen.AutoSize = true;
            this.labelAbfangen.Location = new System.Drawing.Point(19, 78);
            this.labelAbfangen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAbfangen.Name = "labelAbfangen";
            this.labelAbfangen.Size = new System.Drawing.Size(111, 13);
            this.labelAbfangen.TabIndex = 1;
            this.labelAbfangen.Text = "Y-Achsenabschnitt (b)";
            // 
            // textBoxNeigung
            // 
            this.textBoxNeigung.Location = new System.Drawing.Point(134, 27);
            this.textBoxNeigung.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNeigung.Name = "textBoxNeigung";
            this.textBoxNeigung.Size = new System.Drawing.Size(76, 20);
            this.textBoxNeigung.TabIndex = 2;
            // 
            // textBoxAbfangen
            // 
            this.textBoxAbfangen.Location = new System.Drawing.Point(134, 75);
            this.textBoxAbfangen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAbfangen.Name = "textBoxAbfangen";
            this.textBoxAbfangen.Size = new System.Drawing.Size(76, 20);
            this.textBoxAbfangen.TabIndex = 3;
            // 
            // buttonZeichnen
            // 
            this.buttonZeichnen.Location = new System.Drawing.Point(22, 118);
            this.buttonZeichnen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZeichnen.Name = "buttonZeichnen";
            this.buttonZeichnen.Size = new System.Drawing.Size(56, 19);
            this.buttonZeichnen.TabIndex = 4;
            this.buttonZeichnen.Text = "Zeichnen";
            this.buttonZeichnen.UseVisualStyleBackColor = true;
            this.buttonZeichnen.Click += new System.EventHandler(this.buttonZeichnen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(480, 17);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(108, 23);
            this.buttonBeenden.TabIndex = 5;
            this.buttonBeenden.Text = "Formular Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonHilfe
            // 
            this.buttonHilfe.Location = new System.Drawing.Point(513, 78);
            this.buttonHilfe.Name = "buttonHilfe";
            this.buttonHilfe.Size = new System.Drawing.Size(75, 23);
            this.buttonHilfe.TabIndex = 6;
            this.buttonHilfe.Text = "Hilfe";
            this.buttonHilfe.UseVisualStyleBackColor = true;
            this.buttonHilfe.Click += new System.EventHandler(this.buttonHilfe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ausgabe Funktion:";
            // 
            // LinearFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHilfe);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonZeichnen);
            this.Controls.Add(this.textBoxAbfangen);
            this.Controls.Add(this.textBoxNeigung);
            this.Controls.Add(this.labelAbfangen);
            this.Controls.Add(this.labelNeigung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LinearFunktionForm";
            this.Text = "LinearFunktionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNeigung;
        private System.Windows.Forms.Label labelAbfangen;
        private System.Windows.Forms.TextBox textBoxNeigung;
        private System.Windows.Forms.TextBox textBoxAbfangen;
        private System.Windows.Forms.Button buttonZeichnen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonHilfe;
        private System.Windows.Forms.Label label1;
    }
}