using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public List<Producto> ListaProductos = new List<Producto>();    

        public void AltaProductoElectronico(ProductoElectronico productoElectronico)
        {
            ListaProductos.Add(productoElectronico);
        }

        public void AltaProductoAlimenticio(ProductoAlimenticio productoAlimenticio)
        {
            ListaProductos.Add(productoAlimenticio);
        }

        public void BajaProductoElectronico(ProductoElectronico productoElectronico) 
        {
            ListaProductos.Remove(productoElectronico);
        }
        public void BajaProductoAlimenticio(ProductoAlimenticio productoAlimenticio)
        {
            ListaProductos.Remove(productoAlimenticio);
        }
        public void ModificarProductoElectronico(ProductoElectronico productoElectronico, ProductoElectronico itemEliminar )
        {
            ListaProductos.Add(productoElectronico);
            ListaProductos.Remove(itemEliminar);
        }
        public void ModificarProductoAlimenticio(ProductoAlimenticio productoAlimenticio, ProductoAlimenticio itemEliminar)
        {
            ListaProductos.Add(productoAlimenticio);
            ListaProductos.Remove(itemEliminar);
        }

        public void ModificarProductoAlimenticio2daManera(ProductoAlimenticio productoAlimenticioNuevo, ProductoAlimenticio itemEliminar)
        {
            ProductoAlimenticio productoAlimenticio = new ProductoAlimenticio();
            productoAlimenticio.codigo = itemEliminar.codigo;
            productoAlimenticio.nombre = productoAlimenticioNuevo.nombre;
            productoAlimenticio.precio = productoAlimenticioNuevo.precio;
            productoAlimenticio.fechaVencimiento = itemEliminar.fechaVencimiento;
            productoAlimenticio.cantidad= itemEliminar.cantidad;

            ListaProductos.Add(productoAlimenticio);
            ListaProductos.Remove(itemEliminar);
        }

    }
}
