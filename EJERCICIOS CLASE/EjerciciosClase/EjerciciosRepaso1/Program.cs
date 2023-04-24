using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788
                Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo.
                Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados 
                Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras
                Siguiendo con el ejercicio anterior, al ingresar uno mayor o menor a 3 cifras se mostrará el promedio de los ingresados. 

             */

            //1 
            Console.WriteLine("Ingresa una clave");
            string clave;

            do
            {
                clave= Console.ReadLine();
            } while (clave != "667788");

            //2
            Console.WriteLine("Ingresa un numero");
            int nro;

            do
            {
                nro = int.Parse(Console.ReadLine());
            } while (nro > 0);

            //3
            Console.WriteLine("Ingresa un numero");
            int nro1;
            int contador = 0;
            int suma = 0;

            do
            {
                nro1 = int.Parse(Console.ReadLine());
                if (nro1 < 0)
                {
                    contador++;
                    suma = suma + nro1;
                }
                
            } while (nro1 > 0);

            Console.WriteLine("El promedio es: " + suma/contador);
            //4
            Console.WriteLine("Ingresa un numero");
            int nro2;

            do
            {
                nro2 = int.Parse(Console.ReadLine());
            } while (nro2 > 999);
        }
    }
}
