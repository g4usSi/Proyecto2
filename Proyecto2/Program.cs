using Proyecto2;
using System.Threading.Channels;
public class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Console.WriteLine("\t\t\t=== Sistema de Biblioteca ===");
        Console.Write("Nombre de usuario: ");
        string nombre = Console.ReadLine();
        Console.Write("Contraseña: ");
        string contrasena = Console.ReadLine();

        if (biblioteca.IniciarSesion(nombre, contrasena))
        {
            if (biblioteca.UsuarioActual is Bibliotecario)
            {
                //MostrarMenuBibliotecario(biblioteca);
            }
            else if (biblioteca.UsuarioActual is Lector)
            {
                //MostrarMenuLector(biblioteca);
            }
        }
        else
        {
            Console.WriteLine("Inicio de sesión fallido. Usuario o contraseña incorrectos.");
        }
    
    //Bibliotecario
    int opcion = 0;
        do
        {
            Menu();
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("--- Gestion Libros ---");
                    switch (GestionLibros(opcion))
                    {
                        case 1:
                            biblioteca.AgregarLibro();
                            break;
                        case 2:
                            biblioteca.MostrarLibroBuscado();
                            break;
                        case 3:
                            biblioteca.EliminarLibro();
                        break;
                    }
                    break;
                case 2:
                    Console.WriteLine("--- Gestion Usuarios ---");;
                    switch (GestionUsuarios(opcion))
                    {
                        case 1:
                            biblioteca.RegistrarUsuarioNuevo();
                            break;
                        case 2:
                            biblioteca.EliminarEditarUsuario();
                        break;
                    }
                    break;
                case 3:
                    Console.WriteLine("--- Gestion Prestamos ---");
                    biblioteca.GestionPrestamos();
                    break;
                case 4:
                    Console.WriteLine("--- Cerrar Sesion ---");
                    
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción no válida. Por favor intente de nuevo.");
                break;
            }
        } while (opcion != 6);
    }
    //Cambiar Menus
    static void Menu() 
    {
        Console.WriteLine("\n\t\t\t\tBIBLIOTECA");
        Console.WriteLine("1. Gestion Libros");
        Console.WriteLine("2. Gestion Usuarios");
        Console.WriteLine("3. Gestion Prestamos");
        Console.WriteLine("4. Salir del Sistema");
        Console.Write("Ingrese una opcion: ");
    }
    static int GestionLibros(int opcion) 
    {
        Console.WriteLine("1. Agregar libro nuevo");
        Console.WriteLine("2. Buscar libro");
        Console.WriteLine("3. Eliminar libro");
        Console.Write("Ingrese una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());
        return opcion;
        
    }
    static int GestionUsuarios(int opcion)
    {
        Console.WriteLine("1. Registrar nuevo usuario");
        Console.WriteLine("2. Editar o eliminar usuario");
        Console.Write("Ingrese una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());
        return opcion;
    }    static int GestionPrestamos(int opcion)
    {
        Console.WriteLine("1. Solicitar Libro");
        Console.WriteLine("2. Devolver Libro");
        Console.Write("Ingrese una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());
        return opcion;
    }
    //Lector logica
}
