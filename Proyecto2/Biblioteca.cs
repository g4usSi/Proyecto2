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
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Libro> prestamos = new List<Libro>();
        private Queue<Lector> listaEspera = new Queue<Lector>();
        private bool LibrosOrdenados = false; //Libros ordenados

        //Modulo 1 Gestion de Libros
        //Agregar Libro
        public void AgregarLibro() 
        {
            Console.WriteLine("Agregar Libro Nuevo");
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
                Libro libroNuevo = new Libro(titulo, autor, genero, isbn);
                librosBiblioteca.Add(libroNuevo);
                Console.WriteLine("Libro agregado exitosamente.");
                LibrosOrdenados = false;
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
        private string ParametroBuscar() 
        {
            Console.Write("Ingrese el titulo o autor del libro: ");
            string parametro = Console.ReadLine();
            return parametro.ToLower();
        }
        public void MostrarLibroBuscado()
        {
            string parametro = ParametroBuscar();
            //agregar logica si ya estan ordenados
            Libro libroBuscado = BuscarLibroTitAut(librosBiblioteca, parametro);
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
        public Libro BuscarLibroTitAut(List<Libro> librosBiblioteca, string parametro)
        {
            if (parametro == null || parametro == "") return null;

            foreach (var libro in librosBiblioteca)
            {
                if (libro.Titulo.ToLower() == parametro || libro.Autor.ToLower() == parametro)
                {
                    return libro;
                }
            }
            return null;
        }
        public Libro BuscarLibroISBN(List<Libro> librosBiblioteca, string iSBN)
        {
            if (iSBN == null) return null;

            foreach (var libro in librosBiblioteca)
            {
                if (libro.ISBN == iSBN)
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
            Console.WriteLine("Ingrese el ISBN del libro: ");
            string parametro = Console.ReadLine();

            if (!LibroExistente(librosBiblioteca, parametro))
            {
                Console.WriteLine("Error. No hay coincidencias.");
                return;
            }
            Libro libroEliminar = BuscarLibroISBN(librosBiblioteca, parametro);
            libroEliminar.MostrarLibro();

            Console.WriteLine("Seguro desea eliminar el libro de la biblioteca? (S/N)");
            string eliminacion = Console.ReadLine().ToLower();

            if (eliminacion == "s"||eliminacion == "si")
            {
                librosBiblioteca.Remove(libroEliminar);
                Console.WriteLine("El libro se ha eliminado de la lista.");
            }
            else
            {
                Console.WriteLine("El libro sigue en la lista.");
            }
        }

        //Modulo 2 Gestion de Usuarios
        public void RegistrarUsuarioNuevo() 
        {
            Console.WriteLine("1. Bibliotecario\n2. Lector");
            Console.Write("Ingrese una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) 
            {
                case 1:
                    Bibliotecario nuevoBibliotecario = new Bibliotecario();
                    listaUsuarios.Add(nuevoBibliotecario);
                    Console.WriteLine("Se ha agregado al nuevo usuario.");
                    break;
                case 2:
                    Lector nuevoLector = new Lector();
                    listaUsuarios.Add(nuevoLector);
                    Console.WriteLine("Se ha agregado al nuevo usuario.");
                break;
            }
        }
        public void EliminarEditarUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario");
            string nombreUsuario = Console.ReadLine();
            Usuario usuarioModificado = BuscarUsuario(nombreUsuario);
            if (usuarioModificado == null)
            {
                Console.WriteLine("Error. No se ha encontrado al usuario...");
                return;
            }

            Console.WriteLine("1. Editar");
            Console.WriteLine("2. Eliminar");
            Console.Write("Ingrese una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    EditarUsuario(usuarioModificado);
                    Console.WriteLine("Se ha agregado al nuevo usuario.");
                    break;
                case 2:
                    Console.WriteLine("Seguro desea eliminar al usuario? (S/N)");
                    EliminarUsuario(usuarioModificado);
                    Console.WriteLine("Se ha agregado al nuevo usuario.");
                break;
            }
        }

        public void EditarUsuario(Usuario usuarioBuscado)
        {
            Console.WriteLine("Ingrese los nuevos datos a editar...");
            Console.Write("ingrese el nuevo nombre: ");
            usuarioBuscado.ID = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva contraseña: ");
            usuarioBuscado.Password = Console.ReadLine();
            Console.WriteLine("Cambio realizado");
        }
        public void EliminarUsuario(Usuario usuarioBuscado) 
        { 
            listaUsuarios.Remove(usuarioBuscado);
        }

        private Usuario BuscarUsuario(string nombreUsuario) 
        {
            foreach(var usuario in listaUsuarios)
            {
                if(usuario.ID.ToLower() == nombreUsuario.ToLower())
                {
                    return usuario;
                }
            }
            return null;
        }







        public void OrdenarLibros() 
        {

            LibrosOrdenados = true;
        }


    }
}
