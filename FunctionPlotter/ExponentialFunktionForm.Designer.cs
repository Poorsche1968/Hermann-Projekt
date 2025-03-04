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
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonHilfe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBasis
            // 
            this.labelBasis.AutoSize = true;
            this.labelBasis.Location = new System.Drawing.Point(16, 21);
            this.labelBasis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBasis.Name = "labelBasis";
            this.labelBasis.Size = new System.Drawing.Size(50, 13);
            this.labelBasis.TabIndex = 1;
            this.labelBasis.Text = "f(x) = a^x";
            // 
            // textBoxBasis
            // 
            this.textBoxBasis.Location = new System.Drawing.Point(92, 21);
            this.textBoxBasis.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBasis.Name = "textBoxBasis";
            this.textBoxBasis.Size = new System.Drawing.Size(81, 20);
            this.textBoxBasis.TabIndex = 2;
            // 
            // buttonZeichne
            // 
            this.buttonZeichne.Location = new System.Drawing.Point(10, 58);
            this.buttonZeichne.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZeichne.Name = "buttonZeichne";
            this.buttonZeichne.Size = new System.Drawing.Size(56, 19);
            this.buttonZeichne.TabIndex = 3;
            this.buttonZeichne.Text = "Zeichnen";
            this.buttonZeichne.UseVisualStyleBackColor = true;
            this.buttonZeichne.Click += new System.EventHandler(this.buttonZeichne_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(486, 16);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(102, 23);
            this.buttonBeenden.TabIndex = 4;
            this.buttonBeenden.Text = "Formular Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonHilfe
            // 
            this.buttonHilfe.Location = new System.Drawing.Point(486, 54);
            this.buttonHilfe.Name = "buttonHilfe";
            this.buttonHilfe.Size = new System.Drawing.Size(75, 23);
            this.buttonHilfe.TabIndex = 5;
            this.buttonHilfe.Text = "Hilfe";
            this.buttonHilfe.UseVisualStyleBackColor = true;
            this.buttonHilfe.Click += new System.EventHandler(this.buttonHilfe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ExponentialFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHilfe);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonZeichne);
            this.Controls.Add(this.textBoxBasis);
            this.Controls.Add(this.labelBasis);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExponentialFunktionForm";
            this.Text = "ExponentialFunktionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBasis;
        private System.Windows.Forms.TextBox textBoxBasis;
        private System.Windows.Forms.Button buttonZeichne;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonHilfe;
        private System.Windows.Forms.Label label1;
    }
}