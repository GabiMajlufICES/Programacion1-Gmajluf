using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        public ApplicationDbContext baseDatos = new ApplicationDbContext();
        public void AgregarCliente(Cliente nuevoCliente)
        {
            baseDatos.Clientes.Add(nuevoCliente);
            baseDatos.SaveChanges();
        }
        public string AgregarCuentaBancaria(string tipo, int dniCliente)
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria();

            var clienteEncontrado = baseDatos.Clientes.FirstOrDefault(x =>x.dni== dniCliente);

            if (clienteEncontrado != null)
            {
                cuentaBancaria.saldo = 0;
                cuentaBancaria.clienteCB = clienteEncontrado;
                //Asigno el nombre y apellido del cliente encontrado para poder tenerlo en el FRONT.
                cuentaBancaria.nombreCliente = clienteEncontrado.nombre + ", " + clienteEncontrado.apellido;
                
                cuentaBancaria.tipo = tipo;

                var nroCuenta = (clienteEncontrado.dni).ToString();

                if (tipo == "CC") //Valido tipos.
                {
                    nroCuenta = nroCuenta + "1111";
                }
                else if (tipo == "CA")
                {
                    nroCuenta = nroCuenta + "2222";
                }
                else
                {
                    nroCuenta = nroCuenta + "3333";
                }
                cuentaBancaria.numeroCuenta = long.Parse(nroCuenta);

                var cuentaEncontrada = baseDatos.CuentasBancarias.FirstOrDefault(x => x.numeroCuenta == cuentaBancaria.numeroCuenta);

                if (cuentaEncontrada == null) //Valido que no exista la cuenta.
                {
                    baseDatos.CuentasBancarias.Add(cuentaBancaria);
                    baseDatos.SaveChanges();
                    return "Cuenta agregada con exito";
                }
                else
                {
                    return "La cuenta para este cliente ya existe";
                }                
            }
            else
            {
                return "Cliente no encontrado";
            }
        }


        //public void EmitirTarjetaCredito(int clienteId, TarjetaCredito nuevaTarjeta)
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        var cliente = context.Clientes.Include(c => c.TarjetasCredito).FirstOrDefault(c => c.Id == clienteId);
        //        if (cliente != null)
        //        {
        //            cliente.TarjetasCredito.Add(nuevaTarjeta);
        //            context.SaveChanges();
        //        }
        //    }
        //}

        public void RealizarDeposito(int cuentaId, decimal monto)
        {
            using (var context = new ApplicationDbContext())
            {
                var cuenta = context.CuentasBancarias.FirstOrDefault(c => c.id == cuentaId);
                if (cuenta != null)
                {
                    decimal saldoCuenta = (decimal)cuenta.saldo; // Convierte el saldo a decimal
                    saldoCuenta += monto; // Realiza la suma en decimal
                    cuenta.saldo = (float)saldoCuenta; // Convierte el resultado de nuevo a float
                    context.SaveChanges();
                }
            }
        }

        public void RealizarExtraccion(int cuentaId, decimal monto)
        {
            using (var context = new ApplicationDbContext())
            {
                var cuenta = context.CuentasBancarias.FirstOrDefault(c => c.id == cuentaId);
                if (cuenta != null)
                {
                    decimal saldoCuenta = (decimal)cuenta.saldo; // Convierte el saldo a decimal
                    if (saldoCuenta >= monto)
                    {
                        saldoCuenta -= monto; // Realiza la resta en decimal
                        cuenta.saldo = (float)saldoCuenta; // Convierte el resultado de nuevo a float
                        context.SaveChanges();
                    }
                }
            }
        }


        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, decimal monto)
        {
            using (var context = new ApplicationDbContext())
            {
                var cuentaOrigen = context.CuentasBancarias.FirstOrDefault(c => c.id == cuentaOrigenId);
                var cuentaDestino = context.CuentasBancarias.FirstOrDefault(c => c.id == cuentaDestinoId);
                
                decimal saldoOrigen = (decimal)cuentaOrigen.saldo;// Convierte el saldo de la cuenta origen a decimal

                if (cuentaOrigen != null && cuentaDestino != null && saldoOrigen >= monto)
                {         
                    decimal saldoDestino = (decimal)cuentaDestino.saldo; // Convierte el saldo de la cuenta destino a decimal

                    saldoOrigen -= monto; // Resta el monto de la cuenta origen en decimal
                    saldoDestino += monto; // Suma el monto a la cuenta destino en decimal

                    cuentaOrigen.saldo = (float)saldoOrigen; // Convierte el saldo de nuevo a float en la cuenta origen
                    cuentaDestino.saldo = (float)saldoDestino; // Convierte el saldo de nuevo a float en la cuenta destino

                    context.SaveChanges();
                }
            }
        }


        public void PagarTarjetaCredito(int tarjetaId, decimal monto)
        {
            using (var context = new ApplicationDbContext())
            {
                var tarjeta = context.TarjetaCredito.FirstOrDefault(t => t.id == tarjetaId);

                decimal saldoTarjeta = (decimal)tarjeta.saldoActual; // Convierte el saldo de la tarjeta a decimal

                if (tarjeta != null && saldoTarjeta >= monto)
                {
                    saldoTarjeta -= monto; // Resta el monto del saldo en decimal

                    tarjeta.saldoActual = (float)saldoTarjeta; // Asigna el saldo actual de nuevo como decimal
                    context.SaveChanges();
                }
            }
        }


        public void GenerarResumenTarjeta(int tarjetaId)
        {
            using (var context = new ApplicationDbContext())
            {
                var tarjeta = context.TarjetaCredito.FirstOrDefault(t => t.id == tarjetaId);
                if (tarjeta != null)
                {
                    Console.WriteLine($"Resumen de Tarjeta de Crédito - Número de Tarjeta: {tarjeta.numeroTarjeta}");
                    Console.WriteLine($"Saldo Actual: {tarjeta.saldoActual:C}");
                    Console.WriteLine($"Límite de Crédito: {tarjeta.limiteCredito:C}");
                    Console.WriteLine($"Total a Pagar: {tarjeta.limiteCredito - tarjeta.saldoActual:C}");
                }
            }
        }
    }
}
