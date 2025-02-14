namespace FunktionZeichnen
{
    partial class ExponentialFunktionForm
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
            this.labelBasis = new System.Windows.Forms.Label();
            this.textBoxBasis = new System.Windows.Forms.TextBox();
            this.buttonZeichne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBasis
            // 
            this.labelBasis.AutoSize = true;
            this.labelBasis.Location = new System.Drawing.Point(21, 26);
            this.labelBasis.Name = "labelBasis";
            this.labelBasis.Size = new System.Drawing.Size(113, 16);
            this.labelBasis.TabIndex = 1;
            this.labelBasis.Text = "Basis Funktion (a)";
            // 
            // textBoxBasis
            // 
            this.textBoxBasis.Location = new System.Drawing.Point(197, 26);
            this.textBoxBasis.Name = "textBoxBasis";
            this.textBoxBasis.Size = new System.Drawing.Size(162, 22);
            this.textBoxBasis.TabIndex = 2;
            // 
            // buttonZeichne
            // 
            this.buttonZeichne.Location = new System.Drawing.Point(13, 72);
            this.buttonZeichne.Name = "buttonZeichne";
            this.buttonZeichne.Size = new System.Drawing.Size(75, 23);
            this.buttonZeichne.TabIndex = 3;
            this.buttonZeichne.Text = "Zeichnen";
            this.buttonZeichne.UseVisualStyleBackColor = true;
            this.buttonZeichne.Click += new System.EventHandler(this.buttonZeichne_Click);
            // 
            // ExponentialFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZeichne);
            this.Controls.Add(this.textBoxBasis);
            this.Controls.Add(this.labelBasis);
            this.Name = "ExponentialFunktionForm";
            this.Text = "ExponentialFunktionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBasis;
        private System.Windows.Forms.TextBox textBoxBasis;
        private System.Windows.Forms.Button buttonZeichne;
    }
}