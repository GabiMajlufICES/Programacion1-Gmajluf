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

namespace Vista_Front
{
    public partial class frmProductoAlimenticio : Form
    {
        Principal principal = new Principal();
        public frmProductoAlimenticio()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ProductoAlimenticio productoAlimenticio = new ProductoAlimenticio();
            productoAlimenticio.codigo = int.Parse(textBox_cod.Text);
            productoAlimenticio.nombre= textBox_nombre.Text;
            productoAlimenticio.precio = decimal.Parse(textBox_precio.Text);

            principal.AltaProductoAlimenticio(productoAlimenticio);
            listBox1.DataSource = null;
            listBox1.DataSource = principal.ListaProductos;
            MessageBox.Show("Producto agregado con exito");

            textBox_cod.Clear();
            textBox_nombre.Clear();
            textBox_precio.Clear();
                
        }
    }
}
