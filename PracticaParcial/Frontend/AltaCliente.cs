using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Frontend
{
    public partial class AltaCliente : Form
    {
        
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            Cliente clienteNuevo = new Cliente();
            clienteNuevo.dni = int.Parse(textBox_Dni.ToString());
            clienteNuevo.nombre = textBox_Nombre.ToString();
            clienteNuevo.apellido = textBox_Apellido.ToString();
            principal.AgregarCliente(clienteNuevo);
        }
    }
}
