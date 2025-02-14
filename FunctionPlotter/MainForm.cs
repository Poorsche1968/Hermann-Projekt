using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void lineareFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LinearFunktionForm();
            WindowState = FormWindowState.Maximized;
            form.Show();
            
        }

        private void qudratischeFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuadratischeFunktionForm();
            form.Show();
        }

        private void exponentialeFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ExponentialFunktionForm();
            form.Show();
        }

        private void ganzrationaleFktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GanzrationaleFunktionForm();
            form.Show();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}