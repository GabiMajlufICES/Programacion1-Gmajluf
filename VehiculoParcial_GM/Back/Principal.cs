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
        //Otra manera de hacer el alta que se completa igual a la primera en el front.
        public void AltaVehiculoAutomovil2daManera(VehiculoAutomovil vehiculoAutomovilParametro)
        {
            ListaVehiculoAutomovil.Add(vehiculoAutomovilParametro);
        }
        //Otra manera de hacer el alta que se completa diferente en el front.
        public void AltaVehiculoAutomovil3erManera(string patenteP, string marcaP, string modeloP, decimal precioP, int nropuertasP, int nroasientosP) 
        {
            VehiculoAutomovil vehiculoAutomovilNuevo = new VehiculoAutomovil();
            vehiculoAutomovilNuevo.patente = patenteP;
            vehiculoAutomovilNuevo.marca = marcaP;
            vehiculoAutomovilNuevo.modelo = modeloP;
            vehiculoAutomovilNuevo.precioXDia = precioP;
            vehiculoAutomovilNuevo.nroPuertas = nropuertasP;
            vehiculoAutomovilNuevo.nroAsientos = nroasientosP;
            ListaVehiculoAutomovil.Add(vehiculoAutomovilNuevo);
        }
        //Si seleccionan en una lista un objeto a borrar, se usa el metodo de abajo.
        public void BajaVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilParametro) 
        {
            ListaVehiculoAutomovil.Remove(vehiculoAutomovilParametro);
        }
        //Si piden que se ingrese una patente a borrar, se usa el metodo de abajo.
        public void BajaVehiculoAutomovil2daManera(string patenteAEliminar)
        {
            var elementoEliminado = ListaVehiculoAutomovil.Find(x => x.patente == patenteAEliminar);
            ListaVehiculoAutomovil.Remove(elementoEliminado);
        }
        //Este metodo se usa cuando seleccionamos un objeto ded la lista y lo eliminamos, agregando el nuevo.
        public void ModificarVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilNuevo, VehiculoAutomovil vehiculoAutomovilEliminar) 
        {           
            VehiculoAutomovil vehiculoAutomovilModificado = new VehiculoAutomovil();
            
            vehiculoAutomovilModificado.patente = vehiculoAutomovilNuevo.patente;
            vehiculoAutomovilModificado.marca = vehiculoAutomovilNuevo.marca;
            vehiculoAutomovilModificado.modelo = vehiculoAutomovilNuevo.modelo;
            vehiculoAutomovilModificado.precioXDia = vehiculoAutomovilNuevo.precioXDia;
            vehiculoAutomovilModificado.nroPuertas = vehiculoAutomovilNuevo.nroPuertas;
            vehiculoAutomovilModificado.nroAsientos = vehiculoAutomovilNuevo.nroAsientos;

            ListaVehiculoAutomovil.Remove(vehiculoAutomovilEliminar);

            ListaVehiculoAutomovil.Add(vehiculoAutomovilModificado);
        }

        public void ModificarVehiculoAutomovil2daManera(VehiculoAutomovil vehiculoAutomovilNuevo)
        {
            //Busco el elemento a eliminar por patente
            var elementoEliminado = ListaVehiculoAutomovil.Find(x => x.patente == vehiculoAutomovilNuevo.patente);

            ListaVehiculoAutomovil.Remove(elementoEliminado);
            ListaVehiculoAutomovil.Add(vehiculoAutomovilNuevo);
        }
        //Esta manera es solamente cuando queremos modificar en este caso la patente y la marca
        public void ModificarVehiculoAutomovil3erManera(VehiculoAutomovil vehiculoAutomovilNuevo)
        {
            //Busco el elemento a eliminar por patente
            var elementoEliminado = ListaVehiculoAutomovil.Find(x => x.patente == vehiculoAutomovilNuevo.patente);

            VehiculoAutomovil vehiculoAutomovilModificado = new VehiculoAutomovil();

            vehiculoAutomovilModificado.patente = vehiculoAutomovilNuevo.patente;
            vehiculoAutomovilModificado.marca = vehiculoAutomovilNuevo.marca;

            vehiculoAutomovilModificado.modelo = elementoEliminado.modelo;
            vehiculoAutomovilModificado.precioXDia = elementoEliminado.precioXDia;
            vehiculoAutomovilModificado.nroPuertas = elementoEliminado.nroPuertas;
            vehiculoAutomovilModificado.nroAsientos = elementoEliminado.nroAsientos;

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
