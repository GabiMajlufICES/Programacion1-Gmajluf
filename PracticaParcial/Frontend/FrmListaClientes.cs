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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();           
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            Cliente cliente = new Cliente();
            cliente.dni = 41288872;
            cliente.nombre = "Gabriel";
            cliente.apellido = "Majluf";

            principal.AgregarCliente(cliente);
            
            dataGridView1.DataSource = null;
            List<Cliente> listaClientesForm = principal.ListaClientes;
            dataGridView1.DataSource = listaClientesForm;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Dni", "Dni");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");

            dataGridView1.Columns["Dni"].DataPropertyName = "dni";
            dataGridView1.Columns["Nombre"].DataPropertyName = "nombre";
            dataGridView1.Columns["Apellido"].DataPropertyName = "apellido";
        }
    }
}
