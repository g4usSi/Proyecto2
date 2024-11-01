using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Biblioteca
    {
        private List<Libro> Libros = new List<Libro>();
        private List<Usuario> Usuarios = new List<Usuario>();
        private List<Prestamo> prestamos = new List<Prestamo>();
        private Queue<Lector> listaEspera = new Queue<Lector>();

        //Modulo 1 Gestion de Libros
        //Agregar Libro
        public void AgregarLibro() 
        {
            Console.Write("Agregar Libro Nuevo");
            Libro libro = new Libro();

        }

        // Busqueda de Libros //
        //Parametros Titulo, Autor
        public Libro BuscarLibroSecuencial()
        {

            return null;
        }



        //BusquedaBinaria
        public Libro BuscarLibroBinario(List<Libro> librosBiblioteca, string ISBN)
        {
            int izquierda = 0;
            int derecha = librosBiblioteca.Count - 1;

            while (izquierda <= derecha)
            {
                int mid = izquierda + (derecha - izquierda) / 2;
                int comparacion = librosBiblioteca[mid].ISBN.CompareTo(ISBN);

                if (comparacion == 0)
                {
                    return librosBiblioteca[mid];
                }
                else if (comparacion < 0)
                {
                    izquierda = mid + 1;
                }
                else
                {
                    derecha = mid - 1;
                }
            }

            return null;
        }
        

        //Modulo 2



        public void OrdenarLibros() 
        { 
            
        }


    }
}
