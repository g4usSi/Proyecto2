using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string ISBN { get; set; }
        public bool Disponible { get; set; }
        public int ContadorPrestamos { get; set; }

        //metodo de agregacion
        public Libro(string titulo, string autor, string genero, string isbn, bool disponible = true, int contadorPrestamo = 0)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            ISBN = isbn;
            Disponible = disponible;
            ContadorPrestamos = contadorPrestamo;
        }
        //select textbox
        public void EditarLibro(string nuevoTitulo = null, string nuevoAutor = null, string nuevoGenero = null, string nuevoISBN = null)
        {
            if (!string.IsNullOrEmpty(nuevoTitulo))
            {
                this.Titulo = nuevoTitulo;
            }

            if (!string.IsNullOrEmpty(nuevoAutor))
            {
                this.Autor = nuevoAutor;
            }

            if (!string.IsNullOrEmpty(nuevoGenero))
            {
                this.Genero = nuevoGenero;
            }

            if (!string.IsNullOrEmpty(nuevoISBN))
            {
                this.ISBN = nuevoISBN;
            }
        }
        public void MostrarLibro()
        {
            Console.WriteLine( $"Titulo: {Titulo} \nAutor: {Autor} \nGenero: {Genero}\nISBN: {ISBN}\nDisponible: {Disponible}");
        }

        public void AumentarContadorPrestamo()
        {
            ContadorPrestamos++;
        }
        public void CambiarDisponibilidad()
        {
            Disponible = !Disponible;
        }




    }
}
