using Logica;
using Logica.Clases;
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
    public partial class ListaTurnos : Form
    {
        Principal principal = new Principal();
        public ListaTurnos()
        {
            InitializeComponent();
        }

        private void ListaTurnos_Load(object sender, EventArgs e)
        {
            TurnoPresencial turnoPresencial = new TurnoPresencial();
            turnoPresencial.fecha = DateTime.Now;
            turnoPresencial.duracion= 30;
            turnoPresencial.lugar = "Sunchales";
            principal.AltaTurnosPresenciales(turnoPresencial.fecha, turnoPresencial.duracion,turnoPresencial.lugar);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.ListaTurnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
