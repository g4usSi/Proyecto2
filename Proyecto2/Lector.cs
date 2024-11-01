using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Lector : Usuario
    {
        public Libro LibroLigado;
        public Lector() : base()
        {
            this.Rol = "Lector";
            this.LibroLigado = null;
        }
        public override void MostrarUsuario(Usuario usuario)
        {
            base.MostrarUsuario(usuario);
            Console.Write($"Libro ligado: ");
            LibroLigado.MostrarLibro();
        }
        //Lo unico que hara es llevarse el libro, no administrar la lista LeL
        public void SolicitarLibro(Libro libroPrestar) 
        {
            libroPrestar.CambiarDisponibilidad();
            libroPrestar.AumentarContadorPrestamo();
            this.LibroLigado = libroPrestar;
        }
        public void DevolverLibro() 
        {
            
            this.LibroLigado = null;
        }

    }
}
