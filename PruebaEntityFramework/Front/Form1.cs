using Back;
using Back.ConexionBD;

namespace Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agrego uno de prueoba
            Producto productoNuevo = new Producto();
            productoNuevo.nombre = "Destornillador";
            productoNuevo.precio = 15000;

            Principal principal = new Principal();
            principal.AgregarProducto(productoNuevo);

            MessageBox.Show("Se agrego " + productoNuevo.nombre);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            
            MessageBox.Show(principal.ConsultarProductos());
        }
    }
}