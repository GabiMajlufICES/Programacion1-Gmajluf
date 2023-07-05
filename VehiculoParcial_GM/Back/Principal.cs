using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        public List<VehiculoAutomovil> ListaVehiculoAutomovil = new List<VehiculoAutomovil>();
        public List<VehiculoCamioneta> ListaVehiculoCamioneta = new List<VehiculoCamioneta>();

        public void AltaVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilParametro) 
        {
            VehiculoAutomovil vehiculoAutomovil = new VehiculoAutomovil();
            vehiculoAutomovil.patente = vehiculoAutomovilParametro.patente;
            vehiculoAutomovil.marca = vehiculoAutomovilParametro.marca;
            vehiculoAutomovil.modelo = vehiculoAutomovilParametro.modelo;
            vehiculoAutomovil.precioXDia = vehiculoAutomovilParametro.precioXDia;
            vehiculoAutomovil.nroPuertas = vehiculoAutomovilParametro.nroPuertas;
            vehiculoAutomovil.nroAsientos = vehiculoAutomovilParametro.nroAsientos;

            ListaVehiculoAutomovil.Add(vehiculoAutomovil);
        }
        //Si seleccionan en una lista un objeto a borrar, se usa el metodo de abajo.
        public void BajaVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilParametro) 
        {
            ListaVehiculoAutomovil.Remove(vehiculoAutomovilParametro);
        }
        //Si piden que se ingrese una patente a borrar, se usa el metodo de abajo.
        public void BajaVehiculoAutomovil(string vehiculoAutomoviEliminar)
        {
            var elementoEliminado = ListaVehiculoAutomovil.Find(x => x.patente == vehiculoAutomoviEliminar);
        }

        public void ModificarVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilNuevo) 
        {
            //Busco el elemento a eliminar por patente
            var elementoEliminado = ListaVehiculoAutomovil.Find(x => x.patente == vehiculoAutomovilNuevo.patente);
            
            VehiculoAutomovil vehiculoAutomovilModificado = new VehiculoAutomovil();
            
            vehiculoAutomovilModificado.patente = vehiculoAutomovilNuevo.patente;
            vehiculoAutomovilModificado.marca = vehiculoAutomovilNuevo.marca;
            vehiculoAutomovilModificado.modelo = vehiculoAutomovilNuevo.modelo;
            vehiculoAutomovilModificado.precioXDia = vehiculoAutomovilNuevo.precioXDia;
            vehiculoAutomovilModificado.nroPuertas = vehiculoAutomovilNuevo.nroPuertas;
            vehiculoAutomovilModificado.nroAsientos = vehiculoAutomovilNuevo.nroAsientos;
            
            ListaVehiculoAutomovil.Remove(elementoEliminado);
            ListaVehiculoAutomovil.Add(vehiculoAutomovilModificado);
        }
        public void AltaVehiculoCamioneta(VehiculoCamioneta vehiculoCamionetaParametro)
        {
            VehiculoCamioneta vehiculoCamioneta = new VehiculoCamioneta();
            vehiculoCamioneta.patente = vehiculoCamionetaParametro.patente;
            vehiculoCamioneta.marca = vehiculoCamionetaParametro.marca;
            vehiculoCamioneta.modelo = vehiculoCamionetaParametro.modelo;
            vehiculoCamioneta.precioXDia = vehiculoCamionetaParametro.precioXDia;
            vehiculoCamioneta.cantidadCarga = vehiculoCamionetaParametro.cantidadCarga;

            ListaVehiculoCamioneta.Add(vehiculoCamioneta);
        }

        //Si seleccionan en una lista un objeto a borrar, se usa el metodo de abajo.
        public void BajaVehiculoCamioneta(VehiculoCamioneta vehiculoCamionetaParametro)
        {
            ListaVehiculoCamioneta.Remove(vehiculoCamionetaParametro);
        }
        //Si piden que se ingrese una patente a borrar, se usa el metodo de abajo.
        public void BajaVehiculoCamioneta(string vehiculoCamionetaEliminar)
        {
            var elementoEliminado = ListaVehiculoCamioneta.Find(x => x.patente == vehiculoCamionetaEliminar);
        }

        public void ModificarVehiculoCamioneta(VehiculoCamioneta vehiculoCamionetaNuevo)
        {
            //Busco el elemento a eliminar por patente
            var elementoEliminado = ListaVehiculoCamioneta.Find(x => x.patente == vehiculoCamionetaNuevo.patente);

            VehiculoCamioneta vehiculoCamionetaModificado = new VehiculoCamioneta();

            vehiculoCamionetaModificado.patente = vehiculoCamionetaNuevo.patente;
            vehiculoCamionetaModificado.marca = vehiculoCamionetaNuevo.marca;
            vehiculoCamionetaModificado.modelo = vehiculoCamionetaNuevo.modelo;
            vehiculoCamionetaModificado.precioXDia = vehiculoCamionetaNuevo.precioXDia;
            vehiculoCamionetaModificado.cantidadCarga = vehiculoCamionetaNuevo.cantidadCarga;


            ListaVehiculoCamioneta.Remove(elementoEliminado);
            ListaVehiculoCamioneta.Add(vehiculoCamionetaModificado);
        }

    }
}
