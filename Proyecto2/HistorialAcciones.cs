using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class AccionBiblioteca
    {
        public string TipoAccion { get; set; } //"Prestamo", "Devolucion"
        public Libro LibroInvolucrado { get; set; }

        public AccionBiblioteca(string tipoAccion, Libro libro)
        {
            TipoAccion = tipoAccion;
            LibroInvolucrado = libro;
        }
        public string ObtenerDescripcion()
        {
            return $"{TipoAccion} del libro '{LibroInvolucrado.Titulo}'";
        }
    }

    public class HistorialAcciones
    {
        private Stack<AccionBiblioteca> historial;

        public HistorialAcciones()
        {
            historial = new Stack<AccionBiblioteca>();
        }

        public void RegistrarAccion(AccionBiblioteca accion)
        {
            historial.Push(accion);
        }

        public AccionBiblioteca DeshacerUltimaAccion()
        {
            if (historial.Count > 0)
            {
                AccionBiblioteca ultimaAccion = historial.Pop();
                Console.WriteLine($"Se deshizo la última acción: {ultimaAccion.ObtenerDescripcion()}.");
                return ultimaAccion;
            }

            Console.WriteLine("No hay acciones para deshacer.");
            return null;
        }

        public void LimpiarHistorial()
        {
            historial.Clear();
        }
    }
    public class SolicitudEspera
    {
        public Lector Lector { get; private set; }
        public Libro LibroSolicitado { get; private set; }

        public SolicitudEspera(Lector lector, Libro libroSolicitado)
        {
            Lector = lector;
            LibroSolicitado = libroSolicitado;
        }
    }


}
