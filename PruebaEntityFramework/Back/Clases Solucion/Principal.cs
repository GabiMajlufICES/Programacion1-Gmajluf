using Back.ConexionBD;
using System.Runtime.InteropServices;
using System.Text;

namespace Back
{
    public class Principal
    {
        //Creo una unica instancia en Principal de la BD.
        ApplicationDbContext context = new ApplicationDbContext(); 
        public void AgregarProducto(Producto productoNuevo)
        {
            context.Productos.Add(productoNuevo);
            context.SaveChanges();
        }

        public string ConsultarProductos()
        {
            List<Producto> Listaproductos = context.Productos.ToList();

            if (Listaproductos.Count > 0)
            {
                StringBuilder resultado = new StringBuilder();

                foreach (var unProducto in Listaproductos)
                {
                    resultado.AppendLine($"El producto: {unProducto.nombre} cuesta: {unProducto.precio}"); 
                    //Se usa el AppendLine solamente porque lo vamos a mostrar en un unico MessageBox.
                    //Cada vuelta del foreach agrega una linea al mismo string de la vuelta pasada.
                }
                return resultado.ToString(); //Era un constructor de String y lo convierto al tipo de datos que pide el metodo.
            }
            else
            {
                return "No hay ningún producto registrado";
            }
        }

        public void EliminarProducto(int id)
        {
            var productoEncontrado = context.Productos.Find(id);
            if (productoEncontrado != null)
            {
                context.Productos.Remove(productoEncontrado);
                context.SaveChanges();
            }           
        }

        public void ModificarProducto(Producto productoModificado)
        {
            var productoEncontrado = context.Productos.Find(productoModificado.id);
            if (productoEncontrado != null)
            {
                productoEncontrado.precio = productoModificado.precio;
                context.SaveChanges();
            }
        }

        public bool BuscarProducto(int id)
        {
            var productoEncontrado = context.Productos.Find(id);
            if (productoEncontrado != null)
            {
                return true; //Encontre el id
            }
            else 
            { 
                return false; //No encontre el id
            }
        }


    }
}