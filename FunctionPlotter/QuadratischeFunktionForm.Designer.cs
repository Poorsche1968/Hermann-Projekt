namespace FunktionZeichnen
{
    partial class QuadratischeFunktionForm
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonZeichne = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonHilfe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(6, 27);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(38, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "f(x)= x²";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(6, 55);
            this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(24, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "+bx";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(6, 88);
            this.labelC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(19, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "+c";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(48, 24);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(76, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(48, 52);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(76, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(48, 85);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(76, 20);
            this.textBoxC.TabIndex = 5;
            // 
            // buttonZeichne
            // 
            this.buttonZeichne.Location = new System.Drawing.Point(20, 124);
            this.buttonZeichne.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZeichne.Name = "buttonZeichne";
            this.buttonZeichne.Size = new System.Drawing.Size(56, 19);
            this.buttonZeichne.TabIndex = 6;
            this.buttonZeichne.Text = "Zeichnen ";
            this.buttonZeichne.UseVisualStyleBackColor = true;
            this.buttonZeichne.Click += new System.EventHandler(this.buttonZeichne_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(483, 15);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(105, 23);
            this.buttonBeenden.TabIndex = 7;
            this.buttonBeenden.Text = "Formular Beenden ";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonHilfe
            // 
            this.buttonHilfe.Location = new System.Drawing.Point(483, 57);
            this.buttonHilfe.Name = "buttonHilfe";
            this.buttonHilfe.Size = new System.Drawing.Size(75, 23);
            this.buttonHilfe.TabIndex = 8;
            this.buttonHilfe.Text = "Hilfe";
            this.buttonHilfe.UseVisualStyleBackColor = true;
            this.buttonHilfe.Click += new System.EventHandler(this.buttonHilfe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bsp.: f (x) = 1x²+bx+c";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ausgabe Funktion:";
            // 
            // QuadratischeFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHilfe);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonZeichne);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuadratischeFunktionForm";
            this.Text = "QuadraticFunctionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button buttonZeichne;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonHilfe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}