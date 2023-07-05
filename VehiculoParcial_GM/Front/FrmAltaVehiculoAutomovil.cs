using Back;
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
    public partial class FrmAltaVehiculoAutomovil : Form
    {
        Principal principal = new Principal();
        public FrmAltaVehiculoAutomovil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehiculoAutomovil vehiculoAutomovil = new VehiculoAutomovil();

            vehiculoAutomovil.patente = textPatente.Text;
            vehiculoAutomovil.marca = textMarca.Text;
            vehiculoAutomovil.modelo = textModelo.Text;
            vehiculoAutomovil.precioXDia = decimal.Parse(textPrecio.Text);
            vehiculoAutomovil.nroPuertas = int.Parse(textNroPuertas.Text);
            vehiculoAutomovil.nroAsientos = int.Parse(textNroAsientos.Text);

            principal.AltaVehiculoAutomovil(vehiculoAutomovil);
            MessageBox.Show("Vehiculo Automovil guardado con exito.");

            textPatente.Clear();
            textMarca.Clear();
            textModelo.Clear();
            textPrecio.Clear();
            textNroPuertas.Clear();
            textNroAsientos.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
