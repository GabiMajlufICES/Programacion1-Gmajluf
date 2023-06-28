using Logica.Clases;
using Logica;
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
    public partial class BajaTurnoPresencial : Form
    {
        Principal principal = new Principal();
        public BajaTurnoPresencial()
        {
            InitializeComponent();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            TurnoPresencial turnoPresencialEliminado = new TurnoPresencial();

            turnoPresencialEliminado.id = int.Parse(textBox_Id.Text);        

            principal.BajaTurnoPresencial(turnoPresencialEliminado.id);
            MessageBox.Show("Turno Presencial eliminado con exito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnoPresencial turnoPresencialModificado = new TurnoPresencial();

            turnoPresencialModificado.id = int.Parse(textBox_Id.Text);
            turnoPresencialModificado.lugar = "Rafaela";

            principal.ModificarTurnoPresencial(turnoPresencialModificado.id, turnoPresencialModificado.lugar);
            MessageBox.Show("Turno Presencial modificado con exito");
        }
    }
}
