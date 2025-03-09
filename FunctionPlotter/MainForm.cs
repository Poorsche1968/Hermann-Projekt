using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); //Startet das Formular
        }
        #region Formulare anzeigen und beenden 
        private void lineareFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LinearFunktionForm();
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;

        }

        private void qudratischeFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuadratischeFunktionForm();
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
        }

        private void exponentialeFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ExponentialFunktionForm();
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
        }

        private void ganzrationaleFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GanzrationaleFunktionForm();
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
#endregion
