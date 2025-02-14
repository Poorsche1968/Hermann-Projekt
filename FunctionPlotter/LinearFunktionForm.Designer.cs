namespace FunktionZeichnen
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
            this.SuspendLayout();
            // 
            // labelNeigung
            // 
            this.labelNeigung.AutoSize = true;
            this.labelNeigung.Location = new System.Drawing.Point(26, 25);
            this.labelNeigung.Name = "labelNeigung";
            this.labelNeigung.Size = new System.Drawing.Size(80, 16);
            this.labelNeigung.TabIndex = 0;
            this.labelNeigung.Text = "Neigung (m)";
            // 
            // labelAbfangen
            // 
            this.labelAbfangen.AutoSize = true;
            this.labelAbfangen.Location = new System.Drawing.Point(26, 99);
            this.labelAbfangen.Name = "labelAbfangen";
            this.labelAbfangen.Size = new System.Drawing.Size(84, 16);
            this.labelAbfangen.TabIndex = 1;
            this.labelAbfangen.Text = "Abfangen (b)";
            // 
            // textBoxNeigung
            // 
            this.textBoxNeigung.Location = new System.Drawing.Point(139, 25);
            this.textBoxNeigung.Name = "textBoxNeigung";
            this.textBoxNeigung.Size = new System.Drawing.Size(100, 22);
            this.textBoxNeigung.TabIndex = 2;
            // 
            // textBoxAbfangen
            // 
            this.textBoxAbfangen.Location = new System.Drawing.Point(139, 99);
            this.textBoxAbfangen.Name = "textBoxAbfangen";
            this.textBoxAbfangen.Size = new System.Drawing.Size(100, 22);
            this.textBoxAbfangen.TabIndex = 3;
            // 
            // buttonZeichnen
            // 
            this.buttonZeichnen.Location = new System.Drawing.Point(29, 142);
            this.buttonZeichnen.Name = "buttonZeichnen";
            this.buttonZeichnen.Size = new System.Drawing.Size(75, 23);
            this.buttonZeichnen.TabIndex = 4;
            this.buttonZeichnen.Text = "Zeichnen";
            this.buttonZeichnen.UseVisualStyleBackColor = true;
            this.buttonZeichnen.Click += new System.EventHandler(this.buttonZeichnen_Click);
            // 
            // LinearFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZeichnen);
            this.Controls.Add(this.textBoxAbfangen);
            this.Controls.Add(this.textBoxNeigung);
            this.Controls.Add(this.labelAbfangen);
            this.Controls.Add(this.labelNeigung);
            this.Name = "LinearFunktionForm";
            this.Text = "LinearFunktionForm";
            this.Load += new System.EventHandler(this.LinearFunktionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNeigung;
        private System.Windows.Forms.Label labelAbfangen;
        private System.Windows.Forms.TextBox textBoxNeigung;
        private System.Windows.Forms.TextBox textBoxAbfangen;
        private System.Windows.Forms.Button buttonZeichnen;
    }
}