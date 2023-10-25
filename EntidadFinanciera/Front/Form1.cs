using Back;
namespace Front
{
    public partial class Form1 : Form
    {
        Principal principal = new Principal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {                
                List<CuentaBancaria> listaCuentas = context.CuentasBancarias.ToList();
                dataGridView1.DataSource = listaCuentas; //Le paso la lista de cuentas al data grid.

                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["clienteCB"].Visible = false;
                //No dejo visible en el datagrid el objeto Cliente, se creo una propiedad nombreCliente para mostrar solo esa columna.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comboText = "";//Inicializo variable para que el combo no tome los valores que voy asignando y se mantenga igual.
            if (comboBox1.Text == "Cuenta Corriente") //Valida tipos de cuenta del combo.
            {
                comboText = "CC";
            }
            else if (comboBox1.Text == "Caja Ahorro")
            {
                comboText = "CA";
            }
            else
            {
                comboText = "CS";
            }

            //Llamo al metodo en el messageBox para que retorne los string y agrego a partir del combo y el dni.
            MessageBox.Show(principal.AgregarCuentaBancaria(comboText, int.Parse(textBox1.Text)));
            //Refresco el dataGrid pasandole de nuevo la BD actualizada posterior a la ejecución del metodo.
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.baseDatos.CuentasBancarias.ToList();
            dataGridView1.DataSource = aBind;
        }
    }
}