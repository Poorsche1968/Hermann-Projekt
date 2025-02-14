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
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(24, 25);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(16, 16);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(24, 70);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(16, 16);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(24, 111);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(16, 16);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(64, 25);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(64, 64);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(64, 105);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 5;
            // 
            // buttonZeichne
            // 
            this.buttonZeichne.Location = new System.Drawing.Point(27, 152);
            this.buttonZeichne.Name = "buttonZeichne";
            this.buttonZeichne.Size = new System.Drawing.Size(75, 23);
            this.buttonZeichne.TabIndex = 6;
            this.buttonZeichne.Text = "Zeichnen ";
            this.buttonZeichne.UseVisualStyleBackColor = true;
            this.buttonZeichne.Click += new System.EventHandler(this.buttonZeichne_Click);
            // 
            // QuadratischeFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZeichne);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
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
    }
}