using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Logica.Ejercicio2;
using Logica.Ejercicio3;
using Logica.Ejercicio4;
using Logica.Ejercicio5;
using Logica.EjercicioOpcional;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1
            List<Animal> animales = new List<Animal>();
            animales.Add(new Perro());
            animales.Add(new Gato());
            animales.Add(new Vaca());

            foreach (Animal animal in animales)
            {
                animal.Sonido();
            }
            
            //EJERCICIO 2
            List<IVehiculo> vehiculos = new List<IVehiculo>();
            vehiculos.Add(new Auto());
            vehiculos.Add(new Bicicleta());

            foreach (IVehiculo vehiculo in vehiculos)
            {
                vehiculo.Acelerar();
            }

            //EJERCICIO 3
            List<Figura> figuras = new List<Figura>();
            Circulo circulo= new Circulo();
            circulo.radio = 3;
            figuras.Add(circulo);
            
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.baseRectangulo = 4;
            rectangulo.altura= 5;
            figuras.Add(rectangulo);

            foreach (Figura figura in figuras)
            {
                double area = figura.CalcularArea();
                Console.WriteLine("El área de la figura es: " + area);
            }

            //EJERCICIO 4
            List<Empleado> empleados = new List<Empleado>();
            Gerente gerente = new Gerente();
            gerente.nombre = "Juan";
            gerente.salarioBase = 5000;
            gerente.bono = 2000;
            empleados.Add(gerente);
           
            Vendedor vendedor = new Vendedor();
            vendedor.nombre = "Pedro";
            vendedor.salarioBase = 3000;
            vendedor.comision = 1000;
            empleados.Add(vendedor);

            foreach (Empleado empleado in empleados)
            {
                double salario = empleado.CalcularSalario();
                Console.WriteLine("El salario de " + empleado.nombre + " es: " + salario);
            }

            //EJERCICIO 5
            List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();
            instrumentos.Add(new Guitarra());
            instrumentos.Add(new Piano());
            instrumentos.Add(new Bateria());

            foreach (InstrumentoMusical instrumento in instrumentos)
            {
                instrumento.Tocar();
            }


            //EJERCICIO OPCIONAL
            // Crear lista de productos
            List<Producto> productos = new List<Producto>();

            // Agregar objetos de la clase ProductoFisico usando constructor
            ProductoFisico productoFisico1 = new ProductoFisico("Libro", 2500, 2.5m);
            productos.Add(productoFisico1);

            ProductoFisico productoFisico2 = new ProductoFisico("Juguete", 1500, 1.6m);
            productos.Add(productoFisico2);

            // Agregar objetos de la clase ProductoDigital usando constructor
            ProductoDigital productoDigital1 = new ProductoDigital("Software", 15000, 750);
            productos.Add(productoDigital1);

            ProductoDigital productoDigital2 = new ProductoDigital("Música", 150, 55);
            productos.Add(productoDigital2);

            // Imprimir información de cada producto
            foreach (Producto producto in productos)
            {
                Console.WriteLine("Nombre: " + producto.Nombre);
                Console.WriteLine("Precio: $" + producto.Precio);
                Console.WriteLine("Impuesto: $" + producto.CalcularImpuesto());
                Console.WriteLine("Total: $" + producto.CalcularTotal());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
