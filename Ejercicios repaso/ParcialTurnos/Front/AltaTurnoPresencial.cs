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
    public partial class AltaTurnoPresencial : Form
    {
        Principal principal = new Principal();
        public AltaTurnoPresencial()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            TurnoPresencial turnoPresencial = new TurnoPresencial();

            turnoPresencial.fecha = dateTimePicker_Fecha.Value;
            turnoPresencial.duracion = int.Parse(textBox_Duracion.Text);
            turnoPresencial.lugar = textBox_Lugar.Text;

            principal.AltaTurnosPresenciales(turnoPresencial.fecha, turnoPresencial.duracion, turnoPresencial.lugar);
            MessageBox.Show("Turno Presencial agregado con exito");

            var lista = principal.MostrarListaTurnos();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
