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
        private List<Libro> librosBiblioteca = new List<Libro>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Prestamo> prestamos = new List<Prestamo>();
        private Queue<Lector> listaEspera = new Queue<Lector>();
        private bool Ordenados = false; //Libros ordenados

        //Modulo 1 Gestion de Libros
        //Agregar Libro
        public void AgregarLibro() 
        {
            Console.Write("Agregar Libro Nuevo");
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Genero: ");
            string genero = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();

            if (!LibroExistente(librosBiblioteca, isbn))
            {
                Libro libro = new Libro(titulo, autor, genero, isbn);
                Console.WriteLine("Libro agregado exitosamente.");
                Ordenados = false;
            }
            else
            {
                Console.WriteLine("Error. Ya existe un libro con el mismo ISBN.");
            }
        }

        private bool LibroExistente(List<Libro> librosBiblioteca, string ISBN)
        {
            return librosBiblioteca.Any(libro => libro.ISBN == ISBN);
        }
        // ***** Busqueda de Libros ***** //
        //Metodo de introduccion de datos
        public string ParametroBuscar() 
        {
            Console.Write("Ingrese el titulo o autor del libro: ");
            string parametro = Console.ReadLine();
            return parametro;
        }
        public void MostrarLibroBuscado()
        {
            string parametro = ParametroBuscar();
            //agregar logica si ya estan ordenados
            Libro libroBuscado = BuscarLibro(librosBiblioteca, parametro);
            if (libroBuscado != null)
            {
                libroBuscado.MostrarLibro();
            }
            else 
            {
                Console.WriteLine("Error. No hay coincidencias.");
            }
            
        }

        //Secuencial (Muy importante UwU)
        public Libro BuscarLibro(List<Libro> librosBiblioteca, string parametro)
        {
            if (parametro == null || parametro == "") return null;

            foreach (var libro in librosBiblioteca)
            {
                if (libro.Titulo == parametro || libro.Autor == parametro)
                {
                    return libro;
                }
            }
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
        //Eliminar Libro
        public void EliminarLibro()
        {


        }

        //Modulo 2



        public void OrdenarLibros() 
        {

            Ordenados = true;
        }


    }
}
