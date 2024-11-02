using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    namespace Proyecto2
    {
        public class Prestamo
        {
            public DateTime FechaPrestamo { get; private set; }
            public Libro LibroPrestado { get; private set; }
            public Lector LectorPrestamo { get; private set; }

            public Prestamo(Libro libro, Lector lector)
            {
                FechaPrestamo = DateTime.Now;
                LibroPrestado = libro;
                LectorPrestamo = lector;
                libro.Disponible = false;
                LectorPrestamo.SolicitarLibro(libro);
            }

            public void DevolverLibro()
            {
                LibroPrestado.Disponible = true;
                Console.WriteLine("El libro ha sido devuelto correctamente.");
                LectorPrestamo.DevolverLibro();
            }
            public void MostrarPrestamo() 
            {
                Console.WriteLine($"Fecha: {FechaPrestamo}, Libro:{LibroPrestado.Titulo}, Lector: {LectorPrestamo.ID}");
            }
        }
    }
}
