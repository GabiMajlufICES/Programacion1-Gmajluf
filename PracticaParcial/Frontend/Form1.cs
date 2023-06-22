using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Form1 : Form
    {
        private AltaCliente frmAltaCliente;
        private FrmListaClientes frmListaClientes;
        public Form1()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAltaCliente == null || frmAltaCliente.IsDisposed)
            {
                frmAltaCliente = new AltaCliente();
            }            
            frmAltaCliente.ShowDialog();
            this.Hide();
            //frmListaClientes.ActualizarLista();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frmListaClientes == null || frmListaClientes.IsDisposed)
            {
                frmListaClientes = new FrmListaClientes();
            }

            frmListaClientes.ShowDialog();
            this.Hide();
        }
    }
}
