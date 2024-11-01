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
        public int ContadorPrestamo { get; set; }
        
        //metodo de agregacion
        //
        public Libro(string titulo = null, string autor = null, string genero = null, string iSBN = null, bool disponible = true, int contadorPrestamo = 0)
        {
            Console.Write("Titulo: ");
            Titulo = titulo;
            Console.Write("Autor: ");
            Autor = autor;
            Console.Write("Genero: ");
            Genero = genero;
            Console.Write("ISBN: ");
            ISBN = iSBN;
            Disponible = disponible;
            ContadorPrestamo = contadorPrestamo;
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
            Console.WriteLine($"Titulo: {Titulo} Autor: {Autor} Genero: {Genero}\nISBN: {ISBN}");
        }

        public void AumentarContadorPrestamo() 
        {
            ContadorPrestamo++;
        }
        public void CambiarDisponibilidad()
        {
            Disponible = !Disponible;
        }




    }
}
