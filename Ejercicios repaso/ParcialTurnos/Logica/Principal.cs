using Logica.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {

        public List<Turnos> ListaTurnos = new List<Turnos>();

        public void AltaTurnos(DateTime fecha, int duracion, string lugar, string plataforma) 
        {
            TurnoPresencial turnoPresencial = new TurnoPresencial();
            TurnoVirtual turnoVirtual = new TurnoVirtual();
            var contador = ListaTurnos.Count() + 1;

            if (lugar == null) //Si lugar es null, se entiende que no tiene datos y se agrega un turno virtual.
            {
                turnoVirtual.plataforma = plataforma;
                turnoVirtual.duracion = duracion; 
                turnoVirtual.fecha = fecha;
                turnoVirtual.id = contador;
                turnoVirtual.estado= "Habilitado";
                ListaTurnos.Add(turnoVirtual);
            }
            else
            {
                turnoPresencial.lugar = lugar;
                turnoPresencial.duracion = duracion;
                turnoPresencial.fecha = fecha;
                turnoPresencial.id = contador;
                turnoPresencial.estado = "Habilitado";
                ListaTurnos.Add(turnoPresencial);
            }
        }

        public void AltaTurnosVirtuales(DateTime fecha, int duracion, string plataforma)
        {
            TurnoVirtual turnoVirtual = new TurnoVirtual();
            var contador = ListaTurnos.Count() + 1; //Nos genera un id iterando

            turnoVirtual.plataforma = plataforma;
            turnoVirtual.duracion = duracion;
            turnoVirtual.fecha = fecha;
            turnoVirtual.id = contador;
            turnoVirtual.estado = "Habilitado"; //cuando se crea quedo Habilitado
            ListaTurnos.Add(turnoVirtual);
        }

        public void AltaTurnosPresenciales(DateTime fecha, int duracion, string lugar)
        {
            TurnoPresencial turnoPresencial = new TurnoPresencial();
            var contador = ListaTurnos.Count() + 1; //Nos genera un id iterando

            turnoPresencial.lugar = lugar;
            turnoPresencial.duracion = duracion;
            turnoPresencial.fecha = fecha;
            turnoPresencial.id = contador;
            turnoPresencial.estado = "Habilitado"; //cuando se crea quedo Habilitado
            ListaTurnos.Add(turnoPresencial);
        }

        public void BajaTurnoVirtual(int id)
        {
            var turnoVirtualEliminado = ListaTurnos.Find(x => x.id == id); //Buscamos por id para eliminar
            ListaTurnos.Remove(turnoVirtualEliminado);

        }

        public void ModificarTurnoVirtual (int id, string plataforma) 
        {
            TurnoVirtual turnoVirtualNuevo = new TurnoVirtual();
            var turnoVrtualBuscado = ListaTurnos.Find(x => x.id == id); //Buscamos por id para modificar

            turnoVirtualNuevo.plataforma = plataforma;

            turnoVirtualNuevo.duracion = turnoVrtualBuscado.duracion;
            turnoVirtualNuevo.fecha = turnoVrtualBuscado.fecha;
            turnoVirtualNuevo.id = turnoVrtualBuscado.id;

            ListaTurnos.Remove(turnoVrtualBuscado);
            ListaTurnos.Add(turnoVirtualNuevo);
        }

        public void BajaTurnoPresencial(int id)
        {
            var turnoPresencialEliminado = ListaTurnos.Find(x => x.id == id); //Buscamos por id para eliminar
            ListaTurnos.Remove(turnoPresencialEliminado);

        }

        public void ModificarTurnoPresencial(int id, string lugar)
        {
            TurnoPresencial turnoPresencialNuevo = new TurnoPresencial();
            var turnoPresencialBuscado = ListaTurnos.Find(x => x.id == id); //Buscamos por id para modificar

            turnoPresencialNuevo.lugar = lugar;

            turnoPresencialNuevo.duracion = turnoPresencialBuscado.duracion;
            turnoPresencialNuevo.fecha = turnoPresencialBuscado.fecha;
            turnoPresencialNuevo.id = turnoPresencialBuscado.id;

            ListaTurnos.Remove(turnoPresencialBuscado);
            ListaTurnos.Add(turnoPresencialNuevo);
        }

        public void BajaLogicaTurnoVirtual(int id)
        {
            TurnoVirtual turnoVirtualNuevo = new TurnoVirtual();
            var turnoVrtualBuscado = ListaTurnos.Find(x => x.id == id);

            turnoVirtualNuevo.estado = "Deshabilitado";

            //turnoVirtualNuevo.plataforma = turnoVrtualBuscado.plataforma;
            turnoVirtualNuevo.duracion = turnoVrtualBuscado.duracion;
            turnoVirtualNuevo.fecha = turnoVrtualBuscado.fecha;
            turnoVirtualNuevo.id = turnoVrtualBuscado.id;

            ListaTurnos.Remove(turnoVrtualBuscado);
            ListaTurnos.Add(turnoVirtualNuevo);
        }

        public List<Turnos> MostrarListaTurnos() 
        { 
            return ListaTurnos; 
        }

    }
}
