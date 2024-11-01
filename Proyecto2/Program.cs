using Proyecto2;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        //agregar logica de usuarios
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
                    Console.WriteLine("--- Gestion Usuarios ---");
                    Console.WriteLine("Ingrese el nombre del usuario");
                    string nombreUsuario = Console.ReadLine();
                    Usuario usuarioModificado = biblioteca.BuscarUsuario(nombreUsuario);
                    if (usuarioModificado == null)
                    {
                        Console.WriteLine("Error. No se ha encontrado al usuario...");
                        return;
                    }
                    switch (GestionUsuarios(opcion))
                    {
                        case 1:
                            biblioteca.EditarUsuario(usuarioModificado);
                            break;
                        case 2:
                            biblioteca.EliminarUsuario(usuarioModificado);
                        break;
                    }

                    break;
                case 3:
                    Console.WriteLine("--- Gestion Prestamos ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea buscar: ");

                    break;
                case 4:
                    Console.WriteLine("--- Cerrar Sesion ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea actualizar: ");
                    
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción no válida. Por favor intente de nuevo.");
                break;
            }
        } while (opcion != 5);
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
    }
    static void GestionPrestamos()
    {


    }

}
