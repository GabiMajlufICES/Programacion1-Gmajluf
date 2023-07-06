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
    public partial class FrmAltaVehiculoCamioneta : Form
    {
        Principal principal = new Principal();
        public FrmAltaVehiculoCamioneta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehiculoCamioneta vehiculoCamioneta = new VehiculoCamioneta();

            vehiculoCamioneta.patente = textPatente.Text;
            vehiculoCamioneta.marca = textMarca.Text;
            vehiculoCamioneta.modelo = textModelo.Text;
            vehiculoCamioneta.precioXDia = decimal.Parse(textPrecio.Text);
            vehiculoCamioneta.cantidadCarga = int.Parse(textCantCarga.Text);

            principal.AltaVehiculoCamioneta(vehiculoCamioneta);
            listBox1.DataSource = null;
            listBox1.DisplayMember= "VC";
            listBox1.DataSource = principal.ListaVehiculoCamioneta;
            
            MessageBox.Show("Vehiculo Camioneta guardado con exito.");

            textPatente.Clear();
            textMarca.Clear();
            textModelo.Clear();
            textPrecio.Clear();
            textCantCarga.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
