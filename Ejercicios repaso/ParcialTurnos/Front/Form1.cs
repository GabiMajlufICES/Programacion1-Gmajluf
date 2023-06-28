using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTurnoPresencial altaTurnoPresencial = new AltaTurnoPresencial();
            altaTurnoPresencial.Show();
            this.Hide();
        }

        private void verListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTurnos verListaTurnos = new ListaTurnos();
            verListaTurnos.Show();
            this.Hide();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaTurnoPresencial bajaTurnos = new BajaTurnoPresencial();
            bajaTurnos.Show();
            this.Hide();
        }
    }
}
